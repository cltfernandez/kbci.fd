Imports FD.Common
Imports FD.DataAccessObject
Public Class PatronageRefundReportFactory : Implements IReportFactoryService

    Private _memberStatus As String
    Sub New(ByVal memberStatus As String)
        _memberStatus = memberStatus
    End Sub
    Public Function GetReportData() As DataTable Implements IReportFactoryService.GetReportData
        Dim data As DataTable
        Select Case _memberStatus
            Case MemberStatusEnum.Active
                Using dao As New InterestDAO
                    data = dao.GetInterestForAllMembers()
                End Using
            Case MemberStatusEnum.Resigned
                Using dao As New RnterestDAO
                    data = dao.GetInterestForAllMembers()
                End Using
            Case MemberStatusEnum.Staff
                Using dao As New SnterestDAO
                    data = dao.GetInterestForAllMembers()
                End Using
            Case Else
                Using dao As New MembersDAO
                    data = dao.GetInterestForAllMembers()
                End Using
        End Select
        Return data
    End Function

End Class
