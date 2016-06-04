Imports FD.DataAccessObject
Public Class DailyTransactionRegisterReportService : Implements IReportService


    Sub New(ByVal transactionDate As Date)
        _TransactionDate = transactionDate
    End Sub
    Private _TransactionDate As Date    

    Public Function GetData() As DataTable Implements IReportService.GetData
        Dim result As DataTable
        Using rsFdDao As New FdDAO
            result = rsFdDao.GetDailyTransactions(_TransactionDate)
        End Using
        Return result
    End Function

End Class
