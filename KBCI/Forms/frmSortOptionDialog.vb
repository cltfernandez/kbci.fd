Imports FD.Common
Imports FD.Common.Utilities
Imports System.Collections.Generic

Public Class frmSortOptionDialog
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSortOptionDialog))
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(19, 34)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox3.TabIndex = 5
        Me.ComboBox3.Tag = "*Enter Membership Code:  [M] - Member  [I] - Investor"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&OK"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(106, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancel"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Arranged by:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(19, 60)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(173, 21)
        Me.TextBox6.TabIndex = 15
        '
        'frmSortOptionDialog
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(208, 128)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSortOptionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _SelectedField As String
    Public Property SelectedField() As String
        Get
            Return _SelectedField
        End Get
        Set(ByVal value As String)
            _SelectedField = value
        End Set
    End Property


    Private _SelectedRegion As String
    Public Property SelectedRegion() As String
        Get
            Return _SelectedRegion
        End Get
        Set(ByVal value As String)
            _SelectedRegion = value
        End Set
    End Property

    Private SortOptionItems As New List(Of KeyValuePair(Of String, String))


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not ComboBox3.SelectedItem.Value.Equals(String.Empty) Then
            SelectedField = ComboBox3.SelectedItem.Value
            SelectedRegion = TextBox6.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem.Value = SortOptions.Region Then
            TextBox6.Enabled = True
        Else : TextBox6.Enabled = False : TextBox6.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSortOptionDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox3.Items.Clear()
        ComboBox3.DisplayMember = "Text"
        ComboBox3.ValueMember = "Value"

        ComboBox3.Items.Add(New With {Key .Value = SortOptions.KbciNumber, Key .Text = GetGlobalResourceString("KBCINumber")})
        ComboBox3.Items.Add(New With {Key .Value = SortOptions.Name, Key .Text = GetGlobalResourceString("Name")})
        ComboBox3.Items.Add(New With {Key .Value = SortOptions.Region, Key .Text = GetGlobalResourceString("Region")})
        ComboBox3.SelectedIndex = 0
    End Sub
End Class
