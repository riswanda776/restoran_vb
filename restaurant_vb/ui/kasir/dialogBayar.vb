Public Class dialogBayar
    Dim eventDate As String
    Private Sub dialogBayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txTotalBayar.Text = formTransaksi.total.Text
        txTotalBayar.Enabled = False
        txKembali.Enabled = False
        eventDate = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim noTx As String
        Dim pelanggan As String
        Dim meja As String
        Dim totalPesanan As Integer
        Dim totalHarga As String


        noTx = formTransaksi.txTransaksi.Text
        pelanggan = formTransaksi.txPelanggan.Text
        meja = formTransaksi.ComboMeja.Text
        totalPesanan = formTransaksi.DataGridView1.RowCount - 1
        totalHarga = formTransaksi.total.Text

        If Integer.Parse(txBayar.Text) < Integer.Parse(txTotalBayar.Text) Then
            MsgBox("bayar kurang")
        Else
            controlTransaksi.simpanTransaksi(noTx, pelanggan, meja, totalPesanan, totalHarga, eventDate)
            Dispose()

        End If


    End Sub



    Private Sub txBayar_TextChanged(sender As Object, e As EventArgs) Handles txBayar.TextChanged
        Dim hitungKembali As Integer
        hitungKembali = Val(txBayar.Text) - Val(txTotalBayar.Text)
        txKembali.Text = hitungKembali.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()

    End Sub
End Class