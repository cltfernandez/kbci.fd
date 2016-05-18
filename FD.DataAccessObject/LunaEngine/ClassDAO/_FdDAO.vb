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
'''This class manage persistency on db of Fd object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _FdDAO
Inherits LUNA.LunaBaseClassDAO(Of Fd)

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
'''Read from DB table Fd
''' </summary>
''' <returns>
'''Return a Fd object
''' </returns>
Public Overrides Function Read(Id as integer) as Fd
    Dim cls as new Fd

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Fd where FD_ID = " & Id
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
'''Save on DB table Fd
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Fd) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.FD_ID = 0 Then
                        sql = "INSERT INTO Fd ("
                            sql &= " KBCI_NO,"
                            sql &= " TRAN_CODE,"
                            sql &= " [DATE],"
                            sql &= " REF,"
                            sql &= " AMOUNT,"
                            sql &= " BALANCE,"
                            sql &= " RMK,"
                            sql &= " ADD_DATE,"
                            sql &= " [USER],"
                            sql &= " LPOSTED,"
                            sql &= " DRCR,"
                            sql &= " BANK_CODE,"
                            sql &= " CHECKNO,"
                            sql &= " TPOSTED,"
                            sql &= " TREVERSED"
                      sql &= ") VALUES ("
                      sql &= " @KBCI_NO,"
                      sql &= " @TRAN_CODE,"
                      sql &= " @DATE,"
                      sql &= " @REF,"
                      sql &= " @AMOUNT,"
                      sql &= " @BALANCE,"
                      sql &= " @RMK,"
                      sql &= " @ADD_DATE,"
                      sql &= " @USER,"
                      sql &= " @LPOSTED,"
                      sql &= " @DRCR,"
                      sql &= " @BANK_CODE,"
                      sql &= " @CHECKNO,"
                      sql &= " @TPOSTED,"
                      sql &= " @TREVERSED"
                      sql &= ")"
		            Else
			            sql = "UPDATE Fd SET "
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "TRAN_CODE = @TRAN_CODE,"
                            sql &= "[DATE] = @DATE,"
                  sql &= "REF = @REF,"
                  sql &= "AMOUNT = @AMOUNT,"
                  sql &= "BALANCE = @BALANCE,"
                  sql &= "RMK = @RMK,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                            sql &= "[USER] = @USER,"
                  sql &= "LPOSTED = @LPOSTED,"
                  sql &= "DRCR = @DRCR,"
                  sql &= "BANK_CODE = @BANK_CODE,"
                  sql &= "CHECKNO = @CHECKNO,"
                  sql &= "TPOSTED = @TPOSTED,"
                  sql &= "TREVERSED = @TREVERSED"
			            sql &= " WHERE FD_ID= " & cls.FD_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TRAN_CODE"
					p.Value = cls.TRAN_CODE
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
					p.ParameterName = "@REF"
					p.Value = cls.REF
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@AMOUNT"
					p.Value = cls.AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BALANCE"
					p.Value = cls.BALANCE
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

					p = myCommand.CreateParameter
					p.ParameterName = "@LPOSTED"
					p.Value = cls.LPOSTED
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DRCR"
					p.Value = cls.DRCR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BANK_CODE"
					p.Value = cls.BANK_CODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHECKNO"
					p.Value = cls.CHECKNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TPOSTED"
					p.Value = cls.TPOSTED
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TREVERSED"
					p.Value = cls.TREVERSED
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.FD_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.FD_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.FD_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.FD_ID
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
        'Dim Sql As String = "UPDATE Fd SET DELETED=True "
        Dim Sql As String = "DELETE FROM Fd"
        Sql &= " Where FD_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Fd. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Fd. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Fd, Optional ByRef ListaObj as List (of Fd) = Nothing)
        DestroyPermanently (obj.FD_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return first of Fd
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Fd
    Dim ris As Fd = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Fd) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return first of Fd
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Fd
    Dim ris As Fd = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Fd) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return a list of Fd
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Fd)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return a list of Fd
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Fd)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return a list of Fd
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Fd)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Fd
''' </summary>
''' <returns>
'''Return a list of Fd
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Fd)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Fd)
    Dim Ls As New List(Of Fd)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Fd" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Fd)
    Dim Ls As New List(Of Fd)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Fd" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Fd)
        Dim Ls As New List(Of Fd)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Fd() With {.FD_ID = Nothing, .KBCI_NO = "", .TRAN_CODE = "", .DATE = Nothing, .REF = "", .AMOUNT = 0, .BALANCE = 0, .RMK = "", .ADD_DATE = Nothing, .USER = "", .LPOSTED = 0, .DRCR = "", .BANK_CODE = "", .CHECKNO = "", .TPOSTED = False, .TREVERSED = False})
                    While myReader.Read
                        Dim classe As New Fd(CType(myReader, IDataRecord))
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
