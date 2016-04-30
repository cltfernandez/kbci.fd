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
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
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
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 327)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(768, 22)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel4.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw
        Me.StatusBarPanel4.Text = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 99
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem1, Me.MenuItem9, Me.MenuItem14})
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28})
        Me.MenuItem24.Text = "File"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "Lock"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
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
        Me.MenuItem28.Text = "Exit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6, Me.MenuItem7, Me.MenuItem5, Me.MenuItem8})
        Me.MenuItem1.Text = "Fixed Deposit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Data Entry"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Print FD Ledger"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Text = "Print Daily Transaction Register"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "Print FD Runup"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "Passbook Initialization"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem13})
        Me.MenuItem9.Text = "Members"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "New Member"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Print Members Listing"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "List of Resigned Mem/Inv"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem15, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem14.Text = "DIV/REF"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "Cash Div/Pat Refund Maintenance"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "Cash Div/Pat Refund"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
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
        Me.MenuItem19.Text = "Print Cash Div Register"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "Print Pat. Ref. Register"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.Text = "Print Div/Ref Register"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
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
        'frmFDS_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(768, 349)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmFDS_Main"
        Me.Text = "Fixed Deposits"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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

    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        rsMEMBERS.Open("SELECT KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT FROM Members ", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
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
                sQRY = "SELECT FD.DATE,TC.TR_CODE AS CODE,FD.AMOUNT AS DEBIT,FD.AMOUNT AS CREDIT,FD.BALANCE,FD.REF,FD.RMK AS REMARKS FROM FD INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID WHERE DATE BETWEEN '" & sDate & "' and KBCI_NO = '" & SEL_KBCI_NO & "'"
                rsFD_Mem.Open(sQRY, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                txtKBCI.Text = SEL_KBCI_NO
                txtFLNAME.Text = SEL_FNAME
                GenRPT(rsFD_Mem, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "1:3:2:2:2:3:3")
                frmFD_Member.Show()
            End If
        End If
    End Sub

    Private Sub frmFDS_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open("Provider=SQLOLEDB.1;Password=3ethaYaS;Persist Security Info=True;User ID=sa;Initial Catalog=kbci;Data Source=133.100.205.237\AUTOPROD,1433")
        'cn.Open("Provider=SQLOLEDB.1;Password=password123;Persist Security Info=True;User ID=sa;Initial Catalog=kbci;Data Source=BLITZ\SQLEXPRESS,1433")
        lcn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App_Path() & "KBCILocal.mdb" & ";Persist Security Info=False;Jet OLEDB:Database Password=password123""Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App_Path() & "KBCILocal.mdb" & ";Persist Security Info=False;Jet OLEDB:Database Password=password123")
        'rsMEMBERS.Open("SELECT KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT FROM Members WHERE KBCI_NO=9130381", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        With rsTRANCODE
            .Open("SELECT * FROM TRANCODE", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
            .MoveFirst()
            lcn.Execute("DELETE FROM TRANCODE")
            Do Until rsTRANCODE.EOF
                lcn.Execute("INSERT INTO TRANCODE(TR_ID,TR_CODE) Values('" & .Fields("TR_ID").Value & "','" & .Fields("TR_CODE").Value & "')")
                .MoveNext()
            Loop
        End With
        rsTRANCODE.Close()
        rsTRANCODE.Open("SELECT * FROM TRANCODE", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        rsCTL.Open("SELECT TOP 1 * FROM  CTRL", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        MsgBox(CStr("-999-999").Replace("-", ""))


    End Sub

    Private Sub frmFDS_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        cn.Close()
        lcn.Close()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click

    End Sub
End Class
