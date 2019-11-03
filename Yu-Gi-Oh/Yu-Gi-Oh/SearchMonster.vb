Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SearchMonster
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        YuGiOh.Show()
        Me.Close()
    End Sub
    Private Sub SearchMonster_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNumberOwned.Hide()
        txtNumberOwned.Hide()
        lblCardNumber.Hide()
        txtCardNumber.Hide()
        lblAttribute.Hide()
        txtAttribute.Hide()
        lblDescription.Hide()
        txtDescription.Hide()
        lblATK.Hide()
        txtATK.Hide()
        lblDEF.Hide()
        txtDEF.Hide()
        lblLevel.Hide()
        txtLevel.Hide()
        txtATK.Enabled = False
        txtAttribute.Enabled = False
        txtCardNumber.Enabled = False
        txtDEF.Enabled = False
        txtDescription.ReadOnly = True
        txtLevel.Enabled = False
        txtNumberOwned.Enabled = False
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
        Dim Cmd As String = "SELECT #Owned, Card#, Attribute, Description, ATK, DEF, Level FROM Monster WHERE CardName = '" & CardName & "'"
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
                txtCardNumber.Text = reader.GetValue(1).ToString
                txtAttribute.Text = reader.GetValue(2).ToString
                txtDescription.Text = reader.GetValue(3).ToString
                txtATK.Text = reader.GetValue(4).ToString
                txtDEF.Text = reader.GetValue(5).ToString
                txtLevel.Text = reader.GetValue(6).ToString
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Close()
        End Try
        txtNumberOwned.Show()
        txtLevel.Show()
        txtDescription.Show()
        txtDEF.Show()
        txtCardNumber.Show()
        txtAttribute.Show()
        txtATK.Show()
        lblNumberOwned.Show()
        lblLevel.Show()
        lblDescription.Show()
        lblDEF.Show()
        lblCardNumber.Show()
        lblAttribute.Show()
        lblATK.Show()
    End Sub
End Class