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
'''This class manage persistency on db of Ledger object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _LedgerDAO
Inherits LUNA.LunaBaseClassDAO(Of Ledger)

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
'''Read from DB table Ledger
''' </summary>
''' <returns>
'''Return a Ledger object
''' </returns>
Public Overrides Function Read(Id as integer) as Ledger
    Dim cls as new Ledger

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Ledger where LEDGER_ID = " & Id
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
'''Save on DB table Ledger
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Ledger) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.LEDGER_ID = 0 Then
                        sql = "INSERT INTO Ledger ("
                            sql &= " PN_NO,"
                            sql &= " [DATE],"
                            sql &= " DOX_TYPE,"
                            sql &= " REF,"
                            sql &= " ACCT_TYPE,"
                            sql &= " ACCT_CODE,"
                            sql &= " BEGBAL,"
                            sql &= " DR,"
                            sql &= " CR,"
                            sql &= " ENDBAL,"
                            sql &= " RMK,"
                            sql &= " ADD_DATE,"
                            sql &= " USER"
                      sql &= ") VALUES ("
                      sql &= " @PN_NO,"
                      sql &= " @DATE,"
                      sql &= " @DOX_TYPE,"
                      sql &= " @REF,"
                      sql &= " @ACCT_TYPE,"
                      sql &= " @ACCT_CODE,"
                      sql &= " @BEGBAL,"
                      sql &= " @DR,"
                      sql &= " @CR,"
                      sql &= " @ENDBAL,"
                      sql &= " @RMK,"
                      sql &= " @ADD_DATE,"
                      sql &= " @USER"
                      sql &= ")"
		            Else
			            sql = "UPDATE Ledger SET "
                  sql &= "PN_NO = @PN_NO,"
                            sql &= "[DATE] = @DATE,"
                  sql &= "DOX_TYPE = @DOX_TYPE,"
                  sql &= "REF = @REF,"
                  sql &= "ACCT_TYPE = @ACCT_TYPE,"
                  sql &= "ACCT_CODE = @ACCT_CODE,"
                  sql &= "BEGBAL = @BEGBAL,"
                  sql &= "DR = @DR,"
                  sql &= "CR = @CR,"
                  sql &= "ENDBAL = @ENDBAL,"
                  sql &= "RMK = @RMK,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "USER = @USER"
			            sql &= " WHERE LEDGER_ID= " & cls.LEDGER_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@PN_NO"
					p.Value = cls.PN_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DATE"
					p.DbType = DbType.DateTime
					if cls.DATE <> Date.MinValue then
			            p.Value = cls.DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DOX_TYPE"
					p.Value = cls.DOX_TYPE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REF"
					p.Value = cls.REF
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCT_TYPE"
					p.Value = cls.ACCT_TYPE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCT_CODE"
					p.Value = cls.ACCT_CODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BEGBAL"
					p.Value = cls.BEGBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DR"
					p.Value = cls.DR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CR"
					p.Value = cls.CR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ENDBAL"
					p.Value = cls.ENDBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RMK"
					p.Value = cls.RMK
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
					p.ParameterName = "@USER"
					p.Value = cls.USER
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.LEDGER_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.LEDGER_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.LEDGER_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.LEDGER_ID
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
        'Dim Sql As String = "UPDATE Ledger SET DELETED=True "
        Dim Sql As String = "DELETE FROM Ledger"
        Sql &= " Where LEDGER_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Ledger. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Ledger. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Ledger, Optional ByRef ListaObj as List (of Ledger) = Nothing)
        DestroyPermanently (obj.LEDGER_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return first of Ledger
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ledger
    Dim ris As Ledger = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Ledger) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return first of Ledger
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ledger
    Dim ris As Ledger = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Ledger) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return a list of Ledger
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ledger)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return a list of Ledger
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ledger)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return a list of Ledger
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ledger)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ledger
''' </summary>
''' <returns>
'''Return a list of Ledger
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ledger)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Ledger)
    Dim Ls As New List(Of Ledger)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Ledger" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Ledger)
    Dim Ls As New List(Of Ledger)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Ledger" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Ledger)
        Dim Ls As New List(Of Ledger)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Ledger() With {.LEDGER_ID = Nothing, .PN_NO = "", .DATE = Nothing, .DOX_TYPE = "", .REF = "", .ACCT_TYPE = "", .ACCT_CODE = "", .BEGBAL = 0, .DR = 0, .CR = 0, .ENDBAL = 0, .RMK = "", .ADD_DATE = Nothing, .USER = ""})
                    While myReader.Read
                        Dim classe As New Ledger(CType(myReader, IDataRecord))
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
