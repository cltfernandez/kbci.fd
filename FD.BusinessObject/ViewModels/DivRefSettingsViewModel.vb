Public Class DivRefSettingsViewModel


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

    Private _FEBTC_SA As String
    Public Property FEBTC_SA() As String
        Get
            Return _FEBTC_SA
        End Get
        Set(ByVal value As String)
            _FEBTC_SA = value
        End Set
    End Property

    Private _DIVIDEND As Single
    Public Property DIVIDEND() As Single
        Get
            Return _DIVIDEND
        End Get
        Set(ByVal value As Single)
            _DIVIDEND = value
        End Set
    End Property

    Private _REFUND As Single
    Public Property REFUND() As Single
        Get
            Return _REFUND
        End Get
        Set(ByVal value As Single)
            _REFUND = value
        End Set
    End Property
End Class
