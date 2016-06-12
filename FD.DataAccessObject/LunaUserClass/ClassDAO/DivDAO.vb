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
'''DAO Class for table Div
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class DivDAO
	Inherits _DivDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub PostDividendsForMembers(ByVal DividendPercentage As Decimal, ByVal SystemDate As Date, ByVal FixedDepositCutOffDate As Date, ByVal ProcessingDate As Date)

        Dim Sql As String = "INSERT INTO DIV([DATE],[KBCI_NO],[FD_AMT],[DIV_AMT],[DEDNS],[ADD_DATE]) " & _
                              "SELECT @ProcessingDate AS DATE,MEM.KBCI_NO, FD.BALANCE, FD.BALANCE * @DividendPercentage AS DIV_AMT, 0 AS DEDNS,@SystemDate AS ADD_DATE  FROM FD  " & _
                              "RIGHT OUTER JOIN (SELECT MAX(FD_ID) FD_ID FROM FD WHERE KBCI_NO + convert(varchar(30), [DATE]) in " & _
                              "( select KBCI_NO + convert(varchar(30), MAX([DATE])) K_D from FD where [DATE] <= @FixedDepositCutOffDate group by KBCI_NO) " & _
                              "group by KBCI_NO ) B on FD.FD_ID = B.FD_ID RIGHT JOIN MEMBERS MEM on FD.KBCI_NO = MEM.KBCI_NO"


        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramDividendPercentage = myCommand.CreateParameter
                With paramDividendPercentage
                    .ParameterName = "@DividendPercentage"
                    .Value = DividendPercentage
                End With

                Dim paramSystemDate = myCommand.CreateParameter
                With paramSystemDate
                    .ParameterName = "@SystemDate"
                    .Value = SystemDate
                End With

                Dim paramFixedDepositCutOffDate = myCommand.CreateParameter
                With paramFixedDepositCutOffDate
                    .ParameterName = "@FixedDepositCutOffDate"
                    .Value = FixedDepositCutOffDate
                End With

                Dim paramProcessingDate = myCommand.CreateParameter
                With paramProcessingDate
                    .ParameterName = "@ProcessingDate"
                    .Value = ProcessingDate
                End With

                myCommand.Parameters.Add(paramDividendPercentage)
                myCommand.Parameters.Add(paramSystemDate)
                myCommand.Parameters.Add(paramFixedDepositCutOffDate)
                myCommand.Parameters.Add(paramProcessingDate)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub


    Public Sub DeleteAll()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "TRUNCATE TABLE DIV"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
    End Sub


    Public Function GetDividendsByRegion(ByVal SortBy As String, Optional ByVal RegionFilter As String = "") As DataTable
        Dim Sql As String

        Dim resultDataTable As New DataTable

        Try
            Sql = String.Format("SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                  "DIV.DIV_AMT, DIV.DEDNS,MEM.REGION FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE DIV.FD_AMT>0 AND (@SelectedRegion = '' OR @SelectedRegion = REGION) ORDER BY {0}", SortBy)

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql
                Dim paramSelectedRegion = myCommand.CreateParameter
                With paramSelectedRegion
                    .ParameterName = "@SelectedRegion"
                    .Value = RegionFilter
                End With

                myCommand.Parameters.Add(paramSelectedRegion)

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