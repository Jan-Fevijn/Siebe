Imports MySql.Data.MySqlClient
Public Class broodtype
Private connStr As String = "server= localhost;user= root;password= usbw;port= 3307;database=project3;"
Private conn As New MySqlConnection(connStr)
Private _broodnaam as String
    Private _idbroodtype As Integer
    Private _kostprijs As String
    Private _aantalIn As String

    Public Sub New()
    End Sub

    Public Sub New(broodnaam As String, idbroodtype As Integer)
        Me.broodnaam = broodnaam
        Me.idbroodtype = idbroodtype
    End Sub

    Public Property aantalIn() As String
        Get
            Return _aantalIn
        End Get
        Set(ByVal value As String)
            _aantalIn = value
        End Set
    End Property
    Public Property kostprijs() As String
        Get
            Return _kostprijs
        End Get
        Set(ByVal value As String)
            _kostprijs = value
        End Set
    End Property
    Public Property broodnaam() As String
        Get
            Return _broodnaam
        End Get
        Set(ByVal value As String)
            _broodnaam = value
        End Set
    End Property
    Public Property idbroodtype() As Integer
        Get
            Return _idbroodtype
        End Get
        Set(ByVal value As Integer)
            _idbroodtype = value
        End Set
    End Property

    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO broodtype(broodnaam,idbroodtype) VALUES(@broodnaam,@idbroodtype)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@broodnaam", broodnaam())
                    cmd.Parameters.AddWithValue("@idbroodtype", idbroodtype())
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
            Dim query As String = "Update broodtype SET broodnaam=@broodnaam WHERE idbroodtype = @idbroodtype"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@broodnaam", broodnaam())
                    cmd.Parameters.AddWithValue("@idbroodtype", idbroodtype())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Shared Function GetOne(ByVal ID As Integer) As broodtype
        Dim myObj As New broodtype()
        Using conn = New MySqlConnection("server= localhost;user= root;password= usbw;port= 3307;database=project3;")
            Dim query As String = "SELECT * FROM broodtype WHERE idbroodtype = @idbroodtype"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idbroodtype", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.broodnaam = reader("broodnaam").ToString()
                            myObj.idbroodtype = Convert.ToInt32(reader("idbroodtype"))
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
            Dim query As String = "SELECT * FROM broodtype"
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
