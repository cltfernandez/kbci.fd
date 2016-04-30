#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Div
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Div
	Inherits _Div
    Implements IDiv

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property DIV_ID() as Int64
    Get
	    Return MyBase.DIV_ID
    End Get
    Set (byval value as Int64)
        MyBase.DIV_ID= value
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


    Public Overrides Property KBCI_NO() As String
        Get
            Return MyBase.KBCI_NO
        End Get
        Set(ByVal value As String)
            MyBase.KBCI_NO = value
        End Set
    End Property


    Public Overrides Property FD_AMT() As Single
        Get
            Return MyBase.FD_AMT
        End Get
        Set(ByVal value As Single)
            MyBase.FD_AMT = value
        End Set
    End Property


    Public Overrides Property DIV_AMT() As Single
        Get
            Return MyBase.DIV_AMT
        End Get
        Set(ByVal value As Single)
            MyBase.DIV_AMT = value
        End Set
    End Property


    Public Overrides Property DEDNS() As Single
        Get
            Return MyBase.DEDNS
        End Get
        Set(ByVal value As Single)
            MyBase.DEDNS = value
        End Set
    End Property


    Public Overrides Property CHKNO() As String
        Get
            Return MyBase.CHKNO
        End Get
        Set(ByVal value As String)
            MyBase.CHKNO = value
        End Set
    End Property


    Public Overrides Property CLAIMED() As DateTime
        Get
            Return MyBase.CLAIMED
        End Get
        Set(ByVal value As DateTime)
            MyBase.CLAIMED = value
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


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IDiv.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IDiv.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IDiv.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Div
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDiv
        Inherits _IDiv

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface