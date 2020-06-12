Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmToevoegenBrood
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim Brood As New brood()
        'Brood.broodCode = nmrCode.Value
        ' Brood.typeBrood = txtbrood.Text
        'Brood.aantal = 0
        'Brood.prijs = nmrPrijs.Value
        Brood.Add()
        MessageBox.Show("Het brood is toegevoegd")
        Me.Close()

    End Sub
End Class
