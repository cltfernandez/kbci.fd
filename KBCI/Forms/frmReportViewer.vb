Imports FD.BusinessLogic
Imports FD.Common.Utilities
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportViewer
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
    Friend WithEvents bgwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label5 As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents crvMainViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crvMainViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.bgwLoadData = New System.ComponentModel.BackgroundWorker
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'crvMainViewer
        '
        Me.crvMainViewer.ActiveViewIndex = -1
        Me.crvMainViewer.AutoScroll = True
        Me.crvMainViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.crvMainViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvMainViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvMainViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvMainViewer.Name = "crvMainViewer"
        Me.crvMainViewer.SelectionFormula = ""
        Me.crvMainViewer.ShowCloseButton = False
        Me.crvMainViewer.Size = New System.Drawing.Size(828, 561)
        Me.crvMainViewer.TabIndex = 0
        Me.crvMainViewer.ViewTimeSelectionFormula = ""
        Me.crvMainViewer.Visible = False
        '
        'bgwLoadData
        '
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Loading..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReportViewer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(828, 561)
        Me.Controls.Add(Me.crvMainViewer)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ReportService As IReportService
    Public ReportModel As ReportClass
    Public HeaderText As String

    Private data As DataTable

    Private Sub frmFD_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = HeaderText
        If Not ReportService Is Nothing Then bgwLoadData.RunWorkerAsync() Else crvMainViewer.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub bgwLoadData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadData.DoWork
        data = ReportService.GetData()
    End Sub

    Private Sub bgwLoadData_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadData.RunWorkerCompleted
        If data.Rows.Count > 0 Then
            ReportModel.SetDataSource(data)
            crvMainViewer.ReportSource = ReportModel
            crvMainViewer.Visible = True
        Else
            MsgBox(GetGlobalResourceString("NoTransactionFound"), MsgBoxStyle.Critical, GetGlobalResourceString("FixedDepositSystem"))
            Me.Dispose()
        End If
    End Sub

    Private Sub crvMainViewer_ReportRefresh(ByVal source As System.Object, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles crvMainViewer.ReportRefresh
        crvMainViewer.Visible = False
        bgwLoadData.RunWorkerAsync()
    End Sub
End Class
