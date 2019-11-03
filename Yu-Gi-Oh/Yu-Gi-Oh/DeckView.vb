Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DeckView
    Private Sub DeckView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cmd As String
        If DeckSelected = "J" Then
            lbxDeck.Items.Add("Main Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Jason WHERE Type = 'Main Deck'"
            Getdata(Cmd)
            lbxDeck.Items.Add("Extra Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Jason WHERE Type = 'Extra Deck'"
            Getdata(Cmd)
            Sizings()
        ElseIf DeckSelected = "C" Then
            lbxDeck.Items.Add("Main Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Charly WHERE Type = 'Main Deck'"
            Getdata(Cmd)
            lbxDeck.Items.Add("Extra Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Charly WHERE Type = 'Extra Deck'"
            Getdata(Cmd)
            Sizings()
        ElseIf DeckSelected = "M" Then
            lbxDeck.Items.Add("Main Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Matthew WHERE Type = 'Main Deck'"
            Getdata(Cmd)
            lbxDeck.Items.Add("Extra Deck:")
            Cmd = "SELECT CardName, NumberInDeck FROM Matthew WHERE Type = 'Extra Deck'"
            Getdata(Cmd)
            Sizings()
        End If
    End Sub
    Private Sub Getdata(ByVal Cmd As String)
        Dim Con As New SqlConnection(Constring)
        Dim Command As New SqlCommand
        Dim reader As SqlDataReader
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Command = Con.CreateCommand
            Command.CommandText = Cmd
            reader = Command.ExecuteReader
            Do While reader.Read
                lbxDeck.Items.Add(reader.GetValue(0) & " x" & reader.GetValue(1))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Sub Sizings()
        lbxDeck.Height = lbxDeck.ItemHeight * (lbxDeck.Items.Count + 3)
        Me.Height = lbxDeck.Height
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        YuGiOh.Show()
        Me.Close()
    End Sub
End Class