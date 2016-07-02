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
'''DAO Class for table Divrefh
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class DivrefhDAO
	Inherits _DivrefhDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Function GetDividendForAllMembers(ByVal memberStatus As String, ByVal sortBy As String, ByVal postingYear As Integer, ByVal postingQuarter As Integer, ByVal filterByRegion As String) As DataTable
        Dim Sql As String
        Dim resultDataTable As New DataTable
        Try
            Sql = CustomQueryString.DividendRefundReportHistory

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramMemberStatus = myCommand.CreateParameter
                With paramMemberStatus
                    .ParameterName = "@MemberStatus"
                    .Value = memberStatus
                End With


                Dim paramSortBy = myCommand.CreateParameter
                With paramSortBy
                    .ParameterName = "@SortBy"
                    .Value = sortBy
                End With

                Dim paramPostingYear = myCommand.CreateParameter
                With paramPostingYear
                    .ParameterName = "@PostingYear"
                    .Value = postingYear
                End With

                Dim paramPostingQuarter = myCommand.CreateParameter
                With paramPostingQuarter
                    .ParameterName = "@PostingQuarter"
                    .Value = postingQuarter
                End With

                Dim parmFilterByRegion = myCommand.CreateParameter
                With parmFilterByRegion
                    .ParameterName = "@FilterByRegion"
                    .Value = filterByRegion
                End With

                myCommand.Parameters.Add(paramMemberStatus)
                myCommand.Parameters.Add(paramSortBy)
                myCommand.Parameters.Add(paramPostingYear)
                myCommand.Parameters.Add(paramPostingQuarter)
                myCommand.Parameters.Add(parmFilterByRegion)

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