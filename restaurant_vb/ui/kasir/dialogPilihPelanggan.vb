Public Class dialogPilihPelanggan
    Private Sub dialogPilihPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pelangganControl.tampilPelanggan(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formTransaksi.txPelanggan.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Dispose()

    End Sub
End Class