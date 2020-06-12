Imports MySql.Data.MySqlClient
Public Class automaat
    Private connStr As String = "server=localhost;user=root;password=usbw;port=3306;database=project3;"
    Private conn As New MySqlConnection(connStr)
    Private _aantal As Integer
    Private _brood As brood
    Private _datum As Date
    Private _idautomaat As Integer
    Private _locatie As Integer
    Private _prijs As String
    Public Sub New()
    End Sub
    Public Sub New(aantal As Integer, brood As brood, datum As Date, idAutomaat As Integer, locatie As Integer, prijs As String)
        Me.aantal = aantal
        Me.brood = brood
        Me.datum = datum
        Me.idAutomaat = idAutomaat
        Me.locatie = locatie
        Me.prijs = prijs
    End Sub
    Public Property aantal() As Integer
        Get
            Return _aantal
        End Get
        Set(ByVal value As Integer)
            _aantal = value
        End Set
    End Property
    Public Property brood() As brood
        Get
            Return _brood
        End Get
        Set(ByVal value As brood)
            _brood = value
        End Set
    End Property
    Public Property datum() As Date
        Get
            Return _datum
        End Get
        Set(ByVal value As Date)
            _datum = value
        End Set
    End Property
    Public Property idAutomaat() As Integer
        Get
            Return _idautomaat
        End Get
        Set(ByVal value As Integer)
            _idautomaat = value
        End Set
    End Property
    Public Property locatie() As Integer
        Get
            Return _locatie
        End Get
        Set(ByVal value As Integer)
            _locatie = value
        End Set
    End Property
    Public Property prijs() As String
        Get
            Return _prijs
        End Get
        Set(ByVal value As String)
            _prijs = value
        End Set
    End Property
    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO automaat(aantal,brood,datum,idAutomaat,locatie,prijs) VALUES(@aantal,@brood,@datum,@idAutomaat,@locatie,@prijs)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@aantal", aantal())
                    cmd.Parameters.AddWithValue("@brood", brood.idBrood)
                    cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idAutomaat", idAutomaat())
                    cmd.Parameters.AddWithValue("@locatie", locatie())
                    cmd.Parameters.AddWithValue("@prijs", prijs())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            conn.Close()
        End Using
    End Sub
    Public Sub Update()
        Using Conn = New MySqlConnection(connStr)
            Dim query As String = "Update automaat SET aantal=@aantal,brood=@brood,datum=@datum,locatie=@locatie,prijs=@prijs WHERE idAutomaat = @idAutomaat"
            Conn.Open()
            Try
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@aantal", aantal())
                    cmd.Parameters.AddWithValue("@brood", brood.idBrood)
                    cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idAutomaat", idAutomaat())
                    cmd.Parameters.AddWithValue("@locatie", locatie())
                    cmd.Parameters.AddWithValue("@prijs", prijs())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Conn.Close()
        End Using
    End Sub
    Public Shared Function GetOne(ByVal ID As Integer) As automaat
        Dim myObj As New automaat()
        Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3307;database=project3;")
            Dim query As String = "SELECT * FROM automaat WHERE idAutomaat = @idAutomaat"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idAutomaat", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.aantal = Convert.ToInt32(reader("aantal"))
                            myObj.brood.idBrood = Convert.ToInt32(reader("brood"))
                            myObj.datum = reader("datum").ToString()
                            myObj.idAutomaat = Convert.ToInt32(reader("idAutomaat"))
                            myObj.locatie = Convert.ToInt32(reader("locatie"))
                            myObj.prijs = reader("prijs").ToString()
                        End If
                    End Using
                End Using
                Return myObj
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Function
    Public Shared Function GetAll() As DataTable
        Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3307;database=project3;")
            conn.Open()
            Dim datatable As New DataTable()
            Dim query As String = "SELECT * FROM automaat"
            Try
                Using cmd = New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        datatable.Load(reader)
                    End Using
                    Return datatable
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Function
End Class
