﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.8009
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class GlobalResource
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("FD.Common.GlobalResource", GetType(GlobalResource).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Active Members.
        '''</summary>
        Friend Shared ReadOnly Property ActiveMembers() As String
            Get
                Return ResourceManager.GetString("ActiveMembers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Add New.
        '''</summary>
        Friend Shared ReadOnly Property AddButton() As String
            Get
                Return ResourceManager.GetString("AddButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to add this member to the master file?.
        '''</summary>
        Friend Shared ReadOnly Property AddMemberQuestion() As String
            Get
                Return ResourceManager.GetString("AddMemberQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Added New Record Successfully.
        '''</summary>
        Friend Shared ReadOnly Property AddSuccessful() As String
            Get
                Return ResourceManager.GetString("AddSuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All KBCI Members.
        '''</summary>
        Friend Shared ReadOnly Property AllMembers() As String
            Get
                Return ResourceManager.GetString("AllMembers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please input  amount less than 10,000,000.00.
        '''</summary>
        Friend Shared ReadOnly Property AmountExceeds1B() As String
            Get
                Return ResourceManager.GetString("AmountExceeds1B", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Cancel.
        '''</summary>
        Friend Shared ReadOnly Property CancelButton() As String
            Get
                Return ResourceManager.GetString("CancelButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cash Dividend Register.
        '''</summary>
        Friend Shared ReadOnly Property CashDividendRegister() As String
            Get
                Return ResourceManager.GetString("CashDividendRegister", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Confirmation Password does not match..
        '''</summary>
        Friend Shared ReadOnly Property ConfirmationPasswordNotMatch() As String
            Get
                Return ResourceManager.GetString("ConfirmationPasswordNotMatch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Current Members/Investors As of {0}.
        '''</summary>
        Friend Shared ReadOnly Property CurrentMembersHeader() As String
            Get
                Return ResourceManager.GetString("CurrentMembersHeader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Delete.
        '''</summary>
        Friend Shared ReadOnly Property DeleteButton() As String
            Get
                Return ResourceManager.GetString("DeleteButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cash Dividend / Patronage Refund Maintenance.
        '''</summary>
        Friend Shared ReadOnly Property DividendPatronageMaintenance() As String
            Get
                Return ResourceManager.GetString("DividendPatronageMaintenance", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cash Dividend / Patronage Refund.
        '''</summary>
        Friend Shared ReadOnly Property DividendPatronageRefund() As String
            Get
                Return ResourceManager.GetString("DividendPatronageRefund", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to process the CASH DIVIDEND/PAT. REFUND with the following settings?.
        '''</summary>
        Friend Shared ReadOnly Property DivPatProcessingQuestion() As String
            Get
                Return ResourceManager.GetString("DivPatProcessingQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to RECORD NOT FOUND FOR YEAR:[{0}] QUARTER:[{1}]..
        '''</summary>
        Friend Shared ReadOnly Property DivRefRecordNotFound() As String
            Get
                Return ResourceManager.GetString("DivRefRecordNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done!.
        '''</summary>
        Friend Shared ReadOnly Property Done() As String
            Get
                Return ResourceManager.GetString("Done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Edit.
        '''</summary>
        Friend Shared ReadOnly Property EditButton() As String
            Get
                Return ResourceManager.GetString("EditButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to exit the application?.
        '''</summary>
        Friend Shared ReadOnly Property ExitApplicationPrompt() As String
            Get
                Return ResourceManager.GetString("ExitApplicationPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Do you want to exit the application?.
        '''</summary>
        Friend Shared ReadOnly Property ExitApplicationQuestion() As String
            Get
                Return ResourceManager.GetString("ExitApplicationQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to E&amp;xit.
        '''</summary>
        Friend Shared ReadOnly Property ExitButton() As String
            Get
                Return ResourceManager.GetString("ExitButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fixed Deposit - Members Maintenance.
        '''</summary>
        Friend Shared ReadOnly Property FDMembersMaintenance() As String
            Get
                Return ResourceManager.GetString("FDMembersMaintenance", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please fill out all fields..
        '''</summary>
        Friend Shared ReadOnly Property FillOutAllFields() As String
            Get
                Return ResourceManager.GetString("FillOutAllFields", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fixed Deposit - Ledger.
        '''</summary>
        Friend Shared ReadOnly Property FixedDepositLedger() As String
            Get
                Return ResourceManager.GetString("FixedDepositLedger", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fixed Deposit - Members.
        '''</summary>
        Friend Shared ReadOnly Property FixedDepositMembers() As String
            Get
                Return ResourceManager.GetString("FixedDepositMembers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fixed Deposit System - Run-up.
        '''</summary>
        Friend Shared ReadOnly Property FixedDepositRunup() As String
            Get
                Return ResourceManager.GetString("FixedDepositRunup", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Last Run-up was [{0}]. Would you like to continue?.
        '''</summary>
        Friend Shared ReadOnly Property FixedDepositRunupPrompt() As String
            Get
                Return ResourceManager.GetString("FixedDepositRunupPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fixed Deposit - Transaction.
        '''</summary>
        Friend Shared ReadOnly Property FixedDepositTransaction() As String
            Get
                Return ResourceManager.GetString("FixedDepositTransaction", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log-In Failed. Incorrect Credentials.
        '''</summary>
        Friend Shared ReadOnly Property IncorrectCredentials() As String
            Get
                Return ResourceManager.GetString("IncorrectCredentials", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Incorrect settings. Please check the processing date, cutoff date, and percentage to apply. .
        '''</summary>
        Friend Shared ReadOnly Property IncorrectDividendSettings() As String
            Get
                Return ResourceManager.GetString("IncorrectDividendSettings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error on settings, please check the processing date, loans date range, and percentage to apply..
        '''</summary>
        Friend Shared ReadOnly Property IncorrectPatronageRefundSettings() As String
            Get
                Return ResourceManager.GetString("IncorrectPatronageRefundSettings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Transaction error. Insufficient Funds..
        '''</summary>
        Friend Shared ReadOnly Property InsufficientFunds() As String
            Get
                Return ResourceManager.GetString("InsufficientFunds", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please input correct amount..
        '''</summary>
        Friend Shared ReadOnly Property InvalidAmount() As String
            Get
                Return ResourceManager.GetString("InvalidAmount", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid date range please, select a valid date range..
        '''</summary>
        Friend Shared ReadOnly Property InvalidDateRange() As String
            Get
                Return ResourceManager.GetString("InvalidDateRange", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to KBCI Number.
        '''</summary>
        Friend Shared ReadOnly Property KBCINumber() As String
            Get
                Return ResourceManager.GetString("KBCINumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to KBCI No: [{0}] is not found on the database..
        '''</summary>
        Friend Shared ReadOnly Property KBCINumberNotFound() As String
            Get
                Return ResourceManager.GetString("KBCINumberNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to KBCI Staff Members.
        '''</summary>
        Friend Shared ReadOnly Property KbciStaff() As String
            Get
                Return ResourceManager.GetString("KbciStaff", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log-In.
        '''</summary>
        Friend Shared ReadOnly Property Login() As String
            Get
                Return ResourceManager.GetString("Login", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log-In Successful.
        '''</summary>
        Friend Shared ReadOnly Property LoginSuccessful() As String
            Get
                Return ResourceManager.GetString("LoginSuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Do you want to log-off?.
        '''</summary>
        Friend Shared ReadOnly Property LogOffQuestion() As String
            Get
                Return ResourceManager.GetString("LogOffQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please set the corresponding Bank Code for the check..
        '''</summary>
        Friend Shared ReadOnly Property MissingBankCode() As String
            Get
                Return ResourceManager.GetString("MissingBankCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please set the corresponding Check No. of the check..
        '''</summary>
        Friend Shared ReadOnly Property MissingCheckNumber() As String
            Get
                Return ResourceManager.GetString("MissingCheckNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remarks are required in this type of transaction..
        '''</summary>
        Friend Shared ReadOnly Property MissingRemarks() As String
            Get
                Return ResourceManager.GetString("MissingRemarks", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Name.
        '''</summary>
        Friend Shared ReadOnly Property Name() As String
            Get
                Return ResourceManager.GetString("Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No Records Found.
        '''</summary>
        Friend Shared ReadOnly Property NoRecordsFound() As String
            Get
                Return ResourceManager.GetString("NoRecordsFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No Transaction available for reversal..
        '''</summary>
        Friend Shared ReadOnly Property NoTransactionForReversal() As String
            Get
                Return ResourceManager.GetString("NoTransactionForReversal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No Transactions found..
        '''</summary>
        Friend Shared ReadOnly Property NoTransactionFound() As String
            Get
                Return ResourceManager.GetString("NoTransactionFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Passbook &amp;Update.
        '''</summary>
        Friend Shared ReadOnly Property PassbookUpdateButton() As String
            Get
                Return ResourceManager.GetString("PassbookUpdateButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There are [{0}] transaction/s, for printing.  Click OK to continue..
        '''</summary>
        Friend Shared ReadOnly Property PassbookUpdatePrompt() As String
            Get
                Return ResourceManager.GetString("PassbookUpdatePrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please input numeric characters.
        '''</summary>
        Friend Shared ReadOnly Property PleaseInputNumeric() As String
            Get
                Return ResourceManager.GetString("PleaseInputNumeric", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Posting....
        '''</summary>
        Friend Shared ReadOnly Property PostingProgress() As String
            Get
                Return ResourceManager.GetString("PostingProgress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to P&amp;rint.
        '''</summary>
        Friend Shared ReadOnly Property PrintButton() As String
            Get
                Return ResourceManager.GetString("PrintButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Printing Done!.
        '''</summary>
        Friend Shared ReadOnly Property PrintingDone() As String
            Get
                Return ResourceManager.GetString("PrintingDone", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Insert Passbook, and Press OK..
        '''</summary>
        Friend Shared ReadOnly Property PrintPassbookPrompt() As String
            Get
                Return ResourceManager.GetString("PrintPassbookPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There are [{0}] transactions that are not yet posted on Member&apos;s Passbook. Would you like to print?.
        '''</summary>
        Friend Shared ReadOnly Property PrintTransactionOnPassbook() As String
            Get
                Return ResourceManager.GetString("PrintTransactionOnPassbook", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Region.
        '''</summary>
        Friend Shared ReadOnly Property Region() As String
            Get
                Return ResourceManager.GetString("Region", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Resigned Members.
        '''</summary>
        Friend Shared ReadOnly Property ResignedMembers() As String
            Get
                Return ResourceManager.GetString("ResignedMembers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Resigned Members/Investors from {0} to {1}..
        '''</summary>
        Friend Shared ReadOnly Property ResignedMembersHeader() As String
            Get
                Return ResourceManager.GetString("ResignedMembersHeader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to reverse the last transaction?.
        '''</summary>
        Friend Shared ReadOnly Property ReverseTransactionPrompt() As String
            Get
                Return ResourceManager.GetString("ReverseTransactionPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Save.
        '''</summary>
        Friend Shared ReadOnly Property SaveButton() As String
            Get
                Return ResourceManager.GetString("SaveButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Find.
        '''</summary>
        Friend Shared ReadOnly Property SearchButton() As String
            Get
                Return ResourceManager.GetString("SearchButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New configration definitions are updated kindly restart the application to apply the changes.
        '''</summary>
        Friend Shared ReadOnly Property SetConfigSuccessful() As String
            Get
                Return ResourceManager.GetString("SetConfigSuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please specify the reason why Applicant is considered DORI.
        '''</summary>
        Friend Shared ReadOnly Property SpecifyDORIReason() As String
            Get
                Return ResourceManager.GetString("SpecifyDORIReason", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Patronage Refund Report (Summarized).
        '''</summary>
        Friend Shared ReadOnly Property SummarizedPatronageRefundReport() As String
            Get
                Return ResourceManager.GetString("SummarizedPatronageRefundReport", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to System Configuration.
        '''</summary>
        Friend Shared ReadOnly Property SystemConfiguration() As String
            Get
                Return ResourceManager.GetString("SystemConfiguration", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Transaction Code Not found! Please Contact your system administrator..
        '''</summary>
        Friend Shared ReadOnly Property TrancodeNotFound() As String
            Get
                Return ResourceManager.GetString("TrancodeNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Transaction Details.
        '''</summary>
        Friend Shared ReadOnly Property TransactionDetails() As String
            Get
                Return ResourceManager.GetString("TransactionDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please turn to next page, and Press OK..
        '''</summary>
        Friend Shared ReadOnly Property TurnPassbookPrompt() As String
            Get
                Return ResourceManager.GetString("TurnPassbookPrompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to process CASH DIVIDEND FOR YEAR:[{0}] QUARTER:[{1}]. Please check if the voucher is processed / dividend is posted..
        '''</summary>
        Friend Shared ReadOnly Property UnableToProcessDivref() As String
            Get
                Return ResourceManager.GetString("UnableToProcessDivref", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Update Failed!.
        '''</summary>
        Friend Shared ReadOnly Property Unsuccessful() As String
            Get
                Return ResourceManager.GetString("Unsuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Updated Record Successfully!.
        '''</summary>
        Friend Shared ReadOnly Property UpdateSuccessful() As String
            Get
                Return ResourceManager.GetString("UpdateSuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to User is already logged in. Please contact your administrator..
        '''</summary>
        Friend Shared ReadOnly Property UserIsLoggedIn() As String
            Get
                Return ResourceManager.GetString("UserIsLoggedIn", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
