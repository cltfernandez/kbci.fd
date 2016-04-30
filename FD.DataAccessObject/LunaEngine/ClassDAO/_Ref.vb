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
'''DAO Class for table Ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Ref
	Inherits LUNA.LunaBaseClassEntity
    Implements _IRef
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IRef.FillFromDataRecord
     REF_ID = myRecord("REF_ID")
    		if not myRecord("DATE") is DBNull.Value then [DATE] = myRecord("DATE")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("INT_PAID") is DBNull.Value then INT_PAID = myRecord("INT_PAID")
    		if not myRecord("REFUND") is DBNull.Value then REFUND = myRecord("REFUND")
    		if not myRecord("CLAIMED") is DBNull.Value then CLAIMED = myRecord("CLAIMED")
    		if not myRecord("DEDNS") is DBNull.Value then DEDNS = myRecord("DEDNS")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Ref)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(RefDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Ref))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _REF_ID as Int64  = Nothing 
Public Overridable Property REF_ID() as Int64  Implements _IRef.REF_ID
    Get
	    Return _REF_ID
    End Get
    Set (byval value as Int64)
	    If _REF_ID <> value Then
	        IsChanged = True
	        _REF_ID= value
	    End If
    End Set
End property 

Protected _DATE as DateTime  = Nothing 
    Public Overridable Property [DATE]() As DateTime Implements _IRef.[DATE]
        Get
            Return _DATE
        End Get
        Set(ByVal value As DateTime)
            If _DATE <> value Then
                IsChanged = True
                _DATE = value
            End If
        End Set
    End Property

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IRef.KBCI_NO
    Get
	    Return _KBCI_NO
    End Get
    Set (byval value as string)
	    If _KBCI_NO <> value Then
	        IsChanged = True
	        _KBCI_NO= value
	    End If
    End Set
End property 

Protected _INT_PAID as single  = 0 
Public Overridable Property INT_PAID() as single  Implements _IRef.INT_PAID
    Get
	    Return _INT_PAID
    End Get
    Set (byval value as single)
	    If _INT_PAID <> value Then
	        IsChanged = True
	        _INT_PAID= value
	    End If
    End Set
End property 

Protected _REFUND as single  = 0 
Public Overridable Property REFUND() as single  Implements _IRef.REFUND
    Get
	    Return _REFUND
    End Get
    Set (byval value as single)
	    If _REFUND <> value Then
	        IsChanged = True
	        _REFUND= value
	    End If
    End Set
End property 

Protected _CLAIMED as Boolean  = False 
Public Overridable Property CLAIMED() as Boolean  Implements _IRef.CLAIMED
    Get
	    Return _CLAIMED
    End Get
    Set (byval value as Boolean)
	    If _CLAIMED <> value Then
	        IsChanged = True
	        _CLAIMED= value
	    End If
    End Set
End property 

Protected _DEDNS as single  = 0 
Public Overridable Property DEDNS() as single  Implements _IRef.DEDNS
    Get
	    Return _DEDNS
    End Get
    Set (byval value as single)
	    If _DEDNS <> value Then
	        IsChanged = True
	        _DEDNS= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Ref from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Ref = Manager.Read(Id)
                    _REF_ID = int.REF_ID
                _DATE = int.[DATE]
                    _KBCI_NO = int.KBCI_NO
                    _INT_PAID = int.INT_PAID
                    _REFUND = int.REFUND
                    _CLAIMED = int.CLAIMED
                    _DEDNS = int.DEDNS
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Ref on DB.
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
	  if _KBCI_NO.Length > 7 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IRef

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property REF_ID() as Int64

    
    Property [DATE]() As DateTime

    
    Property KBCI_NO() as string

    
    Property INT_PAID() as single

    
    Property REFUND() as single

    
    Property CLAIMED() as Boolean

    
    Property DEDNS() as single

    
#End Region

End Interface