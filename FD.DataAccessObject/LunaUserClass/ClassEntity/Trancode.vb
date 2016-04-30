#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Trancode
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Trancode
	Inherits _Trancode
    Implements ITrancode

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property ID() as Int64
    Get
	    Return MyBase.ID
    End Get
    Set (byval value as Int64)
        MyBase.ID= value
    End Set
End property 


Public Overrides Property TR_ID() as string
    Get
	    Return MyBase.TR_ID
    End Get
    Set (byval value as string)
        MyBase.TR_ID= value
    End Set
End property 


Public Overrides Property TR_CODE() as string
    Get
	    Return MyBase.TR_CODE
    End Get
    Set (byval value as string)
        MyBase.TR_CODE= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ITrancode.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ITrancode.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ITrancode.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Trancode
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ITrancode
        Inherits _ITrancode

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface