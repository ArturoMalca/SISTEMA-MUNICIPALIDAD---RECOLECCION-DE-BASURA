<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cbo_nom_day = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_total_neto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.dt_year_b = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dt_month_b = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dt_day_b = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_rep_pdf = New System.Windows.Forms.Button()
        Me.fec_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_reporte = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbo_nom_day
        '
        Me.Cbo_nom_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_nom_day.FormattingEnabled = True
        Me.Cbo_nom_day.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves ", "Viernes", "Sábado ", "Domingo"})
        Me.Cbo_nom_day.Location = New System.Drawing.Point(256, 27)
        Me.Cbo_nom_day.Name = "Cbo_nom_day"
        Me.Cbo_nom_day.Size = New System.Drawing.Size(150, 23)
        Me.Cbo_nom_day.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Lbl_total_neto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_limpiar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_excel)
        Me.Panel1.Controls.Add(Me.dt_year_b)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dt_month_b)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.dt_day_b)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btn_rep_pdf)
        Me.Panel1.Controls.Add(Me.Cbo_nom_day)
        Me.Panel1.Controls.Add(Me.fec_hasta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1343, 89)
        Me.Panel1.TabIndex = 64
        '
        'Lbl_total_neto
        '
        Me.Lbl_total_neto.AutoSize = True
        Me.Lbl_total_neto.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_total_neto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_total_neto.ForeColor = System.Drawing.Color.White
        Me.Lbl_total_neto.Location = New System.Drawing.Point(1249, 69)
        Me.Lbl_total_neto.Name = "Lbl_total_neto"
        Me.Lbl_total_neto.Size = New System.Drawing.Size(28, 16)
        Me.Lbl_total_neto.TabIndex = 75
        Me.Lbl_total_neto.Text = "Día"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 17)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "BÚSQUEDA DE DATOS POR FECHA DE ENTRADA"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_limpiar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_limpiar.Location = New System.Drawing.Point(693, 53)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(73, 25)
        Me.btn_limpiar.TabIndex = 82
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(1141, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Total Neto (tn):"
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.Transparent
        Me.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_excel.ForeColor = System.Drawing.Color.Transparent
        Me.btn_excel.Location = New System.Drawing.Point(956, 21)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(73, 29)
        Me.btn_excel.TabIndex = 81
        Me.btn_excel.Text = "EXCEL"
        Me.btn_excel.UseVisualStyleBackColor = False
        '
        'dt_year_b
        '
        Me.dt_year_b.Checked = False
        Me.dt_year_b.CustomFormat = "yyyy"
        Me.dt_year_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_year_b.Location = New System.Drawing.Point(546, 27)
        Me.dt_year_b.Name = "dt_year_b"
        Me.dt_year_b.ShowCheckBox = True
        Me.dt_year_b.ShowUpDown = True
        Me.dt_year_b.Size = New System.Drawing.Size(73, 23)
        Me.dt_year_b.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(565, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Año"
        '
        'dt_month_b
        '
        Me.dt_month_b.Checked = False
        Me.dt_month_b.CustomFormat = "MM"
        Me.dt_month_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_month_b.Location = New System.Drawing.Point(481, 27)
        Me.dt_month_b.Name = "dt_month_b"
        Me.dt_month_b.ShowCheckBox = True
        Me.dt_month_b.ShowUpDown = True
        Me.dt_month_b.Size = New System.Drawing.Size(60, 23)
        Me.dt_month_b.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(496, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 15)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Mes "
        '
        'dt_day_b
        '
        Me.dt_day_b.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dt_day_b.Checked = False
        Me.dt_day_b.CustomFormat = "dd"
        Me.dt_day_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_day_b.Location = New System.Drawing.Point(411, 27)
        Me.dt_day_b.Name = "dt_day_b"
        Me.dt_day_b.ShowCheckBox = True
        Me.dt_day_b.ShowUpDown = True
        Me.dt_day_b.Size = New System.Drawing.Size(64, 23)
        Me.dt_day_b.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(425, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Día"
        '
        'btn_rep_pdf
        '
        Me.btn_rep_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btn_rep_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rep_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rep_pdf.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_rep_pdf.ForeColor = System.Drawing.Color.Transparent
        Me.btn_rep_pdf.Location = New System.Drawing.Point(877, 21)
        Me.btn_rep_pdf.Name = "btn_rep_pdf"
        Me.btn_rep_pdf.Size = New System.Drawing.Size(73, 29)
        Me.btn_rep_pdf.TabIndex = 73
        Me.btn_rep_pdf.Text = "PDF"
        Me.btn_rep_pdf.UseVisualStyleBackColor = False
        '
        'fec_hasta
        '
        Me.fec_hasta.Checked = False
        Me.fec_hasta.CustomFormat = "dd-MM-yyyy"
        Me.fec_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fec_hasta.Location = New System.Drawing.Point(634, 27)
        Me.fec_hasta.Name = "fec_hasta"
        Me.fec_hasta.ShowCheckBox = True
        Me.fec_hasta.Size = New System.Drawing.Size(132, 23)
        Me.fec_hasta.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(660, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Fecha - Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(292, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Nombre Día"
        '
        'dg_reporte
        '
        Me.dg_reporte.AllowUserToAddRows = False
        Me.dg_reporte.AllowUserToResizeColumns = False
        Me.dg_reporte.AllowUserToResizeRows = False
        Me.dg_reporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_reporte.BackgroundColor = System.Drawing.Color.White
        Me.dg_reporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_reporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_reporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_reporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_reporte.Location = New System.Drawing.Point(12, 94)
        Me.dg_reporte.MultiSelect = False
        Me.dg_reporte.Name = "dg_reporte"
        Me.dg_reporte.ReadOnly = True
        Me.dg_reporte.RowHeadersVisible = False
        Me.dg_reporte.RowTemplate.Height = 25
        Me.dg_reporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_reporte.ShowCellToolTips = False
        Me.dg_reporte.Size = New System.Drawing.Size(1321, 558)
        Me.dg_reporte.TabIndex = 65
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1339, 664)
        Me.Controls.Add(Me.dg_reporte)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_reporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cbo_nom_day As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dg_reporte As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents fec_hasta As DateTimePicker
    Friend WithEvents btn_rep_pdf As Button
    Friend WithEvents Lbl_total_neto As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dt_day_b As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_month_b As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents dt_year_b As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
