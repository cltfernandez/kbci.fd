Imports FD.Common
Imports FD.Common.Utilities
Imports System.Collections.Generic
Imports FD.DataAccessObject
Imports FD.BusinessLogic
Imports FD.ViewModels
Public Class frmDividendPatronageSettings

    Inherits System.Windows.Forms.Form
    Public Sub New(ByVal _CurrentUser As UserViewModel, _
                   ByVal _IDivPatRefSettingsService As IDividendPatronageRefundSettingService, _
                   ByVal MsgSvc As IDividendPatronageMessagePromptService)
        CurrentUser = _CurrentUser
        IDivPatRefSettingsService = _IDivPatRefSettingsService
        _IMessageService = MsgSvc
        _IRecordMsgService = MsgSvc
        InitializeComponent()
    End Sub
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDividendPatronageSettings))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton4, Me.ToolBarButton9, Me.ToolBarButton3, Me.ToolBarButton8, Me.ToolBarButton5})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(530, 44)
        Me.ToolBar1.TabIndex = 6
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "&Add New"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 0
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "&Edit"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 0
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "&Delete"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "&Find"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 0
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "E&xit"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(400, 88)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 21)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(400, 64)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 21)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Patronage Refund :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dividend :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(80, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(424, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label10"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(376, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Label10"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Savings Acct. No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "KBCI No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox3.Location = New System.Drawing.Point(80, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 16)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(72, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 32)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "CASH DIV. / PAT. REFUND MAINTENANCE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 50)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'frmDividendPatronageSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(530, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDividendPatronageSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _CurrentUser As UserViewModel
    Public Property CurrentUser() As UserViewModel
        Get
            Return _CurrentUser
        End Get
        Set(ByVal value As UserViewModel)
            _CurrentUser = value
        End Set
    End Property

    Private _IDivPatRefSettingsService As IDividendPatronageRefundSettingService
    Public Property IDivPatRefSettingsService() As IDividendPatronageRefundSettingService
        Get
            Return _IDivPatRefSettingsService
        End Get
        Set(ByVal value As IDividendPatronageRefundSettingService)
            _IDivPatRefSettingsService = value
        End Set
    End Property
    Private _IMessageService As IDividendPatronageMessagePromptService
    Private Property IMessageService() As IDividendPatronageMessagePromptService
        Get
            Return _IMessageService
        End Get
        Set(ByVal value As IDividendPatronageMessagePromptService)
            _IMessageService = value
        End Set
    End Property
    Private _IRecordMsgService As IRecordUpdateMessagePromptService
    Private Property IRecordMsgService() As IRecordUpdateMessagePromptService
        Get
            Return _IRecordMsgService
        End Get
        Set(ByVal value As IRecordUpdateMessagePromptService)
            _IRecordMsgService = value
        End Set
    End Property


    Private _SelectedDivRefRecord As DivRefSettingsViewModel
    Public Property SelectedDivRefRecord() As DivRefSettingsViewModel
        Get
            Return _SelectedDivRefRecord
        End Get
        Set(ByVal value As DivRefSettingsViewModel)
            _SelectedDivRefRecord = value
        End Set
    End Property

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim IDX As Integer = Val(ToolBar1.Buttons.IndexOf(e.Button).ToString)
        Dim DividendAmount As Decimal = Round(CDbl(TextBox5.Text), 2)
        Dim RefundAmount As Decimal = Round(CDbl(TextBox1.Text), 2)
        Dim SaveParameter As New DivrefSaveParameters With {.KbciNo = SelectedDivRefRecord.KBCI_NO, .Quarter = SELQTR, .Year = SELYR}
        With ToolBar1
            Select Case IDX
                Case DivRefToolbarButtons.Add
                    If e.Button.Text = GetGlobalResourceString("AddButton") Then
                        Dim MemberSearchForm As New frmMemberSearchDialog
                        MemberSearchForm.ShowDialog()
                        If SW = True Then
                            TextBox3.Text = SelectedMemberData.KBCI_NO
                            Label4.Text = SelectedMemberData.FEBTC_CA
                            Label5.Text = SelectedMemberData.LNAME
                            EDTool(ToolBar1, False)
                            .Buttons(IDX).Enabled = True
                            GroupBox1.Enabled = True
                            e.Button.Text = GetGlobalResourceString("SaveButton")
                            .Buttons(DivRefToolbarButtons.Exit).Text = GetGlobalResourceString("CancelButton")
                        End If
                    Else
                        If Not SelectedMemberData Is Nothing Then
                            Dim result As RecordUpdateResult = IDivPatRefSettingsService.Save(SaveParameter, DividendAmount, RefundAmount, ViewOption)
                            IRecordMsgService.GetMessageFromRecordUpdateResult(result)
                            If Not result = RecordUpdateResult.Unsuccessful Then
                                .Buttons(DivRefToolbarButtons.Exit).Text = GetGlobalResourceString("ExitButton")
                                e.Button.Text = GetGlobalResourceString("AddButton")
                                EDTool(ToolBar1, True)
                                GroupBox1.Enabled = False
                            End If
                        End If
                    End If
                Case DivRefToolbarButtons.Edit
                    If .Buttons(IDX).Text = GetGlobalResourceString("EditButton") Then
                        EDTool(ToolBar1, False)
                        .Buttons(IDX).Enabled = True
                        e.Button.Text = GetGlobalResourceString("SaveButton")
                        .Buttons(DivRefToolbarButtons.Exit).Text = GetGlobalResourceString("CancelButton")
                        GroupBox1.Enabled = True
                        TextBox5.Focus()
                    Else
                        Dim result As RecordUpdateResult = IDivPatRefSettingsService.Save(SaveParameter, DividendAmount, RefundAmount, ViewOption)
                        IRecordMsgService.GetMessageFromRecordUpdateResult(result)
                        e.Button.Text = GetGlobalResourceString("EditButton")
                        .Buttons(DivRefToolbarButtons.Exit).Text = GetGlobalResourceString("ExitButton")
                        GroupBox1.Enabled = False
                        EDTool(ToolBar1, True)                        
                    End If

                Case DivRefToolbarButtons.Delete

                Case DivRefToolbarButtons.Search
                    Dim MemberSearchForm As New frmMemberSearchDialog
                    MemberSearchForm.ShowDialog()
                    If SW = True Then
                        SelectedDivRefRecord = IDivPatRefSettingsService.GetDivRefByKbciNo(SaveParameter, ViewOption)
                        PopulateFields(SelectedDivRefRecord)
                    End If
                Case DivRefToolbarButtons.Exit
                    If e.Button.Text = GetGlobalResourceString("CancelButton") Then
                        EDTool(ToolBar1, True)
                        GroupBox1.Enabled = False
                        .Buttons(DivRefToolbarButtons.Add).Text = GetGlobalResourceString("AddButton")
                        .Buttons(DivRefToolbarButtons.Edit).Text = GetGlobalResourceString("EditButton")
                        e.Button.Text = GetGlobalResourceString("ExitButton")
                    Else
                        ClsForm(Me, rsDIVPATMain)
                    End If
                Case Else
            End Select
        End With
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox(GetGlobalResourceString("PleaseInputNumeric"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance")) : TextBox5.Text = "0.00"
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If IsNumeric(TextBox1.Text) Then TextBox1.Text = FormatNumber(TextBox1.Text, 2) Else MsgBox(GetGlobalResourceString("PleaseInputNumeric"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance")) : TextBox1.Text = "0.00"
    End Sub

    Private Sub frmFDS_Main_DIVPATMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = GetGlobalResourceString("DividendPatronageMaintenance")

        Dim result As DivRefSettingsValidationResult = IDivPatRefSettingsService.ValidateSettings(SELYR, SELQTR)


        If Not result = DivRefSettingsValidationResult.Valid Then
            IMessageService.GetMessageFromDivRefSettingsValidation(result, SELYR, SELQTR)
            Me.Dispose()
            Exit Sub
        End If

        Dim DivRefPostingList As List(Of DivRefSettingsViewModel) = IDivPatRefSettingsService.GetDividendPatronageRefundPosting(ViewOption, SELYR, SELQTR)

        If DivRefPostingList.Count > 0 Then
            SelectedDivRefRecord = DivRefPostingList.FirstOrDefault
            PopulateFields(SelectedDivRefRecord)
        Else
            MsgBox(GetGlobalResourceString("NoTransactionFound"), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageMaintenance"))
            Me.Dispose()
        End If

    End Sub

    Private Sub PopulateFields(ByVal DivRefRecord As DivRefSettingsViewModel)

        TextBox3.Text = DivRefRecord.KBCI_NO
        Label4.Text = DivRefRecord.FEBTC_SA
        Label5.Text = String.Format("{0}, {1} {2}", DivRefRecord.LNAME, DivRefRecord.FNAME, DivRefRecord.MI)
        TextBox5.Text = FormatNumber(DivRefRecord.DIVIDEND, 2)
        TextBox1.Text = FormatNumber(DivRefRecord.REFUND, 2)
    End Sub
    Private Sub EDTool(ByRef TB As ToolBar, ByVal SW As Boolean)
        Dim x As Integer
        For x = 0 To TB.Buttons.Count - 2
            TB.Buttons(x).Enabled = SW
        Next
    End Sub

End Class
