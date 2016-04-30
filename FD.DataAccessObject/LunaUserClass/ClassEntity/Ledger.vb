#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Ledger
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Ledger
	Inherits _Ledger
    Implements ILedger

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property LEDGER_ID() as Int64
    Get
	    Return MyBase.LEDGER_ID
    End Get
    Set (byval value as Int64)
        MyBase.LEDGER_ID= value
    End Set
End property 


Public Overrides Property PN_NO() as string
    Get
	    Return MyBase.PN_NO
    End Get
    Set (byval value as string)
        MyBase.PN_NO= value
    End Set
End property 


    Public Overrides Property [DATE]() As DateTime
        Get
            Return MyBase.DATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.DATE = value
        End Set
    End Property


    Public Overrides Property DOX_TYPE() As String
        Get
            Return MyBase.DOX_TYPE
        End Get
        Set(ByVal value As String)
            MyBase.DOX_TYPE = value
        End Set
    End Property


    Public Overrides Property REF() As String
        Get
            Return MyBase.REF
        End Get
        Set(ByVal value As String)
            MyBase.REF = value
        End Set
    End Property


    Public Overrides Property ACCT_TYPE() As String
        Get
            Return MyBase.ACCT_TYPE
        End Get
        Set(ByVal value As String)
            MyBase.ACCT_TYPE = value
        End Set
    End Property


    Public Overrides Property ACCT_CODE() As String
        Get
            Return MyBase.ACCT_CODE
        End Get
        Set(ByVal value As String)
            MyBase.ACCT_CODE = value
        End Set
    End Property


    Public Overrides Property BEGBAL() As Single
        Get
            Return MyBase.BEGBAL
        End Get
        Set(ByVal value As Single)
            MyBase.BEGBAL = value
        End Set
    End Property


    Public Overrides Property DR() As Single
        Get
            Return MyBase.DR
        End Get
        Set(ByVal value As Single)
            MyBase.DR = value
        End Set
    End Property


    Public Overrides Property CR() As Single
        Get
            Return MyBase.CR
        End Get
        Set(ByVal value As Single)
            MyBase.CR = value
        End Set
    End Property


    Public Overrides Property ENDBAL() As Single
        Get
            Return MyBase.ENDBAL
        End Get
        Set(ByVal value As Single)
            MyBase.ENDBAL = value
        End Set
    End Property


    Public Overrides Property RMK() As String
        Get
            Return MyBase.RMK
        End Get
        Set(ByVal value As String)
            MyBase.RMK = value
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


Public Overrides Property USER() as string
    Get
	    Return MyBase.USER
    End Get
    Set (byval value as string)
        MyBase.USER= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ILedger.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ILedger.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ILedger.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Ledger
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ILedger
        Inherits _ILedger

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface