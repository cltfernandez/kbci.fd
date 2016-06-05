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
'''DAO Class for table Members
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class MembersDAO
	Inherits _MembersDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub ResetMembersYtdDividend()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "UPDATE MEMBERS SET YTD_DIVAMT=0"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using

    End Sub

    Public Function GetActiveMembers(ByVal SystemDate As Date) As DataTable
        Dim Sql As String
        Dim resultDataTable As New DataTable
        Try
            Sql = "SELECT [KBCI_NO],[LNAME]+ ', ' + [FNAME] + ' ' + [MI] + '.' AS NAME,[MEM_ADDR],[MEM_CODE],[MEM_STAT],[DORI],[REA_DORI]," & _
                   "[FEBTC_SA],[CB_EMPNO],[CB_HIRE],[REGION],[DEPT],[POSITION],[OFF_TEL],[RES_TEL],[SAL_BAS],[SAL_ALL],[OTH_INC]," & _
                   "[SEX],[CIV_STAT],[NO_DEPEND],[B_DATE],[SP_NAME],[SP_EMPLOY],[SP_CBEMPNO] AS SP_CBEMPN,[SP_OFFTEL],[SP_SALARY] AS SP_SAL FROM MEMBERS " & _
                   "WHERE MEM_DATE <=@SystemDate"

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql
                Dim paramSystemDate = myCommand.CreateParameter
                With paramSystemDate
                    .ParameterName = "@SystemDate"
                    .Value = SystemDate
                End With

                myCommand.Parameters.Add(paramSystemDate)

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