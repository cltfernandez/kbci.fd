Imports FD.DataAccessObject
Imports FD.Common
Public Class PatronageRefundDetailedReportService : Implements IReportService


    Sub New()
    End Sub
    Sub New(ByVal memberStatus As String)
        _memberStatus = memberStatus
    End Sub
    Private _memberStatus As String


    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim reportFactory As New ReportFactoryService
        Return reportFactory.GetReportData(_memberStatus)
    End Function
End Class
