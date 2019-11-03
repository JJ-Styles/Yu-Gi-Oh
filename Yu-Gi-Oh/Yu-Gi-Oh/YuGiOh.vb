Public Class YuGiOh
    Private Sub SearchMonster_Click(sender As Object, e As EventArgs) Handles BtnSearchMonster.Click
        SearchMonster.Show()
        Me.Close()
    End Sub
    Private Sub btnSearchTrap_Click(sender As Object, e As EventArgs) Handles btnSearchTrap.Click
        SearchTrap.Show()
        Me.Close()
    End Sub
    Private Sub btnSearchSpell_Click(sender As Object, e As EventArgs) Handles btnSearchSpell.Click
        SearchSpell.Show()
        Me.Close()
    End Sub
    Private Sub btnEditNumbers_Click(sender As Object, e As EventArgs) Handles btnEditNumbers.Click
        EditNumbers.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Show()
    End Sub

    Private Sub btnViewDeck_Click(sender As Object, e As EventArgs) Handles btnViewDeck.Click
        ViewDeck.Show()
        Me.Close()
    End Sub
End Class
