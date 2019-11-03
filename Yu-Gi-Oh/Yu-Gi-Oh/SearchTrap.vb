Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SearchTrap
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        YuGiOh.Show()
        Me.Close()
    End Sub
    Private Sub SearchMonster_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNumberOwned.Hide()
        txtNumberOwned.Hide()
        lblCardNo.Hide()
        txtCardNo.Hide()
        lblSubType.Hide()
        txtSubType.Hide()
        lblDescription.Hide()
        txtDescription.Hide()
    End Sub
    Private Sub txtCardName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCardName.KeyDown
        Dim CardName As String
        If e.KeyCode = Keys.KeyCode.Enter Then
            CardName = txtCardName.Text
            txtCardName.Enabled = False
            Getdata(CardName)
        End If
    End Sub
    Private Sub Getdata(ByVal CardName As String)
        Dim Con As New SqlConnection(Constring)
        Dim Cmd As String = "SELECT #Owned, Card#, Sub_Type, Description FROM Trap WHERE CardName = '" & CardName & "'"
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
                If IsDBNull(reader.GetValue(0)) Then
                    txtNumberOwned.Text = "0"
                Else
                    txtNumberOwned.Text = reader.GetValue(0).ToString
                End If
                txtCardNo.Text = reader.GetValue(1).ToString
                txtSubType.Text = reader.GetValue(2).ToString
                txtDescription.Text = reader.GetValue(3).ToString
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
        txtNumberOwned.Show()
        txtDescription.Show()
        txtCardNo.Show()
        txtSubType.Show()
        lblNumberOwned.Show()
        lblDescription.Show()
        lblCardNo.Show()
        lblSubType.Show()
    End Sub
End Class