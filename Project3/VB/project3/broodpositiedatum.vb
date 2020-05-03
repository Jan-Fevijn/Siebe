Imports MySql.Data.MySqlClient
Public Class broodpositiedatum
Private connStr As String = "server= localhost;user= root;password= usbw;port= 3307;database=project3;"
Private conn As New MySqlConnection(connStr)
Private _aantalIn as Integer
Private _Datum as Date
Private _idbrood as broodtype
Private _idbroodpositieDatum as Integer
Private _kostprijs as String
Private _positie as Integer
    Public Sub New()
    End Sub

    Public Sub New(aantalIn As Integer, Datum As Date, idbrood As broodtype, idbroodpositieDatum As Integer, kostprijs As String, positie As Integer)
        Me.aantalIn = aantalIn
        Me.Datum = Datum
        Me.idbrood = idbrood
        Me.idbroodpositieDatum = idbroodpositieDatum
        Me.kostprijs = kostprijs
        Me.positie = positie
    End Sub

    Public Property aantalIn() As Integer
        Get
            Return _aantalIn
        End Get
        Set(ByVal value As Integer)
            _aantalIn = value
        End Set
    End Property

    Public Property Datum() As Date
        Get
            Return _Datum
        End Get
        Set(ByVal value As Date)
            _Datum = value
        End Set
    End Property

    Public Property idbrood() As broodtype
        Get
            Return _idbrood
        End Get
        Set(ByVal value As broodtype)
            _idbrood = value
        End Set
    End Property

    Public Property idbroodpositieDatum() As Integer
        Get
            Return _idbroodpositieDatum
        End Get
        Set(ByVal value As Integer)
            _idbroodpositieDatum = value
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

    Public Property positie() As Integer
        Get
            Return _positie
        End Get
        Set(ByVal value As Integer)
            _positie = value
        End Set
    End Property

    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO broodpositiedatum(aantalIn,Datum,idbrood,idbroodpositieDatum,kostprijs,positie) VALUES(@aantalIn,@Datum,@idbrood,@idbroodpositieDatum,@kostprijs,@positie)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@aantalIn", aantalIn())
                    cmd.Parameters.AddWithValue("@Datum", Datum())
                    cmd.Parameters.AddWithValue("@idbrood", idbrood.idbroodtype)
                    cmd.Parameters.AddWithValue("@idbroodpositieDatum", idbroodpositieDatum())
                    cmd.Parameters.AddWithValue("@kostprijs", kostprijs())
                    cmd.Parameters.AddWithValue("@positie", positie())
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
            Dim query As String = "Update broodpositiedatum SET aantalIn=@aantalIn,Datum=@Datum,idbrood=@idbrood,kostprijs=@kostprijs,positie=@positie WHERE idbroodpositieDatum = @idbroodpositieDatum"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@aantalIn", aantalIn())
                    cmd.Parameters.AddWithValue("@Datum", Datum())
                    cmd.Parameters.AddWithValue("@idbrood", idbrood.idbroodtype)
                    cmd.Parameters.AddWithValue("@idbroodpositieDatum", idbroodpositieDatum())
                    cmd.Parameters.AddWithValue("@kostprijs", kostprijs())
                    cmd.Parameters.AddWithValue("@positie", positie())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Shared Function GetOne(ByVal ID As Integer) As broodpositiedatum
        Dim myObj As New broodpositiedatum()
        Using conn = New MySqlConnection("server= localhost;user= root;password= usbw;port= 3307;database=project3;")
            Dim query As String = "SELECT * FROM broodpositiedatum WHERE idbroodpositieDatum = @idbroodpositieDatum"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idbroodpositieDatum", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.aantalIn = Convert.ToInt32(reader("aantalIn"))
                            myObj.Datum = reader("Datum").ToString()
                            myObj.idbrood.idbroodtype = Convert.ToInt32(reader("idbrood"))
                            myObj.idbroodpositieDatum = Convert.ToInt32(reader("idbroodpositieDatum"))
                            myObj.kostprijs = reader("kostprijs").ToString()
                            myObj.positie = Convert.ToInt32(reader("positie"))
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
            Dim query As String = "SELECT * FROM broodpositiedatum"
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
