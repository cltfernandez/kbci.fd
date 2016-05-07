Imports FD.ViewModels
Imports FD.Common
Imports FD.DataAccessObject
Imports FD.BusinessLogic
Imports System
Public Class FixedDepositTransactionService : Implements IFixedDepositTransactionService
    Public Function Save(ByVal fdViewModel As FixedDepositViewModel, ByVal MembersBalance As Decimal) As RecordUpdateResult Implements IFixedDepositTransactionService.Save
        Try
            Using cmdFD As New FdDAO
                Dim FixedDepositRecord As New FD.DataAccessObject.Fd

                With FixedDepositRecord
                    .KBCI_NO = fdViewModel.KBCI_NO
                    .TRAN_CODE = fdViewModel.TRAN_CODE
                    .DATE = fdViewModel.DATE
                    .REF = fdViewModel.REF
                    .AMOUNT = fdViewModel.AMOUNT
                    .BALANCE = fdViewModel.BALANCE
                    .RMK = fdViewModel.RMK
                    .ADD_DATE = fdViewModel.ADD_DATE
                    .USER = fdViewModel.USER
                    .LPOSTED = fdViewModel.LPOSTED
                    .DRCR = fdViewModel.DRCR
                    .BANK_CODE = fdViewModel.BANK_CODE
                    .CHECKNO = fdViewModel.CHECKNO
                    .TPOSTED = fdViewModel.TPOSTED
                    .TREVERSED = fdViewModel.TREVERSED
                End With
                cmdFD.Save(FixedDepositRecord)
            End Using
            Using cmdMembersDao As New MembersDAO
                Dim memberRecord As Members
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", fdViewModel.KBCI_NO)
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

    Public Function Validate(ByVal fdViewModel As FixedDepositViewModel, ByVal FixedDepositAmount As Decimal) As FixedDepositTransactionValidationResult
        'With fdViewModel
        '    If .RMK.Trim = String.Empty Then

        '        Return FixedDepositTransactionValidationResult.MissingRemarks ' MsgBox("Put remarks for this transaction.")
        '    End If

        '    Select Case .TRAN_CODE
        '        Case TransactionCode.CheckDeposit
        '            If .BANK_CODE.Trim = "" Then Return FixedDepositTransactionValidationResult.MissingBankCode ' MsgBox("Please set the corresponding Bank Code for the check.") : Exit Function
        '            If .CHECKNO.Trim = "" Then Return FixedDepositTransactionValidationResult.MissingCheckNumber ' MsgBox("Please set the corresponding Check No. of the check.") : Exit Function
        '            .RMK = String.Format("CHK:{0}-{1}", .BANK_CODE, .CHECKNO)
        '        Case TransactionCode.Adjustment
        '            If .DRCR = String.Empty Then Return FixedDepositTransactionValidationResult.MissingTransactionCode '  MsgBox("Please select a DR/CR code.", MsgBoxStyle.Information, "Error") : Exit Function
        '    End Select
        '    If .AMOUNT < 1 Then Return FixedDepositTransactionValidationResult.InvalidAmount 'MsgBox("Please check the amount.") : Exit Function

        '    If .BALANCE < 0 Then Return FixedDepositTransactionValidationResult.InsufficientFunds 'MsgBox("Unable to process transaction, ending balance is less than [0.00]", MsgBoxStyle.Critical, "Transaction Error") : Exit Function
        '    If .AMOUNT > 99999999.99 Or Round(CDbl(BALANCE)) > 99999999.99 Then MsgBox("Unable to process transaction, maximum balance / amount is reached.", MsgBoxStyle.Critical, "Transaction Error") : Exit Function

        'End With
    End Function
End Class
