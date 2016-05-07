Imports FD.ViewModels
Imports FD.Common

Public Interface IFixedDepositTransactionService
    Function Save(ByVal fdViewModel As FixedDepositViewModel, ByVal MembersBalance As Decimal) As RecordUpdateResult
End Interface
