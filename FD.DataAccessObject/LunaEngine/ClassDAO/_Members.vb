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
'''DAO Class for table Members
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Members
	Inherits LUNA.LunaBaseClassEntity
    Implements _IMembers
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IMembers.FillFromDataRecord
     KBCI_ID = myRecord("KBCI_ID")
    KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("LNAME") is DBNull.Value then LNAME = myRecord("LNAME")
    		if not myRecord("FNAME") is DBNull.Value then FNAME = myRecord("FNAME")
    		if not myRecord("MI") is DBNull.Value then MI = myRecord("MI")
    		if not myRecord("MEM_CODE") is DBNull.Value then MEM_CODE = myRecord("MEM_CODE")
    		if not myRecord("MEM_STAT") is DBNull.Value then MEM_STAT = myRecord("MEM_STAT")
    		if not myRecord("MEM_DATE") is DBNull.Value then MEM_DATE = myRecord("MEM_DATE")
    		if not myRecord("BY_WHOM") is DBNull.Value then BY_WHOM = myRecord("BY_WHOM")
    		if not myRecord("CB_EMPNO") is DBNull.Value then CB_EMPNO = myRecord("CB_EMPNO")
    		if not myRecord("CB_HIRE") is DBNull.Value then CB_HIRE = myRecord("CB_HIRE")
    		if not myRecord("DEPT") is DBNull.Value then DEPT = myRecord("DEPT")
    		if not myRecord("REGION") is DBNull.Value then REGION = myRecord("REGION")
    		if not myRecord("OFF_TEL") is DBNull.Value then OFF_TEL = myRecord("OFF_TEL")
    		if not myRecord("DORI") is DBNull.Value then DORI = myRecord("DORI")
    		if not myRecord("REA_DORI") is DBNull.Value then REA_DORI = myRecord("REA_DORI")
    		if not myRecord("SEX") is DBNull.Value then SEX = myRecord("SEX")
    		if not myRecord("B_DATE") is DBNull.Value then B_DATE = myRecord("B_DATE")
    		if not myRecord("CIV_STAT") is DBNull.Value then CIV_STAT = myRecord("CIV_STAT")
    		if not myRecord("MEM_ADDR") is DBNull.Value then MEM_ADDR = myRecord("MEM_ADDR")
    		if not myRecord("RES_TEL") is DBNull.Value then RES_TEL = myRecord("RES_TEL")
    		if not myRecord("POSITION") is DBNull.Value then POSITION = myRecord("POSITION")
    		if not myRecord("SAL_BAS") is DBNull.Value then SAL_BAS = myRecord("SAL_BAS")
    		if not myRecord("SAL_ALL") is DBNull.Value then SAL_ALL = myRecord("SAL_ALL")
    		if not myRecord("OTH_INC") is DBNull.Value then OTH_INC = myRecord("OTH_INC")
    		if not myRecord("FEBTC_SA") is DBNull.Value then FEBTC_SA = myRecord("FEBTC_SA")
    		if not myRecord("FEBTC_CA") is DBNull.Value then FEBTC_CA = myRecord("FEBTC_CA")
    		if not myRecord("FD_CERTNO") is DBNull.Value then FD_CERTNO = myRecord("FD_CERTNO")
    		if not myRecord("FD_DATE") is DBNull.Value then FD_DATE = myRecord("FD_DATE")
    		if not myRecord("AP_AMOUNT") is DBNull.Value then AP_AMOUNT = myRecord("AP_AMOUNT")
    		if not myRecord("AR_AMOUNT") is DBNull.Value then AR_AMOUNT = myRecord("AR_AMOUNT")
    		if not myRecord("FD_AMOUNT") is DBNull.Value then FD_AMOUNT = myRecord("FD_AMOUNT")
    		if not myRecord("SD_AMOUNT") is DBNull.Value then SD_AMOUNT = myRecord("SD_AMOUNT")
    		if not myRecord("TD_AMOUNT") is DBNull.Value then TD_AMOUNT = myRecord("TD_AMOUNT")
    		if not myRecord("OTH_AMOUNT") is DBNull.Value then OTH_AMOUNT = myRecord("OTH_AMOUNT")
    		if not myRecord("YTD_DIVAMT") is DBNull.Value then YTD_DIVAMT = myRecord("YTD_DIVAMT")
    		if not myRecord("YTD_LRI") is DBNull.Value then YTD_LRI = myRecord("YTD_LRI")
    		if not myRecord("REM_PROP") is DBNull.Value then REM_PROP = myRecord("REM_PROP")
    		if not myRecord("REM_VALUE") is DBNull.Value then REM_VALUE = myRecord("REM_VALUE")
    		if not myRecord("NO_DEPEND") is DBNull.Value then NO_DEPEND = myRecord("NO_DEPEND")
    		if not myRecord("SP_NAME") is DBNull.Value then SP_NAME = myRecord("SP_NAME")
    		if not myRecord("SP_EMPLOY") is DBNull.Value then SP_EMPLOY = myRecord("SP_EMPLOY")
    		if not myRecord("SP_OFFTEL") is DBNull.Value then SP_OFFTEL = myRecord("SP_OFFTEL")
    		if not myRecord("SP_CBEMPNO") is DBNull.Value then SP_CBEMPNO = myRecord("SP_CBEMPNO")
    		if not myRecord("SP_KBCINO") is DBNull.Value then SP_KBCINO = myRecord("SP_KBCINO")
    		if not myRecord("SP_SALARY") is DBNull.Value then SP_SALARY = myRecord("SP_SALARY")
    		if not myRecord("APRUN_AMT") is DBNull.Value then APRUN_AMT = myRecord("APRUN_AMT")
    		if not myRecord("ARRUN_AMT") is DBNull.Value then ARRUN_AMT = myRecord("ARRUN_AMT")
    		if not myRecord("RUN_AMT") is DBNull.Value then RUN_AMT = myRecord("RUN_AMT")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("REC_STAT") is DBNull.Value then REC_STAT = myRecord("REC_STAT")
    		if not myRecord("FD_CNTR") is DBNull.Value then FD_CNTR = myRecord("FD_CNTR")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Members)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(MembersDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Members))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _KBCI_ID as Int64  = Nothing 
Public Overridable Property KBCI_ID() as Int64  Implements _IMembers.KBCI_ID
    Get
	    Return _KBCI_ID
    End Get
    Set (byval value as Int64)
	    If _KBCI_ID <> value Then
	        IsChanged = True
	        _KBCI_ID= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IMembers.KBCI_NO
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

Protected _LNAME as string  = "" 
Public Overridable Property LNAME() as string  Implements _IMembers.LNAME
    Get
	    Return _LNAME
    End Get
    Set (byval value as string)
	    If _LNAME <> value Then
	        IsChanged = True
	        _LNAME= value
	    End If
    End Set
End property 

Protected _FNAME as string  = "" 
Public Overridable Property FNAME() as string  Implements _IMembers.FNAME
    Get
	    Return _FNAME
    End Get
    Set (byval value as string)
	    If _FNAME <> value Then
	        IsChanged = True
	        _FNAME= value
	    End If
    End Set
End property 

Protected _MI as string  = "" 
Public Overridable Property MI() as string  Implements _IMembers.MI
    Get
	    Return _MI
    End Get
    Set (byval value as string)
	    If _MI <> value Then
	        IsChanged = True
	        _MI= value
	    End If
    End Set
End property 

Protected _MEM_CODE as string  = "" 
Public Overridable Property MEM_CODE() as string  Implements _IMembers.MEM_CODE
    Get
	    Return _MEM_CODE
    End Get
    Set (byval value as string)
	    If _MEM_CODE <> value Then
	        IsChanged = True
	        _MEM_CODE= value
	    End If
    End Set
End property 

Protected _MEM_STAT as string  = "" 
Public Overridable Property MEM_STAT() as string  Implements _IMembers.MEM_STAT
    Get
	    Return _MEM_STAT
    End Get
    Set (byval value as string)
	    If _MEM_STAT <> value Then
	        IsChanged = True
	        _MEM_STAT= value
	    End If
    End Set
End property 

    Protected _MEM_DATE As DateTime = Nothing
    Public Overridable Property MEM_DATE() As DateTime Implements _IMembers.MEM_DATE
        Get
            Return _MEM_DATE
        End Get
        Set(ByVal value As DateTime)
            If _MEM_DATE <> value Then
                IsChanged = True
                _MEM_DATE = value
            End If
        End Set
    End Property

    Protected _BY_WHOM As String = ""
    Public Overridable Property BY_WHOM() As String Implements _IMembers.BY_WHOM
        Get
            Return _BY_WHOM
        End Get
        Set(ByVal value As String)
            If _BY_WHOM <> value Then
                IsChanged = True
                _BY_WHOM = value
            End If
        End Set
    End Property

    Protected _CB_EMPNO As String = ""
    Public Overridable Property CB_EMPNO() As String Implements _IMembers.CB_EMPNO
        Get
            Return _CB_EMPNO
        End Get
        Set(ByVal value As String)
            If _CB_EMPNO <> value Then
                IsChanged = True
                _CB_EMPNO = value
            End If
        End Set
    End Property

    Protected _CB_HIRE As DateTime = Nothing
    Public Overridable Property CB_HIRE() As DateTime Implements _IMembers.CB_HIRE
        Get
            Return _CB_HIRE
        End Get
        Set(ByVal value As DateTime)
            If _CB_HIRE <> value Then
                IsChanged = True
                _CB_HIRE = value
            End If
        End Set
    End Property

    Protected _DEPT As String = ""
    Public Overridable Property DEPT() As String Implements _IMembers.DEPT
        Get
            Return _DEPT
        End Get
        Set(ByVal value As String)
            If _DEPT <> value Then
                IsChanged = True
                _DEPT = value
            End If
        End Set
    End Property

    Protected _REGION As String = ""
    Public Overridable Property REGION() As String Implements _IMembers.REGION
        Get
            Return _REGION
        End Get
        Set(ByVal value As String)
            If _REGION <> value Then
                IsChanged = True
                _REGION = value
            End If
        End Set
    End Property

    Protected _OFF_TEL As String = ""
    Public Overridable Property OFF_TEL() As String Implements _IMembers.OFF_TEL
        Get
            Return _OFF_TEL
        End Get
        Set(ByVal value As String)
            If _OFF_TEL <> value Then
                IsChanged = True
                _OFF_TEL = value
            End If
        End Set
    End Property

    Protected _DORI As Boolean = False
    Public Overridable Property DORI() As Boolean Implements _IMembers.DORI
        Get
            Return _DORI
        End Get
        Set(ByVal value As Boolean)
            If _DORI <> value Then
                IsChanged = True
                _DORI = value
            End If
        End Set
    End Property

    Protected _REA_DORI As String = ""
    Public Overridable Property REA_DORI() As String Implements _IMembers.REA_DORI
        Get
            Return _REA_DORI
        End Get
        Set(ByVal value As String)
            If _REA_DORI <> value Then
                IsChanged = True
                _REA_DORI = value
            End If
        End Set
    End Property

    Protected _SEX As String = ""
    Public Overridable Property SEX() As String Implements _IMembers.SEX
        Get
            Return _SEX
        End Get
        Set(ByVal value As String)
            If _SEX <> value Then
                IsChanged = True
                _SEX = value
            End If
        End Set
    End Property

    Protected _B_DATE As DateTime = Nothing
    Public Overridable Property B_DATE() As DateTime Implements _IMembers.B_DATE
        Get
            Return _B_DATE
        End Get
        Set(ByVal value As DateTime)
            If _B_DATE <> value Then
                IsChanged = True
                _B_DATE = value
            End If
        End Set
    End Property

    Protected _CIV_STAT As String = ""
    Public Overridable Property CIV_STAT() As String Implements _IMembers.CIV_STAT
        Get
            Return _CIV_STAT
        End Get
        Set(ByVal value As String)
            If _CIV_STAT <> value Then
                IsChanged = True
                _CIV_STAT = value
            End If
        End Set
    End Property

    Protected _MEM_ADDR As String = ""
    Public Overridable Property MEM_ADDR() As String Implements _IMembers.MEM_ADDR
        Get
            Return _MEM_ADDR
        End Get
        Set(ByVal value As String)
            If _MEM_ADDR <> value Then
                IsChanged = True
                _MEM_ADDR = value
            End If
        End Set
    End Property

    Protected _RES_TEL As String = ""
    Public Overridable Property RES_TEL() As String Implements _IMembers.RES_TEL
        Get
            Return _RES_TEL
        End Get
        Set(ByVal value As String)
            If _RES_TEL <> value Then
                IsChanged = True
                _RES_TEL = value
            End If
        End Set
    End Property

    Protected _POSITION As String = ""
    Public Overridable Property POSITION() As String Implements _IMembers.POSITION
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

    Protected _SAL_BAS As Single = 0
    Public Overridable Property SAL_BAS() As Single Implements _IMembers.SAL_BAS
        Get
            Return _SAL_BAS
        End Get
        Set(ByVal value As Single)
            If _SAL_BAS <> value Then
                IsChanged = True
                _SAL_BAS = value
            End If
        End Set
    End Property

    Protected _SAL_ALL As Single = 0
    Public Overridable Property SAL_ALL() As Single Implements _IMembers.SAL_ALL
        Get
            Return _SAL_ALL
        End Get
        Set(ByVal value As Single)
            If _SAL_ALL <> value Then
                IsChanged = True
                _SAL_ALL = value
            End If
        End Set
    End Property

    Protected _OTH_INC As Single = 0
    Public Overridable Property OTH_INC() As Single Implements _IMembers.OTH_INC
        Get
            Return _OTH_INC
        End Get
        Set(ByVal value As Single)
            If _OTH_INC <> value Then
                IsChanged = True
                _OTH_INC = value
            End If
        End Set
    End Property

    Protected _FEBTC_SA As String = ""
    Public Overridable Property FEBTC_SA() As String Implements _IMembers.FEBTC_SA
        Get
            Return _FEBTC_SA
        End Get
        Set(ByVal value As String)
            If _FEBTC_SA <> value Then
                IsChanged = True
                _FEBTC_SA = value
            End If
        End Set
    End Property

    Protected _FEBTC_CA As String = ""
    Public Overridable Property FEBTC_CA() As String Implements _IMembers.FEBTC_CA
        Get
            Return _FEBTC_CA
        End Get
        Set(ByVal value As String)
            If _FEBTC_CA <> value Then
                IsChanged = True
                _FEBTC_CA = value
            End If
        End Set
    End Property

    Protected _FD_CERTNO As String = ""
    Public Overridable Property FD_CERTNO() As String Implements _IMembers.FD_CERTNO
        Get
            Return _FD_CERTNO
        End Get
        Set(ByVal value As String)
            If _FD_CERTNO <> value Then
                IsChanged = True
                _FD_CERTNO = value
            End If
        End Set
    End Property

    Protected _FD_DATE As DateTime = Nothing
    Public Overridable Property FD_DATE() As DateTime Implements _IMembers.FD_DATE
        Get
            Return _FD_DATE
        End Get
        Set(ByVal value As DateTime)
            If _FD_DATE <> value Then
                IsChanged = True
                _FD_DATE = value
            End If
        End Set
    End Property

    Protected _AP_AMOUNT As Single = 0
    Public Overridable Property AP_AMOUNT() As Single Implements _IMembers.AP_AMOUNT
        Get
            Return _AP_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _AP_AMOUNT <> value Then
                IsChanged = True
                _AP_AMOUNT = value
            End If
        End Set
    End Property

    Protected _AR_AMOUNT As Single = 0
    Public Overridable Property AR_AMOUNT() As Single Implements _IMembers.AR_AMOUNT
        Get
            Return _AR_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _AR_AMOUNT <> value Then
                IsChanged = True
                _AR_AMOUNT = value
            End If
        End Set
    End Property

    Protected _FD_AMOUNT As Single = 0
    Public Overridable Property FD_AMOUNT() As Single Implements _IMembers.FD_AMOUNT
        Get
            Return _FD_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _FD_AMOUNT <> value Then
                IsChanged = True
                _FD_AMOUNT = value
            End If
        End Set
    End Property

    Protected _SD_AMOUNT As Single = 0
    Public Overridable Property SD_AMOUNT() As Single Implements _IMembers.SD_AMOUNT
        Get
            Return _SD_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _SD_AMOUNT <> value Then
                IsChanged = True
                _SD_AMOUNT = value
            End If
        End Set
    End Property

    Protected _TD_AMOUNT As Single = 0
    Public Overridable Property TD_AMOUNT() As Single Implements _IMembers.TD_AMOUNT
        Get
            Return _TD_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _TD_AMOUNT <> value Then
                IsChanged = True
                _TD_AMOUNT = value
            End If
        End Set
    End Property

    Protected _OTH_AMOUNT As Single = 0
    Public Overridable Property OTH_AMOUNT() As Single Implements _IMembers.OTH_AMOUNT
        Get
            Return _OTH_AMOUNT
        End Get
        Set(ByVal value As Single)
            If _OTH_AMOUNT <> value Then
                IsChanged = True
                _OTH_AMOUNT = value
            End If
        End Set
    End Property

    Protected _YTD_DIVAMT As Single = 0
    Public Overridable Property YTD_DIVAMT() As Single Implements _IMembers.YTD_DIVAMT
        Get
            Return _YTD_DIVAMT
        End Get
        Set(ByVal value As Single)
            If _YTD_DIVAMT <> value Then
                IsChanged = True
                _YTD_DIVAMT = value
            End If
        End Set
    End Property

    Protected _YTD_LRI As Single = 0
    Public Overridable Property YTD_LRI() As Single Implements _IMembers.YTD_LRI
        Get
            Return _YTD_LRI
        End Get
        Set(ByVal value As Single)
            If _YTD_LRI <> value Then
                IsChanged = True
                _YTD_LRI = value
            End If
        End Set
    End Property

    Protected _REM_PROP As String = ""
    Public Overridable Property REM_PROP() As String Implements _IMembers.REM_PROP
        Get
            Return _REM_PROP
        End Get
        Set(ByVal value As String)
            If _REM_PROP <> value Then
                IsChanged = True
                _REM_PROP = value
            End If
        End Set
    End Property

    Protected _REM_VALUE As Single = 0
    Public Overridable Property REM_VALUE() As Single Implements _IMembers.REM_VALUE
        Get
            Return _REM_VALUE
        End Get
        Set(ByVal value As Single)
            If _REM_VALUE <> value Then
                IsChanged = True
                _REM_VALUE = value
            End If
        End Set
    End Property

    Protected _NO_DEPEND As Single = 0
    Public Overridable Property NO_DEPEND() As Single Implements _IMembers.NO_DEPEND
        Get
            Return _NO_DEPEND
        End Get
        Set(ByVal value As Single)
            If _NO_DEPEND <> value Then
                IsChanged = True
                _NO_DEPEND = value
            End If
        End Set
    End Property

    Protected _SP_NAME As String = ""
    Public Overridable Property SP_NAME() As String Implements _IMembers.SP_NAME
        Get
            Return _SP_NAME
        End Get
        Set(ByVal value As String)
            If _SP_NAME <> value Then
                IsChanged = True
                _SP_NAME = value
            End If
        End Set
    End Property

    Protected _SP_EMPLOY As String = ""
    Public Overridable Property SP_EMPLOY() As String Implements _IMembers.SP_EMPLOY
        Get
            Return _SP_EMPLOY
        End Get
        Set(ByVal value As String)
            If _SP_EMPLOY <> value Then
                IsChanged = True
                _SP_EMPLOY = value
            End If
        End Set
    End Property

    Protected _SP_OFFTEL As String = ""
    Public Overridable Property SP_OFFTEL() As String Implements _IMembers.SP_OFFTEL
        Get
            Return _SP_OFFTEL
        End Get
        Set(ByVal value As String)
            If _SP_OFFTEL <> value Then
                IsChanged = True
                _SP_OFFTEL = value
            End If
        End Set
    End Property

    Protected _SP_CBEMPNO As String = ""
    Public Overridable Property SP_CBEMPNO() As String Implements _IMembers.SP_CBEMPNO
        Get
            Return _SP_CBEMPNO
        End Get
        Set(ByVal value As String)
            If _SP_CBEMPNO <> value Then
                IsChanged = True
                _SP_CBEMPNO = value
            End If
        End Set
    End Property

    Protected _SP_KBCINO As String = ""
    Public Overridable Property SP_KBCINO() As String Implements _IMembers.SP_KBCINO
        Get
            Return _SP_KBCINO
        End Get
        Set(ByVal value As String)
            If _SP_KBCINO <> value Then
                IsChanged = True
                _SP_KBCINO = value
            End If
        End Set
    End Property

    Protected _SP_SALARY As Single = 0
    Public Overridable Property SP_SALARY() As Single Implements _IMembers.SP_SALARY
        Get
            Return _SP_SALARY
        End Get
        Set(ByVal value As Single)
            If _SP_SALARY <> value Then
                IsChanged = True
                _SP_SALARY = value
            End If
        End Set
    End Property

    Protected _APRUN_AMT As Single = 0
    Public Overridable Property APRUN_AMT() As Single Implements _IMembers.APRUN_AMT
        Get
            Return _APRUN_AMT
        End Get
        Set(ByVal value As Single)
            If _APRUN_AMT <> value Then
                IsChanged = True
                _APRUN_AMT = value
            End If
        End Set
    End Property

    Protected _ARRUN_AMT As Single = 0
    Public Overridable Property ARRUN_AMT() As Single Implements _IMembers.ARRUN_AMT
        Get
            Return _ARRUN_AMT
        End Get
        Set(ByVal value As Single)
            If _ARRUN_AMT <> value Then
                IsChanged = True
                _ARRUN_AMT = value
            End If
        End Set
    End Property

    Protected _RUN_AMT As Single = 0
    Public Overridable Property RUN_AMT() As Single Implements _IMembers.RUN_AMT
        Get
            Return _RUN_AMT
        End Get
        Set(ByVal value As Single)
            If _RUN_AMT <> value Then
                IsChanged = True
                _RUN_AMT = value
            End If
        End Set
    End Property

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _IMembers.ADD_DATE
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
    Public Overridable Property CHG_DATE() As DateTime Implements _IMembers.CHG_DATE
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

    Protected _USER As String = ""
    Public Overridable Property USER() As String Implements _IMembers.USER
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

    Protected _REC_STAT As Boolean = False
    Public Overridable Property REC_STAT() As Boolean Implements _IMembers.REC_STAT
        Get
            Return _REC_STAT
        End Get
        Set(ByVal value As Boolean)
            If _REC_STAT <> value Then
                IsChanged = True
                _REC_STAT = value
            End If
        End Set
    End Property

    Protected _FD_CNTR As Single = 0
    Public Overridable Property FD_CNTR() As Single Implements _IMembers.FD_CNTR
        Get
            Return _FD_CNTR
        End Get
        Set(ByVal value As Single)
            If _FD_CNTR <> value Then
                IsChanged = True
                _FD_CNTR = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Members from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Members = Manager.Read(Id)
                _KBCI_ID = int.KBCI_ID
                _KBCI_NO = int.KBCI_NO
                _LNAME = int.LNAME
                _FNAME = int.FNAME
                _MI = int.MI
                _MEM_CODE = int.MEM_CODE
                _MEM_STAT = int.MEM_STAT
                _MEM_DATE = int.MEM_DATE
                _BY_WHOM = int.BY_WHOM
                _CB_EMPNO = int.CB_EMPNO
                _CB_HIRE = int.CB_HIRE
                _DEPT = int.DEPT
                _REGION = int.REGION
                _OFF_TEL = int.OFF_TEL
                _DORI = int.DORI
                _REA_DORI = int.REA_DORI
                _SEX = int.SEX
                _B_DATE = int.B_DATE
                _CIV_STAT = int.CIV_STAT
                _MEM_ADDR = int.MEM_ADDR
                _RES_TEL = int.RES_TEL
                _POSITION = int.POSITION
                _SAL_BAS = int.SAL_BAS
                _SAL_ALL = int.SAL_ALL
                _OTH_INC = int.OTH_INC
                _FEBTC_SA = int.FEBTC_SA
                _FEBTC_CA = int.FEBTC_CA
                _FD_CERTNO = int.FD_CERTNO
                _FD_DATE = int.FD_DATE
                _AP_AMOUNT = int.AP_AMOUNT
                _AR_AMOUNT = int.AR_AMOUNT
                _FD_AMOUNT = int.FD_AMOUNT
                _SD_AMOUNT = int.SD_AMOUNT
                _TD_AMOUNT = int.TD_AMOUNT
                _OTH_AMOUNT = int.OTH_AMOUNT
                _YTD_DIVAMT = int.YTD_DIVAMT
                _YTD_LRI = int.YTD_LRI
                _REM_PROP = int.REM_PROP
                _REM_VALUE = int.REM_VALUE
                _NO_DEPEND = int.NO_DEPEND
                _SP_NAME = int.SP_NAME
                _SP_EMPLOY = int.SP_EMPLOY
                _SP_OFFTEL = int.SP_OFFTEL
                _SP_CBEMPNO = int.SP_CBEMPNO
                _SP_KBCINO = int.SP_KBCINO
                _SP_SALARY = int.SP_SALARY
                _APRUN_AMT = int.APRUN_AMT
                _ARRUN_AMT = int.ARRUN_AMT
                _RUN_AMT = int.RUN_AMT
                _ADD_DATE = int.ADD_DATE
                _CHG_DATE = int.CHG_DATE
                _USER = int.USER
                _REC_STAT = int.REC_STAT
                _FD_CNTR = int.FD_CNTR
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Members on DB.
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
        If _KBCI_NO.Length = 0 Then Ris = False
        If _KBCI_NO.Length > 7 Then Ris = False
        If _LNAME.Length > 20 Then Ris = False
        If _FNAME.Length > 20 Then Ris = False
        If _MI.Length > 1 Then Ris = False
        If _MEM_CODE.Length > 1 Then Ris = False
        If _MEM_STAT.Length > 1 Then Ris = False
        If _BY_WHOM.Length > 15 Then Ris = False
        If _CB_EMPNO.Length > 6 Then Ris = False
        If _DEPT.Length > 15 Then Ris = False
        If _REGION.Length > 15 Then Ris = False
        If _OFF_TEL.Length > 11 Then Ris = False
        If _REA_DORI.Length > 15 Then Ris = False
        If _SEX.Length > 1 Then Ris = False
        If _CIV_STAT.Length > 1 Then Ris = False
        If _MEM_ADDR.Length > 100 Then Ris = False
        If _RES_TEL.Length > 7 Then Ris = False
        If _POSITION.Length > 15 Then Ris = False
        If _FEBTC_SA.Length > 10 Then Ris = False
        If _FEBTC_CA.Length > 10 Then Ris = False
        If _FD_CERTNO.Length > 6 Then Ris = False
        If _REM_PROP.Length > 500 Then Ris = False
        If _SP_NAME.Length > 30 Then Ris = False
        If _SP_EMPLOY.Length > 40 Then Ris = False
        If _SP_OFFTEL.Length > 11 Then Ris = False
        If _SP_CBEMPNO.Length > 6 Then Ris = False
        If _SP_KBCINO.Length > 7 Then Ris = False
        If _USER.Length > 8 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Members
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IMembers

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property KBCI_ID() As Int64


    Property KBCI_NO() As String


    Property LNAME() As String


    Property FNAME() As String


    Property MI() As String


    Property MEM_CODE() As String


    Property MEM_STAT() As String


    Property MEM_DATE() As DateTime


    Property BY_WHOM() As String


    Property CB_EMPNO() As String


    Property CB_HIRE() As DateTime


    Property DEPT() As String


    Property REGION() As String


    Property OFF_TEL() As String


    Property DORI() As Boolean


    Property REA_DORI() As String


    Property SEX() As String


    Property B_DATE() As DateTime


    Property CIV_STAT() As String


    Property MEM_ADDR() As String


    Property RES_TEL() As String


    Property POSITION() As String


    Property SAL_BAS() As Single


    Property SAL_ALL() As Single


    Property OTH_INC() As Single


    Property FEBTC_SA() As String


    Property FEBTC_CA() As String


    Property FD_CERTNO() As String


    Property FD_DATE() As DateTime


    Property AP_AMOUNT() As Single


    Property AR_AMOUNT() As Single


    Property FD_AMOUNT() As Single


    Property SD_AMOUNT() As Single


    Property TD_AMOUNT() As Single


    Property OTH_AMOUNT() As Single


    Property YTD_DIVAMT() As Single


    Property YTD_LRI() As Single


    Property REM_PROP() As String


    Property REM_VALUE() As Single


    Property NO_DEPEND() As Single


    Property SP_NAME() As String


    Property SP_EMPLOY() As String


    Property SP_OFFTEL() As String


    Property SP_CBEMPNO() As String


    Property SP_KBCINO() As String


    Property SP_SALARY() As Single


    Property APRUN_AMT() As Single


    Property ARRUN_AMT() As Single


    Property RUN_AMT() As Single


    Property ADD_DATE() As DateTime


    Property CHG_DATE() As DateTime


    Property USER() As String


    Property REC_STAT() As Boolean


    Property FD_CNTR() As Single


#End Region

End Interface