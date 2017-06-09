Partial Class FormBaoCaoTon
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.MaKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TonDau = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TonPhatSinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TonCuoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.lapbaocao_button = New System.Windows.Forms.Button()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(30, 62)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(52, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Ngày lập "
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(183, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(145, 28)
		Me.label2.TabIndex = 1
		Me.label2.Text = "BÁO CÁO TỒN"
		' 
		' dataGridView1
		' 
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhachHang, Me.TonDau, Me.TonPhatSinh, Me.TonCuoi})
		Me.dataGridView1.Location = New System.Drawing.Point(33, 98)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(532, 213)
		Me.dataGridView1.TabIndex = 2
		' 
		' MaKhachHang
		' 
		Me.MaKhachHang.DataPropertyName = "MaKhachHang"
		Me.MaKhachHang.HeaderText = "Mã khách hàng"
		Me.MaKhachHang.Name = "MaKhachHang"
		Me.MaKhachHang.[ReadOnly] = True
		' 
		' TonDau
		' 
		Me.TonDau.DataPropertyName = "TonDau"
		Me.TonDau.HeaderText = "Nợ đầu"
		Me.TonDau.Name = "TonDau"
		Me.TonDau.[ReadOnly] = True
		' 
		' TonPhatSinh
		' 
		Me.TonPhatSinh.DataPropertyName = "TonPhatSinh"
		Me.TonPhatSinh.HeaderText = "Nợ phát sinh"
		Me.TonPhatSinh.Name = "TonPhatSinh"
		Me.TonPhatSinh.[ReadOnly] = True
		' 
		' TonCuoi
		' 
		Me.TonCuoi.DataPropertyName = "TonCuoi"
		Me.TonCuoi.HeaderText = "Nợ cuối"
		Me.TonCuoi.Name = "TonCuoi"
		Me.TonCuoi.[ReadOnly] = True
		' 
		' dateTimePicker1
		' 
		Me.dateTimePicker1.Location = New System.Drawing.Point(78, 60)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(202, 20)
		Me.dateTimePicker1.TabIndex = 3
		' 
		' lapbaocao_button
		' 
		Me.lapbaocao_button.Location = New System.Drawing.Point(286, 58)
		Me.lapbaocao_button.Name = "lapbaocao_button"
		Me.lapbaocao_button.Size = New System.Drawing.Size(75, 23)
		Me.lapbaocao_button.TabIndex = 4
		Me.lapbaocao_button.Text = "Lập báo cáo"
		Me.lapbaocao_button.UseVisualStyleBackColor = True
		AddHandler Me.lapbaocao_button.Click, New System.EventHandler(AddressOf Me.lapbaocao_button_Click)
		' 
		' FormBaoCaoTon
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(597, 339)
		Me.Controls.Add(Me.lapbaocao_button)
		Me.Controls.Add(Me.dateTimePicker1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "FormBaoCaoTon"
		Me.Text = "Báo cáo tồn"
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private lapbaocao_button As System.Windows.Forms.Button
	Private MaKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
	Private TonDau As System.Windows.Forms.DataGridViewTextBoxColumn
	Private TonPhatSinh As System.Windows.Forms.DataGridViewTextBoxColumn
	Private TonCuoi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
