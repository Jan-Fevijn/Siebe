Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class saldo
    Public conn As MySqlConnection
    Public connstring As String = "server=localhost;Port=3307;database=project3;uid=root;password=usbw; "
    Private Sub ToevoegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        HerlaadBalans()
    End Sub

    Private Sub HerlaadBalans()
        Dim klantcode As String
        Dim klant As klant
        klantcode = txtcode.Text
        If klantcode <> "" Then
            klant = klant.GetOne(klantcode)
            If klant.idKlant > 0 Then
                Dim valueSaldo As String = txtSaldo.Text
                Dim newSaldo = CheckInput(valueSaldo)
                If newSaldo = 0 Then
                    MessageBox.Show("Geef bedrag in.")
                End If
                ' klant.saldo += newSaldo
                klant.Update()
            Else
                MessageBox.Show("Geen geregistreerde klant!")
            End If

        End If
    End Sub

    Private Function CheckInput(ByVal value As String) As Decimal
        If String.IsNullOrWhiteSpace(value) Then Return Nothing
        If IsNumeric(value) Then
            If value.Contains(".") Then
                value = value.Replace(".", ",")
            End If
            Return CDec(value)
        End If
    End Function
End Class