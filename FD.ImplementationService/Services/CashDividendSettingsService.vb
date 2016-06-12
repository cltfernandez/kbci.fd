Imports FD.DataAccessObject
Imports FD.Common
Imports FD.ViewModels
Imports AutoMapper
Public Class CashDividendSettingsService : Implements ICashDividendSettingsService

    Sub New()
        Mapper.CreateMap(Of CashDividendPolicySettingsViewModel, Cashdiv)()
        Mapper.CreateMap(Of Cashdiv, CashDividendPolicySettingsViewModel)()
    End Sub

    Public Function Read() As CashDividendPolicySettingsViewModel Implements ICashDividendSettingsService.Read
        Using rsCashDivDao As New CashdivDAO
            Dim model = Mapper.Map(Of Cashdiv, CashDividendPolicySettingsViewModel)(rsCashDivDao.Read(1))
            Return model
        End Using
    End Function


    Public Function Update(ByVal cashDividendModel As CashDividendPolicySettingsViewModel) As RecordUpdateResult Implements ICashDividendSettingsService.Update
        Using rsCashDivDAO As New CashdivDAO
            Dim Cashdiv = rsCashDivDAO.Read(1)
            Mapper.Map(cashDividendModel, Cashdiv)
            Cashdiv.Save()
        End Using
    End Function
End Class
