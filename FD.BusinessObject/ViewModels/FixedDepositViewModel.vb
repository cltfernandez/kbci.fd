Public Class FixedDepositViewModel




    Private _KBCI_NO As String
    Public Property KBCI_NO() As String
        Get
            Return _KBCI_NO
        End Get
        Set(ByVal value As String)
            _KBCI_NO = _KBCI_NO
        End Set
    End Property

    Private _TRAN_CODE As String
    Public Property TRAN_CODE() As String
        Get
            Return _TRAN_CODE
        End Get
        Set(ByVal value As String)
            _TRAN_CODE = value
        End Set
    End Property

    Private _DATE As DateTime
    Public Property [DATE]() As DateTime
        Get
            Return _DATE
        End Get
        Set(ByVal value As DateTime)
            _DATE = value
        End Set
    End Property

    Private _REF As String
    Public Property REF() As String
        Get
            Return _REF
        End Get
        Set(ByVal value As String)
            _REF = value
        End Set
    End Property

    Private _AMOUNT As Single
    Public Property AMOUNT() As Single
        Get
            Return _AMOUNT
        End Get
        Set(ByVal value As Single)
            _AMOUNT = value
        End Set
    End Property

    Private _BALANCE As Single
    Public Property BALANCE() As Single
        Get
            Return _BALANCE
        End Get
        Set(ByVal value As Single)
            _BALANCE = value
        End Set
    End Property

    Private _RMK As String
    Public Property RMK() As String
        Get
            Return _RMK
        End Get
        Set(ByVal value As String)
            _RMK = value
        End Set
    End Property

    Private _ADD_DATE As DateTime
    Public Property ADD_DATE() As DateTime
        Get
            Return _ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            _ADD_DATE = value
        End Set
    End Property

    Private _USER As String
    Public Property USER() As String
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            _USER = value
        End Set
    End Property

    Private _LPOSTED As Single
    Public Property LPOSTED() As Single
        Get
            Return _LPOSTED
        End Get
        Set(ByVal value As Single)
            _LPOSTED = value
        End Set
    End Property

    Private _DRCR As String
    Public Property DRCR() As String
        Get
            Return _DRCR
        End Get
        Set(ByVal value As String)
            _DRCR = value
        End Set
    End Property

    Private _BANK_CODE As String
    Public Property BANK_CODE() As String
        Get
            Return _BANK_CODE
        End Get
        Set(ByVal value As String)
            _BANK_CODE = value
        End Set
    End Property

    Private _CHECKNO As String
    Public Property CHECKNO() As String
        Get
            Return _CHECKNO
        End Get
        Set(ByVal value As String)
            _CHECKNO = value
        End Set
    End Property

    Private _TPOSTED As Boolean
    Public Property TPOSTED() As Boolean
        Get
            Return _TPOSTED
        End Get
        Set(ByVal value As Boolean)
            _TPOSTED = value
        End Set
    End Property

    Private _TREVERSED As Boolean
    Public Property TREVERSED() As Boolean
        Get
            Return _TREVERSED
        End Get
        Set(ByVal value As Boolean)
            _TREVERSED = value
        End Set
    End Property
End Class
