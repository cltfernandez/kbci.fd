Imports FD.Common
Imports FD.Common.Utilities
Imports FD.BusinessLogic
Imports FD.ViewModels
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Collections.Generic

Public Class frmFixedDepositMain
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()
        MainPasswordValidator = New UserService
        MainUserActionService = New UserService
        MainMessagePromptService = New MessagePromptService
        dividendPatronageRefundSettingsSvc = New DividendPatronageRefundSettingService
        InitializeComponent()
    End Sub
#Region " Windows Form Designer generated code "



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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFixedDepositMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem1, Me.MenuItem9, Me.MenuItem14, Me.MenuItem37, Me.MenuItem39})
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28})
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem24.Text = "&File"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftL
        Me.MenuItem25.Text = "Lock"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem26.Text = "Logoff"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.Text = "E&xit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6, Me.MenuItem7, Me.MenuItem5, Me.MenuItem8})
        Me.MenuItem1.Text = "Fixed &Deposit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem2.Text = "Data &Entry"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem4.Text = "Print FD &Ledger"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MenuItem6.Text = "Print &Daily Transaction Register"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.MenuItem7.Text = "Print FD &Runup"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlI
        Me.MenuItem8.Text = "Passbook &Initialization"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem13})
        Me.MenuItem9.Text = "&Members"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem10.Text = "&New Member"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.MenuItem12.Text = "Print Members &Listing"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.MenuItem13.Text = "List of &Resigned Mem/Inv"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem15, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem14.Text = "DIV/&REF"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem16.Text = "Cash Div/Pat Refund Maintenance"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem15.Text = "Cash Div/Pat Refund"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem17.Text = "Process Dividend Voucher"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.MenuItem19.Text = "Print Cash Div Register"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32})
        Me.MenuItem20.Text = "Print Pat. Ref. Register"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Text = "Active Members"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Text = "Resigned Members"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 2
        Me.MenuItem31.Text = "KBCI Staff"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "All Members"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36})
        Me.MenuItem22.Text = "Print Div/Ref Register"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 0
        Me.MenuItem33.Text = "Active Members"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 1
        Me.MenuItem34.Text = "Resigned Members"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 2
        Me.MenuItem35.Text = "KBCI Staff"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 3
        Me.MenuItem36.Text = "All Members"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MenuItem23.Text = "Print Dividend Voucher"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 4
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38})
        Me.MenuItem37.Text = "Se&ttings"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 0
        Me.MenuItem38.Text = "Co&nnection"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel12, Me.ToolStripStatusLabel13, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel11, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 323)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip2.TabIndex = 10
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel10.Text = "USER:"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel5.ToolTipText = "Current User"
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.AutoSize = False
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(30, 17)
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel13.Text = "DB:"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.AutoSize = False
        Me.ToolStripStatusLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(561, 17)
        Me.ToolStripStatusLabel6.Spring = True
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel11.Text = "SYSTEM DATE:"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(4, 17)
        Me.ToolStripStatusLabel7.ToolTipText = "System Date"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(4, 17)
        Me.ToolStripStatusLabel8.ToolTipText = "System Time"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 5
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.MenuItem39.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Text = "About "
        '
        'frmFixedDepositMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(764, 345)
        Me.Controls.Add(Me.StatusStrip2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmFixedDepositMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KBCI - Fixed Deposit System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private FixedDepositTransactionMembersListForm As frmMembersList
    Public MembersMaintenanceForm As frmMembersMaintenance
    Public SystemConfigurationForm As frmAppConfiguration
    Public LoginForm As frmFixedDepositLogin
    Public ReportViewerForm As frmReportViewer
    Public frmFDS_Main_Arrange As frmSortOptionDialog
    Public frmDIVPAT As frmDividendPatronageRefundProcessing
    Public DividendPatronageSettingsForm As frmDividendPatronageSettings
    Public VoucherProcessingForm As frmVoucherProcessing
    Public MainPasswordValidator As IPasswordValidator
    Private MainUserActionService As IUserService
    Private MainMessagePromptService As ILoginMessagePromptService

    Private CashDividendSettingsService As ICashDividendSettingsService

    Private dividendPatronageRefundSettingsSvc As IDividendPatronageRefundSettingService
    Private LatestDivRefPostingDefinition As DivrefPostingViewModel
    Public CurrentUser As UserViewModel
    Private SystemCtrl As CtrlViewModel

    Private FormOperationService As IFormOperations
    Private MembersGridList As New List(Of MembersBOVM)






    Private Sub frmFDS_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoginPrompt()

        FormOperationService = New ApplicationSettingsService()
        rsCTL = FormOperationService.GetAll()

        If CurrentUser Is Nothing Then End : Exit Sub
        cn.ConnectionString = "Provider=SQLOLEDB.1;Password=" & Utilities.GetConfig("WP") & ";Persist Security Info=True;User ID=" & Utilities.GetConfig("CL") & ";Initial Catalog=" & Utilities.GetConfig("DB") & ";Data Source=" & Utilities.GetConfig("SV")
        cn.Open()
        DEFPRINTER = Utilities.GetConfig("PT")

        If Not rsCTL Is Nothing Then SYSDATE = rsCTL.SYSDATE Else MsgBox(GetGlobalResourceString("CtrlError"), MsgBoxStyle.Critical, GetGlobalResourceString("FixedDepositSystem")) : End
        fillStatbar()
    End Sub

    Private Sub frmFDS_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim msg As String
        msg = MsgBox(GetGlobalResourceString("ExitApplicationPrompt"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, GetGlobalResourceString("FixedDepositSystem"))
        If msg = vbNo Then
            e.Cancel = 1
        Else
            If cn.State = 1 Then cn.Close()
        End If
    End Sub

    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If IsFormLoaded("FixedDepositTransactionMembersListForm") Then Exit Sub
        FixedDepositTransactionMembersListForm = New frmMembersList(CurrentUser)
        With FixedDepositTransactionMembersListForm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If IsFormLoaded("MembersMaintenanceForm") Then Exit Sub
        MembersMaintenanceForm = New frmMembersMaintenance(CurrentUser)
        With MembersMaintenanceForm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        '#####PRINT FD LEDGER        
        Dim reportObject As New FixedDepositLedgerReport
        With reportObject.Section2
            Dim txtKBCI As TextObject = .ReportObjects("txtKBCINO")
            Dim txtFLNAME As TextObject = .ReportObjects("txtFLNAME")
            ReportViewerForm = New frmReportViewer
            ReportViewerForm.MdiParent = Me
            Using DateRangePicker As New frmDateRangePickerDialog
                Dim result As DialogResult = DateRangePicker.ShowDialog
                If result = Windows.Forms.DialogResult.OK Then
                    Using MemberSearchForm As New frmMemberSearchDialog
                        If MemberSearchForm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            txtKBCI.Text = FormatKBCINo(SEL_KBCI_NO)
                            txtFLNAME.Text = SEL_FNAME
                            ReportViewerForm.ReportService = New FixedDepositLedgerReportService(MemberSearchForm.SelectedMember.KBCI_NO, _
                                                                                                 DateRangePicker.StartDate, _
                                                                                                 DateRangePicker.EndDate)
                            ReportViewerForm.ReportModel = reportObject
                            ReportViewerForm.HeaderText = String.Format("{0}: {1}", GetGlobalResourceString("FixedDepositLedger"), SEL_FNAME)
                            ReportViewerForm.Show()
                            SW = False
                        End If
                    End Using
                End If
            End Using
        End With
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        '#####INIT PASSBOOK
        Using MemberSearchForm As New frmMemberSearchDialog
            Dim prtstr As String
            If MemberSearchForm.ShowDialog() = DialogResult.OK Then
                If rsPASSBOOK.State = 1 Then rsPASSBOOK.Close()
                rsPASSBOOK.Open("SELECT LNAME + ', ' + FNAME + ' ' + MI + '.' NAME,ISNULL(DEPT,'') DEPT,ISNULL(OFF_TEL,'') OFF_TEL,ISNULL(MEM_ADDR,'') MEM_ADDR,ISNULL(RES_TEL,'') RES_TEL FROM MEMBERS WHERE KBCI_NO ='" & SEL_KBCI_NO & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                If rsPASSBOOK.RecordCount > 0 Then
                    With rsPASSBOOK
                        prtstr = vbCrLf & " " & vbCrLf & " " & vbCrLf & _
                                 "                         " & Mid(SEL_KBCI_NO, 1, 2) & "-" & Mid(SEL_KBCI_NO, 3, 4) & "-" & Mid(SEL_KBCI_NO, 7, 1) & _
                                 vbCrLf & " " & vbCrLf & _
                                 "          " & .Fields("NAME").Value & _
                                 vbCrLf & _
                                 "               " & .Fields("DEPT").Value.ToString.PadRight(26, " ") & .Fields("OFF_TEL").Value & _
                                 vbCrLf & " " & vbCrLf & _
                                 "               " & Mid(.Fields("MEM_ADDR").Value, 1, 30) & _
                                 vbCrLf & " " & vbCrLf & _
                                 "               " & .Fields("RES_TEL").Value
                    End With
                    MsgBox("Please Insert Passbook for Initialization then Press OK", MsgBoxStyle.Exclamation, "Passbook Initialization")
                    Dim prtobj As New TextPrint(prtstr, DEFPRINTER)
                    prtobj.Font = New Font("Letter Gothic", 10, FontStyle.Regular, GraphicsUnit.Point)
                    ' Issue print command
                    prtobj.Print()
                    prtobj.Dispose()
                Else

                End If
            End If

        End Using
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        '#####PRINT DAILY TRANSACTION

        Dim reportObject As New DailyTransactionRegisterReport
        With reportObject.Section2
            Dim DDATE As TextObject = .ReportObjects("Text9")
            ReportViewerForm = New frmReportViewer
            ReportViewerForm.MdiParent = Me
            Using DatePicker As New frmDateRangePickerDialog
                DatePicker.DatePickerType = DatePickerType.SingleDate

                Dim result As DialogResult = DatePicker.ShowDialog
                If result = Windows.Forms.DialogResult.OK Then
                    DDATE.Text = DatePicker.StartDate.ToString("MMM dd, yyyy")
                    ReportViewerForm.ReportService = New DailyTransactionRegisterReportService(DatePicker.StartDate)
                    ReportViewerForm.ReportModel = reportObject
                    ReportViewerForm.HeaderText = String.Format("{0} For {1}", GetGlobalResourceString("TransactionDetails"), DatePicker.StartDate.ToString("MMM dd, yyyy"))
                    ReportViewerForm.Show()
                    SW = False
                End If
            End Using
        End With
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        '#####LIST OF CURRENT MEM/INV
        Dim reportObject As New ActiveMembersReport
        With reportObject.Section2
            Dim ASOFDATE As TextObject = .ReportObjects("Text36")
            ASOFDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            ReportViewerForm = New frmReportViewer
            With ReportViewerForm
                .MdiParent = Me
                .ReportService = New ActiveMembersReportService(DateValue(SYSDATE))
                .ReportModel = reportObject
                .HeaderText = String.Format(GetGlobalResourceString("CurrentMembersHeader"), DateValue(SYSDATE).ToString("MMM dd, yyyy"))
                .Show()
            End With
        End With
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Me.Close()
        End
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        '#####LIST OF RESIGNED INV/MEM
        Dim reportObject As New ResignedMembersReport
        ReportViewerForm = New frmReportViewer
        Using DatePicker As New frmDateRangePickerDialog
            Dim result As DialogResult = DatePicker.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                With ReportViewerForm
                    Dim RDATE As TextObject = reportObject.Section2.ReportObjects("Text13")
                    RDATE.Text = DatePicker.StartDate & " TO " & DatePicker.EndDate
                    .MdiParent = Me
                    .ReportService = New ResignedMembersReportService(DatePicker.StartDate, DatePicker.EndDate)
                    .ReportModel = reportObject
                    .HeaderText = String.Format(GetGlobalResourceString("ResignedMembersHeader"), DatePicker.StartDate.ToString("MM/dd/yyyy"), DatePicker.EndDate.ToString("MM/dd/yyyy"))
                    .Show()
                End With
            End If
        End Using
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        '#### FDRUNUP
        Dim reportObject As New FixedDepositRunupReport
        ReportViewerForm = New frmReportViewer
        ReportViewerForm.MdiParent = Me
        With reportObject.Section2
            Dim txtDATE As TextObject = .ReportObjects("txtDATE")

            Dim msg As DialogResult = _
                MsgBox(String.Format(GetGlobalResourceString("FixedDepositRunupPrompt"), DateValue(rsCTL.RunDate).ToString("MM/dd/yyyy")), MsgBoxStyle.Information + MsgBoxStyle.YesNo, GetGlobalResourceString("FixedDepositRunup"))

            If msg = vbYes Then
                Using DatePicker As New frmDateRangePickerDialog
                    DatePicker.DatePickerType = DatePickerType.SingleDate
                    Dim result As DialogResult = DatePicker.ShowDialog
                    If result = Windows.Forms.DialogResult.OK Then
                        txtDATE.Text = Format(DatePicker.StartDate, "MMM dd, yyyy")
                        ReportViewerForm.ReportService = New FixedDepositRunupReportService(DatePicker.StartDate)
                        ReportViewerForm.ReportModel = reportObject
                        ReportViewerForm.HeaderText = GetGlobalResourceString("FixedDepositRunup")
                        ReportViewerForm.Show()
                        SW = False
                    End If
                End Using
            End If
        End With
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        frmDIVPAT = New frmDividendPatronageRefundProcessing(New DividendPatronageRefundService, MainMessagePromptService, CurrentUser, rsCTL.SystemDate)
        frmDIVPAT.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusStrip2.Items(8).Text = TimeOfDay
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim postingYr As Integer
        Dim postingQtr As Integer

        Using ProcessingViewOptionDialogForm As New frmProcessingViewOptionDialog(New DividendPatronageRefundService)
            Dim result As DialogResult = ProcessingViewOptionDialogForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                postingYr = ProcessingViewOptionDialogForm.SelectedYear
                postingQtr = ProcessingViewOptionDialogForm.SelectedQuarter

                VoucherProcessingForm = New frmVoucherProcessing(CurrentUser, dividendPatronageRefundSettingsSvc, New MessagePromptService)
                VoucherProcessingForm.ShowDialog()
                If SW = True Then
                    PRTVOUCHER(postingYr, postingQtr)
                End If
            End If
            SW = False
        End Using
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Using ArrangeForm As New frmSortOptionDialog
            ReportViewerForm = New frmReportViewer
            ReportViewerForm.MdiParent = Me
            Dim result As DialogResult = ArrangeForm.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                CashDividendSettingsService = New CashDividendSettingsService
                Dim cashDivSettingsModel As CashDividendPolicySettingsViewModel = CashDividendSettingsService.Read

                If ArrangeForm.SelectedField.Equals(SortOptions.Region) Then
                    Dim reportObject As New CashDividendRegisterPerRegionReport
                    With reportObject.Section6
                        Dim ASOFDATE As TextObject = .ReportObjects("Text11")
                        ASOFDATE.Text = cashDivSettingsModel.TransactionDate
                        ReportViewerForm.ReportModel = reportObject
                    End With
                Else
                    Dim reportObject As New CashDividendRegisterReport
                    With reportObject.Section2
                        Dim ASOFDATE2 As TextObject = .ReportObjects("Text11")
                        ASOFDATE2.Text = cashDivSettingsModel.TransactionDate
                        ReportViewerForm.ReportModel = reportObject
                    End With
                End If
                ReportViewerForm.ReportService = New CashDividendRegisterPerRegionReportService(ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                ReportViewerForm.HeaderText = GetGlobalResourceString("CashDividendRegister")
                ReportViewerForm.Show()
            End If
        End Using
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click

        Using ProcessingViewOptionDialogForm As New frmProcessingViewOptionDialog(New DividendPatronageRefundService)
            DividendPatronageSettingsForm = New frmDividendPatronageSettings(CurrentUser, New DividendPatronageRefundSettingService, MainMessagePromptService)
            ProcessingViewOptionDialogForm.ShowDialog()
            If SW = True Then
                DividendPatronageSettingsForm.ShowDialog()
            End If
            SW = False
        End Using
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        GeneratePatronageRefundReport(MemberStatusEnum.Active, GetGlobalResourceString("ActiveMembers"))

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        GeneratePatronageRefundReport(MemberStatusEnum.Resigned, GetGlobalResourceString("ResignedMembers"))

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        GeneratePatronageRefundReport(MemberStatusEnum.Staff, GetGlobalResourceString("KbciStaff"))
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        GeneratePatronageRefundReport(Nothing, GetGlobalResourceString("AllMembers"))

    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        GenerateDividendRefundReport(MemberStatusEnum.Active)
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        GenerateDividendRefundReport(MemberStatusEnum.Resigned)
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        GenerateDividendRefundReport(MemberStatusEnum.Staff)
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        GenerateDividendRefundReport(String.Empty)
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim postingYr As Integer
        Dim postingQtr As Integer

        Using ProcessingViewOptionDialogForm As New frmProcessingViewOptionDialog(New DividendPatronageRefundService)
            Dim result As DialogResult = ProcessingViewOptionDialogForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                postingYr = ProcessingViewOptionDialogForm.SelectedYear
                postingQtr = ProcessingViewOptionDialogForm.SelectedQuarter

                Dim validationResult As DivRefSettingsValidationResult = dividendPatronageRefundSettingsSvc.ValidateSettings(postingYr, postingQtr)

                If validationResult = DivRefSettingsValidationResult.NotFound Then
                    MsgBox(String.Format(GetGlobalResourceString("DivRefRecordNotFound"), postingYr, postingQtr), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageRefund"))
                    Exit Sub
                End If
                PRTVOUCHER(postingYr, postingQtr)
            End If
        End Using
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        LoginForm = New frmFixedDepositLogin(MainPasswordValidator, MainMessagePromptService)
        With LoginForm
            .TextBox6.Text = CurrentUser.UserName
            .Button3.Text = "Unlock"
            .Button2.Enabled = False
            .TextBox6.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim msg As String
        msg = MsgBox(GetGlobalResourceString("LogOffQuestion"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, String.Format("User Logged In: {0}", CurrentUser.UserName))
        If msg = vbYes Then
            StatusStrip2.Items(1).Text = String.Empty
            MainUserActionService.ChangeUserLoginStatus(CurrentUser, False)
            LoginPrompt()
            fillStatbar()
        End If
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New Crypt
        ' Create object, passing in text
        Dim prtobj As New TextPrint(vbCrLf & vbTab & " TEST 1" & vbCrLf & vbTab & " TEST 2", "HP LaserJet 1022n")
        prtobj.Font = New Font("Lucida Console", 6)
    End Sub

    Private Sub MenuItem37_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prt As New TextPrint("TEST" & vbCrLf & "T ST", DEFPRINTER)
        prt.Print()
        prt.Dispose()
    End Sub

    Private Sub MenuItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        If IsFormLoaded("Form1") Then Exit Sub
        SystemConfigurationForm = New frmAppConfiguration
        SystemConfigurationForm.ShowDialog()
    End Sub


#Region "Private Methods"
    Private Sub PRTVOUCHER(ByVal Year As Integer, ByVal Quarter As Integer)
        Dim rsRPT As New ADODB.Recordset
        Dim reportObject As New DividendVoucherReport
        Dim processingHistoryModel As DivrefPostingViewModel

        ReportViewerForm = New frmReportViewer
        ReportViewerForm.MdiParent = Me

        Dim DivRefPostingHistory As IDividendPatronageRefundService = New DividendPatronageRefundService()
        processingHistoryModel = DivRefPostingHistory.GetDivrefPostingHistory(Year, Quarter)
        Dim CVNO As TextObject = reportObject.Section2.ReportObjects("Text4")
        Dim USR As TextObject = reportObject.Section4.ReportObjects("Text10")
        USR.Text = String.Format("Prepared by : {0}", CurrentUser.UserName)
        CVNO.Text = processingHistoryModel.CVNO
        ReportViewerForm.ReportService = New DividendVoucherReportService(Year, Quarter)
        ReportViewerForm.ReportModel = reportObject
        ReportViewerForm.Show()
    End Sub

    Private Sub GeneratePatronageRefundReport(ByVal memberStatus As String, ByVal reportTitle As String)
        Using SummaryViewOptionForm As New frmSummaryViewOptionDialog
            Dim result As DialogResult = SummaryViewOptionForm.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                If SummaryViewOptionForm.IsSummarized = True Then
                    GeneratePatronageRefundSummaryReport(memberStatus, reportTitle)
                Else
                    GeneratePatronageRefundDetailedReport(memberStatus, reportTitle)
                End If
            End If
        End Using
    End Sub

    Private Sub GeneratePatronageRefundDetailedReport(ByVal memberStatus As String, ByVal reportTitle As String)
        If LatestDivRefPostingDefinition Is Nothing Then
            Dim DivRefPostingHistory As IDividendPatronageRefundService = New DividendPatronageRefundService()
            LatestDivRefPostingDefinition = DivRefPostingHistory.GetLatestDivrefPostingHistory()
        End If

        Dim ReportObject As New PatronageRefundDetailedReport
        ReportViewerForm = New frmReportViewer
        ReportViewerForm.MdiParent = Me

        With ReportObject.Section2
            Dim CAT As TextObject = .ReportObjects("Text19")
            Dim DDATE As TextObject = .ReportObjects("Text20")
            Dim PTL As TextObject = .ReportObjects("Text11")
            Dim YYEAR As TextObject = .ReportObjects("Text25")
            CAT.Text = reportTitle
            DDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            YYEAR.Text = LatestDivRefPostingDefinition.YEAR
            If memberStatus.ToString <> MemberStatusEnum.Staff Then PTL.Text = "-"
            ReportViewerForm.ReportService = New PatronageRefundDetailedReportService(memberStatus)
            ReportViewerForm.ReportModel = ReportObject
            ReportViewerForm.HeaderText = "[DETAILED] PATRONAGE REFUND REGISTER"
            ReportViewerForm.Show()
        End With
    End Sub

    Private Sub GeneratePatronageRefundSummaryReport(ByVal memberStatus As String, ByVal reportTitle As String)
        If LatestDivRefPostingDefinition Is Nothing Then
            Dim DivRefPostingHistory As IDividendPatronageRefundService = New DividendPatronageRefundService()
            LatestDivRefPostingDefinition = DivRefPostingHistory.GetLatestDivrefPostingHistory()
        End If
        Dim reportObject As New PatronageRefundSummaryReport
        ReportViewerForm = New frmReportViewer
        ReportViewerForm.MdiParent = Me

        With reportObject.Section2
            Dim CAT As TextObject = .ReportObjects("Text19")
            Dim DDATE As TextObject = .ReportObjects("Text5")
            Dim YYEAR As TextObject = .ReportObjects("Text6")
            CAT.Text = reportTitle
            DDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            YYEAR.Text = LatestDivRefPostingDefinition.YEAR
            ReportViewerForm.ReportService = New PatronageRefundSummaryReportService(memberStatus)
            ReportViewerForm.ReportModel = reportObject
            ReportViewerForm.HeaderText = GetGlobalResourceString("SummarizedPatronageRefundReport")
            ReportViewerForm.Show()
        End With


    End Sub

    Private Sub GenerateDividendRefundReport(ByVal memberStatus As String)
        Dim reportObject As New DividendRefundReport
        Dim divrefph As New ADODB.Recordset
        ReportViewerForm = New frmReportViewer
        ReportViewerForm.MdiParent = Me

        Using ProcessingViewOptionDialogForm As New frmProcessingViewOptionDialog(New DividendPatronageRefundService)
            Using ArrangeForm As New frmSortOptionDialog
                Dim result As DialogResult = ArrangeForm.ShowDialog()
                If result = Windows.Forms.DialogResult.OK Then
                    If ProcessingViewOptionDialogForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        With reportObject.Section2
                            Dim CAT As TextObject = .ReportObjects("Text9")
                            Dim REG As TextObject = .ReportObjects("Text11")

                            CAT.Text = String.Format("FOR QUARTER: {0}     YEAR: {1}", ProcessingViewOptionDialogForm.SelectedQuarter, ProcessingViewOptionDialogForm.SelectedYear)
                            REG.Text = String.Empty
                            If ArrangeForm.SelectedField.Equals(SortOptions.Region) Then
                                REG.Text = String.Format("REGION : {0}", ArrangeForm.SelectedRegion)
                            End If
                        End With
                        ReportViewerForm.ReportModel = reportObject
                        ReportViewerForm.ReportService = New DivdendRefundReportService(ProcessingViewOptionDialogForm.SelectedViewOption, memberStatus, ArrangeForm.SelectedField, ArrangeForm.SelectedRegion, ProcessingViewOptionDialogForm.SelectedYear, ProcessingViewOptionDialogForm.SelectedQuarter)
                        ReportViewerForm.Text = "CASH DIV. / PAT REFUND. REGISTER"
                        ReportViewerForm.Show()
                    End If
                End If
            End Using
            SW = False
        End Using
    End Sub

    Private Sub fillStatbar()
        With StatusStrip2
            .Items(1).Text = CurrentUser.FullName
            .Items(4).Text = Utilities.GetConfig("DB").ToUpper()
            .Items(7).Text = SYSDATE
            .Items(8).Text = TimeOfDay
        End With

    End Sub

    Private Sub LoginPrompt()
        Using LoginForm As New frmFixedDepositLogin(MainPasswordValidator, MainMessagePromptService)
            Dim result As System.Windows.Forms.DialogResult = LoginForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                CurrentUser = LoginForm.CurrentUser
            End If
        End Using
    End Sub
#End Region

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Using aboutDialog As New frmAboutDialog
            aboutDialog.ShowDialog()
        End Using
    End Sub
End Class
