#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 16/04/2016 
#End Region


Imports System.Data.Common

''' <summary>
'''DAO Class for table Pat_ref
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class Pat_refDAO
	Inherits _Pat_refDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub


    Public Sub LogPatronageRefundProcessing(ByVal PatronageRefundProcessingDate As Date, ByVal SystemDate As String, ByVal CurrentUser As String, ByVal PatronageRefundPercentage As Decimal)

        Dim Sql As String = "INSERT INTO PAT_REF([PERCENT],[PROC_DATE],[ADD_DATE],[CHG_DATE],[USER]) " & _
                           "VALUES(@PatronageRefundPercentage * 100,@PatronageRefundProcessingDate,@SystemDate,@SystemDate,@CurrentUser)"

        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramPatronageRefundProcessingDate = myCommand.CreateParameter
                With paramPatronageRefundProcessingDate
                    .ParameterName = "@PatronageRefundProcessingDate"
                    .Value = PatronageRefundProcessingDate
                End With

                Dim paramSystemDate = myCommand.CreateParameter
                With paramSystemDate
                    .ParameterName = "@SystemDate"
                    .Value = SystemDate
                End With

                Dim paramCurrentUser = myCommand.CreateParameter
                With paramCurrentUser
                    .ParameterName = "@CurrentUser"
                    .Value = CurrentUser
                End With

                Dim paramPatronageRefundPercentage = myCommand.CreateParameter
                With paramPatronageRefundPercentage
                    .ParameterName = "@PatronageRefundPercentage"
                    .Value = PatronageRefundPercentage
                End With


                myCommand.Parameters.Add(paramPatronageRefundProcessingDate)
                myCommand.Parameters.Add(paramSystemDate)
                myCommand.Parameters.Add(paramCurrentUser)
                myCommand.Parameters.Add(paramPatronageRefundPercentage)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub


End Class