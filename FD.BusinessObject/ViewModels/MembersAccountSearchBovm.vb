
Public Class MembersAccountSearchBovm

    Private _SDMASTER_ID As Int64
    Public Property SDMASTER_ID() As Int64
        Get
            Return _SDMASTER_ID
        End Get
        Set(ByVal value As Int64)
            _SDMASTER_ID = value
        End Set
    End Property

    Private _ACCTNO As String
    Public Property ACCTNO() As String
        Get
            Return _ACCTNO
        End Get
        Set(ByVal value As String)
            _ACCTNO = value
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

    Private _ACCTNAME As String
    Public Property ACCTNAME() As String
        Get
            Return _ACCTNAME
        End Get
        Set(ByVal value As String)
            _ACCTNAME = value
        End Set
    End Property

    Private _ACCTSTAT As String
    Public Property ACCTSTAT() As String
        Get
            Return _ACCTSTAT
        End Get
        Set(ByVal value As String)
            _ACCTSTAT = value
        End Set
    End Property
End Class
