Imports FD.Common.Utilities
Imports FD.Common


Public Class MessagePromptService : Implements ILoginMessagePromptService, ITransactionPromptService, IDividendPatronageMessagePromptService, IRecordUpdateMessagePromptService
    Public Sub GetMessageFromResult(ByVal result As ValidationResult) Implements ILoginMessagePromptService.GetMessageFromResult
        Select Case result
            Case ValidationResult.Failed
                MsgBox(GetGlobalResourceString("IncorrectCredentials"), MsgBoxStyle.Critical, GetGlobalResourceString("Login"))
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


    Public Sub GetMessageFromRecordUpdateResult(ByVal result As RecordUpdateResult, Optional ByVal MessageTitleResourceKey As String = "") Implements IRecordUpdateMessagePromptService.GetMessageFromRecordUpdateResult

        Dim Title As String = String.Empty
        If Not MessageTitleResourceKey = String.Empty Then
            Title = GetGlobalResourceString(MessageTitleResourceKey)
        End If

        Select Case result
            Case RecordUpdateResult.AddSuccessful
                MsgBox(GetGlobalResourceString("AddSuccessful"), MsgBoxStyle.Information, Title)
            Case RecordUpdateResult.UpdateSuccessful
                MsgBox(GetGlobalResourceString("UpdateSuccessful"), MsgBoxStyle.Information, Title)
            Case RecordUpdateResult.Unsuccessful
                MsgBox(GetGlobalResourceString("Unsuccessful"), MsgBoxStyle.Critical, Title)

        End Select
    End Sub
    Public Sub GetMessageFromTransactionValidation(ByVal result As RecordUpdateResult) Implements ITransactionPromptService.GetMessageFromTransactionValidation

        Dim Title As String = String.Empty
        Title = GetGlobalResourceString("FixedDepositTransaction")

        Select Case result
            Case FixedDepositTransactionValidationResult.ArithmeticOverflow
                MsgBox(GetGlobalResourceString("AmountExceeds1B"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.InsufficientFunds
                MsgBox(GetGlobalResourceString("InsufficientFunds"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.InvalidAmount
                MsgBox(GetGlobalResourceString("InvalidAmount"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.MissingBankCode
                MsgBox(GetGlobalResourceString("MissingBankCode"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.MissingCheckNumber
                MsgBox(GetGlobalResourceString("MissingCheckNumber"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.MissingRemarks
                MsgBox(GetGlobalResourceString("MissingRemarks"), MsgBoxStyle.Critical, Title)
            Case FixedDepositTransactionValidationResult.MissingTransactionCode
                MsgBox(GetGlobalResourceString("MissingTransactionCode"), MsgBoxStyle.Critical, Title)
        End Select
    End Sub

End Class
