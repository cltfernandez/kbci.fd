Imports FD.Common
Imports FD.ViewModels
Public Interface IDividendPatronageRefundSettingService
    Function ValidateSettings(ByVal Year As String, ByVal Quarter As String) As DivRefSettingsValidationResult

    Function GetDividendPatronageRefundPosting(ByVal Options As ViewOptions, ByVal Year As String, ByVal Quarter As String) As List(Of DivRefSettingsViewModel)

    Function GetDivRefByKbciNo(ByVal kbciNo As String) As DivRefSettingsViewModel

    Function Save(ByVal kbciNo As String, ByVal dividendAmount As Decimal, ByVal refundAmount As Decimal, ByVal ViewOption As ViewOptions) As RecordUpdateResult
End Interface

