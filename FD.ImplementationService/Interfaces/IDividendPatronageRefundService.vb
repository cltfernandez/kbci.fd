Imports FD.Common
Imports FD.ViewModels
Public Interface IDividendPatronageRefundService
    Function ValidateDividendProcessing(ByVal ProcessingYear As String, ByVal ProcessingQuarter As String) As DividendProcessingValidationResult

    Sub PostCashDividend(ByVal DividendPercentage As Decimal, ByVal SystemDate As Date, ByVal FixedDepositCutOffDate As Date, ByVal ProcessingDate As Date, ByVal CurrentUser As String)

    Sub ClearDividendPatronageRefundRecords()

    Sub UpdateDividendPatronageRefundRegister(ByVal divrefParameter As DivrefPostingParameters, ByVal isBatchPosted As Boolean)

    Sub PostPatronageRefund(ByVal divrefParameter As DivrefPostingParameters, ByVal IncludeSTL As Boolean)

    Function GetLatestDivrefPostingHistory() As DivrefPostingViewModel

    Function GetDivrefPostingHistory(ByVal processingYear As String, ByVal processingQuarter As String) As DivrefPostingViewModel

End Interface