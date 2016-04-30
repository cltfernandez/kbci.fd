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
'''DAO Class for table Ctrl
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Ctrl
	Inherits LUNA.LunaBaseClassEntity
    Implements _ICtrl
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ICtrl.FillFromDataRecord
     CTRL_ID = myRecord("CTRL_ID")
    		if not myRecord("MAPP_NO") is DBNull.Value then MAPP_NO = myRecord("MAPP_NO")
    		if not myRecord("LAPP_DATE") is DBNull.Value then LAPP_DATE = myRecord("LAPP_DATE")
    		if not myRecord("LAPP_NO") is DBNull.Value then LAPP_NO = myRecord("LAPP_NO")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("PN_NO") is DBNull.Value then PN_NO = myRecord("PN_NO")
    		if not myRecord("PAY_DAY") is DBNull.Value then PAY_DAY = myRecord("PAY_DAY")
    		if not myRecord("SYSDATE") is DBNull.Value then SYSDATE = myRecord("SYSDATE")
    		if not myRecord("ADMDATE") is DBNull.Value then ADMDATE = myRecord("ADMDATE")
    		if not myRecord("L_DM") is DBNull.Value then L_DM = myRecord("L_DM")
    		if not myRecord("L_CM") is DBNull.Value then L_CM = myRecord("L_CM")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("CEILING") is DBNull.Value then CEILING = myRecord("CEILING")
    		if not myRecord("TD_CVNO") is DBNull.Value then TD_CVNO = myRecord("TD_CVNO")
    		if not myRecord("SDRATE") is DBNull.Value then SDRATE = myRecord("SDRATE")
    		if not myRecord("PROC") is DBNull.Value then PROC = myRecord("PROC")
    		if not myRecord("FDMIN") is DBNull.Value then FDMIN = myRecord("FDMIN")
    		if not myRecord("FDMAX") is DBNull.Value then FDMAX = myRecord("FDMAX")
    		if not myRecord("LRIMAX") is DBNull.Value then LRIMAX = myRecord("LRIMAX")
    		if not myRecord("FD_REP") is DBNull.Value then FD_REP = myRecord("FD_REP")
    		if not myRecord("REP1") is DBNull.Value then REP1 = myRecord("REP1")
    		if not myRecord("REP2") is DBNull.Value then REP2 = myRecord("REP2")
    		if not myRecord("REP3") is DBNull.Value then REP3 = myRecord("REP3")
    		if not myRecord("REP4") is DBNull.Value then REP4 = myRecord("REP4")
    		if not myRecord("REP5") is DBNull.Value then REP5 = myRecord("REP5")
    		if not myRecord("TD_REP") is DBNull.Value then TD_REP = myRecord("TD_REP")
    		if not myRecord("APRUN_DATE") is DBNull.Value then APRUN_DATE = myRecord("APRUN_DATE")
    		if not myRecord("ARRUN_DATA") is DBNull.Value then ARRUN_DATA = myRecord("ARRUN_DATA")
    		if not myRecord("RUN_DATE") is DBNull.Value then RUN_DATE = myRecord("RUN_DATE")
    		if not myRecord("ACCTBR") is DBNull.Value then ACCTBR = myRecord("ACCTBR")
    		if not myRecord("ACCTSEQ") is DBNull.Value then ACCTSEQ = myRecord("ACCTSEQ")
    		if not myRecord("VOUCHER") is DBNull.Value then VOUCHER = myRecord("VOUCHER")
    		if not myRecord("CLOSE") is DBNull.Value then CLOSE = myRecord("CLOSE")
    		if not myRecord("PMAXL") is DBNull.Value then PMAXL = myRecord("PMAXL")
    		if not myRecord("LMAXL") is DBNull.Value then LMAXL = myRecord("LMAXL")
    		if not myRecord("BINIT") is DBNull.Value then BINIT = myRecord("BINIT")
    		if not myRecord("BPOST") is DBNull.Value then BPOST = myRecord("BPOST")
    		if not myRecord("CLR_ONUS") is DBNull.Value then CLR_ONUS = myRecord("CLR_ONUS")
    		if not myRecord("CLR_LOCAL") is DBNull.Value then CLR_LOCAL = myRecord("CLR_LOCAL")
    		if not myRecord("CLR_REG") is DBNull.Value then CLR_REG = myRecord("CLR_REG")
    		if not myRecord("MINBAL") is DBNull.Value then MINBAL = myRecord("MINBAL")
    		if not myRecord("DBDORMANT") is DBNull.Value then DBDORMANT = myRecord("DBDORMANT")
    		if not myRecord("EOM_FLAG") is DBNull.Value then EOM_FLAG = myRecord("EOM_FLAG")
    		if not myRecord("EOQ_FLAG") is DBNull.Value then EOQ_FLAG = myRecord("EOQ_FLAG")
    		if not myRecord("EOY_FLAG") is DBNull.Value then EOY_FLAG = myRecord("EOY_FLAG")
    		if not myRecord("OTC_FLAG") is DBNull.Value then OTC_FLAG = myRecord("OTC_FLAG")
    		if not myRecord("EOD_FLAG") is DBNull.Value then EOD_FLAG = myRecord("EOD_FLAG")
    		if not myRecord("P_PRINT") is DBNull.Value then P_PRINT = myRecord("P_PRINT")
    		if not myRecord("R_PRINT") is DBNull.Value then R_PRINT = myRecord("R_PRINT")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Ctrl)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(CtrlDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Ctrl))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _CTRL_ID as Int64  = Nothing 
Public Overridable Property CTRL_ID() as Int64  Implements _ICtrl.CTRL_ID
    Get
	    Return _CTRL_ID
    End Get
    Set (byval value as Int64)
	    If _CTRL_ID <> value Then
	        IsChanged = True
	        _CTRL_ID= value
	    End If
    End Set
End property 

Protected _MAPP_NO as string  = "" 
Public Overridable Property MAPP_NO() as string  Implements _ICtrl.MAPP_NO
    Get
	    Return _MAPP_NO
    End Get
    Set (byval value as string)
	    If _MAPP_NO <> value Then
	        IsChanged = True
	        _MAPP_NO= value
	    End If
    End Set
End property 

    Protected _LAPP_DATE As DateTime = Nothing
    Public Overridable Property LAPP_DATE() As DateTime Implements _ICtrl.LAPP_DATE
        Get
            Return _LAPP_DATE
        End Get
        Set(ByVal value As DateTime)
            If _LAPP_DATE <> value Then
                IsChanged = True
                _LAPP_DATE = value
            End If
        End Set
    End Property

    Protected _LAPP_NO As Single = 0
    Public Overridable Property LAPP_NO() As Single Implements _ICtrl.LAPP_NO
        Get
            Return _LAPP_NO
        End Get
        Set(ByVal value As Single)
            If _LAPP_NO <> value Then
                IsChanged = True
                _LAPP_NO = value
            End If
        End Set
    End Property

    Protected _KBCI_NO As String = ""
    Public Overridable Property KBCI_NO() As String Implements _ICtrl.KBCI_NO
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

    Protected _PN_NO As Single = 0
    Public Overridable Property PN_NO() As Single Implements _ICtrl.PN_NO
        Get
            Return _PN_NO
        End Get
        Set(ByVal value As Single)
            If _PN_NO <> value Then
                IsChanged = True
                _PN_NO = value
            End If
        End Set
    End Property

    Protected _PAY_DAY As DateTime = Nothing
    Public Overridable Property PAY_DAY() As DateTime Implements _ICtrl.PAY_DAY
        Get
            Return _PAY_DAY
        End Get
        Set(ByVal value As DateTime)
            If _PAY_DAY <> value Then
                IsChanged = True
                _PAY_DAY = value
            End If
        End Set
    End Property

    Protected _SYSDATE As DateTime = Nothing
    Public Overridable Property SYSDATE() As DateTime Implements _ICtrl.SYSDATE
        Get
            Return _SYSDATE
        End Get
        Set(ByVal value As DateTime)
            If _SYSDATE <> value Then
                IsChanged = True
                _SYSDATE = value
            End If
        End Set
    End Property

    Protected _ADMDATE As DateTime = Nothing
    Public Overridable Property ADMDATE() As DateTime Implements _ICtrl.ADMDATE
        Get
            Return _ADMDATE
        End Get
        Set(ByVal value As DateTime)
            If _ADMDATE <> value Then
                IsChanged = True
                _ADMDATE = value
            End If
        End Set
    End Property

    Protected _L_DM As Single = 0
    Public Overridable Property L_DM() As Single Implements _ICtrl.L_DM
        Get
            Return _L_DM
        End Get
        Set(ByVal value As Single)
            If _L_DM <> value Then
                IsChanged = True
                _L_DM = value
            End If
        End Set
    End Property

    Protected _L_CM As Single = 0
    Public Overridable Property L_CM() As Single Implements _ICtrl.L_CM
        Get
            Return _L_CM
        End Get
        Set(ByVal value As Single)
            If _L_CM <> value Then
                IsChanged = True
                _L_CM = value
            End If
        End Set
    End Property

    Protected _ADD_DATE As DateTime = Nothing
    Public Overridable Property ADD_DATE() As DateTime Implements _ICtrl.ADD_DATE
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
    Public Overridable Property CHG_DATE() As DateTime Implements _ICtrl.CHG_DATE
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
    Public Overridable Property USER() As String Implements _ICtrl.USER
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

    Protected _CEILING As Single = 0
    Public Overridable Property CEILING() As Single Implements _ICtrl.CEILING
        Get
            Return _CEILING
        End Get
        Set(ByVal value As Single)
            If _CEILING <> value Then
                IsChanged = True
                _CEILING = value
            End If
        End Set
    End Property

    Protected _TD_CVNO As Single = 0
    Public Overridable Property TD_CVNO() As Single Implements _ICtrl.TD_CVNO
        Get
            Return _TD_CVNO
        End Get
        Set(ByVal value As Single)
            If _TD_CVNO <> value Then
                IsChanged = True
                _TD_CVNO = value
            End If
        End Set
    End Property

    Protected _SDRATE As Single = 0
    Public Overridable Property SDRATE() As Single Implements _ICtrl.SDRATE
        Get
            Return _SDRATE
        End Get
        Set(ByVal value As Single)
            If _SDRATE <> value Then
                IsChanged = True
                _SDRATE = value
            End If
        End Set
    End Property

    Protected _PROC As DateTime = Nothing
    Public Overridable Property PROC() As DateTime Implements _ICtrl.PROC
        Get
            Return _PROC
        End Get
        Set(ByVal value As DateTime)
            If _PROC <> value Then
                IsChanged = True
                _PROC = value
            End If
        End Set
    End Property

    Protected _FDMIN As Single = 0
    Public Overridable Property FDMIN() As Single Implements _ICtrl.FDMIN
        Get
            Return _FDMIN
        End Get
        Set(ByVal value As Single)
            If _FDMIN <> value Then
                IsChanged = True
                _FDMIN = value
            End If
        End Set
    End Property

    Protected _FDMAX As Single = 0
    Public Overridable Property FDMAX() As Single Implements _ICtrl.FDMAX
        Get
            Return _FDMAX
        End Get
        Set(ByVal value As Single)
            If _FDMAX <> value Then
                IsChanged = True
                _FDMAX = value
            End If
        End Set
    End Property

    Protected _LRIMAX As Single = 0
    Public Overridable Property LRIMAX() As Single Implements _ICtrl.LRIMAX
        Get
            Return _LRIMAX
        End Get
        Set(ByVal value As Single)
            If _LRIMAX <> value Then
                IsChanged = True
                _LRIMAX = value
            End If
        End Set
    End Property

    Protected _FD_REP As Boolean = False
    Public Overridable Property FD_REP() As Boolean Implements _ICtrl.FD_REP
        Get
            Return _FD_REP
        End Get
        Set(ByVal value As Boolean)
            If _FD_REP <> value Then
                IsChanged = True
                _FD_REP = value
            End If
        End Set
    End Property

    Protected _REP1 As Boolean = False
    Public Overridable Property REP1() As Boolean Implements _ICtrl.REP1
        Get
            Return _REP1
        End Get
        Set(ByVal value As Boolean)
            If _REP1 <> value Then
                IsChanged = True
                _REP1 = value
            End If
        End Set
    End Property

    Protected _REP2 As Boolean = False
    Public Overridable Property REP2() As Boolean Implements _ICtrl.REP2
        Get
            Return _REP2
        End Get
        Set(ByVal value As Boolean)
            If _REP2 <> value Then
                IsChanged = True
                _REP2 = value
            End If
        End Set
    End Property

    Protected _REP3 As Boolean = False
    Public Overridable Property REP3() As Boolean Implements _ICtrl.REP3
        Get
            Return _REP3
        End Get
        Set(ByVal value As Boolean)
            If _REP3 <> value Then
                IsChanged = True
                _REP3 = value
            End If
        End Set
    End Property

    Protected _REP4 As Boolean = False
    Public Overridable Property REP4() As Boolean Implements _ICtrl.REP4
        Get
            Return _REP4
        End Get
        Set(ByVal value As Boolean)
            If _REP4 <> value Then
                IsChanged = True
                _REP4 = value
            End If
        End Set
    End Property

    Protected _REP5 As Boolean = False
    Public Overridable Property REP5() As Boolean Implements _ICtrl.REP5
        Get
            Return _REP5
        End Get
        Set(ByVal value As Boolean)
            If _REP5 <> value Then
                IsChanged = True
                _REP5 = value
            End If
        End Set
    End Property

    Protected _TD_REP As Boolean = False
    Public Overridable Property TD_REP() As Boolean Implements _ICtrl.TD_REP
        Get
            Return _TD_REP
        End Get
        Set(ByVal value As Boolean)
            If _TD_REP <> value Then
                IsChanged = True
                _TD_REP = value
            End If
        End Set
    End Property

    Protected _APRUN_DATE As DateTime = Nothing
    Public Overridable Property APRUN_DATE() As DateTime Implements _ICtrl.APRUN_DATE
        Get
            Return _APRUN_DATE
        End Get
        Set(ByVal value As DateTime)
            If _APRUN_DATE <> value Then
                IsChanged = True
                _APRUN_DATE = value
            End If
        End Set
    End Property

    Protected _ARRUN_DATA As DateTime = Nothing
    Public Overridable Property ARRUN_DATA() As DateTime Implements _ICtrl.ARRUN_DATA
        Get
            Return _ARRUN_DATA
        End Get
        Set(ByVal value As DateTime)
            If _ARRUN_DATA <> value Then
                IsChanged = True
                _ARRUN_DATA = value
            End If
        End Set
    End Property

    Protected _RUN_DATE As DateTime = Nothing
    Public Overridable Property RUN_DATE() As DateTime Implements _ICtrl.RUN_DATE
        Get
            Return _RUN_DATE
        End Get
        Set(ByVal value As DateTime)
            If _RUN_DATE <> value Then
                IsChanged = True
                _RUN_DATE = value
            End If
        End Set
    End Property

    Protected _ACCTBR As String = ""
    Public Overridable Property ACCTBR() As String Implements _ICtrl.ACCTBR
        Get
            Return _ACCTBR
        End Get
        Set(ByVal value As String)
            If _ACCTBR <> value Then
                IsChanged = True
                _ACCTBR = value
            End If
        End Set
    End Property

    Protected _ACCTSEQ As Single = 0
    Public Overridable Property ACCTSEQ() As Single Implements _ICtrl.ACCTSEQ
        Get
            Return _ACCTSEQ
        End Get
        Set(ByVal value As Single)
            If _ACCTSEQ <> value Then
                IsChanged = True
                _ACCTSEQ = value
            End If
        End Set
    End Property

    Protected _VOUCHER As Single = 0
    Public Overridable Property VOUCHER() As Single Implements _ICtrl.VOUCHER
        Get
            Return _VOUCHER
        End Get
        Set(ByVal value As Single)
            If _VOUCHER <> value Then
                IsChanged = True
                _VOUCHER = value
            End If
        End Set
    End Property

    Protected _CLOSE As Boolean = False
    Public Overridable Property CLOSE() As Boolean Implements _ICtrl.CLOSE
        Get
            Return _CLOSE
        End Get
        Set(ByVal value As Boolean)
            If _CLOSE <> value Then
                IsChanged = True
                _CLOSE = value
            End If
        End Set
    End Property

    Protected _PMAXL As Single = 0
    Public Overridable Property PMAXL() As Single Implements _ICtrl.PMAXL
        Get
            Return _PMAXL
        End Get
        Set(ByVal value As Single)
            If _PMAXL <> value Then
                IsChanged = True
                _PMAXL = value
            End If
        End Set
    End Property

    Protected _LMAXL As Single = 0
    Public Overridable Property LMAXL() As Single Implements _ICtrl.LMAXL
        Get
            Return _LMAXL
        End Get
        Set(ByVal value As Single)
            If _LMAXL <> value Then
                IsChanged = True
                _LMAXL = value
            End If
        End Set
    End Property

    Protected _BINIT As Boolean = False
    Public Overridable Property BINIT() As Boolean Implements _ICtrl.BINIT
        Get
            Return _BINIT
        End Get
        Set(ByVal value As Boolean)
            If _BINIT <> value Then
                IsChanged = True
                _BINIT = value
            End If
        End Set
    End Property

    Protected _BPOST As Boolean = False
    Public Overridable Property BPOST() As Boolean Implements _ICtrl.BPOST
        Get
            Return _BPOST
        End Get
        Set(ByVal value As Boolean)
            If _BPOST <> value Then
                IsChanged = True
                _BPOST = value
            End If
        End Set
    End Property

    Protected _CLR_ONUS As Single = 0
    Public Overridable Property CLR_ONUS() As Single Implements _ICtrl.CLR_ONUS
        Get
            Return _CLR_ONUS
        End Get
        Set(ByVal value As Single)
            If _CLR_ONUS <> value Then
                IsChanged = True
                _CLR_ONUS = value
            End If
        End Set
    End Property

    Protected _CLR_LOCAL As Single = 0
    Public Overridable Property CLR_LOCAL() As Single Implements _ICtrl.CLR_LOCAL
        Get
            Return _CLR_LOCAL
        End Get
        Set(ByVal value As Single)
            If _CLR_LOCAL <> value Then
                IsChanged = True
                _CLR_LOCAL = value
            End If
        End Set
    End Property

    Protected _CLR_REG As Single = 0
    Public Overridable Property CLR_REG() As Single Implements _ICtrl.CLR_REG
        Get
            Return _CLR_REG
        End Get
        Set(ByVal value As Single)
            If _CLR_REG <> value Then
                IsChanged = True
                _CLR_REG = value
            End If
        End Set
    End Property

    Protected _MINBAL As Single = 0
    Public Overridable Property MINBAL() As Single Implements _ICtrl.MINBAL
        Get
            Return _MINBAL
        End Get
        Set(ByVal value As Single)
            If _MINBAL <> value Then
                IsChanged = True
                _MINBAL = value
            End If
        End Set
    End Property

    Protected _DBDORMANT As Single = 0
    Public Overridable Property DBDORMANT() As Single Implements _ICtrl.DBDORMANT
        Get
            Return _DBDORMANT
        End Get
        Set(ByVal value As Single)
            If _DBDORMANT <> value Then
                IsChanged = True
                _DBDORMANT = value
            End If
        End Set
    End Property

    Protected _EOM_FLAG As Boolean = False
    Public Overridable Property EOM_FLAG() As Boolean Implements _ICtrl.EOM_FLAG
        Get
            Return _EOM_FLAG
        End Get
        Set(ByVal value As Boolean)
            If _EOM_FLAG <> value Then
                IsChanged = True
                _EOM_FLAG = value
            End If
        End Set
    End Property

    Protected _EOQ_FLAG As Boolean = False
    Public Overridable Property EOQ_FLAG() As Boolean Implements _ICtrl.EOQ_FLAG
        Get
            Return _EOQ_FLAG
        End Get
        Set(ByVal value As Boolean)
            If _EOQ_FLAG <> value Then
                IsChanged = True
                _EOQ_FLAG = value
            End If
        End Set
    End Property

    Protected _EOY_FLAG As Boolean = False
    Public Overridable Property EOY_FLAG() As Boolean Implements _ICtrl.EOY_FLAG
        Get
            Return _EOY_FLAG
        End Get
        Set(ByVal value As Boolean)
            If _EOY_FLAG <> value Then
                IsChanged = True
                _EOY_FLAG = value
            End If
        End Set
    End Property

    Protected _OTC_FLAG As Boolean = False
    Public Overridable Property OTC_FLAG() As Boolean Implements _ICtrl.OTC_FLAG
        Get
            Return _OTC_FLAG
        End Get
        Set(ByVal value As Boolean)
            If _OTC_FLAG <> value Then
                IsChanged = True
                _OTC_FLAG = value
            End If
        End Set
    End Property

    Protected _EOD_FLAG As Boolean = False
    Public Overridable Property EOD_FLAG() As Boolean Implements _ICtrl.EOD_FLAG
        Get
            Return _EOD_FLAG
        End Get
        Set(ByVal value As Boolean)
            If _EOD_FLAG <> value Then
                IsChanged = True
                _EOD_FLAG = value
            End If
        End Set
    End Property

    Protected _P_PRINT As String = ""
    Public Overridable Property P_PRINT() As String Implements _ICtrl.P_PRINT
        Get
            Return _P_PRINT
        End Get
        Set(ByVal value As String)
            If _P_PRINT <> value Then
                IsChanged = True
                _P_PRINT = value
            End If
        End Set
    End Property

    Protected _R_PRINT As String = ""
    Public Overridable Property R_PRINT() As String Implements _ICtrl.R_PRINT
        Get
            Return _R_PRINT
        End Get
        Set(ByVal value As String)
            If _R_PRINT <> value Then
                IsChanged = True
                _R_PRINT = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Ctrl from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(ByVal Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Ctrl = Manager.Read(Id)
                _CTRL_ID = int.CTRL_ID
                _MAPP_NO = int.MAPP_NO
                _LAPP_DATE = int.LAPP_DATE
                _LAPP_NO = int.LAPP_NO
                _KBCI_NO = int.KBCI_NO
                _PN_NO = int.PN_NO
                _PAY_DAY = int.PAY_DAY
                _SYSDATE = int.SYSDATE
                _ADMDATE = int.ADMDATE
                _L_DM = int.L_DM
                _L_CM = int.L_CM
                _ADD_DATE = int.ADD_DATE
                _CHG_DATE = int.CHG_DATE
                _USER = int.USER
                _CEILING = int.CEILING
                _TD_CVNO = int.TD_CVNO
                _SDRATE = int.SDRATE
                _PROC = int.PROC
                _FDMIN = int.FDMIN
                _FDMAX = int.FDMAX
                _LRIMAX = int.LRIMAX
                _FD_REP = int.FD_REP
                _REP1 = int.REP1
                _REP2 = int.REP2
                _REP3 = int.REP3
                _REP4 = int.REP4
                _REP5 = int.REP5
                _TD_REP = int.TD_REP
                _APRUN_DATE = int.APRUN_DATE
                _ARRUN_DATA = int.ARRUN_DATA
                _RUN_DATE = int.RUN_DATE
                _ACCTBR = int.ACCTBR
                _ACCTSEQ = int.ACCTSEQ
                _VOUCHER = int.VOUCHER
                _CLOSE = int.CLOSE
                _PMAXL = int.PMAXL
                _LMAXL = int.LMAXL
                _BINIT = int.BINIT
                _BPOST = int.BPOST
                _CLR_ONUS = int.CLR_ONUS
                _CLR_LOCAL = int.CLR_LOCAL
                _CLR_REG = int.CLR_REG
                _MINBAL = int.MINBAL
                _DBDORMANT = int.DBDORMANT
                _EOM_FLAG = int.EOM_FLAG
                _EOQ_FLAG = int.EOQ_FLAG
                _EOY_FLAG = int.EOY_FLAG
                _OTC_FLAG = int.OTC_FLAG
                _EOD_FLAG = int.EOD_FLAG
                _P_PRINT = int.P_PRINT
                _R_PRINT = int.R_PRINT
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Ctrl on DB.
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
        If _MAPP_NO.Length > 7 Then Ris = False
        If _KBCI_NO.Length > 7 Then Ris = False
        If _USER.Length > 8 Then Ris = False
        If _ACCTBR.Length > 4 Then Ris = False
        If _P_PRINT.Length > 4 Then Ris = False
        If _R_PRINT.Length > 4 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Ctrl
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ICtrl

    Sub FillFromDataRecord(ByVal myRecord As IDataRecord)

#Region "Database Field Map"


    Property CTRL_ID() As Int64


    Property MAPP_NO() As String


    Property LAPP_DATE() As DateTime


    Property LAPP_NO() As Single


    Property KBCI_NO() As String


    Property PN_NO() As Single


    Property PAY_DAY() As DateTime


    Property SYSDATE() As DateTime


    Property ADMDATE() As DateTime


    Property L_DM() As Single


    Property L_CM() As Single


    Property ADD_DATE() As DateTime


    Property CHG_DATE() As DateTime


    Property USER() As String


    Property CEILING() As Single


    Property TD_CVNO() As Single


    Property SDRATE() As Single


    Property PROC() As DateTime


    Property FDMIN() As Single


    Property FDMAX() As Single


    Property LRIMAX() As Single


    Property FD_REP() As Boolean


    Property REP1() As Boolean


    Property REP2() As Boolean


    Property REP3() As Boolean


    Property REP4() As Boolean


    Property REP5() As Boolean


    Property TD_REP() As Boolean


    Property APRUN_DATE() As DateTime


    Property ARRUN_DATA() As DateTime


    Property RUN_DATE() As DateTime


    Property ACCTBR() As String


    Property ACCTSEQ() As Single


    Property VOUCHER() As Single


    Property CLOSE() As Boolean


    Property PMAXL() As Single


    Property LMAXL() As Single


    Property BINIT() As Boolean


    Property BPOST() As Boolean


    Property CLR_ONUS() As Single


    Property CLR_LOCAL() As Single


    Property CLR_REG() As Single


    Property MINBAL() As Single


    Property DBDORMANT() As Single


    Property EOM_FLAG() As Boolean


    Property EOQ_FLAG() As Boolean


    Property EOY_FLAG() As Boolean


    Property OTC_FLAG() As Boolean


    Property EOD_FLAG() As Boolean


    Property P_PRINT() As String


    Property R_PRINT() As String


#End Region

End Interface