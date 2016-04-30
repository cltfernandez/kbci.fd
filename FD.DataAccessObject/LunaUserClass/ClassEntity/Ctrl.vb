#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Ctrl
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Ctrl
	Inherits _Ctrl
    Implements ICtrl

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property CTRL_ID() as Int64
    Get
	    Return MyBase.CTRL_ID
    End Get
    Set (byval value as Int64)
        MyBase.CTRL_ID= value
    End Set
End property 


Public Overrides Property MAPP_NO() as string
    Get
	    Return MyBase.MAPP_NO
    End Get
    Set (byval value as string)
        MyBase.MAPP_NO= value
    End Set
End property 


    Public Overrides Property LAPP_DATE() As DateTime
        Get
            Return MyBase.LAPP_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.LAPP_DATE = value
        End Set
    End Property


    Public Overrides Property LAPP_NO() As Single
        Get
            Return MyBase.LAPP_NO
        End Get
        Set(ByVal value As Single)
            MyBase.LAPP_NO = value
        End Set
    End Property


    Public Overrides Property KBCI_NO() As String
        Get
            Return MyBase.KBCI_NO
        End Get
        Set(ByVal value As String)
            MyBase.KBCI_NO = value
        End Set
    End Property


    Public Overrides Property PN_NO() As Single
        Get
            Return MyBase.PN_NO
        End Get
        Set(ByVal value As Single)
            MyBase.PN_NO = value
        End Set
    End Property


    Public Overrides Property PAY_DAY() As DateTime
        Get
            Return MyBase.PAY_DAY
        End Get
        Set(ByVal value As DateTime)
            MyBase.PAY_DAY = value
        End Set
    End Property


    Public Overrides Property SYSDATE() As DateTime
        Get
            Return MyBase.SYSDATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.SYSDATE = value
        End Set
    End Property


    Public Overrides Property ADMDATE() As DateTime
        Get
            Return MyBase.ADMDATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.ADMDATE = value
        End Set
    End Property


    Public Overrides Property L_DM() As Single
        Get
            Return MyBase.L_DM
        End Get
        Set(ByVal value As Single)
            MyBase.L_DM = value
        End Set
    End Property


    Public Overrides Property L_CM() As Single
        Get
            Return MyBase.L_CM
        End Get
        Set(ByVal value As Single)
            MyBase.L_CM = value
        End Set
    End Property


    Public Overrides Property ADD_DATE() As DateTime
        Get
            Return MyBase.ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.ADD_DATE = value
        End Set
    End Property


    Public Overrides Property CHG_DATE() As DateTime
        Get
            Return MyBase.CHG_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.CHG_DATE = value
        End Set
    End Property


    Public Overrides Property USER() As String
        Get
            Return MyBase.USER
        End Get
        Set(ByVal value As String)
            MyBase.USER = value
        End Set
    End Property


    Public Overrides Property CEILING() As Single
        Get
            Return MyBase.CEILING
        End Get
        Set(ByVal value As Single)
            MyBase.CEILING = value
        End Set
    End Property


    Public Overrides Property TD_CVNO() As Single
        Get
            Return MyBase.TD_CVNO
        End Get
        Set(ByVal value As Single)
            MyBase.TD_CVNO = value
        End Set
    End Property


    Public Overrides Property SDRATE() As Single
        Get
            Return MyBase.SDRATE
        End Get
        Set(ByVal value As Single)
            MyBase.SDRATE = value
        End Set
    End Property


    Public Overrides Property PROC() As DateTime
        Get
            Return MyBase.PROC
        End Get
        Set(ByVal value As DateTime)
            MyBase.PROC = value
        End Set
    End Property


    Public Overrides Property FDMIN() As Single
        Get
            Return MyBase.FDMIN
        End Get
        Set(ByVal value As Single)
            MyBase.FDMIN = value
        End Set
    End Property


    Public Overrides Property FDMAX() As Single
        Get
            Return MyBase.FDMAX
        End Get
        Set(ByVal value As Single)
            MyBase.FDMAX = value
        End Set
    End Property


    Public Overrides Property LRIMAX() As Single
        Get
            Return MyBase.LRIMAX
        End Get
        Set(ByVal value As Single)
            MyBase.LRIMAX = value
        End Set
    End Property


    Public Overrides Property FD_REP() As Boolean
        Get
            Return MyBase.FD_REP
        End Get
        Set(ByVal value As Boolean)
            MyBase.FD_REP = value
        End Set
    End Property


    Public Overrides Property REP1() As Boolean
        Get
            Return MyBase.REP1
        End Get
        Set(ByVal value As Boolean)
            MyBase.REP1 = value
        End Set
    End Property


    Public Overrides Property REP2() As Boolean
        Get
            Return MyBase.REP2
        End Get
        Set(ByVal value As Boolean)
            MyBase.REP2 = value
        End Set
    End Property


    Public Overrides Property REP3() As Boolean
        Get
            Return MyBase.REP3
        End Get
        Set(ByVal value As Boolean)
            MyBase.REP3 = value
        End Set
    End Property


    Public Overrides Property REP4() As Boolean
        Get
            Return MyBase.REP4
        End Get
        Set(ByVal value As Boolean)
            MyBase.REP4 = value
        End Set
    End Property


    Public Overrides Property REP5() As Boolean
        Get
            Return MyBase.REP5
        End Get
        Set(ByVal value As Boolean)
            MyBase.REP5 = value
        End Set
    End Property


    Public Overrides Property TD_REP() As Boolean
        Get
            Return MyBase.TD_REP
        End Get
        Set(ByVal value As Boolean)
            MyBase.TD_REP = value
        End Set
    End Property


    Public Overrides Property APRUN_DATE() As DateTime
        Get
            Return MyBase.APRUN_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.APRUN_DATE = value
        End Set
    End Property


    Public Overrides Property ARRUN_DATA() As DateTime
        Get
            Return MyBase.ARRUN_DATA
        End Get
        Set(ByVal value As DateTime)
            MyBase.ARRUN_DATA = value
        End Set
    End Property


    Public Overrides Property RUN_DATE() As DateTime
        Get
            Return MyBase.RUN_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.RUN_DATE = value
        End Set
    End Property


Public Overrides Property ACCTBR() as string
    Get
	    Return MyBase.ACCTBR
    End Get
    Set (byval value as string)
        MyBase.ACCTBR= value
    End Set
End property 


Public Overrides Property ACCTSEQ() as single
    Get
	    Return MyBase.ACCTSEQ
    End Get
    Set (byval value as single)
        MyBase.ACCTSEQ= value
    End Set
End property 


Public Overrides Property VOUCHER() as single
    Get
	    Return MyBase.VOUCHER
    End Get
    Set (byval value as single)
        MyBase.VOUCHER= value
    End Set
End property 


Public Overrides Property CLOSE() as Boolean
    Get
	    Return MyBase.CLOSE
    End Get
    Set (byval value as Boolean)
        MyBase.CLOSE= value
    End Set
End property 


Public Overrides Property PMAXL() as single
    Get
	    Return MyBase.PMAXL
    End Get
    Set (byval value as single)
        MyBase.PMAXL= value
    End Set
End property 


Public Overrides Property LMAXL() as single
    Get
	    Return MyBase.LMAXL
    End Get
    Set (byval value as single)
        MyBase.LMAXL= value
    End Set
End property 


Public Overrides Property BINIT() as Boolean
    Get
	    Return MyBase.BINIT
    End Get
    Set (byval value as Boolean)
        MyBase.BINIT= value
    End Set
End property 


Public Overrides Property BPOST() as Boolean
    Get
	    Return MyBase.BPOST
    End Get
    Set (byval value as Boolean)
        MyBase.BPOST= value
    End Set
End property 


Public Overrides Property CLR_ONUS() as single
    Get
	    Return MyBase.CLR_ONUS
    End Get
    Set (byval value as single)
        MyBase.CLR_ONUS= value
    End Set
End property 


Public Overrides Property CLR_LOCAL() as single
    Get
	    Return MyBase.CLR_LOCAL
    End Get
    Set (byval value as single)
        MyBase.CLR_LOCAL= value
    End Set
End property 


Public Overrides Property CLR_REG() as single
    Get
	    Return MyBase.CLR_REG
    End Get
    Set (byval value as single)
        MyBase.CLR_REG= value
    End Set
End property 


Public Overrides Property MINBAL() as single
    Get
	    Return MyBase.MINBAL
    End Get
    Set (byval value as single)
        MyBase.MINBAL= value
    End Set
End property 


Public Overrides Property DBDORMANT() as single
    Get
	    Return MyBase.DBDORMANT
    End Get
    Set (byval value as single)
        MyBase.DBDORMANT= value
    End Set
End property 


Public Overrides Property EOM_FLAG() as Boolean
    Get
	    Return MyBase.EOM_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOM_FLAG= value
    End Set
End property 


Public Overrides Property EOQ_FLAG() as Boolean
    Get
	    Return MyBase.EOQ_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOQ_FLAG= value
    End Set
End property 


Public Overrides Property EOY_FLAG() as Boolean
    Get
	    Return MyBase.EOY_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOY_FLAG= value
    End Set
End property 


Public Overrides Property OTC_FLAG() as Boolean
    Get
	    Return MyBase.OTC_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.OTC_FLAG= value
    End Set
End property 


Public Overrides Property EOD_FLAG() as Boolean
    Get
	    Return MyBase.EOD_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOD_FLAG= value
    End Set
End property 


Public Overrides Property P_PRINT() as string
    Get
	    Return MyBase.P_PRINT
    End Get
    Set (byval value as string)
        MyBase.P_PRINT= value
    End Set
End property 


Public Overrides Property R_PRINT() as string
    Get
	    Return MyBase.R_PRINT
    End Get
    Set (byval value as string)
        MyBase.R_PRINT= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ICtrl.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ICtrl.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ICtrl.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Ctrl
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ICtrl
        Inherits _ICtrl

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface