#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table User
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class User
	Inherits _User
    Implements IUser

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property USER_ID() as Int64
    Get
	    Return MyBase.USER_ID
    End Get
    Set (byval value as Int64)
        MyBase.USER_ID= value
    End Set
End property 


Public Overrides Property USERNAME() as string
    Get
	    Return MyBase.USERNAME
    End Get
    Set (byval value as string)
        MyBase.USERNAME= value
    End Set
End property 


Public Overrides Property USERPASS() as string
    Get
	    Return MyBase.USERPASS
    End Get
    Set (byval value as string)
        MyBase.USERPASS= value
    End Set
End property 


Public Overrides Property LEVEL() as string
    Get
	    Return MyBase.LEVEL
    End Get
    Set (byval value as string)
        MyBase.LEVEL= value
    End Set
End property 


    Public Overrides Property ADD_DATE() As DateTime
        Get
            Return MyBase.ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.ADD_DATE = value
        End Set
    End Property


    Public Overrides Property CHG_DATE() As DateTime
        Get
            Return MyBase.CHG_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.CHG_DATE = value
        End Set
    End Property


Public Overrides Property NAME() as string
    Get
	    Return MyBase.NAME
    End Get
    Set (byval value as string)
        MyBase.NAME= value
    End Set
End property 


Public Overrides Property POSITION() as string
    Get
	    Return MyBase.POSITION
    End Get
    Set (byval value as string)
        MyBase.POSITION= value
    End Set
End property 


Public Overrides Property USER() as string
    Get
	    Return MyBase.USER
    End Get
    Set (byval value as string)
        MyBase.USER= value
    End Set
End property 


Public Overrides Property LOGGED() as Boolean
    Get
	    Return MyBase.LOGGED
    End Get
    Set (byval value as Boolean)
        MyBase.LOGGED= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IUser.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IUser.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IUser.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table User
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IUser
        Inherits _IUser

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface