#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 16/04/2016 
#End Region



''' <summary>
'''Entity Class for table Pat_ref
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Pat_ref
	Inherits _Pat_ref
    Implements IPat_ref

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property PAT_REF_ID() as Int64
    Get
	    Return MyBase.PAT_REF_ID
    End Get
    Set (byval value as Int64)
        MyBase.PAT_REF_ID= value
    End Set
End property 


Public Overrides Property PERCENT() as single
    Get
	    Return MyBase.PERCENT
    End Get
    Set (byval value as single)
        MyBase.PERCENT= value
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


Public Overrides Property YTD_PCT() as single
    Get
	    Return MyBase.YTD_PCT
    End Get
    Set (byval value as single)
        MyBase.YTD_PCT= value
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

Public Overrides Function IsValid() As Boolean Implements IPat_ref.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IPat_ref.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IPat_ref.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Pat_ref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IPat_ref
        Inherits _IPat_ref

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface