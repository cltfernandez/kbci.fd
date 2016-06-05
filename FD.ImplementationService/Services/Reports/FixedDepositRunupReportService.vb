Imports FD.DataAccessObject
Public Class FixedDepositRunupReportService : Implements IReportService


    Sub New(ByVal transactionDate As Date)
        _TransactionDate = transactionDate
    End Sub

    Private _TransactionDate As Date

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsFdDao As New FdDAO
            result = rsFdDao.GenerateFixedDepositRunup(_TransactionDate)
        End Using

        Using ctrlCmd As New CtrlDAO
            Dim ctrlObject As Ctrl = ctrlCmd.Read(1)
            ctrlObject.RUN_DATE = _TransactionDate
            ctrlObject.Save()
        End Using
        Return result
    End Function
End Class
