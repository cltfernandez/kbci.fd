Imports FD.Common
Imports FD.ViewModels
Public Class frmMembersTransactionList
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal _CurrentUser As UserViewModel)
        CurrentUser = _CurrentUser
        InitializeComponent()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembersTransactionList))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 402)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(931, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Show History"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(10, 47)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1056, 315)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Loading..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(912, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Re&versal"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TRANSACTIONS:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(586, 370)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 25)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "A&dd Transaction"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(749, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Passbook &Update"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(771, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "BALANCE :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(771, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(303, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "KBCI No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(480, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 69)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(30, 29)
        Me.TextBox3.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.TextBox3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 21)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Print Line"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(923, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 25)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(634, 54)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(77, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 35)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "KBCI No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "KBCI No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(98, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "KBCI No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(5, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1073, 30)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "..."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFDS_Main_DEntry_Tran
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1086, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDS_Main_DEntry_Tran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public TransactionDialogForm As frmMembersTransactionDialog
    Dim lastLine As Integer
    Private PrintTransaction As Boolean = False
    Private IsPassbookUpdate As Boolean = False

    Private _CurrentUser As UserViewModel
    Public Property CurrentUser() As UserViewModel
        Get
            Return _CurrentUser
        End Get
        Set(ByVal value As UserViewModel)
            _CurrentUser = value
        End Set
    End Property


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim msg3 As String
        TransactionDialogForm = New frmMembersTransactionDialog(CurrentUser)
        TransactionDialogForm.ShowDialog()
        If SW = True Then
            If Not IsPassbookUpdate Then
                rsFD_Mem.Requery()
                rsFD_Mem.Filter = adFilterNone
                rsFD_Mem.Filter = "PRINTED>0"
                If rsFD_Mem.RecordCount > 0 Then
                    rsFD_Mem.MoveLast()
                    lastLine = Int(rsFD_Mem.Fields("PRINTED").Value) + 1
                    If lastLine > 24 Then lastLine = 1
                Else
                    lastLine = 1
                End If
                rsFD_Mem.Filter = adFilterNone
                rsFD_Mem.Filter = "PRINTED<1"

                msg3 = MsgBox(String.Format("There are [{0}] entries that are not yet posted on member's Passbook. Would you like to print.", rsFD_Mem.RecordCount), vbQuestion & vbYesNo, "Print Transaction")
                If msg3 = vbYes Then
                    FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
                    GroupBox2.Visible = True
                    GroupBox1.Enabled = False
                    TextBox3.Text = lastLine
                    TextBox3.Focus()
                    PrintTransaction = True
                End If
            End If
        End If
        UPDT_frmFDS_Main_DEntry_Tran()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            rsFD_Mem.Filter = ADODB.FilterGroupEnum.adFilterNone
        Else
            rsFD_Mem.Filter = "DATE =" & SYSDATE
        End If
        FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
        If rsFD_Mem.RecordCount > 0 Then ListView1.EnsureVisible(ListView1.Items.Count - 1)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub GroupBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.F1
                Button6.PerformClick()
            Case Keys.F2
                Button3.PerformClick()
            Case Keys.F3
                Button2.PerformClick()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SYDATE As Date = SYSDATE
        Dim msg, ref, CRDR As String
        Dim seq As Integer
        With rsFD_Mem_L
            .Open("SELECT * FROM FD WHERE DATE='" & SYDATE.ToString("MM/dd/yyyy") & "' ORDER BY FD.DATE, FD.FD_ID, FD.REF", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If .RecordCount > 0 Then
                msg = MsgBox("Would you like to reverse the last transaction?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Reversal")
                If msg = vbYes Then
                    .MoveLast()
                    rsFD_Mem.Filter = ADODB.FilterGroupEnum.adFilterNone
                    seq = rsFD_Mem.RecordCount + 1
                    rsFD_Mem.Filter = "DATE =" & SYSDATE
                    If .Fields("DRCR").Value = "CR" Then
                        CRDR = "DR"
                        BALANCE = Round(CDbl(SelectedMemberData.FD_AMOUNT), 2) - Round(CDbl(.Fields("AMOUNT").Value), 2)
                    Else
                        CRDR = "CR"
                        BALANCE = Round(CDbl(SelectedMemberData.FD_AMOUNT), 2) + Round(CDbl(.Fields("AMOUNT").Value), 2)
                    End If
                    ref = SYDATE.ToString("yyyyMMdd") & seq.ToString("D2")
                    'WLOG(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                    '     "VALUES('" & .Fields("KBCI_NO").Value & "','5','" & sydate.ToString("MM /dd/yyyy") & "','" & ref & "'," & .Fields("AMOUNT").Value & "," & BALANCE & ",'" & UCase("REVERSAL:" & .Fields("REF").Value) & "','" & SYSDATE & "','" & CurrentUser.Username & "',0,'" & CRDR & "','','',0,1)"), App_Path() & "SQLTRAN.log")
                    'WLOG("UPDATE MEMBERS SET FD_AMOUNT=" & BALANCE & " WHERE KBCI_NO='" & rsMEMBERS_L.Fields("KBCI_NO").Value & "'", App_Path() & "SQLTRAN.log")
                    cn.Execute(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                         "VALUES('" & .Fields("KBCI_NO").Value & "','5','" & SYDATE.ToString("MM /dd/yyyy") & "','" & ref & "'," & .Fields("AMOUNT").Value & "," & BALANCE & ",'" & UCase("REVERSAL:" & .Fields("REF").Value) & "','" & SYSDATE & "','" & CurrentUser.UserName & "',0,'" & CRDR & "','','',0,1)"))
                    cn.Execute("UPDATE MEMBERS SET FD_AMOUNT=" & BALANCE & " WHERE KBCI_NO='" & SelectedMemberData.KBCI_NO & "'")
                    SW = True

                    UPDT_frmFDS_Main_DEntry_Tran()
                End If
            Else
                MsgBox("No Transaction available for reversal.", MsgBoxStyle.Information, "Reverse Transaction")
            End If
            .Close()
        End With
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub frmFDS_Main_DEntry_Tran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Error GoTo errHand

        If rsFD_Mem.RecordCount < 1 Then
            MsgBox("MEMBER HAS NO TRANSACTIONS.", MsgBoxStyle.Exclamation, "Information")
        End If
        rsFD_Mem.Close()
        rsFD_Mem.Open("SELECT FD.FD_ID,FD.KBCI_NO,FD.DATE,FD.REF AS  REFERENCE,TC.TR_CODE AS CODE, isnull(FD.AMOUNT,0) AS AMOUNT,isnull(FD.BALANCE,0) AS BALANCE,FD.RMK AS  REMARKS,TPOSTED,LPOSTED PRINTED,DRCR FROM FD INNER JOIN TRANCODE TC ON FD.TRAN_CODE=TC.TR_ID WHERE KBCI_NO=" & SEL_KBCI_NO & "  ORDER BY FD.DATE, FD.FD_ID, FD.REF", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        rsFD_Mem.Filter = "DATE =" & SYSDATE
        FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Button3.Text = "Passbook &Update" Then
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "PRINTED>0"
            If rsFD_Mem.RecordCount > 0 Then
                rsFD_Mem.MoveLast()
                lastLine = Int(rsFD_Mem.Fields("PRINTED").Value) + 1
                If lastLine > 24 Then lastLine = 1
            Else
                lastLine = 1
            End If
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "PRINTED<1"
            If rsFD_Mem.RecordCount > 0 Then
                MsgBox("There are [ " & rsFD_Mem.RecordCount & " ] entries, to be updated to passbook", MsgBoxStyle.Information, "Passbook Update")
                FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
                Button2.Enabled = False : Button6.Enabled = False : Button3.Text = "P&rint"
                Button1.Text = "Ca&ncel" : CheckBox1.Enabled = False
            Else
                MsgBox("There's nothing to update to Passbook.", MsgBoxStyle.Information, "Passbook Update")
            End If
        Else
            GroupBox2.Visible = True
            GroupBox1.Enabled = False
            TextBox3.Text = lastLine
            TextBox3.Focus()
            IsPassbookUpdate = True
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Public Function AddLine(ByVal LineNo As Integer) As String
        Dim lineStr As String = String.Empty
        For ctr As Integer = 1 To LineNo
            lineStr &= vbCrLf & " "
        Next
        Return lineStr
    End Function

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "&Close" Then
            Dim msg As String
            msg = MsgBox("Would you like to close the transaction window?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Close Transaction Window")
            If msg = vbYes Then
                ClsForm(Me, rsFD_Mem)
            End If
        Else
            GroupBox2.Visible = False : GroupBox1.Enabled = True
            Button2.Enabled = True : Button1.Text = "&Close" : CheckBox1.Enabled = True
            Button6.Enabled = True : Button3.Text = "Passbook &Update"
            TextBox3.Text = ""
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''#####PRINT FD LEDGER
        'Dim frmFD_Member As frmFD_Member
        'Dim frmFDS_main As frmFDS_Main
        'Dim dst As New DataTable("dstFD_Member")
        'Dim rpt As New Passbook
        'Dim ds As New DataSet
        'Dim txtKBCI As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txtKBCI")
        'Dim txtFLNAME As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txtFLNAME")

        'frmFD_Member = New frmFD_Member
        'frmFD_Member.MdiParent = frmFDS_main

        'txtKBCI.Text = Mid(SEL_KBCI_NO, 1, 2) & "-" & Mid(SEL_KBCI_NO, 3, 4) & "-" & Mid(SEL_KBCI_NO, 7, 1)
        'txtFLNAME.Text = SEL_FNAME
        'frmFD_Member.CrystalReportViewer1.ReportSource = rpt
        'frmFD_Member.Show()
        'SW = False
        'Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        Dim strng As String = String.Empty
        Dim CRDR As String = String.Empty
        Dim NameCRLF As String = AddLine(4) 'vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf & " "
        Dim MidCRLF As String = AddLine(5) 'vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf & " " '& vbCrLf & " "
        Dim jump As Boolean = False
        Dim x, lctr As Integer
        If e.KeyValue = Keys.Enter Then
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            lctr = CInt(TextBox3.Text)
            If lctr > 1 Then strng &= AddLine(2)
            For x = 1 To lctr
                If x = 12 And lctr > 12 Then
                    strng &= AddLine(6)
                    jump = True
                Else
                    strng &= AddLine(1)
                End If
            Next

            rsFD_Mem.MoveFirst()
            MsgBox("Please Insert Passbook, and Press OK.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
            For x = 0 To ListView1.Items.Count - 1
                Dim TransactionBalance As Decimal = 0
                If rsFD_Mem.Fields("DRCR").Value = "CR" Then


                    CRDR = "    " & DateValue(ListView1.Items(x).SubItems(2).Text).ToString("ddMMMyyyy").ToUpper.PadLeft(9, " ") & "     " & ListView1.Items(x).SubItems(4).Text.ToString.PadRight(4, " ") & _
                                "".PadRight(30, " ") & FormatNumber(ListView1.Items(x).SubItems(5).Text, 2).PadLeft(14, " ") & "".PadRight(5, " ") & FormatNumber(ListView1.Items(x).SubItems(6).Text, 2).PadLeft(14, " ")
                    TransactionBalance = CDbl(ListView1.Items(x).SubItems(6).Text) - CDbl(ListView1.Items(x).SubItems(5).Text)

                Else
                    CRDR = "    " & DateValue(ListView1.Items(x).SubItems(2).Text).ToString("ddMMMyyyy").ToUpper.PadLeft(9, " ") & "     " & ListView1.Items(x).SubItems(4).Text.ToString.PadRight(4, " ") & _
                            "".PadRight(11, " ") & FormatNumber(ListView1.Items(x).SubItems(5).Text, 2).PadLeft(14, " ") & "".PadRight(24, " ") & FormatNumber(ListView1.Items(x).SubItems(6).Text, 2).PadLeft(14, " ")
                    TransactionBalance = CDbl(ListView1.Items(x).SubItems(6).Text) + CDbl(ListView1.Items(x).SubItems(5).Text)
                End If
                Select Case lctr
                    Case 1
                        If strng <> "" Then strng &= " "

                        strng &= "                  " & Mid(Label3.Text, 1, 2) & "-" & Mid(Label3.Text, 3, 4) & "-" & Mid(Label3.Text, 7, 1) & "".PadRight(27, " ") & Label2.Text & vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf & _
                                "    BALANCE FORWARDED" & "".PadRight(50, " ") & FormatNumber(TransactionBalance, 2).PadLeft(14, " ")
                        lctr += 1
                    Case 13
                        If Not jump Then strng &= MidCRLF
                End Select

                strng &= vbCrLf & CRDR
                cn.Execute("UPDATE FD SET LPOSTED=" & lctr & ",TPOSTED=0 WHERE FD_ID='" & rsFD_Mem.Fields("FD_ID").Value & "'")
                rsFD_Mem.MoveNext()
                lctr += 1
                If lctr > 24 And (x < rsFD_Mem.RecordCount - 1) Then
                    print(strng)
                    lctr = 1
                    strng = String.Empty
                    jump = False
                    MsgBox("Please turn to next page, and Press OK.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
                End If
            Next x
            If lctr > 1 Then lctr -= 1
            If strng <> "" Then print(strng) : strng = ""
            MsgBox("Printing Done.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
            rsFD_Mem.Requery()
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "DATE =" & SYSDATE
            FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
            SW = True
        ElseIf e.KeyValue = Keys.Escape Then
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            TextBox3.Text = ""
        End If
        Button2.Enabled = True : Button1.Text = "&Close" : CheckBox1.Enabled = True
        Button6.Enabled = True : Button3.Text = "Passbook &Update"

        If PrintTransaction Then ClsForm(Me, rsFD_Mem)
    End Sub

    Private Sub ListView1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseUp

        If ListView1.Items.Count > 0 Then
            Dim cellLoc As MyCell
            cellLoc = WhichCell(sender, e.X, e.Y)
            Dim rowCtr As Integer = 0
            If sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(168) Or _
                sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(254) Then
                If bOWCheck(cellLoc.Row) = True Or _
                    sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Checked) Then
                    sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Unchecked)
                    cn.Execute(String.Format("UPDATE FD SET LPOSTED={0} WHERE FD_ID={1}", rowCtr.ToString, sender.Items(cellLoc.Row).SubItems(0).Text))
                    bOWCheck(cellLoc.Row) = False
                Else
                    'sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Checked)
                    'rowCtr = 1

                    'cn.Execute(String.Format("UPDATE FD SET LPOSTED={0} WHERE FD_ID={1}"), rowCtr.ToString, sender.Items(cellLoc.Row).SubItems(0).Text)
                    'bOWCheck(cellLoc.Row) = True
                End If
            End If
            sender.Select()

        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Sub UPDT_frmFDS_Main_DEntry_Tran()
        If SW = True Then

            rsFD_Mem.Requery()
            rsFD_Mem.Filter = "DATE =" & SYSDATE
            With SelectedMemberData
                Label3.Text = .KBCI_NO
                Label2.Text = String.Format("{0}, {1} {2}", .LNAME, .FNAME, .MI)
                Label7.Text = FormatNumber(.FD_AMOUNT, 2, TriState.True)
            End With
            CheckBox1.Checked = False
            FillLV(ListView1, Label5, rsFD_Mem, "0:0:100:110:67:112:100:285:0:80:0")
            If rsFD_Mem.RecordCount > 0 Then Button2.Enabled = True Else Button2.Enabled = False
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

    Sub print(ByVal str As String, Optional ByVal pSize As System.Drawing.Printing.PaperSize = Nothing)
        'Dim prtobj As New TextPrint(str, DEFPRINTER, pSize)
        RawPrinter.SendStringToPrinter(DEFPRINTER, Chr(27) & Chr(77) & Chr(15) & str & Chr(12))
    End Sub

End Class
