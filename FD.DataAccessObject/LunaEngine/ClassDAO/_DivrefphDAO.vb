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
'''This class manage persistency on db of Divrefph object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DivrefphDAO
Inherits LUNA.LunaBaseClassDAO(Of Divrefph)

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
'''Read from DB table Divrefph
''' </summary>
''' <returns>
'''Return a Divrefph object
''' </returns>
Public Overrides Function Read(Id as integer) as Divrefph
    Dim cls as new Divrefph

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Divrefph where DIVREFPH_ID = " & Id
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
'''Save on DB table Divrefph
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Divrefph) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.DIVREFPH_ID = 0 Then
                        sql = "INSERT INTO Divrefph ("
                            sql &= " YEAR,"
                            sql &= " QUARTER,"
                            sql &= " FD_CUTOFF,"
                            sql &= " FD_PERCENT,"
                            sql &= " PR_YEAR,"
                            sql &= " PR_PERCENT,"
                            sql &= " PR_INTFROM,"
                            sql &= " PR_INTTO,"
                            sql &= " TDEBDESC1,"
                            sql &= " TDEBAMT1,"
                            sql &= " TDEBDESC2,"
                            sql &= " TDEBAMT2,"
                            sql &= " TDEBDESC3,"
                            sql &= " TDEBAMT3,"
                            sql &= " TDIVAMT,"
                            sql &= " TREFAMT,"
                            sql &= " [USER],"
                            sql &= " HOLDOUT,"
                            sql &= " POSTED,"
                            sql &= " CVNO,"
                            sql &= " ADD_DATE,"
                            sql &= " P_APL,"
                            sql &= " P_EDL,"
                            sql &= " P_EML,"
                            sql &= " P_RGL,"
                            sql &= " P_RSL,"
                            sql &= " P_SPL,"
                            sql &= " P_STL,"
                            sql &= " P_PTL,"
                            sql &= " PD_APL,"
                            sql &= " PD_EDL,"
                            sql &= " PD_EML,"
                            sql &= " PD_RGL,"
                            sql &= " PD_RSL,"
                            sql &= " PD_SPL,"
                            sql &= " PD_STL,"
                            sql &= " PD_PTL,"
                            sql &= " INTEREST,"
                            sql &= " PENALTY,"
                            sql &= " SAVINGS"
                      sql &= ") VALUES ("
                      sql &= " @YEAR,"
                      sql &= " @QUARTER,"
                      sql &= " @FD_CUTOFF,"
                      sql &= " @FD_PERCENT,"
                      sql &= " @PR_YEAR,"
                      sql &= " @PR_PERCENT,"
                      sql &= " @PR_INTFROM,"
                      sql &= " @PR_INTTO,"
                      sql &= " @TDEBDESC1,"
                      sql &= " @TDEBAMT1,"
                      sql &= " @TDEBDESC2,"
                      sql &= " @TDEBAMT2,"
                      sql &= " @TDEBDESC3,"
                      sql &= " @TDEBAMT3,"
                      sql &= " @TDIVAMT,"
                      sql &= " @TREFAMT,"
                      sql &= " @USER,"
                      sql &= " @HOLDOUT,"
                      sql &= " @POSTED,"
                      sql &= " @CVNO,"
                      sql &= " @ADD_DATE,"
                      sql &= " @P_APL,"
                      sql &= " @P_EDL,"
                      sql &= " @P_EML,"
                      sql &= " @P_RGL,"
                      sql &= " @P_RSL,"
                      sql &= " @P_SPL,"
                      sql &= " @P_STL,"
                      sql &= " @P_PTL,"
                      sql &= " @PD_APL,"
                      sql &= " @PD_EDL,"
                      sql &= " @PD_EML,"
                      sql &= " @PD_RGL,"
                      sql &= " @PD_RSL,"
                      sql &= " @PD_SPL,"
                      sql &= " @PD_STL,"
                      sql &= " @PD_PTL,"
                      sql &= " @INTEREST,"
                      sql &= " @PENALTY,"
                      sql &= " @SAVINGS"
                      sql &= ")"
		            Else
			            sql = "UPDATE Divrefph SET "
                  sql &= "YEAR = @YEAR,"
                  sql &= "QUARTER = @QUARTER,"
                  sql &= "FD_CUTOFF = @FD_CUTOFF,"
                  sql &= "FD_PERCENT = @FD_PERCENT,"
                  sql &= "PR_YEAR = @PR_YEAR,"
                  sql &= "PR_PERCENT = @PR_PERCENT,"
                  sql &= "PR_INTFROM = @PR_INTFROM,"
                  sql &= "PR_INTTO = @PR_INTTO,"
                  sql &= "TDEBDESC1 = @TDEBDESC1,"
                  sql &= "TDEBAMT1 = @TDEBAMT1,"
                  sql &= "TDEBDESC2 = @TDEBDESC2,"
                  sql &= "TDEBAMT2 = @TDEBAMT2,"
                  sql &= "TDEBDESC3 = @TDEBDESC3,"
                  sql &= "TDEBAMT3 = @TDEBAMT3,"
                  sql &= "TDIVAMT = @TDIVAMT,"
                  sql &= "TREFAMT = @TREFAMT,"
                            sql &= "[USER] = @USER,"
                  sql &= "HOLDOUT = @HOLDOUT,"
                  sql &= "POSTED = @POSTED,"
                  sql &= "CVNO = @CVNO,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "P_APL = @P_APL,"
                  sql &= "P_EDL = @P_EDL,"
                  sql &= "P_EML = @P_EML,"
                  sql &= "P_RGL = @P_RGL,"
                  sql &= "P_RSL = @P_RSL,"
                  sql &= "P_SPL = @P_SPL,"
                  sql &= "P_STL = @P_STL,"
                  sql &= "P_PTL = @P_PTL,"
                  sql &= "PD_APL = @PD_APL,"
                  sql &= "PD_EDL = @PD_EDL,"
                  sql &= "PD_EML = @PD_EML,"
                  sql &= "PD_RGL = @PD_RGL,"
                  sql &= "PD_RSL = @PD_RSL,"
                  sql &= "PD_SPL = @PD_SPL,"
                  sql &= "PD_STL = @PD_STL,"
                  sql &= "PD_PTL = @PD_PTL,"
                  sql &= "INTEREST = @INTEREST,"
                  sql &= "PENALTY = @PENALTY,"
                  sql &= "SAVINGS = @SAVINGS"
			            sql &= " WHERE DIVREFPH_ID= " & cls.DIVREFPH_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@YEAR"
					p.Value = cls.YEAR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@QUARTER"
					p.Value = cls.QUARTER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_CUTOFF"
					p.DbType = DbType.DateTime
					if cls.FD_CUTOFF <> Date.MinValue then
			            p.Value = cls.FD_CUTOFF
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_PERCENT"
					p.Value = cls.FD_PERCENT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PR_YEAR"
					p.Value = cls.PR_YEAR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PR_PERCENT"
					p.Value = cls.PR_PERCENT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PR_INTFROM"
					p.DbType = DbType.DateTime
					if cls.PR_INTFROM <> Date.MinValue then
			            p.Value = cls.PR_INTFROM
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PR_INTTO"
					p.DbType = DbType.DateTime
					if cls.PR_INTTO <> Date.MinValue then
			            p.Value = cls.PR_INTTO
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBDESC1"
					p.Value = cls.TDEBDESC1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBAMT1"
					p.Value = cls.TDEBAMT1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBDESC2"
					p.Value = cls.TDEBDESC2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBAMT2"
					p.Value = cls.TDEBAMT2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBDESC3"
					p.Value = cls.TDEBDESC3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDEBAMT3"
					p.Value = cls.TDEBAMT3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDIVAMT"
					p.Value = cls.TDIVAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TREFAMT"
					p.Value = cls.TREFAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@USER"
					p.Value = cls.USER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@HOLDOUT"
					p.Value = cls.HOLDOUT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@POSTED"
					p.Value = cls.POSTED
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CVNO"
					p.Value = cls.CVNO
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
					p.ParameterName = "@P_APL"
					p.Value = cls.P_APL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_EDL"
					p.Value = cls.P_EDL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_EML"
					p.Value = cls.P_EML
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_RGL"
					p.Value = cls.P_RGL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_RSL"
					p.Value = cls.P_RSL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_SPL"
					p.Value = cls.P_SPL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_STL"
					p.Value = cls.P_STL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_PTL"
					p.Value = cls.P_PTL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_APL"
					p.Value = cls.PD_APL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_EDL"
					p.Value = cls.PD_EDL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_EML"
					p.Value = cls.PD_EML
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_RGL"
					p.Value = cls.PD_RGL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_RSL"
					p.Value = cls.PD_RSL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_SPL"
					p.Value = cls.PD_SPL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_STL"
					p.Value = cls.PD_STL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PD_PTL"
					p.Value = cls.PD_PTL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@INTEREST"
					p.Value = cls.INTEREST
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PENALTY"
					p.Value = cls.PENALTY
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SAVINGS"
					p.Value = cls.SAVINGS
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.DIVREFPH_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.DIVREFPH_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.DIVREFPH_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.DIVREFPH_ID
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
        'Dim Sql As String = "UPDATE Divrefph SET DELETED=True "
        Dim Sql As String = "DELETE FROM Divrefph"
        Sql &= " Where DIVREFPH_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Divrefph. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Divrefph. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Divrefph, Optional ByRef ListaObj as List (of Divrefph) = Nothing)
        DestroyPermanently (obj.DIVREFPH_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return first of Divrefph
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Divrefph
    Dim ris As Divrefph = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Divrefph) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return first of Divrefph
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Divrefph
    Dim ris As Divrefph = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Divrefph) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return a list of Divrefph
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefph)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return a list of Divrefph
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefph)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return a list of Divrefph
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefph)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefph
''' </summary>
''' <returns>
'''Return a list of Divrefph
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Divrefph)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Divrefph)
    Dim Ls As New List(Of Divrefph)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Divrefph" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Divrefph)
    Dim Ls As New List(Of Divrefph)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Divrefph" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Divrefph)
        Dim Ls As New List(Of Divrefph)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Divrefph() With {.DIVREFPH_ID = Nothing, .YEAR = "", .QUARTER = "", .FD_CUTOFF = Nothing, .FD_PERCENT = 0, .PR_YEAR = "", .PR_PERCENT = 0, .PR_INTFROM = Nothing, .PR_INTTO = Nothing, .TDEBDESC1 = "", .TDEBAMT1 = 0, .TDEBDESC2 = "", .TDEBAMT2 = 0, .TDEBDESC3 = "", .TDEBAMT3 = 0, .TDIVAMT = 0, .TREFAMT = 0, .USER = "", .HOLDOUT = False, .POSTED = False, .CVNO = "", .ADD_DATE = Nothing, .P_APL = 0, .P_EDL = 0, .P_EML = 0, .P_RGL = 0, .P_RSL = 0, .P_SPL = 0, .P_STL = 0, .P_PTL = 0, .PD_APL = 0, .PD_EDL = 0, .PD_EML = 0, .PD_RGL = 0, .PD_RSL = 0, .PD_SPL = 0, .PD_STL = 0, .PD_PTL = 0, .INTEREST = 0, .PENALTY = 0, .SAVINGS = 0})
                    While myReader.Read
                        Dim classe As New Divrefph(CType(myReader, IDataRecord))
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
