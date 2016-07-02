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
        Dim reportFactory As IReportFactoryService = New PatronageRefundReportFactory(_memberStatus)
        Return reportFactory.GetReportData()
    End Function
End Class
