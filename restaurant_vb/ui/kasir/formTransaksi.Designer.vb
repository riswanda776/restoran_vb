<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cNamaMasakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txTransaksi = New System.Windows.Forms.TextBox()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txPelanggan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboMeja = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.labelTimer = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(483, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Masakan"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNamaMasakan, Me.cHarga, Me.cQty, Me.cJumlah})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(577, 309)
        Me.DataGridView1.TabIndex = 0
        '
        'cNamaMasakan
        '
        Me.cNamaMasakan.HeaderText = "Masakan"
        Me.cNamaMasakan.Name = "cNamaMasakan"
        Me.cNamaMasakan.ReadOnly = True
        '
        'cHarga
        '
        Me.cHarga.HeaderText = "Harga"
        Me.cHarga.Name = "cHarga"
        Me.cHarga.ReadOnly = True
        '
        'cQty
        '
        Me.cQty.HeaderText = "Qty"
        Me.cQty.Name = "cQty"
        Me.cQty.ReadOnly = True
        '
        'cJumlah
        '
        Me.cJumlah.HeaderText = "Jumlah"
        Me.cJumlah.Name = "cJumlah"
        Me.cJumlah.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.labelTimer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(426, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restoran Bang Jago"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.total)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(631, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 51)
        Me.Panel2.TabIndex = 2
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(288, 12)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(68, 29)
        Me.total.TabIndex = 1
        Me.total.Text = "Total"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(631, 511)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(103, 28)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Enabled = False
        Me.btnSelesai.Location = New System.Drawing.Point(963, 511)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(103, 28)
        Me.btnSelesai.TabIndex = 4
        Me.btnSelesai.Text = "SELESAI"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No Transaksi"
        '
        'txTransaksi
        '
        Me.txTransaksi.Enabled = False
        Me.txTransaksi.Location = New System.Drawing.Point(16, 121)
        Me.txTransaksi.Name = "txTransaksi"
        Me.txTransaksi.Size = New System.Drawing.Size(216, 20)
        Me.txTransaksi.TabIndex = 6
        '
        'txNama
        '
        Me.txNama.Enabled = False
        Me.txNama.Location = New System.Drawing.Point(16, 177)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(216, 20)
        Me.txNama.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = " Nama Masakan"
        '
        'txHarga
        '
        Me.txHarga.Enabled = False
        Me.txHarga.Location = New System.Drawing.Point(16, 235)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(216, 20)
        Me.txHarga.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Harga"
        '
        'txPelanggan
        '
        Me.txPelanggan.Enabled = False
        Me.txPelanggan.Location = New System.Drawing.Point(15, 476)
        Me.txPelanggan.Name = "txPelanggan"
        Me.txPelanggan.Size = New System.Drawing.Size(216, 20)
        Me.txPelanggan.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Pelanggan"
        '
        'txQty
        '
        Me.txQty.Enabled = False
        Me.txQty.Location = New System.Drawing.Point(16, 287)
        Me.txQty.Name = "txQty"
        Me.txQty.Size = New System.Drawing.Size(82, 20)
        Me.txQty.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "qty"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(256, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Pilih Masakan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 476)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Pilih Pelanggan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboMeja
        '
        Me.ComboMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMeja.FormattingEnabled = True
        Me.ComboMeja.Location = New System.Drawing.Point(16, 426)
        Me.ComboMeja.Name = "ComboMeja"
        Me.ComboMeja.Size = New System.Drawing.Size(155, 21)
        Me.ComboMeja.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Meja"
        '
        'Timer1
        '
        '
        'labelTimer
        '
        Me.labelTimer.AutoSize = True
        Me.labelTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTimer.Location = New System.Drawing.Point(12, 74)
        Me.labelTimer.Name = "labelTimer"
        Me.labelTimer.Size = New System.Drawing.Size(39, 13)
        Me.labelTimer.TabIndex = 1
        Me.labelTimer.Text = "Label9"
        '
        'formTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboMeja)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txPelanggan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formTransaksi"
        Me.Text = "formTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Public WithEvents txNama As TextBox
    Public WithEvents txHarga As TextBox
    Public WithEvents txPelanggan As TextBox
    Public WithEvents txQty As TextBox
    Friend WithEvents qty1 As DataGridViewTextBoxColumn
    Friend WithEvents cNamaMasakan As DataGridViewTextBoxColumn
    Friend WithEvents cHarga As DataGridViewTextBoxColumn
    Friend WithEvents cQty As DataGridViewTextBoxColumn
    Friend WithEvents cJumlah As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents labelTimer As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents DataGridView1 As DataGridView
    Public WithEvents total As Label
    Public WithEvents txTransaksi As TextBox
    Public WithEvents ComboMeja As ComboBox
End Class
