Imports MySql.Data.MySqlClient

Public Class formLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
        txPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call login()

    End Sub

    Sub login()
        If txUser.Text = "" And txPassword.Text = "" Then
            MsgBox("Isi field terlebih dahulu")
        Else
            Call bukaDB()
            Dim Sql As String
            Sql = "SELECT * FROM tbadmin WHERE username = '" & txUser.Text & "' AND password = '" & txPassword.Text & "'"
            CMD = New MySqlCommand(Sql, conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                If RD("level").ToString = "Kasir" Then
                    formMain.Nama.Text = RD("nama").ToString

                    formMain.Level.Text = RD("level").ToString

                    MyBase.Hide()

                    formMain.Show()
                    MsgBox("SELAMAT DATANG " + RD("nama").ToString)
                Else
                    formManajer.Show()
                End If
            Else
                MsgBox("akun tidak ditemukan")
            End If

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
End Class
