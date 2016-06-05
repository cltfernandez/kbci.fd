Imports FD.DataAccessObject
Public Class ResignedMembersReportService : Implements IReportService


    Sub New(ByVal startDate As Date, ByVal endDate As Date)
        _StartDate = startDate
        _EndDate = endDate
    End Sub
    Private _StartDate As Date
    Private _EndDate As Date

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsMembersDao As New MembersDAO
            result = rsMembersDao.GetResignedMembers(_StartDate, _EndDate)
        End Using
        Return result
    End Function
End Class
