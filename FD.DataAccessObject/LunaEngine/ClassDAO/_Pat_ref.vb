#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 16/04/2016 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Pat_ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Pat_ref
	Inherits LUNA.LunaBaseClassEntity
    Implements _IPat_ref
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IPat_ref.FillFromDataRecord
     PAT_REF_ID = myRecord("PAT_REF_ID")
    		if not myRecord("PERCENT") is DBNull.Value then PERCENT = myRecord("PERCENT")
    		if not myRecord("PROC_DATE") is DBNull.Value then PROC_DATE = myRecord("PROC_DATE")
    		if not myRecord("YTD_PCT") is DBNull.Value then YTD_PCT = myRecord("YTD_PCT")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Pat_ref)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Pat_refDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Pat_ref))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _PAT_REF_ID as Int64  = Nothing 
Public Overridable Property PAT_REF_ID() as Int64  Implements _IPat_ref.PAT_REF_ID
    Get
	    Return _PAT_REF_ID
    End Get
    Set (byval value as Int64)
	    If _PAT_REF_ID <> value Then
	        IsChanged = True
	        _PAT_REF_ID= value
	    End If
    End Set
End property 

Protected _PERCENT as single  = 0 
Public Overridable Property PERCENT() as single  Implements _IPat_ref.PERCENT
    Get
	    Return _PERCENT
    End Get
    Set (byval value as single)
	    If _PERCENT <> value Then
	        IsChanged = True
	        _PERCENT= value
	    End If
    End Set
End property 

Protected _PROC_DATE as DateTime  = Nothing 
Public Overridable Property PROC_DATE() as DateTime  Implements _IPat_ref.PROC_DATE
    Get
	    Return _PROC_DATE
    End Get
    Set (byval value as DateTime)
	    If _PROC_DATE <> value Then
	        IsChanged = True
	        _PROC_DATE= value
	    End If
    End Set
End property 

Protected _YTD_PCT as single  = 0 
Public Overridable Property YTD_PCT() as single  Implements _IPat_ref.YTD_PCT
    Get
	    Return _YTD_PCT
    End Get
    Set (byval value as single)
	    If _YTD_PCT <> value Then
	        IsChanged = True
	        _YTD_PCT= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _IPat_ref.ADD_DATE
    Get
	    Return _ADD_DATE
    End Get
    Set (byval value as DateTime)
	    If _ADD_DATE <> value Then
	        IsChanged = True
	        _ADD_DATE= value
	    End If
    End Set
End property 

Protected _CHG_DATE as DateTime  = Nothing 
Public Overridable Property CHG_DATE() as DateTime  Implements _IPat_ref.CHG_DATE
    Get
	    Return _CHG_DATE
    End Get
    Set (byval value as DateTime)
	    If _CHG_DATE <> value Then
	        IsChanged = True
	        _CHG_DATE= value
	    End If
    End Set
End property 

Protected _USER as string  = "" 
Public Overridable Property USER() as string  Implements _IPat_ref.USER
    Get
	    Return _USER
    End Get
    Set (byval value as string)
	    If _USER <> value Then
	        IsChanged = True
	        _USER= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Pat_ref from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Pat_ref = Manager.Read(Id)
                    _PAT_REF_ID = int.PAT_REF_ID
                    _PERCENT = int.PERCENT
                    _PROC_DATE = int.PROC_DATE
                    _YTD_PCT = int.YTD_PCT
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _USER = int.USER
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Pat_ref on DB.
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
	  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Pat_ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IPat_ref

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property PAT_REF_ID() as Int64

    
    Property PERCENT() as single

    
    Property PROC_DATE() as DateTime

    
    Property YTD_PCT() as single

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
#End Region

End Interface