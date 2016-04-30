Imports FD.ViewModels
Public Interface IUserService
    Sub ChangeUserLoginStatus(ByVal LoggedInUser As UserViewModel, ByVal LoggedIn As Boolean)
End Interface

Public Interface IPasswordValidator
    Function ValidatePassword(ByVal Username As String, ByVal Password As String) As UserViewModel
End Interface
