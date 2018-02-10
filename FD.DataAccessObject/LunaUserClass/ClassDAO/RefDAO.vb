#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region


Imports System.Data.Common
Imports FD.Common

''' <summary>
'''DAO Class for table Ref
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class RefDAO
    Inherits _RefDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub DeleteAll()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "TRUNCATE TABLE REF"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub PopulateRefundRegister(ByVal PatronageRefundProcessingDate As Date, ByVal PatronageRefundPercentage As Decimal)

        Dim Sql As String = "INSERT INTO REF([DATE],[KBCI_NO],[INT_PAID],[REFUND]) " & _
                               "SELECT @PatronageRefundProcessingDate DATE,KBCI_NO,YTD_DIVAMT,ROUND(YTD_DIVAMT * (@PatronageRefundPercentage / 100),0) REFUND FROM MEMBERS WHERE YTD_DIVAMT>0"

        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramPatronageRefundProcessingDate = myCommand.CreateParameter
                With paramPatronageRefundProcessingDate
                    .ParameterName = "@PatronageRefundProcessingDate"
                    .Value = PatronageRefundProcessingDate
                End With

                Dim paramPatronageRefundPercentage = myCommand.CreateParameter
                With paramPatronageRefundPercentage
                    .ParameterName = "@PatronageRefundPercentage"
                    .Value = PatronageRefundPercentage
                End With

                myCommand.Parameters.Add(paramPatronageRefundProcessingDate)
                myCommand.Parameters.Add(paramPatronageRefundPercentage)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Public Function GetPatronageRefundSummarizedData(ByVal memberStatus As String) As DataTable
        Dim Sql As String
        Dim resultDataTable As New DataTable
        Try
            Sql = "SELECT MM.KBCI_NO, MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,RF.INT_PAID,RF.REFUND " & _
                    "FROM REF RF INNER JOIN MEMBERS MM ON RF.KBCI_NO=MM.KBCI_NO WHERE MM.MEM_STAT=@MemberStatus OR @MemberStatus ='' ORDER BY NAME"

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql
                Dim parammemberStatus = myCommand.CreateParameter
                With parammemberStatus
                    .ParameterName = "@MemberStatus"
                    .Value = memberStatus
                End With

                myCommand.Parameters.Add(parammemberStatus)

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