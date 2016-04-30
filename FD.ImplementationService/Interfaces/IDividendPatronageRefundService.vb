Imports FD.Common
Public Interface IDividendPatronageRefundService
    Function ValidateDividendProcessing(ByVal ProcessingYear As String, ByVal ProcessingQuarter As String) As DividendProcessingValidationResult

    Sub PostCashDividend(ByVal DividendPercentage As Decimal, ByVal SystemDate As Date, ByVal FixedDepositCutOffDate As Date, ByVal ProcessingDate As Date, ByVal CurrentUser As String)

    Sub ClearDividendPatronageRefundRecords()

    Sub UpdateDividendPatronageRefundRegister(ByVal divrefParameter As DivrefPostingParameters, ByVal isBatchPosted As Boolean)

    Sub PostPatronageRefund(ByVal divrefParameter As DivrefPostingParameters, ByVal IncludeSTL As Boolean)
End Interface