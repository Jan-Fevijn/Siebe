Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class frmToevoegenBrood
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim Brood As New broodtype()
        'Brood.broodCode = nmrCode.Value
        Brood.broodnaam = txtbrood.Text
        Brood.aantalIn = 0
        Brood.kostprijs = nmrPrijs.Value
        Brood.Add()
        MessageBox.Show("Het brood is toegevoegd")

    End Sub

    Private Sub SaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoToolStripMenuItem.Click
        Me.Show()
        balans.Show()
    End Sub

    $
End Class
