Public Class dialogPilihMasakan
    Private Sub dialogPilihMasakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasakanControl.tampilMasakan(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formTransaksi.txNama.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        formTransaksi.txHarga.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        formTransaksi.txQty.Enabled = True
        formTransaksi.Focus()

        Dispose()

    End Sub
End Class