Imports System.Data.SqlClient

Public Class frmFDS_Main
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDS_Main))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 327)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(768, 22)
        Me.StatusBar1.TabIndex = 2
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.ToolTipText = "Logged user"
        Me.StatusBarPanel1.Width = 200
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel3.ToolTipText = "System Date"
        Me.StatusBarPanel3.Width = 150
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel4.ToolTipText = "Today"
        Me.StatusBarPanel4.Width = 200
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem1, Me.MenuItem9, Me.MenuItem14})
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
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlC
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(768, 48)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmFDS_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(768, 349)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmFDS_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Deposit System V1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public frmFDS_Main_PrntFDL_Srch As frmFDS_Main_PrntFDL_Srch
    Public frmFDS_Main_DEntry As frmFDS_Main_DEntry
    Public frmFDS_Main_NMem As frmFDS_Main_NMem
    Public frmFDS_Main_PrntFDL As frmFDS_Main_PrntFDL
    Public frmFDS_Main_Log As frmFDS_Main_Log = New frmFDS_Main_Log
    Public frmFD_Member As frmFD_Member
    Public frmFDS_Main_Arrange As frmFDS_Main_Arrange
    Public frmDIVPAT As frmDIVPAT
    Public frmFDS_Main_DIVPATMain As frmFDS_Main_DIVPATMain
    Public frmFDS_Main_Opt As frmFDS_Main_Opt
    Public frmFDS_Main_DIVREFOpt As frmFDS_Main_DIVREFOpt
    Public frmFDS_DVoucher As frmFDS_DVoucher
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        rsMEMBERS.Open("SELECT KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT FROM Members ", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        frmFDS_Main_DEntry = New frmFDS_Main_DEntry
        frmFDS_Main_DEntry.MdiParent = Me
        frmFDS_Main_DEntry.Show()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        frmFDS_Main_NMem = New frmFDS_Main_NMem
        frmFDS_Main_NMem.MdiParent = Me
        frmFDS_Main_NMem.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        '#####PRINT FD LEDGER
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptFD_Member
        Dim ds As New DataSet
        Dim txtKBCI As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txtKBCINO")
        Dim txtFLNAME As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txtFLNAME")

        frmFD_Member = New frmFD_Member
        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member.MdiParent = Me
        Dim sQRY As String
        frmFDS_Main_PrntFDL.ShowDialog()
        If SW = True Then
            frmFDS_Main_PrntFDL_Srch.ShowDialog()
            If SW = True Then
                sQRY = "SELECT FD.DATE,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT,FD.BALANCE,FD.REF,FD.RMK AS REMARKS, FD.DRCR FROM FD INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID WHERE DATE BETWEEN '" & sDate & "' and KBCI_NO = '" & SEL_KBCI_NO & "'"
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                txtKBCI.Text = Mid(SEL_KBCI_NO, 1, 2) & "-" & Mid(SEL_KBCI_NO, 3, 4) & "-" & Mid(SEL_KBCI_NO, 7, 1)
                txtFLNAME.Text = SEL_FNAME
                If rsRPT.RecordCount > 0 Then
                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "1:3:2:2:2:3:3")
                    frmFD_Member.Show()
                Else
                    MsgBox("No transactions found between the specified dates.", MsgBoxStyle.Information, "Fixed Deposit Ledger")
                End If
                SW = False
            End If

        End If
        If rsRPT.State = 1 Then rsRPT.Close()
    End Sub
    Function GetConfig(ByVal KEY As String) As String
        Dim crypto As New Crypt
        Return crypto.DecTDES(System.Configuration.ConfigurationSettings.AppSettings(KEY), System.Configuration.ConfigurationSettings.AppSettings("32"))
    End Function
    Private Sub frmFDS_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errHand
        frmFDS_Main_Log = New frmFDS_Main_Log
        cn.ConnectionString = "Provider=SQLOLEDB.1;Password=" & GetConfig("WP") & ";Persist Security Info=True;User ID=" & GetConfig("CL") & ";Initial Catalog=" & GetConfig("DB") & ";Data Source=" & GetConfig("SV")
        'cn.ConnectionString = "Provider=SQLOLEDB.1;Password=3ethaYaS;Persist Security Info=True;User ID=sa;Initial Catalog=kbci;Data Source=133.100.205.237\AUTOPROD,1433"
        'cn.ConnectionString = "Provider=SQLOLEDB.1;Password=password123;Persist Security Info=True;User ID=sa;Initial Catalog=kbci;Data Source=BLITZ\SQLEXPRESS,1433"
        lcn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App_Path() & "KBCILocal.mdb" & ";Persist Security Info=False;Jet OLEDB:Database Password=password123""Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App_Path() & "KBCILocal.mdb" & ";Persist Security Info=False;Jet OLEDB:Database Password=password123"
        cn.Open()
        lcn.Open()
        frmFDS_Main_Log.ShowDialog()
        'rsMEMBERS.Open("SELECT KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT FROM Members WHERE KBCI_NO=9130381", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        lcn.Execute("DELETE FROM TRANCODE")
        With rsTRANCODE
            .Open("SELECT * FROM TRANCODE", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
            .MoveFirst()
            Do Until rsTRANCODE.EOF
                'WLOG(CleanSTR("INSERT INTO TRANCODE(TR_ID,TR_CODE) Values('" & .Fields("TR_ID").Value & "','" & .Fields("TR_CODE").Value & "')"), App_Path() & "SQLTRAN.log")
                lcn.Execute(CleanSTR("INSERT INTO TRANCODE(TR_ID,TR_CODE) Values('" & .Fields("TR_ID").Value & "','" & .Fields("TR_CODE").Value & "')"))
                .MoveNext()
            Loop
        End With
        rsTRANCODE.Close()
        rsTRANCODE.Open("SELECT * FROM TRANCODE", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        rsCTL.Open("SELECT TOP 1 * FROM  CTRL", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        SYSDATE = rsCTL.Fields("sysdate").Value
        fillStatbar()

errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmFDS_Main.frmFDS_Main_Load", CLUSER)
        End If
    End Sub

    Private Sub frmFDS_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        cn.Close()
        lcn.Close()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        '#####PRINT FD LEDGER
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New Passbook
        Dim ds As New DataSet
        Dim txtKBCI As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txtKBCI")
        Dim txtFLNAME As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txtFLNAME")

        frmFD_Member = New frmFD_Member
        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member.MdiParent = Me

        frmFDS_Main_PrntFDL_Srch.ShowDialog()
        If SW = True Then
            txtKBCI.Text = Mid(SEL_KBCI_NO, 1, 2) & "-" & Mid(SEL_KBCI_NO, 3, 4) & "-" & Mid(SEL_KBCI_NO, 7, 1)
            txtFLNAME.Text = SEL_FNAME
            frmFD_Member.CrystalReportViewer1.ReportSource = rpt
            frmFD_Member.Show()
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        '#####PRINT DAILY TRANSACTION
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptDTran_Reg
        Dim ds As New DataSet
        Dim sQRY As String

        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me

        frmFDS_Main_PrntFDL.DateTimePicker2.Visible = False
        frmFDS_Main_PrntFDL.Label2.Visible = False
        frmFDS_Main_PrntFDL.ShowDialog()

        If SW = True Then
            sQRY = "SELECT MM.KBCI_NO,MM.LNAME + ', ' + MM.FNAME + ' ' NAME,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT," & _
                   "FD.BALANCE,FD.REF,FD.RMK, FD.DRCR FROM FD INNER JOIN MEMBERS AS MM ON FD.KBCI_NO= MM.KBCI_NO INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID " & _
                   "WHERE DATE BETWEEN '" & sDate & "'"
            rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If rsRPT.RecordCount > 0 Then
                Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text9")
                DDATE.Text = DateValue(frmFDS_Main_PrntFDL.DateTimePicker2.Value).ToString("MMM dd, yyyy")
                GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:2:2:2:3:3")
                frmFD_Member.Show()
            Else
                MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
            End If
            SW = False
        End If
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        '#####LIST OF CURRENT MEM/INV
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptMem_List
        Dim ds As New DataSet
        Dim ASOFDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text36")
        frmFD_Member = New frmFD_Member
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
            frmFD_Member.Show()
        Else
            MsgBox("No members found.", MsgBoxStyle.Information, "Member Listing")
        End If
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        End
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        '#####LIST OF RESIGNED INV/MEM
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim rpt As New rptRMem_List
        Dim ds As New DataSet
        Dim sQRY As String

        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me

        frmFDS_Main_PrntFDL.ShowDialog()
        If SW = True Then
            sQRY = "SELECT [KBCI_NO],[LNAME]+ ', ' + [FNAME] + ' ' + [MI] + '.' AS NAME,[MEM_STAT],[CHG_DATE],[FD_AMOUNT] FROM MEMBERS " & _
                   "WHERE MEM_STAT='R' AND CHG_DATE BETWEEN '" & sDate & "' ORDER BY LNAME, FNAME"
            rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If rsRPT.RecordCount > 0 Then
                Dim RDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text13")
                RDATE.Text = FRDATE & " TO " & TODATE

                GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:1:2")
                frmFD_Member.Show()
            Else
                MsgBox("No resigned member(s) found between the specified date.", MsgBoxStyle.Information, "Resigned Member/Investor")
            End If
            SW = False
        End If
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
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

        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me

        msg = MsgBox("Last FD Runup is " & DateValue(rsCTL.Fields("RUN_DATE").Value).ToString("MM/dd/yyyy") & ". Would you like to continue?", MsgBoxStyle.Information.YesNo, "Print FD Runup")
        If msg = vbYes Then
            frmFDS_Main_PrntFDL.DateTimePicker2.Visible = False
            frmFDS_Main_PrntFDL.Label2.Visible = False
            frmFDS_Main_PrntFDL.ShowDialog()

            If SW = True Then
                sQRY = "SELECT MEM.KBCI_NO,MEM.LNAME+ ', ' + MEM.FNAME + ' ' + MEM.MI + '.' AS NAME,  FD.BALANCE FROM FD  " & _
                             "RIGHT OUTER JOIN (SELECT MAX(FD_ID) FD_ID FROM FD WHERE KBCI_NO + convert(varchar(30), [DATE]) in " & _
                             "( select KBCI_NO + convert(varchar(30), MAX([DATE])) K_D from FD where [DATE] <= '" & frmFDS_Main_PrntFDL.DateTimePicker1.Value & "' group by KBCI_NO) " & _
                             "group by KBCI_NO ) B on FD.FD_ID = B.FD_ID RIGHT OUTER JOIN MEMBERS MEM on FD.KBCI_NO = MEM.KBCI_NO"
                rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                MsgBox("Successfully processed [" & rsRPT.RecordCount & "] records.", MsgBoxStyle.Information, "FD Runup report")
                If rsRPT.RecordCount > 0 Then
                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2")
                    cn.Execute("UPDATE CTRL SET RUN_DATE='" & frmFDS_Main_PrntFDL.DateTimePicker2.Value & "'")
                    rsCTL.Requery()
                    frmFD_Member.Show()

                Else
                    MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "FD Runup")
                End If
                SW = False
            End If
            If rsRPT.State = 1 Then rsRPT.Close()
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        frmDIVPAT = New frmDIVPAT
        frmDIVPAT.ShowDialog()
    End Sub
    Sub fillStatbar()
        With StatusBar1
            .Panels(1).Width = .Width - (.Panels(0).Width + .Panels(2).Width + .Panels(3).Width)
            .Panels(0).Text = CLUSER
            .Panels(2).Text = SYSDATE
            .Panels(3).Text = Now
        End With

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Panels(3).Text = Now
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_DVoucher = New frmFDS_DVoucher
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
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim rsRPT As New ADODB.Recordset
        Dim msg As String
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String

        frmFDS_Main_Arrange = New frmFDS_Main_Arrange
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("NAME")
            .Items.Add("REGION")
        End With

        frmFDS_Main_Arrange.ShowDialog()
        If SW = True Then
            If SELFIELD = "REGION" Then
                Dim rpt As New rptCASHDIVREG
                Dim ASOFDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section6.ReportObjects("Text11")
                rsRPT.Open("SELECT TOP 1 DIV.DATE FROM DIV", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                ASOFDATE.Text = DateValue(rsRPT.Fields("DATE").Value)
                rsRPT.Close()
                If SELREGION.Trim = "" Then
                    sQRY = "SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                           "DIV.DIV_AMT, DIV.DEDNS,MEM.REGION FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE DIV.FD_AMT>0"
                Else
                    sQRY = "SELECT DIV.KBCI_NO, MEM.LNAME + ' ' + MEM.FNAME + ', ' + ISNULL(MEM.MI,'X') + '.' AS NAME, DIV.FD_AMT, " & _
                           "DIV.DIV_AMT, DIV.DEDNS,MEM.REGION FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE MEM.REGION='" & SELREGION & "' AND DIV.FD_AMT>0"
                End If
                rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                If rsRPT.RecordCount > 0 Then
                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2:3")
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
                       "DIV.DIV_AMT, DIV.DEDNS FROM DIV INNER JOIN MEMBERS MEM ON  MEM.KBCI_NO= div.KBCI_NO WHERE DIV.FD_AMT>0 ORDER BY " & SELFIELD
                rsRPT.CursorLocation = CursorLocationEnum.adUseClient
                rsRPT.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly, )
                If rsRPT.RecordCount > 0 Then
                    GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt2, 0, "5:3:2:2:2")
                    frmFD_Member.Show()
                Else
                    MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "FD Runup")
                End If
            End If
            SW = False
        End If
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        frmFDS_Main_DIVPATMain = New frmFDS_Main_DIVPATMain
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_DIVREFOpt.ShowDialog()
        If SW = True Then
            frmFDS_Main_DIVPATMain.ShowDialog()
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        frmFDS_Main_Opt = New frmFDS_Main_Opt
        frmFDS_Main_Opt.ShowDialog()
        If SW = True Then
            If SUMMRY = True Then
                genPATREFS("WHERE MM.MEM_STAT='A'", "ACTIVE MEMBERS")
            Else
                genPATREFD("INTEREST", "A", ",0 AS PTLINT", "ACTIVE MEMBERS")
            End If
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        frmFDS_Main_Opt = New frmFDS_Main_Opt
        frmFDS_Main_Opt.ShowDialog()
        If SW = True Then
            If SUMMRY = True Then
                genPATREFS("WHERE MM.MEM_STAT='R'", "RESIGNED MEMBERS")
            Else
                genPATREFD("RNTEREST", "R", ",ISNULL(SN.PTLINT,0) PTLINT", "RESIGNED MEMBERS")
            End If
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        frmFDS_Main_Opt = New frmFDS_Main_Opt
        frmFDS_Main_Opt.ShowDialog()
        If SW = True Then
            If SUMMRY = True Then
                genPATREFS("WHERE MM.MEM_STAT='S'", "KBCI STAFF")
            Else
                genPATREFD("SNTEREST", "S", ",ISNULL(SN.PTLINT,0) PTLINT", "KBCI STAFF")
            End If
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        frmFDS_Main_Opt = New frmFDS_Main_Opt
        frmFDS_Main_Opt.ShowDialog()
        If SW = True Then
            If SUMMRY = True Then
                genPATREFS("", "ALL MEMBERS")
            Else
                genPATREFD("", "", "", "ALL MEMBERS")
            End If
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Friend Sub genPATREFD(ByVal TBL As String, ByVal STAT As String, ByVal optstr As String, ByVal categ As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptPATREFDET
        Dim divrefph As New ADODB.Recordset


        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        If STAT = "" Then
            sQRY = "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,SN.PTLINT " & _
                    "FROM  SNTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='S'  AND MM.YTD_DIVAMT>0 " & _
                    "UNION ALL " & _
                    "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,SN.PTLINT " & _
                    "FROM  RNTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='R'  AND MM.YTD_DIVAMT>0 " & _
                    "UNION ALL " & _
                    "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,SN.APLINT,SN.EDLINT,SN.EMLINT,SN.RGLINT,SN.RSLINT,SN.SPLINT,SN.LHLINT,SN.STLINT,0.00 PTLINT " & _
                    "FROM  INTEREST SN INNER JOIN MEMBERS MM ON SN.ACCTNO=MM.KBCI_NO WHERE	MM.MEM_STAT='A'  AND MM.YTD_DIVAMT>0 ORDER BY NAME"
            'WLOG(sQRY, App_Path() & "UNI.txt")
        Else
            sQRY = "SELECT 	SN.ACCTNO,MM.LNAME + ', ' + MM.FNAME + ' ' + ISNULL(MM.MI,'X') + '.' NAME,ISNULL(SN.APLINT,0) APLINT,ISNULL(SN.EDLINT,0) EDLINT," & _
                    "ISNULL(SN.EMLINT,0) EMLINT,ISNULL(SN.RGLINT,0) RGLINT,ISNULL(SN.RSLINT,0) RSLINT,ISNULL(SN.SPLINT,0) SPLINT,ISNULL(SN.LHLINT,0) LHLINT,ISNULL(SN.STLINT,0) STLINT" & optstr & _
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
            If TBL = "INTEREST" Then PTL.Text = "-"
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2:2:2:2:2:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Friend Sub genPATREFS(ByVal optstr As String, ByVal categ As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptPATREFSUM
        Dim divrefph As New ADODB.Recordset
        frmFD_Member = New frmFD_Member
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
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Friend Sub genDIVREFREG(ByVal MSTAT As String, ByVal ORDR As String, ByVal TBL As String)
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim sQRY As String
        Dim rpt As New rptDIVREFREG
        Dim divrefph As New ADODB.Recordset
        frmFD_Member = New frmFD_Member
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
            If SELFIELD = "REGION" Then
                REG.Text = "REGION : " & SELREGION.ToUpper
            Else
                REG.Text = ""
            End If

            'divrefph.Close()
            GenRPT(rsRPT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:2:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        If rsRPT.State = 1 Then rsRPT.Close()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_Arrange = New frmFDS_Main_Arrange
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("LNAME")
            .Items.Add("REGION")
        End With
        frmFDS_Main_Arrange.ShowDialog()
        If SW = True Then
            frmFDS_Main_DIVREFOpt.ShowDialog()
            If SW = True Then
                If SELFIELD <> "REGION" Then
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='A' AND", "ORDER BY DR." & SELFIELD, "DIVREF")
                    Else
                        genDIVREFREG("MM.MEM_STAT='A' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & SELFIELD, "DIVREFH")
                    End If
                Else
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='A' AND", "AND MM.REGION='" & SELREGION & "'", "DIVREF")

                    Else
                        genDIVREFREG("MM.MEM_STAT='A' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & SELREGION & "' ORDER BY DR.KBCI_NO", "DIVREFH")
                    End If
                End If
            End If
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_Arrange = New frmFDS_Main_Arrange
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("LNAME")
            .Items.Add("REGION")
        End With
        frmFDS_Main_Arrange.ShowDialog()
        If SW = True Then
            frmFDS_Main_DIVREFOpt.ShowDialog()
            If SW = True Then
                If SELFIELD <> "REGION" Then
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='R' AND", "ORDER BY DR." & SELFIELD, "DIVREF")
                    Else
                        genDIVREFREG("MM.MEM_STAT='R' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & SELFIELD, "DIVREFH")
                    End If
                Else
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='R' AND", "AND MM.REGION='" & SELREGION & "'", "DIVREF")
                    Else
                        genDIVREFREG("MM.MEM_STAT='R' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & SELREGION & "' ORDER BY DR.KBCI_NO", "DIVREFH")
                    End If
                End If
            End If
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_Arrange = New frmFDS_Main_Arrange
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("LNAME")
            .Items.Add("REGION")
        End With
        frmFDS_Main_Arrange.ShowDialog()
        If SW = True Then
            frmFDS_Main_DIVREFOpt.ShowDialog()
            If SW = True Then
                If SELFIELD <> "REGION" Then
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='S' AND", "ORDER BY DR." & SELFIELD, "DIVREF")
                    Else
                        genDIVREFREG("MM.MEM_STAT='S' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & SELFIELD, "DIVREFH")
                    End If
                Else
                    If CURSW = True Then
                        genDIVREFREG("MM.MEM_STAT='S' AND", "AND MM.REGION='" & SELREGION & "'", "DIVREF")
                    Else
                        genDIVREFREG("MM.MEM_STAT='S' AND", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & SELREGION & "' ORDER BY DR.KBCI_NO", "DIVREFH")
                    End If
                End If
            End If
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_Arrange = New frmFDS_Main_Arrange
        With frmFDS_Main_Arrange.ComboBox3
            .Items.Clear()
            .Items.Add("KBCI_NO")
            .Items.Add("LNAME")
            .Items.Add("REGION")
        End With
        frmFDS_Main_Arrange.ShowDialog()
        If SW = True Then
            frmFDS_Main_DIVREFOpt.ShowDialog()
            If SW = True Then
                If SELFIELD <> "REGION" Then
                    If CURSW = True Then
                        genDIVREFREG("", "ORDER BY DR." & SELFIELD, "DIVREF")
                    Else
                        genDIVREFREG("", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') ORDER BY DR." & SELFIELD, "DIVREFH")
                    End If
                Else
                    If CURSW = True Then
                        genDIVREFREG("", "AND MM.REGION='" & SELREGION & "'", "DIVREF")
                    Else
                        genDIVREFREG("", "AND (DR.YEAR='" & SELYR & "' AND DR.QUARTER='" & SELQTR & "') AND MM.REGION='" & SELREGION & "' ORDER BY DR.KBCI_NO", "DIVREFH")
                    End If
                End If
            End If
        End If
        SW = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        frmFDS_Main_DIVREFOpt = New frmFDS_Main_DIVREFOpt
        frmFDS_Main_DIVREFOpt.ShowDialog()
        If SW = True Then
            rsDIV.Open("SELECT [CVNO],[POSTED] FROM  DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If rsDIV.RecordCount < 1 Then
                MsgBox("RECORD NOT FOUND FOR YEAR:[" & SELYR & "] QUARTER:[" & SELQTR & "].", MsgBoxStyle.Information, "CASH DIV/PAT REF PROCESSING")
                rsDIV.Close()
                Exit Sub
            End If
            rsDIV.Close()
            PRTVOUCHER()
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Sub PRTVOUCHER()
        Dim rsRPT As New ADODB.Recordset
        Dim dst As New DataTable("dstFD_Member")
        Dim ds As New DataSet
        Dim rpt As New rptPRVOUCHER
        Dim divrefph As New ADODB.Recordset
        Dim sQRY As String

        frmFD_Member = New frmFD_Member
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
            USR.Text = "Prepared by : " & CLUSER
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
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        frmFDS_Main_Log = New frmFDS_Main_Log
        frmFDS_Main_Log.TextBox6.Text = CLUSER
        frmFDS_Main_Log.Button3.Text = "Unlock"
        frmFDS_Main_Log.Button2.Enabled = False
        frmFDS_Main_Log.TextBox6.Enabled = False
        frmFDS_Main_Log.ShowDialog()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim msg As String
        msg = MsgBox("Do you want to log-off?", MsgBoxStyle.Exclamation.YesNo, "[" & CLUSER & "] Logout")
        If msg = vbYes Then
            frmFDS_Main_Log = New frmFDS_Main_Log
            frmFDS_Main_Log.ShowDialog()
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub

    Private Sub frmFDS_Main_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        MsgBox(e.KeyValue)
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFDS_Main_DEntry.MdiParent = Me
        frmFDS_Main_DEntry.Show()
    End Sub
End Class