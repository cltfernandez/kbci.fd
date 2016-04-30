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
'''DAO Class for table Divref
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class DivrefDAO
	Inherits _DivrefDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub DeleteAll()
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "TRUNCATE TABLE DIVREF"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
    End Sub


    Public Sub UpdateDividendPatronageRefundRegister()

        Dim Sql As String = "INSERT INTO DIVREF([KBCI_NO],[LNAME],[FNAME],[MI],[FEBTC_SA],[DIVIDEND],[REFUND]) " & _
                    "SELECT MM.KBCI_NO,MM.LNAME,MM.FNAME,MM.MI,MM.FEBTC_SA,DV.DIV_AMT,RF.REFUND " & _
                    "FROM MEMBERS MM LEFT OUTER JOIN DIV DV ON MM.KBCI_NO=DV.KBCI_NO LEFT OUTER JOIN REF RF ON MM.KBCI_NO=RF.KBCI_NO " & _
                    "WHERE DV.DIV_AMT>0 OR RF.REFUND>0"
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = Sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

End Class