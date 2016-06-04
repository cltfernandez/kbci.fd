Imports FD.Common
Imports FD.Common.Utilities
Imports FD.ViewModels
Imports FD.BusinessLogic
Imports System.Collections.Generic

Public Class frmMembersTransactionList
    Inherits System.Windows.Forms.Form

    Public Sub New(ByVal selectedMember As MembersBOVM, ByVal fdTransactionService As IFixedDepositTransactionService, ByVal currentUser As UserViewModel)
        _CurrentUser = currentUser
        _MemberData = selectedMember
        _FixedDepositTxnSvc = fdTransactionService
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 403)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(739, 24)
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
        Me.ListView1.Size = New System.Drawing.Size(864, 315)
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
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(720, 370)
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
        Me.Button6.Location = New System.Drawing.Point(394, 370)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 25)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "A&dd Transaction"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(557, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Passbook &Update"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(586, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "BALANCE :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(586, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "KBCI No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 233)
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
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(725, 506)
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
        Me.Label9.Size = New System.Drawing.Size(885, 29)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "..."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(640, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(250, 14)
        Me.DataGridView1.TabIndex = 31
        Me.DataGridView1.Visible = False
        '
        'frmMembersTransactionList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(898, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "frmMembersTransactionList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public TransactionDialogForm As frmMembersTransactionDialog
    Dim lastLine As Integer
    Private PrintTransaction As Boolean = False
    Private IsPassbookUpdate As Boolean = False
    Private PrintLine As Integer    

    Private _CurrentUser As UserViewModel
    Public Property CurrentUser() As UserViewModel
        Get
            Return _CurrentUser
        End Get
        Set(ByVal value As UserViewModel)
            _CurrentUser = value
        End Set
    End Property

    Private _MemberData As MembersBOVM
    Public Property MemberData() As MembersBOVM
        Get
            Return _MemberData
        End Get
        Set(ByVal value As MembersBOVM)
            _MemberData = value
        End Set
    End Property


    Private _FixedDepositTxnSvc As IFixedDepositTransactionService
    Public Property FixedDepositTxnSvc() As IFixedDepositTransactionService
        Get
            Return _FixedDepositTxnSvc
        End Get
        Set(ByVal value As IFixedDepositTransactionService)
            _FixedDepositTxnSvc = value
        End Set
    End Property



    Private MemberTransactionList As List(Of FixedDepositViewModel)

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click        
        Using MemberTransactionDialogForm As New frmMembersTransactionDialog(New FixedDepositTransactionService, New MessagePromptService, CurrentUser, MemberData)
            Dim result As DialogResult = MemberTransactionDialogForm.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                RefreshTransactionList()
                RefreshFormData()
                PrintPassbook()
            End If
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        RefreshTransactionList()
        PopulateListView(ListView1, GetGridViewDataFromObject(GetTransactionList(CheckBox1.Checked), DataGridView1), ColumnWidthDefinition.TransactionList, ColumnAlignmentDefinition.TransactionList)
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
        Dim msg As String        

        Dim currentTransactions As List(Of FixedDepositViewModel) = GetTransactionList(False)
        If currentTransactions.Any Then
            msg = MsgBox(GetGlobalResourceString("ReverseTransactionPrompt"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetGlobalResourceString("FixedDepositTransaction"))
            If msg = vbYes Then
                Dim ReversalTransaction As FixedDepositViewModel = MemberTransactionList.OrderByDescending(Function(x) x.Id).First
                With ReversalTransaction
                    .TransactionCode = TransactionCode.Reversal
                    .Remarks = String.Format("REVERSAL:{0}", .ReferenceNumber)
                    .ReferenceNumber = GenerateReferenceNumber(SYDATE)
                    .TransactionDate = SYSDATE
                    .DateAdded = DateValue(Now)
                    If .TransactionType = TransactionType.Credit Then
                        .TransactionType = TransactionType.Debit
                        .Balance = .Balance - .TransactedAmount
                    Else
                        .TransactionType = TransactionType.Credit
                        .Balance = .Balance + .TransactedAmount
                    End If
                End With
                Dim TxnResult As RecordUpdateResult = FixedDepositTxnSvc.Save(ReversalTransaction)
                RefreshTransactionList()
                RefreshFormData()
            End If
        Else
            MsgBox(GetGlobalResourceString("NoTransactionForReversal"), MsgBoxStyle.Information, GetGlobalResourceString("FixedDepositTransaction"))
        End If
        Me.DialogResult = Nothing
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim msg As DialogResult
        If Button3.Text = GetGlobalResourceString("PassbookUpdateButton") Then
            SetPrintLine()
            Dim UnPrintedTxn As Integer = MemberTransactionList.Where(Function(x) x.PrintLineNumber < 1).Count()
            If UnPrintedTxn > 0 Then
                MsgBox(String.Format(GetGlobalResourceString("PassbookUpdatePrompt"), UnPrintedTxn), MsgBoxStyle.Information, GetGlobalResourceString("FixedDepositTransaction"))                
                GetTransactionList(True)
                Button2.Enabled = False : Button6.Enabled = False : Button3.Text = GetGlobalResourceString("PrintButton")
                Button1.Text = GetGlobalResourceString("CancelButton") : CheckBox1.Enabled = False
            Else
                MsgBox(GetGlobalResourceString("NoTransactionFound"), MsgBoxStyle.Information, GetGlobalResourceString("FixedDepositTransaction"))

            End If
        Else
            GroupBox2.Visible = True
            GroupBox1.Enabled = False
            TextBox3.Text = lastLine
            TextBox3.Focus()
            IsPassbookUpdate = True
        End If
        Me.DialogResult = Nothing
    End Sub

    Public Function AddLine(ByVal LineNo As Integer) As String
        Dim lineStr As String = String.Empty
        For ctr As Integer = 1 To LineNo
            lineStr &= vbCrLf & " "
        Next
        Return lineStr
    End Function

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text <> GetGlobalResourceString("CloseButton") Then
            GroupBox2.Visible = False : GroupBox1.Enabled = True
            Button2.Enabled = True : Button1.Text = GetGlobalResourceString("CloseButton") : CheckBox1.Enabled = True
            Button6.Enabled = True : Button3.Text = GetGlobalResourceString("PassbookUpdateButton")
            TextBox3.Text = ""
            Me.DialogResult = Windows.Forms.DialogResult.OK
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

    Private Sub TextBox3_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        Dim strng As String = String.Empty
        Dim TransactionEntry As String = String.Empty
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

            MsgBox(GetGlobalResourceString("PrintPassbookPrompt"), MsgBoxStyle.Exclamation, "")
            Me.DialogResult = Nothing
            Dim UnprintedTransaction As List(Of FixedDepositViewModel) = MemberTransactionList.Where(Function(z) z.PrintLineNumber < 1).ToList
            x = 0
            For Each Txn As FixedDepositViewModel In UnprintedTransaction
                Dim TransactionBalance As Decimal = 0
                With Txn
                    If .TransactionType = TransactionType.Credit Then
                        TransactionEntry = String.Format("    {0}     {1}{2}{3}{4}{5}", _
                                            .TransactionDate.ToString.ToUpper.PadLeft(9, " "), _
                                            .TransactionCode.ToUpper.PadRight(4, " "), _
                                            String.Empty.PadRight(30, " "), _
                                            FormatNumber(.TransactedAmount, 2).ToString.PadLeft(14, " "), _
                                            String.Empty.PadRight(5, " "), _
                                            FormatNumber(.Balance, 2).ToString.PadLeft(14, " "))

                        TransactionBalance = .Balance - .TransactedAmount
                    Else
                        TransactionEntry = String.Format("    {0}     {1}{2}{3}{4}{5}", _
                                            .TransactionDate.ToString.ToUpper.PadLeft(9, " "), _
                                            .TransactionCode.ToUpper.PadRight(4, " "), _
                                            String.Empty.PadRight(11, " "), _
                                            FormatNumber(.TransactedAmount, 2).ToString.PadLeft(14, " "), _
                                            String.Empty.PadRight(24, " "), _
                                            FormatNumber(.Balance, 2).ToString.PadLeft(14, " "))
                        TransactionBalance = .Balance + .TransactedAmount

                    End If
                    Select Case lctr
                        Case 1
                            If strng <> "" Then strng &= " "

                            strng &= String.Format("                  {0}{1}{2}{3}    BALANCE FORWARDED{4}{5}", _
                                                    FormatKBCINo(.KbciNumber), _
                                                    String.Empty.PadRight(27, " "), _
                                                    Label2.Text, _
                                                    vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf, _
                                                    String.Empty.PadRight(50, " "), _
                                                    FormatNumber(TransactionBalance, 2).PadLeft(14, " "))
                            lctr += 1
                        Case 13
                            If Not jump Then strng &= MidCRLF
                    End Select

                    strng &= vbCrLf & TransactionEntry
                    'TODO:Sack this line!
                    cn.Execute("UPDATE FD SET LPOSTED=" & lctr & ",TPOSTED=0 WHERE FD_ID='" & .Id & "'")
                    lctr += 1
                    If lctr > 24 And (x < UnprintedTransaction.Count - 1) Then
                        print(strng)
                        lctr = 1
                        strng = String.Empty
                        jump = False
                        MsgBox(GetGlobalResourceString("TurnPassbookPrompt"), MsgBoxStyle.Exclamation, GetGlobalResourceString("FixedDepositTransaction"))
                    End If
                End With
                x += 1
            Next

            If lctr > 1 Then lctr -= 1
            If strng <> "" Then print(strng) : strng = ""
            MsgBox(GetGlobalResourceString("PrintingDone"), MsgBoxStyle.Exclamation, GetGlobalResourceString("FixedDepositTransaction"))
            RefreshFormData()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf e.KeyValue = Keys.Escape Then
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            TextBox3.Text = ""
        End If
        Button2.Enabled = True : Button1.Text = GetGlobalResourceString("CloseButton") : CheckBox1.Enabled = True
        Button6.Enabled = True : Button3.Text = GetGlobalResourceString("PassbookUpdateButton")

        If PrintTransaction Then Me.DialogResult = Windows.Forms.DialogResult.OK
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
                    FixedDepositTxnSvc.UpdatedPassbookPosting(sender.Items(cellLoc.Row).SubItems(0).Text, rowCtr.ToString)                    
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


    Private Sub frmMembersTransactionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Error GoTo errHand
        RefreshTransactionList()
        RefreshFormData()
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Not MemberTransactionList.Any Then
            MsgBox(GetGlobalResourceString("NoTransactionFound"), MsgBoxStyle.Exclamation, GetGlobalResourceString("FixedDepositTransaction"))            
        End If

errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CurrentUser.UserName)
        End If
    End Sub

#Region "Private Methods"
    Private Sub RefreshFormData()

        With MemberData
            Label3.Text = FormatKBCINo(.KBCI_NO)
            Label2.Text = String.Format("{0}, {1} {2}", .LNAME, .FNAME, .MI)
            Label7.Text = FormatNumber(.FD_AMOUNT, 2, TriState.True)
        End With

        CheckBox1.Checked = False
        PopulateListView(ListView1, GetGridViewDataFromObject(GetTransactionList(CheckBox1.Checked), DataGridView1), ColumnWidthDefinition.TransactionList, ColumnAlignmentDefinition.TransactionList)
        If ListView1.Items.Count > 0 Then Button2.Enabled = True Else Button2.Enabled = False
    End Sub

    Private Sub print(ByVal str As String, Optional ByVal pSize As System.Drawing.Printing.PaperSize = Nothing)
        RawPrinter.SendStringToPrinter(DEFPRINTER, Chr(27) & Chr(77) & Chr(15) & str & Chr(12))
    End Sub

    Private Function GetTransactionList(ByVal ShowHistory As Boolean) As List(Of FixedDepositViewModel)
        If ShowHistory Then
            Return MemberTransactionList
        End If
        Return MemberTransactionList.Where(Function(x) x.TransactionDate = SYSDATE).ToList
    End Function
    Private Sub RefreshTransactionList()
        MemberTransactionList = FixedDepositTxnSvc.GetMemberTransactions(MemberData.KBCI_NO)        
    End Sub

    Private Function SetPrintLine() As Integer
        PrintLine = MemberTransactionList.Select(Function(x) x.PrintLineNumber).Max() + 1
        If PrintLine > 24 Then PrintLine = 1
    End Function


    Private Sub PrintPassbook()
        SetPrintLine()
        Dim UnPrintedTxn As Integer = MemberTransactionList.Where(Function(x) x.PrintLineNumber < 1).Count()
        If MsgBox(String.Format(GetGlobalResourceString("PrintTransactionOnPassbook"), UnPrintedTxn), vbQuestion & vbYesNo, GetGlobalResourceString("FixedDepositTransaction")) = vbYes Then
            PopulateListView(ListView1, GetGridViewDataFromObject(GetTransactionList(CheckBox1.Checked), DataGridView1), ColumnWidthDefinition.TransactionList, ColumnAlignmentDefinition.TransactionList)
            GroupBox2.Visible = True
            GroupBox1.Enabled = False
            TextBox3.Text = PrintLine
            TextBox3.Focus()
            PrintTransaction = True
        End If
    End Sub


#End Region

    
End Class
