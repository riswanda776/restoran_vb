<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMasakan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txKode = New System.Windows.Forms.TextBox()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.txKodeMasakan = New System.Windows.Forms.Label()
        Me.txNamaMasakan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbJenisMasakan = New System.Windows.Forms.ComboBox()
        Me.tbMasakan = New System.Windows.Forms.DataGridView()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txSearch = New System.Windows.Forms.TextBox()
        CType(Me.tbMasakan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Masakan"
        '
        'txKode
        '
        Me.txKode.Location = New System.Drawing.Point(143, 67)
        Me.txKode.Name = "txKode"
        Me.txKode.Size = New System.Drawing.Size(152, 20)
        Me.txKode.TabIndex = 1
        '
        'txHarga
        '
        Me.txHarga.Location = New System.Drawing.Point(143, 226)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(152, 20)
        Me.txHarga.TabIndex = 3
        '
        'txKodeMasakan
        '
        Me.txKodeMasakan.AutoSize = True
        Me.txKodeMasakan.Location = New System.Drawing.Point(45, 229)
        Me.txKodeMasakan.Name = "txKodeMasakan"
        Me.txKodeMasakan.Size = New System.Drawing.Size(36, 13)
        Me.txKodeMasakan.TabIndex = 2
        Me.txKodeMasakan.Text = "Harga"
        '
        'txNamaMasakan
        '
        Me.txNamaMasakan.Location = New System.Drawing.Point(143, 117)
        Me.txNamaMasakan.Name = "txNamaMasakan"
        Me.txNamaMasakan.Size = New System.Drawing.Size(152, 20)
        Me.txNamaMasakan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Masakan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Masakan"
        '
        'cbJenisMasakan
        '
        Me.cbJenisMasakan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenisMasakan.FormattingEnabled = True
        Me.cbJenisMasakan.Location = New System.Drawing.Point(143, 170)
        Me.cbJenisMasakan.Name = "cbJenisMasakan"
        Me.cbJenisMasakan.Size = New System.Drawing.Size(152, 21)
        Me.cbJenisMasakan.TabIndex = 7
        '
        'tbMasakan
        '
        Me.tbMasakan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbMasakan.Location = New System.Drawing.Point(333, 67)
        Me.tbMasakan.Name = "tbMasakan"
        Me.tbMasakan.Size = New System.Drawing.Size(336, 337)
        Me.tbMasakan.TabIndex = 8
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(48, 290)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(333, 431)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(424, 431)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(594, 431)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(513, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 22)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "BATAL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txSearch
        '
        Me.txSearch.Location = New System.Drawing.Point(333, 34)
        Me.txSearch.Name = "txSearch"
        Me.txSearch.Size = New System.Drawing.Size(218, 20)
        Me.txSearch.TabIndex = 14
        '
        'formMasakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.txSearch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.tbMasakan)
        Me.Controls.Add(Me.cbJenisMasakan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txNamaMasakan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txHarga)
        Me.Controls.Add(Me.txKodeMasakan)
        Me.Controls.Add(Me.txKode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formMasakan"
        Me.Text = "Form Masakan"
        CType(Me.tbMasakan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txKode As TextBox
    Friend WithEvents txHarga As TextBox
    Friend WithEvents txKodeMasakan As Label
    Friend WithEvents txNamaMasakan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbJenisMasakan As ComboBox
    Friend WithEvents tbMasakan As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txSearch As TextBox
End Class
