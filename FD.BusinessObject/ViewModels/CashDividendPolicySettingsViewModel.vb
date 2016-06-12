Public Class CashDividendPolicySettingsViewModel

    Public [DATE] As Date
    Public PERCENT As Single
    Public YTD_PCT As Single
    Public PROC_DATE As Date
    Public ADD_DATE As Date
    Public CHG_DATE As Date
    Public USER As String
    Public Property TransactionDate() As Date
        Get
            Return [DATE]
        End Get
        Set(ByVal value As Date)
            [DATE] = value
        End Set
    End Property


    Public Property Percentage() As Single
        Get
            Return PERCENT
        End Get
        Set(ByVal value As Single)
            PERCENT = value
        End Set
    End Property


    Public Property YearToDatePercentage() As Single
        Get
            Return YTD_PCT
        End Get
        Set(ByVal value As Single)
            YTD_PCT = value
        End Set
    End Property

    Public Property ProcessingDate() As Date
        Get
            Return PROC_DATE
        End Get
        Set(ByVal value As Date)
            PROC_DATE = value
        End Set
    End Property

    Public Property DateAdded() As Date
        Get
            Return ADD_DATE
        End Get
        Set(ByVal value As Date)
            ADD_DATE = value
        End Set
    End Property

    Public Property DateUpdated() As Date
        Get
            Return CHG_DATE
        End Get
        Set(ByVal value As Date)
            CHG_DATE = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return USER
        End Get
        Set(ByVal value As String)
            USER = value
        End Set
    End Property
End Class
