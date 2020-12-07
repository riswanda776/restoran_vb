Imports MySql.Data.MySqlClient

Module controlTransaksi
    Public Sub simpanTransaksi(noTransaksi As String, pelanggan As String, meja As String, total As Integer, harga As Integer, tgl As String)
        Try
            bukaDB()

            Dim sql As String
            sql = "INSERT INTO tbpenjualan VALUES ('" & noTransaksi & "', '" & pelanggan & "', '" & meja & "', '" & total & "', '" & harga & "', '" & tgl & "')"
            CMD = New MySqlCommand(sql, conn)
            CMD.ExecuteNonQuery()
            MsgBox("transaksi berhasil")

        Catch ex As Exception
            MsgBox("gagal karena " + ex.ToString)
        End Try

    End Sub

    Public Sub tampilMeja(Combo1 As ComboBox)
        Try
            bukaDB()

            Dim sql As String
            sql = "SELECT * FROM meja"
            CMD = New MySqlCommand(sql, conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    Combo1.Items.Add(RD("no_meja"))
                Loop
            End If
        Catch ex As Exception
            MsgBox("gagal karena" + ex.ToString)
        End Try
    End Sub
End Module
