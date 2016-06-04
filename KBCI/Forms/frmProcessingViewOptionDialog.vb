Imports FD.BusinessLogic
Imports FD.ViewModels
Public Class frmProcessingViewOptionDialog
    Inherits System.Windows.Forms.Form
    Public Sub New(ByVal svc As IDividendPatronageRefundService)
        Service = svc

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessingViewOptionDialog))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(115, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cancel"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(45, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "&OK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 125)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "YR:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "QTR :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Silver
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.Text = "CURRENT"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(71, 93)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(87, 21)
        Me.NumericUpDown3.TabIndex = 24
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Silver
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 46)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(152, 17)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.Text = "HISTORICAL"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(71, 66)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(87, 21)
        Me.NumericUpDown4.TabIndex = 23
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmProcessingViewOptionDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(190, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProcessingViewOptionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _SelectedYear As Integer
    Public Property SelectedYear() As Integer
        Get
            Return _SelectedYear
        End Get
        Set(ByVal value As Integer)
            _SelectedYear = value
        End Set
    End Property

    Private _SelectedQuarter As Integer
    Public Property SelectedQuarter() As Integer
        Get
            Return _SelectedQuarter
        End Get
        Set(ByVal value As Integer)
            _SelectedQuarter = value
        End Set
    End Property

    Private Service As IDividendPatronageRefundService

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then Me.NumericUpDown3.Enabled = False : Me.NumericUpDown4.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then Me.NumericUpDown3.Enabled = True : Me.NumericUpDown4.Enabled = True
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            ViewOption = FD.Common.ViewOptions.Current
        End If

        If RadioButton2.Checked = True Then
            ViewOption = FD.Common.ViewOptions.History
            SELYR = NumericUpDown4.Value
            SELQTR = NumericUpDown3.Value
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmProcessingViewOptionDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim model As DivrefPostingViewModel = Service.GetLatestDivrefPostingHistory()

        RadioButton1.Checked = True
        _SelectedYear = Integer.Parse(model.YEAR)
        SELYR = SelectedYear
        NumericUpDown4.Value = SelectedYear

        _SelectedQuarter = Int32.Parse(model.QUARTER)
        SELQTR = SelectedYear
        NumericUpDown3.Value = SelectedQuarter
    End Sub
End Class
