Imports FD.Common
Imports FD.ViewModels
Public Interface IDividendPatronageRefundSettingService
    Function ValidateSettings(ByVal Year As String, ByVal Quarter As String) As DivRefSettingsValidationResult

    Function GetDividendPatronageRefundPosting(ByVal Options As ViewOptions, ByVal Year As String, ByVal Quarter As String) As List(Of DivRefSettingsViewModel)

    Function GetDivRefByKbciNo(ByVal saveParameter As DivrefSaveParameters, ByVal ViewOption As ViewOptions) As DivRefSettingsViewModel

    Function Save(ByVal saveParameter As DivrefSaveParameters, ByVal dividendAmount As Decimal, ByVal refundAmount As Decimal, ByVal ViewOption As ViewOptions) As RecordUpdateResult
End Interface

