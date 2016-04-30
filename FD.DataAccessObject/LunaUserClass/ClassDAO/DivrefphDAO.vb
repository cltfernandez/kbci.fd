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
'''DAO Class for table Divrefph
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class DivrefphDAO
    Inherits _DivrefphDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub UpdateDivrefPostingHistory(ByVal divrefParameter As DivrefPostingParameters, ByVal isBatchPosted As Boolean)
        Dim Sql As String
        If isBatchPosted Then
            Sql = "INSERT INTO DIVREFPH([YEAR],[QUARTER],[FD_CUTOFF],[FD_PERCENT],[PR_YEAR],[PR_PERCENT],[PR_INTFROM],[PR_INTTO],[HOLDOUT],[USER],[ADD_DATE],[TDIVAMT],[TREFAMT],[SAVINGS],[POSTED]) " & _
                  "SELECT @PostingYear,@PostingQuarter ,@FixedDepositCutoffDate ,@DividendPercentage ,YEAR(@PatronageRefundProcessingDate) ," & _
                  "@PatronageRefundPercentage ,@PatronageRefundInterestStartDate ,@PatronageRefundInterestEndDate ,'False',@CurrentUsername,@SystemDate," & _
                  "(SELECT SUM(DIV_AMT) FROM DIV),(SELECT SUM(REFUND) FROM REF),(SELECT SUM(DIV_AMT) FROM DIV)+(SELECT SUM(REFUND) FROM REF),'False'"
        Else
            Sql = "UPDATE DIVREFPH SET [YEAR]=@PostingYear,[QUARTER]=@PostingQuarter ,[FD_CUTOFF]=@FixedDepositCutoffDate," & _
                  "[FD_PERCENT]=@DividendPercentage ,[PR_YEAR]=YEAR(@PatronageRefundProcessingDate) ,[PR_PERCENT]=@PatronageRefundPercentage ,[PR_INTFROM]=@PatronageRefundInterestStartDate," & _
                  "[PR_INTTO]=@PatronageRefundInterestEndDate ,[HOLDOUT]='False',[USER]=@CurrentUsername,[ADD_DATE]=@SystemDate," & _
                  "[TDIVAMT]=(SELECT SUM(DIV_AMT) FROM DIV),[TREFAMT]=(SELECT SUM(REFUND) FROM REF),[SAVINGS]=(SELECT SUM(DIV_AMT) FROM DIV)+(SELECT SUM(REFUND) FROM REF),[POSTED]='False' " & _
                  "WHERE [YEAR] = @PostingYear AND  [QUARTER] = @PostingQuarter"
        End If

        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramPostingYear = myCommand.CreateParameter
                With paramPostingYear
                    .ParameterName = "@PostingYear"
                    .Value = divrefParameter.PostingYear
                End With

                Dim paramPostingQuarter = myCommand.CreateParameter
                With paramPostingQuarter
                    .ParameterName = "@PostingQuarter"
                    .Value = divrefParameter.PostingQuarter
                End With

                Dim paramFixedDepositCutoffDate = myCommand.CreateParameter
                With paramFixedDepositCutoffDate
                    .ParameterName = "@FixedDepositCutoffDate"
                    .Value = divrefParameter.FixedDepositCutOffDate
                End With

                Dim paramDividendPercentage = myCommand.CreateParameter
                With paramDividendPercentage
                    .ParameterName = "@DividendPercentage"
                    .Value = divrefParameter.DividendPercentage
                End With

                Dim paramPatronageRefundProcessingDate = myCommand.CreateParameter
                With paramPatronageRefundProcessingDate
                    .ParameterName = "@PatronageRefundProcessingDate"
                    .Value = divrefParameter.PatronageRefundProcessingDate
                End With

                Dim paramPatronageRefundPercentage = myCommand.CreateParameter
                With paramPatronageRefundPercentage
                    .ParameterName = "@PatronageRefundPercentage"
                    .Value = divrefParameter.PatronageRefundPercentage
                End With

                Dim paramPatronageRefundInterestStartDate = myCommand.CreateParameter
                With paramPatronageRefundInterestStartDate
                    .ParameterName = "@PatronageRefundInterestStartDate"
                    .Value = divrefParameter.PatronageRefundInterestStartDate
                End With

                Dim paramPatronageRefundInterestEndDate = myCommand.CreateParameter
                With paramPatronageRefundInterestEndDate
                    .ParameterName = "@PatronageRefundInterestEndDate"
                    .Value = divrefParameter.PatronageRefundInterestEndDate
                End With
                Dim paramCurrentUsername = myCommand.CreateParameter
                With paramCurrentUsername
                    .ParameterName = "@CurrentUsername"
                    .Value = divrefParameter.CurrentUsername
                End With

                Dim paramSystemDate = myCommand.CreateParameter
                With paramSystemDate
                    .ParameterName = "@SystemDate"
                    .Value = divrefParameter.SystemDate
                End With                

                myCommand.Parameters.Add(paramPostingYear)
                myCommand.Parameters.Add(paramPostingQuarter)
                myCommand.Parameters.Add(paramFixedDepositCutoffDate)
                myCommand.Parameters.Add(paramDividendPercentage)
                myCommand.Parameters.Add(paramPatronageRefundProcessingDate)
                myCommand.Parameters.Add(paramPatronageRefundPercentage)
                myCommand.Parameters.Add(paramPatronageRefundInterestStartDate)
                myCommand.Parameters.Add(paramPatronageRefundInterestEndDate)
                myCommand.Parameters.Add(paramCurrentUsername)
                myCommand.Parameters.Add(paramSystemDate)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub
End Class