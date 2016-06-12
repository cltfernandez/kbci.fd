Imports FD.ViewModels
Imports FD.Common

Public Interface ICashDividendSettingsService

    Function Read() As CashDividendPolicySettingsViewModel

    Function Update(ByVal cashDividendModel As CashDividendPolicySettingsViewModel) As RecordUpdateResult

End Interface
