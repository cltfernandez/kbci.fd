#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 10/04/2016 
#End Region



Namespace LUNA
    Public Class LunaContext

        Public Shared Property IsolationLevel() As Data.IsolationLevel
            Get
                Return IsolationLevel.ReadUncommitted
            End Get
            Set(ByVal value As Data.IsolationLevel)

            End Set
        End Property

    End Class
End Namespace