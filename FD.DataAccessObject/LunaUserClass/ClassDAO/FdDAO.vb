#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region


Imports System.Data.Common

''' <summary>
'''DAO Class for table Fd
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class FdDAO
	Inherits _FdDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Function GetMemberLedger(ByVal kbciNo As String, ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        Dim Sql As String
        Dim resultDataTable As New DataTable
        Try
            Sql = "SELECT FD.DATE,TC.TR_CODE AS CODE,CASE WHEN FD.DRCR ='DR' THEN FD.AMOUNT ELSE 0.00 END AS DEBIT,CASE WHEN FD.DRCR ='CR' THEN FD.AMOUNT ELSE 0.00 END AS CREDIT,FD.BALANCE,FD.REF,FD.RMK AS REMARKS, FD.DRCR FROM FD INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID WHERE KBCI_NO =@KbciNo AND ([DATE] BETWEEN  @StartDate AND @EndDate)  ORDER BY FD.[DATE], FD.FD_ID"
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramkbciNo = myCommand.CreateParameter
                With paramkbciNo
                    .ParameterName = "@KbciNo"
                    .Value = kbciNo
                End With

                Dim paramStartDate = myCommand.CreateParameter
                With paramStartDate
                    .ParameterName = "@StartDate"
                    .Value = StartDate
                End With

                Dim paramEndDate = myCommand.CreateParameter
                With paramEndDate
                    .ParameterName = "@EndDate"
                    .Value = EndDate
                End With

                myCommand.Parameters.Add(paramkbciNo)
                myCommand.Parameters.Add(paramStartDate)
                myCommand.Parameters.Add(paramEndDate)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    resultDataTable.Load(myReader)
                End Using
            End Using
        Catch ex As Exception
            ManageError(ex)
        End Try

        Return resultDataTable
    End Function

    Public Function GetDailyTransactions(ByVal TransactionDate As Date) As DataTable
        Dim Sql As String
        Dim resultDataTable As New DataTable
        Try
            Sql = "SELECT MM.KBCI_NO,MM.LNAME + ', ' + MM.FNAME + ' ' NAME,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT," & _
                           "FD.BALANCE,FD.REF,FD.RMK, FD.DRCR FROM FD INNER JOIN MEMBERS AS MM ON FD.KBCI_NO= MM.KBCI_NO INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID " & _
                           "WHERE [DATE] = @TransactionDate ORDER BY MM.LNAME,MM.FNAME"
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramTransactionDate = myCommand.CreateParameter
                With paramTransactionDate
                    .ParameterName = "@TransactionDate"
                    .Value = TransactionDate
                End With

                myCommand.Parameters.Add(paramTransactionDate)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    resultDataTable.Load(myReader)
                End Using
            End Using
        Catch ex As Exception
            ManageError(ex)
        End Try

        Return resultDataTable
    End Function
End Class