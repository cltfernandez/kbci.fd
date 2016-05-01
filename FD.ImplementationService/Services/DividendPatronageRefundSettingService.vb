Imports FD.DataAccessObject
Imports FD.Common.Utilities
Imports FD.ViewModels
Imports FD.Common


Public Class DividendPatronageRefundSettingService : Implements IDividendPatronageRefundSettingService

    Public Function ValidateSettings(ByVal Year As String, ByVal Quarter As String) As DivRefSettingsValidationResult Implements IDividendPatronageRefundSettingService.ValidateSettings
        Using rsDivRefPhDAO As New DivrefphDAO
            Dim rsDIV As New Divrefph
            Dim param1 As New LUNA.LunaSearchParameter("YEAR", Year)
            Dim param2 As New LUNA.LunaSearchParameter("QUARTER", Quarter)


            rsDIV = rsDivRefPhDAO.Find(param1, param2)
            If Not rsDIV Is Nothing Then
                If rsDIV.CVNO.Trim = String.Empty Or rsDIV.POSTED = True Then
                    Return DivRefSettingsValidationResult.Invalid
                End If
            Else
                Return DivRefSettingsValidationResult.NotFound
            End If
        End Using
    End Function

    Public Function GetDividendPatronageRefundPosting(ByVal Options As ViewOptions, ByVal Year As String, ByVal Quarter As String) As List(Of DivRefSettingsViewModel) Implements IDividendPatronageRefundSettingService.GetDividendPatronageRefundPosting
        Dim result As New List(Of DivRefSettingsViewModel)
        If Options = ViewOptions.Current Then

            Using rsDivrefDao As New DivrefDAO
                Dim DivRefList As List(Of Divref)
                DivRefList = rsDivrefDao.GetAll()

                For Each element As Divref In DivRefList
                    Dim viewmodel As New DivRefSettingsViewModel
                    With element
                        viewmodel.DIVIDEND = .DIVIDEND
                        viewmodel.FEBTC_SA = .FEBTC_SA
                        viewmodel.FNAME = .FNAME
                        viewmodel.KBCI_NO = .KBCI_NO
                        viewmodel.LNAME = .LNAME
                        viewmodel.MI = .MI
                        viewmodel.REFUND = .REFUND
                    End With
                    result.Add(viewmodel)
                Next
            End Using
        Else
            Using rsDivRefhDAO As New DivrefhDAO
                Dim DivRefhList As New List(Of Divrefh)
                Dim rsDIV As New Divrefph
                Dim param1 As New LUNA.LunaSearchParameter("YEAR", Year)
                Dim param2 As New LUNA.LunaSearchParameter("QUARTER", Quarter)
                DivRefhList = rsDivRefhDAO.FindAll(param1, param2)

                For Each element As Divrefh In DivRefhList
                    Dim viewmodel As New DivRefSettingsViewModel
                    With element
                        viewmodel.DIVIDEND = .DIVIDEND
                        viewmodel.FEBTC_SA = .FEBTC_SA
                        viewmodel.FNAME = .FNAME
                        viewmodel.KBCI_NO = .KBCI_NO
                        viewmodel.LNAME = .LNAME
                        viewmodel.MI = .MI
                        viewmodel.REFUND = .REFUND
                    End With
                    result.Add(viewmodel)
                Next
            End Using
        End If
        Return result
    End Function


    Public Function Save(ByVal saveParameter As DivrefSaveParameters, ByVal dividendAmount As Decimal, ByVal refundAmount As Decimal, ByVal ViewOption As ViewOptions) As RecordUpdateResult Implements IDividendPatronageRefundSettingService.Save

        'TODO: CREATE A SAVE METHOD FOR HISTORY RECORDS SINCE KBCI_NO PARAMETER IS ONLY APPLICABLE FOR DIVREF TABLE
        'TODO: CREATE A SAVE METHOD FOR HISTORY RECORDS SINCE KBCI_NO PARAMETER IS ONLY APPLICABLE FOR DIVREF TABLE
        'TODO: CREATE A SAVE METHOD FOR HISTORY RECORDS SINCE KBCI_NO PARAMETER IS ONLY APPLICABLE FOR DIVREF TABLE
        'TODO: CREATE A SAVE METHOD FOR HISTORY RECORDS SINCE KBCI_NO PARAMETER IS ONLY APPLICABLE FOR DIVREF TABLE
        'TODO: CREATE A SAVE METHOD FOR HISTORY RECORDS SINCE KBCI_NO PARAMETER IS ONLY APPLICABLE FOR DIVREF TABLE
        Dim result As RecordUpdateResult = RecordUpdateResult.AddSuccessful
        If ViewOption = ViewOptions.Current Then
            Using rsDivRefDao As New DivrefDAO
                Dim rsDIV As New Divref
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)

                rsDIV = rsDivRefDao.Find(param1)

                If Not rsDIV Is Nothing Then
                    rsDIV.DIVIDEND = dividendAmount
                    rsDIV.REFUND = refundAmount
                    If rsDivRefDao.Save(rsDIV) = 1 Then
                        result = RecordUpdateResult.UpdateSuccessful
                    Else
                        result = RecordUpdateResult.Unsuccessful
                    End If
                Else
                    Using rsMember As New MembersDAO

                        Dim param2 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)
                        Dim MemberRecord As Members = rsMember.Find(param2)
                        If Not MemberRecord Is Nothing Then
                            With MemberRecord
                                rsDIV.DIVIDEND = dividendAmount
                                rsDIV.FEBTC_SA = .FEBTC_SA
                                rsDIV.FNAME = .FNAME
                                rsDIV.KBCI_NO = .KBCI_NO
                                rsDIV.LNAME = .LNAME
                                rsDIV.MI = .MI
                                rsDIV.REFUND = refundAmount
                            End With
                            If rsDivRefDao.Save(rsDIV) > 0 Then
                                result = RecordUpdateResult.AddSuccessful
                            Else
                                result = RecordUpdateResult.Unsuccessful
                            End If
                        Else
                            result = RecordUpdateResult.Unsuccessful
                        End If
                    End Using
                End If
            End Using
        Else
            Using rsDivRefhDao As New DivrefhDAO
                Dim rsDIV As New Divrefh
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)
                Dim param2 As New LUNA.LunaSearchParameter("YEAR", saveParameter.Year)
                Dim param3 As New LUNA.LunaSearchParameter("QUARTER", saveParameter.Quarter)

                rsDIV = rsDivRefhDao.Find(param1, param2, param3)

                If Not rsDIV Is Nothing Then                    
                    rsDIV.DIVIDEND = dividendAmount
                    rsDIV.REFUND = refundAmount
                    If rsDivRefhDao.Save(rsDIV) = 1 Then
                        result = RecordUpdateResult.UpdateSuccessful
                    Else
                        result = RecordUpdateResult.Unsuccessful
                    End If
                Else
                    Using rsMember As New MembersDAO

                        Dim param4 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)
                        Dim MemberRecord As Members = rsMember.Find(param4)
                        If Not MemberRecord Is Nothing Then
                            With MemberRecord
                                rsDIV.DIVIDEND = dividendAmount
                                rsDIV.FEBTC_SA = .FEBTC_SA
                                rsDIV.FNAME = .FNAME
                                rsDIV.KBCI_NO = .KBCI_NO
                                rsDIV.LNAME = .LNAME
                                rsDIV.MI = .MI
                                rsDIV.REFUND = refundAmount
                            End With
                            If rsDivRefhDao.Save(rsDIV) > 0 Then
                                result = RecordUpdateResult.AddSuccessful
                            Else
                                result = RecordUpdateResult.Unsuccessful
                            End If
                        Else
                            result = RecordUpdateResult.Unsuccessful
                        End If
                    End Using
                End If
            End Using
        End If
        Return result
    End Function
    Public Function GetDivRefByKbciNo(ByVal saveParameter As DivrefSaveParameters, ByVal ViewOption As ViewOptions) As DivRefSettingsViewModel Implements IDividendPatronageRefundSettingService.GetDivRefByKbciNo

        If ViewOption = ViewOptions.Current Then
            Using rsDivRefDao As New DivrefDAO
                Dim rsDIV As New Divref
                Dim result As New DivRefSettingsViewModel
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)

                rsDIV = rsDivRefDao.Find(param1)
                With rsDIV
                    result.DIVIDEND = .DIVIDEND
                    result.FEBTC_SA = .FEBTC_SA
                    result.FNAME = .FNAME
                    result.KBCI_NO = .KBCI_NO
                    result.LNAME = .LNAME
                    result.MI = .MI
                    result.REFUND = .REFUND
                End With
                Return result
            End Using

        Else
            Using rsDivRefhDao As New DivrefhDAO
                Dim rsDIV As New Divrefh
                Dim result As New DivRefSettingsViewModel
                Dim param1 As New LUNA.LunaSearchParameter("KBCI_NO", saveParameter.KbciNo)
                Dim param2 As New LUNA.LunaSearchParameter("YEAR", saveParameter.Year)
                Dim param3 As New LUNA.LunaSearchParameter("QUARTER", saveParameter.Quarter)

                rsDIV = rsDivRefhDao.Find(param1, param2, param3)
                With rsDIV
                    result.DIVIDEND = .DIVIDEND
                    result.FEBTC_SA = .FEBTC_SA
                    result.FNAME = .FNAME
                    result.KBCI_NO = .KBCI_NO
                    result.LNAME = .LNAME
                    result.MI = .MI
                    result.REFUND = .REFUND
                End With
                Return result
            End Using

        End If
    End Function

End Class



