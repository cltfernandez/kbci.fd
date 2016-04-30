Imports FD.ViewModels
Imports FD.Common
Imports FD.DataAccessObject
Imports System

Public Class UserService : Implements IPasswordValidator, IUserService
    Public Sub New()

    End Sub
    Public Function ValidatePassword(ByVal Username As String, ByVal Password As String) As UserViewModel Implements IPasswordValidator.ValidatePassword
        Dim Crypt As New Crpyto(Username, System.Configuration.ConfigurationManager.AppSettings("32"))
        Dim LoginUser As New User
        Dim param As LUNA.LunaSearchParameter
        Dim result As New UserViewModel
        Using LoginUserDAO As New UserDAO

            If IsInputValid(Username, Password) Then
                param = New LUNA.LunaSearchParameter("USERNAME", Username)
                LoginUser = LoginUserDAO.Find(param)
                If Not LoginUser Is Nothing Then
                    If Crypt.GetEncryptedText(Password) = LoginUser.USERPASS Then
                        If True Then 'Not LoginUser.LOGGED Then
                            result = InjectFrom(LoginUser, ValidationResult.Passed)
                            ChangeUserLoginStatus(result, True)
                        Else
                            result.PasswordValidationResult = ValidationResult.UserIsLoggedIn
                        End If
                        Return result
                    End If
                End If
            End If
        End Using
        result.PasswordValidationResult = ValidationResult.Failed
        Return result
    End Function

    Public Sub ChangeUserLoginStatus(ByVal LoggedInUser As UserViewModel, ByVal LoggedIn As Boolean) Implements IUserService.ChangeUserLoginStatus

        Using loggedUserDAO As New UserDAO
            Dim param As New LUNA.LunaSearchParameter("USER_ID", LoggedInUser.UserID)
            Dim loggedUser = loggedUserDAO.Find(param)
            loggedUser.LOGGED = LoggedIn
            loggedUser.Save()
        End Using
    End Sub

    Private Function IsInputValid(ByVal Username As String, ByVal Password As String) As Boolean
        Return Username <> "" And Password <> ""
    End Function

    Private Function InjectFrom(ByVal userDao As User, ByVal _validationResult As ValidationResult) As UserViewModel
        Dim result As New UserViewModel
        With result
            .UserID = userDao.USER_ID
            .UserName = userDao.USERNAME
            .FullName = userDao.NAME
            .PasswordValidationResult = _validationResult
        End With
        Return result
    End Function
End Class
