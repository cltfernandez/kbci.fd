Imports FD.DataAccessObject
Public Class FixedDepositLedgerReportService : Implements IReportService


    Sub New(ByVal kbciNo As String, ByVal startDate As Date, ByVal endDate As Date)
        _KbciNo = kbciNo
        _StartDate = startDate
        _EndDate = endDate
    End Sub
    Private _KbciNo As String
    Private _StartDate As Date
    Private _EndDate As Date

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsFdDao As New FdDAO
            result = rsFdDao.GetMemberLedger(_KbciNo, _StartDate, _EndDate)
        End Using
        Return result
    End Function
End Class
