<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_patente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_chofer = New System.Windows.Forms.Button()
        Me.cbo_chofer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_lugar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dg_lugar = New System.Windows.Forms.DataGridView()
        Me.btn_quitar_lugar = New System.Windows.Forms.Button()
        Me.dg_registro = New System.Windows.Forms.DataGridView()
        Me.Check_edicion = New System.Windows.Forms.CheckBox()
        Me.txt_buscarP = New System.Windows.Forms.TextBox()
        Me.dt_year_b = New System.Windows.Forms.DateTimePicker()
        Me.dt_hour_b = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dt_day_b = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_minute_b = New System.Windows.Forms.DateTimePicker()
        Me.txt_buscarC = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Check_activaFB_RE = New System.Windows.Forms.CheckBox()
        Me.dg_lugar_origen = New System.Windows.Forms.DataGridView()
        Me.Cbo_lugar = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cbo_patente = New System.Windows.Forms.ComboBox()
        Me.dt_h_insertS = New System.Windows.Forms.DateTimePicker()
        Me.dt_fecha_insertS = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Check_tomarFS = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_limpiar_RE = New System.Windows.Forms.Button()
        Me.txt_tara_RE = New System.Windows.Forms.TextBox()
        Me.txt_bruto_RE = New System.Windows.Forms.TextBox()
        Me.dt_hora_RE = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dt_fecha_RE = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.check_tomarFA_RE = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt_month_b = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cbo_nom_day_b = New System.Windows.Forms.ComboBox()
        Me.Check_nom_day_b = New System.Windows.Forms.CheckBox()
        Me.lbl_total_neto = New System.Windows.Forms.Label()
        Me.btn_reportes = New System.Windows.Forms.Button()
        CType(Me.dg_lugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_lugar_origen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_patente
        '
        Me.btn_patente.BackColor = System.Drawing.Color.White
        Me.btn_patente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_patente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_patente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_patente.Location = New System.Drawing.Point(244, 26)
        Me.btn_patente.Name = "btn_patente"
        Me.btn_patente.Size = New System.Drawing.Size(75, 23)
        Me.btn_patente.TabIndex = 1
        Me.btn_patente.Text = "Patente"
        Me.btn_patente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccionar patente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(244, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Acceder a:"
        '
        'btn_chofer
        '
        Me.btn_chofer.BackColor = System.Drawing.Color.White
        Me.btn_chofer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_chofer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_chofer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_chofer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_chofer.Location = New System.Drawing.Point(619, 25)
        Me.btn_chofer.Name = "btn_chofer"
        Me.btn_chofer.Size = New System.Drawing.Size(75, 23)
        Me.btn_chofer.TabIndex = 5
        Me.btn_chofer.Text = "Chofer"
        Me.btn_chofer.UseVisualStyleBackColor = False
        '
        'cbo_chofer
        '
        Me.cbo_chofer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_chofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbo_chofer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbo_chofer.FormattingEnabled = True
        Me.cbo_chofer.Location = New System.Drawing.Point(352, 26)
        Me.cbo_chofer.Name = "cbo_chofer"
        Me.cbo_chofer.Size = New System.Drawing.Size(261, 113)
        Me.cbo_chofer.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(388, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seleccionar chofer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(620, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Acceder a:"
        '
        'btn_lugar
        '
        Me.btn_lugar.BackColor = System.Drawing.Color.White
        Me.btn_lugar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_lugar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_lugar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_lugar.Location = New System.Drawing.Point(1200, 22)
        Me.btn_lugar.Name = "btn_lugar"
        Me.btn_lugar.Size = New System.Drawing.Size(75, 23)
        Me.btn_lugar.TabIndex = 9
        Me.btn_lugar.Text = "Lugar"
        Me.btn_lugar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(988, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Seleccionar lugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1200, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Acceder a:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_guardar.Location = New System.Drawing.Point(1015, 441)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 25)
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1100, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Controles:"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_limpiar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_limpiar.Location = New System.Drawing.Point(1096, 441)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 25)
        Me.btn_limpiar.TabIndex = 15
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Location = New System.Drawing.Point(1177, 441)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(73, 25)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'dg_lugar
        '
        Me.dg_lugar.AllowUserToAddRows = False
        Me.dg_lugar.AllowUserToResizeColumns = False
        Me.dg_lugar.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dg_lugar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_lugar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_lugar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_lugar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_lugar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_lugar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_lugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_lugar.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_lugar.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg_lugar.Location = New System.Drawing.Point(11, 7)
        Me.dg_lugar.MultiSelect = False
        Me.dg_lugar.Name = "dg_lugar"
        Me.dg_lugar.ReadOnly = True
        Me.dg_lugar.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.dg_lugar.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_lugar.RowTemplate.Height = 25
        Me.dg_lugar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_lugar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_lugar.ShowCellToolTips = False
        Me.dg_lugar.Size = New System.Drawing.Size(204, 102)
        Me.dg_lugar.TabIndex = 17
        '
        'btn_quitar_lugar
        '
        Me.btn_quitar_lugar.BackColor = System.Drawing.Color.White
        Me.btn_quitar_lugar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_lugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitar_lugar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_quitar_lugar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_quitar_lugar.Location = New System.Drawing.Point(221, 7)
        Me.btn_quitar_lugar.Name = "btn_quitar_lugar"
        Me.btn_quitar_lugar.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar_lugar.TabIndex = 18
        Me.btn_quitar_lugar.Text = "Quitar"
        Me.btn_quitar_lugar.UseVisualStyleBackColor = False
        Me.btn_quitar_lugar.Visible = False
        '
        'dg_registro
        '
        Me.dg_registro.AllowUserToAddRows = False
        Me.dg_registro.AllowUserToResizeColumns = False
        Me.dg_registro.AllowUserToResizeRows = False
        Me.dg_registro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_registro.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dg_registro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_registro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_registro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_registro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_registro.Location = New System.Drawing.Point(12, 249)
        Me.dg_registro.MultiSelect = False
        Me.dg_registro.Name = "dg_registro"
        Me.dg_registro.ReadOnly = True
        Me.dg_registro.RowHeadersVisible = False
        Me.dg_registro.RowTemplate.Height = 25
        Me.dg_registro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_registro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_registro.ShowCellToolTips = False
        Me.dg_registro.Size = New System.Drawing.Size(961, 382)
        Me.dg_registro.TabIndex = 19
        '
        'Check_edicion
        '
        Me.Check_edicion.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_edicion.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Check_edicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check_edicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_edicion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Check_edicion.ForeColor = System.Drawing.Color.White
        Me.Check_edicion.Location = New System.Drawing.Point(989, 472)
        Me.Check_edicion.Name = "Check_edicion"
        Me.Check_edicion.Size = New System.Drawing.Size(290, 32)
        Me.Check_edicion.TabIndex = 20
        Me.Check_edicion.Text = "Opciones de Edición"
        Me.Check_edicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check_edicion.UseVisualStyleBackColor = False
        '
        'txt_buscarP
        '
        Me.txt_buscarP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscarP.Location = New System.Drawing.Point(61, 220)
        Me.txt_buscarP.MaxLength = 25
        Me.txt_buscarP.Name = "txt_buscarP"
        Me.txt_buscarP.Size = New System.Drawing.Size(87, 23)
        Me.txt_buscarP.TabIndex = 21
        '
        'dt_year_b
        '
        Me.dt_year_b.Checked = False
        Me.dt_year_b.CustomFormat = "yyyy"
        Me.dt_year_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_year_b.Location = New System.Drawing.Point(273, 220)
        Me.dt_year_b.Name = "dt_year_b"
        Me.dt_year_b.ShowCheckBox = True
        Me.dt_year_b.ShowUpDown = True
        Me.dt_year_b.Size = New System.Drawing.Size(73, 23)
        Me.dt_year_b.TabIndex = 23
        '
        'dt_hour_b
        '
        Me.dt_hour_b.CalendarForeColor = System.Drawing.Color.White
        Me.dt_hour_b.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.dt_hour_b.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_hour_b.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_hour_b.Checked = False
        Me.dt_hour_b.CustomFormat = "HH"
        Me.dt_hour_b.Enabled = False
        Me.dt_hour_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_hour_b.Location = New System.Drawing.Point(644, 219)
        Me.dt_hour_b.Name = "dt_hour_b"
        Me.dt_hour_b.ShowCheckBox = True
        Me.dt_hour_b.ShowUpDown = True
        Me.dt_hour_b.Size = New System.Drawing.Size(63, 23)
        Me.dt_hour_b.TabIndex = 24
        Me.dt_hour_b.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(78, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Patente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(290, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Año"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(651, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Hora"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(430, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Día"
        '
        'dt_day_b
        '
        Me.dt_day_b.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dt_day_b.Checked = False
        Me.dt_day_b.CustomFormat = "dd"
        Me.dt_day_b.Enabled = False
        Me.dt_day_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_day_b.Location = New System.Drawing.Point(418, 220)
        Me.dt_day_b.Name = "dt_day_b"
        Me.dt_day_b.ShowCheckBox = True
        Me.dt_day_b.ShowUpDown = True
        Me.dt_day_b.Size = New System.Drawing.Size(64, 23)
        Me.dt_day_b.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(715, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Minuto"
        '
        'dt_minute_b
        '
        Me.dt_minute_b.CalendarForeColor = System.Drawing.Color.White
        Me.dt_minute_b.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.dt_minute_b.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_minute_b.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_minute_b.Checked = False
        Me.dt_minute_b.CustomFormat = "mm"
        Me.dt_minute_b.Enabled = False
        Me.dt_minute_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_minute_b.Location = New System.Drawing.Point(713, 219)
        Me.dt_minute_b.Name = "dt_minute_b"
        Me.dt_minute_b.ShowCheckBox = True
        Me.dt_minute_b.ShowUpDown = True
        Me.dt_minute_b.Size = New System.Drawing.Size(63, 23)
        Me.dt_minute_b.TabIndex = 31
        Me.dt_minute_b.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'txt_buscarC
        '
        Me.txt_buscarC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscarC.Location = New System.Drawing.Point(154, 220)
        Me.txt_buscarC.MaxLength = 30
        Me.txt_buscarC.Name = "txt_buscarC"
        Me.txt_buscarC.Size = New System.Drawing.Size(113, 23)
        Me.txt_buscarC.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(187, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Chofer"
        '
        'Check_activaFB_RE
        '
        Me.Check_activaFB_RE.AutoSize = True
        Me.Check_activaFB_RE.BackColor = System.Drawing.Color.Transparent
        Me.Check_activaFB_RE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Check_activaFB_RE.ForeColor = System.Drawing.Color.White
        Me.Check_activaFB_RE.Location = New System.Drawing.Point(409, 164)
        Me.Check_activaFB_RE.Name = "Check_activaFB_RE"
        Me.Check_activaFB_RE.Size = New System.Drawing.Size(242, 19)
        Me.Check_activaFB_RE.TabIndex = 23
        Me.Check_activaFB_RE.Text = "Activar Búsqueda por fecha de entrada"
        Me.Check_activaFB_RE.UseVisualStyleBackColor = False
        '
        'dg_lugar_origen
        '
        Me.dg_lugar_origen.AllowUserToAddRows = False
        Me.dg_lugar_origen.AllowUserToResizeColumns = False
        Me.dg_lugar_origen.AllowUserToResizeRows = False
        Me.dg_lugar_origen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_lugar_origen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_lugar_origen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_lugar_origen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_lugar_origen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_lugar_origen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_lugar_origen.Location = New System.Drawing.Point(1064, 510)
        Me.dg_lugar_origen.MultiSelect = False
        Me.dg_lugar_origen.Name = "dg_lugar_origen"
        Me.dg_lugar_origen.ReadOnly = True
        Me.dg_lugar_origen.RowHeadersVisible = False
        Me.dg_lugar_origen.RowTemplate.Height = 25
        Me.dg_lugar_origen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_lugar_origen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_lugar_origen.ShowCellToolTips = False
        Me.dg_lugar_origen.Size = New System.Drawing.Size(153, 103)
        Me.dg_lugar_origen.TabIndex = 36
        Me.dg_lugar_origen.Visible = False
        '
        'Cbo_lugar
        '
        Me.Cbo_lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Cbo_lugar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cbo_lugar.FormattingEnabled = True
        Me.Cbo_lugar.Location = New System.Drawing.Point(989, 23)
        Me.Cbo_lugar.Name = "Cbo_lugar"
        Me.Cbo_lugar.Size = New System.Drawing.Size(205, 113)
        Me.Cbo_lugar.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(268, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(321, 18)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "R  E  G  I  S  T  R  A  N  D  O       S  A  L  I  D  A"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.Cbo_patente)
        Me.Panel3.Controls.Add(Me.btn_patente)
        Me.Panel3.Controls.Add(Me.btn_chofer)
        Me.Panel3.Controls.Add(Me.dt_h_insertS)
        Me.Panel3.Controls.Add(Me.cbo_chofer)
        Me.Panel3.Controls.Add(Me.Cbo_lugar)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dt_fecha_insertS)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btn_lugar)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1291, 130)
        Me.Panel3.TabIndex = 39
        '
        'Cbo_patente
        '
        Me.Cbo_patente.AllowDrop = True
        Me.Cbo_patente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cbo_patente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Cbo_patente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cbo_patente.FormattingEnabled = True
        Me.Cbo_patente.Location = New System.Drawing.Point(33, 26)
        Me.Cbo_patente.Name = "Cbo_patente"
        Me.Cbo_patente.Size = New System.Drawing.Size(205, 113)
        Me.Cbo_patente.TabIndex = 43
        '
        'dt_h_insertS
        '
        Me.dt_h_insertS.CalendarForeColor = System.Drawing.Color.White
        Me.dt_h_insertS.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.dt_h_insertS.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_h_insertS.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_h_insertS.Checked = False
        Me.dt_h_insertS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dt_h_insertS.CustomFormat = "HH:mm"
        Me.dt_h_insertS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dt_h_insertS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_h_insertS.Location = New System.Drawing.Point(894, 23)
        Me.dt_h_insertS.Name = "dt_h_insertS"
        Me.dt_h_insertS.ShowCheckBox = True
        Me.dt_h_insertS.ShowUpDown = True
        Me.dt_h_insertS.Size = New System.Drawing.Size(74, 23)
        Me.dt_h_insertS.TabIndex = 41
        Me.dt_h_insertS.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'dt_fecha_insertS
        '
        Me.dt_fecha_insertS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dt_fecha_insertS.CustomFormat = ""
        Me.dt_fecha_insertS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dt_fecha_insertS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_fecha_insertS.Location = New System.Drawing.Point(726, 23)
        Me.dt_fecha_insertS.Name = "dt_fecha_insertS"
        Me.dt_fecha_insertS.Size = New System.Drawing.Size(162, 23)
        Me.dt_fecha_insertS.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Gray
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(741, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Seleccionar Fecha"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(894, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 15)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Hora-minuto"
        '
        'Check_tomarFS
        '
        Me.Check_tomarFS.AutoSize = True
        Me.Check_tomarFS.BackColor = System.Drawing.Color.Gray
        Me.Check_tomarFS.ForeColor = System.Drawing.Color.White
        Me.Check_tomarFS.Location = New System.Drawing.Point(770, 2)
        Me.Check_tomarFS.Name = "Check_tomarFS"
        Me.Check_tomarFS.Padding = New System.Windows.Forms.Padding(5, 1, 2, 4)
        Me.Check_tomarFS.Size = New System.Drawing.Size(133, 24)
        Me.Check_tomarFS.TabIndex = 43
        Me.Check_tomarFS.Text = "Tomar fecha actual"
        Me.Check_tomarFS.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btn_limpiar_RE)
        Me.Panel2.Controls.Add(Me.txt_tara_RE)
        Me.Panel2.Controls.Add(Me.txt_bruto_RE)
        Me.Panel2.Controls.Add(Me.dt_hora_RE)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.dt_fecha_RE)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Enabled = False
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(979, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 114)
        Me.Panel2.TabIndex = 43
        '
        'btn_limpiar_RE
        '
        Me.btn_limpiar_RE.BackColor = System.Drawing.Color.White
        Me.btn_limpiar_RE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar_RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpiar_RE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_limpiar_RE.ForeColor = System.Drawing.Color.Black
        Me.btn_limpiar_RE.Location = New System.Drawing.Point(190, 82)
        Me.btn_limpiar_RE.Name = "btn_limpiar_RE"
        Me.btn_limpiar_RE.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar_RE.TabIndex = 52
        Me.btn_limpiar_RE.Text = "Limpiar"
        Me.btn_limpiar_RE.UseVisualStyleBackColor = False
        '
        'txt_tara_RE
        '
        Me.txt_tara_RE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tara_RE.Location = New System.Drawing.Point(104, 82)
        Me.txt_tara_RE.MaxLength = 5
        Me.txt_tara_RE.Name = "txt_tara_RE"
        Me.txt_tara_RE.Size = New System.Drawing.Size(80, 23)
        Me.txt_tara_RE.TabIndex = 45
        '
        'txt_bruto_RE
        '
        Me.txt_bruto_RE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bruto_RE.Location = New System.Drawing.Point(18, 82)
        Me.txt_bruto_RE.MaxLength = 5
        Me.txt_bruto_RE.Name = "txt_bruto_RE"
        Me.txt_bruto_RE.Size = New System.Drawing.Size(80, 23)
        Me.txt_bruto_RE.TabIndex = 44
        '
        'dt_hora_RE
        '
        Me.dt_hora_RE.CalendarForeColor = System.Drawing.Color.White
        Me.dt_hora_RE.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.dt_hora_RE.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_hora_RE.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_hora_RE.Checked = False
        Me.dt_hora_RE.CustomFormat = "HH:mm"
        Me.dt_hora_RE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_hora_RE.Location = New System.Drawing.Point(173, 27)
        Me.dt_hora_RE.Name = "dt_hora_RE"
        Me.dt_hora_RE.ShowCheckBox = True
        Me.dt_hora_RE.ShowUpDown = True
        Me.dt_hora_RE.Size = New System.Drawing.Size(82, 23)
        Me.dt_hora_RE.TabIndex = 43
        Me.dt_hora_RE.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(173, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 15)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Hora-minuto"
        '
        'dt_fecha_RE
        '
        Me.dt_fecha_RE.CustomFormat = ""
        Me.dt_fecha_RE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_fecha_RE.Location = New System.Drawing.Point(5, 27)
        Me.dt_fecha_RE.Name = "dt_fecha_RE"
        Me.dt_fecha_RE.Size = New System.Drawing.Size(162, 23)
        Me.dt_fecha_RE.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Gray
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(5, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 19)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Seleccionar Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "mm"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(834, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(63, 23)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.White
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DimGray
        Me.DateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.CustomFormat = "HH"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(765, 23)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(63, 23)
        Me.DateTimePicker2.TabIndex = 41
        Me.DateTimePicker2.Value = New Date(2022, 4, 27, 16, 33, 0, 0)
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = ""
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(597, 23)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(162, 23)
        Me.DateTimePicker3.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Gray
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(612, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 19)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Seleccionar Fecha"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(834, 7)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 15)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Minuto"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(765, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 15)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Hora"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(18, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 15)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Bruto (Kg)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(109, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 15)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Tara (Kg)"
        '
        'check_tomarFA_RE
        '
        Me.check_tomarFA_RE.AutoSize = True
        Me.check_tomarFA_RE.BackColor = System.Drawing.Color.Gray
        Me.check_tomarFA_RE.Enabled = False
        Me.check_tomarFA_RE.ForeColor = System.Drawing.Color.White
        Me.check_tomarFA_RE.Location = New System.Drawing.Point(1159, 278)
        Me.check_tomarFA_RE.Name = "check_tomarFA_RE"
        Me.check_tomarFA_RE.Padding = New System.Windows.Forms.Padding(5, 1, 2, 4)
        Me.check_tomarFA_RE.Size = New System.Drawing.Size(133, 24)
        Me.check_tomarFA_RE.TabIndex = 44
        Me.check_tomarFA_RE.Text = "Tomar fecha actual"
        Me.check_tomarFA_RE.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(1006, 278)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 18)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = " E  N  T  R  A  D  A"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Controls.Add(Me.dg_lugar)
        Me.Panel5.Controls.Add(Me.btn_quitar_lugar)
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(979, 148)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 115)
        Me.Panel5.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(137, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Label8.Size = New System.Drawing.Size(266, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = " BUSCAR EN REGISTRO DE SALIDA"
        '
        'dt_month_b
        '
        Me.dt_month_b.Checked = False
        Me.dt_month_b.CustomFormat = "MM"
        Me.dt_month_b.Enabled = False
        Me.dt_month_b.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_month_b.Location = New System.Drawing.Point(352, 220)
        Me.dt_month_b.Name = "dt_month_b"
        Me.dt_month_b.ShowCheckBox = True
        Me.dt_month_b.ShowUpDown = True
        Me.dt_month_b.Size = New System.Drawing.Size(60, 23)
        Me.dt_month_b.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(367, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 15)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Mes "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(782, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cbo_nom_day_b
        '
        Me.Cbo_nom_day_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_nom_day_b.Enabled = False
        Me.Cbo_nom_day_b.FormattingEnabled = True
        Me.Cbo_nom_day_b.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves ", "Viernes", "Sábado ", "Domingo"})
        Me.Cbo_nom_day_b.Location = New System.Drawing.Point(488, 219)
        Me.Cbo_nom_day_b.Name = "Cbo_nom_day_b"
        Me.Cbo_nom_day_b.Size = New System.Drawing.Size(150, 23)
        Me.Cbo_nom_day_b.TabIndex = 49
        '
        'Check_nom_day_b
        '
        Me.Check_nom_day_b.AutoSize = True
        Me.Check_nom_day_b.BackColor = System.Drawing.Color.Transparent
        Me.Check_nom_day_b.Enabled = False
        Me.Check_nom_day_b.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Check_nom_day_b.ForeColor = System.Drawing.Color.White
        Me.Check_nom_day_b.Location = New System.Drawing.Point(515, 201)
        Me.Check_nom_day_b.Name = "Check_nom_day_b"
        Me.Check_nom_day_b.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Check_nom_day_b.Size = New System.Drawing.Size(98, 19)
        Me.Check_nom_day_b.TabIndex = 50
        Me.Check_nom_day_b.Text = "Nombre día."
        Me.Check_nom_day_b.UseVisualStyleBackColor = False
        '
        'lbl_total_neto
        '
        Me.lbl_total_neto.AutoSize = True
        Me.lbl_total_neto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total_neto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_total_neto.ForeColor = System.Drawing.Color.White
        Me.lbl_total_neto.Location = New System.Drawing.Point(1042, 561)
        Me.lbl_total_neto.Name = "lbl_total_neto"
        Me.lbl_total_neto.Size = New System.Drawing.Size(65, 18)
        Me.lbl_total_neto.TabIndex = 51
        Me.lbl_total_neto.Text = "Label21"
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.Color.Blue
        Me.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reportes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reportes.ForeColor = System.Drawing.Color.Transparent
        Me.btn_reportes.Location = New System.Drawing.Point(1042, 582)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(129, 31)
        Me.btn_reportes.TabIndex = 52
        Me.btn_reportes.Text = "Reportes"
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1291, 637)
        Me.Controls.Add(Me.btn_reportes)
        Me.Controls.Add(Me.lbl_total_neto)
        Me.Controls.Add(Me.Cbo_nom_day_b)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dt_month_b)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.check_tomarFA_RE)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Check_edicion)
        Me.Controls.Add(Me.Check_activaFB_RE)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dg_lugar_origen)
        Me.Controls.Add(Me.txt_buscarC)
        Me.Controls.Add(Me.dt_minute_b)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dt_day_b)
        Me.Controls.Add(Me.dt_hour_b)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dt_year_b)
        Me.Controls.Add(Me.txt_buscarP)
        Me.Controls.Add(Me.dg_registro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Check_tomarFS)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Check_nom_day_b)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.dg_lugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_lugar_origen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_patente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_chofer As Button
    Friend WithEvents cbo_chofer As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_lugar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents dg_lugar As DataGridView
    Friend WithEvents btn_quitar_lugar As Button
    Friend WithEvents dg_registro As DataGridView
    Friend WithEvents Check_edicion As CheckBox
    Friend WithEvents txt_buscarP As TextBox
    Friend WithEvents dt_year_b As DateTimePicker
    Friend WithEvents dt_hour_b As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_day_b As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dt_minute_b As DateTimePicker
    Friend WithEvents txt_buscarC As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dg_lugar_origen As DataGridView
    Friend WithEvents Cbo_lugar As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dt_fecha_insertS As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Check_tomarFS As CheckBox
    Friend WithEvents dt_h_insertS As DateTimePicker
    Friend WithEvents Check_activaFB_RE As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dt_hora_RE As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents dt_fecha_RE As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents check_tomarFA_RE As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_tara_RE As TextBox
    Friend WithEvents txt_bruto_RE As TextBox
    Friend WithEvents Cbo_patente As ComboBox
    Friend WithEvents dt_month_b As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Cbo_nom_day_b As ComboBox
    Friend WithEvents Check_nom_day_b As CheckBox
    Friend WithEvents btn_limpiar_RE As Button
    Friend WithEvents lbl_total_neto As Label
    Friend WithEvents btn_reportes As Button
End Class
