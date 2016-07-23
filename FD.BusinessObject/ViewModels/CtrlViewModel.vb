Public Class CtrlViewModel

    Public CTRL_ID As Int64
    Public Property Id() As Int64
        Get
            Return CTRL_ID
        End Get
        Set(ByVal value As Int64)
            CTRL_ID = value
        End Set
    End Property

    Public KBCI_NO As String
    Public Property KbciNumber() As String
        Get
            Return KBCI_NO
        End Get
        Set(ByVal value As String)
            KBCI_NO = value
        End Set
    End Property

    Public SYSDATE As DateTime
    Public Property SystemDate() As DateTime
        Get
            Return SYSDATE
        End Get
        Set(ByVal value As DateTime)
            SYSDATE = value
        End Set
    End Property

    Public ADMDATE As DateTime
    Public Property AdminDate() As DateTime
        Get
            Return ADMDATE
        End Get
        Set(ByVal value As DateTime)
            ADMDATE = value
        End Set
    End Property

    Public CHG_DATE As DateTime
    Public Property ChangedDate() As DateTime
        Get
            Return CHG_DATE
        End Get
        Set(ByVal value As DateTime)
            CHG_DATE = value
        End Set
    End Property

    Public USER As String
    Public Property UserName() As String
        Get
            Return USER
        End Get
        Set(ByVal value As String)
            USER = value
        End Set
    End Property

    Public RUN_DATE As DateTime
    Public Property RunDate() As DateTime
        Get
            Return RUN_DATE
        End Get
        Set(ByVal value As DateTime)
            RUN_DATE = value
        End Set
    End Property

    Public VOUCHER As Single
    Public Property VoucherNumber() As Single
        Get
            Return VOUCHER
        End Get
        Set(ByVal value As Single)
            VOUCHER = value
        End Set
    End Property


End Class
