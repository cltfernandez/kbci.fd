#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table User
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _User
	Inherits LUNA.LunaBaseClassEntity
    Implements _IUser
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IUser.FillFromDataRecord
     USER_ID = myRecord("USER_ID")
    		if not myRecord("USERNAME") is DBNull.Value then USERNAME = myRecord("USERNAME")
    		if not myRecord("USERPASS") is DBNull.Value then USERPASS = myRecord("USERPASS")
    		if not myRecord("LEVEL") is DBNull.Value then LEVEL = myRecord("LEVEL")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("NAME") is DBNull.Value then NAME = myRecord("NAME")
    		if not myRecord("POSITION") is DBNull.Value then POSITION = myRecord("POSITION")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("LOGGED") is DBNull.Value then LOGGED = myRecord("LOGGED")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of User)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(UserDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of User))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _USER_ID as Int64  = Nothing 
Public Overridable Property USER_ID() as Int64  Implements _IUser.USER_ID
    Get
	    Return _USER_ID
    End Get
    Set (byval value as Int64)
	    If _USER_ID <> value Then
	        IsChanged = True
	        _USER_ID= value
	    End If
    End Set
End property 

Protected _USERNAME as string  = "" 
Public Overridable Property USERNAME() as string  Implements _IUser.USERNAME
    Get
	    Return _USERNAME
    End Get
    Set (byval value as string)
	    If _USERNAME <> value Then
	        IsChanged = True
	        _USERNAME= value
	    End If
    End Set
End property 

Protected _USERPASS as string  = "" 
Public Overridable Property USERPASS() as string  Implements _IUser.USERPASS
    Get
	    Return _USERPASS
    End Get
    Set (byval value as string)
	    If _USERPASS <> value Then
	        IsChanged = True
	        _USERPASS= value
	    End If
    End Set
End property 

Protected _LEVEL as string  = "" 
Public Overridable Property LEVEL() as string  Implements _IUser.LEVEL
    Get
	    Return _LEVEL
    End Get
    Set (byval value as string)
	    If _LEVEL <> value Then
	        IsChanged = True
	        _LEVEL= value
	    End If
    End Set
End property 

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _IUser.ADD_DATE
        Get
            Return _ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            If _ADD_DATE <> value Then
                IsChanged = True
                _ADD_DATE = value
            End If
        End Set
    End Property

    Protected _CHG_DATE As DateTime = Nothing
    Public Overridable Property CHG_DATE() As DateTime Implements _IUser.CHG_DATE
        Get
            Return _CHG_DATE
        End Get
        Set(ByVal value As DateTime)
            If _CHG_DATE <> value Then
                IsChanged = True
                _CHG_DATE = value
            End If
        End Set
    End Property

    Protected _NAME As String = ""
    Public Overridable Property NAME() As String Implements _IUser.NAME
        Get
            Return _NAME
        End Get
        Set(ByVal value As String)
            If _NAME <> value Then
                IsChanged = True
                _NAME = value
            End If
        End Set
    End Property

    Protected _POSITION As String = ""
    Public Overridable Property POSITION() As String Implements _IUser.POSITION
        Get
            Return _POSITION
        End Get
        Set(ByVal value As String)
            If _POSITION <> value Then
                IsChanged = True
                _POSITION = value
            End If
        End Set
    End Property

    Protected _USER As String = ""
    Public Overridable Property USER() As String Implements _IUser.USER
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            If _USER <> value Then
                IsChanged = True
                _USER = value
            End If
        End Set
    End Property

    Protected _LOGGED As Boolean = False
    Public Overridable Property LOGGED() As Boolean Implements _IUser.LOGGED
        Get
            Return _LOGGED
        End Get
        Set(ByVal value As Boolean)
            If _LOGGED <> value Then
                IsChanged = True
                _LOGGED = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an User from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As User = Manager.Read(Id)
                _USER_ID = int.USER_ID
                _USERNAME = int.USERNAME
                _USERPASS = int.USERPASS
                _LEVEL = int.LEVEL
                _ADD_DATE = int.ADD_DATE
                _CHG_DATE = int.CHG_DATE
                _NAME = int.NAME
                _POSITION = int.POSITION
                _USER = int.USER
                _LOGGED = int.LOGGED
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an User on DB.
    ''' </summary>
    ''' <returns>
    '''Return Id insert in DB if all ok, 0 if error
    ''' </returns>
    Public Overridable Function Save() As Integer
        'Return the id Inserted
        Dim Ris As Integer = 0
        Try
            Using Manager
                Ris = Manager.Save(Me)
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function

    Protected Function InternalIsValid() As Boolean
        Dim Ris As Boolean = True
        If _USERNAME.Length > 8 Then Ris = False
        If _USERPASS.Length > 50 Then Ris = False
        If _LEVEL.Length > 1 Then Ris = False
        If _NAME.Length > 30 Then Ris = False
        If _POSITION.Length > 15 Then Ris = False
        If _USER.Length > 8 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table User
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IUser

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property USER_ID() As Int64


    Property USERNAME() As String


    Property USERPASS() As String


    Property LEVEL() As String


    Property ADD_DATE() As DateTime


    Property CHG_DATE() As DateTime


    Property NAME() As String


    Property POSITION() As String


    Property USER() As String


    Property LOGGED() As Boolean


#End Region

End Interface