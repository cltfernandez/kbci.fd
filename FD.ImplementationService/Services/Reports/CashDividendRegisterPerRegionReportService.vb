Imports FD.DataAccessObject
Public Class CashDividendRegisterPerRegionReportService : Implements IReportService


    Sub New(ByVal sortBy As String, Optional ByVal regionFilter As String = "")
        _SortBy = sortBy
        _RegionFilter = regionFilter
    End Sub
    Private _RegionFilter As String
    Private _SortBy As String

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using dtDivDao As New DivDAO
            result = dtDivDao.GetDividendsByRegion(_SortBy, _RegionFilter)
        End Using
        Return result
    End Function
End Class
