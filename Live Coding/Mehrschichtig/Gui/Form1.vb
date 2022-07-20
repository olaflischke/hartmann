Option Strict On ' Keine automatischen Konvertierungen (global in Extras/Optionen/VB-Standard einstellbar)

Imports Bl


Public Class Form1

    Dim daten As New BindingSource

    Private Sub NeuesHuhn(sender As Object, e As EventArgs) Handles btnNeu.Click
        Dim tier As New Huhn

        ' Combobox ungebunden (unbound)
        cbxTiere.Items.Add(tier)
        cbxTiere.SelectedItem = tier
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTiere.DisplayMember = "Name"

        ListBox1.DataSource = daten
        'ListBox1.DisplayMember = "Gewicht"
    End Sub

    Private Sub cbxTiere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTiere.SelectedIndexChanged
        pgdTiere.SelectedObject = cbxTiere.SelectedItem

        daten.DataSource = CType(cbxTiere.SelectedItem, Huhn).Eier
        ' ListBox gebunden (bound)
        ' ListBox1.DataSource = CType(cbxTiere.SelectedItem, Huhn).Eier
        daten.ResetBindings(True)
    End Sub

    Private Sub btnFuettern_Click(sender As Object, e As EventArgs) Handles btnFuettern.Click
        Dim tier As Huhn = CType(cbxTiere.SelectedItem, Huhn)
        If tier IsNot Nothing Then
            tier.Fressen()
        End If

        pgdTiere.SelectedObject = tier
    End Sub

    Private Sub btnEiLegen_Click(sender As Object, e As EventArgs) Handles btnEiLegen.Click
        Dim tier As Huhn = CType(cbxTiere.SelectedItem, Huhn)
        If tier IsNot Nothing Then
            tier.Eilegen()

            'ListBox1.DataSource = tier.Eier
            daten.ResetBindings(True)
        End If

        pgdTiere.SelectedObject = tier


    End Sub
End Class
