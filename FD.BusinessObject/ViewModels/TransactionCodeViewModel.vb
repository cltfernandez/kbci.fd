Public Class TransactionCodeViewModel

    Private _TransactionID As String
    Public Property TransactionID() As String
        Get
            Return _TransactionID
        End Get
        Set(ByVal value As String)
            _TransactionID = value
        End Set
    End Property


    Private _TransactionCode As String
    Public Property TransactionCode() As String
        Get
            Return _TransactionCode
        End Get
        Set(ByVal value As String)
            _TransactionCode = value
        End Set
    End Property
End Class
