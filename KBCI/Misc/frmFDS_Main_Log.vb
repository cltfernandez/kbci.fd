Public Class frmFDS_Main_Log
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmFDS_Main_Log
        '
        Me.ClientSize = New System.Drawing.Size(648, 327)
        Me.Name = "frmFDS_Main_Log"
        Me.Text = "frmFDS_Main_Log"

    End Sub

#End Region

    Private Sub frmFDS_Main_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(cn.State)
        Do Until cn.State = ConnectionState.Open
            MsgBox(cn.State)
        Loop
        Me.Close()
    End Sub
End Class
