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
'''DAO Class for table Ledger
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Ledger
	Inherits LUNA.LunaBaseClassEntity
    Implements _ILedger
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ILedger.FillFromDataRecord
     LEDGER_ID = myRecord("LEDGER_ID")
    		if not myRecord("PN_NO") is DBNull.Value then PN_NO = myRecord("PN_NO")
        If Not myRecord("DATE") Is DBNull.Value Then [Date] = myRecord("DATE")
    		if not myRecord("DOX_TYPE") is DBNull.Value then DOX_TYPE = myRecord("DOX_TYPE")
    		if not myRecord("REF") is DBNull.Value then REF = myRecord("REF")
    		if not myRecord("ACCT_TYPE") is DBNull.Value then ACCT_TYPE = myRecord("ACCT_TYPE")
    		if not myRecord("ACCT_CODE") is DBNull.Value then ACCT_CODE = myRecord("ACCT_CODE")
    		if not myRecord("BEGBAL") is DBNull.Value then BEGBAL = myRecord("BEGBAL")
    		if not myRecord("DR") is DBNull.Value then DR = myRecord("DR")
    		if not myRecord("CR") is DBNull.Value then CR = myRecord("CR")
    		if not myRecord("ENDBAL") is DBNull.Value then ENDBAL = myRecord("ENDBAL")
    		if not myRecord("RMK") is DBNull.Value then RMK = myRecord("RMK")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Ledger)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(LedgerDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Ledger))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _LEDGER_ID as Int64  = Nothing 
Public Overridable Property LEDGER_ID() as Int64  Implements _ILedger.LEDGER_ID
    Get
	    Return _LEDGER_ID
    End Get
    Set (byval value as Int64)
	    If _LEDGER_ID <> value Then
	        IsChanged = True
	        _LEDGER_ID= value
	    End If
    End Set
End property 

Protected _PN_NO as string  = "" 
Public Overridable Property PN_NO() as string  Implements _ILedger.PN_NO
    Get
	    Return _PN_NO
    End Get
    Set (byval value as string)
	    If _PN_NO <> value Then
	        IsChanged = True
	        _PN_NO= value
	    End If
    End Set
End property 

    Protected _DATE As DateTime = Nothing
    Public Overridable Property [DATE]() As DateTime Implements _ILedger.[DATE]
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

    Protected _DOX_TYPE As String = ""
    Public Overridable Property DOX_TYPE() As String Implements _ILedger.DOX_TYPE
        Get
            Return _DOX_TYPE
        End Get
        Set(ByVal value As String)
            If _DOX_TYPE <> value Then
                IsChanged = True
                _DOX_TYPE = value
            End If
        End Set
    End Property

    Protected _REF As String = ""
    Public Overridable Property REF() As String Implements _ILedger.REF
        Get
            Return _REF
        End Get
        Set(ByVal value As String)
            If _REF <> value Then
                IsChanged = True
                _REF = value
            End If
        End Set
    End Property

    Protected _ACCT_TYPE As String = ""
    Public Overridable Property ACCT_TYPE() As String Implements _ILedger.ACCT_TYPE
        Get
            Return _ACCT_TYPE
        End Get
        Set(ByVal value As String)
            If _ACCT_TYPE <> value Then
                IsChanged = True
                _ACCT_TYPE = value
            End If
        End Set
    End Property

    Protected _ACCT_CODE As String = ""
    Public Overridable Property ACCT_CODE() As String Implements _ILedger.ACCT_CODE
        Get
            Return _ACCT_CODE
        End Get
        Set(ByVal value As String)
            If _ACCT_CODE <> value Then
                IsChanged = True
                _ACCT_CODE = value
            End If
        End Set
    End Property

    Protected _BEGBAL As Single = 0
    Public Overridable Property BEGBAL() As Single Implements _ILedger.BEGBAL
        Get
            Return _BEGBAL
        End Get
        Set(ByVal value As Single)
            If _BEGBAL <> value Then
                IsChanged = True
                _BEGBAL = value
            End If
        End Set
    End Property

    Protected _DR As Single = 0
    Public Overridable Property DR() As Single Implements _ILedger.DR
        Get
            Return _DR
        End Get
        Set(ByVal value As Single)
            If _DR <> value Then
                IsChanged = True
                _DR = value
            End If
        End Set
    End Property

    Protected _CR As Single = 0
    Public Overridable Property CR() As Single Implements _ILedger.CR
        Get
            Return _CR
        End Get
        Set(ByVal value As Single)
            If _CR <> value Then
                IsChanged = True
                _CR = value
            End If
        End Set
    End Property

    Protected _ENDBAL As Single = 0
    Public Overridable Property ENDBAL() As Single Implements _ILedger.ENDBAL
        Get
            Return _ENDBAL
        End Get
        Set(ByVal value As Single)
            If _ENDBAL <> value Then
                IsChanged = True
                _ENDBAL = value
            End If
        End Set
    End Property

    Protected _RMK As String = ""
    Public Overridable Property RMK() As String Implements _ILedger.RMK
        Get
            Return _RMK
        End Get
        Set(ByVal value As String)
            If _RMK <> value Then
                IsChanged = True
                _RMK = value
            End If
        End Set
    End Property

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _ILedger.ADD_DATE
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

    Protected _USER As String = ""
    Public Overridable Property USER() As String Implements _ILedger.USER
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


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Ledger from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Ledger = Manager.Read(Id)
                _LEDGER_ID = int.LEDGER_ID
                _PN_NO = int.PN_NO
                _DATE = int.DATE
                _DOX_TYPE = int.DOX_TYPE
                _REF = int.REF
                _ACCT_TYPE = int.ACCT_TYPE
                _ACCT_CODE = int.ACCT_CODE
                _BEGBAL = int.BEGBAL
                _DR = int.DR
                _CR = int.CR
                _ENDBAL = int.ENDBAL
                _RMK = int.RMK
                _ADD_DATE = int.ADD_DATE
                _USER = int.USER
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Ledger on DB.
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
        If _PN_NO.Length > 7 Then Ris = False
        If _DOX_TYPE.Length > 3 Then Ris = False
        If _REF.Length > 10 Then Ris = False
        If _ACCT_TYPE.Length > 3 Then Ris = False
        If _ACCT_CODE.Length > 3 Then Ris = False
        If _RMK.Length > 35 Then Ris = False
        If _USER.Length > 8 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Ledger
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ILedger

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property LEDGER_ID() As Int64


    Property PN_NO() As String


    Property [DATE]() As DateTime


    Property DOX_TYPE() As String


    Property REF() As String


    Property ACCT_TYPE() As String


    Property ACCT_CODE() As String


    Property BEGBAL() As Single


    Property DR() As Single


    Property CR() As Single


    Property ENDBAL() As Single


    Property RMK() As String


    Property ADD_DATE() As DateTime


    Property USER() As String


#End Region

End Interface