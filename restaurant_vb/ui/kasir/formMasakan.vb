Imports MySql.Data.MySqlClient

Public Class formMasakan

    Dim kodeMasakan, namaMasakan, jenisMasakan As String
    Dim harga As Integer
    Dim isEdit As Boolean = False
    Dim isNew As Boolean = False

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txKodeMasakan.Text = "" Or txNamaMasakan.Text = "" Or cbJenisMasakan.Text = "" Or txHarga.Text = "") Then
            MsgBox("Field belum disi")
        Else

            kodeMasakan = txKode.Text
            namaMasakan = txNamaMasakan.Text
            harga = Integer.Parse(txHarga.Text)

            If isEdit Then
                Call MasakanControl.editMasakan(kodeMasakan, namaMasakan, jenisMasakan, harga)
                Call MasakanControl.tampilMasakan(tbMasakan)
                MsgBox("DATA BERHASIL DI EDIT")
                Call Clear()
                Call enableField(False)
                isEdit = False
                isNew = False

            Else
                Call MasakanControl.simpanMasakan(kodeMasakan, namaMasakan, jenisMasakan, harga)
                Call MasakanControl.tampilMasakan(tbMasakan)
                MsgBox("Data Berhasil disimpan")
                Call Clear()
                Call enableField(False)
            End If


        End If
    End Sub

    Private Sub cbJenisMasakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenisMasakan.SelectedIndexChanged
        jenisMasakan = cbJenisMasakan.Text
    End Sub

    Private Sub txHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txHarga.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MasakanControl.tampilMasakan(tbMasakan)
        Call controlJenisMasakan.tampilJenisMasakan(cbJenisMasakan)
        Call enableField(False)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Clear()
        isNew = True
        txKode.Focus()
        txKode.Enabled = True
        txNamaMasakan.Enabled = True
        cbJenisMasakan.Enabled = True
        txHarga.Enabled = True
        btnSimpan.Enabled = True
        btnCancel.Enabled = True
        btnNew.Enabled = False

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Clear()
        Call enableField(False)
        isEdit = False
        isNew = False
    End Sub


    Sub enableField(isEnable As Boolean)

        txKode.Enabled = isEnable
        txNamaMasakan.Enabled = isEnable
        cbJenisMasakan.Enabled = isEnable
        txHarga.Enabled = isEnable
        btnNew.Enabled = Not isEnable
        btnSimpan.Enabled = isEnable
        btnEdit.Enabled = isEnable
        btnHapus.Enabled = isEnable
        btnCancel.Enabled = isEnable
    End Sub

    Private Sub tbMasakan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbMasakan.CellClick
        If Not isNew Then
            Call setDataFromTabel()
            btnNew.Enabled = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            btnCancel.Enabled = True
            If isEdit Then
                btnEdit.Enabled = False
                btnHapus.Enabled = False

            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin untuk menghapus " + txNamaMasakan.Text, "Hapus", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            kodeMasakan = txKode.Text
            MasakanControl.hapusDate(kodeMasakan)
            Call MasakanControl.tampilMasakan(tbMasakan)
            MsgBox("DATA BERHASIL DIHAPUS")
            Call Clear()
            Call enableField(False)

        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isEdit = True
        txKode.Enabled = False
        txNamaMasakan.Enabled = True
        cbJenisMasakan.Enabled = True
        txHarga.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = True
        txNamaMasakan.Focus()
    End Sub

    Private Sub txSearch_TextChanged(sender As Object, e As EventArgs) Handles txSearch.TextChanged
        Call MasakanControl.cariMasakan(tbMasakan, txSearch.Text)
    End Sub

    Private Sub txHarga_TextChanged(sender As Object, e As EventArgs) Handles txHarga.TextChanged

    End Sub

    Sub Clear()
        txKode.Text = ""
        txNamaMasakan.Text = ""
        txHarga.Text = ""
        cbJenisMasakan.Text = ""
        jenisMasakan = ""
        txSearch.Text = ""
    End Sub

    Sub setDataFromTabel()
        txKode.Text = tbMasakan.CurrentRow.Cells(0).Value.ToString
        txNamaMasakan.Text = tbMasakan.CurrentRow.Cells(1).Value.ToString
        cbJenisMasakan.Text = tbMasakan.CurrentRow.Cells(2).Value.ToString
        txHarga.Text = tbMasakan.CurrentRow.Cells(3).Value.ToString

    End Sub

End Class