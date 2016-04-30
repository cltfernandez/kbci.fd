Public Class frmFDS_Main_NMem
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
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MaskEdBox1 As AxMSMask.AxMaskEdBox
    Friend WithEvents AxMaskEdBox1 As AxMSMask.AxMaskEdBox
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents MaskEdBox2 As AxMSMask.AxMaskEdBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents AxMaskEdBox2 As AxMSMask.AxMaskEdBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents AxMaskEdBox3 As AxMSMask.AxMaskEdBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents AxMaskEdBox4 As AxMSMask.AxMaskEdBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDS_Main_NMem))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.MaskEdBox1 = New AxMSMask.AxMaskEdBox
        Me.AxMaskEdBox1 = New AxMSMask.AxMaskEdBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox6 = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.MaskEdBox2 = New AxMSMask.AxMaskEdBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.AxMaskEdBox3 = New AxMSMask.AxMaskEdBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.AxMaskEdBox4 = New AxMSMask.AxMaskEdBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.AxMaskEdBox2 = New AxMSMask.AxMaskEdBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MaskEdBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMaskEdBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.MaskEdBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMaskEdBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxMaskEdBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMaskEdBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton4, Me.ToolBarButton9, Me.ToolBarButton3, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton5})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(774, 46)
        Me.ToolBar1.TabIndex = 5
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "ADD NEW"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 6
        Me.ToolBarButton2.Text = "EDIT"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 1
        Me.ToolBarButton4.Text = "DELETE"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 3
        Me.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 5
        Me.ToolBarButton3.Text = "SEARCH"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 4
        Me.ToolBarButton6.Text = "PREV"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 3
        Me.ToolBarButton7.Text = "NEXT"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 2
        Me.ToolBarButton5.Text = "EXIT"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label54)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(3, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 560)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(254, Byte), CType(203, Byte))
        Me.Label54.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.DimGray
        Me.Label54.Location = New System.Drawing.Point(80, 27)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(384, 32)
        Me.Label54.TabIndex = 46
        Me.Label54.Text = "MEMBERSHIP MAINTENANCE MODULE"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 50)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(16, 536)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(96, 16)
        Me.Label51.TabIndex = 42
        Me.Label51.Text = "Information :"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label33.Location = New System.Drawing.Point(120, 536)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(632, 16)
        Me.Label33.TabIndex = 41
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.MaskEdBox1)
        Me.GroupBox2.Controls.Add(Me.AxMaskEdBox1)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 152)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(232, 88)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Birthdate:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label30.Location = New System.Drawing.Point(504, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "0"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox3.Location = New System.Drawing.Point(96, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 16)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(632, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Tag = "*Enter Gender:  [M] - Male  [F] - Female"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Tag = "*Enter Birth Date"
        Me.DateTimePicker1.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(464, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Age :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "KBCI No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 40)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = "*Enter Last Name"
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Last Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(112, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(600, 21)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.Tag = " Enter Home Address"
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(408, 40)
        Me.TextBox4.MaxLength = 20
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(224, 21)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Tag = "*Enter First Name"
        Me.TextBox4.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "First Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(640, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "M.I. :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(680, 40)
        Me.TextBox5.MaxLength = 1
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(32, 21)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.Tag = "*Enter Middle Initial"
        Me.TextBox5.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Res. Tel :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(320, 112)
        Me.TextBox7.MaxLength = 20
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(104, 21)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.Tag = " Enter Real Estate Property Value"
        Me.TextBox7.Text = "0.00"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(232, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "REP Value :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Dependent :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(568, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Gender :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.ComboBox2.Location = New System.Drawing.Point(632, 112)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox2.TabIndex = 11
        Me.ComboBox2.Tag = "*Enter Civil Status:  [S] - Single  [M] - Married  [W] - Widower"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(544, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Civil Status :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"Member", "Investor"})
        Me.ComboBox3.Location = New System.Drawing.Point(600, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox3.TabIndex = 4
        Me.ComboBox3.Tag = "*Enter Membership Code:  [M] - Member  [I] - Investor"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(472, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Membership Code :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaskEdBox1
        '
        Me.MaskEdBox1.ContainingControl = Me
        Me.MaskEdBox1.Location = New System.Drawing.Point(96, 88)
        Me.MaskEdBox1.Name = "MaskEdBox1"
        Me.MaskEdBox1.OcxState = CType(resources.GetObject("MaskEdBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MaskEdBox1.Size = New System.Drawing.Size(80, 20)
        Me.MaskEdBox1.TabIndex = 35
        Me.MaskEdBox1.Tag = " Enter Home Telephone Number"
        '
        'AxMaskEdBox1
        '
        Me.AxMaskEdBox1.ContainingControl = Me
        Me.AxMaskEdBox1.Location = New System.Drawing.Point(96, 112)
        Me.AxMaskEdBox1.Name = "AxMaskEdBox1"
        Me.AxMaskEdBox1.OcxState = CType(resources.GetObject("AxMaskEdBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMaskEdBox1.Size = New System.Drawing.Size(30, 20)
        Me.AxMaskEdBox1.TabIndex = 35
        Me.AxMaskEdBox1.Tag = " Enter number of dependents"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(432, 94)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 16)
        Me.Label35.TabIndex = 39
        Me.Label35.Text = "*"
        Me.Label35.Visible = False
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Red
        Me.Label36.Location = New System.Drawing.Point(720, 69)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 16)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = "*"
        Me.Label36.Visible = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(720, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(16, 16)
        Me.Label40.TabIndex = 39
        Me.Label40.Text = "*"
        Me.Label40.Visible = False
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(720, 120)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(16, 16)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "*"
        Me.Label41.Visible = False
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(720, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(16, 16)
        Me.Label42.TabIndex = 39
        Me.Label42.Text = "*"
        Me.Label42.Visible = False
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(720, 22)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(16, 16)
        Me.Label49.TabIndex = 39
        Me.Label49.Text = "*"
        Me.Label49.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox6)
        Me.GroupBox3.Controls.Add(Me.Label53)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBox15)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TextBox16)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TextBox17)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TextBox28)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TextBox14)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.MaskEdBox2)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.AxMaskEdBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 192)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(112, 64)
        Me.ComboBox4.MaxLength = 15
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox4.TabIndex = 44
        Me.ComboBox4.Tag = "*Enter Region where assigned"
        Me.ComboBox4.Text = ""
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.Location = New System.Drawing.Point(536, 64)
        Me.ComboBox6.MaxLength = 15
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox6.TabIndex = 43
        Me.ComboBox6.Tag = "*Enter Region where assigned"
        Me.ComboBox6.Text = ""
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(8, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(88, 16)
        Me.Label53.TabIndex = 42
        Me.Label53.Text = "CB Emp No :"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label50.Location = New System.Drawing.Point(112, 160)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(272, 18)
        Me.Label50.TabIndex = 41
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Location = New System.Drawing.Point(336, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 48)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(72, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Reason :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Tag = " Is Applicant a Director/Officer/Related Interest ? [Y/N"
        Me.CheckBox1.Text = "DORI |"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(144, 16)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(224, 21)
        Me.TextBox13.TabIndex = 14
        Me.TextBox13.Tag = " Enter Reason why Applicant is considered DORI"
        Me.TextBox13.Text = ""
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(96, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker2.TabIndex = 30
        Me.DateTimePicker2.Tag = "*Enter Hiring Date at CB"
        Me.DateTimePicker2.Value = New Date(2009, 7, 14, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Department :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(632, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "loc."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(96, 16)
        Me.TextBox10.MaxLength = 6
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(112, 21)
        Me.TextBox10.TabIndex = 12
        Me.TextBox10.Tag = "*Enter CB Employee number"
        Me.TextBox10.Text = ""
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Hire Date :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Position :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(424, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Region :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(112, 88)
        Me.TextBox15.MaxLength = 20
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(112, 21)
        Me.TextBox15.TabIndex = 17
        Me.TextBox15.Tag = "*Enter Basic Salary"
        Me.TextBox15.Text = "0.00"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Sal [Basic] :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(536, 88)
        Me.TextBox16.MaxLength = 15
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(176, 21)
        Me.TextBox16.TabIndex = 18
        Me.TextBox16.Tag = "*Enter Region where assigned"
        Me.TextBox16.Text = ""
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Sal [Allow] :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(112, 112)
        Me.TextBox17.MaxLength = 20
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(112, 21)
        Me.TextBox17.TabIndex = 19
        Me.TextBox17.Tag = " Enter Allowance"
        Me.TextBox17.Text = "0.00"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(424, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 16)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Office Tel :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox28
        '
        Me.TextBox28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(112, 136)
        Me.TextBox28.MaxLength = 20
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(112, 21)
        Me.TextBox28.TabIndex = 21
        Me.TextBox28.Tag = " Enter Other Income, if any"
        Me.TextBox28.Text = "0.00"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 136)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 16)
        Me.Label37.TabIndex = 15
        Me.Label37.Text = "Other Income :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 160)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 16)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Tenure :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(536, 136)
        Me.TextBox12.MaxLength = 10
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(144, 21)
        Me.TextBox12.TabIndex = 22
        Me.TextBox12.Tag = " Enter FEBTC Savings Account No."
        Me.TextBox12.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(424, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "FEBTC S/A No :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(536, 160)
        Me.TextBox14.MaxLength = 10
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(144, 21)
        Me.TextBox14.TabIndex = 24
        Me.TextBox14.Tag = " Enter FEBTC Current Account No."
        Me.TextBox14.Text = ""
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(424, 160)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(128, 16)
        Me.Label39.TabIndex = 29
        Me.Label39.Text = "FEBTC C/A No :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaskEdBox2
        '
        Me.MaskEdBox2.ContainingControl = Me
        Me.MaskEdBox2.Location = New System.Drawing.Point(536, 112)
        Me.MaskEdBox2.Name = "MaskEdBox2"
        Me.MaskEdBox2.OcxState = CType(resources.GetObject("MaskEdBox2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MaskEdBox2.Size = New System.Drawing.Size(80, 20)
        Me.MaskEdBox2.TabIndex = 35
        Me.MaskEdBox2.Tag = "*Enter Office Telephone Number w/ Local number"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(216, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 16)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "*"
        Me.Label34.Visible = False
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(216, 47)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 16)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "*"
        Me.Label43.Visible = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(720, 96)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(16, 16)
        Me.Label44.TabIndex = 40
        Me.Label44.Text = "*"
        Me.Label44.Visible = False
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Red
        Me.Label45.Location = New System.Drawing.Point(720, 72)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(16, 16)
        Me.Label45.TabIndex = 40
        Me.Label45.Text = "*"
        Me.Label45.Visible = False
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(384, 72)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(16, 16)
        Me.Label46.TabIndex = 40
        Me.Label46.Text = "*"
        Me.Label46.Visible = False
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(232, 96)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(16, 16)
        Me.Label47.TabIndex = 40
        Me.Label47.Text = "*"
        Me.Label47.Visible = False
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(720, 120)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(16, 16)
        Me.Label48.TabIndex = 40
        Me.Label48.Text = "*"
        Me.Label48.Visible = False
        '
        'AxMaskEdBox3
        '
        Me.AxMaskEdBox3.ContainingControl = Me
        Me.AxMaskEdBox3.Location = New System.Drawing.Point(664, 112)
        Me.AxMaskEdBox3.Name = "AxMaskEdBox3"
        Me.AxMaskEdBox3.OcxState = CType(resources.GetObject("AxMaskEdBox3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMaskEdBox3.Size = New System.Drawing.Size(48, 20)
        Me.AxMaskEdBox3.TabIndex = 35
        Me.AxMaskEdBox3.Tag = " Enter number of dependents"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AxMaskEdBox4)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.TextBox21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.TextBox19)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.TextBox22)
        Me.GroupBox5.Controls.Add(Me.TextBox23)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.TextBox25)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.AxMaskEdBox2)
        Me.GroupBox5.Controls.Add(Me.Label52)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 408)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(736, 120)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'AxMaskEdBox4
        '
        Me.AxMaskEdBox4.ContainingControl = Me
        Me.AxMaskEdBox4.Location = New System.Drawing.Point(232, 64)
        Me.AxMaskEdBox4.Name = "AxMaskEdBox4"
        Me.AxMaskEdBox4.OcxState = CType(resources.GetObject("AxMaskEdBox4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMaskEdBox4.Size = New System.Drawing.Size(48, 20)
        Me.AxMaskEdBox4.TabIndex = 37
        Me.AxMaskEdBox4.Tag = " Enter number of dependents"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(512, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 16)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "CB Emp No :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(600, 40)
        Me.TextBox21.MaxLength = 6
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(112, 21)
        Me.TextBox21.TabIndex = 28
        Me.TextBox21.Tag = " Enter spouse employee no"
        Me.TextBox21.Text = ""
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(512, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 16)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "KBCI No :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(600, 16)
        Me.TextBox18.MaxLength = 7
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(112, 21)
        Me.TextBox18.TabIndex = 26
        Me.TextBox18.Tag = " Enter spouse KBCI no. (if applicable)"
        Me.TextBox18.Text = ""
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Spouse Name :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(112, 16)
        Me.TextBox19.MaxLength = 30
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(344, 21)
        Me.TextBox19.TabIndex = 25
        Me.TextBox19.Tag = " Enter spouse name"
        Me.TextBox19.Text = ""
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(112, 40)
        Me.TextBox20.MaxLength = 40
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(344, 21)
        Me.TextBox20.TabIndex = 27
        Me.TextBox20.Tag = " Enter spouse occupation"
        Me.TextBox20.Text = ""
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Occupation :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Office Tel :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Salary :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(112, 88)
        Me.TextBox22.MaxLength = 20
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(112, 21)
        Me.TextBox22.TabIndex = 31
        Me.TextBox22.Tag = " Enter spouse salary"
        Me.TextBox22.Text = "0.00"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(568, 88)
        Me.TextBox23.MaxLength = 20
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(144, 21)
        Me.TextBox23.TabIndex = 32
        Me.TextBox23.Tag = " Enter savings deposit amount"
        Me.TextBox23.Text = "0.00"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(456, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 16)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "SD Balance :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox25
        '
        Me.TextBox25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(568, 64)
        Me.TextBox25.MaxLength = 20
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(144, 21)
        Me.TextBox25.TabIndex = 30
        Me.TextBox25.Tag = " Enter fixed deposit amount"
        Me.TextBox25.Text = "0.00"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(456, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 16)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "FD Balance :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AxMaskEdBox2
        '
        Me.AxMaskEdBox2.ContainingControl = Me
        Me.AxMaskEdBox2.Location = New System.Drawing.Point(112, 64)
        Me.AxMaskEdBox2.Name = "AxMaskEdBox2"
        Me.AxMaskEdBox2.OcxState = CType(resources.GetObject("AxMaskEdBox2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMaskEdBox2.Size = New System.Drawing.Size(80, 20)
        Me.AxMaskEdBox2.TabIndex = 35
        Me.AxMaskEdBox2.Tag = " Enter spouse office telephone no."
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(204, 66)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(32, 16)
        Me.Label52.TabIndex = 36
        Me.Label52.Text = "loc."
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFDS_Main_NMem
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(774, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "frmFDS_Main_NMem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MaskEdBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMaskEdBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.MaskEdBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMaskEdBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AxMaskEdBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMaskEdBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim KBCINUM As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Function KBCINumber() As String
        Dim KBCINO As Integer = Val(Mid(CStr(rsCTL.Fields("KBCI_NO").Value), 3, 4)) + 1
        Dim NOKBCI As String = Microsoft.VisualBasic.Right(CStr(SYSDATE), 2)
        Dim INS As String
        Dim i As Integer = 7
        Dim tot As Integer = 0
        Dim chk As Integer
        Dim ch_d As String
        NOKBCI = NOKBCI & CStr(KBCINO.ToString("D4")) & "0"
        Do Until i <= 1
            tot = tot + Val(Mid(NOKBCI, 8 - i, 1)) * i
            i -= 1
        Loop
        chk = tot Mod 11
        chk = 11 - chk
        ch_d = chk.ToString("D1")
        If chk > 9 Then ch_d = "0"
        NOKBCI = Microsoft.VisualBasic.Left(NOKBCI, 6) + ch_d
        Return NOKBCI
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim CTROL As Control
        Dim IDX As Integer = Val(ToolBar1.Buttons.IndexOf(e.Button).ToString)

        With ToolBar1
            Select Case IDX
                Case 0
                    If .Buttons(IDX).Text = "ADD NEW" Then
                        KBCINUM = KBCINumber()
                        GroupBox1.Enabled = True
                        RstFrm()
                        shwReq(False)
                        EDTool(ToolBar1, False)
                        .Buttons(IDX).Text = "SAVE" : .Buttons(8).Text = "CANCEL"
                        .Buttons(IDX).Enabled = True
                        TextBox3.Text = Mid(KBCINUM, 1, 2) & "-" & Mid(KBCINUM, 3, 4) & "-" & Mid(KBCINUM, 7, 1)
                        TextBox1.Focus()
                    Else
                        If valTXT() Then
                            Dim MSG As String
                            MSG = MsgBox("Would you like to add this member to the master file?", MsgBoxStyle.Information.YesNo, "Add New Member")
                            If MSG = vbYes Then
                                EDTool(ToolBar1, True)
                                .Buttons(IDX).Text = "ADD NEW"
                                GroupBox1.Enabled = False
                                'WLOG(CleanSTR("INSERT INTO MEMBERS([KBCI_NO],[LNAME],[FNAME],[MI],[MEM_CODE],[MEM_STAT],[MEM_DATE],[BY_WHOM],[CB_EMPNO],[CB_HIRE],[DEPT],[REGION],[OFF_TEL],[DORI],[REA_DORI],[SEX],[B_DATE],[CIV_STAT],[MEM_ADDR],[RES_TEL],[POSITION],[SAL_BAS],[SAL_ALL],[OTH_INC],[FEBTC_SA],[FEBTC_CA],[FD_CERTNO],[FD_DATE],[AP_AMOUNT],[AR_AMOUNT],[FD_AMOUNT],[SD_AMOUNT],[TD_AMOUNT],[OTH_AMOUNT],[YTD_DIVAMT],[YTD_LRI],[REM_PROP],[REM_VALUE],[NO_DEPEND],[SP_NAME],[SP_EMPLOY],[SP_OFFTEL],[SP_CBEMPNO],[SP_KBCINO],[SP_SALARY],[APRUN_AMT],[ARRUN_AMT],[RUN_AMT],[ADD_DATE],[CHG_DATE],[USER],[REC_STAT],[FD_CNTR]) " & _
                                '  "VALUES    ('" & KBCINUM & "','" & TextBox1.Text.ToUpper & "','" & TextBox4.Text.ToUpper & "','" & TextBox5.Text.ToUpper & "','" & Mid(ComboBox3.Text.ToUpper, 1, 1) & "','A','" & SYSDATE & "','" & CLUSER & "','" & TextBox10.Text.ToUpper & "','" & DateValue(DateTimePicker2.Value.ToString) & "','" & ComboBox6.Text.ToUpper & "','" & TextBox16.Text.ToUpper & "','" & Trim(MaskEdBox2.CtlText.ToUpper.Replace("-", "") & AxMaskEdBox3.CtlText) & "','" & CheckBox1.Checked.ToString & "','" & TextBox13.Text.ToUpper & "','" & Mid(ComboBox1.Text.ToUpper, 1, 1) & "','" & DateValue(DateTimePicker1.Value.ToString) & "','" & Mid(ComboBox2.Text.ToUpper, 1, 1) & "','" & TextBox2.Text.ToUpper & "','" & Trim(MaskEdBox1.CtlText.Replace("-", "")) & "','" & _
                                '                   ComboBox4.Text.ToUpper & "'," & Decimal.Round(TextBox15.Text, 2) & "," & Decimal.Round(TextBox17.Text, 2) & "," & Decimal.Round(Val(TextBox28.Text), 2) & ",'" & TextBox12.Text.Replace("-", "") & "','" & TextBox14.Text.Replace("-", "") & "','','',0.00,0.00," & Decimal.Round(TextBox25.Text, 2) & "," & Decimal.Round(TextBox23.Text, 2) & ",0.00,0.00,0.00,0.00,'MEMO'," & Decimal.Round(TextBox7.Text, 2) & "," & Val(AxMaskEdBox1.CtlText) & ",'" & TextBox19.Text.ToUpper & "','" & TextBox20.Text.ToUpper & "','" & Trim(AxMaskEdBox2.CtlText.Replace("-", "") & AxMaskEdBox4.CtlText) & "','" & TextBox21.Text.ToUpper & "','" & TextBox18.Text.ToUpper & "'," & Decimal.Round(TextBox22.Text, 2) & _
                                '                 ",0.00,0.00,0.00,'" & SYSDATE & "','" & SYSDATE & "','" & CLUSER & "','False',0)"), App_Path() & "SQLTRAN.log")

                                cn.Execute(CleanSTR("INSERT INTO MEMBERS([KBCI_NO],[LNAME],[FNAME],[MI],[MEM_CODE],[MEM_STAT],[MEM_DATE],[BY_WHOM],[CB_EMPNO],[CB_HIRE],[DEPT],[REGION],[OFF_TEL],[DORI],[REA_DORI],[SEX],[B_DATE],[CIV_STAT],[MEM_ADDR],[RES_TEL],[POSITION],[SAL_BAS],[SAL_ALL],[OTH_INC],[FEBTC_SA],[FEBTC_CA],[FD_CERTNO],[FD_DATE],[AP_AMOUNT],[AR_AMOUNT],[FD_AMOUNT],[SD_AMOUNT],[TD_AMOUNT],[OTH_AMOUNT],[YTD_DIVAMT],[YTD_LRI],[REM_PROP],[REM_VALUE],[NO_DEPEND],[SP_NAME],[SP_EMPLOY],[SP_OFFTEL],[SP_CBEMPNO],[SP_KBCINO],[SP_SALARY],[APRUN_AMT],[ARRUN_AMT],[RUN_AMT],[ADD_DATE],[CHG_DATE],[USER],[REC_STAT],[FD_CNTR]) " & _
                                "VALUES    ('" & KBCINUM & "','" & TextBox1.Text.ToUpper & "','" & TextBox4.Text.ToUpper & "','" & TextBox5.Text.ToUpper & "','" & Mid(ComboBox3.Text.ToUpper, 1, 1) & "','A','" & SYSDATE & "','" & CLUSER & "','" & TextBox10.Text.ToUpper & "','" & DateValue(DateTimePicker2.Value.ToString) & "','" & ComboBox6.Text.ToUpper & "','" & TextBox16.Text.ToUpper & "','" & Trim(MaskEdBox2.CtlText.ToUpper.Replace("-", "") & AxMaskEdBox3.CtlText) & "','" & CheckBox1.Checked.ToString & "','" & TextBox13.Text.ToUpper & "','" & Mid(ComboBox1.Text.ToUpper, 1, 1) & "','" & DateValue(DateTimePicker1.Value.ToString) & "','" & Mid(ComboBox2.Text.ToUpper, 1, 1) & "','" & TextBox2.Text.ToUpper & "','" & Trim(MaskEdBox1.CtlText.Replace("-", "")) & "','" & _
                                                 ComboBox4.Text.ToUpper & "'," & Decimal.Round(TextBox15.Text, 2) & "," & Decimal.Round(TextBox17.Text, 2) & "," & Decimal.Round(Val(TextBox28.Text), 2) & ",'" & TextBox12.Text.Replace("-", "") & "','" & TextBox14.Text.Replace("-", "") & "','','',0.00,0.00," & Decimal.Round(TextBox25.Text, 2) & "," & Decimal.Round(TextBox23.Text, 2) & ",0.00,0.00,0.00,0.00,'MEMO'," & Decimal.Round(TextBox7.Text, 2) & "," & Val(AxMaskEdBox1.CtlText) & ",'" & TextBox19.Text.ToUpper & "','" & TextBox20.Text.ToUpper & "','" & Trim(AxMaskEdBox2.CtlText.Replace("-", "") & AxMaskEdBox4.CtlText) & "','" & TextBox21.Text.ToUpper & "','" & TextBox18.Text.ToUpper & "'," & Decimal.Round(TextBox22.Text, 2) & _
                                                ",0.00,0.00,0.00,'" & SYSDATE & "','" & SYSDATE & "','" & CLUSER & "','False',0)"))
                                If Decimal.Round(TextBox25.Text, 2) > 0 Then
                                    'WLOG(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                    '                            "VALUES('" & KBCINUM & "','1','" & SYSDATE & "','INITIAL'," & Decimal.Round(TextBox25.Text, 2) & "," & Decimal.Round(TextBox25.Text, 2) & ",'INITIAL SETUP','" & SYSDATE & "','" & CLUSER & "',0,'CR','','','True','False')"), App_Path() & "SQLTRAN.log")

                                    cn.Execute(CleanSTR("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                             "VALUES('" & KBCINUM & "','1','" & SYSDATE & "','INITIAL'," & Decimal.Round(TextBox25.Text, 2) & "," & Decimal.Round(TextBox25.Text, 2) & ",'INITIAL SETUP','" & SYSDATE & "','" & CLUSER & "',0,'CR','','','True','False')"))
                                End If
                                'WLOG("UPDATE CTRL SET KBCI_NO='" & KBCINUM & "'", App_Path() & "SQLTRAN.log")
                                cn.Execute("UPDATE CTRL SET KBCI_NO='" & KBCINUM & "'")
                                rsCTL.Requery()
                                rsMEMBERS.Requery() : rsMEMBERS.MoveFirst()
                                FillField()
                                .Buttons(8).Text = "EXIT"
                            End If
                        Else
                            shwReq(True)
                        End If
                    End If
                Case 1
                    If .Buttons(IDX).Text = "EDIT" Then
                        shwReq(False)
                        EDTool(ToolBar1, False)
                        .Buttons(IDX).Text = "SAVE" : .Buttons(8).Text = "CANCEL"
                        .Buttons(IDX).Enabled = True
                        GroupBox1.Enabled = True
                        TextBox1.Focus()
                    Else
                        If valTXT() Then
                            Dim MSG As String
                            MSG = MsgBox("Would you like to apply the changes for this member?", MsgBoxStyle.Information.YesNo, "Add New Member")
                            If MSG = vbYes Then
                                EDTool(ToolBar1, True)
                                .Buttons(IDX).Text = "EDIT"
                                GroupBox1.Enabled = False
                                '    WLOG("UPDATE MEMBERS SET [LNAME]='" & TextBox1.Text.ToUpper & "',[FNAME]='" & TextBox4.Text.ToUpper & "',[MI]='" & TextBox5.Text.ToUpper & "',[MEM_CODE]='" & Mid(ComboBox3.Text.ToUpper, 1, 1) & _
                                '"',[CB_EMPNO]='" & TextBox10.Text.ToUpper & "',[CB_HIRE]='" & DateValue(DateTimePicker2.Value.ToString) & "',[DEPT]='" & ComboBox6.Text.ToUpper & "',[REGION]='" & TextBox16.Text.ToUpper & "',[OFF_TEL]='" & Trim(MaskEdBox2.CtlText.ToUpper.Replace("-", "") & AxMaskEdBox3.CtlText) & _
                                '"',[DORI]='" & CheckBox1.Checked.ToString & "',[REA_DORI]='" & TextBox13.Text.ToUpper & "',[SEX]='" & Mid(ComboBox1.Text.ToUpper, 1, 1) & "',[B_DATE]='" & DateValue(DateTimePicker1.Value.ToString) & "',[CIV_STAT]='" & Mid(ComboBox2.Text.ToUpper, 1, 1) & "',[MEM_ADDR]='" & TextBox2.Text.ToUpper & _
                                '"',[RES_TEL]='" & Trim(MaskEdBox1.CtlText.Replace("-", "")) & "',[POSITION]='" & ComboBox4.Text.ToUpper & "',[SAL_BAS]=" & Decimal.Round(TextBox15.Text, 2) & ",[SAL_ALL]=" & Decimal.Round(TextBox17.Text, 2) & _
                                ' ",[OTH_INC]=" & Decimal.Round(TextBox28.Text, 2) & ",[FEBTC_SA]='" & TextBox12.Text.Replace("-", "") & "',[FEBTC_CA]='" & TextBox14.Text.Replace("-", "") & "',[REM_VALUE]=" & Decimal.Round(TextBox7.Text, 2) & _
                                ' ",[NO_DEPEND]=" & Val(AxMaskEdBox1.CtlText) & ",[SP_NAME]='" & TextBox19.Text.ToUpper & "',[SP_EMPLOY]='" & TextBox20.Text.ToUpper & "',[SP_OFFTEL]='" & Trim(AxMaskEdBox2.CtlText.Replace("-", "") & AxMaskEdBox4.CtlText) & _
                                '"',[SP_CBEMPNO]='" & TextBox21.Text.ToUpper & "',[SP_KBCINO]='" & TextBox18.Text.ToUpper & "',[SP_SALARY]=" & Decimal.Round(TextBox22.Text, 2) & ",[CHG_DATE]='" & SYSDATE & "',[USER]='" & CLUSER & "',[CHG_DATE]='" & DateValue(SYSDATE) & "',[REC_STAT]='False',[FD_CNTR]=0 WHERE KBCI_NO ='" & TextBox3.Text.Replace("-", "") & "'", App_Path() & "SQLTRAN.log")

                                cn.Execute("UPDATE MEMBERS SET [LNAME]='" & TextBox1.Text.ToUpper & "',[FNAME]='" & TextBox4.Text.ToUpper & "',[MI]='" & TextBox5.Text.ToUpper & "',[MEM_CODE]='" & Mid(ComboBox3.Text.ToUpper, 1, 1) & _
                                                            "',[CB_EMPNO]='" & TextBox10.Text.ToUpper & "',[CB_HIRE]='" & DateValue(DateTimePicker2.Value.ToString) & "',[DEPT]='" & ComboBox6.Text.ToUpper & "',[REGION]='" & TextBox16.Text.ToUpper & "',[OFF_TEL]='" & Trim(MaskEdBox2.CtlText.ToUpper.Replace("-", "") & AxMaskEdBox3.CtlText) & _
                                                            "',[DORI]='" & CheckBox1.Checked.ToString & "',[REA_DORI]='" & TextBox13.Text.ToUpper & "',[SEX]='" & Mid(ComboBox1.Text.ToUpper, 1, 1) & "',[B_DATE]='" & DateValue(DateTimePicker1.Value.ToString) & "',[CIV_STAT]='" & Mid(ComboBox2.Text.ToUpper, 1, 1) & "',[MEM_ADDR]='" & TextBox2.Text.ToUpper & _
                                                            "',[RES_TEL]='" & Trim(MaskEdBox1.CtlText.Replace("-", "")) & "',[POSITION]='" & ComboBox4.Text.ToUpper & "',[SAL_BAS]=" & Decimal.Round(TextBox15.Text, 2) & ",[SAL_ALL]=" & Decimal.Round(TextBox17.Text, 2) & _
                                                             ",[OTH_INC]=" & Decimal.Round(TextBox28.Text, 2) & ",[FEBTC_SA]='" & TextBox12.Text.Replace("-", "") & "',[FEBTC_CA]='" & TextBox14.Text.Replace("-", "") & "',[REM_VALUE]=" & Decimal.Round(TextBox7.Text, 2) & _
                                                             ",[NO_DEPEND]=" & Val(AxMaskEdBox1.CtlText) & ",[SP_NAME]='" & TextBox19.Text.ToUpper & "',[SP_EMPLOY]='" & TextBox20.Text.ToUpper & "',[SP_OFFTEL]='" & Trim(AxMaskEdBox2.CtlText.Replace("-", "") & AxMaskEdBox4.CtlText) & _
                                                            "',[SP_CBEMPNO]='" & TextBox21.Text.ToUpper & "',[SP_KBCINO]='" & TextBox18.Text.ToUpper & "',[SP_SALARY]=" & Decimal.Round(TextBox22.Text, 2) & ",[CHG_DATE]='" & SYSDATE & "',[USER]='" & CLUSER & "',[REC_STAT]='False',[FD_CNTR]=0 WHERE KBCI_NO ='" & TextBox3.Text.Replace("-", "") & "'")
                                .Buttons(8).Text = "EXIT"
                                rsMEMBERS.Requery() : rsMEMBERS.MoveFirst()
                                FillField()
                            End If
                        Else
                            shwReq(True)
                        End If
                    End If

                Case 2

                Case 4
                    Dim frmFDS_Main_PrntFDL_Srch As New frmFDS_Main_PrntFDL_Srch
                    frmFDS_Main_PrntFDL_Srch.ShowDialog()
                    If SW = True Then
                        rsMEMBERS.MoveFirst()
                        rsMEMBERS.Find("KBCI_NO=" & SEL_KBCI_NO.Trim.Replace("-", ""))
                        FillField()
                    End If
                Case 5
                    If rsMEMBERS.AbsolutePosition <= 1 Then Exit Sub
                    rsMEMBERS.MovePrevious() : FillField()
                Case 6
                    If rsMEMBERS.AbsolutePosition >= rsMEMBERS.RecordCount Then Exit Sub
                    rsMEMBERS.MoveNext() : FillField()
                Case 8
                    If .Buttons(IDX).Text = "CANCEL" Then
                        If .Buttons(0).Text = "SAVE" Then RstFrm()
                        shwReq(False)
                        EDTool(ToolBar1, True)
                        GroupBox1.Enabled = False
                        .Buttons(0).Text = "ADD NEW" : .Buttons(1).Text = "EDIT"
                        .Buttons(IDX).Text = "EXIT"
                    Else
                        ClsForm(Me, rsMEMBERS)
                    End If
                Case Else
            End Select
        End With
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Sub EDTool(ByRef TB As ToolBar, ByVal SW As Boolean)
        Dim x As Integer
        For x = 0 To TB.Buttons.Count - 2
            TB.Buttons(x).Enabled = SW
        Next
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Function valTXT() As Boolean
        Dim Control, gControl, G2Control As Control
        For Each Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                For Each gControl In Control.Controls
                    If TypeOf gControl Is GroupBox Then
                        For Each G2Control In gControl.Controls
                            If TypeOf G2Control Is TextBox Or TypeOf G2Control Is ComboBox Then
                                If Mid(CStr(G2Control.Tag), 1, 1) = "*" And Trim(G2Control.Text = "") Then MsgBox("Please Fill-out all the required fields (*)", MsgBoxStyle.Critical, "ERROR") : Return False
                            ElseIf TypeOf G2Control Is AxMSMask.AxMaskEdBox Then
                                Dim Mask As AxMSMask.AxMaskEdBox = G2Control
                                If Mid(CStr(G2Control.Tag), 1, 1) = "*" And Trim(Mid(Mask.CtlText, 1, 1)) = "" Then MsgBox("Please Fill-out all the required fields (*)", MsgBoxStyle.Critical, "ERROR") : Return False
                            End If
                        Next
                    End If
                Next
                If TypeOf Control Is TextBox Then
                    If CStr(Control.Tag) = "*" And Trim(Control.Text) = "" Then MsgBox("Please Fill-out all the required fields (*)", MsgBoxStyle.Critical, "ERROR") : Return False
                End If
            End If
        Next Control
        Return True
    End Function
    Sub shwReq(ByVal Shw As Boolean)
        Dim Control, gControl, G2Control As Control
        For Each Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                For Each gControl In Control.Controls
                    If TypeOf gControl Is GroupBox Then
                        For Each G2Control In gControl.Controls
                            If TypeOf G2Control Is Label Then
                                If Trim(G2Control.Text) = "*" Then G2Control.Visible = Shw
                            End If
                        Next
                    End If
                Next
            End If
        Next
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub frmFDS_Main_NMem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim qry As String
        qry = "SELECT KBCI_NO, LNAME, FNAME, MI, MEM_CODE, CB_EMPNO, CB_HIRE, DEPT, Region, OFF_TEL,DORI,REA_DORI," & _
                "SEX,B_DATE,CIV_STAT,MEM_ADDR,RES_TEL,POSITION,SAL_BAS,SAL_ALL,OTH_INC,FEBTC_SA,FEBTC_CA,REM_VALUE," & _
                "REM_VALUE,NO_DEPEND,SP_NAME,SP_EMPLOY,SP_OFFTEL,SP_CBEMPNO,SP_KBCINO,SP_SALARY,FD_AMOUNT,SD_AMOUNT FROM MEMBERS"
        rsMEMBERS.Open(qry, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        rsMEMBERS.MoveFirst()
        FillField()
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(TextBox1.Tag)
        MsgBox("'" & MaskEdBox1.CtlText & "'")
        MaskEdBox1.CtlText = "123-4566"
        MsgBox("'" & Trim(MaskEdBox2.CtlText) & "'")
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateValue(DateTimePicker1.Value) <= DateValue(Now) Then
            Label30.Text = (DateDiff(DateInterval.Month, DateTimePicker1.Value, Now) - (DateDiff(DateInterval.Month, DateTimePicker1.Value, Now) Mod 12)) / 12
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Sub RstFrm()
        Dim Control, gControl, G2Control As Control
        For Each Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                For Each gControl In Control.Controls
                    If TypeOf gControl Is GroupBox Then
                        For Each G2Control In gControl.Controls
                            If TypeOf G2Control Is TextBox Or TypeOf G2Control Is ComboBox Then
                                G2Control.Text = ""
                            ElseIf TypeOf G2Control Is DateTimePicker Then
                                Dim DTP As DateTimePicker = G2Control
                                DTP.Value = DateValue(Now)
                            ElseIf TypeOf G2Control Is CheckBox Then
                                Dim CHK As CheckBox = G2Control
                                CHK.Checked = False
                            End If
                        Next
                    End If
                Next
            End If
        Next Control
        TextBox7.Text = "0.00" : TextBox15.Text = "0.00" : TextBox17.Text = "0.00" : TextBox28.Text = "0.00"
        TextBox25.Text = "0.00" : TextBox23.Text = "0.00" : TextBox22.Text = "0.00" : Label30.Text = "0" : Label50.Text = ""
        MaskEdBox2.CtlText = "   -    " : AxMaskEdBox2.CtlText = "   -    "
        MaskEdBox1.CtlText = "   -    " : AxMaskEdBox1.CtlText = "  "
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.LostFocus
        If Trim(TextBox18.Text) <> "" Then
            rsMEMBERS.Filter = adFilterNone
            rsMEMBERS.Filter = "KBCI_NO=" & Trim(TextBox18.Text)
            If rsMEMBERS.RecordCount < 1 Then
                MsgBox("KBCI No: [" & TextBox18.Text & "] is not found on the database.")
                TextBox18.Text = ""
            End If
            rsMEMBERS.Filter = adFilterNone
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        Label33.Text = Mid(CStr(TextBox1.Tag), 2)
    End Sub

    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.GotFocus
        Label33.Text = Mid(CStr(TextBox4.Tag), 2)
    End Sub
    Private Sub ComboBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.GotFocus
        Label33.Text = Mid(CStr(ComboBox3.Tag), 2)
    End Sub
    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        Label33.Text = Mid(CStr(TextBox5.Tag), 2)
    End Sub
    Private Sub CheckBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.LostFocus
        If CheckBox1.Checked = True Then TextBox13.Focus()
    End Sub
    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus
        If CheckBox1.Checked = True And Trim(TextBox13.Text) = "" Then
            MsgBox("Please specify the reason why Applicant is considered DORI", MsgBoxStyle.Information, "New Member")
            CheckBox1.Checked = False : TextBox13.Text = ""
        End If
    End Sub
    Private Sub TextBox12_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.LostFocus
        If Trim(TextBox12.Text.Replace("-", "")) <> "" Then TextBox12.Text = ValAcct(TextBox12.Text.Replace("-", ""))
    End Sub
    Function ValAcct(ByRef TXT As String) As String
        Dim v, v2, i, chk As Integer
        Dim tot As Integer = 0
        Dim s As String
        i = 10
        v = Val(Mid(TXT, 3, 2))
        v2 = Microsoft.VisualBasic.Right(Trim(TXT), 6)
        s = Microsoft.VisualBasic.Left(Trim(TXT), 2)
        If IsNumeric(TXT) And Len(Trim(TXT)) = 10 And (s = "00" Or s = "01" Or s = "51" Or s = "50") Then
            If (s = "00" Or s = "01") And v < 0 Then
                MsgBox("INVALID ACCOUNT TYPE", MsgBoxStyle.Information, "FEBTC S/A - C/A Number") : Exit Function
            ElseIf (s = "50" Or s = "51") And (v < 0 Or v > 31) Then
                MsgBox("INVALID BRANCH CODE", MsgBoxStyle.Information, "FEBTC S/A - C/A Number") : Exit Function
            ElseIf v2 <= 0 Then
                MsgBox("INVALID SERIAL No.", MsgBoxStyle.Information, "FEBTC S/A - C/A Number") : Exit Function
            Else
                For i = 10 To 1 Step -1
                    tot = tot + Val(Mid(Trim(TXT), 11 - i, 1)) * i
                Next
                chk = tot Mod 11
                If chk > 1 Then MsgBox("INVALID CHECK DIGIT", MsgBoxStyle.Information, "FEBTC S/A - C/A Number") : Exit Function
            End If
        Else
            MsgBox("INVALID ACCOUNT No. [" & TXT & "]", MsgBoxStyle.Information, "FEBTC S/A - C/A Number") : Exit Function
        End If
        s = Mid(TXT, 1, 4) & "-" & Mid(TXT, 5, 5) & "-" & Mid(TXT, 10, 1)
        Return s
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Function

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox14_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.LostFocus
        If Trim(TextBox14.Text.Replace("-", "")) <> "" Then TextBox14.Text = ValAcct(TextBox14.Text.Replace("-", ""))
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateValue(DateTimePicker2.Value) <= DateValue(Now) Then
            Label50.Text = (DateDiff(DateInterval.Month, DateTimePicker2.Value, Now) - (DateDiff(DateInterval.Month, DateTimePicker2.Value, Now) Mod 12)) / 12 & " YEAR(S), " & DateDiff(DateInterval.Month, DateTimePicker2.Value, Now) Mod 12 & " MONTH(S)."
        End If
    End Sub

    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        If IsNumeric(TextBox15.Text) Then TextBox15.Text = FormatNumber(TextBox15.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox15.Text = "0.00"
    End Sub

    Private Sub TextBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.LostFocus
        If IsNumeric(TextBox17.Text) Then TextBox17.Text = FormatNumber(TextBox17.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox17.Text = "0.00"
    End Sub
    Private Sub TextBox28_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox28.LostFocus
        If IsNumeric(TextBox28.Text) Then TextBox28.Text = FormatNumber(TextBox28.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox28.Text = "0.00"
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        If IsNumeric(TextBox7.Text) Then TextBox7.Text = FormatNumber(TextBox7.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox7.Text = "0.00"
    End Sub
    Private Sub TextBox22_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox22.LostFocus
        If IsNumeric(TextBox22.Text) Then TextBox22.Text = FormatNumber(Val(TextBox22.Text), 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox22.Text = "0.00"
    End Sub
    Private Sub TextBox25_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox25.LostFocus
        If IsNumeric(TextBox25.Text) Then TextBox25.Text = FormatNumber(TextBox25.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox25.Text = "0.00"
    End Sub
    Private Sub TextBox23_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox23.LostFocus
        If IsNumeric(TextBox23.Text) Then TextBox23.Text = FormatNumber(TextBox23.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox23.Text = "0.00"
    End Sub
    Sub FillField()
        'On Error Resume Next
        With rsMEMBERS
            If Not IsDBNull(.Fields("KBCI_NO").Value) Then TextBox3.Text = Mid(.Fields("KBCI_NO").Value, 1, 2) & "-" & Mid(.Fields("KBCI_NO").Value, 3, 4) & "-" & Mid(.Fields("KBCI_NO").Value, 7, 1) Else TextBox3.Text = ""
            If Not IsDBNull(.Fields("LNAME").Value) Then TextBox1.Text = .Fields("LNAME").Value Else TextBox1.Text = ""
            If Not IsDBNull(.Fields("FNAME").Value) Then TextBox4.Text = .Fields("FNAME").Value Else TextBox4.Text = ""
            If Not IsDBNull(.Fields("MI").Value) Then TextBox5.Text = .Fields("MI").Value Else TextBox5.Text = ""
            If Not IsDBNull(.Fields("MEM_CODE").Value) Then ComboBox3.Text = .Fields("MEM_CODE").Value Else ComboBox3.Text = ""
            If Not IsDBNull(.Fields("CB_EMPNO").Value) Then TextBox10.Text = .Fields("CB_EMPNO").Value Else TextBox10.Text = ""
            If Not IsDBNull(.Fields("CB_HIRE").Value) Then DateTimePicker2.Value = DateValue(.Fields("CB_HIRE").Value) Else DateTimePicker2.Value = Now
            If Not IsDBNull(.Fields("DEPT").Value) Then ComboBox6.Text = .Fields("DEPT").Value Else ComboBox6.Text = ""
            If Not IsDBNull(.Fields("Region").Value) Then TextBox16.Text = .Fields("Region").Value Else TextBox16.Text = ""
            If Not IsDBNull(.Fields("OFF_TEL").Value) Then MaskEdBox2.CtlText = Mid(.Fields("OFF_TEL").Value, 1, 3).PadLeft(3) & "-" & Mid(.Fields("OFF_TEL").Value, 4, 4).PadLeft(4) Else MaskEdBox2.CtlText = "   -    "
            If Not IsDBNull(.Fields("OFF_TEL").Value) Then AxMaskEdBox3.CtlText = Mid(.Fields("OFF_TEL").Value, 8, 4).PadLeft(4) Else AxMaskEdBox3.CtlText = "    "
            If Not IsDBNull(.Fields("DORI").Value) Then CheckBox1.Checked = CBool(.Fields("DORI").Value) Else CheckBox1.Checked = False
            If Not IsDBNull(.Fields("REA_DORI").Value) Then TextBox13.Text = .Fields("REA_DORI").Value Else TextBox13.Text = ""
            If Not IsDBNull(.Fields("SEX").Value) Then ComboBox1.Text = .Fields("SEX").Value Else ComboBox1.Text = ""
            If Not IsDBNull(.Fields("B_DATE").Value) Then DateTimePicker1.Value = DateValue(.Fields("B_DATE").Value) Else DateTimePicker1.Value = Now
            If Not IsDBNull(.Fields("CIV_STAT").Value) Then ComboBox2.Text = .Fields("CIV_STAT").Value Else ComboBox2.Text = ""
            If Not IsDBNull(.Fields("MEM_ADDR").Value) Then TextBox2.Text = .Fields("MEM_ADDR").Value Else TextBox2.Text = ""

            If Not IsDBNull(.Fields("RES_TEL").Value) Then MaskEdBox1.CtlText = Mid(.Fields("RES_TEL").Value, 1, 3).PadLeft(3) & "-" & Mid(.Fields("RES_TEL").Value, 4, 4).PadLeft(4) Else MaskEdBox1.CtlText = "   -    "
            If Not IsDBNull(.Fields("POSITION").Value) Then ComboBox4.Text = .Fields("POSITION").Value Else ComboBox4.Text = ""
            If Not IsDBNull(.Fields("SAL_BAS").Value) Then TextBox15.Text = FormatNumber(.Fields("SAL_BAS").Value, 2) Else TextBox15.Text = "0.00"
            If Not IsDBNull(.Fields("SAL_ALL").Value) Then TextBox17.Text = FormatNumber(.Fields("SAL_ALL").Value, 2) Else TextBox17.Text = "0.00"
            If Not IsDBNull(.Fields("OTH_INC").Value) Then TextBox28.Text = FormatNumber(.Fields("OTH_INC").Value, 2) Else TextBox28.Text = "0.00"
            If Not IsDBNull(.Fields("FEBTC_SA").Value) Then TextBox12.Text = Mid(.Fields("FEBTC_SA").Value, 1, 4) & "-" & Mid(.Fields("FEBTC_SA").Value, 5, 5) & "-" & Mid(.Fields("FEBTC_SA").Value, 10, 1) Else TextBox12.Text = ""
            If Not IsDBNull(.Fields("FEBTC_CA").Value) Then TextBox14.Text = Mid(.Fields("FEBTC_CA").Value, 1, 4) & "-" & Mid(.Fields("FEBTC_CA").Value, 5, 5) & "-" & Mid(.Fields("FEBTC_CA").Value, 10, 1) Else TextBox14.Text = ""

            If Not IsDBNull(.Fields("REM_VALUE").Value) Then TextBox7.Text = FormatNumber(.Fields("REM_VALUE").Value, 2) Else TextBox7.Text = "0.00"
            If Not IsDBNull(.Fields("NO_DEPEND").Value) Then AxMaskEdBox1.CtlText = CStr(.Fields("NO_DEPEND").Value).PadLeft(2) Else AxMaskEdBox1.CtlText = "  "
            If Not IsDBNull(.Fields("SP_NAME").Value) Then TextBox19.Text = .Fields("SP_NAME").Value Else TextBox19.Text = ""
            If Not IsDBNull(.Fields("SP_EMPLOY").Value) Then TextBox20.Text = .Fields("SP_EMPLOY").Value Else TextBox20.Text = ""
            If Not IsDBNull(.Fields("SP_OFFTEL").Value) Then AxMaskEdBox2.CtlText = Mid(.Fields("SP_OFFTEL").Value, 1, 3).PadLeft(3) & "-" & Mid(.Fields("SP_OFFTEL").Value, 4, 4).PadLeft(4) Else AxMaskEdBox2.CtlText = "   -    "
            If Not IsDBNull(.Fields("SP_OFFTEL").Value) Then AxMaskEdBox4.CtlText = Mid(.Fields("SP_OFFTEL").Value, 8, 4).PadLeft(4) Else AxMaskEdBox4.CtlText = "    "
            If Not IsDBNull(.Fields("SP_CBEMPNO").Value) Then TextBox21.Text = .Fields("SP_CBEMPNO").Value Else TextBox21.Text = ""
            If Not IsDBNull(.Fields("SP_KBCINO").Value) Then TextBox18.Text = .Fields("SP_KBCINO").Value Else TextBox18.Text = ""
            If Not IsDBNull(.Fields("SP_SALARY").Value) Then TextBox22.Text = FormatNumber(.Fields("SP_SALARY").Value, 2) Else TextBox22.Text = FormatNumber("0", 2)
            If Not IsDBNull(.Fields("FD_AMOUNT").Value) Then TextBox25.Text = FormatNumber(.Fields("FD_AMOUNT").Value, 2) Else TextBox25.Text = FormatNumber("0", 2)
            If Not IsDBNull(.Fields("SD_AMOUNT").Value) Then TextBox23.Text = FormatNumber(.Fields("SD_AMOUNT").Value, 2) Else TextBox23.Text = FormatNumber("0", 2)

        End With
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub

    Private Sub frmFDS_Main_NMem_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If rsMEMBERS.State = 1 Then rsMEMBERS.Close()
    End Sub
End Class

