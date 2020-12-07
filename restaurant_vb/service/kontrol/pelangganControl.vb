Imports MySql.Data.MySqlClient

Module pelangganControl
    Public Sub tampilPelanggan(tabel As DataGridView)
        Try
            bukaDB()
            Dim sql As String
            sql = "SELECT * FROM tbpelanggan"
            DA = New MySqlDataAdapter(sql, conn)
            DS = New DataSet
            DA.Fill(DS, "tbpelanggan")
            tabel.DataSource = DS.Tables("tbpelanggan")
            tabel.ReadOnly = True
        Catch ex As Exception
            MsgBox("gagal karena " + ex.ToString)
        End Try

    End Sub

    Public Sub simpanPelanggan(kode As String, nama As String)
        Try
            bukaDB()
            Dim SQL As String
            SQL = "INSERT INTO tbpelanggan VALUES('" & kode & "', '" & nama & "')"
            CMD = New MySqlCommand(SQL, conn)
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("gagal karena " + ex.ToString)
        End Try
    End Sub

    Public Sub editPelanggan(kode As String, nama As String)
        Try
            bukaDB()
            Dim SQL As String
            SQL = "UPDATE tbpelanggan SET namapelanggan = '" & nama & "' WHERE kodepelanggan = '" & kode & "'"
            CMD = New MySqlCommand(SQL, conn)
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("gagal karena " + ex.ToString)
        End Try
    End Sub

    Public Sub hapusPelanggan(kode As String)
        Try
            bukaDB()
            Dim SQL As String
            SQL = "DELETE FROM tbpelanggan WHERE kodepelanggan = '" & kode & "' "
            CMD = New MySqlCommand(SQL, conn)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("gagal karena" + ex.ToString)
        End Try
    End Sub

    Public Sub cariPelanggan(text As String, tabel As DataGridView)
        Try
            bukaDB()
            Dim SQL As String
            SQL = "SELECT * FROM tbpelanggan WHERE kodepelanggan LIKE '%" & text & "%' OR namapelanggan LIKE '%" & text & "%'"
            DA = New MySqlDataAdapter(SQL, conn)
            DS = New DataSet
            DA.Fill(DS, "tbpelanggan")
            tabel.DataSource = DS.Tables("tbpelanggan")
            tabel.ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub
End Module
