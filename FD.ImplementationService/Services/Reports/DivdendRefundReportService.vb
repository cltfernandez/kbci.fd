Imports FD.DataAccessObject
Imports FD.Common
Public Class DivdendRefundReportService : Implements IReportService


    Private _memberStatus As String
    Private _viewOption As Integer
    Private _sortBy As String
    Private _filterByRegion As String
    Private _postingYear As Integer
    Private _postingQurater As Integer
    Sub New(ByVal viewOption As Integer, _
            ByVal memberStatus As String, _
            ByVal sortBy As String, _
            Optional ByVal filterByRegion As String = "", _
            Optional ByVal postingYear As Integer = Nothing, _
            Optional ByVal postingQurater As Integer = Nothing)

        _viewOption = viewOption
        _memberStatus = memberStatus
        _sortBy = sortBy
        _filterByRegion = filterByRegion
        _postingYear = postingYear
        _postingQurater = postingQurater
    End Sub

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim reportFactory As IReportFactoryService = New DividenRefundReportFactory(_viewOption, _memberStatus, _sortBy, _filterByRegion, _postingYear, _postingQurater)
        Return reportFactory.GetReportData()
    End Function
End Class
