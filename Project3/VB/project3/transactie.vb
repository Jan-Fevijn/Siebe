Imports MySql.Data.MySqlClient
Public Class transactie
    Private connStr As String = "server=localhost;user=root;password=usbw;port=3306;database=project3;"
    Private conn As New MySqlConnection(connStr)
        Private _datum As Date
        Private _idAutomaat As automaat
        Private _idKlant As klant
        Private _idTransactie As Integer
        Public Sub New()
        End Sub
        Public Sub New(datum As Date, idAutomaat As automaat, idKlant As klant, idTransactie As Integer)
            Me.datum = datum
            Me.idAutomaat = idAutomaat
            Me.idKlant = idKlant
            Me.idTransactie = idTransactie
        End Sub
        Public Property datum() As Date
            Get
                Return _datum
            End Get
            Set(ByVal value As Date)
                _datum = value
            End Set
        End Property
        Public Property idAutomaat() As automaat
            Get
                Return _idAutomaat
            End Get
            Set(ByVal value As automaat)
                _idAutomaat = value
            End Set
        End Property
        Public Property idKlant() As klant
            Get
                Return _idKlant
            End Get
            Set(ByVal value As klant)
                _idKlant = value
            End Set
        End Property
        Public Property idTransactie() As Integer
            Get
                Return _idTransactie
            End Get
            Set(ByVal value As Integer)
                _idTransactie = value
            End Set
        End Property
        Public Sub Add()
            Using conn = New MySqlConnection(connStr)
                Dim query = "INSERT INTO transactie(datum,idAutomaat,idKlant,idTransactie) VALUES(@datum,@idAutomaat,@idKlant,@idTransactie)"
                conn.Open()
                Try
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idAutomaat", idAutomaat.idAutomaat)
                    cmd.Parameters.AddWithValue("@idKlant", idKlant.idKlant)
                    cmd.Parameters.AddWithValue("@idTransactie", idTransactie())
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
                Dim query As String = "Update transactie SET datum=@datum,idAutomaat=@idAutomaat,idKlant=@idKlant WHERE idTransactie = @idTransactie"
                Conn.Open()
                Try
                    Using cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idAutomaat", idAutomaat.idAutomaat)
                    cmd.Parameters.AddWithValue("@idKlant", idKlant.idKlant)
                    cmd.Parameters.AddWithValue("@idTransactie", idTransactie())
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                Conn.Close()
            End Using
        End Sub
        Public Shared Function GetOne(ByVal ID As Integer) As transactie
            Dim myObj As New transactie()
            Using conn = New MySqlConnection("server=localhost;user=root;password=usbw;port=3307;database=project3;")
                Dim query As String = "SELECT * FROM transactie WHERE idTransactie = @idTransactie"
                conn.Open()
                Try
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@idTransactie", ID)
                        Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                            If reader.Read() Then
                                myObj.datum = reader("datum").ToString()
                            myObj.idAutomaat.idAutomaat = Convert.ToInt32(reader("idAutomaat"))
                            myObj.idKlant.idKlant = Convert.ToInt32(reader("idKlant"))
                            myObj.idTransactie = Convert.ToInt32(reader("idTransactie"))
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
                Dim query As String = "SELECT * FROM transactie"
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
