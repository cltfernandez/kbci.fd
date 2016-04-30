#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 10/04/2016 
#End Region



''' <summary>
'''Entity Class for table Cashdiv
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Cashdiv
	Inherits _Cashdiv
    Implements ICashdiv

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property CASHDIV_ID() as Int64
    Get
	    Return MyBase.CASHDIV_ID
    End Get
    Set (byval value as Int64)
        MyBase.CASHDIV_ID= value
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


Public Overrides Property PERCENT() as single
    Get
	    Return MyBase.PERCENT
    End Get
    Set (byval value as single)
        MyBase.PERCENT= value
    End Set
End property 


Public Overrides Property YTD_PCT() as single
    Get
	    Return MyBase.YTD_PCT
    End Get
    Set (byval value as single)
        MyBase.YTD_PCT= value
    End Set
End property 


Public Overrides Property PROC_DATE() as DateTime
    Get
	    Return MyBase.PROC_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.PROC_DATE= value
    End Set
End property 


Public Overrides Property ADD_DATE() as DateTime
    Get
	    Return MyBase.ADD_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.ADD_DATE= value
    End Set
End property 


Public Overrides Property CHG_DATE() as DateTime
    Get
	    Return MyBase.CHG_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.CHG_DATE= value
    End Set
End property 


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

Public Overrides Function IsValid() As Boolean Implements ICashdiv.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ICashdiv.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ICashdiv.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Cashdiv
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ICashdiv
        Inherits _ICashdiv

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface