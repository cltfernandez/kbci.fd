Imports FD.Common
Public Class UserViewModel


    Private _UserID As Integer
    Public Property UserID() As Integer
        Get
            Return _UserID
        End Get
        Set(ByVal value As Integer)
            _UserID = value
        End Set
    End Property

    Private _Username As String
    Public Property UserName() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Private _FullName As String
    Public Property FullName() As String
        Get
            Return _FullName
        End Get
        Set(ByVal value As String)
            _FullName = value
        End Set
    End Property

    Private _PasswordValidationResult As ValidationResult
    Public Property PasswordValidationResult() As ValidationResult
        Get
            Return _PasswordValidationResult
        End Get
        Set(ByVal value As ValidationResult)
            _PasswordValidationResult = value
        End Set
    End Property


End Class

