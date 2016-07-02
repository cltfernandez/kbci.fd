Imports FD.DataAccessObject
Imports FD.Common
Public Class DividenRefundReportFactory : Implements IReportFactoryService

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
    Public Function GetReportData() As System.Data.DataTable Implements IReportFactoryService.GetReportData
        Dim data As DataTable
        Select Case DirectCast(_viewOption, ViewOptions)
            Case ViewOptions.Current
                Using dao As New DivrefDAO
                    data = dao.GetDividendForAllMembers(_memberStatus, _sortBy, _filterByRegion)
                End Using
            Case Else
                Using dao As New DivrefhDAO
                    data = dao.GetDividendForAllMembers(_memberStatus, _sortBy, _postingYear, _postingQurater, _filterByRegion)
                End Using
        End Select
        Return data
    End Function
End Class
