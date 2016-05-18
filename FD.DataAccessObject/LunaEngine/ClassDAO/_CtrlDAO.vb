#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Ctrl object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _CtrlDAO
Inherits LUNA.LunaBaseClassDAO(Of Ctrl)

''' <summary>
'''New() create an istance of this class. Use default DB Connection
''' </summary>
''' <returns>
'''
''' </returns>
Public Sub New()
	MyBase.New()
End Sub

''' <summary>
'''New() create an istance of this class and specify an OPENED DB connection
''' </summary>
''' <returns>
'''
''' </returns>
Public Sub New(ByVal Connection As DbConnection)
	MyBase.New(Connection)
End Sub

''' <summary>
'''Read from DB table Ctrl
''' </summary>
''' <returns>
'''Return a Ctrl object
''' </returns>
Public Overrides Function Read(Id as integer) as Ctrl
    Dim cls as new Ctrl

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Ctrl where CTRL_ID = " & Id
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader

                myReader.Read()
                if myReader.HasRows then
                    cls.FillFromDataRecord(CType(myReader, IDataRecord))	
                End If
                myReader.Close()
            End Using
        End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return cls
End Function

''' <summary>
'''Save on DB table Ctrl
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Ctrl) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.CTRL_ID = 0 Then
                        sql = "INSERT INTO Ctrl ("
                            sql &= " MAPP_NO,"
                            sql &= " LAPP_DATE,"
                            sql &= " LAPP_NO,"
                            sql &= " KBCI_NO,"
                            sql &= " PN_NO,"
                            sql &= " PAY_DAY,"
                            sql &= " SYSDATE,"
                            sql &= " ADMDATE,"
                            sql &= " L_DM,"
                            sql &= " L_CM,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " [USER],"
                            sql &= " CEILING,"
                            sql &= " TD_CVNO,"
                            sql &= " SDRATE,"
                            sql &= " PROC,"
                            sql &= " FDMIN,"
                            sql &= " FDMAX,"
                            sql &= " LRIMAX,"
                            sql &= " FD_REP,"
                            sql &= " REP1,"
                            sql &= " REP2,"
                            sql &= " REP3,"
                            sql &= " REP4,"
                            sql &= " REP5,"
                            sql &= " TD_REP,"
                            sql &= " APRUN_DATE,"
                            sql &= " ARRUN_DATA,"
                            sql &= " RUN_DATE,"
                            sql &= " ACCTBR,"
                            sql &= " ACCTSEQ,"
                            sql &= " VOUCHER,"
                            sql &= " CLOSE,"
                            sql &= " PMAXL,"
                            sql &= " LMAXL,"
                            sql &= " BINIT,"
                            sql &= " BPOST,"
                            sql &= " CLR_ONUS,"
                            sql &= " CLR_LOCAL,"
                            sql &= " CLR_REG,"
                            sql &= " MINBAL,"
                            sql &= " DBDORMANT,"
                            sql &= " EOM_FLAG,"
                            sql &= " EOQ_FLAG,"
                            sql &= " EOY_FLAG,"
                            sql &= " OTC_FLAG,"
                            sql &= " EOD_FLAG,"
                            sql &= " P_PRINT,"
                            sql &= " R_PRINT"
                      sql &= ") VALUES ("
                      sql &= " @MAPP_NO,"
                      sql &= " @LAPP_DATE,"
                      sql &= " @LAPP_NO,"
                      sql &= " @KBCI_NO,"
                      sql &= " @PN_NO,"
                      sql &= " @PAY_DAY,"
                      sql &= " @SYSDATE,"
                      sql &= " @ADMDATE,"
                      sql &= " @L_DM,"
                      sql &= " @L_CM,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER,"
                      sql &= " @CEILING,"
                      sql &= " @TD_CVNO,"
                      sql &= " @SDRATE,"
                      sql &= " @PROC,"
                      sql &= " @FDMIN,"
                      sql &= " @FDMAX,"
                      sql &= " @LRIMAX,"
                      sql &= " @FD_REP,"
                      sql &= " @REP1,"
                      sql &= " @REP2,"
                      sql &= " @REP3,"
                      sql &= " @REP4,"
                      sql &= " @REP5,"
                      sql &= " @TD_REP,"
                      sql &= " @APRUN_DATE,"
                      sql &= " @ARRUN_DATA,"
                      sql &= " @RUN_DATE,"
                      sql &= " @ACCTBR,"
                      sql &= " @ACCTSEQ,"
                      sql &= " @VOUCHER,"
                      sql &= " @CLOSE,"
                      sql &= " @PMAXL,"
                      sql &= " @LMAXL,"
                      sql &= " @BINIT,"
                      sql &= " @BPOST,"
                      sql &= " @CLR_ONUS,"
                      sql &= " @CLR_LOCAL,"
                      sql &= " @CLR_REG,"
                      sql &= " @MINBAL,"
                      sql &= " @DBDORMANT,"
                      sql &= " @EOM_FLAG,"
                      sql &= " @EOQ_FLAG,"
                      sql &= " @EOY_FLAG,"
                      sql &= " @OTC_FLAG,"
                      sql &= " @EOD_FLAG,"
                      sql &= " @P_PRINT,"
                      sql &= " @R_PRINT"
                      sql &= ")"
		            Else
			            sql = "UPDATE Ctrl SET "
                  sql &= "MAPP_NO = @MAPP_NO,"
                  sql &= "LAPP_DATE = @LAPP_DATE,"
                  sql &= "LAPP_NO = @LAPP_NO,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "PN_NO = @PN_NO,"
                  sql &= "PAY_DAY = @PAY_DAY,"
                  sql &= "SYSDATE = @SYSDATE,"
                  sql &= "ADMDATE = @ADMDATE,"
                  sql &= "L_DM = @L_DM,"
                  sql &= "L_CM = @L_CM,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "[USER] = @USER,"
                  sql &= "CEILING = @CEILING,"
                  sql &= "TD_CVNO = @TD_CVNO,"
                  sql &= "SDRATE = @SDRATE,"
                  sql &= "PROC = @PROC,"
                  sql &= "FDMIN = @FDMIN,"
                  sql &= "FDMAX = @FDMAX,"
                  sql &= "LRIMAX = @LRIMAX,"
                  sql &= "FD_REP = @FD_REP,"
                  sql &= "REP1 = @REP1,"
                  sql &= "REP2 = @REP2,"
                  sql &= "REP3 = @REP3,"
                  sql &= "REP4 = @REP4,"
                  sql &= "REP5 = @REP5,"
                  sql &= "TD_REP = @TD_REP,"
                  sql &= "APRUN_DATE = @APRUN_DATE,"
                  sql &= "ARRUN_DATA = @ARRUN_DATA,"
                  sql &= "RUN_DATE = @RUN_DATE,"
                  sql &= "ACCTBR = @ACCTBR,"
                  sql &= "ACCTSEQ = @ACCTSEQ,"
                  sql &= "VOUCHER = @VOUCHER,"
                  sql &= "CLOSE = @CLOSE,"
                  sql &= "PMAXL = @PMAXL,"
                  sql &= "LMAXL = @LMAXL,"
                  sql &= "BINIT = @BINIT,"
                  sql &= "BPOST = @BPOST,"
                  sql &= "CLR_ONUS = @CLR_ONUS,"
                  sql &= "CLR_LOCAL = @CLR_LOCAL,"
                  sql &= "CLR_REG = @CLR_REG,"
                  sql &= "MINBAL = @MINBAL,"
                  sql &= "DBDORMANT = @DBDORMANT,"
                  sql &= "EOM_FLAG = @EOM_FLAG,"
                  sql &= "EOQ_FLAG = @EOQ_FLAG,"
                  sql &= "EOY_FLAG = @EOY_FLAG,"
                  sql &= "OTC_FLAG = @OTC_FLAG,"
                  sql &= "EOD_FLAG = @EOD_FLAG,"
                  sql &= "P_PRINT = @P_PRINT,"
                  sql &= "R_PRINT = @R_PRINT"
			            sql &= " WHERE CTRL_ID= " & cls.CTRL_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@MAPP_NO"
					p.Value = cls.MAPP_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LAPP_DATE"
					p.DbType = DbType.DateTime
					if cls.LAPP_DATE <> Date.MinValue then
			            p.Value = cls.LAPP_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LAPP_NO"
					p.Value = cls.LAPP_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PN_NO"
					p.Value = cls.PN_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PAY_DAY"
					p.DbType = DbType.DateTime
					if cls.PAY_DAY <> Date.MinValue then
			            p.Value = cls.PAY_DAY
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SYSDATE"
					p.DbType = DbType.DateTime
					if cls.SYSDATE <> Date.MinValue then
			            p.Value = cls.SYSDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADMDATE"
					p.DbType = DbType.DateTime
					if cls.ADMDATE <> Date.MinValue then
			            p.Value = cls.ADMDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@L_DM"
					p.Value = cls.L_DM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@L_CM"
					p.Value = cls.L_CM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADD_DATE"
					p.DbType = DbType.DateTime
					if cls.ADD_DATE <> Date.MinValue then
			            p.Value = cls.ADD_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHG_DATE"
					p.DbType = DbType.DateTime
					if cls.CHG_DATE <> Date.MinValue then
			            p.Value = cls.CHG_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@USER"
					p.Value = cls.USER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CEILING"
					p.Value = cls.CEILING
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TD_CVNO"
					p.Value = cls.TD_CVNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDRATE"
					p.Value = cls.SDRATE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PROC"
					p.DbType = DbType.DateTime
					if cls.PROC <> Date.MinValue then
			            p.Value = cls.PROC
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FDMIN"
					p.Value = cls.FDMIN
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FDMAX"
					p.Value = cls.FDMAX
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LRIMAX"
					p.Value = cls.LRIMAX
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_REP"
					p.Value = cls.FD_REP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REP1"
					p.Value = cls.REP1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REP2"
					p.Value = cls.REP2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REP3"
					p.Value = cls.REP3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REP4"
					p.Value = cls.REP4
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REP5"
					p.Value = cls.REP5
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TD_REP"
					p.Value = cls.TD_REP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@APRUN_DATE"
					p.DbType = DbType.DateTime
					if cls.APRUN_DATE <> Date.MinValue then
			            p.Value = cls.APRUN_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARRUN_DATA"
					p.DbType = DbType.DateTime
					if cls.ARRUN_DATA <> Date.MinValue then
			            p.Value = cls.ARRUN_DATA
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RUN_DATE"
					p.DbType = DbType.DateTime
					if cls.RUN_DATE <> Date.MinValue then
			            p.Value = cls.RUN_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTBR"
					p.Value = cls.ACCTBR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTSEQ"
					p.Value = cls.ACCTSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@VOUCHER"
					p.Value = cls.VOUCHER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLOSE"
					p.Value = cls.CLOSE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PMAXL"
					p.Value = cls.PMAXL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LMAXL"
					p.Value = cls.LMAXL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BINIT"
					p.Value = cls.BINIT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BPOST"
					p.Value = cls.BPOST
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_ONUS"
					p.Value = cls.CLR_ONUS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_LOCAL"
					p.Value = cls.CLR_LOCAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_REG"
					p.Value = cls.CLR_REG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MINBAL"
					p.Value = cls.MINBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DBDORMANT"
					p.Value = cls.DBDORMANT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOM_FLAG"
					p.Value = cls.EOM_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOQ_FLAG"
					p.Value = cls.EOQ_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOY_FLAG"
					p.Value = cls.EOY_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OTC_FLAG"
					p.Value = cls.OTC_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOD_FLAG"
					p.Value = cls.EOD_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_PRINT"
					p.Value = cls.P_PRINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@R_PRINT"
					p.Value = cls.R_PRINT
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.CTRL_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.CTRL_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.CTRL_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.CTRL_ID
        End If

    Else
	    throw new ApplicationException("Object data is not valid")
    End If
    Return Ris
End Function

Private Sub DestroyPermanently(Id as integer) 
    Try

    Using myCommand As DbCommand = _Cn.CreateCommand
        myCommand.Connection = _cn

        '******IMPORTANT: You can use this commented instruction to make a logical delete .
        '******Replace DELETED Field with your logic deleted field name.
        'Dim Sql As String = "UPDATE Ctrl SET DELETED=True "
        Dim Sql As String = "DELETE FROM Ctrl"
        Sql &= " Where CTRL_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Ctrl. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Ctrl. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Ctrl, Optional ByRef ListaObj as List (of Ctrl) = Nothing)
        DestroyPermanently (obj.CTRL_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return first of Ctrl
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ctrl
    Dim ris As Ctrl = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Ctrl) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return first of Ctrl
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ctrl
    Dim ris As Ctrl = Nothing
    Dim So As New LUNA.LunaSearchOption With { .Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Ctrl) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return a list of Ctrl
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return a list of Ctrl
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return a list of Ctrl
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl
''' </summary>
''' <returns>
'''Return a list of Ctrl
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ctrl)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Ctrl)
    Dim Ls As New List(Of Ctrl)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Ctrl" 
    For Each Par As LUNA.LunaSearchParameter In Parameter
	    If Not Par Is Nothing Then
		    If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		        sql &= Par.FieldName & " " & Par.SqlOperator
                If Par.SqlOperator.IndexOf("IN") <> -1 Then
                    sql &= " " & ApIn(Par.Value)
                Else
                    sql &= " " & Ap(Par.Value)
                End If
	    End if
    Next

            If Not SearchOption.OrderBy = Nothing Then
                sql &= " ORDER BY " & SearchOption.OrderBy
            End If

	
    Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Ctrl)
    Dim Ls As New List(Of Ctrl)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Ctrl" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Ctrl)
        Dim Ls As New List(Of Ctrl)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Ctrl() With {.CTRL_ID = Nothing, .MAPP_NO = "", .LAPP_DATE = Nothing, .LAPP_NO = 0, .KBCI_NO = "", .PN_NO = 0, .PAY_DAY = Nothing, .SYSDATE = Nothing, .ADMDATE = Nothing, .L_DM = 0, .L_CM = 0, .ADD_DATE = Nothing, .CHG_DATE = Nothing, .USER = "", .CEILING = 0, .TD_CVNO = 0, .SDRATE = 0, .PROC = Nothing, .FDMIN = 0, .FDMAX = 0, .LRIMAX = 0, .FD_REP = False, .REP1 = False, .REP2 = False, .REP3 = False, .REP4 = False, .REP5 = False, .TD_REP = False, .APRUN_DATE = Nothing, .ARRUN_DATA = Nothing, .RUN_DATE = Nothing, .ACCTBR = "", .ACCTSEQ = 0, .VOUCHER = 0, .CLOSE = False, .PMAXL = 0, .LMAXL = 0, .BINIT = False, .BPOST = False, .CLR_ONUS = 0, .CLR_LOCAL = 0, .CLR_REG = 0, .MINBAL = 0, .DBDORMANT = 0, .EOM_FLAG = False, .EOQ_FLAG = False, .EOY_FLAG = False, .OTC_FLAG = False, .EOD_FLAG = False, .P_PRINT = "", .R_PRINT = ""})
                    While myReader.Read
                        Dim classe As New Ctrl(CType(myReader, IDataRecord))
                        Ls.Add(classe)
                    End While
                    myReader.Close()
                End Using
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class
