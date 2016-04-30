Imports FD.ViewModels
Imports FD.Common
Imports FD.DataAccessObject
Imports System

Public Class DividendPatronageRefundService : Implements IDividendPatronageRefundService


    Private _DividendRefundPh As Divrefph
    Public Property DividendRefundPh() As Divrefph
        Get
            Return _DividendRefundPh
        End Get
        Set(ByVal value As Divrefph)
            _DividendRefundPh = value
        End Set
    End Property

    Public Function ValidateDividendProcessing(ByVal ProcessingYear As String, ByVal ProcessingQuarter As String) As DividendProcessingValidationResult Implements IDividendPatronageRefundService.ValidateDividendProcessing
        Using rsdivDAO As New DivrefphDAO
            Dim param1 As New LUNA.LunaSearchParameter("YEAR", ProcessingYear)
            Dim param2 As New LUNA.LunaSearchParameter("QUARTER", ProcessingQuarter)
            DividendRefundPh = rsdivDAO.Find(param1, param2)
            If Not DividendRefundPh Is Nothing Then
                If DividendRefundPh.CVNO.Trim <> String.Empty Or DividendRefundPh.POSTED = True Then
                    Return DividendProcessingValidationResult.Invalid
                Else
                    Return DividendProcessingValidationResult.NotFound
                End If
            Else
                Return DividendProcessingValidationResult.Valid
            End If
        End Using
    End Function

    Public Sub PostCashDividend(ByVal dividendPercentage As Decimal, ByVal systemDate As Date, ByVal fixedDepositCutOffDate As Date, ByVal processingDate As Date, ByVal currentUser As String) Implements IDividendPatronageRefundService.PostCashDividend
        Using rsDividendDAO As New DivDAO
            rsDividendDAO.PostDividendsForMembers(DividendPercentage, SystemDate, FixedDepositCutOffDate, ProcessingDate)
        End Using

        Using rsCashDivDAO As New CashdivDAO
            Dim Cashdiv = rsCashDivDAO.GetAll().FirstOrDefault()
            With Cashdiv
                .DATE = processingDate
                .PERCENT = Math.Round(dividendPercentage * 100, 2)
                .YTD_PCT = Math.Round(dividendPercentage * 100, 2)
                .PROC_DATE = processingDate
                .ADD_DATE = systemDate
                .CHG_DATE = systemDate
                .USER = currentUser
                .Save()
            End With

        End Using
    End Sub

    Public Sub ClearDividendPatronageRefundRecords() Implements IDividendPatronageRefundService.ClearDividendPatronageRefundRecords
        Using cmdDividendDao As New DivDAO
            cmdDividendDao.DeleteAll()
        End Using
        Using cmdRefundDao As New RefDAO
            cmdRefundDao.DeleteAll()
        End Using
    End Sub

    Public Sub UpdateDividendPatronageRefundRegister(ByVal divrefParameter As DivrefPostingParameters, ByVal isBatchPosted As Boolean) Implements IDividendPatronageRefundService.UpdateDividendPatronageRefundRegister

        Using cmdDivRefDao As New DivrefDAO
            cmdDivRefDao.DeleteAll()
            cmdDivRefDao.UpdateDividendPatronageRefundRegister()
        End Using


        Using cmdDivRefPHDao As New DivrefphDAO
            cmdDivRefPHDao.UpdateDivrefPostingHistory(divrefParameter, isBatchPosted)
        End Using
    End Sub

    Public Sub PostPatronageRefund(ByVal divrefParameter As DivrefPostingParameters, ByVal IncludeSTL As Boolean) Implements IDividendPatronageRefundService.PostPatronageRefund

        Using cmdMembersDao As New MembersDAO
            cmdMembersDao.ResetMembersYtdDividend()
        End Using

        Using cmdInterestDao As New InterestDAO
            cmdInterestDao.DeleteAll()
            cmdInterestDao.CalculatePatronageRefund(divrefParameter.PatronageRefundInterestStartDate, divrefParameter.PatronageRefundInterestEndDate, IncludeSTL)
            cmdInterestDao.PostMembersRefund()
        End Using

        Using cmdSnterestDao As New SnterestDAO
            cmdSnterestDao.DeleteAll()
            cmdSnterestDao.CalculatePatronageRefund(divrefParameter.PatronageRefundInterestStartDate, divrefParameter.PatronageRefundInterestEndDate, IncludeSTL)
            cmdSnterestDao.PostMembersRefund()
        End Using

        Using cmdRnterestDao As New RnterestDAO
            cmdRnterestDao.DeleteAll()
            cmdRnterestDao.CalculatePatronageRefund(divrefParameter.PatronageRefundInterestStartDate, divrefParameter.PatronageRefundInterestEndDate, IncludeSTL)
            cmdRnterestDao.PostMembersRefund()
        End Using

        Using cmdPatrefDao As New Pat_refDAO
            cmdPatrefDao.LogPatronageRefundProcessing(divrefParameter.PatronageRefundProcessingDate, divrefParameter.SystemDate, divrefParameter.CurrentUsername, divrefParameter.PatronageRefundPercentage)
        End Using


        Using cmdRefDao As New RefDAO
            cmdRefDao.PopulateRefundRegister(divrefParameter.PatronageRefundProcessingDate, divrefParameter.PatronageRefundPercentage)
        End Using
    End Sub

End Class
