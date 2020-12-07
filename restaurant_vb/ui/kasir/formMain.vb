Public Class formMain
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        formMasakan.StartPosition = FormStartPosition.CenterScreen
        formMasakan.Show()

    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        pelangganForm.Show()

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        formTransaksi.StartPosition = FormStartPosition.CenterScreen
        formTransaksi.Show()

    End Sub
End Class