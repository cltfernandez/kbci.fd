#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 16/04/2016 
#End Region



''' <summary>
'''Entity Class for table Ref
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Ref
	Inherits _Ref
    Implements IRef

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property REF_ID() as Int64
    Get
	    Return MyBase.REF_ID
    End Get
    Set (byval value as Int64)
        MyBase.REF_ID= value
    End Set
End property 


Public Overrides Property [DATE]() as DateTime
    Get
	    Return MyBase.DATE
    End Get
    Set (byval value as DateTime)
        MyBase.DATE= value
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


Public Overrides Property INT_PAID() as single
    Get
	    Return MyBase.INT_PAID
    End Get
    Set (byval value as single)
        MyBase.INT_PAID= value
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


Public Overrides Property CLAIMED() as Boolean
    Get
	    Return MyBase.CLAIMED
    End Get
    Set (byval value as Boolean)
        MyBase.CLAIMED= value
    End Set
End property 


Public Overrides Property DEDNS() as single
    Get
	    Return MyBase.DEDNS
    End Get
    Set (byval value as single)
        MyBase.DEDNS= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IRef.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IRef.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IRef.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IRef
        Inherits _IRef

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface