Imports FD.Common
Imports FD.Common.Utilities
Imports FD.DataAccessObject
Imports FD.ViewModels
Imports FD.BusinessLogic
Public Class frmDividendPatronageRefundProcessing

    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal DivPatRefSvc As IDividendPatronageRefundService, _
                   ByVal MsgSvc As IDividendPatronageMessagePromptService, _
                   ByVal CurrUser As UserViewModel, _
                   ByVal CtrlSysDate As DateTime)
        _IMessageService = MsgSvc
        _IDivPatRefundService = DivPatRefSvc
        _CurrentUser = CurrUser        
        _CtrlSystemDate = CtrlSysDate
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
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bgwDividendWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwPatronageRefundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.bgwDividendWorker = New System.ComponentModel.BackgroundWorker
        Me.bgwPatronageRefundWorker = New System.ComponentModel.BackgroundWorker
        Me.lblProgress = New System.Windows.Forms.Label
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "YEAR :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(96, 40)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(48, 21)
        Me.NumericUpDown2.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(96, 16)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(88, 21)
        Me.NumericUpDown1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "QUARTER :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 339)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Gray
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(8, 149)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(280, 16)
        Me.CheckBox3.TabIndex = 49
        Me.CheckBox3.Text = "PATRONAGE REFUND PROCESSING"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Gray
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(8, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(280, 16)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Text = "CASH DIVIDEND PROCESSING"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 157)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Interest Range"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(136, 40)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker5.TabIndex = 26
        Me.DateTimePicker5.Tag = "*Enter Birth Date"
        Me.DateTimePicker5.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "DATE TO:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(136, 16)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker3.TabIndex = 24
        Me.DateTimePicker3.Tag = "*Enter Birth Date"
        Me.DateTimePicker3.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "DATE FROM:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Percentage:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(248, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "PR YEAR:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(144, 16)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker4.TabIndex = 24
        Me.DateTimePicker4.Tag = "*Enter Birth Date"
        Me.DateTimePicker4.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.DecimalPlaces = 2
        Me.NumericUpDown6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown6.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown6.Location = New System.Drawing.Point(144, 41)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(104, 21)
        Me.NumericUpDown6.TabIndex = 23
        Me.NumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 111)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Percentage:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(248, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "FD cut-off date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(144, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker2.TabIndex = 16
        Me.DateTimePicker2.Tag = "*Enter Birth Date"
        Me.DateTimePicker2.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Tag = "*Enter Birth Date"
        Me.DateTimePicker1.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Processing date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.DecimalPlaces = 2
        Me.NumericUpDown5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown5.Location = New System.Drawing.Point(144, 64)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(104, 21)
        Me.NumericUpDown5.TabIndex = 14
        Me.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(134, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Process"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(248, 18)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Process with STL :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "YEAR :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(173, 35)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(83, 21)
        Me.NumericUpDown3.TabIndex = 6
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(173, 11)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(83, 21)
        Me.NumericUpDown4.TabIndex = 5
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "QUARTER :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label54.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.DimGray
        Me.Label54.Location = New System.Drawing.Point(27, 13)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(371, 40)
        Me.Label54.TabIndex = 47
        Me.Label54.Text = "CASH DIV. / PAT REF. PROCESSING"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(2, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(629, 53)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'bgwDividendWorker
        '
        '
        'bgwPatronageRefundWorker
        '
        '
        'lblProgress
        '
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(35, 491)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(80, 16)
        Me.lblProgress.TabIndex = 59
        Me.lblProgress.Text = "Posting..."
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProgress.Visible = False
        '
        'frmDividendPatronageRefundProcessing
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(382, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDividendPatronageRefundProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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


    Private _CtrlSystemDate As DateTime
    Public Property CtrlSystemDate() As DateTime
        Get
            Return _CtrlSystemDate
        End Get
        Set(ByVal value As DateTime)
            _CtrlSystemDate = value
        End Set
    End Property

    Private _IDivPatRefundService As IDividendPatronageRefundService
    Public Property IDivPatRefundService() As IDividendPatronageRefundService
        Get
            Return _IDivPatRefundService
        End Get
        Set(ByVal value As IDividendPatronageRefundService)
            _IDivPatRefundService = value
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

    Private _DividendPercentage As Decimal
    Public Property DividendPercentage() As Decimal
        Get
            Return _DividendPercentage
        End Get
        Set(ByVal value As Decimal)
            _DividendPercentage = value
        End Set
    End Property

    Private _PatronageRefundPercentage As Decimal
    Public Property PatronageRefundPercentage() As Decimal
        Get
            Return _PatronageRefundPercentage
        End Get
        Set(ByVal value As Decimal)
            _PatronageRefundPercentage = value
        End Set
    End Property



    Private _IsDividendOrPatronageRefundChecked As Boolean
    Private _IsBatchPosted As Boolean


    Private Sub frmDIVPAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown4.Value = CtrlSystemDate.Year : NumericUpDown3.Text = 1
        FillDatePicker()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then GroupBox4.Enabled = True Else GroupBox4.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then GroupBox3.Enabled = True Else GroupBox3.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String        

        _IsDividendOrPatronageRefundChecked = False

        msg = MsgBox(GetGlobalResourceString("DivPatProcessingQuestion"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetGlobalResourceString("DividendPatronageRefund"))

        If msg = vbYes Then
            Dim ProcessingYear As String = NumericUpDown4.Text
            Dim ProcessingQtr As String = NumericUpDown3.Text
            Dim result As DividendProcessingValidationResult = IDivPatRefundService.ValidateDividendProcessing(ProcessingYear, ProcessingQtr)
            IMessageService.GetMessageFromDividendRefundValidation(result, ProcessingYear, ProcessingQtr)

            If result = DividendProcessingValidationResult.Invalid Then Exit Sub
            If result = DividendProcessingValidationResult.Valid Then _IsBatchPosted = True

            If CheckBox2.Checked Or CheckBox3.Checked Then
                _IsDividendOrPatronageRefundChecked = True
                Button2.Enabled = False : Button1.Enabled = False
                lblProgress.Visible = True : lblProgress.Text = GetGlobalResourceString("PostingProgress")
                IDivPatRefundService.ClearDividendPatronageRefundRecords()
            End If

            If CheckBox2.Checked = True Then

                If DateTimePicker1.Value <= DateValue(CtrlSystemDate) And DateTimePicker2.Value <= DateValue(CtrlSystemDate) And NumericUpDown5.Value > 0 Then
                    DividendPercentage = NumericUpDown5.Value / 100
                    bgwDividendWorker.RunWorkerAsync()
                Else
                    If CheckBox3.Checked = True Then
                        MsgBox(GetGlobalResourceString("IncorrectDividendSettings"), MsgBoxStyle.Critical, GetGlobalResourceString("DividendPatronageRefund"))
                        Exit Sub
                    End If
                End If

            End If

            If CheckBox3.Checked = True Then
                If DateTimePicker4.Value <= CtrlSystemDate And DateTimePicker3.Value <= DateTimePicker5.Value And DateTimePicker3.Value <= CtrlSystemDate And DateTimePicker5.Value <= CtrlSystemDate And NumericUpDown6.Value > 0 Then
                    PatronageRefundPercentage = NumericUpDown6.Value / 100
                    bgwPatronageRefundWorker.RunWorkerAsync()
                Else
                    MsgBox(GetGlobalResourceString("IncorrectPatronageRefundSettings"), MsgBoxStyle.Critical, GetGlobalResourceString("DividendPatronageRefund"))
                End If
            End If

        End If
    End Sub

    Private Sub FillDatePicker()
        NumericUpDown3.Text = CStr(DatePart(DateInterval.Quarter, DateValue(SYSDATE)))
        DateTimePicker1.Value = SYSDATE
        DateTimePicker2.Value = SYSDATE
        DateTimePicker3.Value = SYSDATE
        DateTimePicker4.Value = SYSDATE
        DateTimePicker5.Value = SYSDATE
    End Sub

    Private Sub bgwDividendWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwDividendWorker.DoWork
        CheckBox2.BackColor = Color.LightYellow

        IDivPatRefundService.PostCashDividend(DividendPercentage, SYSDATE, DateTimePicker1.Value, DateTimePicker2.Value, CurrentUser.UserName)

        If Not CheckBox3.Checked Then
            UpdateDividendPatronageRefundRegister()
        End If
    End Sub

    Private Sub bgwDividendWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwDividendWorker.RunWorkerCompleted
        CheckBox2.BackColor = Color.LimeGreen
        lblProgress.Text = GetGlobalResourceString("Done")
        If Not bgwPatronageRefundWorker.IsBusy Then
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub bgwPatronageRefundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwPatronageRefundWorker.DoWork

        Dim IncludeSTL As Boolean = CheckBox1.Checked

        CheckBox3.BackColor = Color.LightYellow
        IDivPatRefundService.PostPatronageRefund(SetupParamaters(), IncludeSTL)
        UpdateDividendPatronageRefundRegister()
   
    End Sub

    Private Sub bgwPatronageRefundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwPatronageRefundWorker.RunWorkerCompleted
        CheckBox3.BackColor = Color.LimeGreen
        lblProgress.Text = GetGlobalResourceString("Done")
        If Not bgwDividendWorker.IsBusy Then
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub UpdateDividendPatronageRefundRegister()      
        IDivPatRefundService.UpdateDividendPatronageRefundRegister(SetupParamaters(), _IsBatchPosted)
    End Sub

    Private Function SetupParamaters() As DivrefPostingParameters
        Dim param As DivrefPostingParameters
        With param
            .PostingYear = NumericUpDown4.Value
            .PostingQuarter = NumericUpDown3.Value

            .FixedDepositCutOffDate = DateTimePicker1.Value
            .DividendPercentage = NumericUpDown5.Value

            .PatronageRefundProcessingDate = DateValue(DateTimePicker4.Value)
            .PatronageRefundPercentage = NumericUpDown6.Value
            .PatronageRefundInterestStartDate = DateTimePicker3.Value
            .PatronageRefundInterestEndDate = DateTimePicker5.Value

            .CurrentUsername = CurrentUser.UserName
            .SystemDate = SYSDATE
        End With
        Return param
    End Function

End Class
