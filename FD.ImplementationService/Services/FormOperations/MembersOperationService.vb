Imports FD.DataAccessObject
Imports FD.Common
Imports FD.ViewModels
Imports AutoMapper
Public Class MembersOperationService : Implements IFormOperations

    Sub New()

    End Sub

    Public Function GetAll() As Object Implements IFormOperations.GetAll
        Using rsMemberSearchDao As New MembersDAO
            Dim rsMembersList = rsMemberSearchDao.GetAll()
            Return rsMembersList.Select(Function(x) New MemberSearchBovm() With {.KBCI_ID = x.KBCI_ID, _
                                                                                  .KBCI_NO = x.KBCI_NO, _
                                                                                  .LNAME = x.LNAME, _
                                                                                  .FNAME = x.FNAME, _
                                                                                  .MI = x.MI, _
                                                                                  .FEBTC_SA = x.FEBTC_SA, _
                                                                                  .FEBTC_CA = x.FEBTC_CA}).ToList
        End Using
    End Function
End Class
