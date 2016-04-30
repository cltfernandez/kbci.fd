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
'''DAO Class for table Trancode
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Trancode
	Inherits LUNA.LunaBaseClassEntity
    Implements _ITrancode
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ITrancode.FillFromDataRecord
     		if not myRecord("ID") is DBNull.Value then ID = myRecord("ID")
    		if not myRecord("TR_ID") is DBNull.Value then TR_ID = myRecord("TR_ID")
    		if not myRecord("TR_CODE") is DBNull.Value then TR_CODE = myRecord("TR_CODE")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Trancode)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(TrancodeDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Trancode))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _ID as Int64  = Nothing 
Public Overridable Property ID() as Int64  Implements _ITrancode.ID
    Get
	    Return _ID
    End Get
    Set (byval value as Int64)
	    If _ID <> value Then
	        IsChanged = True
	        _ID= value
	    End If
    End Set
End property 

Protected _TR_ID as string  = "" 
Public Overridable Property TR_ID() as string  Implements _ITrancode.TR_ID
    Get
	    Return _TR_ID
    End Get
    Set (byval value as string)
	    If _TR_ID <> value Then
	        IsChanged = True
	        _TR_ID= value
	    End If
    End Set
End property 

Protected _TR_CODE as string  = "" 
Public Overridable Property TR_CODE() as string  Implements _ITrancode.TR_CODE
    Get
	    Return _TR_CODE
    End Get
    Set (byval value as string)
	    If _TR_CODE <> value Then
	        IsChanged = True
	        _TR_CODE= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Trancode from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Trancode = Manager.Read(Id)
                    _ID = int.ID
                    _TR_ID = int.TR_ID
                    _TR_CODE = int.TR_CODE
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Trancode on DB.
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
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ris
End Function

Protected Function InternalIsValid() As Boolean
	Dim Ris As Boolean = True
	  if _TR_ID.Length > 2 then Ris = False
  if _TR_CODE.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Trancode
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ITrancode

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property ID() as Int64

    
    Property TR_ID() as string

    
    Property TR_CODE() as string

    
#End Region

End Interface