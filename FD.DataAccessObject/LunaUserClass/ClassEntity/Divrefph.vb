#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



''' <summary>
'''Entity Class for table Divrefph
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Divrefph
	Inherits _Divrefph
    Implements IDivrefph

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property DIVREFPH_ID() as Int64
    Get
	    Return MyBase.DIVREFPH_ID
    End Get
    Set (byval value as Int64)
        MyBase.DIVREFPH_ID= value
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


    Public Overrides Property FD_CUTOFF() As DateTime
        Get
            Return MyBase.FD_CUTOFF
        End Get
        Set(ByVal value As DateTime)
            MyBase.FD_CUTOFF = value
        End Set
    End Property


    Public Overrides Property FD_PERCENT() As Single
        Get
            Return MyBase.FD_PERCENT
        End Get
        Set(ByVal value As Single)
            MyBase.FD_PERCENT = value
        End Set
    End Property


    Public Overrides Property PR_YEAR() As String
        Get
            Return MyBase.PR_YEAR
        End Get
        Set(ByVal value As String)
            MyBase.PR_YEAR = value
        End Set
    End Property


    Public Overrides Property PR_PERCENT() As Single
        Get
            Return MyBase.PR_PERCENT
        End Get
        Set(ByVal value As Single)
            MyBase.PR_PERCENT = value
        End Set
    End Property


    Public Overrides Property PR_INTFROM() As DateTime
        Get
            Return MyBase.PR_INTFROM
        End Get
        Set(ByVal value As DateTime)
            MyBase.PR_INTFROM = value
        End Set
    End Property


    Public Overrides Property PR_INTTO() As DateTime
        Get
            Return MyBase.PR_INTTO
        End Get
        Set(ByVal value As DateTime)
            MyBase.PR_INTTO = value
        End Set
    End Property


    Public Overrides Property TDEBDESC1() As String
        Get
            Return MyBase.TDEBDESC1
        End Get
        Set(ByVal value As String)
            MyBase.TDEBDESC1 = value
        End Set
    End Property


    Public Overrides Property TDEBAMT1() As Single
        Get
            Return MyBase.TDEBAMT1
        End Get
        Set(ByVal value As Single)
            MyBase.TDEBAMT1 = value
        End Set
    End Property


    Public Overrides Property TDEBDESC2() As String
        Get
            Return MyBase.TDEBDESC2
        End Get
        Set(ByVal value As String)
            MyBase.TDEBDESC2 = value
        End Set
    End Property


    Public Overrides Property TDEBAMT2() As Single
        Get
            Return MyBase.TDEBAMT2
        End Get
        Set(ByVal value As Single)
            MyBase.TDEBAMT2 = value
        End Set
    End Property


    Public Overrides Property TDEBDESC3() As String
        Get
            Return MyBase.TDEBDESC3
        End Get
        Set(ByVal value As String)
            MyBase.TDEBDESC3 = value
        End Set
    End Property


    Public Overrides Property TDEBAMT3() As Single
        Get
            Return MyBase.TDEBAMT3
        End Get
        Set(ByVal value As Single)
            MyBase.TDEBAMT3 = value
        End Set
    End Property


    Public Overrides Property TDIVAMT() As Single
        Get
            Return MyBase.TDIVAMT
        End Get
        Set(ByVal value As Single)
            MyBase.TDIVAMT = value
        End Set
    End Property


    Public Overrides Property TREFAMT() As Single
        Get
            Return MyBase.TREFAMT
        End Get
        Set(ByVal value As Single)
            MyBase.TREFAMT = value
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


    Public Overrides Property HOLDOUT() As Boolean
        Get
            Return MyBase.HOLDOUT
        End Get
        Set(ByVal value As Boolean)
            MyBase.HOLDOUT = value
        End Set
    End Property


    Public Overrides Property POSTED() As Boolean
        Get
            Return MyBase.POSTED
        End Get
        Set(ByVal value As Boolean)
            MyBase.POSTED = value
        End Set
    End Property


    Public Overrides Property CVNO() As String
        Get
            Return MyBase.CVNO
        End Get
        Set(ByVal value As String)
            MyBase.CVNO = value
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


Public Overrides Property P_APL() as single
    Get
	    Return MyBase.P_APL
    End Get
    Set (byval value as single)
        MyBase.P_APL= value
    End Set
End property 


Public Overrides Property P_EDL() as single
    Get
	    Return MyBase.P_EDL
    End Get
    Set (byval value as single)
        MyBase.P_EDL= value
    End Set
End property 


Public Overrides Property P_EML() as single
    Get
	    Return MyBase.P_EML
    End Get
    Set (byval value as single)
        MyBase.P_EML= value
    End Set
End property 


Public Overrides Property P_RGL() as single
    Get
	    Return MyBase.P_RGL
    End Get
    Set (byval value as single)
        MyBase.P_RGL= value
    End Set
End property 


Public Overrides Property P_RSL() as single
    Get
	    Return MyBase.P_RSL
    End Get
    Set (byval value as single)
        MyBase.P_RSL= value
    End Set
End property 


Public Overrides Property P_SPL() as single
    Get
	    Return MyBase.P_SPL
    End Get
    Set (byval value as single)
        MyBase.P_SPL= value
    End Set
End property 


Public Overrides Property P_STL() as single
    Get
	    Return MyBase.P_STL
    End Get
    Set (byval value as single)
        MyBase.P_STL= value
    End Set
End property 


Public Overrides Property P_PTL() as single
    Get
	    Return MyBase.P_PTL
    End Get
    Set (byval value as single)
        MyBase.P_PTL= value
    End Set
End property 


Public Overrides Property PD_APL() as single
    Get
	    Return MyBase.PD_APL
    End Get
    Set (byval value as single)
        MyBase.PD_APL= value
    End Set
End property 


Public Overrides Property PD_EDL() as single
    Get
	    Return MyBase.PD_EDL
    End Get
    Set (byval value as single)
        MyBase.PD_EDL= value
    End Set
End property 


Public Overrides Property PD_EML() as single
    Get
	    Return MyBase.PD_EML
    End Get
    Set (byval value as single)
        MyBase.PD_EML= value
    End Set
End property 


Public Overrides Property PD_RGL() as single
    Get
	    Return MyBase.PD_RGL
    End Get
    Set (byval value as single)
        MyBase.PD_RGL= value
    End Set
End property 


Public Overrides Property PD_RSL() as single
    Get
	    Return MyBase.PD_RSL
    End Get
    Set (byval value as single)
        MyBase.PD_RSL= value
    End Set
End property 


Public Overrides Property PD_SPL() as single
    Get
	    Return MyBase.PD_SPL
    End Get
    Set (byval value as single)
        MyBase.PD_SPL= value
    End Set
End property 


Public Overrides Property PD_STL() as single
    Get
	    Return MyBase.PD_STL
    End Get
    Set (byval value as single)
        MyBase.PD_STL= value
    End Set
End property 


Public Overrides Property PD_PTL() as single
    Get
	    Return MyBase.PD_PTL
    End Get
    Set (byval value as single)
        MyBase.PD_PTL= value
    End Set
End property 


Public Overrides Property INTEREST() as single
    Get
	    Return MyBase.INTEREST
    End Get
    Set (byval value as single)
        MyBase.INTEREST= value
    End Set
End property 


Public Overrides Property PENALTY() as single
    Get
	    Return MyBase.PENALTY
    End Get
    Set (byval value as single)
        MyBase.PENALTY= value
    End Set
End property 


Public Overrides Property SAVINGS() as single
    Get
	    Return MyBase.SAVINGS
    End Get
    Set (byval value as single)
        MyBase.SAVINGS= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IDivrefph.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IDivrefph.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IDivrefph.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Divrefph
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDivrefph
        Inherits _IDivrefph

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface