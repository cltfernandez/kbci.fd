Public Class frmFDS_Main_DIVPATMain
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
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDS_Main_DIVPATMain))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton4, Me.ToolBarButton9, Me.ToolBarButton3, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton5})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(530, 44)
        Me.ToolBar1.TabIndex = 6
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "ADD NEW"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 0
        Me.ToolBarButton2.Text = "EDIT"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 0
        Me.ToolBarButton4.Text = "DELETE"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        Me.ToolBarButton3.Text = "SEARCH"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 0
        Me.ToolBarButton6.Text = "PREVIOUS"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 0
        Me.ToolBarButton7.Text = "NEXT"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 0
        Me.ToolBarButton5.Text = "EXIT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 50)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(400, 88)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 21)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(400, 64)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 21)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.Text = ""
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Patronage Refund :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dividend :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(80, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(424, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label10"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(376, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Label10"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Savings Acct. No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "KBCI No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox3.Location = New System.Drawing.Point(80, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 16)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "Label10"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(254, Byte), CType(203, Byte))
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(72, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 32)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "CASH DIV. / PAT. REFUND MAINTENANCE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFDS_Main_DIVPATMain
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmFDS_Main_DIVPATMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASH DIV / PAT REFUND MAINTENANCE"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim CTROL As Control
        Dim IDX As Integer = Val(ToolBar1.Buttons.IndexOf(e.Button).ToString)

        With ToolBar1
            Select Case IDX
                Case 0
                    If .Buttons(IDX).Text = "ADD NEW" Then
                        Dim frmFDS_Main_PrntFDL_Srch As New frmFDS_Main_PrntFDL_Srch
                        frmFDS_Main_PrntFDL_Srch.ShowDialog()
                        If SW = True Then
                            TextBox3.Text = SEL_KBCI_NO
                            Label4.Text = SEL_FEBTC
                            Label5.Text = SEL_FNAME
                            EDTool(ToolBar1, False)
                            .Buttons(IDX).Enabled = True
                            .Buttons(IDX).Text = "SAVE" : .Buttons(8).Text = "CANCEL"
                            GroupBox1.Enabled = True
                        End If
                    Else
                        If rsDIVPATMain.RecordCount < 1 Then
                            cn.Execute("insert into divref(kbci_no,lname,fname,mi,febtc_sa,dividend,refund) " & _
                                        "select  mm.kbci_no,mm.lname,mm.fname, mm.mi,mm.febtc_sa," & Decimal.Round(TextBox5.Text, 2) & "," & Decimal.Round(TextBox5.Text, 2) & " " & _
                                        "from members mm where mm.kbci_no='" & SEL_KBCI_NO & "'")
                            MsgBox("Added Succesfully.")
                            rsDIVPATMain.Requery()
                        Else
                            MsgBox("Member is already added")
                        End If                        
                    End If
                Case 1
                    If .Buttons(IDX).Text = "EDIT" Then
                        EDTool(ToolBar1, False)
                        .Buttons(IDX).Enabled = True
                        .Buttons(IDX).Text = "SAVE" : .Buttons(8).Text = "CANCEL"
                        GroupBox1.Enabled = True
                        TextBox5.Focus()
                    Else
                        cn.Execute("UPDATE DIVREF SET [DIVIDEND]=" & Decimal.Round(TextBox5.Text, 2) & ",[REFUND]=" & Decimal.Round(TextBox1.Text, 2) & " WHERE KBCI_NO='" & TextBox3.Text.Replace("-", "") & "'")
                        MsgBox("Updated Succesfully.")
                        rsDIVPATMain.Requery()
                    End If

                Case 2

                Case 4
                    Dim frmFDS_Main_PrntFDL_Srch As New frmFDS_Main_PrntFDL_Srch
                    frmFDS_Main_PrntFDL_Srch.ShowDialog()
                    If SW = True Then
                        rsDIVPATMain.MoveFirst()
                        'MsgBox(SEL_KBCI_NO.Trim.Replace("-", ""))
                        rsDIVPATMain.Find("KBCI_NO=" & SEL_KBCI_NO.Trim.Replace("-", ""))
                        fillField()
                    End If

                Case 5
                    If rsDIVPATMain.AbsolutePosition <= 1 Then Exit Sub
                    rsDIVPATMain.MovePrevious() : fillField()
                Case 6
                    If rsDIVPATMain.AbsolutePosition >= rsDIVPATMain.RecordCount Then Exit Sub
                    rsDIVPATMain.MoveNext() : fillField()
                Case 8
                    If .Buttons(IDX).Text = "CANCEL" Then
                        EDTool(ToolBar1, True)
                        GroupBox1.Enabled = False
                        .Buttons(0).Text = "ADD NEW" : .Buttons(1).Text = "EDIT"
                        .Buttons(IDX).Text = "EXIT"
                    Else
                        ClsForm(Me, rsDIVPATMain)
                    End If
                Case Else
            End Select
        End With
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
    Sub fillField()
        TextBox3.Text = rsDIVPATMain.Fields("KBCI_NO").Value
        Label4.Text = rsDIVPATMain.Fields("FEBTC_SA").Value
        Label5.Text = rsDIVPATMain.Fields("LNAME").Value & ", " & rsDIVPATMain.Fields("FNAME").Value & " " & rsDIVPATMain.Fields("MI").Value & "."
        TextBox5.Text = FormatNumber(rsDIVPATMain.Fields("DIVIDEND").Value, 2)
        TextBox1.Text = FormatNumber(rsDIVPATMain.Fields("REFUND").Value, 2)
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
    Private Sub TextBox5_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If IsNumeric(TextBox1.Text) Then TextBox1.Text = FormatNumber(TextBox1.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox1.Text = "0.00"
    End Sub

    Private Sub frmFDS_Main_DIVPATMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rsDIV.Open("SELECT [CVNO],[POSTED] FROM  DIVREFPH WHERE [YEAR]='" & SELYR & "' AND [QUARTER]='" & SELQTR & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        If rsDIV.RecordCount > 0 Then
            If Not IsDBNull(rsDIV.Fields("CVNO").Value) Or CBool(rsDIV.Fields("POSTED").Value) = True Then
                MsgBox("Unable to process CASH DIVIDEND FOR YEAR:[" & SELYR & "] QUARTER:[" & SELQTR & "]. Please check if the voucher is processed / dividend is posted.", MsgBoxStyle.Information, "CASH DIV/PAT REF PROCESSING")
                rsDIV.Close()
                Me.Close()
                Exit Sub
            End If
        Else
            MsgBox("RECORD NOT FOUND FOR YEAR:[" & SELYR & "] QUARTER:[" & SELQTR & "].", MsgBoxStyle.Information, "CASH DIV/PAT REF PROCESSING")
            rsDIV.Close()
            Me.Close()
            Exit Sub
        End If
        rsDIV.Close()

        If CURSW = True Then
            rsDIVPATMain.Open("SELECT kbci_no,lname,fname,isnull(mi,'X') MI,febtc_sa,isnull(dividend,0.00) DIVIDEND,isnull(refund,0.00) REFUND FROM  DIVREF", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        Else
            rsDIVPATMain.Open("SELECT kbci_no,lname,fname,isnull(mi,'X') MI,febtc_sa,isnull(dividend,0.00) DIVIDEND,isnull(refund,0.00) REFUND FROM  DIVREFH WHERE YEAR='" & SELYR & "' AND QUARTER='" & SELQTR & "'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockReadOnly)
        End If
        If rsDIVPATMain.RecordCount > 0 Then
            rsDIVPATMain.MoveFirst()
            fillField()
        Else
            MsgBox("No Transactions found.", MsgBoxStyle.Information, "CASH DIV/PAT REF Maintenance")
            ClsForm(Me, rsDIVPATMain)
        End If
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", CLUSER)
        End If
    End Sub
End Class
