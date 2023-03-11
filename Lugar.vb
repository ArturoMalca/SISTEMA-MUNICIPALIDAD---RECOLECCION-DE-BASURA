Public Class Lugar
    Private Sub Lugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titulo()
        mostrar_dg(0, "")
        btn_eliminar.Visible = False
        'dg1.Enabled = False
    End Sub
    Sub titulo()
        dg1.ColumnCount = 0
        dg1.Columns.Add("Codigo", "Codigo")
        dg1.Columns.Add("Lugar", "Lugar")
        dg1.Columns("Codigo").Visible = False

        dg2.ColumnCount = 0
        dg2.Columns.Add("Codigo", "Codigo")
        dg2.Columns.Add("Lugar", "Lugar")
        dg2.Columns("Codigo").Visible = False
    End Sub
    Sub mostrar_dg(str, val_busca)
        If str = 0 Then
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "lugar_select"
            dr = cmd.ExecuteReader
            While dr.Read
                dg1.Rows.Add(dr("lug_id"), dr("lug_nom"))
                dg2.Rows.Add(dr("lug_id"), dr("lug_nom"))
            End While
            Cerrar()
            'dg1.ClearSelection()
        Else
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "lugar_search"
            cmd.Parameters.AddWithValue("@lug_nom", val_busca)
            dr = cmd.ExecuteReader
            While dr.Read
                dg1.Rows.Add(dr("lug_id"), dr("lug_nom"))
                dg2.Rows.Add(dr("lug_id"), dr("lug_nom"))
            End While
            Cerrar()
            cmd.Parameters.Clear()
            'dg1.ClearSelection()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lugar_nom.KeyPress
        Dim char_add As String = "´" & Convert.ToChar(2)
        'Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) _
                        AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not char_add.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lugar_buscar.KeyPress
        Dim char_add As String = "´" & Convert.ToChar(2)
        'Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) _
                        AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not char_add.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If CheckBox1.Checked = False Then
            If Trim(txt_lugar_nom.Text) = "" Then
                MsgBox("Ingrese Lugar a registrar", vbCritical, "Campos Vacíos")
                txt_lugar_nom.Focus()
                Exit Sub
            End If
            Dim duplicado = 0
            For i = 0 To dg1.Rows.Count - 1
                If StrConv(txt_lugar_nom.Text, VbStrConv.ProperCase) = dg1.Item(1, i).Value Then
                    duplicado = 1
                End If
            Next
            If duplicado = 1 Then
                MsgBox("Lugar, ya se encuentra registrado", vbInformation, "EVITAR DUCPLICIDAD DE DATOS")
                txt_lugar_nom.Clear()
                txt_lugar_nom.Focus()
                Exit Sub
            End If

            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "lugar_insert"
            cmd.Parameters.AddWithValue("@lug_nom", StrConv(txt_lugar_nom.Text, VbStrConv.ProperCase))
            cmd.ExecuteNonQuery()
            Cerrar()
            cmd.Parameters.Clear()
            MsgBox("Lugar Ingresado", vbInformation, "Ingreso de lugares")
            titulo()
            mostrar_dg(0, "")
            limpiar()
            If Registro.Visible = True Then
                Registro.mostrar_lugar()
            End If
        Else
            If dg1.SelectedRows.Count = 0 Then
                MsgBox("seleccionar fila en la tabla", vbCritical, "Seleccionar un Lugar")
                Exit Sub
            End If
            If Trim(txt_lugar_nom.Text) = "" Then
                MsgBox("no puede actualizar a vacío", vbCritical, "Campos Vacíos al actualizar")
                CheckBox1.Checked = False
                Exit Sub
            End If
            Dim fila2 = dg1.CurrentRow.Index
            Dim dg2_lugid = dg2.Item(0, fila2).Value
            Dim dg2_lugnom = dg2.Item(1, fila2).Value

            If dg2_lugnom = Trim(txt_lugar_nom.Text) Then
                MsgBox("no se realizaron cambios", vbInformation, "Actualizar Lugar")
            Else
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "lugar_update"
                cmd.Parameters.AddWithValue("@lug_id", dg2_lugid)
                cmd.Parameters.AddWithValue("@lug_nom", StrConv(txt_lugar_nom.Text, VbStrConv.ProperCase))
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()
                MsgBox("actualizado lugar :" & vbCrLf & "de: " + dg2_lugnom + " --> " + StrConv(txt_lugar_nom.Text, VbStrConv.ProperCase), vbInformation, "Actualizar Lugar")
                CheckBox1.Checked = False
                titulo()
                mostrar_dg(0, "")
                limpiar()
                If Registro.Visible = True Then
                    Registro.mostrar_lugar()
                End If
            End If
        End If
    End Sub
    Sub limpiar()
        txt_lugar_nom.Clear()
        txt_lugar_buscar.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'limpiar()
            'dg1.Enabled = True
            CheckBox1.Text = "Desactivar"

            Dim fila As Integer
            'Dim fila
            If CheckBox1.Checked = True Then
                If dg1.SelectedRows.Count > 0 Then
                    'MessageBox.Show("ingresamos")
                    'Exit Sub
                    txt_lugar_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                    'txt_lugar_nom.Text = dg1.CurrentRow.Cells(1).Value
                    fila = dg1.CurrentRow.Index

                    dg2.ClearSelection()
                    dg2.Rows(fila).Selected = True
                    btn_eliminar.Visible = True
                Else
                    MessageBox.Show("Selecciona una fila")
                End If
            End If
        Else
            'dg1.ClearSelection()
            'dg1.Enabled = False
            txt_lugar_nom.Clear()
            txt_lugar_buscar.Clear()
            btn_eliminar.Visible = False
            CheckBox1.Text = "Activar Edición"
        End If
    End Sub

    Private Sub txt_lugar_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_lugar_buscar.TextChanged
        'If Trim(txt_lugar_buscar.Text) <> "" Then
        titulo()
        mostrar_dg(1, Trim(txt_lugar_buscar.Text)) 'StrConv(txt_lugar_buscar.Text, VbStrConv.ProperCase))
        ' End If
        Dim fila As Integer
        'Dim fila
        If CheckBox1.Checked = True Then
            If dg1.SelectedRows.Count > 0 Then
                'MessageBox.Show("ingresamos")
                'Exit Sub
                txt_lugar_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                'txt_lugar_nom.Text = dg1.CurrentRow.Cells(1).Value
                fila = dg1.CurrentRow.Index

                dg2.ClearSelection()
                dg2.Rows(fila).Selected = True
                btn_eliminar.Visible = True
                'Else
                ' MessageBox.Show("Selecciona una fila")
            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dg1.SelectedRows.Count > 0 Then
            Dim fila2 = dg1.CurrentRow.Index
            Dim dg2_lugid = dg2.Item(0, fila2).Value
            Dim dg2_lugnom = dg2.Item(1, fila2).Value

            Dim count = 0
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registro_count"
            cmd.Parameters.AddWithValue("@pat_id", "")
            cmd.Parameters.AddWithValue("@cho_id", "")
            cmd.Parameters.AddWithValue("@lug_id", dg2_lugid)
            dr = cmd.ExecuteReader
            If dr.Read Then
                count = dr("cantidad")
            End If
            Cerrar()
            cmd.Parameters.Clear()

            If count > 0 Then
                MsgBox(dg2_lugnom & vbCrLf & " se encuentra en: " &
                       count & " Registro/os" & vbCrLf & vbCrLf &
                       "Si desea eliminar Lugar, elimine todos los registros que lo contienen", vbInformation, "LUGAR VINCULADO EN LA TABLA REGISTROS")
                Exit Sub
            End If

            Dim respuesta As Integer
            respuesta = MsgBox("desea eliminar, Lugar:" & vbCrLf & dg2_lugnom, vbQuestion + vbYesNo + vbDefaultButton1, "ELIMINAR LUGAR")
            If respuesta = vbYes Then
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "lugar_delete"
                cmd.Parameters.AddWithValue("@lug_id", dg2_lugid)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()
                CheckBox1.Checked = False
                titulo()
                mostrar_dg(0, "")
                If Registro.Visible = True Then
                    Registro.mostrar_lugar()
                End If
            End If
        Else
            MessageBox.Show("Selecciona lugar a eliminar")
        End If
    End Sub

    Private Sub dg1_Click(sender As Object, e As EventArgs) Handles dg1.Click
        Dim fila As Integer
        'Dim fila
        If CheckBox1.Checked = True Then
            If dg1.SelectedRows.Count > 0 Then
                'MessageBox.Show("ingresamos")
                'Exit Sub
                txt_lugar_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                'txt_lugar_nom.Text = dg1.CurrentRow.Cells(1).Value
                fila = dg1.CurrentRow.Index

                dg2.ClearSelection()
                dg2.Rows(fila).Selected = True
                btn_eliminar.Visible = True
            Else
                MessageBox.Show("Selecciona una fila")
            End If
        End If
    End Sub
End Class