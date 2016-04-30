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
'''DAO Class for table Div
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Div
	Inherits LUNA.LunaBaseClassEntity
    Implements _IDiv
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDiv.FillFromDataRecord
     DIV_ID = myRecord("DIV_ID")
        If Not myRecord("DATE") Is DBNull.Value Then [DATE] = myRecord("DATE")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("FD_AMT") is DBNull.Value then FD_AMT = myRecord("FD_AMT")
    		if not myRecord("DIV_AMT") is DBNull.Value then DIV_AMT = myRecord("DIV_AMT")
    		if not myRecord("DEDNS") is DBNull.Value then DEDNS = myRecord("DEDNS")
    		if not myRecord("CHKNO") is DBNull.Value then CHKNO = myRecord("CHKNO")
    		if not myRecord("CLAIMED") is DBNull.Value then CLAIMED = myRecord("CLAIMED")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Div)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(DivDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Div))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _DIV_ID as Int64  = Nothing 
Public Overridable Property DIV_ID() as Int64  Implements _IDiv.DIV_ID
    Get
	    Return _DIV_ID
    End Get
    Set (byval value as Int64)
	    If _DIV_ID <> value Then
	        IsChanged = True
	        _DIV_ID= value
	    End If
    End Set
End property 

    Protected _DATE As DateTime = Nothing
    Public Overridable Property [DATE]() As DateTime Implements _IDiv.[DATE]
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

    Protected _KBCI_NO As String = ""
    Public Overridable Property KBCI_NO() As String Implements _IDiv.KBCI_NO
        Get
            Return _KBCI_NO
        End Get
        Set(ByVal value As String)
            If _KBCI_NO <> value Then
                IsChanged = True
                _KBCI_NO = value
            End If
        End Set
    End Property

    Protected _FD_AMT As Single = 0
    Public Overridable Property FD_AMT() As Single Implements _IDiv.FD_AMT
        Get
            Return _FD_AMT
        End Get
        Set(ByVal value As Single)
            If _FD_AMT <> value Then
                IsChanged = True
                _FD_AMT = value
            End If
        End Set
    End Property

    Protected _DIV_AMT As Single = 0
    Public Overridable Property DIV_AMT() As Single Implements _IDiv.DIV_AMT
        Get
            Return _DIV_AMT
        End Get
        Set(ByVal value As Single)
            If _DIV_AMT <> value Then
                IsChanged = True
                _DIV_AMT = value
            End If
        End Set
    End Property

    Protected _DEDNS As Single = 0
    Public Overridable Property DEDNS() As Single Implements _IDiv.DEDNS
        Get
            Return _DEDNS
        End Get
        Set(ByVal value As Single)
            If _DEDNS <> value Then
                IsChanged = True
                _DEDNS = value
            End If
        End Set
    End Property

    Protected _CHKNO As String = ""
    Public Overridable Property CHKNO() As String Implements _IDiv.CHKNO
        Get
            Return _CHKNO
        End Get
        Set(ByVal value As String)
            If _CHKNO <> value Then
                IsChanged = True
                _CHKNO = value
            End If
        End Set
    End Property

    Protected _CLAIMED As DateTime = Nothing
    Public Overridable Property CLAIMED() As DateTime Implements _IDiv.CLAIMED
        Get
            Return _CLAIMED
        End Get
        Set(ByVal value As DateTime)
            If _CLAIMED <> value Then
                IsChanged = True
                _CLAIMED = value
            End If
        End Set
    End Property

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _IDiv.ADD_DATE
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


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Div from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Div = Manager.Read(Id)
                _DIV_ID = int.DIV_ID
                _DATE = int.DATE
                _KBCI_NO = int.KBCI_NO
                _FD_AMT = int.FD_AMT
                _DIV_AMT = int.DIV_AMT
                _DEDNS = int.DEDNS
                _CHKNO = int.CHKNO
                _CLAIMED = int.CLAIMED
                _ADD_DATE = int.ADD_DATE
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Div on DB.
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
        If _CHKNO.Length > 6 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Div
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDiv

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property DIV_ID() As Int64


    Property [DATE]() As DateTime


    Property KBCI_NO() As String


    Property FD_AMT() As Single


    Property DIV_AMT() As Single


    Property DEDNS() As Single


    Property CHKNO() As String


    Property CLAIMED() As DateTime


    Property ADD_DATE() As DateTime


#End Region

End Interface