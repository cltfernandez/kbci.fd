Imports FD.DataAccessObject
Imports FD.Common
Imports FD.ViewModels
Imports AutoMapper
Public Class ApplicationSettingsService : Implements IFormOperations

    Sub New()
        Mapper.CreateMap(Of Ctrl, CtrlViewModel)()
    End Sub
    Public Function GetAll() As Object Implements IFormOperations.GetAll
        Dim ctrlObject As New CtrlViewModel
        Dim ctrlEntity As Ctrl
        Using rsCtrlDAO As New CtrlDAO
            Dim param As New LUNA.LunaSearchParameter("CTRL_ID", "1")
            ctrlEntity = rsCtrlDAO.Find(param)
            Mapper.Map(ctrlEntity, ctrlObject)

            Return ctrlObject
        End Using
    End Function
End Class
