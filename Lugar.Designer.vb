<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lugar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_lugar_nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lugar_buscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.txt_lugar_nom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(48, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 63)
        Me.Panel1.TabIndex = 0
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(274, 28)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(193, 28)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txt_lugar_nom
        '
        Me.txt_lugar_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lugar_nom.Location = New System.Drawing.Point(12, 28)
        Me.txt_lugar_nom.MaxLength = 30
        Me.txt_lugar_nom.Name = "txt_lugar_nom"
        Me.txt_lugar_nom.PlaceholderText = "Ingrese Lugar"
        Me.txt_lugar_nom.Size = New System.Drawing.Size(175, 23)
        Me.txt_lugar_nom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(76, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lugar"
        '
        'txt_lugar_buscar
        '
        Me.txt_lugar_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lugar_buscar.Location = New System.Drawing.Point(12, 28)
        Me.txt_lugar_buscar.MaxLength = 30
        Me.txt_lugar_buscar.Name = "txt_lugar_buscar"
        Me.txt_lugar_buscar.PlaceholderText = "Ingrese lugar a Buscar"
        Me.txt_lugar_buscar.Size = New System.Drawing.Size(175, 23)
        Me.txt_lugar_buscar.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.btn_limpiar)
        Me.Panel2.Controls.Add(Me.txt_lugar_buscar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(48, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 62)
        Me.Panel2.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(270, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 24)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Activa Edicion"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.DimGray
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.Location = New System.Drawing.Point(193, 28)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 3
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(58, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar Lugar"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToResizeColumns = False
        Me.dg1.AllowUserToResizeRows = False
        Me.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg1.Location = New System.Drawing.Point(106, 180)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowHeadersVisible = False
        Me.dg1.RowTemplate.Height = 25
        Me.dg1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(257, 220)
        Me.dg1.TabIndex = 3
        '
        'dg2
        '
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToResizeColumns = False
        Me.dg2.AllowUserToResizeRows = False
        Me.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg2.Location = New System.Drawing.Point(106, 208)
        Me.dg2.MultiSelect = False
        Me.dg2.Name = "dg2"
        Me.dg2.RowHeadersVisible = False
        Me.dg2.RowTemplate.Height = 25
        Me.dg2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg2.Size = New System.Drawing.Size(257, 159)
        Me.dg2.TabIndex = 4
        Me.dg2.Visible = False
        '
        'Lugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(475, 437)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Lugar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lugar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_lugar_nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lugar_buscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents dg2 As DataGridView
End Class
