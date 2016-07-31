Public Class DivrefPostingViewModel



    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _Year As String
    Public Property YEAR() As String
        Get
            Return _Year
        End Get
        Set(ByVal value As String)
            _Year = value
        End Set
    End Property



    Private _QUARTER As String
    Public Property QUARTER() As String
        Get
            Return _QUARTER
        End Get
        Set(ByVal value As String)
            _QUARTER = value
        End Set
    End Property

    Private _CVNO As String
    Public Property CVNO() As String
        Get
            Return _CVNO
        End Get
        Set(ByVal value As String)
            _CVNO = value
        End Set
    End Property
End Class
