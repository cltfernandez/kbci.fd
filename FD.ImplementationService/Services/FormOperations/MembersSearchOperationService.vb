Imports FD.DataAccessObject
Imports FD.Common
Imports FD.ViewModels
Imports AutoMapper
Public Class MembersSearchOperationService : Implements IFormOperations

    Private ReadOnly _searchType As MemberSearchType
    Sub New()
        _searchType = MemberSearchType.MembersData
    End Sub

    Sub New(ByVal searchType As MemberSearchType)
        _searchType = searchType
    End Sub

    Public Function GetAll() As Object Implements IFormOperations.GetAll
        Return If(_searchType = MemberSearchType.MembersData, GetMembers(), GetSdMaster())
    End Function


    Private Function GetMembers() As List(Of MemberSearchBovm)
        Using rsMemberSearchDao As New MembersDAO
            Dim rsMembersList = rsMemberSearchDao.GetAll()
            Return rsMembersList.Select(Function(x) New MemberSearchBovm() With {.KBCI_ID = x.KBCI_ID, _
                                                                                  .KBCI_NO = x.KBCI_NO, _
                                                                                  .LNAME = x.LNAME, _
                                                                                  .FNAME = x.FNAME, _
                                                                                  .MEM_STAT = x.MEM_STAT, _
                                                                                  .FEBTC_SA = x.FEBTC_SA, _
                                                                                  .FEBTC_CA = x.FEBTC_CA}).OrderBy(Function(y) y.LNAME).ToList
        End Using
    End Function

    Private Function GetSdMaster() As List(Of MemberSearchBovm)
        Using sdmasterDao As New SdmasterDAO
            Dim param1 As New LUNA.LunaSearchParameter("ACCTSTAT", "A")
            Dim sdMasterList = sdmasterDao.FindAll(param1)

            Return sdMasterList.Select(Function(x) New MemberSearchBovm() With {.KBCI_ID = x.SDMASTER_ID, _
                                                                                  .KBCI_NO = x.KBCI_NO, _
                                                                                  .FNAME = x.ACCTNAME, _
                                                                                  .MEM_STAT = x.ACCTSTAT, _
                                                                                  .FEBTC_SA = x.ACCTNO}).OrderBy(Function(y) y.FNAME).ToList
        End Using
    End Function
End Class
