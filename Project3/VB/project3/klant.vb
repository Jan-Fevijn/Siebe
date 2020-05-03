Imports MySql.Data.MySqlClient
Public Class klant
    Private connStr As String = "server= localhost;user= root;password= usbw;port= 3306;database=project3;"
    Private conn As New MySqlConnection(connStr)
Private _code as Integer
Private _idklant as Integer
    Private _naam As String
    Private _saldo As String
    Public Sub New()
    End Sub

    Public Sub New(code As Integer, idklant As Integer, naam As String)
        Me.code = code
        Me.idklant = idklant
        Me.naam = naam
    End Sub

    Public Property code() As Integer
        Get
            Return _code
        End Get
        Set(ByVal value As Integer)
            _code = value
        End Set
    End Property

    Public Property idklant() As Integer
        Get
            Return _idklant
        End Get
        Set(ByVal value As Integer)
            _idklant = value
        End Set
    End Property

    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property
    Public Property saldo() As String
        Get
            Return _Saldo
        End Get
        Set(ByVal value As String)
            _saldo = value
        End Set
    End Property
    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO klant(code,idklant,naam) VALUES(@code,@idklant,@naam)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", code())
                    cmd.Parameters.AddWithValue("@idklant", idklant())
                    cmd.Parameters.AddWithValue("@naam", naam())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Sub Update()
        Using Conn = New MySqlConnection(connStr)
            Dim query As String = "Update klant SET code=@code,naam=@naam WHERE idklant = @idklant"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", code())
                    cmd.Parameters.AddWithValue("@idklant", idklant())
                    cmd.Parameters.AddWithValue("@naam", naam())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Shared Function GetOne(ByVal ID As Integer) As klant
        Dim myObj As New klant()
        Using conn = New MySqlConnection("server= localhost;user= root;password= usbw;port= 3307;database=project3;")
            Dim query As String = "SELECT * FROM klant WHERE idklant = @idklant"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idklant", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.code = Convert.ToInt32(reader("code"))
                            myObj.idklant = Convert.ToInt32(reader("idklant"))
                            myObj.naam = reader("naam").ToString()
                        End If
                    End Using
                End Using
                Return myObj
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
        End Using
    End Function

    Public Shared Function GetAll() As Datatable
        Using conn = New MySqlConnection("server= localhost;user= root;password= usbw;port= 3307;database=project3;")
            conn.Open()
            Dim datatable As New DataTable()
            Dim query As String = "SELECT * FROM klant"
            Try
                Using cmd = New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        datatable.load(reader)
                    End Using
                    Return datatable
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
        End Using
    End Function

End Class
