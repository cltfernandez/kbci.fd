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

End Class