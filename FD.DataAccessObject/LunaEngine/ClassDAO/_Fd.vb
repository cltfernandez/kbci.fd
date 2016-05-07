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
'''DAO Class for table Fd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Fd
	Inherits LUNA.LunaBaseClassEntity
    Implements _IFd
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IFd.FillFromDataRecord
     FD_ID = myRecord("FD_ID")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("TRAN_CODE") is DBNull.Value then TRAN_CODE = myRecord("TRAN_CODE")
        If Not myRecord("DATE") Is DBNull.Value Then [Date] = myRecord("DATE")
    		if not myRecord("REF") is DBNull.Value then REF = myRecord("REF")
    		if not myRecord("AMOUNT") is DBNull.Value then AMOUNT = myRecord("AMOUNT")
    		if not myRecord("BALANCE") is DBNull.Value then BALANCE = myRecord("BALANCE")
    		if not myRecord("RMK") is DBNull.Value then RMK = myRecord("RMK")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("LPOSTED") is DBNull.Value then LPOSTED = myRecord("LPOSTED")
    		if not myRecord("DRCR") is DBNull.Value then DRCR = myRecord("DRCR")
    		if not myRecord("BANK_CODE") is DBNull.Value then BANK_CODE = myRecord("BANK_CODE")
    		if not myRecord("CHECKNO") is DBNull.Value then CHECKNO = myRecord("CHECKNO")
    		if not myRecord("TPOSTED") is DBNull.Value then TPOSTED = myRecord("TPOSTED")
    		if not myRecord("TREVERSED") is DBNull.Value then TREVERSED = myRecord("TREVERSED")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Fd)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(FdDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Fd))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _FD_ID as Int64  = Nothing 
Public Overridable Property FD_ID() as Int64  Implements _IFd.FD_ID
    Get
	    Return _FD_ID
    End Get
    Set (byval value as Int64)
	    If _FD_ID <> value Then
	        IsChanged = True
	        _FD_ID= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IFd.KBCI_NO
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

Protected _TRAN_CODE as string  = "" 
Public Overridable Property TRAN_CODE() as string  Implements _IFd.TRAN_CODE
    Get
	    Return _TRAN_CODE
    End Get
    Set (byval value as string)
	    If _TRAN_CODE <> value Then
	        IsChanged = True
	        _TRAN_CODE= value
	    End If
    End Set
End property 

    Protected _DATE As DateTime = Nothing
    Public Overridable Property [DATE]() As DateTime Implements _IFd.[DATE]
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

    Protected _REF As String = ""
    Public Overridable Property REF() As String Implements _IFd.REF
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

    Protected _AMOUNT As Single = 0
    Public Overridable Property AMOUNT() As Single Implements _IFd.AMOUNT
        Get
            Return _AMOUNT
        End Get
        Set(ByVal value As Single)
            If _AMOUNT <> value Then
                IsChanged = True
                _AMOUNT = value
            End If
        End Set
    End Property

    Protected _BALANCE As Single = 0
    Public Overridable Property BALANCE() As Single Implements _IFd.BALANCE
        Get
            Return _BALANCE
        End Get
        Set(ByVal value As Single)
            If _BALANCE <> value Then
                IsChanged = True
                _BALANCE = value
            End If
        End Set
    End Property

    Protected _RMK As String = ""
    Public Overridable Property RMK() As String Implements _IFd.RMK
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
    Public Overridable Property ADD_DATE() As DateTime Implements _IFd.ADD_DATE
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
    Public Overridable Property USER() As String Implements _IFd.USER
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

    Protected _LPOSTED As Single = 0
    Public Overridable Property LPOSTED() As Single Implements _IFd.LPOSTED
        Get
            Return _LPOSTED
        End Get
        Set(ByVal value As Single)
            If _LPOSTED <> value Then
                IsChanged = True
                _LPOSTED = value
            End If
        End Set
    End Property

    Protected _DRCR As String = ""
    Public Overridable Property DRCR() As String Implements _IFd.DRCR
        Get
            Return _DRCR
        End Get
        Set(ByVal value As String)
            If _DRCR <> value Then
                IsChanged = True
                _DRCR = value
            End If
        End Set
    End Property

    Protected _BANK_CODE As String = ""
    Public Overridable Property BANK_CODE() As String Implements _IFd.BANK_CODE
        Get
            Return _BANK_CODE
        End Get
        Set(ByVal value As String)
            If _BANK_CODE <> value Then
                IsChanged = True
                _BANK_CODE = value
            End If
        End Set
    End Property

    Protected _CHECKNO As String = ""
    Public Overridable Property CHECKNO() As String Implements _IFd.CHECKNO
        Get
            Return _CHECKNO
        End Get
        Set(ByVal value As String)
            If _CHECKNO <> value Then
                IsChanged = True
                _CHECKNO = value
            End If
        End Set
    End Property

    Protected _TPOSTED As Boolean = False
    Public Overridable Property TPOSTED() As Boolean Implements _IFd.TPOSTED
        Get
            Return _TPOSTED
        End Get
        Set(ByVal value As Boolean)
            If _TPOSTED <> value Then
                IsChanged = True
                _TPOSTED = value
            End If
        End Set
    End Property

    Protected _TREVERSED As Boolean = False
    Public Overridable Property TREVERSED() As Boolean Implements _IFd.TREVERSED
        Get
            Return _TREVERSED
        End Get
        Set(ByVal value As Boolean)
            If _TREVERSED <> value Then
                IsChanged = True
                _TREVERSED = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Fd from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Fd = Manager.Read(Id)
                _FD_ID = int.FD_ID
                _KBCI_NO = int.KBCI_NO
                _TRAN_CODE = int.TRAN_CODE
                _DATE = int.DATE
                _REF = int.REF
                _AMOUNT = int.AMOUNT
                _BALANCE = int.BALANCE
                _RMK = int.RMK
                _ADD_DATE = int.ADD_DATE
                _USER = int.USER
                _LPOSTED = int.LPOSTED
                _DRCR = int.DRCR
                _BANK_CODE = int.BANK_CODE
                _CHECKNO = int.CHECKNO
                _TPOSTED = int.TPOSTED
                _TREVERSED = int.TREVERSED
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Fd on DB.
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
        If _KBCI_NO.Length > 7 Then Ris = False
        If _TRAN_CODE.Length > 1 Then Ris = False
        If _REF.Length > 20 Then Ris = False
        If _RMK.Length > 40 Then Ris = False
        If _USER.Length > 8 Then Ris = False
        If _DRCR.Length > 2 Then Ris = False
        If _BANK_CODE.Length > 15 Then Ris = False
        If _CHECKNO.Length > 15 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Fd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IFd

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property FD_ID() As Int64


    Property KBCI_NO() As String


    Property TRAN_CODE() As String


    Property [DATE]() As DateTime


    Property REF() As String


    Property AMOUNT() As Single


    Property BALANCE() As Single


    Property RMK() As String


    Property ADD_DATE() As DateTime


    Property USER() As String


    Property LPOSTED() As Single


    Property DRCR() As String


    Property BANK_CODE() As String


    Property CHECKNO() As String


    Property TPOSTED() As Boolean


    Property TREVERSED() As Boolean


#End Region

End Interface