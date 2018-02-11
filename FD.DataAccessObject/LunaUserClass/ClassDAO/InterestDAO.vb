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
'''DAO Class for table Interest
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class InterestDAO
    Inherits _InterestDAO

    Private Const _Table As String = "INTEREST"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub DeleteAll()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "TRUNCATE TABLE INTEREST"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub CalculatePatronageRefund(ByVal PatronageRefundInterestStartDate As Date, ByVal PatronageRefundInterestEndDate As Date, ByVal IncludeSTL As Boolean)

        Dim STLFilter As String = String.Empty

        If Not IncludeSTL Then STLFilter = InterestPostinSqlStringEnum.STLFilter
        Dim Sql As String = String.Format(InterestPostinSqlStringEnum.MembersPostingCommand, _Table, STLFilter)

        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

                Dim paramPatronageRefundInterestStartDate = myCommand.CreateParameter
                With paramPatronageRefundInterestStartDate
                    .ParameterName = "@PatronageRefundInterestStartDate"
                    .Value = PatronageRefundInterestStartDate
                End With

                Dim paramPatronageRefundInterestEndDate = myCommand.CreateParameter
                With paramPatronageRefundInterestEndDate
                    .ParameterName = "@PatronageRefundInterestEndDate"
                    .Value = PatronageRefundInterestEndDate
                End With

                Dim paramMemberStatus = myCommand.CreateParameter
                With paramMemberStatus
                    .ParameterName = "@MemberStatus"
                    .Value = MemberStatusEnum.Active
                End With


                myCommand.Parameters.Add(paramPatronageRefundInterestStartDate)
                myCommand.Parameters.Add(paramPatronageRefundInterestEndDate)
                myCommand.Parameters.Add(paramMemberStatus)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub
    Public Sub PostMembersRefund()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = String.Format(MembersPostingSqlStringEnum.UpdateMembersYtdDividendCommand, _Table)

            Dim paramMemberStatus = myCommand.CreateParameter
            With paramMemberStatus
                .ParameterName = "@MemberStatus"
                .Value = MemberStatusEnum.Active
            End With

            myCommand.Parameters.Add(paramMemberStatus)

            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
    End Sub
    Public Function GetInterestForAllMembers() As DataTable
        Dim Sql As String
        Dim tableName As String = "Interest"
        Dim ptlIntParameter As String = " NULL AS PTLINT "
        Dim resultDataTable As New DataTable
        Try
            Sql = String.Format(CustomQueryString.PatronageRefundDetailedReport, ptlIntParameter, tableName, MemberStatusEnum.Active)

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql

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