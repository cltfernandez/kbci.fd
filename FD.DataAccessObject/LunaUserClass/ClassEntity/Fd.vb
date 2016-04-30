#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Fd
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Fd
	Inherits _Fd
    Implements IFd

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property FD_ID() as Int64
    Get
	    Return MyBase.FD_ID
    End Get
    Set (byval value as Int64)
        MyBase.FD_ID= value
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


Public Overrides Property TRAN_CODE() as string
    Get
	    Return MyBase.TRAN_CODE
    End Get
    Set (byval value as string)
        MyBase.TRAN_CODE= value
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


    Public Overrides Property REF() As String
        Get
            Return MyBase.REF
        End Get
        Set(ByVal value As String)
            MyBase.REF = value
        End Set
    End Property


    Public Overrides Property AMOUNT() As Single
        Get
            Return MyBase.AMOUNT
        End Get
        Set(ByVal value As Single)
            MyBase.AMOUNT = value
        End Set
    End Property


    Public Overrides Property BALANCE() As Single
        Get
            Return MyBase.BALANCE
        End Get
        Set(ByVal value As Single)
            MyBase.BALANCE = value
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


Public Overrides Property LPOSTED() as single
    Get
	    Return MyBase.LPOSTED
    End Get
    Set (byval value as single)
        MyBase.LPOSTED= value
    End Set
End property 


Public Overrides Property DRCR() as string
    Get
	    Return MyBase.DRCR
    End Get
    Set (byval value as string)
        MyBase.DRCR= value
    End Set
End property 


Public Overrides Property BANK_CODE() as string
    Get
	    Return MyBase.BANK_CODE
    End Get
    Set (byval value as string)
        MyBase.BANK_CODE= value
    End Set
End property 


Public Overrides Property CHECKNO() as string
    Get
	    Return MyBase.CHECKNO
    End Get
    Set (byval value as string)
        MyBase.CHECKNO= value
    End Set
End property 


Public Overrides Property TPOSTED() as Boolean
    Get
	    Return MyBase.TPOSTED
    End Get
    Set (byval value as Boolean)
        MyBase.TPOSTED= value
    End Set
End property 


Public Overrides Property TREVERSED() as Boolean
    Get
	    Return MyBase.TREVERSED
    End Get
    Set (byval value as Boolean)
        MyBase.TREVERSED= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IFd.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IFd.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IFd.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Fd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IFd
        Inherits _IFd

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface