Imports System.Data.SqlClient
Imports FD.Common
Imports FD.Common.Utilities
Imports FD.DataAccessObject
Imports FD.BusinessLogic
Imports FD.ViewModels

Public Class frmFixedDepositMain
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()


        MainPasswordValidator = New UserService
        MainUserActionService = New UserService
        MainMessagePromptService = New MessagePromptService

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
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem1, Me.MenuItem9, Me.MenuItem14, Me.MenuItem37})
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
    Public frmFDS_Main_PrntFDL_Srch As frmFDS_Main_PrntFDL_Srch
    Public frmFDS_Main_DEntry As frmMembersList
    Public MembersMaintenanceForm As frmMembersMaintenance
    Public SystemConfigurationForm As frmAppConfiguration    
    Public LoginForm As frmFixedDepositLogin
    Public frmFD_Member As frmReportViewer
    Public frmFDS_Main_Arrange As frmSortOptionDialog
    Public frmDIVPAT As frmDividendPatronageRefundProcessing
    Public DividendPatronageSettingsForm As frmDividendPatronageSettings    
    Public frmFDS_Main_DIVREFOpt As frmFDS_Main_DIVREFOpt
    Public frmFDS_DVoucher As frmVoucherProcessing

    Private _MainPasswordValidator As IPasswordValidator
    Private Property MainPasswordValidator() As IPasswordValidator
        Get
            Return _MainPasswordValidator
        End Get
        Set(ByVal value As IPasswordValidator)
            _MainPasswordValidator = value
        End Set
    End Property

    Private _MainUserActionService As IUserService
    Private Property MainUserActionService() As IUserService
        Get
            Return _MainUserActionService
        End Get
        Set(ByVal value As IUserService)
            _MainUserActionService = value
        End Set
    End Property

    Private _MainMessagePromptService As ILoginMessagePromptService
    Private Property MainMessagePromptService() As ILoginMessagePromptService
        Get
            Return _MainMessagePromptService
        End Get
        Set(ByVal value As ILoginMessagePromptService)
            _MainMessagePromptService = value
        End Set
    End Property

    Private _CurrentUser As UserViewModel
    Public Property CurrentUser() As UserViewModel
        Get
            Return _CurrentUser
        End Get
        Set(ByVal value As UserViewModel)
            _CurrentUser = value
        End Set
    End Property


    Private _SystemCtrl As CtrlViewModel
    Private Property SystemCtrl() As CtrlViewModel
        Get
            Return _SystemCtrl
        End Get
        Set(ByVal value As CtrlViewModel)
            _SystemCtrl = value
        End Set
    End Property




    Private Sub frmFDS_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using rsCtrlDAO As New CtrlDAO
            Dim param As New LUNA.LunaSearchParameter("CTRL_ID", "1")
            rsCTL = rsCtrlDAO.Find(param)
        End Using

        Using rsTrancodeDAO As New TrancodeDAO
            LoginPrompt()
            If CurrentUser Is Nothing Then End : Exit Sub
            cn.ConnectionString = "Provider=SQLOLEDB.1;Password=" & Utilities.GetConfig("WP") & ";Persist Security Info=True;User ID=" & Utilities.GetConfig("CL") & ";Initial Catalog=" & Utilities.GetConfig("DB") & ";Data Source=" & Utilities.GetConfig("SV")
            cn.Open()
            rCN = "Password=" & Utilities.GetConfig("WP") & ";User ID=" & Utilities.GetConfig("CL") & ";Initial Catalog=" & Utilities.GetConfig("DB") & ";Data Source=" & Utilities.GetConfig("SV")
            DEFPRINTER = Utilities.GetConfig("PT")

            If Not rsCTL Is Nothing Then SYSDATE = rsCTL.SYSDATE Else MsgBox("CTRL Configuration Not found! Please Contact your system administrator.", MsgBoxStyle.Critical, "Critical Error") : End

            rsTRANCODE = rsTrancodeDAO.GetAll

            If Not rsTRANCODE.Any Then MsgBox("TRANCODE Not found! Please Contact your system administrator.", MsgBoxStyle.Critical, "Critical Error") : End
            fillStatbar()
        End Using
    End Sub

    Private Sub frmFDS_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim msg As String
        msg = MsgBox("Would you like to terminate the application?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "EXIT FD System")
        If msg = vbNo Then
            e.Cancel = 1
        Else
            If cn.State = 1 Then cn.Close()
        End If
    End Sub

    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If IsFormLoaded("frmFDS_Main_DEntry") Then Exit Sub
        PopulateMembersList()
        If Not rsMEMBERS Is Nothing Then
            frmFDS_Main_DEntry = New frmMembersList(CurrentUser)
            frmFDS_Main_DEntry.MdiParent = Me
            frmFDS_Main_DEntry.Show()
        Else
            MsgBox("No Records Found")
        End If
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
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptFD_Member
        Dim ds As New DataSet
        Dim txtKBCI As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txtKBCINO")
        Dim txtFLNAME As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txtFLNAME")

        frmFD_Member = New frmReportViewer






        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member.MdiParent = Me
        Dim sQRY As String
        Using DateRangePicker As New frmDateRangePickerDialog
            Dim result As DialogResult = DateRangePicker.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                frmFDS_Main_PrntFDL_Srch.ShowDialog()
                If SW = True Then
                    sQRY = "SELECT FD.DATE,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT,FD.BALANCE,FD.REF,FD.RMK AS REMARKS, FD.DRCR FROM FD INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID WHERE DATE BETWEEN '" & DateRangePicker.DateRange & "' and KBCI_NO = '" & SEL_KBCI_NO & "' ORDER BY FD.[DATE], FD.FD_ID"
                    rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                    txtKBCI.Text = Mid(SEL_KBCI_NO, 1, 2) & "-" & Mid(SEL_KBCI_NO, 3, 4) & "-" & Mid(SEL_KBCI_NO, 7, 1)
                    txtFLNAME.Text = SEL_FNAME
                    If rsRPT.RecordCount > 0 Then
                        GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "1:3:2:2:2:3:3")
                        frmFD_Member.Text = "[" & SEL_FNAME & "] : FD LEDGER"
                        frmFD_Member.Show()
                    Else
                        MsgBox("No transactions found between the specified dates.", MsgBoxStyle.Information, "Fixed Deposit Ledger")
                    End If
                    SW = False
                End If
            End If
        End Using
        If rsRPT.State = 1 Then rsRPT.Close()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        '#####INIT PASSBOOK
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFDS_Main_PrntFDL_Srch.ShowDialog()
        Dim prtstr As String
        If SW = True Then
            If rsPASSBOOK.State = 1 Then rsPASSBOOK.Close()
            rsPASSBOOK.Open("SELECT LNAME + ', ' + FNAME + ' ' + MI + '.' NAME,ISNULL(DEPT,'') DEPT,ISNULL(OFF_TEL,'') OFF_TEL,ISNULL(MEM_ADDR,'') MEM_ADDR,ISNULL(RES_TEL,'') RES_TEL FROM MEMBERS WHERE KBCI_NO ='" & SEL_KBCI_NO & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If rsPASSBOOK.RecordCount > 0 Then
                With rsPASSBOOK
                    'prtstr = vbCrLf & " TEST 1" & "<ST=10000>" & vbCrLf & "TEST 2"
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
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        '#####PRINT DAILY TRANSACTION
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptDTran_Reg
        Dim ds As New DataSet
        Dim sQRY As String

        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me
        Using DatePicker As New frmDateRangePickerDialog

            DatePicker.DateTimePicker2.Visible = False
            DatePicker.Label2.Visible = False
            Dim result As DialogResult = DatePicker.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                sQRY = "SELECT MM.KBCI_NO,MM.LNAME + ', ' + MM.FNAME + ' ' NAME,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT," & _
                       "FD.BALANCE,FD.REF,FD.RMK, FD.DRCR FROM FD INNER JOIN MEMBERS AS MM ON FD.KBCI_NO= MM.KBCI_NO INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID " & _
                       "WHERE DATE BETWEEN '" & DatePicker.DateRange & "' ORDER BY MM.LNAME,MM.FNAME"
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                If rsRPT.RecordCount > 0 Then
                    Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text9")
                    DDATE.Text = DatePicker.StartDate.ToString("MMM dd, yyyy")
                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:2:2:2:3:3")
                    frmFD_Member.Text = "[" & DatePicker.EndDate.ToString("MMM dd, yyyy") & "] TRANSACTION DETAILS"
                    frmFD_Member.Show()
                Else
                    MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
                End If
                SW = False

            End If
        End Using
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        '#####LIST OF CURRENT MEM/INV
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptMem_List
        Dim ds As New DataSet
        Dim ASOFDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text36")
        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me
        Dim sQRY As String
        sQRY = "SELECT [KBCI_NO],[LNAME]+ ', ' + [FNAME] + ' ' + [MI] + '.' AS NAME,[MEM_ADDR],[MEM_CODE],[MEM_STAT],[DORI],[REA_DORI]," & _
               "[FEBTC_SA],[CB_EMPNO],[CB_HIRE],[REGION],[DEPT],[POSITION],[OFF_TEL],[RES_TEL],[SAL_BAS],[SAL_ALL],[OTH_INC]," & _
               "[SEX],[CIV_STAT],[NO_DEPEND],[B_DATE],[SP_NAME],[SP_EMPLOY],[SP_CBEMPNO] AS SP_CBEMPN,[SP_OFFTEL],[SP_SALARY] AS SP_SAL FROM MEMBERS " & _
               "WHERE MEM_DATE <='" & DateValue(SYSDATE).ToString("MM/dd/yyyy") & "'"
        rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsRPT.RecordCount > 0 Then
            ASOFDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:3:3:4:3:3:3:1:3:3:3:3:3:2:2:2:3:3:3:1:3:3:3:3:2")
            frmFD_Member.Text = "CURRENT MEMBERS / INVESTORS AS OF " & DateValue(SYSDATE).ToString("MMM dd, yyyy")
            frmFD_Member.Show()
        Else
            MsgBox("No members found.", MsgBoxStyle.Information, "Member Listing")
        End If
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Me.Close()
        End
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        '#####LIST OF RESIGNED INV/MEM
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptRMem_List
        Dim ds As New DataSet
        Dim sQRY As String
        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me

        Using DatePicker As New frmDateRangePickerDialog
            Dim result As DialogResult = DatePicker.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                sQRY = "SELECT M.[KBCI_NO],M.[LNAME]+', '+M.[FNAME]+' '+COALESCE(M.[MI]+'.','') AS NAME,M.[MEM_STAT]," & _
                        "FDA.[DATE] CHG_DATE,FDA.AMOUNT FD_AMOUNT FROM MEMBERS M LEFT JOIN(SELECT*from FD WHERE FD_ID IN(" & _
                        "select MAX(FD_ID)from fd group by KBCI_NO))FDA ON M.KBCI_NO=FDA.KBCI_NO WHERE M.MEM_STAT=" & _
                        "'R'AND CHG_DATE BETWEEN'" & DatePicker.DateRange & "' ORDER BY M.KBCI_NO"
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                If rsRPT.RecordCount > 0 Then
                    Dim RDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text13")
                    RDATE.Text = DatePicker.StartDate & " TO " & DatePicker.EndDate

                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:1:2")
                    frmFD_Member.Text = "LIST OF RESIGNED MEMBERS / INVESTORS FROM " & DatePicker.StartDate & " TO " & DatePicker.EndDate
                    frmFD_Member.Show()
                Else
                    MsgBox("No resigned member(s) found between the specified date.", MsgBoxStyle.Information, "Resigned Member/Investor")
                End If
                SW = False
            End If
        End Using

        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        '#### FDRUNUP
        Dim rsRPT As New ADODB.Recordset
        Dim msg As String
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptFD_Runup
        Dim ds As New DataSet
        Dim sQRY As String

        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me
        Dim txtDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txtDATE")

        msg = MsgBox("Last FD Runup is " & DateValue(rsCTL.RUN_DATE).ToString("MM/dd/yyyy") & ". Would you like to continue?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Print FD Runup")
        If msg = vbYes Then
            Using DatePicker As New frmDateRangePickerDialog

                DatePicker.DateTimePicker2.Visible = False
                DatePicker.Label1.Text = "AS OF : "
                DatePicker.Label2.Visible = False

                Dim result As DialogResult = DatePicker.ShowDialog
                If result = Windows.Forms.DialogResult.OK Then
                    sQRY = "SELECT A.KBCI_NO,CASE WHEN A.MI IS NULL THEN A.LNAME+', '+A.FNAME ELSE A.LNAME+', '+A." & _
                           "FNAME+' '+ISNULL(A.MI,'')+'.'END NAME,B.BALANCE FROM MEMBERS A JOIN(SELECT X.KBCI_NO," & _
                           "isnull(SUM(X.CREDIT),0)-isnull(SUM(X.DEBIT),0)BALANCE FROM(select KBCI_NO,CASE WHEN " & _
                           "DRCR='DR'THEN AMOUNT END DEBIT,CASE WHEN DRCR='CR'THEN AMOUNT END CREDIT from FD WHERE" & _
                           "[DATE]<='" & DatePicker.StartDate & "')X GROUP BY KBCI_NO)B ON A.KBCI_NO=B.KBCI_NO WHERE B.BALANCE IS NOT " & _
                           "NULL AND B.BALANCE>1"
                    rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                    rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                    MsgBox("Successfully processed [" & rsRPT.RecordCount & "] records.", MsgBoxStyle.Information, "FD Runup report")
                    If rsRPT.RecordCount > 0 Then
                        GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2")
                        cn.Execute("UPDATE CTRL SET RUN_DATE='" & DatePicker.EndDate & "'")
                        rsCTL.Read(1)
                        frmFD_Member.Text = "FIXED DEPOSIT RUNUP"
                        txtDATE.Text = Format(DatePicker.StartDate, "MMM dd, yyyy")
                        frmFD_Member.Show()

                    Else
                        MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "FD Runup")
                    End If
                    SW = False
                End If
            End Using

            If rsRPT.State = 1 Then rsRPT.Close()
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        frmDIVPAT = New frmDividendPatronageRefundProcessing(New DividendPatronageRefundService, MainMessagePromptService, CurrentUser, rsCTL.SYSDATE)
        frmDIVPAT.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusStrip2.Items(8).Text = TimeOfDay
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_DVoucher = New frmVoucherProcessing(CurrentUser)
        frmFDS_Main_DIVREFOpt.ShowDialog()
        If SW = True Then
            frmFDS_DVoucher.ShowDialog()
            If SW = True Then
                PRTVOUCHER()
            End If
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String

        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("NAME")
            .Items.Add("REGION")
        End With

        Using ArrangeForm As New frmSortOptionDialog
            Dim result As DialogResult = ArrangeForm.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                If ArrangeForm.SelectedField = "REGION" Then
                    Dim rpt As New rptCASHDIVREG
                    Dim ASOFDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section6.ReportObjects("Text11")
                    rsRPT.Open("SELECT TOP 1 DIV.DATE FROM DIV", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                    ASOFDATE.Text = DateValue(rsRPT.Fields("DATE").Value)
                    rsRPT.Close()
                    If ArrangeForm.SelectedRegion.Trim = "" Then
                        sQRY = "SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                               "DIV.DIV_AMT, DIV.DEDNS,MEM.REGION FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE DIV.FD_AMT>0"
                    Else
                        sQRY = "SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                               "DIV.DIV_AMT, DIV.DEDNS,MEM.REGION FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE MEM.REGION='" & ArrangeForm.SelectedRegion & "' AND DIV.FD_AMT>0"
                    End If
                    rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                    rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                    If rsRPT.RecordCount > 0 Then
                        GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2:3")
                        frmFD_Member.Text = "CASH DIVIDEND REGISTER"
                        frmFD_Member.Show()
                    Else
                        MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "FD Runup")
                    End If
                Else
                    Dim rpt2 As New rptCASHDIVR
                    Dim ASOFDATE2 As CrystalDecisions.CrystalReports.Engine.TextObject = rpt2.Section2.ReportObjects("Text11")
                    rsRPT.Open("SELECT TOP 1 DIV.DATE FROM DIV", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                    ASOFDATE2.Text = DateValue(rsRPT.Fields("DATE").Value)
                    rsRPT.Close()
                    sQRY = "SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                           "DIV.DIV_AMT, DIV.DEDNS FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE DIV.FD_AMT>0 ORDER BY " & ArrangeForm.SelectedField
                    rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                    rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                    If rsRPT.RecordCount > 0 Then
                        GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt2, 0, "5:3:2:2:2")
                        frmFD_Member.Text = "CASH DIVIDEND REGISTER"
                        frmFD_Member.Show()
                    Else
                        MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "FD Runup")
                    End If
                End If
            End If

        End Using
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        DividendPatronageSettingsForm = New frmDividendPatronageSettings(CurrentUser, New DividendPatronageRefundSettingService, MainMessagePromptService)
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_DIVREFOpt.ShowDialog()
        If SW = True Then
            DividendPatronageSettingsForm.ShowDialog()
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click


        Using SummaryViewOptionForm As New frmSummaryViewOptionDialog
            Dim result As DialogResult = SummaryViewOptionForm.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                If SummaryViewOptionForm.IsSummarized = True Then
                    genPATREFS("WHERE MM.MEM_STAT='A'", "ACTIVE MEMBERS")
                Else
                    genPATREFD("INTEREST", "A", ",NULL AS PTLINT", "ACTIVE MEMBERS")
                End If
            End If

        End Using
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click

        Using SummaryViewOptionForm As New frmSummaryViewOptionDialog
            Dim result As DialogResult = SummaryViewOptionForm.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                If SummaryViewOptionForm.IsSummarized = True Then
                    genPATREFS("WHERE MM.MEM_STAT='R'", "RESIGNED MEMBERS")
                Else
                    genPATREFD("RNTEREST", "R", ",NULL AS PTLINT", "RESIGNED MEMBERS")
                End If
            End If
        End Using
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Using SummaryViewOptionForm As New frmSummaryViewOptionDialog
            Dim result As DialogResult = SummaryViewOptionForm.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                If SummaryViewOptionForm.IsSummarized = True Then
                    genPATREFS("WHERE MM.MEM_STAT='S'", "KBCI STAFF")
                Else
                    genPATREFD("SNTEREST", "S", ",ISNULL(SN.PTLINT,0) PTLINT", "KBCI STAFF")
                End If
            End If
        End Using

    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Using SummaryViewOptionForm As New frmSummaryViewOptionDialog
            Dim result As DialogResult = SummaryViewOptionForm.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                If SummaryViewOptionForm.IsSummarized = True Then
                    genPATREFS("", "ALL MEMBERS")
                Else
                    genPATREFD("", "", "", "ALL MEMBERS")
                End If
            End If
        End Using
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_Arrange = New frmSortOptionDialog
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("LNAME")
            .Items.Add("REGION")
        End With
        Using ArrangeForm As New frmSortOptionDialog

            Dim result As DialogResult = ArrangeForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                frmFDS_Main_DIVREFOpt.ShowDialog()
                If SW = True Then
                    If ArrangeForm.SelectedField <> "REGION" Then
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='A' AND", "ORDER BY DR." & ArrangeForm.SelectedField, "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("MM.MEM_STAT='A' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & ArrangeForm.SelectedField, "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    Else
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='A' AND", "AND MM.REGION='" & ArrangeForm.SelectedRegion & "'", "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)

                        Else
                            genDIVREFREG("MM.MEM_STAT='A' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & ArrangeForm.SelectedRegion & "' ORDER BY DR.KBCI_NO", "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    End If
                End If
            End If
        End Using


        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt

        Using ArrangeForm As New frmSortOptionDialog
            With ArrangeForm.ComboBox3
                .Items.Clear()
                .Items.Add("KBCI_NO")
                .Items.Add("LNAME")
                .Items.Add("REGION")
            End With

            Dim result As DialogResult = ArrangeForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                frmFDS_Main_DIVREFOpt.ShowDialog()
                If SW = True Then
                    If ArrangeForm.SelectedField <> "REGION" Then
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='R' AND", "ORDER BY DR." & ArrangeForm.SelectedField, "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("MM.MEM_STAT='R' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & ArrangeForm.SelectedField, "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    Else
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='R' AND", "AND MM.REGION='" & ArrangeForm.SelectedRegion & "'", "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("MM.MEM_STAT='R' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & ArrangeForm.SelectedRegion & "' ORDER BY DR.KBCI_NO", "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    End If
                End If

            End If
        End Using
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt

        Using ArrangeForm As New frmSortOptionDialog
            With ArrangeForm.ComboBox3
                .Items.Clear()
                .Items.Add("KBCI_NO")
                .Items.Add("LNAME")
                .Items.Add("REGION")
            End With

            Dim result As DialogResult = ArrangeForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                frmFDS_Main_DIVREFOpt.ShowDialog()
                If SW = True Then
                    If ArrangeForm.SelectedField <> "REGION" Then
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='S' AND", "ORDER BY DR." & ArrangeForm.SelectedField, "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("MM.MEM_STAT='S' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & ArrangeForm.SelectedField, "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    Else
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("MM.MEM_STAT='S' AND", "AND MM.REGION='" & ArrangeForm.SelectedRegion & "'", "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("MM.MEM_STAT='S' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & ArrangeForm.SelectedRegion & "' ORDER BY DR.KBCI_NO", "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    End If
                End If

            End If
        End Using
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt

        Using ArrangeForm As New frmSortOptionDialog
            With ArrangeForm.ComboBox3
                .Items.Clear()
                .Items.Add("KBCI_NO")
                .Items.Add("LNAME")
                .Items.Add("REGION")
            End With

            Dim result As DialogResult = ArrangeForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                frmFDS_Main_DIVREFOpt.ShowDialog()
                If SW = True Then
                    If ArrangeForm.SelectedField <> "REGION" Then
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("", "ORDER BY DR." & ArrangeForm.SelectedField, "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & ArrangeForm.SelectedField, "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    Else
                        If ViewOption = ViewOptions.Current Then
                            genDIVREFREG("", "AND MM.REGION='" & ArrangeForm.SelectedRegion & "'", "DIVREF", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        Else
                            genDIVREFREG("", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & ArrangeForm.SelectedRegion & "' ORDER BY DR.KBCI_NO", "DIVREFH", ArrangeForm.SelectedField, ArrangeForm.SelectedRegion)
                        End If
                    End If
                End If

            End If
        End Using
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_DIVREFOpt.ShowDialog()
        If SW = True Then

            Using rsDIVDao As New DivrefphDAO
                Dim param1 As New LUNA.LunaSearchParameter("YEAR", SELYR)
                Dim param2 As New LUNA.LunaSearchParameter("QUARTER", SELQTR)


                rsDIV = rsDIVDao.Find(param1, param2)
                If rsDIV Is Nothing Then
                    MsgBox(String.Format(GetGlobalResourceString("DivRefRecordNotFound"), SELYR, SELQTR), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageRefund"))
                    Exit Sub
                End If
                PRTVOUCHER()

            End Using
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

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
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

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

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFDS_Main_DEntry.MdiParent = Me
        frmFDS_Main_DEntry.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New Crypt
        ' Create object, passing in text
        Dim prtobj As New TextPrint(vbCrLf & vbTab & " TEST 1" & vbCrLf & vbTab & " TEST 2", "HP LaserJet 1022n")
        prtobj.Font = New Font("Lucida Console", 6)
        ' Issue print command

        'prtobj.Print()
        'prtobj.Dispose()
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

    Sub PRTVOUCHER()
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim rpt As New rptPRVOUCHER
        Dim divrefph As New ADODB.Recordset
        Dim sQRY As String

        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me


        sQRY = "SELECT 'APPLIANCE LOAN' AS [DESC], P_APL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'EDUCATIONAL LOAN' AS [DESC], P_EDL AS CDT, null AS DBT  FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'EMERGENCY LOAN' AS [DESC], P_EML AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'REGULAR LOAN' AS [DESC], P_RGL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'SPECIAL LOAN' AS [DESC], P_SPL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'RESTRUCTURED LOAN' AS [DESC], P_RSL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'SHORT TERM LOAN' AS [DESC], P_STL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PROVIDENT LOAN' AS [DESC], P_PTL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE APL' AS [DESC], PD_APL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE EDL' AS [DESC], PD_EDL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE EML' AS [DESC], PD_EmL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE RGL' AS [DESC], PD_RGL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE SPL' AS [DESC], PD_SPL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE RSL' AS [DESC], PD_RSL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE STL' AS [DESC], PD_STL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PAST DUE PTL' AS [DESC], PD_PTL AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'INTEREST ON LOANS' AS [DESC], INTEREST AS CDT, null AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'PENALTY ON LOANS' AS [DESC], PENALTY AS CDT,null as DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT 'SAVINGS DEPOSIT' AS [DESC], SAVINGS AS CDT,null as DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT TDEBDESC1 AS [DESC], null AS CDT,CAST(TDEBAMT1 AS CHAR(12)) AS DBT  FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT TDEBDESC2  AS [DESC], null AS CDT,CAST(TDEBAMT2 AS CHAR(12)) AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' " & _
                "UNION ALL SELECT TDEBDESC3 AS [DESC], null AS CDT, CAST(TDEBAMT3 AS CHAR(12)) AS DBT FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "' "

        rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsRPT.RecordCount > 0 Then
            divrefph.Open("select  ISNULL(CVNO,'XXXXXXX') CVNO FROM divrefph WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            Dim CVNO As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text4")
            Dim USR As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("Text10")
            USR.Text = "Prepared by : " & CurrentUser.UserName
            CVNO.Text = CStr(divrefph.Fields("cvno").Value)
            divrefph.Close()
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Friend Sub genPATREFD(ByVal TBL As String, ByVal STAT As String, ByVal optstr As String, ByVal categ As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptPATREFDET
        Dim divrefph As New ADODB.Recordset


        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me
        If STAT = "" Then
            sQRY = "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,SN.PTLINT,SN.CMLINT,SN.FALINT,SN.MPLINT " & _
                    "FROM  SNTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='S'  AND MM.YTD_DIVAMT>0 " & _
                    "UNION ALL " & _
                    "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,SN.PTLINT,SN.CMLINT,SN.FALINT,SN.MPLINT " & _
                    "FROM  RNTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='R'  AND MM.YTD_DIVAMT>0 " & _
                    "UNION ALL " & _
                    "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,0.00 PTLINT,SN.CMLINT,SN.FALINT,SN.MPLINT " & _
                    "FROM  INTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='A'  AND MM.YTD_DIVAMT>0 ORDER BY NAME"
            'WLOG(sQRY, App_Path() & "UNI.txt")
        Else
            sQRY = "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,ISNULL(SN.APLINT,0) APLINT,ISNULL(SN.EDLINT,0) EDLINT," & _
                    "ISNULL(SN.EMLINT,0) EMLINT,ISNULL(SN.RGLINT,0) RGLINT,ISNULL(SN.RSLINT,0) RSLINT,ISNULL(SN.SPLINT,0) SPLINT,ISNULL(SN.LHLINT,0) LHLINT,ISNULL(SN.STLINT,0) STLINT" & _
                    ",ISNULL(SN.CMLINT,0) CMLINT,ISNULL(SN.FALINT,0) FALINT,ISNULL(SN.MPLINT,0) MPLINT" & optstr & _
                    " FROM " & TBL & " SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='" & STAT & "' AND MM.YTD_DIVAMT>0 ORDER BY MM.LNAME, MM.FNAME"
        End If
        rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsRPT.RecordCount > 0 Then
            divrefph.Open("select TOP 1 PR_YEAR FROM divrefph ORDER BY [YEAR] DESC, [QUARTER] DESC", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            Dim CAT As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text19")
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text20")
            Dim PTL As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text11")
            Dim YYEAR As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text25")
            CAT.Text = categ
            DDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            YYEAR.Text = CStr(divrefph.Fields("PR_YEAR").Value)
            If TBL = "INTEREST" Or TBL = "RNTEREST" Then PTL.Text = "-"
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2:2:2:2:2:2:2:2:2:2")
            frmFD_Member.Text = "[DETAILED] PATRONAGE REFUND REGISTER"
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Friend Sub genPATREFS(ByVal optstr As String, ByVal categ As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptPATREFSUM
        Dim divrefph As New ADODB.Recordset
        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me

        sQRY = "SELECT MM.KBCI_NO, MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,RF.INT_PAID,RF.REFUND " & _
                "FROM		REF RF INNER JOIN MEMBERS MM ON RF.KBCI_NO=MM.KBCI_NO " & _
                optstr & " " & _
                "ORDER BY	NAME"

        rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsRPT.RecordCount > 0 Then
            divrefph.Open("select TOP 1 PR_YEAR FROM divrefph ORDER BY [YEAR] DESC, [QUARTER] DESC", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            Dim CAT As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text19")
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text5")
            Dim YYEAR As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text6")
            CAT.Text = categ
            DDATE.Text = DateValue(SYSDATE).ToString("MMM dd, yyyy")
            YYEAR.Text = CStr(divrefph.Fields("PR_YEAR").Value)
            divrefph.Close()
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2")
            frmFD_Member.Text = "[SUMMARIZED] PATRONAGE REFUND REGISTER"
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Friend Sub genDIVREFREG(ByVal MSTAT As String, ByVal ORDR As String, ByVal TBL As String, ByVal SelectedField As String, ByVal SelectedRegion As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptDIVREFREG
        Dim divrefph As New ADODB.Recordset
        frmFD_Member = New frmReportViewer
        frmFD_Member.MdiParent = Me

        sQRY = "SELECT DR.KBCI_NO, DR.LNAME + ', ' + DR.FNAME + ' ' + ISNULL(DR.MI,'X') + '.' NAME," & _
                "ISNULL(DR.DIVIDEND,0) DIVIDEND,ISNULL(DR.REFUND,0) REFUND," & _
                "ISNULL(DR.DEDUCTIONS,0) DEDUCTIONS " & _
                "FROM " & TBL & " DR " & _
                "LEFT JOIN MEMBERS MM ON MM.KBCI_NO=DR.KBCI_NO " & _
                "WHERE " & MSTAT & " (DR.REFUND>0 OR DR.DIVIDEND>0) " & ORDR


        rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsRPT.RecordCount > 0 Then
            'divrefph.Open("select TOP 1 PR_YEAR FROM divrefph ORDER BY [YEAR] DESC, [QUARTER] DESC", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            Dim CAT As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text9")
            Dim REG As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text11")
            '
            'Dim YYEAR As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text6")

            CAT.Text = "FOR QUARTER " & SELQTR & " YEAR " & SELYR
            If SelectedField = "REGION" Then
                REG.Text = "REGION : " & SelectedRegion.ToUpper
            Else
                REG.Text = ""
            End If

            'divrefph.Close()
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2")
            frmFD_Member.Text = "CASH DIV. / PAT REFUND. REGISTER"
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If

    End Sub

    Sub fillStatbar()
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

End Class
