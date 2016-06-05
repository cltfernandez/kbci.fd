Imports FD.DataAccessObject
Public Class ActiveMembersReportService : Implements IReportService


    Sub New(ByVal systemDate As Date)
        _SystemDate = systemDate
    End Sub
    Private _SystemDate As Date

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsMembersDao As New MembersDAO
            result = rsMembersDao.GetActiveMembers(_SystemDate)
        End Using
        Return result
    End Function
End Class
