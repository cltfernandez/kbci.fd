Imports FD.Common
Public Interface ILoginMessagePromptService
    Sub GetMessageFromResult(ByVal result As ValidationResult)
End Interface

Public Interface IDividendPatronageMessagePromptService
    Sub GetMessageFromDividendRefundValidation(ByVal result As DividendProcessingValidationResult, ByVal Year As String, ByVal Quarter As String)

    Sub GetMessageFromDivRefSettingsValidation(ByVal result As DivRefSettingsValidationResult, ByVal Year As String, ByVal Quarter As String)

    Sub GetMessageFromRecordUpdateResult(ByVal result As RecordUpdateResult)

End Interface

Public Interface IRecordUpdateMessagePromptService
    Sub GetMessageFromRecordUpdateResult(ByVal result As RecordUpdateResult, Optional ByVal MessageTitleResourceKey As String = "")

End Interface