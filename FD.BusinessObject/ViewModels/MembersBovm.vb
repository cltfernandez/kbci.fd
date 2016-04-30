
Public Class MembersBOVM
    Private _KBCI_ID As Int64
    Public Property KBCI_ID() As Int64
        Get
            Return _KBCI_ID
        End Get
        Set(ByVal value As Int64)
            _KBCI_ID = value
        End Set
    End Property


    Private _KBCI_NO As String
    Public Property KBCI_NO() As String
        Get
            Return _KBCI_NO
        End Get
        Set(ByVal value As String)
            _KBCI_NO = value
        End Set
    End Property

    Private _LNAME As String
    Public Property LNAME() As String
        Get
            Return _LNAME
        End Get
        Set(ByVal value As String)
            _LNAME = value
        End Set
    End Property

    Private _FNAME As String
    Public Property FNAME() As String
        Get
            Return _FNAME
        End Get
        Set(ByVal value As String)
            _FNAME = value
        End Set
    End Property

    Private _MI As String
    Public Property MI() As String
        Get
            Return _MI
        End Get
        Set(ByVal value As String)
            _MI = value
        End Set
    End Property
    Private _MEM_STAT As String
    Public Property MEM_STAT() As String
        Get
            Return _MEM_STAT
        End Get
        Set(ByVal value As String)
            _MEM_STAT = value
        End Set
    End Property

    Private _MEM_DATE As Date
    Public Property [DATE]() As Date
        Get
            Return _MEM_DATE
        End Get
        Set(ByVal value As Date)
            _MEM_DATE = value
        End Set
    End Property

    Private _FD_AMOUNT As Decimal
    Public Property FD_AMOUNT() As Decimal
        Get
            Return _FD_AMOUNT
        End Get
        Set(ByVal value As Decimal)
            _FD_AMOUNT = value
        End Set
    End Property
End Class
