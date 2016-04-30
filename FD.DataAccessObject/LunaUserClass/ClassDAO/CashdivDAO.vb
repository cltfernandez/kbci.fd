#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 10/04/2016 
#End Region


Imports System.Data.Common

''' <summary>
'''DAO Class for table Cashdiv
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class CashdivDAO
	Inherits _CashdivDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub


End Class