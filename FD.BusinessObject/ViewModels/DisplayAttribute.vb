<AttributeUsage(AttributeTargets.Property)> _
Class DisplayAttribute
    Inherits Attribute

    Public Order As Integer
    Public Property DisplayOrder() As Integer
        Get
            Return Order
        End Get
        Set(ByVal value As Integer)
            Order = value
        End Set
    End Property
End Class
