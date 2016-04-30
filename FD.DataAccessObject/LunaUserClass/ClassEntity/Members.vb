#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Members
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Members
	Inherits _Members
    Implements IMembers

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property KBCI_ID() as Int64
    Get
	    Return MyBase.KBCI_ID
    End Get
    Set (byval value as Int64)
        MyBase.KBCI_ID= value
    End Set
End property 


Public Overrides Property KBCI_NO() as string
    Get
	    Return MyBase.KBCI_NO
    End Get
    Set (byval value as string)
        MyBase.KBCI_NO= value
    End Set
End property 


Public Overrides Property LNAME() as string
    Get
	    Return MyBase.LNAME
    End Get
    Set (byval value as string)
        MyBase.LNAME= value
    End Set
End property 


Public Overrides Property FNAME() as string
    Get
	    Return MyBase.FNAME
    End Get
    Set (byval value as string)
        MyBase.FNAME= value
    End Set
End property 


Public Overrides Property MI() as string
    Get
	    Return MyBase.MI
    End Get
    Set (byval value as string)
        MyBase.MI= value
    End Set
End property 


Public Overrides Property MEM_CODE() as string
    Get
	    Return MyBase.MEM_CODE
    End Get
    Set (byval value as string)
        MyBase.MEM_CODE= value
    End Set
End property 


Public Overrides Property MEM_STAT() as string
    Get
	    Return MyBase.MEM_STAT
    End Get
    Set (byval value as string)
        MyBase.MEM_STAT= value
    End Set
End property 


    Public Overrides Property MEM_DATE() As DateTime
        Get
            Return MyBase.MEM_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.MEM_DATE = value
        End Set
    End Property


    Public Overrides Property BY_WHOM() As String
        Get
            Return MyBase.BY_WHOM
        End Get
        Set(ByVal value As String)
            MyBase.BY_WHOM = value
        End Set
    End Property


    Public Overrides Property CB_EMPNO() As String
        Get
            Return MyBase.CB_EMPNO
        End Get
        Set(ByVal value As String)
            MyBase.CB_EMPNO = value
        End Set
    End Property


    Public Overrides Property CB_HIRE() As DateTime
        Get
            Return MyBase.CB_HIRE
        End Get
        Set(ByVal value As DateTime)
            MyBase.CB_HIRE = value
        End Set
    End Property


    Public Overrides Property DEPT() As String
        Get
            Return MyBase.DEPT
        End Get
        Set(ByVal value As String)
            MyBase.DEPT = value
        End Set
    End Property


    Public Overrides Property REGION() As String
        Get
            Return MyBase.REGION
        End Get
        Set(ByVal value As String)
            MyBase.REGION = value
        End Set
    End Property


    Public Overrides Property OFF_TEL() As String
        Get
            Return MyBase.OFF_TEL
        End Get
        Set(ByVal value As String)
            MyBase.OFF_TEL = value
        End Set
    End Property


    Public Overrides Property DORI() As Boolean
        Get
            Return MyBase.DORI
        End Get
        Set(ByVal value As Boolean)
            MyBase.DORI = value
        End Set
    End Property


    Public Overrides Property REA_DORI() As String
        Get
            Return MyBase.REA_DORI
        End Get
        Set(ByVal value As String)
            MyBase.REA_DORI = value
        End Set
    End Property


    Public Overrides Property SEX() As String
        Get
            Return MyBase.SEX
        End Get
        Set(ByVal value As String)
            MyBase.SEX = value
        End Set
    End Property


    Public Overrides Property B_DATE() As DateTime
        Get
            Return MyBase.B_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.B_DATE = value
        End Set
    End Property


    Public Overrides Property CIV_STAT() As String
        Get
            Return MyBase.CIV_STAT
        End Get
        Set(ByVal value As String)
            MyBase.CIV_STAT = value
        End Set
    End Property


    Public Overrides Property MEM_ADDR() As String
        Get
            Return MyBase.MEM_ADDR
        End Get
        Set(ByVal value As String)
            MyBase.MEM_ADDR = value
        End Set
    End Property


    Public Overrides Property RES_TEL() As String
        Get
            Return MyBase.RES_TEL
        End Get
        Set(ByVal value As String)
            MyBase.RES_TEL = value
        End Set
    End Property


    Public Overrides Property POSITION() As String
        Get
            Return MyBase.POSITION
        End Get
        Set(ByVal value As String)
            MyBase.POSITION = value
        End Set
    End Property


    Public Overrides Property SAL_BAS() As Single
        Get
            Return MyBase.SAL_BAS
        End Get
        Set(ByVal value As Single)
            MyBase.SAL_BAS = value
        End Set
    End Property


    Public Overrides Property SAL_ALL() As Single
        Get
            Return MyBase.SAL_ALL
        End Get
        Set(ByVal value As Single)
            MyBase.SAL_ALL = value
        End Set
    End Property


    Public Overrides Property OTH_INC() As Single
        Get
            Return MyBase.OTH_INC
        End Get
        Set(ByVal value As Single)
            MyBase.OTH_INC = value
        End Set
    End Property


    Public Overrides Property FEBTC_SA() As String
        Get
            Return MyBase.FEBTC_SA
        End Get
        Set(ByVal value As String)
            MyBase.FEBTC_SA = value
        End Set
    End Property


    Public Overrides Property FEBTC_CA() As String
        Get
            Return MyBase.FEBTC_CA
        End Get
        Set(ByVal value As String)
            MyBase.FEBTC_CA = value
        End Set
    End Property


    Public Overrides Property FD_CERTNO() As String
        Get
            Return MyBase.FD_CERTNO
        End Get
        Set(ByVal value As String)
            MyBase.FD_CERTNO = value
        End Set
    End Property


    Public Overrides Property FD_DATE() As DateTime
        Get
            Return MyBase.FD_DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.FD_DATE = value
        End Set
    End Property


    Public Overrides Property AP_AMOUNT() As Single
        Get
            Return MyBase.AP_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.AP_AMOUNT = value
        End Set
    End Property


    Public Overrides Property AR_AMOUNT() As Single
        Get
            Return MyBase.AR_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.AR_AMOUNT = value
        End Set
    End Property


    Public Overrides Property FD_AMOUNT() As Single
        Get
            Return MyBase.FD_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.FD_AMOUNT = value
        End Set
    End Property


    Public Overrides Property SD_AMOUNT() As Single
        Get
            Return MyBase.SD_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.SD_AMOUNT = value
        End Set
    End Property


    Public Overrides Property TD_AMOUNT() As Single
        Get
            Return MyBase.TD_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.TD_AMOUNT = value
        End Set
    End Property


    Public Overrides Property OTH_AMOUNT() As Single
        Get
            Return MyBase.OTH_AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.OTH_AMOUNT = value
        End Set
    End Property


    Public Overrides Property YTD_DIVAMT() As Single
        Get
            Return MyBase.YTD_DIVAMT
        End Get
        Set(ByVal value As Single)
            MyBase.YTD_DIVAMT = value
        End Set
    End Property


    Public Overrides Property YTD_LRI() As Single
        Get
            Return MyBase.YTD_LRI
        End Get
        Set(ByVal value As Single)
            MyBase.YTD_LRI = value
        End Set
    End Property


    Public Overrides Property REM_PROP() As String
        Get
            Return MyBase.REM_PROP
        End Get
        Set(ByVal value As String)
            MyBase.REM_PROP = value
        End Set
    End Property


    Public Overrides Property REM_VALUE() As Single
        Get
            Return MyBase.REM_VALUE
        End Get
        Set(ByVal value As Single)
            MyBase.REM_VALUE = value
        End Set
    End Property


    Public Overrides Property NO_DEPEND() As Single
        Get
            Return MyBase.NO_DEPEND
        End Get
        Set(ByVal value As Single)
            MyBase.NO_DEPEND = value
        End Set
    End Property


    Public Overrides Property SP_NAME() As String
        Get
            Return MyBase.SP_NAME
        End Get
        Set(ByVal value As String)
            MyBase.SP_NAME = value
        End Set
    End Property


    Public Overrides Property SP_EMPLOY() As String
        Get
            Return MyBase.SP_EMPLOY
        End Get
        Set(ByVal value As String)
            MyBase.SP_EMPLOY = value
        End Set
    End Property


    Public Overrides Property SP_OFFTEL() As String
        Get
            Return MyBase.SP_OFFTEL
        End Get
        Set(ByVal value As String)
            MyBase.SP_OFFTEL = value
        End Set
    End Property


    Public Overrides Property SP_CBEMPNO() As String
        Get
            Return MyBase.SP_CBEMPNO
        End Get
        Set(ByVal value As String)
            MyBase.SP_CBEMPNO = value
        End Set
    End Property


    Public Overrides Property SP_KBCINO() As String
        Get
            Return MyBase.SP_KBCINO
        End Get
        Set(ByVal value As String)
            MyBase.SP_KBCINO = value
        End Set
    End Property


    Public Overrides Property SP_SALARY() As Single
        Get
            Return MyBase.SP_SALARY
        End Get
        Set(ByVal value As Single)
            MyBase.SP_SALARY = value
        End Set
    End Property


    Public Overrides Property APRUN_AMT() As Single
        Get
            Return MyBase.APRUN_AMT
        End Get
        Set(ByVal value As Single)
            MyBase.APRUN_AMT = value
        End Set
    End Property


    Public Overrides Property ARRUN_AMT() As Single
        Get
            Return MyBase.ARRUN_AMT
        End Get
        Set(ByVal value As Single)
            MyBase.ARRUN_AMT = value
        End Set
    End Property


    Public Overrides Property RUN_AMT() As Single
        Get
            Return MyBase.RUN_AMT
        End Get
        Set(ByVal value As Single)
            MyBase.RUN_AMT = value
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


Public Overrides Property USER() as string
    Get
	    Return MyBase.USER
    End Get
    Set (byval value as string)
        MyBase.USER= value
    End Set
End property 


Public Overrides Property REC_STAT() as Boolean
    Get
	    Return MyBase.REC_STAT
    End Get
    Set (byval value as Boolean)
        MyBase.REC_STAT= value
    End Set
End property 


Public Overrides Property FD_CNTR() as single
    Get
	    Return MyBase.FD_CNTR
    End Get
    Set (byval value as single)
        MyBase.FD_CNTR= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IMembers.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IMembers.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IMembers.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Members
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IMembers
        Inherits _IMembers

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface