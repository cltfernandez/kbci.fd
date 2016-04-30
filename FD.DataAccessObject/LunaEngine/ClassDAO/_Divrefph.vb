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
'''DAO Class for table Divrefph
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Divrefph
	Inherits LUNA.LunaBaseClassEntity
    Implements _IDivrefph
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDivrefph.FillFromDataRecord
     DIVREFPH_ID = myRecord("DIVREFPH_ID")
    		if not myRecord("YEAR") is DBNull.Value then YEAR = myRecord("YEAR")
    		if not myRecord("QUARTER") is DBNull.Value then QUARTER = myRecord("QUARTER")
    		if not myRecord("FD_CUTOFF") is DBNull.Value then FD_CUTOFF = myRecord("FD_CUTOFF")
    		if not myRecord("FD_PERCENT") is DBNull.Value then FD_PERCENT = myRecord("FD_PERCENT")
    		if not myRecord("PR_YEAR") is DBNull.Value then PR_YEAR = myRecord("PR_YEAR")
    		if not myRecord("PR_PERCENT") is DBNull.Value then PR_PERCENT = myRecord("PR_PERCENT")
    		if not myRecord("PR_INTFROM") is DBNull.Value then PR_INTFROM = myRecord("PR_INTFROM")
    		if not myRecord("PR_INTTO") is DBNull.Value then PR_INTTO = myRecord("PR_INTTO")
    		if not myRecord("TDEBDESC1") is DBNull.Value then TDEBDESC1 = myRecord("TDEBDESC1")
    		if not myRecord("TDEBAMT1") is DBNull.Value then TDEBAMT1 = myRecord("TDEBAMT1")
    		if not myRecord("TDEBDESC2") is DBNull.Value then TDEBDESC2 = myRecord("TDEBDESC2")
    		if not myRecord("TDEBAMT2") is DBNull.Value then TDEBAMT2 = myRecord("TDEBAMT2")
    		if not myRecord("TDEBDESC3") is DBNull.Value then TDEBDESC3 = myRecord("TDEBDESC3")
    		if not myRecord("TDEBAMT3") is DBNull.Value then TDEBAMT3 = myRecord("TDEBAMT3")
    		if not myRecord("TDIVAMT") is DBNull.Value then TDIVAMT = myRecord("TDIVAMT")
    		if not myRecord("TREFAMT") is DBNull.Value then TREFAMT = myRecord("TREFAMT")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("HOLDOUT") is DBNull.Value then HOLDOUT = myRecord("HOLDOUT")
    		if not myRecord("POSTED") is DBNull.Value then POSTED = myRecord("POSTED")
    		if not myRecord("CVNO") is DBNull.Value then CVNO = myRecord("CVNO")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("P_APL") is DBNull.Value then P_APL = myRecord("P_APL")
    		if not myRecord("P_EDL") is DBNull.Value then P_EDL = myRecord("P_EDL")
    		if not myRecord("P_EML") is DBNull.Value then P_EML = myRecord("P_EML")
    		if not myRecord("P_RGL") is DBNull.Value then P_RGL = myRecord("P_RGL")
    		if not myRecord("P_RSL") is DBNull.Value then P_RSL = myRecord("P_RSL")
    		if not myRecord("P_SPL") is DBNull.Value then P_SPL = myRecord("P_SPL")
    		if not myRecord("P_STL") is DBNull.Value then P_STL = myRecord("P_STL")
    		if not myRecord("P_PTL") is DBNull.Value then P_PTL = myRecord("P_PTL")
    		if not myRecord("PD_APL") is DBNull.Value then PD_APL = myRecord("PD_APL")
    		if not myRecord("PD_EDL") is DBNull.Value then PD_EDL = myRecord("PD_EDL")
    		if not myRecord("PD_EML") is DBNull.Value then PD_EML = myRecord("PD_EML")
    		if not myRecord("PD_RGL") is DBNull.Value then PD_RGL = myRecord("PD_RGL")
    		if not myRecord("PD_RSL") is DBNull.Value then PD_RSL = myRecord("PD_RSL")
    		if not myRecord("PD_SPL") is DBNull.Value then PD_SPL = myRecord("PD_SPL")
    		if not myRecord("PD_STL") is DBNull.Value then PD_STL = myRecord("PD_STL")
    		if not myRecord("PD_PTL") is DBNull.Value then PD_PTL = myRecord("PD_PTL")
    		if not myRecord("INTEREST") is DBNull.Value then INTEREST = myRecord("INTEREST")
    		if not myRecord("PENALTY") is DBNull.Value then PENALTY = myRecord("PENALTY")
    		if not myRecord("SAVINGS") is DBNull.Value then SAVINGS = myRecord("SAVINGS")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Divrefph)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(DivrefphDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Divrefph))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _DIVREFPH_ID as Int64  = Nothing 
Public Overridable Property DIVREFPH_ID() as Int64  Implements _IDivrefph.DIVREFPH_ID
    Get
	    Return _DIVREFPH_ID
    End Get
    Set (byval value as Int64)
	    If _DIVREFPH_ID <> value Then
	        IsChanged = True
	        _DIVREFPH_ID= value
	    End If
    End Set
End property 

Protected _YEAR as string  = "" 
Public Overridable Property YEAR() as string  Implements _IDivrefph.YEAR
    Get
	    Return _YEAR
    End Get
    Set (byval value as string)
	    If _YEAR <> value Then
	        IsChanged = True
	        _YEAR= value
	    End If
    End Set
End property 

Protected _QUARTER as string  = "" 
Public Overridable Property QUARTER() as string  Implements _IDivrefph.QUARTER
    Get
	    Return _QUARTER
    End Get
    Set (byval value as string)
	    If _QUARTER <> value Then
	        IsChanged = True
	        _QUARTER= value
	    End If
    End Set
End property 

    Protected _FD_CUTOFF As DateTime = Nothing
    Public Overridable Property FD_CUTOFF() As DateTime Implements _IDivrefph.FD_CUTOFF
        Get
            Return _FD_CUTOFF
        End Get
        Set(ByVal value As DateTime)
            If _FD_CUTOFF <> value Then
                IsChanged = True
                _FD_CUTOFF = value
            End If
        End Set
    End Property

    Protected _FD_PERCENT As Single = 0
    Public Overridable Property FD_PERCENT() As Single Implements _IDivrefph.FD_PERCENT
        Get
            Return _FD_PERCENT
        End Get
        Set(ByVal value As Single)
            If _FD_PERCENT <> value Then
                IsChanged = True
                _FD_PERCENT = value
            End If
        End Set
    End Property

    Protected _PR_YEAR As String = ""
    Public Overridable Property PR_YEAR() As String Implements _IDivrefph.PR_YEAR
        Get
            Return _PR_YEAR
        End Get
        Set(ByVal value As String)
            If _PR_YEAR <> value Then
                IsChanged = True
                _PR_YEAR = value
            End If
        End Set
    End Property

    Protected _PR_PERCENT As Single = 0
    Public Overridable Property PR_PERCENT() As Single Implements _IDivrefph.PR_PERCENT
        Get
            Return _PR_PERCENT
        End Get
        Set(ByVal value As Single)
            If _PR_PERCENT <> value Then
                IsChanged = True
                _PR_PERCENT = value
            End If
        End Set
    End Property

    Protected _PR_INTFROM As DateTime = Nothing
    Public Overridable Property PR_INTFROM() As DateTime Implements _IDivrefph.PR_INTFROM
        Get
            Return _PR_INTFROM
        End Get
        Set(ByVal value As DateTime)
            If _PR_INTFROM <> value Then
                IsChanged = True
                _PR_INTFROM = value
            End If
        End Set
    End Property

    Protected _PR_INTTO As DateTime = Nothing
    Public Overridable Property PR_INTTO() As DateTime Implements _IDivrefph.PR_INTTO
        Get
            Return _PR_INTTO
        End Get
        Set(ByVal value As DateTime)
            If _PR_INTTO <> value Then
                IsChanged = True
                _PR_INTTO = value
            End If
        End Set
    End Property

    Protected _TDEBDESC1 As String = ""
    Public Overridable Property TDEBDESC1() As String Implements _IDivrefph.TDEBDESC1
        Get
            Return _TDEBDESC1
        End Get
        Set(ByVal value As String)
            If _TDEBDESC1 <> value Then
                IsChanged = True
                _TDEBDESC1 = value
            End If
        End Set
    End Property

    Protected _TDEBAMT1 As Single = 0
    Public Overridable Property TDEBAMT1() As Single Implements _IDivrefph.TDEBAMT1
        Get
            Return _TDEBAMT1
        End Get
        Set(ByVal value As Single)
            If _TDEBAMT1 <> value Then
                IsChanged = True
                _TDEBAMT1 = value
            End If
        End Set
    End Property

    Protected _TDEBDESC2 As String = ""
    Public Overridable Property TDEBDESC2() As String Implements _IDivrefph.TDEBDESC2
        Get
            Return _TDEBDESC2
        End Get
        Set(ByVal value As String)
            If _TDEBDESC2 <> value Then
                IsChanged = True
                _TDEBDESC2 = value
            End If
        End Set
    End Property

    Protected _TDEBAMT2 As Single = 0
    Public Overridable Property TDEBAMT2() As Single Implements _IDivrefph.TDEBAMT2
        Get
            Return _TDEBAMT2
        End Get
        Set(ByVal value As Single)
            If _TDEBAMT2 <> value Then
                IsChanged = True
                _TDEBAMT2 = value
            End If
        End Set
    End Property

    Protected _TDEBDESC3 As String = ""
    Public Overridable Property TDEBDESC3() As String Implements _IDivrefph.TDEBDESC3
        Get
            Return _TDEBDESC3
        End Get
        Set(ByVal value As String)
            If _TDEBDESC3 <> value Then
                IsChanged = True
                _TDEBDESC3 = value
            End If
        End Set
    End Property

    Protected _TDEBAMT3 As Single = 0
    Public Overridable Property TDEBAMT3() As Single Implements _IDivrefph.TDEBAMT3
        Get
            Return _TDEBAMT3
        End Get
        Set(ByVal value As Single)
            If _TDEBAMT3 <> value Then
                IsChanged = True
                _TDEBAMT3 = value
            End If
        End Set
    End Property

    Protected _TDIVAMT As Single = 0
    Public Overridable Property TDIVAMT() As Single Implements _IDivrefph.TDIVAMT
        Get
            Return _TDIVAMT
        End Get
        Set(ByVal value As Single)
            If _TDIVAMT <> value Then
                IsChanged = True
                _TDIVAMT = value
            End If
        End Set
    End Property

    Protected _TREFAMT As Single = 0
    Public Overridable Property TREFAMT() As Single Implements _IDivrefph.TREFAMT
        Get
            Return _TREFAMT
        End Get
        Set(ByVal value As Single)
            If _TREFAMT <> value Then
                IsChanged = True
                _TREFAMT = value
            End If
        End Set
    End Property

    Protected _USER As String = ""
    Public Overridable Property USER() As String Implements _IDivrefph.USER
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

    Protected _HOLDOUT As Boolean = False
    Public Overridable Property HOLDOUT() As Boolean Implements _IDivrefph.HOLDOUT
        Get
            Return _HOLDOUT
        End Get
        Set(ByVal value As Boolean)
            If _HOLDOUT <> value Then
                IsChanged = True
                _HOLDOUT = value
            End If
        End Set
    End Property

    Protected _POSTED As Boolean = False
    Public Overridable Property POSTED() As Boolean Implements _IDivrefph.POSTED
        Get
            Return _POSTED
        End Get
        Set(ByVal value As Boolean)
            If _POSTED <> value Then
                IsChanged = True
                _POSTED = value
            End If
        End Set
    End Property

    Protected _CVNO As String = ""
    Public Overridable Property CVNO() As String Implements _IDivrefph.CVNO
        Get
            Return _CVNO
        End Get
        Set(ByVal value As String)
            If _CVNO <> value Then
                IsChanged = True
                _CVNO = value
            End If
        End Set
    End Property

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _IDivrefph.ADD_DATE
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

    Protected _P_APL As Single = 0
    Public Overridable Property P_APL() As Single Implements _IDivrefph.P_APL
        Get
            Return _P_APL
        End Get
        Set(ByVal value As Single)
            If _P_APL <> value Then
                IsChanged = True
                _P_APL = value
            End If
        End Set
    End Property

    Protected _P_EDL As Single = 0
    Public Overridable Property P_EDL() As Single Implements _IDivrefph.P_EDL
        Get
            Return _P_EDL
        End Get
        Set(ByVal value As Single)
            If _P_EDL <> value Then
                IsChanged = True
                _P_EDL = value
            End If
        End Set
    End Property

    Protected _P_EML As Single = 0
    Public Overridable Property P_EML() As Single Implements _IDivrefph.P_EML
        Get
            Return _P_EML
        End Get
        Set(ByVal value As Single)
            If _P_EML <> value Then
                IsChanged = True
                _P_EML = value
            End If
        End Set
    End Property

    Protected _P_RGL As Single = 0
    Public Overridable Property P_RGL() As Single Implements _IDivrefph.P_RGL
        Get
            Return _P_RGL
        End Get
        Set(ByVal value As Single)
            If _P_RGL <> value Then
                IsChanged = True
                _P_RGL = value
            End If
        End Set
    End Property

    Protected _P_RSL As Single = 0
    Public Overridable Property P_RSL() As Single Implements _IDivrefph.P_RSL
        Get
            Return _P_RSL
        End Get
        Set(ByVal value As Single)
            If _P_RSL <> value Then
                IsChanged = True
                _P_RSL = value
            End If
        End Set
    End Property

    Protected _P_SPL As Single = 0
    Public Overridable Property P_SPL() As Single Implements _IDivrefph.P_SPL
        Get
            Return _P_SPL
        End Get
        Set(ByVal value As Single)
            If _P_SPL <> value Then
                IsChanged = True
                _P_SPL = value
            End If
        End Set
    End Property

    Protected _P_STL As Single = 0
    Public Overridable Property P_STL() As Single Implements _IDivrefph.P_STL
        Get
            Return _P_STL
        End Get
        Set(ByVal value As Single)
            If _P_STL <> value Then
                IsChanged = True
                _P_STL = value
            End If
        End Set
    End Property

    Protected _P_PTL As Single = 0
    Public Overridable Property P_PTL() As Single Implements _IDivrefph.P_PTL
        Get
            Return _P_PTL
        End Get
        Set(ByVal value As Single)
            If _P_PTL <> value Then
                IsChanged = True
                _P_PTL = value
            End If
        End Set
    End Property

    Protected _PD_APL As Single = 0
    Public Overridable Property PD_APL() As Single Implements _IDivrefph.PD_APL
        Get
            Return _PD_APL
        End Get
        Set(ByVal value As Single)
            If _PD_APL <> value Then
                IsChanged = True
                _PD_APL = value
            End If
        End Set
    End Property

    Protected _PD_EDL As Single = 0
    Public Overridable Property PD_EDL() As Single Implements _IDivrefph.PD_EDL
        Get
            Return _PD_EDL
        End Get
        Set(ByVal value As Single)
            If _PD_EDL <> value Then
                IsChanged = True
                _PD_EDL = value
            End If
        End Set
    End Property

    Protected _PD_EML As Single = 0
    Public Overridable Property PD_EML() As Single Implements _IDivrefph.PD_EML
        Get
            Return _PD_EML
        End Get
        Set(ByVal value As Single)
            If _PD_EML <> value Then
                IsChanged = True
                _PD_EML = value
            End If
        End Set
    End Property

    Protected _PD_RGL As Single = 0
    Public Overridable Property PD_RGL() As Single Implements _IDivrefph.PD_RGL
        Get
            Return _PD_RGL
        End Get
        Set(ByVal value As Single)
            If _PD_RGL <> value Then
                IsChanged = True
                _PD_RGL = value
            End If
        End Set
    End Property

    Protected _PD_RSL As Single = 0
    Public Overridable Property PD_RSL() As Single Implements _IDivrefph.PD_RSL
        Get
            Return _PD_RSL
        End Get
        Set(ByVal value As Single)
            If _PD_RSL <> value Then
                IsChanged = True
                _PD_RSL = value
            End If
        End Set
    End Property

    Protected _PD_SPL As Single = 0
    Public Overridable Property PD_SPL() As Single Implements _IDivrefph.PD_SPL
        Get
            Return _PD_SPL
        End Get
        Set(ByVal value As Single)
            If _PD_SPL <> value Then
                IsChanged = True
                _PD_SPL = value
            End If
        End Set
    End Property

    Protected _PD_STL As Single = 0
    Public Overridable Property PD_STL() As Single Implements _IDivrefph.PD_STL
        Get
            Return _PD_STL
        End Get
        Set(ByVal value As Single)
            If _PD_STL <> value Then
                IsChanged = True
                _PD_STL = value
            End If
        End Set
    End Property

    Protected _PD_PTL As Single = 0
    Public Overridable Property PD_PTL() As Single Implements _IDivrefph.PD_PTL
        Get
            Return _PD_PTL
        End Get
        Set(ByVal value As Single)
            If _PD_PTL <> value Then
                IsChanged = True
                _PD_PTL = value
            End If
        End Set
    End Property

    Protected _INTEREST As Single = 0
    Public Overridable Property INTEREST() As Single Implements _IDivrefph.INTEREST
        Get
            Return _INTEREST
        End Get
        Set(ByVal value As Single)
            If _INTEREST <> value Then
                IsChanged = True
                _INTEREST = value
            End If
        End Set
    End Property

    Protected _PENALTY As Single = 0
    Public Overridable Property PENALTY() As Single Implements _IDivrefph.PENALTY
        Get
            Return _PENALTY
        End Get
        Set(ByVal value As Single)
            If _PENALTY <> value Then
                IsChanged = True
                _PENALTY = value
            End If
        End Set
    End Property

    Protected _SAVINGS As Single = 0
    Public Overridable Property SAVINGS() As Single Implements _IDivrefph.SAVINGS
        Get
            Return _SAVINGS
        End Get
        Set(ByVal value As Single)
            If _SAVINGS <> value Then
                IsChanged = True
                _SAVINGS = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Divrefph from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Divrefph = Manager.Read(Id)
                _DIVREFPH_ID = int.DIVREFPH_ID
                _YEAR = int.YEAR
                _QUARTER = int.QUARTER
                _FD_CUTOFF = int.FD_CUTOFF
                _FD_PERCENT = int.FD_PERCENT
                _PR_YEAR = int.PR_YEAR
                _PR_PERCENT = int.PR_PERCENT
                _PR_INTFROM = int.PR_INTFROM
                _PR_INTTO = int.PR_INTTO
                _TDEBDESC1 = int.TDEBDESC1
                _TDEBAMT1 = int.TDEBAMT1
                _TDEBDESC2 = int.TDEBDESC2
                _TDEBAMT2 = int.TDEBAMT2
                _TDEBDESC3 = int.TDEBDESC3
                _TDEBAMT3 = int.TDEBAMT3
                _TDIVAMT = int.TDIVAMT
                _TREFAMT = int.TREFAMT
                _USER = int.USER
                _HOLDOUT = int.HOLDOUT
                _POSTED = int.POSTED
                _CVNO = int.CVNO
                _ADD_DATE = int.ADD_DATE
                _P_APL = int.P_APL
                _P_EDL = int.P_EDL
                _P_EML = int.P_EML
                _P_RGL = int.P_RGL
                _P_RSL = int.P_RSL
                _P_SPL = int.P_SPL
                _P_STL = int.P_STL
                _P_PTL = int.P_PTL
                _PD_APL = int.PD_APL
                _PD_EDL = int.PD_EDL
                _PD_EML = int.PD_EML
                _PD_RGL = int.PD_RGL
                _PD_RSL = int.PD_RSL
                _PD_SPL = int.PD_SPL
                _PD_STL = int.PD_STL
                _PD_PTL = int.PD_PTL
                _INTEREST = int.INTEREST
                _PENALTY = int.PENALTY
                _SAVINGS = int.SAVINGS
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Divrefph on DB.
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
        If _YEAR.Length > 4 Then Ris = False
        If _QUARTER.Length > 1 Then Ris = False
        If _PR_YEAR.Length > 4 Then Ris = False
        If _TDEBDESC1.Length > 30 Then Ris = False
        If _TDEBDESC2.Length > 30 Then Ris = False
        If _TDEBDESC3.Length > 30 Then Ris = False
        If _USER.Length > 8 Then Ris = False
        If _CVNO.Length > 7 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Divrefph
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDivrefph

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property DIVREFPH_ID() As Int64


    Property YEAR() As String


    Property QUARTER() As String


    Property FD_CUTOFF() As DateTime


    Property FD_PERCENT() As Single


    Property PR_YEAR() As String


    Property PR_PERCENT() As Single


    Property PR_INTFROM() As DateTime


    Property PR_INTTO() As DateTime


    Property TDEBDESC1() As String


    Property TDEBAMT1() As Single


    Property TDEBDESC2() As String


    Property TDEBAMT2() As Single


    Property TDEBDESC3() As String


    Property TDEBAMT3() As Single


    Property TDIVAMT() As Single


    Property TREFAMT() As Single


    Property USER() As String


    Property HOLDOUT() As Boolean


    Property POSTED() As Boolean


    Property CVNO() As String


    Property ADD_DATE() As DateTime


    Property P_APL() As Single


    Property P_EDL() As Single


    Property P_EML() As Single


    Property P_RGL() As Single


    Property P_RSL() As Single


    Property P_SPL() As Single


    Property P_STL() As Single


    Property P_PTL() As Single


    Property PD_APL() As Single


    Property PD_EDL() As Single


    Property PD_EML() As Single


    Property PD_RGL() As Single


    Property PD_RSL() As Single


    Property PD_SPL() As Single


    Property PD_STL() As Single


    Property PD_PTL() As Single


    Property INTEREST() As Single


    Property PENALTY() As Single


    Property SAVINGS() As Single


#End Region

End Interface