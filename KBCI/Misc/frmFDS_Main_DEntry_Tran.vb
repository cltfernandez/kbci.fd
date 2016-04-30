Public Class frmFDS_Main_DEntry_Tran
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 392)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(776, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Show History"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 32)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(880, 304)
        Me.ListView1.TabIndex = 1
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Loading..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(760, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Re&versal"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Transaction Listing"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(8, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "&Initialize Passbook"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(488, 344)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "A&dd Transaction"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(624, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Passbook &Update"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KBCI No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KBCI No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KBCI No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(640, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "BALANCE :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(640, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "KBCI No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(624, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Sa&ve && Close"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 64)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Print Line"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(24, 32)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(48, 21)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(760, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Close"
        '
        'frmFDS_Main_DEntry_Tran
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(898, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDS_Main_DEntry_Tran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public frmFDS_Main_DEntry_Tran_Add As frmFDS_Main_DEntry_Tran_Add
    Dim lastLine As Integer
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'SET KBCI_NO and FD_AMOUNT to a Variable
        'Loads Transaction Add Window
        'Checks  if there are commited transactions (Local DB),
        'then
        frmFDS_Main_DEntry_Tran_Add = New frmFDS_Main_DEntry_Tran_Add
        frmFDS_Main_DEntry_Tran_Add.ShowDialog()
        UPDT_frmFDS_Main_DEntry_Tran()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            rsFD_Mem.Filter = ADODB.FilterGroupEnum.adFilterNone
        Else
            rsFD_Mem.Filter = "DATE =" & rsCTL.Fields("SYSDATE").Value
        End If
        FillLV(ListView1, Label5, rsFD_Mem, "0:100:110:59:112:100:373:0")
        If rsFD_Mem.RecordCount > 0 Then ListView1.EnsureVisible(ListView1.Items.Count - 1)
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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sysdate As Date = rsCTL.Fields("SYSDATE").Value
        Dim msg, ref, CRDR As String
        Dim seq As Integer
        msg = MsgBox("Would you like to reverse the last transaction?", MsgBoxStyle.Information.YesNo, "Reversal")
        If msg = vbYes Then
            With rsFD_Mem_L
                .Open("SELECT * FROM FD WHERE DATE=#" & sysdate.ToString("MM /dd/yyyy") & "#", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                If .RecordCount > 0 Then
                    .MoveLast()
                    seq = rsFD_Mem_L.RecordCount + 1
                    If .Fields("DRCR").Value = "CR" Then
                        CRDR = "DR"
                        BALANCE = Decimal.Round(rsMEMBERS_L.Fields("FD_AMOUNT").Value, 2) - Decimal.Round(.Fields("AMOUNT").Value, 2)
                    Else
                        CRDR = "CR"
                        BALANCE = Decimal.Round(rsMEMBERS_L.Fields("FD_AMOUNT").Value, 2) + Decimal.Round(.Fields("AMOUNT").Value, 2)
                    End If
                    ref = sysdate.ToString("yyyyMMdd") & seq.ToString("D2")
                    lcn.Execute("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                         "VALUES('" & .Fields("KBCI_NO").Value & "','5','" & sysdate.ToString("MM /dd/yyyy") & "','" & ref & "'," & .Fields("AMOUNT").Value & "," & BALANCE & ",'" & UCase("REVERSAL:" & .Fields("REF").Value) & "','" & sysdate & "','" & CLUSER & "',0,'" & CRDR & "','','',0,1)")
                    WLOG("UPDATE MEMBERS SET FD_AMOUNT=" & rsMEMBERS_L.Fields("FD_AMOUNT").Value & " WHERE KBCI_NO='" & rsMEMBERS_L.Fields("KBCI_NO").Value & "'", App_Path() & "insert.log")
                    lcn.Execute("UPDATE MEMBERS SET FD_AMOUNT=" & BALANCE & " WHERE KBCI_NO='" & rsMEMBERS_L.Fields("KBCI_NO").Value & "'")
                    SW = True
                    UPDT_frmFDS_Main_DEntry_Tran()
                End If
                .Close()
            End With
        End If
    End Sub
    Private Sub frmFDS_Main_DEntry_Tran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ERRLOG
        If rsFD_Mem.RecordCount > 0 Then
            With rsFD_Mem
                lcn.Execute("DELETE FROM FD")
                Do Until rsFD_Mem.EOF
                    WLOG("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                 "VALUES('" & .Fields("KBCI_NO").Value & "','" & .Fields("TRAN_CODE").Value & "','" & .Fields("DATE").Value & "','" & .Fields("REF").Value & "'," & .Fields("AMOUNT").Value & "," & .Fields("BALANCE").Value & ",'" & .Fields("RMK").Value & _
                                 "','" & .Fields("ADD_DATE").Value & "','" & .Fields("USER").Value & "'," & .Fields("LPOSTED").Value & ",'" & .Fields("DRCR").Value & "','" & .Fields("BANK_CODE").Value & "','" & .Fields("CHECKNO").Value & "'," & .Fields("TPOSTED").Value & "," & .Fields("TREVERSED").Value & ")", App_Path() & "INSERT.log")

                    lcn.Execute("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                 "VALUES('" & .Fields("KBCI_NO").Value & "','" & .Fields("TRAN_CODE").Value & "','" & .Fields("DATE").Value & "','" & .Fields("REF").Value & "'," & .Fields("AMOUNT").Value & "," & .Fields("BALANCE").Value & ",'" & .Fields("RMK").Value & _
                                 "','" & .Fields("ADD_DATE").Value & "','" & .Fields("USER").Value & "'," & .Fields("LPOSTED").Value & ",'" & .Fields("DRCR").Value & "','" & .Fields("BANK_CODE").Value & "','" & .Fields("CHECKNO").Value & "'," & .Fields("TPOSTED").Value & "," & .Fields("TREVERSED").Value & ")")
                    .MoveNext()
                Loop
            End With
            rsFD_Mem.Close()
            rsFD_Mem.Open("SELECT FD.KBCI_NO,FD.DATE,FD.REF AS  REFERENCE,TC.TR_CODE AS CODE,FD.AMOUNT,FD.BALANCE,FD.RMK AS  REMARKS,TPOSTED,LPOSTED FROM FD INNER JOIN TRANCODE TC ON FD.TRAN_CODE=TC.TR_ID  ORDER BY FD.DATE, FD.REF ASC", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
            rsFD_Mem.Filter = "DATE =" & rsCTL.Fields("SYSDATE").Value
            FillLV(ListView1, Label5, rsFD_Mem, "0:100:110:67:112:100:365:0:0")
            If rsFD_Mem.RecordCount > 0 Then Button2.Enabled = True Else Button2.Enabled = False
        Else
            MsgBox("MEMBER HAS NO TRANSACTIONS.", MsgBoxStyle.Exclamation, "Information")
        End If
ERRLOG:
        If Err.Number <> 0 Then
            WLOG("[" & Now & "] frmFDS_Main_DEntry_Tran_Load:" & Err.Description, App_Path() & "ERROR." & Now.ToString("MMddyyyy") & ".log")
            MsgBox("[" & Now & "] frmFDS_Main_DEntry_Tran_Load:" & Err.Description, MsgBoxStyle.Critical, "Critical Error")
            Resume ERRLOG
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim msg2 As String
        If SW = True Then
            msg2 = MsgBox("Would you like to Post the transactions to the master file?", vbQuestion & vbYesNo, "Commit Transaction")
            If msg2 = vbYes Then
                rsFD_Mem.Close()
                rsFD_Mem.Open("SELECT * FROM FD WHERE TPOSTED=0", lcn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                Do Until rsFD_Mem.EOF
                    With rsFD_Mem
                        WLOG("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                     "VALUES('" & .Fields("KBCI_NO").Value & "','" & .Fields("TRAN_CODE").Value & "','" & .Fields("DATE").Value & "','" & .Fields("REF").Value & "'," & .Fields("AMOUNT").Value & "," & .Fields("BALANCE").Value & ",'" & .Fields("RMK").Value & _
                                     "','" & .Fields("DATE").Value & "','" & CLUSER & "',0,'" & .Fields("DRCR").Value & "','" & .Fields("BANK_CODE").Value & "','" & .Fields("CHECKNO").Value & "',1,'" & .Fields("TREVERSED").Value & "')", App_Path() & "INSERT.log")

                        cn.Execute("INSERT INTO FD([KBCI_NO],[TRAN_CODE],[DATE],[REF],[AMOUNT],[BALANCE],[RMK],[ADD_DATE],[USER] ,[LPOSTED],[DRCR],[BANK_CODE],[CHECKNO],[TPOSTED],[TREVERSED])" & _
                                     "VALUES('" & .Fields("KBCI_NO").Value & "','" & .Fields("TRAN_CODE").Value & "','" & .Fields("DATE").Value & "','" & .Fields("REF").Value & "'," & .Fields("AMOUNT").Value & "," & .Fields("BALANCE").Value & ",'" & .Fields("RMK").Value & _
                                     "','" & .Fields("DATE").Value & "','" & CLUSER & "',0,'" & .Fields("DRCR").Value & "','" & .Fields("BANK_CODE").Value & "','" & .Fields("CHECKNO").Value & "',1,'" & .Fields("TREVERSED").Value & "')")
                        .MoveNext()
                    End With
                Loop
                cn.Execute("UPDATE MEMBERS SET FD_AMOUNT=" & rsMEMBERS_L.Fields("FD_AMOUNT").Value & " WHERE KBCI_NO='" & rsMEMBERS.Fields("KBCI_NO").Value & "'")
            End If
        Else
            MsgBox("No Transactions were done.", MsgBoxStyle.Information, "Save Transaction")
        End If
        rsMEMBERS_L.Close()
        ClsForm(Me, rsFD_Mem)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub UPDT_frmFDS_Main_DEntry_Tran()
        If SW = True Then
            rsFD_Mem.Requery()
            rsFD_Mem.Filter = "DATE =" & rsCTL.Fields("SYSDATE").Value
            With rsMEMBERS_L
                .Requery()
                Label3.Text = rsMEMBERS_L.Fields("KBCI_NO").Value
                Label2.Text = .Fields("LNAME").Value & ", " & .Fields("FNAME").Value & " " & .Fields("MI").Value & "."
                Label7.Text = FormatNumber(.Fields("FD_AMOUNT").Value, 2, TriState.True)
            End With
            CheckBox1.Checked = False
            FillLV(ListView1, Label5, rsFD_Mem, "0:100:110:59:112:100:373:0")
            If rsFD_Mem.RecordCount > 0 Then Button2.Enabled = True Else Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Button3.Text = "Passbook &Update" Then
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "LPOSTED>2"
            If rsFD_Mem.RecordCount > 0 Then
                rsFD_Mem.MoveLast()
                lastLine = Int(rsFD_Mem.Fields("LPOSTED").Value)
                If lastLine > 24 Then lastLine = 3
            Else
                lastLine = 3
            End If
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "LPOSTED<3"
            If rsFD_Mem.RecordCount > 0 Then
                MsgBox("There are [ " & rsFD_Mem.RecordCount & " ] entries, to be updated to passbook", MsgBoxStyle.Information, "Passbook Update")
                FillLV(ListView1, Label5, rsFD_Mem, "0:100:110:59:112:100:373:0:0")
                Button2.Enabled = False : Button6.Enabled = False : Button5.Enabled = False : Button3.Text = "P&rint"
                Button1.Text = "Ca&ncel" : CheckBox1.Enabled = False
            Else
                MsgBox("There's nothing to update to Passbook.", MsgBoxStyle.Information, "Passbook Update")
            End If
        Else
            GroupBox2.Visible = True
            GroupBox1.Enabled = False
            TextBox3.Text = lastLine
            TextBox3.Focus()
        End If


    End Sub

    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        If e.KeyValue = e.KeyCode.Enter Then
            rsFD_Mem.MoveFirst()
            Do Until rsFD_Mem.EOF
                'lcn.Execute("UPDATE FD SET LPOSTED=" & lastLine & "WHERE REF='" & rsFD_Mem.Fields("REF").Value)
                MsgBox("UPDATE FD SET LPOSTED=" & lastLine & "WHERE REF='" & rsFD_Mem.Fields("REFERENCE").Value)
                If lastLine > 23 Then lastLine = 3 Else lastLine += 1
                rsFD_Mem.MoveNext()
            Loop
            Button4.Enabled = True : Button2.Enabled = True : Button1.Text = "&Close" : CheckBox1.Enabled = True
            Button6.Enabled = True : Button5.Enabled = True : Button3.Text = "Passbook &Update"
            rsFD_Mem.Requery()
            rsFD_Mem.Filter = adFilterNone
            rsFD_Mem.Filter = "DATE =" & rsCTL.Fields("SYSDATE").Value
            FillLV(ListView1, Label5, rsFD_Mem, "0:100:110:67:112:100:365:0:0")
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            TextBox3.Text = ""
        ElseIf e.KeyValue = e.KeyCode.Escape Then
            GroupBox2.Visible = False
            GroupBox1.Enabled = True
            TextBox3.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "&Close" Then
            rsMEMBERS_L.Close()
            ClsForm(Me, rsFD_Mem)
        Else
            Button4.Enabled = True : Button2.Enabled = True : Button1.Text = "&Close" : CheckBox1.Enabled = True
            Button6.Enabled = True : Button5.Enabled = True : Button3.Text = "Passbook &Update"
        End If
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
