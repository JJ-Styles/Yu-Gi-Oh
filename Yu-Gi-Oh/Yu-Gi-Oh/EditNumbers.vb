Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditNumbers
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        YuGiOh.Show()
        Me.Close()
    End Sub
    Private Sub txtCardName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCardName.KeyDown
        Dim CardName, CardType As String
        Dim NumberOwned As Integer
        If e.KeyCode = Keys.KeyCode.Enter Then
            CardName = txtCardName.Text
            NumberOwned = CInt(txtNumberOwned.Text)
            CardType = txtCardType.Text
            UpdateData(CardName, NumberOwned, CardType)
            txtCardName.Text = ""
            txtCardType.Text = ""
            txtNumberOwned.Text = ""
        End If
    End Sub
    Private Sub txtCardType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCardType.KeyDown
        Dim CardName, CardType As String
        Dim NumberOwned As Integer
        If e.KeyCode = Keys.KeyCode.Enter Then
            CardName = txtCardName.Text
            NumberOwned = CInt(txtNumberOwned.Text)
            CardType = txtCardType.Text
            UpdateData(CardName, NumberOwned, CardType)
            txtCardName.Text = ""
            txtCardType.Text = ""
            txtNumberOwned.Text = ""
        End If
    End Sub
    Private Sub txtNumberOwned_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumberOwned.KeyDown
        Dim CardName, CardType As String
        Dim NumberOwned As Integer
        If e.KeyCode = Keys.KeyCode.Enter Then
            CardName = txtCardName.Text
            NumberOwned = CInt(txtNumberOwned.Text)
            CardType = txtCardType.Text
            UpdateData(CardName, NumberOwned, CardType)
            txtCardName.Text = ""
            txtCardType.Text = ""
            txtNumberOwned.Text = ""
        End If
    End Sub
    Private Sub UpdateData(ByVal CardName As String, ByVal NumberOwned As Integer, ByVal CardType As String)
        Dim Con As New SqlConnection(Constring)
        Dim Cmd As String = " UPDATE " & CardType & " SET #Owned = " & NumberOwned & " WHERE CardName = '" & CardName & "'"
        Dim Command As New SqlCommand
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Command = Con.CreateCommand
            Command.CommandText = Cmd
            Command.ExecuteNonQuery()
            MsgBox("Data Added to Table.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
End Class