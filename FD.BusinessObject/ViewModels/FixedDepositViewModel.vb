Imports FD.Common.Utilities
Imports System.ComponentModel

Public Class FixedDepositViewModel


    Private _ID As Integer
    <DisplayName("ID")> _
    Public Property Id() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Private _KBCI_NO As String
    <DisplayName("KBCI NO")> _
    Public Property KbciNumber() As String
        Get
            Return _KBCI_NO
        End Get
        Set(ByVal value As String)
            _KBCI_NO = value
        End Set
    End Property

    Private _TRAN_CODE As String
    <DisplayName("TRANSACTION CODE")> _
    <Display(Order:=3)> _
    Public Property TransactionCode() As String
        Get
            Return _TRAN_CODE
        End Get
        Set(ByVal value As String)
            _TRAN_CODE = value
        End Set
    End Property

    Private _DATE As DateTime
    <DisplayName("TRANSACTION DATE")> _
    <Display(Order:=1)> _
    Public Property TransactionDate() As DateTime
        Get
            Return _DATE
        End Get
        Set(ByVal value As DateTime)
            _DATE = value
        End Set
    End Property

    Private _REF As String
    <DisplayName("REFERENCE NO")> _
    <Display(Order:=2)> _
    Public Property ReferenceNumber() As String
        Get
            Return _REF
        End Get
        Set(ByVal value As String)
            _REF = value
        End Set
    End Property

    Private _AMOUNT As Single
    <DisplayName("AMOUNT")> _
    <Display(Order:=5)> _
    Public Property TransactedAmount() As Single
        Get
            Return _AMOUNT
        End Get
        Set(ByVal value As Single)
            _AMOUNT = value
        End Set
    End Property

    Private _BALANCE As Single
    <DisplayName("BALANCE")> _
    <Display(Order:=6)> _
    Public Property Balance() As Single
        Get
            Return _BALANCE
        End Get
        Set(ByVal value As Single)
            _BALANCE = value
        End Set
    End Property

    Private _RMK As String
    <DisplayName("REMARKS")> _
    <Display(Order:=4)> _
    Public Property Remarks() As String
        Get
            Return _RMK
        End Get
        Set(ByVal value As String)
            _RMK = value
        End Set
    End Property

    Private _ADD_DATE As DateTime
    <DisplayName("DATE ADDED")> _
    Public Property DateAdded() As DateTime
        Get
            Return _ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            _ADD_DATE = value
        End Set
    End Property

    Private _USER As String
    <DisplayName("USER")> _
    Public Property User() As String
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            _USER = value
        End Set
    End Property

    Private _LPOSTED As Single
    <DisplayName("PRINTED")> _
    <Display(Order:=7)> _
    Public Property PrintLineNumber() As Single
        Get
            Return _LPOSTED
        End Get
        Set(ByVal value As Single)
            _LPOSTED = value
        End Set
    End Property

    Private _DRCR As String
    <DisplayName("TYPE")> _
    Public Property TransactionType() As String
        Get
            Return _DRCR
        End Get
        Set(ByVal value As String)
            _DRCR = value
        End Set
    End Property

    Private _BANK_CODE As String
    <DisplayName("BANK CODE")> _
    Public Property BankCode() As String
        Get
            Return _BANK_CODE
        End Get
        Set(ByVal value As String)
            _BANK_CODE = value
        End Set
    End Property

    Private _CHECKNO As String
    <DisplayName("CHECK NO")> _
    Public Property CheckNumber() As String
        Get
            Return _CHECKNO
        End Get
        Set(ByVal value As String)
            _CHECKNO = value
        End Set
    End Property

    Private _TPOSTED As Boolean
    <DisplayName("POSTED")> _
    Public Property IsTransactionPosted() As Boolean
        Get
            Return _TPOSTED
        End Get
        Set(ByVal value As Boolean)
            _TPOSTED = value
        End Set
    End Property

    Private _TREVERSED As Boolean
    <DisplayName("REVERSED")> _
    Public Property IsTransactionReversed() As Boolean
        Get
            Return _TREVERSED
        End Get
        Set(ByVal value As Boolean)
            _TREVERSED = value
        End Set
    End Property
End Class
