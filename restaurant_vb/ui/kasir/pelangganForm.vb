Public Class pelangganForm
    Dim kode, nama As String
    Dim isEdit As Boolean = False
    Dim isNew As Boolean = False



    Private Sub pelangganForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pelangganControl.tampilPelanggan(DataGridView1)

        Call enable(False)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isNew = True
        txKode.Enabled = True
        txNama.Enabled = True
        txKode.Focus()

        btnNew.Enabled = False
        btnSimpan.Enabled = True

        btnCancel.Enabled = True

    End Sub

    Sub enable(value As Boolean)
        txKode.Enabled = value
        txNama.Enabled = value
        btnSimpan.Enabled = value
        btnHapus.Enabled = value
        btnEdit.Enabled = value
        btnCancel.Enabled = value
        btnNew.Enabled = Not value
    End Sub

    Sub clear()
        txKode.Text = ""
        txNama.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call enable(False)
        btnNew.Enabled = True
        isNew = False
        Call clear()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Not isNew Then
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            btnCancel.Enabled = True
            btnNew.Enabled = False
            txKode.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            txNama.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txKode.Text = "" Then
            MsgBox("pilih pelanggan yang akan dihapus")
        Else
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus " + txNama.Text, "Hapus ?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                pelangganControl.hapusPelanggan(txKode.Text)
                pelangganControl.tampilPelanggan(DataGridView1)
                MsgBox("Data berhasil dihapus")
                enable(False)
                clear()



            End If


        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isEdit = True

        txKode.Enabled = False
        txNama.Enabled = True
        txNama.Focus()
        btnSimpan.Enabled = True
        btnHapus.Enabled = False
        btnCancel.Enabled = True
        btnEdit.Enabled = False
    End Sub

    Private Sub txCari_TextChanged(sender As Object, e As EventArgs) Handles txCari.TextChanged
        pelangganControl.cariPelanggan(txCari.Text, DataGridView1)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If isEdit Then
            kode = txKode.Text
            nama = txNama.Text
            pelangganControl.editPelanggan(kode, nama)
            MsgBox("Data berhasil diedit")
            Call pelangganControl.tampilPelanggan(DataGridView1)
            clear()
            enable(False)
            isEdit = False
        Else
            kode = txKode.Text
            nama = txNama.Text
            pelangganControl.simpanPelanggan(kode, nama)
            Call pelangganControl.tampilPelanggan(DataGridView1)
            MsgBox("Data berhasil disimpan")
            clear()
            enable(False)
        End If
        isNew = False
    End Sub
End Class