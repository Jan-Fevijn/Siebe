Imports MySql.Data.MySqlClient
Public Class saldo
Private connStr As String = "server= localhost;user= root;password= usbw;port= 3307;database=project3;"
Private conn As New MySqlConnection(connStr)
Private _broodpositiedatum as broodpositiedatum
Private _datum as Date
Private _idklant as klant
Private _idsaldo as Integer
    Private _saldo As String

    Public Sub New()
    End Sub

    Public Sub New(broodpositiedatum As broodpositiedatum, datum As Date, idklant As klant, idsaldo As Integer, saldo As String)
        Me.broodpositiedatum = broodpositiedatum
        Me.datum = datum
        Me.idklant = idklant
        Me.idsaldo = idsaldo
        Me.saldo = saldo
    End Sub

    Public Property broodpositiedatum() As broodpositiedatum
        Get
            Return _broodpositiedatum
        End Get
        Set(ByVal value As broodpositiedatum)
            _broodpositiedatum = value
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

    Public Property idklant() As klant
        Get
            Return _idklant
        End Get
        Set(ByVal value As klant)
            _idklant = value
        End Set
    End Property

    Public Property idsaldo() As Integer
        Get
            Return _idsaldo
        End Get
        Set(ByVal value As Integer)
            _idsaldo = value
        End Set
    End Property

    Public Property saldo() As String
        Get
            Return _saldo
        End Get
        Set(ByVal value As String)
            _saldo = value
        End Set
    End Property

    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO saldo(broodpositiedatum,datum,idklant,idsaldo,saldo) VALUES(@broodpositiedatum,@datum,@idklant,@idsaldo,@saldo)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@broodpositiedatum", broodpositiedatum.idbroodpositieDatum)
                    cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idklant", idklant.idklant)
                    cmd.Parameters.AddWithValue("@idsaldo", idsaldo())
                    cmd.Parameters.AddWithValue("@saldo", saldo())
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
            Dim query As String = "Update saldo SET broodpositiedatum=@broodpositiedatum,datum=@datum,idklant=@idklant,saldo=@saldo WHERE idsaldo = @idsaldo"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@broodpositiedatum", broodpositiedatum.idbroodpositieDatum)
                    cmd.Parameters.AddWithValue("@datum", datum())
                    cmd.Parameters.AddWithValue("@idklant", idklant.idklant)
                    cmd.Parameters.AddWithValue("@idsaldo", idsaldo())
                    cmd.Parameters.AddWithValue("@saldo", saldo())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Shared Function GetOne(ByVal ID As Integer) As saldo
        Dim myObj As New saldo()
        Using conn = New MySqlConnection("server= localhost;user= root;password= usbw;port= 3307;database=project3;")
            Dim query As String = "SELECT * FROM saldo WHERE idsaldo = @idsaldo"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idsaldo", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.broodpositiedatum.idbroodpositieDatum = Convert.ToInt32(reader("broodpositiedatum"))
                            myObj.datum = reader("datum").ToString()
                            myObj.idklant.idklant = Convert.ToInt32(reader("idklant"))
                            myObj.idsaldo = Convert.ToInt32(reader("idsaldo"))
                            myObj.saldo = reader("saldo").ToString()
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
            Dim query As String = "SELECT * FROM saldo"
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
