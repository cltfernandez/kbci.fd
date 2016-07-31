Imports FD.DataAccessObject
Imports FD.Common
Public Class DividendVoucherReportService : Implements IReportService


    Private _postingYear As Integer
    Private _postingQurater As Integer
    Sub New(ByVal postingYear As Integer, _
            ByVal postingQurater As Integer)

        _postingYear = postingYear
        _postingQurater = postingQurater
    End Sub

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsDivrefPhDao As New DivrefphDAO
            result = rsDivrefPhDao.GetVoucherDetails(_postingYear, _postingQurater)
        End Using
        Return result
    End Function
End Class
