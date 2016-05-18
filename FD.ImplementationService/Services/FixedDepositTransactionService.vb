Imports FD.ViewModels
Imports FD.Common
Imports FD.DataAccessObject
Imports FD.BusinessLogic
Imports System
Public Class FixedDepositTransactionService : Implements IFixedDepositTransactionService
    Public Function Save(ByVal fdViewModel As FixedDepositViewModel) As RecordUpdateResult Implements IFixedDepositTransactionService.Save
        Try
            Dim MembersBalance As Decimal
            Using cmdFD As New FdDAO
                Dim FixedDepositRecord As New FD.DataAccessObject.Fd
                With FixedDepositRecord
                    If fdViewModel.TransactionCode = TransactionCode.CheckDeposit Then
                        fdViewModel.Remarks = String.Format("CHK:{0}-{1}  {3}", fdViewModel.BankCode, fdViewModel.CheckNumber, fdViewModel.Remarks)
                    End If
                    .KBCI_NO = fdViewModel.KbciNumber
                    .TRAN_CODE = fdViewModel.TransactionCode
                    .DATE = fdViewModel.TransactionDate
                    .REF = fdViewModel.ReferenceNumber
                    .AMOUNT = fdViewModel.TransactedAmount
                    .BALANCE = fdViewModel.Balance
                    .RMK = fdViewModel.Remarks
                    .ADD_DATE = fdViewModel.DateAdded
                    .USER = fdViewModel.User
                    .LPOSTED = fdViewModel.PrintLineNumber
                    .DRCR = fdViewModel.TransactionType
                    .BANK_CODE = fdViewModel.BankCode
                    .CHECKNO = fdViewModel.CheckNumber
                    .TPOSTED = fdViewModel.IsTransactionPosted
                    .TREVERSED = fdViewModel.IsTransactionReversed
                End With
                MembersBalance = UpdateRecordsAndCalculateBalanceForAdjustments(fdViewModel)
                cmdFD.Save(FixedDepositRecord)
            End Using
            Using cmdMembersDao As New MembersDAO
                Dim memberRecord As Members
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", fdViewModel.KbciNumber)
                memberRecord = cmdMembersDao.Find(param1)
                If Not memberRecord Is Nothing Then
                    memberRecord.FD_AMOUNT = MembersBalance
                    cmdMembersDao.Save(memberRecord)
                End If
            End Using
            Return RecordUpdateResult.UpdateSuccessful
        Catch ex As Exception
            Return RecordUpdateResult.Unsuccessful
        End Try
    End Function

    Public Function Validate(ByVal fdViewModel As FixedDepositViewModel) As FixedDepositTransactionValidationResult Implements IFixedDepositTransactionService.Validate
        With fdViewModel
            If .Remarks.Trim = String.Empty And .TransactionCode <> TransactionCode.CheckDeposit Then
                Return FixedDepositTransactionValidationResult.MissingRemarks ' MsgBox("")
            End If

            Select Case .TransactionCode
                Case TransactionCode.CheckDeposit
                    If .BankCode.Trim = "" Then Return FixedDepositTransactionValidationResult.MissingBankCode
                    If .CheckNumber.Trim = "" Then Return FixedDepositTransactionValidationResult.MissingCheckNumber
                Case TransactionCode.Adjustment
                    If .TransactionType = String.Empty Then Return FixedDepositTransactionValidationResult.MissingTransactionCode
            End Select
            If .TransactedAmount < 1 Then Return FixedDepositTransactionValidationResult.InvalidAmount 
            If .Balance < 0 Then Return FixedDepositTransactionValidationResult.InsufficientFunds
            If .TransactedAmount > 9999999.99 Or .Balance > 9999999.99 Then Return FixedDepositTransactionValidationResult.ArithmeticOverflow

        End With
        Return FixedDepositTransactionValidationResult.Valid
    End Function


    Public Function GetMemberTransactions(ByVal kbciNumber As String) As List(Of FixedDepositViewModel) Implements IFixedDepositTransactionService.GetMemberTransactions
        Dim TransactionList As List(Of FD.DataAccessObject.Fd)
        Dim TranCodeList As List(Of Trancode)
        Using fixedDepositDao As New FdDAO
            Using txnCodeDao As New TrancodeDAO
                TranCodeList = txnCodeDao.GetAll()
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", kbciNumber)
                TransactionList = fixedDepositDao.FindAll(param1).OrderBy(Function(x) x.DATE).ThenBy(Function(y) y.FD_ID).ThenBy(Function(z) z.REF).ToList


                Return (From txnList In TransactionList _
                        Join txnCodeList In TranCodeList _
                            On txnList.TRAN_CODE.Trim Equals txnCodeList.TR_ID _
                        Select New FixedDepositViewModel() With {.Balance = txnList.BALANCE, _
                                                                        .BankCode = txnList.BANK_CODE, _
                                                                        .CheckNumber = txnList.CHECKNO, _
                                                                        .DateAdded = txnList.ADD_DATE, _
                                                                        .PrintLineNumber = txnList.LPOSTED, _
                                                                        .IsTransactionPosted = txnList.TPOSTED, _
                                                                        .IsTransactionReversed = txnList.TREVERSED, _
                                                                        .KbciNumber = txnList.KBCI_NO, _
                                                                        .ReferenceNumber = txnList.REF, _
                                                                        .Remarks = txnList.RMK, _
                                                                        .TransactedAmount = txnList.AMOUNT, _
                                                                        .TransactionCode = txnCodeList.TR_CODE, _
                                                                        .TransactionDate = txnList.DATE, _
                                                                        .TransactionType = txnList.DRCR, _
                                                                        .User = txnList.USER, _
                                                                        .Id = txnList.FD_ID}).ToList

            End Using
        End Using        
    End Function



    Private Function UpdateRecordsAndCalculateBalanceForAdjustments(ByRef fdViewModel As FixedDepositViewModel) As Decimal
        Dim newBalance As Decimal = 0
        Dim updatedAmount As Decimal = 0
        Dim updatedBalance As Decimal = 0
        Dim fdBalance As Decimal = 0
        Dim getNewBalance As Boolean = False

        If fdViewModel.TransactionCode = TransactionCode.Adjustment Then
            Using rsFixedDeposit As New FdDAO
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", fdViewModel.KbciNumber)
                Dim param2 As New LUNA.LunaSearchParameter("[DATE]", fdViewModel.DateAdded, ">")
                Dim FdList As List(Of FD.DataAccessObject.Fd)

                FdList = rsFixedDeposit.FindAll(param1).OrderBy(Function(x) x.DATE).ThenBy(Function(y) y.FD_ID).ThenBy(Function(z) z.REF).ToList

                If FdList.Any Then
                    With FdList.First()
                        If .DRCR = TransactionType.Credit Then
                            fdViewModel.Balance = .BALANCE - .AMOUNT
                        Else
                            fdViewModel.Balance = .BALANCE + .AMOUNT
                        End If
                        If fdViewModel.TransactionType = TransactionType.Credit Then
                            fdViewModel.Balance = fdViewModel.Balance + fdViewModel.TransactedAmount
                        Else
                            fdViewModel.Balance = fdViewModel.Balance - fdViewModel.TransactedAmount
                        End If
                        newBalance = fdViewModel.Balance
                        For Each item In FdList
                            If item.DRCR = TransactionType.Debit Then
                                updatedBalance = newBalance - item.AMOUNT
                                newBalance = updatedBalance
                            Else
                                updatedBalance = newBalance + item.AMOUNT
                                newBalance = updatedBalance
                            End If
                            item.BALANCE = updatedBalance
                            item.TPOSTED = False
                            item.Save()
                        Next
                    End With
                    getNewBalance = True
                End If
            End Using
        End If
        If getNewBalance Then fdBalance = updatedBalance Else fdBalance = fdViewModel.Balance
        Return fdBalance
    End Function

    Public Function GetTransactionCodes() As List(Of TransactionCodeViewModel) Implements IFixedDepositTransactionService.GetTransactionCodes
        Using txnCodeDao As New TrancodeDAO
            Return txnCodeDao.GetAll().Select(Function(x) New TransactionCodeViewModel With {.TransactionID = x.TR_ID, .TransactionCode = x.TR_CODE}).ToList
        End Using
    End Function

    Public Function UpdatedPassbookPosting(ByVal id As String, ByVal isPrinted As String) As RecordUpdateResult Implements IFixedDepositTransactionService.UpdatedPassbookPosting
        Using cmdFixedDeposit As New FdDAO
            Dim param1 As New LUNA.LunaSearchParameter("FD_ID", id)
            Dim FixedDepositTxn = cmdFixedDeposit.Find(param1)

            If Not FixedDepositTxn Is Nothing Then
                FixedDepositTxn.LPOSTED = Integer.Parse(isPrinted)
                FixedDepositTxn.Save()
                Return RecordUpdateResult.UpdateSuccessful
            End If
            Return RecordUpdateResult.Unsuccessful
        End Using
    End Function

End Class
