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
'''This class manage persistency on db of Divrefh object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DivrefhDAO
Inherits LUNA.LunaBaseClassDAO(Of Divrefh)

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
'''Read from DB table Divrefh
''' </summary>
''' <returns>
'''Return a Divrefh object
''' </returns>
Public Overrides Function Read(Id as integer) as Divrefh
    Dim cls as new Divrefh

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Divrefh where DIVREFH_ID = " & Id
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
'''Save on DB table Divrefh
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Divrefh) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.DIVREFH_ID = 0 Then
                        sql = "INSERT INTO Divrefh ("
                            sql &= " YEAR,"
                            sql &= " QUARTER,"
                            sql &= " KBCI_NO,"
                            sql &= " LNAME,"
                            sql &= " FNAME,"
                            sql &= " MI,"
                            sql &= " FEBTC_SA,"
                            sql &= " DIVIDEND,"
                            sql &= " REFUND,"
                            sql &= " DEDUCTIONS"
                      sql &= ") VALUES ("
                      sql &= " @YEAR,"
                      sql &= " @QUARTER,"
                      sql &= " @KBCI_NO,"
                      sql &= " @LNAME,"
                      sql &= " @FNAME,"
                      sql &= " @MI,"
                      sql &= " @FEBTC_SA,"
                      sql &= " @DIVIDEND,"
                      sql &= " @REFUND,"
                      sql &= " @DEDUCTIONS"
                      sql &= ")"
		            Else
			            sql = "UPDATE Divrefh SET "
                  sql &= "YEAR = @YEAR,"
                  sql &= "QUARTER = @QUARTER,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "LNAME = @LNAME,"
                  sql &= "FNAME = @FNAME,"
                  sql &= "MI = @MI,"
                  sql &= "FEBTC_SA = @FEBTC_SA,"
                  sql &= "DIVIDEND = @DIVIDEND,"
                  sql &= "REFUND = @REFUND,"
                  sql &= "DEDUCTIONS = @DEDUCTIONS"
			            sql &= " WHERE DIVREFH_ID= " & cls.DIVREFH_ID
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
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LNAME"
					p.Value = cls.LNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FNAME"
					p.Value = cls.FNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MI"
					p.Value = cls.MI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FEBTC_SA"
					p.Value = cls.FEBTC_SA
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DIVIDEND"
					p.Value = cls.DIVIDEND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REFUND"
					p.Value = cls.REFUND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DEDUCTIONS"
					p.Value = cls.DEDUCTIONS
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.DIVREFH_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.DIVREFH_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.DIVREFH_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.DIVREFH_ID
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
        'Dim Sql As String = "UPDATE Divrefh SET DELETED=True "
        Dim Sql As String = "DELETE FROM Divrefh"
        Sql &= " Where DIVREFH_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Divrefh. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Divrefh. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Divrefh, Optional ByRef ListaObj as List (of Divrefh) = Nothing)
        DestroyPermanently (obj.DIVREFH_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return first of Divrefh
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Divrefh
    Dim ris As Divrefh = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Divrefh) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return first of Divrefh
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Divrefh
    Dim ris As Divrefh = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Divrefh) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return a list of Divrefh
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefh)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return a list of Divrefh
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefh)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return a list of Divrefh
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Divrefh)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Divrefh
''' </summary>
''' <returns>
'''Return a list of Divrefh
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Divrefh)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Divrefh)
    Dim Ls As New List(Of Divrefh)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Divrefh" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Divrefh)
    Dim Ls As New List(Of Divrefh)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Divrefh" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Divrefh)
        Dim Ls As New List(Of Divrefh)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Divrefh() With {.DIVREFH_ID = Nothing, .YEAR = "", .QUARTER = "", .KBCI_NO = "", .LNAME = "", .FNAME = "", .MI = "", .FEBTC_SA = "", .DIVIDEND = 0, .REFUND = 0, .DEDUCTIONS = 0})
                    While myReader.Read
                        Dim classe As New Divrefh(CType(myReader, IDataRecord))
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
