
Public Class ColumnWidthDefinition
    Public Const MembersGridList As String = "0:100:222:241:38:136:100:0"
    Public Const MembersSearchList As String = "0:100:222:241:38:0"
    Public Const TransactionList As String = "0:0:125:125:110:100:100:210:0:0:60"

End Class

Public Class ColumnAlignmentDefinition
    Public Const MemberGridList As String = "1:2:1:1:1:1:1:1"
    Public Const MembersSearchList As String = "1:1:1:1:1:1"
    Public Const TransactionList As String = "1:1:2:2:1:3:3:1:1:1:2"
End Class
Public Class TransactionType
    Public Const Debit As String = "DR"
    Public Const Credit As String = "CR"
    Public Const Adjustment As String = " "
End Class

Public Enum CustomDataType
    [Date] = 1
    [Decimal] = 2
End Enum
Public Enum CheckboxEnum
    [Checked] = 254
    [Unchecked] = 168
End Enum

Public Enum ValidationResult
    Failed = 1
    Passed = 2
    UserIsLoggedIn = 3
End Enum

Public Enum DividendProcessingValidationResult
    Invalid = 0
    Valid = 1
    NotFound = 2
End Enum

Public Enum DivRefSettingsValidationResult
    Valid = 0
    Invalid = 1
    NotFound = 2
End Enum

Public Enum FixedDepositTransactionValidationResult
    Valid = 0
    MissingRemarks = 1
    MissingBankCode = 2
    MissingCheckNumber = 3
    MissingTransactionCode = 4
    InvalidAmount = 5
    InsufficientFunds = 6
    ArithmeticOverflow = 7
End Enum

Public Enum ViewOptions
    Current = 0
    History = 1
End Enum

Public Structure MyCell
    Dim Row As Integer
    Dim Col As Integer
End Structure


Public Enum TransactionCode
    CashDeposit = 1
    CloseAccount = 2
    CheckDeposit = 3
    Adjustment = 4
    Reversal = 5
End Enum

Public Enum PrintlineNumber
    Initial = 0
End Enum


Public Enum DivRefToolbarButtons
    Add = 0
    Edit = 1
    Delete = 2
    Search = 4
    [Exit] = 6
End Enum

Public Enum RecordUpdateResult
    AddSuccessful = 0
    UpdateSuccessful = 1
    Unsuccessful = 2
    RecordExists = 3
End Enum

Public Enum DatePickerType
    DateRange = 0
    SingleDate = 1
End Enum

Public Structure DivrefPostingParameters
    Public PostingYear As Integer
    Public PostingQuarter As Integer

    Public FixedDepositCutOffDate As Date
    Public DividendPercentage As Decimal

    Public PatronageRefundProcessingDate As Date
    Public PatronageRefundPercentage As Decimal
    Public PatronageRefundInterestStartDate As Date
    Public PatronageRefundInterestEndDate As Date

    Public CurrentUsername As String
    Public SystemDate As Date
End Structure

Public Class MemberStatusEnum
    Public Const Active As String = "A"
    Public Const Resigned As String = "R"
    Public Const Staff As String = "S"
End Class

Public Structure DivrefSaveParameters
    Public KbciNo As String
    Public Year As Integer
    Public Quarter As Integer
End Structure

Public Class InterestPostinSqlStringEnum
    Public Const MembersPostingCommand As String = "INSERT INTO {0}([ACCTNO],[APLINT],[EDLINT],[EMLINT],[RGLINT],[RSLINT],[SPLINT],[LHLINT],[STLINT],[CMLINT],[MPLINT],[FALINT]) " & _
                                                    "SELECT LN.KBCI_NO," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='APL' THEN LT.AMOUNT ELSE 0 END) APLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='EDL' THEN LT.AMOUNT ELSE 0 END) EDLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='EML' THEN LT.AMOUNT ELSE 0 END) EMLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='RGL' THEN LT.AMOUNT ELSE 0 END) RGLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='RSL' THEN LT.AMOUNT ELSE 0 END) RSLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='SPL' THEN LT.AMOUNT ELSE 0 END) SPLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='LHL' THEN LT.AMOUNT ELSE 0 END) LHLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='STL' THEN LT.AMOUNT ELSE 0 END) STLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='CML' THEN LT.AMOUNT ELSE 0 END) CMLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='MPL' THEN LT.AMOUNT ELSE 0 END) MPLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='FAL' THEN LT.AMOUNT ELSE 0 END) FALINT " & _
                                                    "FROM (SELECT DISTINCT LG.PN_NO, SUM(ISNULL(LG.CR,0.00)) - SUM(ISNULL(LG.DR,0.00)) AMOUNT  FROM  LEDGER LG WHERE ACCT_CODE='INT' " & _
                                                    "AND (ACCT_TYPE='PAY' OR ACCT_TYPE='ADJ' OR ACCT_TYPE='TER' OR ACCT_TYPE='INT') AND  DATE BETWEEN @PatronageRefundInterestStartDate AND @PatronageRefundInterestEndDate " & _
                                                    "GROUP BY LG.PN_NO) LT RIGHT OUTER JOIN LOANS LN ON LT.PN_NO=LN.PN_NO LEFT JOIN MEMBERS MM ON MM.KBCI_NO=LN.KBCI_NO WHERE MM.MEM_STAT=@MemberStatus {1} GROUP BY LN.KBCI_NO"

    Public Const StaffPostingCommand As String = "INSERT INTO {0}([ACCTNO],[APLINT],[EDLINT],[EMLINT],[RGLINT],[RSLINT],[SPLINT],[LHLINT],[STLINT],[PTLINT],[CMLINT],[MPLINT],[FALINT]) " & _
                                                    "SELECT LN.KBCI_NO," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='APL' THEN LT.AMOUNT ELSE 0 END) APLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='EDL' THEN LT.AMOUNT ELSE 0 END) EDLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='EML' THEN LT.AMOUNT ELSE 0 END) EMLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='RGL' THEN LT.AMOUNT ELSE 0 END) RGLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='RSL' THEN LT.AMOUNT ELSE 0 END) RSLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='SPL' THEN LT.AMOUNT ELSE 0 END) SPLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='LHL' THEN LT.AMOUNT ELSE 0 END) LHLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='STL' THEN LT.AMOUNT ELSE 0 END) STLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='PTL' THEN LT.AMOUNT ELSE 0 END) PTLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='CML' THEN LT.AMOUNT ELSE 0 END) CMLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='MPL' THEN LT.AMOUNT ELSE 0 END) MPLINT," & _
                                                    "SUM(CASE WHEN LN.LOAN_TYPE ='FAL' THEN LT.AMOUNT ELSE 0 END) FALINT " & _
                                                    "FROM (SELECT DISTINCT LG.PN_NO, SUM(ISNULL(LG.CR,0.00)) - SUM(ISNULL(LG.DR,0.00)) AMOUNT  FROM  LEDGER LG WHERE ACCT_CODE='INT' " & _
                                                    "AND (ACCT_TYPE='PAY' OR ACCT_TYPE='ADJ' OR ACCT_TYPE='TER' OR ACCT_TYPE='INT') AND  DATE BETWEEN @PatronageRefundInterestStartDate AND @PatronageRefundInterestEndDate " & _
                                                    "GROUP BY LG.PN_NO) LT RIGHT OUTER JOIN LOANS LN ON LT.PN_NO=LN.PN_NO LEFT JOIN MEMBERS MM ON MM.KBCI_NO=LN.KBCI_NO WHERE MM.MEM_STAT=@MemberStatus {1} GROUP BY LN.KBCI_NO"

    Public Const STLFilter As String = "AND (LN.LOAN_TYPE!='STL' AND LN.FREQ!='D')"
End Class

Public Class MembersPostingSqlStringEnum
    Public Const UpdateMembersYtdDividendCommand As String = "UPDATE MEMBERS SET MEMBERS.YTD_DIVAMT=PATREF.PR FROM  " & _
                                                            "(SELECT [ACCTNO], ([APLINT]+[EDLINT]+[EMLINT]+[RGLINT]+[RSLINT]+[SPLINT]+[LHLINT]+[STLINT]) PR FROM {0}) " & _
                                                            "PATREF WHERE MEMBERS.KBCI_NO=PATREF.ACCTNO"
    Public Const UpdateStaffYtdDividendCommand As String = "UPDATE MEMBERS SET MEMBERS.YTD_DIVAMT=PATREF.PR FROM  " & _
                                                            "(SELECT [ACCTNO], ([APLINT]+[EDLINT]+[EMLINT]+[RGLINT]+[RSLINT]+[SPLINT]+[LHLINT]+[STLINT]+[PTLINT]) PR FROM {0}) " & _
                                                            "PATREF WHERE MEMBERS.KBCI_NO=PATREF.ACCTNO"

End Class








