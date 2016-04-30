Public Class frmFDS_Main_DEntry_Tran_Add
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDS_Main_DEntry_Tran_Add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"DR", "CR"})
        Me.ComboBox1.Location = New System.Drawing.Point(144, 40)
        Me.ComboBox1.MaxLength = 2
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox3.Location = New System.Drawing.Point(144, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 16)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(344, 176)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(136, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "&Transact"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Deposit Code :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transaction Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reference No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DR/CR Code :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Amount :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(376, 112)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 21)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.Text = "0.00"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(144, 144)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(336, 21)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bank Code :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(144, 88)
        Me.TextBox7.MaxLength = 5
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(64, 21)
        Me.TextBox7.TabIndex = 1
        Me.TextBox7.Text = ""
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(344, 88)
        Me.TextBox8.MaxLength = 10
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(136, 21)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Check No :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox4.Location = New System.Drawing.Point(144, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 16)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = "Label10"
        Me.TextBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(376, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 16)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "Label10"
        Me.TextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(376, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 16)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "Label10"
        Me.TextBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 64)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Cash Deposit"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Check Deposit"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(160, 16)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(144, 16)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.Text = "Closing of Account"
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(160, 40)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(144, 16)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Adjustment"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(352, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ca&ncel"
        '
        'frmFDS_Main_DEntry_Tran_Add
        '
        Me.AcceptButton = Me.Button6
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(506, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDS_Main_DEntry_Tran_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public trOPT As Integer = 0
    Public trTYP As String

    Private Sub TRANSACT()
        Dim SYDATE As Date = SYSDATE
        Dim sqNum As Integer
        If trOPT = 3 Then
            TextBox7.Enabled = True : TextBox8.Enabled = True : TextBox6.Enabled = False
        Else
            TextBox7.Enabled = False : TextBox8.Enabled = False : TextBox6.Enabled = True
        End If
        If trOPT = 2 Then TextBox5.Enabled = False Else TextBox5.Enabled = True
        If trOPT = 4 Then ComboBox1.Visible = True Else ComboBox1.Visible = False
        clrTXT(Me)
        GroupBox1.Enabled = True
        rsTRANCODE.Find("TR_ID=" & trOPT)
        rsFD_Mem.Filter = adFilterNone
        rsFD_Mem.Filter = "DATE =" & SYDATE

        TextBox3.Text = rsTRANCODE.Fields("TR_CODE").Value
        TextBox1.Text = sysdate
        TextBox4.Text = trTYP
        If trOPT = 2 Then TextBox5.Text = FormatNumber(Val(rsMEMBERS_L.Fields("FD_AMOUNT").Value), 2)
        sqNum = rsFD_Mem.RecordCount + 1
        TextBox2.Text = SYDATE.ToString("yyyyMMdd") & sqNum.ToString("D2")

        rsFD_Mem.Filter = adFilterNone
        rsTRANCODE.MoveFirst()


    End Sub


    Private Sub TextBox5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyUp
        If TextBox5.Text <> "" Then If Not IsNumeric(TextBox5.Text) Then System.Windows.Forms.SendKeys.Send("{BS}") : Beep()
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub
    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        If RadioButton4.Checked = True Then trOPT = 4 : trTYP = "  "
        TRANSACT()
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked = True Then trOPT = 2 : trTYP = "DR"
        TRANSACT()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True Then trOPT = 3 : trTYP = "CR"
        TRANSACT()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then trOPT = 1 : trTYP = "CR"
        TRANSACT()
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SW = False
        Me.Close()
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.Text = TextBox7.Text.ToUpper
    End Sub
    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox6.Text = TextBox6.Text.ToUpper
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frmFDS_Main_DEntry_Tran As New frmFDS_Main_DEntry_Tran
        Select Case trOPT
            Case 1
                If TextBox6.Text.Trim = "" Then MsgBox("Put remarks for this transaction.") : Exit Sub
            Case 2
                If TextBox6.Text.Trim = "" Then MsgBox("Put remarks for this transaction.") : Exit Sub
            Case 3
                If TextBox7.Text.Trim = "" Then MsgBox("Please set the corresponding Bank Code for the check.") : Exit Sub
                If TextBox8.Text.Trim = "" Then MsgBox("Please set the corresponding Check No. of the check.") : Exit Sub
                TextBox6.Text = "CHK:" & TextBox7.Text.ToString.ToUpper & "-" & TextBox8.Text.ToString
            Case 4
                If ComboBox1.Text <> "" Then trTYP = ComboBox1.Text Else MsgBox("Please select a DR/CR code.", MsgBoxStyle.Information, "Error")
            Case Else
                If Decimal.Round(TextBox5.Text, 2) < 1 Then MsgBox("Please check the amount.") : Exit Sub
        End Select
        If Decimal.Round(TextBox5.Text, 2) < 1 Then MsgBox("Please input a valid amount.", MsgBoxStyle.Information, "Invalid Amount") : Exit Sub
        If trTYP = "CR" Then
            BALANCE = Decimal.Round(rsMEMBERS_L.Fields("FD_AMOUNT").Value, 2) + Decimal.Round(TextBox5.Text, 2)
        Else
            BALANCE = Decimal.Round(rsMEMBERS_L.Fields("FD_AMOUNT").Value, 2) - Decimal.Round(TextBox5.Text, 2)
        End If
        If Decimal.Round(BALANCE, 2) < 0 Then MsgBox("Unable to process transaction, ending balance is less than [0.00]", MsgBoxStyle.Critical, "Transaction Error") : Exit Sub

        'WLOG(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
        '                 "VALUES('" & rsMEMBERS_L.Fields("KBCI_NO").Value & "','" & trOPT & "','" & TextBox1.Text.ToUpper & "','" & TextBox2.Text.ToUpper & "'," & Decimal.Round(TextBox5.Text, 2) & "," & BALANCE & ",'" & TextBox6.Text.ToUpper & "','" & TextBox1.Text.ToUpper & "','" & CLUSER & "',0,'" & trTYP & "','" & TextBox7.Text.ToUpper & "','" & TextBox8.Text.ToUpper & "',0,0)"), App_Path() & "SQLTRAN.log")
        lcn.Execute(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                         "VALUES('" & rsMEMBERS_L.Fields("KBCI_NO").Value & "','" & trOPT & "','" & TextBox1.Text.ToUpper & "','" & TextBox2.Text.ToUpper & "'," & Decimal.Round(TextBox5.Text, 2) & "," & BALANCE & ",'" & TextBox6.Text.ToUpper & "','" & TextBox1.Text.ToUpper & "','" & CLUSER & "',0,'" & trTYP & "','" & TextBox7.Text.ToUpper & "','" & TextBox8.Text.ToUpper & "',0,0)"))
        'WLOG("UPDATE MEMBERS SET FD_AMOUNT=" & BALANCE & " WHERE KBCI_NO='" & rsMEMBERS_L.Fields("KBCI_NO").Value & "'", App_Path() & "SQLTRAN.log")
        lcn.Execute("UPDATE MEMBERS SET FD_AMOUNT=" & BALANCE & " WHERE KBCI_NO='" & rsMEMBERS_L.Fields("KBCI_NO").Value & "'")
        SW = True
        rsMEMBERS_L.Requery()
        Me.Close()
    End Sub

End Class
