Public Class frmDIVPAT
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDIVPAT))
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 216)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(344, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Process"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Processing..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(296, 16)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(248, 16)
        Me.CheckBox3.TabIndex = 49
        Me.CheckBox3.Text = "PATRONAGE REFUND PROCESSING"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(8, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(248, 16)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Text = "CASH DIVIDEND PROCESSING"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox3.Location = New System.Drawing.Point(296, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 144)
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
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker5.Location = New System.Drawing.Point(144, 40)
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
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker3.Location = New System.Drawing.Point(144, 16)
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
        Me.Label13.Location = New System.Drawing.Point(179, 40)
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
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker4.Location = New System.Drawing.Point(136, 16)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker4.TabIndex = 24
        Me.DateTimePicker4.Tag = "*Enter Birth Date"
        Me.DateTimePicker4.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown6.Location = New System.Drawing.Point(136, 40)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(40, 21)
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
        Me.GroupBox4.Size = New System.Drawing.Size(272, 144)
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
        Me.Label9.Location = New System.Drawing.Point(184, 66)
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
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
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
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
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
        Me.NumericUpDown5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown5.Location = New System.Drawing.Point(144, 64)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown5.TabIndex = 14
        Me.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(464, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "&Close"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(464, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 64)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(176, 16)
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
        Me.NumericUpDown3.Location = New System.Drawing.Point(96, 40)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown3.TabIndex = 6
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(96, 16)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(88, 21)
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 50)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'frmDIVPAT
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 381)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDIVPAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CASH DIV/PAT REF Settings"
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDIVPAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown4.Text = Val(Year(rsCTL.Fields("PROC").Value)) : NumericUpDown3.Text = 1
        filldate()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then GroupBox4.Enabled = True Else GroupBox4.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then GroupBox3.Enabled = True Else GroupBox3.Enabled = False
    End Sub

    Friend Sub filldate()
        NumericUpDown3.Text = CStr(DatePart(DateInterval.Quarter, DateValue(SYSDATE)))
        DateTimePicker1.Value = SYSDATE
        DateTimePicker2.Value = SYSDATE
        DateTimePicker3.Value = SYSDATE
        DateTimePicker4.Value = SYSDATE
        DateTimePicker5.Value = SYSDATE
    End Sub

    Sub PrcCASHDIV(ByVal PRC As Decimal)
        Dim sQRY As String
        'sQRY = "SELECT MM.KBCI_NO,MM.LNAME+ ', ' + MM.FNAME + ' ' + MM.MI + '.' AS NAME," & _
        '       "(select top 1 FD.BALANCE  from FD   where FD.KBCI_NO=MM.KBCI_NO and FD.DATE<='" & DateTimePicker1.Value & "' order by FD.FD_ID desc) " & _
        '       "AS BALANCE INTO TEST FROM MEMBERS AS MM"
        sQRY = "INSERT INTO DIV([DATE],[KBCI_NO],[FD_AMT],[DIV_AMT],[DEDNS],[ADD_DATE]) " & _
               "SELECT '" & DateValue(DateTimePicker2.Value) & "' AS DATE,MEM.KBCI_NO, FD.BALANCE, FD.BALANCE * " & PRC & " AS DIV_AMT, 0 AS DEDNS,'" & SYSDATE & "' AS ADD_DATE  FROM FD  " & _
               "RIGHT OUTER JOIN (SELECT MAX(FD_ID) FD_ID FROM FD WHERE KBCI_NO + convert(varchar(30), [DATE]) in " & _
               "( select KBCI_NO + convert(varchar(30), MAX([DATE])) K_D from FD where [DATE] <= '" & DateTimePicker1.Value & "' group by KBCI_NO) " & _
               "group by KBCI_NO ) B on FD.FD_ID = B.FD_ID RIGHT JOIN MEMBERS MEM on FD.KBCI_NO = MEM.KBCI_NO"
        cn.CommandTimeout = 9999
        cn.Execute("DELETE FROM DIV")
        cn.Execute(sQRY)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Sub updCASHDIV()
        cn.Execute("UPDATE CASHDIV SET [DATE]='" & DateTimePicker1.Value & "',[PERCENT]=" & NumericUpDown5.Text & ",[YTD_PCT]=" & NumericUpDown5.Text & ",[PROC_DATE]='" & DateTimePicker2.Value & "',[ADD_DATE]='" & SYSDATE & "',[CHG_DATE]='" & SYSDATE & "',[USER]='" & CLUSER & "'")
    End Sub
    Sub PRCPATREF(ByVal MEMSTAT As String, ByVal TBL As String, ByVal STL As String)
        Dim sqry As String
        cn.Execute("DELETE FROM " & TBL)
        sqry = "INSERT INTO " & TBL & "([ACCTNO],[APLINT],[EDLINT],[EMLINT],[RGLINT],[RSLINT],[SPLINT],[LHLINT],[STLINT],[PTLINT]) " & _
                "SELECT LN.KBCI_NO," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='APL' THEN LT.AMOUNT ELSE 0 END) APLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='EDL' THEN LT.AMOUNT ELSE 0 END) EDLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='EML' THEN LT.AMOUNT ELSE 0 END) EMLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='RGL' THEN LT.AMOUNT ELSE 0 END) RGLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='RSL' THEN LT.AMOUNT ELSE 0 END) RSLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='SPL' THEN LT.AMOUNT ELSE 0 END) SPLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='LHL' THEN LT.AMOUNT ELSE 0 END) LHLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='STL' THEN LT.AMOUNT ELSE 0 END) STLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='PTL' THEN LT.AMOUNT ELSE 0 END) PTLINT " & _
                "FROM (SELECT DISTINCT LG.PN_NO, SUM(ISNULL(LG.CR,0.00)) - SUM(ISNULL(LG.DR,0.00)) AMOUNT  FROM  LEDGER LG WHERE ACCT_CODE='INT' " & _
                "AND (ACCT_TYPE='PAY' OR ACCT_TYPE='ADJ' OR ACCT_TYPE='TER' OR ACCT_TYPE='INT') AND  DATE BETWEEN '" & DateTimePicker3.Value & "' AND '" & DateTimePicker5.Value & "' " & _
                "GROUP BY LG.PN_NO) LT RIGHT OUTER JOIN LOANS LN ON LT.PN_NO=LN.PN_NO LEFT JOIN MEMBERS MM ON MM.KBCI_NO=LN.KBCI_NO WHERE MM.MEM_STAT='" & MEMSTAT & "' " & STL & " GROUP BY LN.KBCI_NO"
        cn.CommandTimeout = 9999
        cn.Execute(sqry)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Sub PRCINTERST(ByVal TBL As String, ByVal STL As String)
        Dim sqry As String
        cn.Execute("DELETE FROM " & TBL)
        sqry = "INSERT INTO " & TBL & "([ACCTNO],[APLINT],[EDLINT],[EMLINT],[RGLINT],[RSLINT],[SPLINT],[LHLINT],[STLINT]) " & _
                "SELECT LN.KBCI_NO," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='APL' THEN LT.AMOUNT ELSE 0 END) APLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='EDL' THEN LT.AMOUNT ELSE 0 END) EDLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='EML' THEN LT.AMOUNT ELSE 0 END) EMLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='RGL' THEN LT.AMOUNT ELSE 0 END) RGLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='RSL' THEN LT.AMOUNT ELSE 0 END) RSLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='SPL' THEN LT.AMOUNT ELSE 0 END) SPLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='LHL' THEN LT.AMOUNT ELSE 0 END) LHLINT," & _
                "SUM(CASE WHEN LN.LOAN_TYPE ='STL' THEN LT.AMOUNT ELSE 0 END) STLINT " & _
                "FROM (SELECT DISTINCT LG.PN_NO, SUM(ISNULL(LG.CR,0.00)) - SUM(ISNULL(LG.DR,0.00)) AMOUNT  FROM  LEDGER LG WHERE ACCT_CODE='INT' " & _
                "AND (ACCT_TYPE='PAY' OR ACCT_TYPE='ADJ' OR ACCT_TYPE='TER' OR ACCT_TYPE='INT') AND  DATE BETWEEN '" & DateTimePicker3.Value & "' AND '" & DateTimePicker5.Value & "' " & _
                "GROUP BY LG.PN_NO) LT RIGHT OUTER JOIN LOANS LN ON LT.PN_NO=LN.PN_NO LEFT JOIN MEMBERS MM ON MM.KBCI_NO=LN.KBCI_NO WHERE (MM.MEM_STAT!='S' AND MM.MEM_STAT!='R') " & STL & " GROUP BY LN.KBCI_NO"
        '"GROUP BY LG.PN_NO) LT RIGHT OUTER JOIN LOANS LN ON LT.PN_NO=LN.PN_NO LEFT JOIN MEMBERS MM ON MM.KBCI_NO=LN.KBCI_NO WHERE  MM.MEM_STAT!='A' " & STL & " GROUP BY LN.KBCI_NO"
        cn.CommandTimeout = 9999
        cn.Execute(sqry)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Sub UPDATEMEM(ByVal TBL As String)
        Dim sqry As String
        sqry = "UPDATE MEMBERS SET MEMBERS.YTD_DIVAMT=PATREF.PR FROM  " & _
             "(SELECT [ACCTNO], ([APLINT]+[EDLINT]+[EMLINT]+[RGLINT]+[RSLINT]+[SPLINT]+[LHLINT]+[STLINT]+[PTLINT]) PR FROM " & TBL & ") " & _
             "PATREF WHERE MEMBERS.KBCI_NO=PATREF.ACCTNO"
        cn.Execute(sqry)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Sub UPDATEMEMINT()
        Dim sqry As String
        sqry = "UPDATE MEMBERS SET MEMBERS.YTD_DIVAMT=PATREF.PR FROM  " & _
             "(SELECT [ACCTNO], ([APLINT]+[EDLINT]+[EMLINT]+[RGLINT]+[RSLINT]+[SPLINT]+[LHLINT]+[STLINT]) PR FROM INTEREST) " & _
             "PATREF WHERE MEMBERS.KBCI_NO=PATREF.ACCTNO"
        cn.Execute(sqry)
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Sub updPATREF(ByVal prc As Decimal)
        cn.Execute("INSERT INTO PAT_REF([PERCENT],[PROC_DATE],[ADD_DATE],[CHG_DATE],[USER]) " & _
                   "VALUES(" & prc & " * 100,'" & DateTimePicker4.Value & "','" & SYSDATE & "','" & SYSDATE & "','" & CLUSER & "')")

        cn.Execute("DELETE FROM REF")
        cn.Execute("INSERT INTO REF([DATE],[KBCI_NO],[INT_PAID],[REFUND]) " & _
                   "SELECT '" & DateTimePicker4.Value & "' DATE,KBCI_NO,YTD_DIVAMT,ROUND(YTD_DIVAMT * " & prc & ",0) REFUND FROM MEMBERS WHERE YTD_DIVAMT>0")
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Sub updDIVREF()
        cn.Execute("DELETE FROM DIVREF")
        cn.Execute("INSERT INTO DIVREF([KBCI_NO],[LNAME],[FNAME],[MI],[FEBTC_SA],[DIVIDEND],[REFUND]) " & _
                    "SELECT MM.KBCI_NO,MM.LNAME,MM.FNAME,MM.MI,MM.FEBTC_SA,DV.DIV_AMT,RF.REFUND " & _
                    "FROM MEMBERS MM LEFT OUTER JOIN DIV DV ON MM.KBCI_NO=DV.KBCI_NO LEFT OUTER JOIN REF RF ON MM.KBCI_NO=RF.KBCI_NO " & _
                    "WHERE DV.DIV_AMT>0 OR RF.REFUND>0")
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If

    End Sub
    Sub upDIVREFPH(ByVal newrec As Boolean)

        If newrec Then
            cn.Execute("INSERT INTO DIVREFPH([YEAR],[QUARTER],[FD_CUTOFF],[FD_PERCENT],[PR_YEAR],[PR_PERCENT],[PR_INTFROM],[PR_INTTO],[HOLDOUT],[USER],[ADD_DATE],[TDIVAMT],[TREFAMT],[SAVINGS],[POSTED]) " & _
                       "SELECT '" & NumericUpDown4.Text & "','" & NumericUpDown3.Text & "','" & DateTimePicker1.Value & "'," & NumericUpDown5.Text & ",'" & Year(DateValue(DateTimePicker4.Value)) & "'," & _
                        NumericUpDown6.Text & ",'" & DateTimePicker3.Value & "','" & DateTimePicker5.Value & "','False','" & CLUSER & "','" & SYSDATE & "',(SELECT SUM(DIV_AMT) FROM DIV),(SELECT SUM(REFUND) FROM REF),(SELECT SUM(DIV_AMT) FROM DIV)+(SELECT SUM(REFUND) FROM REF),'False'")
        Else
            cn.Execute("UPDATE DIVREFPH SET [YEAR]='" & NumericUpDown4.Text & "',[QUARTER]='" & NumericUpDown3.Text & "',[FD_CUTOFF]='" & DateTimePicker1.Value & _
                                         "',[FD_PERCENT]=" & NumericUpDown5.Text & ",[PR_YEAR]='" & Year(DateValue(DateTimePicker4.Value)) & "',[PR_PERCENT]=" & NumericUpDown6.Text & ",[PR_INTFROM]='" & DateTimePicker3.Value & _
                                         "',[PR_INTTO]='" & DateTimePicker5.Value & "',[HOLDOUT]='False',[USER]='" & CLUSER & "',[ADD_DATE]='" & SYSDATE & "',[TDIVAMT]=(SELECT SUM(DIV_AMT) FROM DIV),[TREFAMT]=(SELECT SUM(REFUND) FROM REF),[SAVINGS]=(SELECT SUM(DIV_AMT) FROM DIV)+(SELECT SUM(REFUND) FROM REF),[POSTED]='False'  " & _
                                         "WHERE YEAR+ CONVERT(varchar(1),[QUARTER]) ='" & NumericUpDown4.Text & NumericUpDown3.Text & "'")
        End If

errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String
        Dim prc As Decimal
        Dim DivExist, PROCD As Boolean
        Dim StartTime As DateTime
        Dim Elapsed, PRElapsed As Double

        PROCD = False
        msg = MsgBox("Would you like to process the CASH DIVIDEND/PAT. REFUND with the following settings.", MsgBoxStyle.Question.YesNo, "CASH DIV/PAT REFUND")
        If msg = vbYes Then
            rsDIV.Open("SELECT [CVNO],[POSTED] FROM  DIVREFPH WHERE YEAR='" & NumericUpDown4.Text & "' AND QUARTER='" & NumericUpDown3.Text & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
            If rsDIV.RecordCount > 0 Then
                If Not IsDBNull(rsDIV.Fields("CVNO").Value) Or CBool(rsDIV.Fields("POSTED").Value) = True Then
                    MsgBox("Unable to process CASH DIVIDEND FOR YEAR:[" & NumericUpDown4.Text & "] QUARTER:[" & NumericUpDown3.Text & "]. Please check if the voucher is processed / dividend is posted.", MsgBoxStyle.Information, "CASH DIV/PAT REF PROCESSING")
                    If rsDIV.State = 1 Then rsDIV.Close()
                    Exit Sub
                Else
                    DivExist = False
                End If
            Else
                DivExist = True
            End If
            rsDIV.Close()
            If CheckBox2.Checked = True Then

                If DateTimePicker1.Value <= DateValue(SYSDATE) And DateTimePicker2.Value <= DateValue(SYSDATE) And Val(NumericUpDown5.Text) > 0 Then
                    StartTime = System.DateTime.Now : Label4.Visible = True : Application.DoEvents()
                    PROCD = True
                    prc = Val(NumericUpDown5.Text) / 100
                    PrcCASHDIV(prc)
                    updCASHDIV()
                    Elapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds : Label4.Visible = False : Application.DoEvents()
                Else

                    If CheckBox3.Checked = True Then
                        Dim msg2 As String
                        MsgBox("Error on settings, please check the processing date, cutoff date, and percentage to apply. Would you like to continue processing the Patronage Refund", MsgBoxStyle.Information.YesNo, "CASH DIV Settings Error")
                        If msg2 = vbNo Then
                            Exit Sub
                        End If
                    Else
                        MsgBox("Error on settings, please check the processing date, cutoff date, and percentage to apply.", MsgBoxStyle.Information, "CASH DIV Settings Error")
                    End If
                End If

            End If

            If CheckBox3.Checked = True Then
                If DateTimePicker4.Value <= SYSDATE And DateTimePicker3.Value <= DateTimePicker5.Value And DateTimePicker3.Value <= SYSDATE And DateTimePicker5.Value <= SYSDATE And Val(NumericUpDown6.Text) > 0 Then
                    StartTime = System.DateTime.Now : Label4.Visible = True : Application.DoEvents()
                    PROCD = True
                    prc = Val(NumericUpDown6.Text) / 100
                    If Me.CheckBox1.Checked = True Then
                        PRCPATREF("S", "SNTEREST", "")
                        PRCPATREF("R", "RNTEREST", "")
                        PRCINTERST("INTEREST", "")
                    Else
                        PRCPATREF("S", "SNTEREST", "AND (LN.LOAN_TYPE!='STL' AND LN.FREQ!='D')")
                        PRCPATREF("R", "RNTEREST", "AND (LN.LOAN_TYPE!='STL' AND LN.FREQ!='D')")
                        PRCINTERST("INTEREST", "AND (LN.LOAN_TYPE!='STL' AND LN.FREQ!='D')")
                    End If
                    cn.Execute("UPDATE MEMBERS SET YTD_DIVAMT=0")
                    UPDATEMEM("SNTEREST")
                    UPDATEMEM("RNTEREST")
                    UPDATEMEMINT()
                    updPATREF(prc)
                    PRElapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds : Label4.Visible = False : Application.DoEvents()
                Else
                    MsgBox("Error on settings, please check the processing date, loans date range, and percentage to apply.", MsgBoxStyle.Information, "PAT REF Settings Error")
                End If
            End If
            MsgBox("CASH DIV / PAT REFUND Successfully Processed: " & _
                    vbCrLf & "CASH DIVIDEND Elapsed : " & Elapsed & "ms" & _
                    vbCrLf & "PATRONAGE REFUND Elapsed : " & PRElapsed & "ms", MsgBoxStyle.Information, "CASH DIV / PAT REFUND")
            If PROCD = True Then upDIVREFPH(DivExist) : updDIVREF()
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
End Class