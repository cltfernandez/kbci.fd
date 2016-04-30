Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.OleDb
Imports FD.Common
Imports System.Collections.Generic
Imports FD.DataAccessObject
Imports FD.ViewModels
Imports System.Reflection

Module CommonUtilities
    Public BALANCE As Integer
    Public SW As Boolean = False
    Public frmFDS_Main As frmFixedDepositMain
    Public cn As New ADODB.Connection
    Public rsCTL As New Ctrl
    Public rsTRANCODE As New List(Of Trancode)
    Public rsMEMBERS As New List(Of Members)
    Public MembersGridList As New List(Of MembersBOVM)
    Public rsNMEMBERS As New ADODB.Recordset
    Public SelectedMemberData As New Members    
    Public rsFD_Mem As New ADODB.Recordset
    Public rsFD_MemX As New ADODB.Recordset
    Public rsFD_Mem_L As New ADODB.Recordset
    Public rsMEM_SRC As New ADODB.Recordset
    Public rsPRINT As New ADODB.Recordset
    Public rsCASHDIV As New ADODB.Recordset
    Public rsDIV As New Divrefph
    Public rsDIVPATMain As New ADODB.Recordset
    Public rsPASSBOOK As New ADODB.Recordset
    Public Const adFilterNone As ADODB.FilterGroupEnum = ADODB.FilterGroupEnum.adFilterNone
    Public DEFPRINTER As String
    Public SEL_KBCI_NO, SEL_FNAME, SELFIELD, SELREGION, SEL_FEBTC As String
    Public sDate, FRDATE, TODATE As String
    Public SYSDATE, SELYR, SELQTR, rCN As String
    Public SUMMRY As Boolean

    Public ViewOption As ViewOptions
    Public OPTIO As Integer
    Public bOWCheck() As Boolean
    Public _GlobalCurrentUser As UserViewModel
    Public Forms As System.Windows.Forms.FormCollection = Application.OpenForms
    
    
    Public Function IsFormLoaded(ByVal FormName As String) As Boolean
        Dim i As Integer, fnamelc As String

        fnamelc = LCase$(FormName)
        IsFormLoaded = False

        For i = 0 To Forms.Count - 1
            If LCase$(Forms(i).Name) = fnamelc Then
                IsFormLoaded = True
                Exit Function
            End If

        Next

    End Function


    Public Sub getWID(ByRef LVW As ListView, ByRef TXT As TextBox)
        Dim x As Integer
        Dim s As String
        s = ""
        For x = 0 To LVW.Columns.Count - 1
            s = s & LVW.Columns(x).Width & ":"
        Next
        TXT.Text = s
    End Sub
    Public Sub ClsForm(ByRef FRM As Form, Optional ByRef RCSet As ADODB.Recordset = Nothing)
        FRM.Dispose()

        If RCSet Is Nothing Then Exit Sub
        If RCSet.State = 1 Then RCSet.Close()
    End Sub

    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
    Public Sub WLOG(ByVal LogMsg As String, ByVal LogPTH As String)
        On Error GoTo err1
        Dim logWrite As StreamWriter = File.AppendText(LogPTH)
        logWrite.WriteLine(LogMsg) : logWrite.Flush() : logWrite.Close()
err1:
        If Err.Number <> 0 Then
            WLOG("**RUNTIME ERROR** " & Err.Description & "  Module: 'WLOG'" & Now, LogPTH) : Resume err1
        End If
    End Sub
    Public Sub clrTXT(ByRef Mee As Form)
        Dim Control As Control
        Dim gControl As Control

        For Each Control In Mee.Controls
            If TypeOf Control Is GroupBox Then
                For Each gControl In Control.Controls
                    If TypeOf gControl Is TextBox Then
                        Dim txt As TextBox = gControl
                        txt.Text = ""
                    End If
                Next
                If TypeOf Control Is TextBox Then
                    Dim txt As TextBox = Control
                    txt.Text = ""
                End If
            End If
        Next Control
    End Sub
    Public Sub GenRPT(ByRef rptRS As ADODB.Recordset, ByRef rptDT As DataTable, ByRef RepViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal CrysRep As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal TBL As Integer, ByVal FString As String)
        Dim colCTR, wds, wdsctr As Integer
        Dim rptDS As New DataSet
        Dim wdSET(50) As String


        For wds = 0 To Len(FString)
            If Mid(FString, wds + 1, 1) = ":" Then
                wdsctr += 1
            Else
                wdSET(wdsctr) = wdSET(wdsctr) & Mid(FString, wds + 1, 1)
            End If
        Next

        For colCTR = 0 To rptRS.Fields.Count - 1
            Select Case wdSET(colCTR)
                Case 2 'decimal
                    rptDT.Columns.Add(rptRS.Fields(colCTR).Name, Type.GetType("System.Decimal"))
                Case Else
                    rptDT.Columns.Add(rptRS.Fields(colCTR).Name, Type.GetType("System.String"))
            End Select
        Next
        rptRS.MoveFirst()
        Do Until rptRS.EOF
            Dim dtr As DataRow = rptDT.NewRow
            For colCTR = 0 To rptRS.Fields.Count - 1
                Select Case wdSET(colCTR)
                    Case 1 'date
                        If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = DateValue(rptRS.Fields(rptRS.Fields(colCTR).Name).Value).ToString("MM/dd/yyy")
                    Case 2 'decimal
                        If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then
                            If rptRS.Fields(colCTR).Name = "DEBIT" Then
                                If rptRS.Fields("DRCR").Value = "DR" Then
                                    If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = rptRS.Fields(rptRS.Fields(colCTR).Name).Value
                                End If
                            ElseIf rptRS.Fields(colCTR).Name = "CREDIT" Then
                                If rptRS.Fields("DRCR").Value = "CR" Then
                                    If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = rptRS.Fields(rptRS.Fields(colCTR).Name).Value
                                End If
                            Else
                                If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = rptRS.Fields(rptRS.Fields(colCTR).Name).Value
                            End If
                        End If
                    Case 4 'boolean
                        If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = Mid(rptRS.Fields(rptRS.Fields(colCTR).Name).Value, 1, 1)
                    Case 5 'kbci format
                        If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = Mid(rptRS.Fields(rptRS.Fields(colCTR).Name).Value, 1, 2) & _
                         "-" & Mid(rptRS.Fields(rptRS.Fields(colCTR).Name).Value, 3, 4) & "-" & Mid(rptRS.Fields(rptRS.Fields(colCTR).Name).Value, 7, 1)
                    Case Else
                        If Not IsDBNull(rptRS.Fields(rptRS.Fields(colCTR).Name).Value) Then dtr.Item(rptRS.Fields(colCTR).Name) = rptRS.Fields(rptRS.Fields(colCTR).Name).Value
                End Select
            Next
            rptDT.Rows.Add(dtr)
            rptRS.MoveNext()
        Loop
        rptRS.Close()
        rptDS.Tables.Add(rptDT)
        CrysRep.SetDataSource(rptDS.Tables(TBL))
        RepViewer.ReportSource = CrysRep
    End Sub
    Public Function CleanSTR(ByVal SQLStr As String) As String
        Dim x As Integer
        Dim rStr As String = ""
        For x = 1 To Len(SQLStr)
            If Mid(SQLStr, x, 1) = "'" Then
                If Mid(SQLStr, x - 1, 1) <> "," And Mid(SQLStr, x + 1, 1) <> "," And Mid(SQLStr, x + 1, 1) <> ")" And Mid(SQLStr, x - 1, 1) <> "(" And Mid(SQLStr, x - 1, 1) <> "=" And Mid(SQLStr, x + 1, 1) <> "" Then
                    rStr = rStr & "'"
                End If
            End If
            rStr = rStr & Mid(SQLStr, x, 1)
        Next
        Return rStr
    End Function
    Public Sub SQLConn(ByVal QRYStr As String, ByRef DS As DataSet, ByVal DT As DataTable)
        Dim cnn As New SqlConnection("Provider=SQLOLEDB.1;Password=password123;Persist Security Info=True;User ID=sa;Initial Catalog=kbci;Data Source=BLITZ\SQLEXPRESS,1433")
        Dim sqlCMD As New SqlCommand(QRYStr, cnn)
        Dim shitadapter As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        shitadapter.Fill(DS)
        cnn.Close()
        DT = DS.Tables(0)
        MsgBox(DT.Columns.Count)

    End Sub
    Public Function IsDBExist(ByVal CnStr As String, ByVal TBL As String) As Boolean
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection
        Dim SchemaTable As DataTable

        AccessConnection.ConnectionString = CnStr
        AccessConnection.Open()
        SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, TBL})

        If SchemaTable.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
        AccessConnection.Close()
    End Function

    Public Function LogError(ByVal lngErrNumber As Long, ByVal strErrDescription As String, ByVal strCallingProc As String, ByVal currUser As String, Optional ByVal bShowUser As Boolean = True) As Boolean
        On Error GoTo ErrorHandler

        Dim strMsg As String
        Dim strUser As String
        Dim strSQL As String
        ' Case on type of error generated by Access
        Select Case lngErrNumber
            Case 2501
                ' Do nothing - error code corresponds to cancellation
            Case 3314, 2101, 2115
                ' Can't save records - logger will not function
                If bShowUser Then
                    ' Display dialog if user specified non-silent logging
                    strMsg = "Record cannot be saved at this time." & vbCrLf & _
                        "Complete the entry, or press <Esc> to undo."
                    MsgBox(strMsg, vbExclamation, strCallingProc)
                End If
            Case Else
                If bShowUser Then
                    ' Display dialog if user specified non-silent logging
                    strMsg = "Error " & lngErrNumber & ": " & strErrDescription
                    MsgBox(strMsg, vbExclamation, strCallingProc)
                End If

                LogError = True
        End Select

ExitHandler:
        Exit Function
ErrorHandler:
        ' Display dialog for error in error logger
        strMsg = "An unexpected situation arose in your program." & vbCrLf & _
            "Please write down the following details:" & vbCrLf & vbCrLf & _
            "Calling Proc: " & strCallingProc & vbCrLf & _
            "Error Number " & lngErrNumber & vbCrLf & strErrDescription & vbCrLf & vbCrLf & _
            "Unable to record because Error " & Err.Number & vbCrLf & Err.Description
        MsgBox(strMsg, vbCritical, "LogError()")
        Resume ExitHandler

    End Function
    Public Sub FillLV(ByRef LV As ListView, ByRef LBL As Label, ByRef RSET As ADODB.Recordset, ByVal wSET As String)
        Dim sLvw As New ListViewItem
        Dim colCTR, wds, wdsCTR As Integer
        Dim wdSET(50) As String
        Dim TempStr() As String
        Dim TempNode As ListViewItem
        Dim TempArr() As ListViewItem
        Dim i As Integer
        Dim myCheckFont As New System.Drawing.Font("Wingdings", 12, FontStyle.Regular)
        Dim myRegFont As New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold)

        LV.Items.Clear()

        If RSET.RecordCount > 0 Then
            'StartTime = System.DateTime.Now
            RSET.MoveFirst()
            LBL.Visible = True ': Application.DoEvents()
            wdsCTR = 0
            LV.Columns.Clear()
            For wds = 0 To Len(wSET)
                If Mid(wSET, wds + 1, 1) = ":" Then
                    wdsCTR += 1
                Else
                    wdSET(wdsCTR) = wdSET(wdsCTR) & Mid(wSET, wds + 1, 1)
                End If
            Next
            For colCTR = 0 To RSET.Fields.Count - 1
                LV.Columns.Add(RSET.Fields(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Left)
            Next
            ReDim TempStr(0)
            ReDim TempArr(RSET.RecordCount - 1)
            RSET.MoveFirst()
            For i = 0 To RSET.RecordCount - 1
                TempStr(0) = CStr(RSET.Fields(RSET.Fields(0).Name).Value)
                TempNode = New ListViewItem(TempStr)
                For colCTR = 1 To RSET.Fields.Count - 1
                    If Not IsDBNull(RSET.Fields(RSET.Fields(colCTR).Name).Value) Then
                        If RSET.Fields(colCTR).Name = "PRINTED" Then
                            Dim checked = CBool(RSET.Fields(RSET.Fields(colCTR).Name).Value)
                            Dim checkStatus
                            With TempNode
                                If checked Then checkStatus = CheckboxEnum.Checked Else checkStatus = CheckboxEnum.Unchecked
                                .UseItemStyleForSubItems = False
                                .SubItems.Add(Chr(checkStatus))
                                .SubItems.Item(colCTR).ForeColor = Color.Black
                                .SubItems.Item(colCTR).Font = myCheckFont
                            End With
                            ReDim bOWCheck(i)
                        Else
                            TempNode.SubItems.Add(CStr(RSET.Fields(RSET.Fields(colCTR).Name).Value))
                            TempNode.Font = myRegFont
                        End If
                    Else
                        TempNode.SubItems.Add("NULL")
                        TempNode.Font = myRegFont
                    End If
                Next
                TempNode.Tag = i.ToString
                TempArr(i) = TempNode
                RSET.MoveNext()

            Next i
            LV.Items.AddRange(TempArr)

            LBL.Visible = False
        End If
        'odb.Fill(ds, RSET, "Table")
        'dt = ds.Tables(0)
    End Sub
    Public Sub FillLV2(ByRef LV As ListView, ByRef DT As DataGridView, ByVal wSET As String, ByVal fSET As String)
        Dim sLvw As New ListViewItem
        Dim colCTR, wds, wdsCTR As Integer
        Dim wdSET(50) As String
        Dim frSet(50) As String
        Dim TempStr() As String
        Dim TempNode As ListViewItem
        Dim TempArr() As ListViewItem
        Dim i As Integer
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        'Dim dt As DataTable = New DataTable
        Dim ds As New DataSet
        'Dim StartTime As DateTime
        'Dim Elapsed As Double

        LV.Items.Clear()
        If DT.Rows.Count > 0 Then
            'StartTime = System.DateTime.Now           
            wdsCTR = 0
            LV.Columns.Clear()
            For wds = 0 To Len(wSET)
                If Mid(wSET, wds + 1, 1) = ":" Then
                    wdsCTR += 1
                Else
                    wdSET(wdsCTR) = wdSET(wdsCTR) & Mid(wSET, wds + 1, 1)
                End If
            Next
            wdsCTR = 0
            For wds = 0 To Len(fSET)
                If Mid(fSET, wds + 1, 1) = ":" Then
                    wdsCTR += 1
                Else
                    frSet(wdsCTR) = frSet(wdsCTR) & Mid(fSET, wds + 1, 1)
                End If
            Next
            For colCTR = 0 To DT.Columns.Count - 1
                Select Case frSet(colCTR)
                    Case 1
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Left)
                    Case 2
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Center)
                    Case 3
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Right)
                End Select

            Next
            ReDim TempStr(0)
            ReDim TempArr(DT.Rows.Count - 1)
            For i = 0 To DT.Rows.Count - 1
                TempStr(0) = CStr(DT.Rows(i).Cells(DT.Columns(0).Name).Value)
                TempNode = New ListViewItem(TempStr)
                For colCTR = 1 To DT.Columns.Count - 1
                    If Not IsDBNull(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value) Then
                        If CInt(frSet(colCTR)) = 3 Then
                            TempNode.SubItems.Add(FormatNumber(CStr(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value), 2))
                        Else
                            Dim itemValue As String = CStr(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value)
                            If itemValue.StartsWith("12:00:00 AM") Then
                                itemValue = "--"
                            End If
                            TempNode.SubItems.Add(itemValue)
                        End If

                    Else
                        TempNode.SubItems.Add("NULL")
                    End If
                Next
                TempNode.Tag = i.ToString
                TempArr(i) = TempNode
            Next i
            LV.Items.AddRange(TempArr)
            'Elapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds
            'MessageBox.Show("Elapsed time " & Elapsed.ToString & " ms with ListView.Add", _
            '  "Elapsed Time", _
            '  MessageBoxButtons.OK, _
            '  MessageBoxIcon.Information)
        End If
        'odb.Fill(ds, recSET, "Table")
        'dt = ds.Tables(0)  
    End Sub
    Public Function GetData(ByVal QRYStr As String, ByVal FLTR As String, ByRef DG As DataGridView) As DataGridView
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(QRYStr, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        Dim DV As New DataView(DT)
        DV.RowFilter = FLTR
        DG.DataSource = DV
        Return DG
    End Function
    Public Function GetGridViewDataFromObject(Of T)(ByVal items As List(Of T), ByRef DG As DataGridView) As DataGridView
        DG.DataSource = items
        Return DG
    End Function
    Public Function WhichCell(ByVal lvw As ListView, ByVal X As Integer, ByVal Y As Integer) As MyCell

        Dim colstart As Integer = 0
        Dim colend As Integer = 0
        Dim xCol As Integer

        For xCol = 0 To (lvw.Columns.Count - 1)
            colend = colend + lvw.Columns(xCol).Width
            If colstart <= X And X <= colend Then
                WhichCell.Col = xCol + 1
                Exit For
            End If
            colstart = colstart + lvw.Columns(xCol).Width
        Next

        WhichCell.Row = lvw.FocusedItem.Index
        Return WhichCell

    End Function

    Public Function ToDataTable(Of T)(ByVal items As List(Of T)) As DataTable
        Dim dataTable As New DataTable(GetType(T).Name)

        'Get all the properties
        Dim Props As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
        For Each prop As PropertyInfo In Props
            'Setting column names as Property names
            dataTable.Columns.Add(prop.Name)
        Next
        For Each item As T In items
            Dim values = New Object(Props.Length - 1) {}
            For i As Integer = 0 To Props.Length - 1
                'inserting property values to datatable rows
                values(i) = Props(i).GetValue(item, Nothing)
            Next
            dataTable.Rows.Add(values)
        Next
        'put a breakpoint here and check datatable
        Return dataTable
    End Function
    Public Sub PopulateMembersList()
        Using rsMEMBERSDao As New MembersDAO
            rsMEMBERS = rsMEMBERSDao.GetAll("LNAME")
            MembersGridList = rsMEMBERS.Select(Function(x) New MembersBOVM() With {.KBCI_ID = x.KBCI_ID, _
                                                                          .KBCI_NO = x.KBCI_NO, _
                                                                          .LNAME = x.LNAME, _
                                                                          .FNAME = x.FNAME, _
                                                                          .MI = x.MI, _
                                                                          .MEM_STAT = x.MEM_STAT, _
                                                                          .DATE = x.MEM_DATE, _
                                                                          .FD_AMOUNT = x.FD_AMOUNT}).ToList
        End Using
    End Sub

    Public Function FormatKBCINo(ByVal rawKBCINo As String) As String
        Return String.Format("{0}-{1}-{2}", Mid(rawKBCINo, 1, 2), Mid(rawKBCINo, 3, 4), Mid(rawKBCINo, 7, 1))
    End Function
End Module
