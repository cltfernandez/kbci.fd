Public Class frmFDS_Main_DEntry
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDS_Main_DEntry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 624)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(254, Byte), CType(203, Byte))
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(80, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "MEMBER SELECTION WINDOW"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 50)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 592)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Loading..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(16, 160)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(864, 424)
        Me.ListView1.TabIndex = 10
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MEMBERS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(768, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Close"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 80)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KBCI No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(88, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(616, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BALANCE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NAME :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(712, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 21)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(88, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 21)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(32, 152)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(688, 24)
        Me.DataGrid1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(648, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Se&lect"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmFDS_Main_DEntry
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(914, 635)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDS_Main_DEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim eload As Boolean
    Dim mTXT As TextBox
    Dim fField As String
    Public frmFDS_Main_DEntry_Tran As frmFDS_Main_DEntry_Tran


    Private Sub TextBox1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp

        'On Error GoTo err1
        mTXT = TextBox1 : fField = "LNAME"
        If TextBox1.Text <> "" Then
            If ((e.KeyValue > 31 And e.KeyValue < 128) Or e.KeyValue = 8) Then
                eload = False
                If Timer1.Enabled = True Then Timer1.Stop()
                Timer1.Enabled = True
            End If
        Else
            If eload = False Then
                If Timer1.Enabled = True Then Timer1.Stop()
                Timer1.Enabled = True
                eload = True
            End If
        End If
        'If (e.KeyValue > 31 And e.KeyValue < 128) Or e.KeyValue = 8 Then
        '    rsMEMBERS.Filter = ADODB.FilterGroupEnum.adFilterNone
        '    If TextBox1.Text.Trim <> "" Then
        '        rsMEMBERS.Filter = "LNAME like *" & TextBox1.Text.Trim & "*"
        '        FillLV(ListView1, Label5, rsMEMBERS, "0:100:222:241:38:136:100:0")
        '    End If
        'End If
err1:
        If Err.Number <> 0 Then
            rsMEMBERS.Filter = ADODB.FilterGroupEnum.adFilterNone
            Resume err1
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedIndices.Count > 0 Then
            TextBox3.Text = Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text, 1, 2) & "-" & Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text, 3, 4) & "-" & Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text, 7, 1)
            TextBox1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text & ", " & _
                ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text & " " & _
                ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text & "."
            If Trim(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(7).Text) <> "NULL" Then TextBox2.Text = FormatNumber(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(7).Text, 2) Else TextBox2.Text = "0.00"
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.SelectionStart = 0 : TextBox1.SelectionLength = Len(TextBox1.Text) + 1
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'On Error GoTo ERRLOG

        If ListView1.SelectedItems.Count > 0 Then
            Dim KBCIN As String = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            frmFDS_Main_DEntry_Tran = New frmFDS_Main_DEntry_Tran
            rsFD_Mem.Open("SELECT * FROM FD where kbci_no='" & KBCIN & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            rsFD_Mem.Filter = adFilterNone
            With rsMEMBERS
                .MoveFirst()
                .Find("KBCI_NO=" & KBCIN.Trim, , SearchDirectionEnum.adSearchForward)
                lcn.Execute("DELETE FROM MEMBERS")
                'WLOG(CleanSTR("INSERT INTO MEMBERS(KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT) " & _
                '                         "VALUES(" & .Fields("KBCI_NO").Value & ",'" & .Fields("KBCI_NO").Value & "','" & .Fields("LNAME").Value & "','" & .Fields("FNAME").Value & "','" & .Fields("MI").Value & "','" & .Fields("MEM_STAT").Value & "','" & .Fields("MEM_DATE").Value & "'," & .Fields("FD_AMOUNT").Value & ")"), App_Path() & "SQLTRAN.log")
                lcn.Execute(CleanSTR("INSERT INTO MEMBERS(KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT) " & _
                                         "VALUES(" & .Fields("KBCI_NO").Value & ",'" & .Fields("KBCI_NO").Value & "','" & .Fields("LNAME").Value & "','" & .Fields("FNAME").Value & "','" & .Fields("MI").Value & "','" & .Fields("MEM_STAT").Value & "','" & .Fields("MEM_DATE").Value & "'," & .Fields("FD_AMOUNT").Value & ")"))
                rsMEMBERS_L.Open("SELECT KBCI_ID,KBCI_NO,LNAME,FNAME,MI,MEM_STAT,MEM_DATE,FD_AMOUNT FROM Members ", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
                frmFDS_Main_DEntry_Tran.Label3.Text = .Fields("KBCI_NO").Value
                frmFDS_Main_DEntry_Tran.Label2.Text = .Fields("LNAME").Value & ", " & .Fields("FNAME").Value & " " & .Fields("MI").Value & "."
                frmFDS_Main_DEntry_Tran.Label7.Text = FormatNumber(.Fields("FD_AMOUNT").Value, 2, TriState.True)
                frmFDS_Main_DEntry_Tran.ShowDialog()

                'FillListViewWithAddRange(ListView1, Label5, rsMEMBERS, "0:100:222:241:38:136:100:0")
                If SW = True Then rsMEMBERS.Requery() : rsMEMBERS.Filter = ADODB.FilterGroupEnum.adFilterNone : FillLV(ListView1, Label5, rsMEMBERS, "0:100:222:241:38:136:100:0") : SW = False
            End With
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClsForm(Me, rsMEMBERS)
    End Sub

    Private Sub frmFDS_Main_DEntry_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FillLV(ListView1, Label5, rsMEMBERS, "0:100:222:241:38:136:100:0")
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        mTXT = TextBox3 : fField = "KBCI_NO"
        If TextBox3.Text <> "" Then
            If ((e.KeyValue > 31 And e.KeyValue < 128) Or e.KeyValue = 8) Then
                eload = False
                If Timer1.Enabled = True Then Timer1.Stop()
                Timer1.Enabled = True
            End If
        Else
            If eload = False Then
                If Timer1.Enabled = True Then Timer1.Stop()
                Timer1.Enabled = True
                eload = True
            End If
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        rsMEMBERS.Filter = ADODB.FilterGroupEnum.adFilterNone
        If mTXT.Text.Trim <> "" Then
            rsMEMBERS.Filter = fField & " like '*" & mTXT.Text.Trim & "*'"
        End If
        FillLV(ListView1, Label5, rsMEMBERS, "0:100:222:241:38:136:100:0")
        If rsMEMBERS.RecordCount > 0 Then ListView1.Focus()
        Timer1.Enabled = False
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub frmFDS_Main_DEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmFDS_Main_DEntry_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If rsMEMBERS.State = 1 Then rsMEMBERS.Close()
        Me.Dispose()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Button2.PerformClick()
    End Sub
End Class
