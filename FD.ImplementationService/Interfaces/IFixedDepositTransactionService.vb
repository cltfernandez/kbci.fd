Imports FD.ViewModels
Imports FD.Common

Public Interface IFixedDepositTransactionService
    Function Save(ByVal fdViewModel As FixedDepositViewModel) As RecordUpdateResult

    Function Validate(ByVal fdViewModel As FixedDepositViewModel) As FixedDepositTransactionValidationResult

    Function GetMemberTransactions(ByVal kbciNumber As String) As List(Of FixedDepositViewModel)

    Function GetTransactionCodes() As List(Of TransactionCodeViewModel)

    Function UpdatedPassbookPosting(ByVal id As String, ByVal isPrinted As String) As RecordUpdateResult

End Interface
