Imports MySql.Data.MySqlClient

Module MasakanControl
    Public Sub tampilMasakan(tabel As DataGridView)
        Try
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tbmasakan", conn)
            DS = New DataSet
            DA.Fill(DS, "tbmasakan")
            tabel.DataSource = DS.Tables("tbmasakan")
            tabel.ReadOnly = True


        Catch ex As Exception

        End Try
    End Sub

    Public Sub simpanMasakan(kode As String, nama As String, jenis As String, harga As Integer)

        Try
            Call bukaDB()

            simpan = "INSERT INTO tbmasakan VALUES('" & kode & "', '" & nama & "', '" & jenis & "', '" & harga & "')"
            CMD = New MySqlCommand(simpan, conn)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub editMasakan(kode As String, nama As String, jenis As String, harga As Integer)
        Try
            Call bukaDB()
            ubah = "UPDATE tbmasakan SET namamasakan = '" & nama & "', jenismasakan = '" & jenis & "', harga = '" & harga & "' WHERE kodemasakan = '" & kode & "'"
            CMD = New MySqlCommand(ubah, conn)
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub hapusDate(kode As String)
        Try
            Call bukaDB()
            hapus = "DELETE FROM tbmasakan WHERE kodemasakan = '" & kode & "'"
            CMD = New MySqlCommand(hapus, conn)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub cariMasakan(tabel As DataGridView, text As String)
        Try
            bukaDB()
            cari = "SELECT * FROM tbmasakan WHERE kodemasakan LIKE '%" & text & "%' OR namamasakan LIKE '%" & text & "%' OR jenismasakan LIKE '%" & text & "%' OR harga LIKE '%" & text & "%'"
            DA = New MySqlDataAdapter(cari, conn)
            DS = New DataSet
            DA.Fill(DS, "tbmasakan")
            tabel.DataSource = DS.Tables("tbmasakan")

        Catch ex As Exception

        End Try
    End Sub

End Module
