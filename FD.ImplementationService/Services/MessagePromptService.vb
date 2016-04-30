Imports FD.Common.Utilities
Imports FD.Common


Public Class MessagePromptService : Implements ILoginMessagePromptService, IDividendPatronageMessagePromptService
    Public Sub GetMessageFromResult(ByVal result As ValidationResult) Implements ILoginMessagePromptService.GetMessageFromResult
        Select Case result
            Case ValidationResult.Failed
                MsgBox(GetGlobalResourceString("IncorrectCredentials"), MsgBoxStyle.Information, GetGlobalResourceString("Login"))
            Case ValidationResult.Passed
                MsgBox(GetGlobalResourceString("LoginSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("Login"))
            Case ValidationResult.UserIsLoggedIn
                MsgBox(GetGlobalResourceString("UserIsLoggedIn"), MsgBoxStyle.Information, GetGlobalResourceString("Login"))

        End Select
    End Sub

    Public Sub GetMessageFromDividendRefundValidation(ByVal result As DividendProcessingValidationResult, ByVal Year As String, ByVal Quarter As String) Implements IDividendPatronageMessagePromptService.GetMessageFromDividendRefundValidation
        Select Case result
            Case DividendProcessingValidationResult.Invalid
                MsgBox(String.Format(GetGlobalResourceString("UnableToProcessDivref"), Year, Quarter), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageRefund"))
        End Select
    End Sub
    Public Sub GetMessageFromDivRefSettingsValidation(ByVal result As DivRefSettingsValidationResult, ByVal Year As String, ByVal Quarter As String) Implements IDividendPatronageMessagePromptService.GetMessageFromDivRefSettingsValidation
        Select Case result
            Case DivRefSettingsValidationResult.Invalid
                MsgBox(String.Format(GetGlobalResourceString("UnableToProcessDivref"), Year, Quarter), MsgBoxStyle.Critical, GetGlobalResourceString("DividendPatronageMaintenance"))
            Case DivRefSettingsValidationResult.NotFound
                MsgBox(String.Format(GetGlobalResourceString("DivRefRecordNotFound"), Year, Quarter), MsgBoxStyle.Critical, GetGlobalResourceString("DividendPatronageMaintenance"))
        End Select
    End Sub
    Public Sub GetMessageFromRecordUpdateResult(ByVal result As RecordUpdateResult) Implements IDividendPatronageMessagePromptService.GetMessageFromRecordUpdateResult

        Select Case result
            Case RecordUpdateResult.AddSuccessful
                MsgBox(GetGlobalResourceString("AddSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance"))
            Case RecordUpdateResult.UpdateSuccessful
                MsgBox(GetGlobalResourceString("UpdateSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance"))
            Case RecordUpdateResult.Unsuccessful
                MsgBox(GetGlobalResourceString("Unsuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance"))

        End Select
    End Sub

    'Public Sub GetMessageFromRecordUpdateResult(ByVal result As RecordUpdateResult, Optional ByVal MessageTitleResourceKey As String = "") Implements IRecordUpdateMessagePromptService.GetMessageFromRecordUpdateResult

    '    Dim Title As String = String.Empty
    '    If Not MessageTitleResourceKey = String.Empty Then
    '        Title = GetGlobalResourceString("Login")
    '    End If

    '    Select Case result
    '        Case RecordUpdateResult.AddSuccessful
    '            MsgBox(GetGlobalResourceString("AddSuccessful"), MsgBoxStyle.Information, Title)
    '        Case RecordUpdateResult.UpdateSuccessful
    '            MsgBox(GetGlobalResourceString("UpdateSuccessful"), MsgBoxStyle.Information, Title)
    '        Case RecordUpdateResult.Unsuccessful
    '            MsgBox(GetGlobalResourceString("Unsuccessful"), MsgBoxStyle.Information, Title)

    '    End Select
    'End Sub
End Class
