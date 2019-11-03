Public Class ViewDeck
    Private Sub btnJasonsDeck_Click(sender As Object, e As EventArgs) Handles btnJasonsDeck.Click
        DeckSelected = "J"
        DeckView.Show()
        Me.Close()
    End Sub
    Private Sub btnCharlysDeck_Click(sender As Object, e As EventArgs) Handles btnCharlysDeck.Click
        DeckSelected = "C"
        DeckView.Show()
        Me.Close()
    End Sub
    Private Sub btnMatthewsDeck_Click(sender As Object, e As EventArgs) Handles btnMatthewsDeck.Click
        DeckSelected = "M"
        DeckView.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        YuGiOh.Show()
        Me.Close()
    End Sub
End Class