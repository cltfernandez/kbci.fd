Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.OleDb

Module frmFDS_Mod1
    Public BALANCE As Integer
    Public SW As Boolean = False
    Public frmFDS_Main As frmFDS_Main
    Public cn As New ADODB.Connection
    Public lcn As New ADODB.Connection
    Public rsCTL As New ADODB.Recordset
    Public rsTRANCODE As New ADODB.Recordset
    Public rsMEMBERS As New ADODB.Recordset
    Public rsMEMBERS_L As New ADODB.Recordset
    Public rsFD_Mem As New ADODB.Recordset
    Public rsFD_Mem_L As New ADODB.Recordset
    Public rsMEM_SRC As New ADODB.Recordset
    Public Const adFilterNone = ADODB.FilterGroupEnum.adFilterNone
    Public Const CLUSER As String = "DEBUG"

    Sub Main()
        frmFDS_Main = New frmFDS_Main

        frmFDS_Main.ShowDialog()



    End Sub
    Public Sub FillListViewWithAddRange(ByRef LV As ListView, ByRef LBL As Label, ByRef RSET As ADODB.Recordset, ByVal wSET As String)
        Dim sLvw As New ListViewItem
        Dim STRDate As String
        Dim colCTR, wds, wdsCTR As Integer
        Dim wdSET(50) As String
        Dim StartTime As DateTime
        Dim Elapsed As Double


        If RSET.RecordCount > 0 Then
            StartTime = System.DateTime.Now
            RSET.MoveFirst()
            LBL.Visible = True : Application.DoEvents()
            wdsCTR = 0
            LV.Items.Clear() : LV.Columns.Clear()
            For wds = 0 To Len(wSET)
                If Mid(wSET, wds + 1, 1) = ":" Then
                    wdsCTR += 1
                Else
                    wdSET(wdsCTR) = wdSET(wdsCTR) & Mid(wSET, wds + 1, 1)
                End If
            Next
            For colCTR = 0 To RSET.Fields.Count - 1
                LV.Columns.Add(RSET.Fields(colCTR).Name, wdSET(colCTR), HorizontalAlignment.Left)
            Next

            Do Until RSET.EOF
                sLvw = LV.Items.Add(RSET.Fields(RSET.Fields(0).Name).Value)
                For colCTR = 1 To RSET.Fields.Count - 1
                    If Not IsDBNull(RSET.Fields(RSET.Fields(colCTR).Name).Value) Then
                        sLvw.SubItems.Add(CStr(RSET.Fields(RSET.Fields(colCTR).Name).Value))
                    Else
                        sLvw.SubItems.Add("NULL")
                    End If
                Next
                RSET.MoveNext()

            Loop
            LBL.Visible = False
            Elapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds
            MessageBox.Show("Elapsed time " & Elapsed.ToString & " ms with ListView.Add", _
              "Elapsed Time", _
              MessageBoxButtons.OK, _
              MessageBoxIcon.Information)

        End If
    End Sub
    Public Sub FillLV(ByRef LV As ListView, ByRef LBL As Label, ByRef RSET As ADODB.Recordset, ByVal wSET As String)
        Dim sLvw As New ListViewItem
        Dim STRDate As String
        Dim colCTR, wds, wdsCTR As Integer
        Dim wdSET(50) As String
        Dim TempStr() As String
        Dim TempNode As ListViewItem
        Dim TempArr() As ListViewItem
        Dim i As Integer
        'Dim StartTime As DateTime
        'Dim Elapsed As Double
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
                LV.Columns.Add(RSET.Fields(colCTR).Name, wdSET(colCTR), HorizontalAlignment.Left)
            Next
            ReDim TempStr(0)
            ReDim TempArr(RSET.RecordCount - 1)
            RSET.MoveFirst()
            For i = 0 To RSET.RecordCount - 1
                TempStr(0) = CStr(RSET.Fields(RSET.Fields(1).Name).Value)
                TempNode = New ListViewItem(TempStr)
                For colCTR = 1 To RSET.Fields.Count - 1
                    If Not IsDBNull(RSET.Fields(RSET.Fields(colCTR).Name).Value) Then
                        TempNode.SubItems.Add(CStr(RSET.Fields(RSET.Fields(colCTR).Name).Value))
                    Else
                        TempNode.SubItems.Add("NULL")
                    End If
                Next
                TempNode.Tag = i.ToString
                TempArr(i) = TempNode
                RSET.MoveNext()

            Next i
            LV.Items.AddRange(TempArr)
            'Elapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds
            'MessageBox.Show("Elapsed time " & Elapsed.ToString & " ms with ListView.Add", _
            '  "Elapsed Time", _
            '  MessageBoxButtons.OK, _
            '  MessageBoxIcon.Information)
            LBL.Visible = False
        End If
        '
    End Sub
    Public Sub getWID(ByRef LVW As ListView, ByRef TXT As TextBox)
        Dim x As Integer
        Dim s As String
        s = ""
        For x = 0 To LVW.Columns.Count - 1
            s = s & LVW.Columns(x).Width & ":"
        Next
        TXT.Text = s
    End Sub
    Public Sub ClsForm(ByRef FRM As Form, ByRef RCSet As ADODB.Recordset)
        FRM.Dispose()
        If RCSet.State = 1 Then RCSet.Close()
    End Sub

    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
    Public Function WLOG(ByVal LogMsg As String, ByVal LogPTH As String)
        On Error GoTo err1
        Dim logWrite As StreamWriter = File.AppendText(LogPTH)
        logWrite.WriteLine(LogMsg) : logWrite.Flush() : logWrite.Close()
err1:
        If Err.Number <> 0 Then
            WLOG("**RUNTIME ERROR** " & Err.Description & "  Module: 'WLOG'" & Now, LogPTH) : Resume err1
        End If
    End Function
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

    'INSERT * TO MEMBERS
    'WLOG("INSERT INTO MEMBERS([KBCI_NO],[LNAME],[FNAME],[MI],[MEM_CODE],[MEM_STAT],[MEM_DATE],[BY_WHOM],[CB_EMPNO],[CB_HIRE],[DEPT],[REGION],[OFF_TEL],[DORI],[REA_DORI],[SEX],[B_DATE],[CIV_STAT],[MEM_ADDR],[RES_TEL],[POSITION],[SAL_BAS],[SAL_ALL],[OTH_INC],[FEBTC_SA],[FEBTC_CA],[FD_CERTNO],[FD_DATE],[AP_AMOUNT],[AR_AMOUNT],[FD_AMOUNT],[SD_AMOUNT],[TD_AMOUNT],[OTH_AMOUNT],[YTD_DIVAMT],[YTD_LRI],[REM_PROP],[REM_VALUE],[NO_DEPEND],[SP_NAME],[SP_EMPLOY],[SP_OFFTEL],[SP_CBEMPNO],[SP_KBCINO],[SP_SALARY],[APRUN_AMT],[ARRUN_AMT],[RUN_AMT],[ADD_DATE],[CHG_DATE],[USER],[REC_STAT],[FD_CNTR]) " & _
    '"VALUES    ('" & .Fields("KBCI_NO").Value & "','" & .Fields("LNAME").Value & "','" & .Fields("FNAME").Value & "','" & .Fields("MI").Value & "','" & .Fields("MEM_CODE").Value & "','" & .Fields("MEM_STAT").Value & "','" & .Fields("MEM_DATE").Value & "','" & .Fields("BY_WHOM").Value & "','" & .Fields("CB_EMPNO").Value & "','" & .Fields("CB_HIRE").Value & "','" & .Fields("DEPT").Value & "','" & .Fields("REGION").Value & "','" & .Fields("OFF_TEL").Value & "'," & .Fields("DORI").Value & ",'" & .Fields("REA_DORI").Value & "','" & .Fields("SEX").Value & "','" & .Fields("B_DATE").Value & _
    '         "','" & .Fields("CIV_STAT").Value & "','" & .Fields("MEM_ADDR").Value & "','" & .Fields("RES_TEL").Value & "','" & .Fields("POSITION").Value & "'," & .Fields("SAL_BAS").Value & "," & .Fields("SAL_ALL").Value & "," & .Fields("OTH_INC").Value & ",'" & .Fields("FEBTC_SA").Value & "','" & .Fields("FEBTC_CA").Value & "','" & .Fields("FD_CERTNO").Value & "','" & .Fields("FD_DATE").Value & "'," & .Fields("AP_AMOUNT").Value & "," & .Fields("AR_AMOUNT").Value & "," & .Fields("FD_AMOUNT").Value & "," & .Fields("SD_AMOUNT").Value & "," & .Fields("TD_AMOUNT").Value & "," & .Fields("OTH_AMOUNT").Value & _
    '           "," & .Fields("YTD_DIVAMT").Value & "," & .Fields("YTD_LRI").Value & ",'" & .Fields("REM_PROP").Value & "'," & .Fields("REM_VALUE").Value & "," & .Fields("NO_DEPEND").Value & ",'" & .Fields("SP_NAME").Value & "','" & .Fields("SP_EMPLOY").Value & "','" & .Fields("SP_OFFTEL").Value & "','" & .Fields("SP_CBEMPNO").Value & "','" & .Fields("SP_KBCINO").Value & "'," & .Fields("SP_SALARY").Value & "," & .Fields("APRUN_AMT").Value & "," & .Fields("ARRUN_AMT").Value & "," & .Fields("RUN_AMT").Value & ",'" & .Fields("ADD_DATE").Value & "','" & .Fields("CHG_DATE").Value & "','" & .Fields("USER").Value & "'," & .Fields("REC_STAT").Value & "," & .Fields("FD_CNTR").Value & ")", App_Path() & "INSERT.log")

End Module
