<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chofer
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
        Me.txt_cho_nom = New System.Windows.Forms.TextBox()
        Me.txt_cho_apel = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_cho_buscar = New System.Windows.Forms.TextBox()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.cbo_cho_buscar = New System.Windows.Forms.ComboBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cho_nom
        '
        Me.txt_cho_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cho_nom.Location = New System.Drawing.Point(176, 25)
        Me.txt_cho_nom.MaxLength = 30
        Me.txt_cho_nom.Name = "txt_cho_nom"
        Me.txt_cho_nom.PlaceholderText = "Ingresar Nombre"
        Me.txt_cho_nom.Size = New System.Drawing.Size(156, 23)
        Me.txt_cho_nom.TabIndex = 0
        '
        'txt_cho_apel
        '
        Me.txt_cho_apel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cho_apel.Location = New System.Drawing.Point(11, 25)
        Me.txt_cho_apel.MaxLength = 30
        Me.txt_cho_apel.Name = "txt_cho_apel"
        Me.txt_cho_apel.PlaceholderText = "Ingresar Apellido"
        Me.txt_cho_apel.Size = New System.Drawing.Size(159, 23)
        Me.txt_cho_apel.TabIndex = 1
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(338, 25)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 23)
        Me.btn_guardar.TabIndex = 2
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Crimson
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(405, 25)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(58, 23)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'txt_cho_buscar
        '
        Me.txt_cho_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cho_buscar.Location = New System.Drawing.Point(11, 24)
        Me.txt_cho_buscar.MaxLength = 30
        Me.txt_cho_buscar.Name = "txt_cho_buscar"
        Me.txt_cho_buscar.PlaceholderText = "Buscar Chofer"
        Me.txt_cho_buscar.Size = New System.Drawing.Size(156, 23)
        Me.txt_cho_buscar.TabIndex = 4
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToResizeColumns = False
        Me.dg1.AllowUserToResizeRows = False
        Me.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.dg1.Location = New System.Drawing.Point(56, 174)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowHeadersVisible = False
        Me.dg1.RowTemplate.Height = 25
        Me.dg1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(402, 200)
        Me.dg1.TabIndex = 5
        '
        'cbo_cho_buscar
        '
        Me.cbo_cho_buscar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbo_cho_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cho_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_cho_buscar.FormattingEnabled = True
        Me.cbo_cho_buscar.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cbo_cho_buscar.Location = New System.Drawing.Point(348, 23)
        Me.cbo_cho_buscar.Name = "cbo_cho_buscar"
        Me.cbo_cho_buscar.Size = New System.Drawing.Size(115, 23)
        Me.cbo_cho_buscar.TabIndex = 6
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.DimGray
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.Location = New System.Drawing.Point(173, 24)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(61, 23)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_cho_apel)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.txt_cho_nom)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(31, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 58)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(227, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(64, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apellido"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.cbo_cho_buscar)
        Me.Panel2.Controls.Add(Me.btn_limpiar)
        Me.Panel2.Controls.Add(Me.txt_cho_buscar)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(31, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 56)
        Me.Panel2.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(240, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Activar Edicion"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(45, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar chofer"
        '
        'dg2
        '
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(56, 174)
        Me.dg2.Name = "dg2"
        Me.dg2.RowTemplate.Height = 25
        Me.dg2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg2.Size = New System.Drawing.Size(402, 200)
        Me.dg2.TabIndex = 10
        '
        'chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(537, 414)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "chofer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chofer"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_cho_nom As TextBox
    Friend WithEvents txt_cho_apel As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_cho_buscar As TextBox
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents cbo_cho_buscar As ComboBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dg2 As DataGridView
End Class
