Imports FD.DataAccessObject
Imports FD.Common

Public Class PatronageRefundSummaryReportService : Implements IReportService


    Sub New(ByVal memberStatus As String)

        _MemberStatus = memberStatus
    End Sub
    Private _MemberStatus As String

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsRefDao As New RefDAO
            result = rsRefDao.GetPatronageRefundSummarizedData(_MemberStatus)
        End Using
        Return result
    End Function
End Class
