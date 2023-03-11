<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patente
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
        Me.txt_bus_pat = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_patingresar = New System.Windows.Forms.Button()
        Me.txt_patnom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txt_patnom_dg1 = New System.Windows.Forms.TextBox()
        Me.cbo_patest_dg1 = New System.Windows.Forms.ComboBox()
        Me.btn_edit_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_bus_pat
        '
        Me.txt_bus_pat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bus_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bus_pat.Location = New System.Drawing.Point(4, 26)
        Me.txt_bus_pat.MaxLength = 10
        Me.txt_bus_pat.Name = "txt_bus_pat"
        Me.txt_bus_pat.PlaceholderText = "Ingresar Valor a Buscar"
        Me.txt_bus_pat.Size = New System.Drawing.Size(204, 23)
        Me.txt_bus_pat.TabIndex = 5
        Me.txt_bus_pat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Navy
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpiar.Font = New System.Drawing.Font("Forte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.Location = New System.Drawing.Point(216, 26)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(71, 23)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btn_limpiar)
        Me.Panel3.Controls.Add(Me.txt_bus_pat)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(58, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 61)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(54, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BUSCAR PATENTE"
        '
        'btn_patingresar
        '
        Me.btn_patingresar.AutoSize = True
        Me.btn_patingresar.BackColor = System.Drawing.Color.MediumBlue
        Me.btn_patingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_patingresar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_patingresar.ForeColor = System.Drawing.Color.White
        Me.btn_patingresar.Location = New System.Drawing.Point(216, 22)
        Me.btn_patingresar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_patingresar.Name = "btn_patingresar"
        Me.btn_patingresar.Size = New System.Drawing.Size(71, 25)
        Me.btn_patingresar.TabIndex = 1
        Me.btn_patingresar.Text = "INGRESAR"
        Me.btn_patingresar.UseVisualStyleBackColor = False
        '
        'txt_patnom
        '
        Me.txt_patnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_patnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_patnom.ForeColor = System.Drawing.Color.Black
        Me.txt_patnom.Location = New System.Drawing.Point(4, 22)
        Me.txt_patnom.MaxLength = 7
        Me.txt_patnom.Name = "txt_patnom"
        Me.txt_patnom.Size = New System.Drawing.Size(204, 23)
        Me.txt_patnom.TabIndex = 2
        Me.txt_patnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_patnom)
        Me.Panel1.Controls.Add(Me.btn_patingresar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(58, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 56)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(54, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INGRESAR PATENTE"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(62, 157)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.Size = New System.Drawing.Size(206, 233)
        Me.DataGridView1.TabIndex = 9
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(-50, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(206, 177)
        Me.DataGridView2.TabIndex = 10
        Me.DataGridView2.Visible = False
        '
        'txt_patnom_dg1
        '
        Me.txt_patnom_dg1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_patnom_dg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_patnom_dg1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_patnom_dg1.ForeColor = System.Drawing.Color.White
        Me.txt_patnom_dg1.Location = New System.Drawing.Point(3, 21)
        Me.txt_patnom_dg1.MaxLength = 7
        Me.txt_patnom_dg1.Name = "txt_patnom_dg1"
        Me.txt_patnom_dg1.Size = New System.Drawing.Size(153, 23)
        Me.txt_patnom_dg1.TabIndex = 11
        '
        'cbo_patest_dg1
        '
        Me.cbo_patest_dg1.BackColor = System.Drawing.SystemColors.Highlight
        Me.cbo_patest_dg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_patest_dg1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_patest_dg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_patest_dg1.ForeColor = System.Drawing.Color.Black
        Me.cbo_patest_dg1.FormattingEnabled = True
        Me.cbo_patest_dg1.Items.AddRange(New Object() {"Activo ", "Inactivo"})
        Me.cbo_patest_dg1.Location = New System.Drawing.Point(2, 57)
        Me.cbo_patest_dg1.Margin = New System.Windows.Forms.Padding(0)
        Me.cbo_patest_dg1.Name = "cbo_patest_dg1"
        Me.cbo_patest_dg1.Size = New System.Drawing.Size(154, 23)
        Me.cbo_patest_dg1.TabIndex = 12
        '
        'btn_edit_guardar
        '
        Me.btn_edit_guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_edit_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_edit_guardar.Location = New System.Drawing.Point(3, 98)
        Me.btn_edit_guardar.Name = "btn_edit_guardar"
        Me.btn_edit_guardar.Size = New System.Drawing.Size(71, 28)
        Me.btn_edit_guardar.TabIndex = 13
        Me.btn_edit_guardar.Text = "Guardar"
        Me.btn_edit_guardar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(87, 98)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(69, 28)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btn_edit_guardar)
        Me.Panel2.Controls.Add(Me.btn_eliminar)
        Me.Panel2.Controls.Add(Me.cbo_patest_dg1)
        Me.Panel2.Controls.Add(Me.txt_patnom_dg1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(274, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 179)
        Me.Panel2.TabIndex = 15
        '
        'Patente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(499, 419)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Patente"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patente"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_bus_pat As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_patingresar As Button
    Friend WithEvents txt_patnom As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txt_patnom_dg1 As TextBox
    Friend WithEvents cbo_patest_dg1 As ComboBox
    Friend WithEvents btn_edit_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
