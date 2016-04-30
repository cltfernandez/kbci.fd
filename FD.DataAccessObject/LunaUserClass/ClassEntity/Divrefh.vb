#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Divrefh
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Divrefh
	Inherits _Divrefh
    Implements IDivrefh

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property DIVREFH_ID() as Int64
    Get
	    Return MyBase.DIVREFH_ID
    End Get
    Set (byval value as Int64)
        MyBase.DIVREFH_ID= value
    End Set
End property 


Public Overrides Property YEAR() as string
    Get
	    Return MyBase.YEAR
    End Get
    Set (byval value as string)
        MyBase.YEAR= value
    End Set
End property 


Public Overrides Property QUARTER() as string
    Get
	    Return MyBase.QUARTER
    End Get
    Set (byval value as string)
        MyBase.QUARTER= value
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


Public Overrides Property FEBTC_SA() as string
    Get
	    Return MyBase.FEBTC_SA
    End Get
    Set (byval value as string)
        MyBase.FEBTC_SA= value
    End Set
End property 


Public Overrides Property DIVIDEND() as single
    Get
	    Return MyBase.DIVIDEND
    End Get
    Set (byval value as single)
        MyBase.DIVIDEND= value
    End Set
End property 


Public Overrides Property REFUND() as single
    Get
	    Return MyBase.REFUND
    End Get
    Set (byval value as single)
        MyBase.REFUND= value
    End Set
End property 


Public Overrides Property DEDUCTIONS() as single
    Get
	    Return MyBase.DEDUCTIONS
    End Get
    Set (byval value as single)
        MyBase.DEDUCTIONS= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IDivrefh.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IDivrefh.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IDivrefh.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Divrefh
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDivrefh
        Inherits _IDivrefh

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface