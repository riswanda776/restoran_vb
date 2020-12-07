Public Class formTransaksi

    Dim nama, pelanggan As String
    Dim harga, qtyy, jumlah As Integer

    Sub clearField()
        txNama.Text = ""
        txHarga.Text = ""
        txQty.Text = ""

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dialogPilihMasakan.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dialogPilihPelanggan.Show()

    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentTime = DateTime.Now.Millisecond
        Timer1.Enabled = True
        btnSimpan.Enabled = False
        txTransaksi.Text = currentTime.ToString
        Call controlTransaksi.tampilMeja(ComboMeja)
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txQty_TextChanged(sender As Object, e As EventArgs) Handles txQty.TextChanged
        If txQty.Text.Length > 0 Then
            btnSimpan.Enabled = True
        Else
            btnSimpan.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        dialogBayar.StartPosition = FormStartPosition.CenterScreen
        dialogBayar.Show()
        btnSelesai.Enabled = False



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTimer.Text = Format(Now, "dd MMM yyyy HH:mm:ss")
    End Sub

    Private Sub txQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQty.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txPelanggan_TextChanged(sender As Object, e As EventArgs) Handles txPelanggan.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        nama = txNama.Text
        harga = Integer.Parse(txHarga.Text)
        qtyy = Integer.Parse(txQty.Text)
        jumlah = harga * qtyy


        Dim row As String() = New String() {
            nama, harga, qtyy, jumlah
            }

        DataGridView1.Rows.Add(row)
        If DataGridView1.RowCount > 1 Then
            Dim totalHarga As Integer
            For index As Integer = 0 To DataGridView1.RowCount - 1
                totalHarga += DataGridView1.Rows(index).Cells(3).Value

            Next
            total.Text = totalHarga
            Call clearField()
            txQty.Enabled = False
            btnSimpan.Enabled = False
            btnSelesai.Enabled = True
        End If
    End Sub
End Class