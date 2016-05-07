Imports FD.ViewModels
Imports FD.Common
Imports FD.BusinessLogic
Public Class frmMembersTransactionDialog
    Inherits System.Windows.Forms.Form

    Public Sub New(ByVal FdTransactionService As IFixedDepositTransactionService, ByVal MsgService As ILoginMessagePromptService, ByVal currUser As UserViewModel)
        CurrentUser = currUser
        _FixedDepositTransactionService = FdTransactionService
        _IMessageService = MsgService
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Textbox1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
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
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembersTransactionDialog))
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Textbox1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox3 = New System.Windows.Forms.Label
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
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(361, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Ca&ncel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 108)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(126, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Cash Deposit"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(126, 16)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Check Deposit"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(8, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(126, 16)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.Text = "Closing of Account"
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(8, 80)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(126, 16)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Adjustment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Textbox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
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
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(62, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 135)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Textbox1
        '
        Me.Textbox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Textbox1.Location = New System.Drawing.Point(376, 14)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(104, 21)
        Me.Textbox1.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"DR", "CR"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 40)
        Me.ComboBox1.MaxLength = 2
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox3.Location = New System.Drawing.Point(128, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 16)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label2.Size = New System.Drawing.Size(112, 16)
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
        Me.Label3.Size = New System.Drawing.Size(112, 16)
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
        Me.Label5.Location = New System.Drawing.Point(248, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Amount :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(376, 101)
        Me.TextBox5.MaxLength = 0
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
        Me.Label6.Location = New System.Drawing.Point(16, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(128, 102)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(104, 21)
        Me.TextBox6.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bank Code :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(128, 77)
        Me.TextBox7.MaxLength = 5
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(104, 21)
        Me.TextBox7.TabIndex = 1
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(376, 40)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 21)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(376, 76)
        Me.TextBox8.MaxLength = 10
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(104, 21)
        Me.TextBox8.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 77)
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
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(362, 63)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 22)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "&Transact"
        '
        'frmMembersTransactionDialog
        '
        Me.AcceptButton = Me.Button6
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(616, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMembersTransactionDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public trOPT As Integer = 0
    Public trTYP As String


    Private FdViewModel As FixedDepositViewModel


    Private _FixedDepositTransactionService As IFixedDepositTransactionService
    Public Property FixedDepositTransactionService() As IFixedDepositTransactionService
        Get
            Return _FixedDepositTransactionService
        End Get
        Set(ByVal value As IFixedDepositTransactionService)
            _FixedDepositTransactionService = value
        End Set
    End Property


    Private _IMessageService As ILoginMessagePromptService
    Public Property MessageService() As ILoginMessagePromptService
        Get
            Return _IMessageService
        End Get
        Set(ByVal value As ILoginMessagePromptService)
            _IMessageService = value
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




    Private Sub TextBox5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If TextBox5.Text <> "" Then If Not IsNumeric(TextBox5.Text) Then System.Windows.Forms.SendKeys.Send("{BS}") : Beep()
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim RGX As New RegularExpressions.Regex("^(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$")
        If RGX.IsMatch(TextBox5.Text) And TextBox5.Text.Replace(",", "").Replace(".", "").Length < 9 Then
            TextBox5.Text = FormatNumber(TextBox5.Text, 2)
        Else
            MsgBox("Please check the amount if it's correct and/or within the range.", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
        End If
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
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SW = False
        Me.Close()
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TextBox7.Text = TextBox7.Text.ToUpper
    End Sub
    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TextBox6.Text = TextBox6.Text.ToUpper
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim newBalance As Decimal = 0
        Dim updatedAmount As Decimal = 0
        Dim updatedBalance As Decimal = 0
        Dim fdBalance As Decimal = 0
        Dim x As String
        Dim getNewBalance As Boolean = False

        If TextBox6.Text.Trim = String.Empty Then MsgBox("Put remarks for this transaction.") : Exit Sub
        Select Case trOPT
            Case TransactionCode.CheckDeposit
                If TextBox7.Text.Trim = "" Then MsgBox("Please set the corresponding Bank Code for the check.") : Exit Sub
                If TextBox8.Text.Trim = "" Then MsgBox("Please set the corresponding Check No. of the check.") : Exit Sub
                TextBox6.Text = "CHK:" & TextBox7.Text.ToString.ToUpper & "-" & TextBox8.Text.ToString
            Case TransactionCode.Adjustment
                If ComboBox1.Text <> "" Then trTYP = ComboBox1.Text Else MsgBox("Please select a DR/CR code.", MsgBoxStyle.Information, "Error") : Exit Sub
            Case Else
                If Round(CDbl(TextBox5.Text), 2) < 1 Then MsgBox("Please check the amount.") : Exit Sub
        End Select
        If Round(CDbl(TextBox5.Text), 2) < 1 Then MsgBox("Please input a valid amount.", MsgBoxStyle.Information, "Invalid Amount") : Exit Sub
        If trTYP = "CR" Then
            BALANCE = Round(CDbl(SelectedMemberData.FD_AMOUNT), 2) + Round(CDbl(TextBox5.Text), 2)
        Else
            BALANCE = Round(CDbl(SelectedMemberData.FD_AMOUNT), 2) - Round(CDbl(TextBox5.Text), 2)
        End If
        If Round(CDbl(BALANCE), 2) < 0 Then MsgBox("Unable to process transaction, ending balance is less than [0.00]", MsgBoxStyle.Critical, "Transaction Error") : Exit Sub
        If Round(CDbl(TextBox5.Text)) > 99999999.99 Or Round(CDbl(BALANCE)) > 99999999.99 Then MsgBox("Unable to process transaction, maximum balance / amount is reached.", MsgBoxStyle.Critical, "Transaction Error") : Exit Sub

        Dim msg2 As String = MsgBox("Would you like to Post the transactions to the master file?", vbQuestion & vbYesNo, "Commit Transaction")
        If msg2 = vbYes Then
            If trOPT = TransactionCode.Adjustment Then
                Dim fdMemId As ADODB.Recordset = New ADODB.Recordset
                Dim fdMem As ADODB.Recordset = New ADODB.Recordset


                fdMemId.Open("SELECT FD.REF AS REF FROM FD WHERE [DATE]> '" & Textbox1.Text.ToUpper & "' ", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)

                If fdMemId.RecordCount > 0 Then
                    x = String.Format("'{0}'", Trim(fdMemId.GetString(, , , " ")).Replace(" ", "','"))

                    fdMem.Open("SELECT FD.FD_ID,FD.KBCI_NO,FD.DATE,FD.REF AS REFERENCE,TC.TR_CODE AS CODE,isnull(FD." & _
                                "AMOUNT,0)AS AMOUNT,isnull(FD.BALANCE,0)AS BALANCE,FD.RMK AS REMARKS,TPOSTED,LPOSTED," & _
                                "DRCR FROM FD INNER JOIN TRANCODE TC ON FD.TRAN_CODE=TC.TR_ID WHERE FD.REF IN(" & x & ")" & _
                                "ORDER BY FD.DATE,FD.FD_ID,FD.REF", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                    If fdMem.RecordCount > 0 Then

                        With fdMem

                            If .Fields("DRCR").Value = "CR" Then
                                BALANCE = .Fields("BALANCE").Value - .Fields("AMOUNT").Value

                            Else
                                BALANCE = .Fields("BALANCE").Value + .Fields("AMOUNT").Value

                            End If
                            If trTYP = "CR" Then
                                BALANCE = Round(BALANCE + CDbl(TextBox5.Text), 2)
                            Else
                                BALANCE = Round(BALANCE - CDbl(TextBox5.Text), 2)
                            End If
                            newBalance = BALANCE
                            Do Until .EOF
                                If .Fields("DRCR").Value = "DR" Then
                                    updatedBalance = newBalance - .Fields("AMOUNT").Value
                                    newBalance = updatedBalance
                                Else
                                    updatedBalance = newBalance + .Fields("AMOUNT").Value
                                    newBalance = updatedBalance
                                End If
                                cn.Execute("UPDATE FD SET [BALANCE]=" & updatedBalance & ",[TPOSTED]=0 WHERE [REF]='" & .Fields("REFERENCE").Value & "'")
                                .MoveNext()
                            Loop
                        End With
                        getNewBalance = True
                    End If
                End If
            End If
            Dim qry As String = CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                     "VALUES('" & SelectedMemberData.KBCI_NO & "','" & trOPT & "','" & Textbox1.Text.ToUpper & "','" & TextBox2.Text.ToUpper & "'," & Round(CDbl(TextBox5.Text), 2) & "," & BALANCE & ",'" & TextBox6.Text.ToUpper & "','" & Textbox1.Text.ToUpper & "','" & CurrentUser.UserName & "',0,'" & trTYP & "','" & TextBox7.Text.ToUpper & "','" & TextBox8.Text.ToUpper & "',1,0)")
            cn.Execute(qry)

            If getNewBalance Then fdBalance = updatedBalance Else fdBalance = BALANCE
            cn.Execute("UPDATE MEMBERS SET FD_AMOUNT=" & fdBalance & " WHERE KBCI_NO='" & SelectedMemberData.KBCI_NO & "'")
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub PopulateViewModel()
        With FdViewModel
            .KBCI_NO = SelectedMemberData.KBCI_NO
            .TRAN_CODE = trOPT
            .DATE = Textbox1.Value
            .REF = TextBox2.Text.ToUpper
            .AMOUNT = Round(CDbl(TextBox5.Text), 2)
            .BALANCE = BALANCE
            .RMK = TextBox6.Text.ToUpper
            .ADD_DATE = Textbox1.Value
            .USER = CurrentUser.UserName
            .LPOSTED = LedgerPostingStatus.NotPosted
            .DRCR = trTYP
            .BANK_CODE = TextBox7.Text.ToUpper
            .CHECKNO = TextBox8.Text.ToUpper
            .TPOSTED = True
            .TREVERSED = False
        End With

    End Sub
    Private Sub TRANSACT()
        Dim SYDATE As Date = SYSDATE
        Dim sqNum As Integer
        If trOPT = 3 Then
            TextBox7.Enabled = True : TextBox8.Enabled = True : TextBox6.Enabled = False
        Else
            TextBox7.Enabled = False : TextBox8.Enabled = False : TextBox6.Enabled = True
        End If
        If trOPT = 2 Then TextBox5.Enabled = False Else TextBox5.Enabled = True
        If trOPT = 4 Then ComboBox1.Visible = True : Textbox1.Enabled = True Else ComboBox1.Visible = False : Textbox1.Enabled = False
        clrTXT(Me)
        TextBox5.Text = "0.00"
        GroupBox1.Enabled = True

        TextBox3.Text = rsTRANCODE.Find(Function(x) x.TR_ID = trOPT).TR_CODE
        Textbox1.Text = SYSDATE
        TextBox4.Text = trTYP
        If trOPT = 2 Then TextBox5.Text = FormatNumber(Val(SelectedMemberData.FD_AMOUNT), 2)
        rsFD_Mem.Filter = adFilterNone
        rsFD_Mem.Filter = "DATE =" & SYSDATE
        sqNum = rsFD_Mem.RecordCount + 1
        TextBox2.Text = String.Format("{0}{1}", SYDATE.ToString("yyyyMMdd"), Now.ToString("HHmmss"))
        rsFD_Mem.Filter = adFilterNone


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmMembersTransactionDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FdViewModel = New FixedDepositViewModel()
        SW = False
    End Sub

End Class
