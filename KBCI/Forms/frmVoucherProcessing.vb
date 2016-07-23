Imports FD.DataAccessObject
Imports FD.Common
Imports FD.Common.Utilities
Imports FD.ViewModels
Public Class frmVoucherProcessing
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
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucherProcessing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ENTRIES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(19, 86)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 121)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DESCRIPTION"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "AMOUNT"
        Me.ColumnHeader2.Width = 150
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "AMOUNT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(384, 34)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(134, 21)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "0.00"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(19, 34)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(355, 21)
        Me.TextBox6.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DESCRIPTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(300, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 25)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Process"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(440, 427)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 25)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "&Close"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(77, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(352, 35)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "DIVIDEND VOUCHER PROCESSING"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(633, 53)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 79)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(382, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Label10"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "AVAILABLE :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "PAT REF :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(111, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 18)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Label10"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "CASH DIV :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox3.Location = New System.Drawing.Point(111, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 17)
        Me.TextBox3.TabIndex = 49
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(352, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 25)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(438, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Remove"
        '
        'frmFDS_DVoucher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(588, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDS_DVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim CDT, SVG, TREFAMT, TDIVAMT As Decimal
    Private _CurrentUser As UserViewModel
    Public Property CurrentUser() As UserViewModel
        Get
            Return _CurrentUser
        End Get
        Set(ByVal value As UserViewModel)
            _CurrentUser = value
        End Set
    End Property

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SW = False
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim QRY, msg As String
        If Round(CDbl(Label8.Text), 2) = 0 And ListView1.Items.Count > 2 Then
            SVG = SVG - CDT
            With ListView1
                QRY = "UPDATE DIVREFPH SET [CVNO]='" & CVNo() & "',[SAVINGS]=" & SVG & ",[TDEBDESC1]='" & .Items(0).Text & "',[TDEBAMT1]=" & Round(CDbl(.Items(0).SubItems(1).Text), 2) & "," & _
                            "[TDEBDESC2]='" & .Items(1).Text & "',[TDEBAMT2]=" & Round(CDbl(.Items(1).SubItems(1).Text), 2) & ",[TDEBDESC3]='" & .Items(2).Text & "',[TDEBAMT3]=" & Round(CDbl(.Items(2).SubItems(1).Text), 2) & ", " & _
                            "[USER]='" & CurrentUser.UserName & "' WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "'"
                cn.Execute(QRY)
                QRY = "INSERT INTO DIVREFH([YEAR],[QUARTER],[KBCI_NO],[LNAME],[FNAME],[MI],[FEBTC_SA],[DIVIDEND],[REFUND],[DEDUCTIONS]) " & _
                            "SELECT '" & SELYR & "' YR, '" & SELQTR & "' QTR,KBCI_NO,LNAME,FNAME,MI,FEBTC_SA,DIVIDEND,REFUND,DEDUCTIONS " & _
                            "FROM DIVREF"
                cn.Execute(QRY)
                ListView1.Clear()
                msg = MsgBox("Successfully processed! Would you like to print the Dividend Voucher? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "DIVIDEND VOUCHER")
                If msg = vbYes Then
                    SW = True
                End If
                Me.Close()
            End With
        Else
            MsgBox("Current Totals doesn't match. Please allocate the balance correctly.", MsgBoxStyle.Information, "Dividend Processing")
        End If
    End Sub

    Private Sub frmFDS_DVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rsDV As New ADODB.Recordset
        Dim sqlQ As String
        Dim i As Integer
        Using rsDIVDao As New DivrefphDAO
            Dim param1 As New LUNA.LunaSearchParameter("YEAR", SELYR)
            Dim param2 As New LUNA.LunaSearchParameter("QUARTER", SELQTR)

            rsDIV = rsDIVDao.Find(param1, param2)
            If Not rsDIV Is Nothing Then
                If rsDIV.CVNO.Trim <> String.Empty Or rsDIV.POSTED = True Then
                    MsgBox(String.Format(GetGlobalResourceString("UnableToProcessDivref"), SELYR, SELQTR), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageRefund"))
                    SW = False                    
                    Me.Close()
                    Exit Sub
                End If
            Else
                MsgBox(String.Format(GetGlobalResourceString("DivRefRecordNotFound"), SELYR, SELQTR), MsgBoxStyle.Information, GetGlobalResourceString("DividendPatronageRefund"))
                Me.Close()
                Exit Sub
            End If            
        End Using

        sqlQ = "SELECT ISNULL([P_APL],0) P_APL,ISNULL([P_EDL],0) P_EDL,ISNULL([P_EML],0) P_EML,ISNULL([P_RGL],0) P_RGL,ISNULL([P_RSL],0) P_RSL,ISNULL([P_SPL],0) P_SPL,ISNULL([P_STL],0) P_STL," & _
                "ISNULL([P_PTL],0) P_PTL,ISNULL([PD_APL],0) PD_APL,ISNULL([PD_EDL],0) PD_EDL,ISNULL([PD_EML],0) PD_EML,ISNULL([PD_RGL],0) PD_RGL,ISNULL([PD_RSL],0) PD_RSL,ISNULL([PD_SPL],0) PD_SPL,ISNULL([PD_STL],0) PD_STL," & _
                "ISNULL([PD_PTL],0) PD_PTL,ISNULL([INTEREST],0) INTEREST,ISNULL([PENALTY],0) PENALTY,ISNULL([TDIVAMT],0) TDIVAMT,ISNULL([TREFAMT],0) TREFAMT,ISNULL([SAVINGS],0) SAVINGS FROM DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "'"
        rsDV.Open(sqlQ, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)

        For i = 0 To rsDV.Fields.Count - 2
            If rsDV.Fields(i).Name = "TREFAMT" Or rsDV.Fields(i).Name = "TDIVAMT" Then
                SVG = SVG + Val(rsDV.Fields(i).Value)
            Else
                CDT = CDT + Val(rsDV.Fields(i).Value)
            End If
        Next
        TextBox3.Text = FormatNumber(Val(rsDV.Fields("TDIVAMT").Value), 2)
        Label6.Text = FormatNumber(Val(rsDV.Fields("TREFAMT").Value), 2)
        Label8.Text = FormatNumber(Round(CDbl(TextBox3.Text), 2) + Round(CDbl(Label6.Text), 2), 2)
        rsDV.Close()
    End Sub
    Function CVNo() As String
        Dim TMPCVNo As Integer = Val(rsCTL.VoucherNumber)
        Dim TMPCVNUM As String
        If TMPCVNo >= 999 Then TMPCVNo = 0
        TMPCVNo += 1
        TMPCVNUM = Microsoft.VisualBasic.Right(SYSDATE.ToString, 2) & Microsoft.VisualBasic.Left(SYSDATE.ToString, 2) & _
                    TMPCVNo.ToString.PadLeft(3, "0")
        Return TMPCVNUM
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lv As ListViewItem
        If TextBox6.Text <> "" And TextBox5.Text <> "" And Round(CDbl(TextBox5.Text), 2) > 0 Then
            If ListView1.Items.Count < 3 Then
                lv = ListView1.Items.Add(TextBox6.Text.ToUpper)
                lv.SubItems.Add(TextBox5.Text)
                Label8.Text = FormatNumber(Round(CDbl(Label8.Text), 2) - Round(CDbl(TextBox5.Text), 2), 2)
                TextBox6.Clear() : TextBox5.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ListView1.SelectedItems.Count > 0 Then
            Label8.Text = FormatNumber(Round(CDbl(Label8.Text), 2) + Round(CDbl(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text), 2), 2)
            ListView1.Items(ListView1.SelectedIndices(0)).Remove()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
