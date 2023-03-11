Public Class chofer
    Private Sub chofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titulo()
        mostrar_dg(0, "")
        botones(0)
        cbo_cho_buscar.Visible = False

        If Registro.Visible = True Then
            If Registro.cbo_chofer.Items.Count < 1 Then
                Exit Sub
            End If
            titulo()
            mostrar_dg(1, Trim(txt_cho_buscar.Text))
            CheckBox1.Checked = True
            'If CheckBox1.Checked = True Then

            Dim fila As Integer

            'If dg1.SelectedRows.Count > 0 Then
            txt_cho_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
            txt_cho_apel.Text = Convert.ToString(dg1.CurrentRow.Cells(2).Value)
            'If (dg1.CurrentRow.Cells(3).Value = "Activo") Then
            ' MessageBox.Show("jfjfjf")
            cbo_cho_buscar.SelectedItem = dg1.CurrentRow.Cells(4).Value
            'Else
            'cbo_cho_buscar.SelectedIndex = 1
            'End If

            cbo_cho_buscar.Visible = True
            fila = dg1.CurrentRow.Index

            dg2.ClearSelection()
            dg2.Rows(fila).Selected = True
            btn_eliminar.Visible = True
            'Else
            'MsgBox("NO SE HA SELECCIONADO FILA", vbInformation, "SELECCIONAR UNA FILA")
            'End If

            ' End If
        End If
    End Sub

    Sub titulo()
        dg1.ColumnCount = 0
        dg1.Columns.Add("Codigo", "Codigo")
        dg1.Columns.Add("Nombre", "Nombre")
        dg1.Columns.Add("Apellido", "Apellido")
        dg1.Columns.Add("Chofer", "Chofer")
        'dg1.Columns.Add("Apellido", "Apellido")
        dg1.Columns.Add("Estado", "Estado")

        dg1.Columns("Codigo").Visible = False
        dg1.Columns("Estado").Width = 70
        dg1.Columns("Nombre").Visible = False
        dg1.Columns("Apellido").Visible = False

        dg2.ColumnCount = 0
        dg2.Columns.Add("Codigo", "Codigo")
        dg2.Columns.Add("Nombre", "Nombre")
        dg2.Columns.Add("Apellido", "Apellido")
        dg2.Columns.Add("Chofer", "Chofer")
        'dg2.Columns.Add("Apellido", "Apellido")
        dg2.Columns.Add("Estado", "Estado")
    End Sub
    Sub mostrar_dg(str, val_busca)
        If str = 0 Then
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select*from v_chofer order by cho_id desc"
            dr = cmd.ExecuteReader
            While dr.Read
                Dim estado = dr("cho_est")
                If estado = "A" Then
                    estado = "Activo"
                Else
                    estado = "Inactivo"
                End If
                dg1.Rows.Add(dr("cho_id"), dr("cho_nom"), dr("cho_apel"), dr("chofer"), estado)
                dg2.Rows.Add(dr("cho_id"), dr("cho_nom"), dr("cho_apel"), dr("chofer"), estado)
            End While
            Cerrar()
            'dg1.ClearSelection()
        Else
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "chofer_search"
            cmd.Parameters.AddWithValue("@val_busca", val_busca)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim estado = dr("cho_est")
                If estado = "A" Then
                    estado = "Activo"
                Else
                    estado = "Inactivo"
                End If
                dg1.Rows.Add(dr("cho_id"), dr("cho_nom"), dr("cho_apel"), dr("chofer"), estado)
                dg2.Rows.Add(dr("cho_id"), dr("cho_nom"), dr("cho_apel"), dr("chofer"), estado)
            End While
            Cerrar()
            cmd.Parameters.Clear()
            'dg1.ClearSelection()
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If CheckBox1.Checked = True And dg1.SelectedRows.Count = 0 Then
            MsgBox("DESACTIVAR MODO EDICIÓN PARA PODER REGISTRAR" & vbCrLf & vbCrLf & "Puede desactivar, presionando 'Limpiar'", vbInformation, "Modo Edición de Chofer")
            Exit Sub
        End If

        If (Trim(txt_cho_nom.Text)) = "" Then
            MsgBox("campo nombre está vacío", vbCritical, "Verificación de Campos")
            txt_cho_nom.Focus()
            txt_cho_buscar.Clear()
            Exit Sub
        Else
            If (Trim(txt_cho_apel.Text)) = "" Then
                MsgBox("campo apellido está vacío", vbCritical, "Verificación de Campos")
                txt_cho_apel.Focus()
                txt_cho_buscar.Clear()
                Exit Sub
            End If
        End If

        If CheckBox1.Checked = False Then
            Dim duplicidad = 0
            For i = 0 To dg1.Rows.Count - 1
                If StrConv(txt_cho_nom.Text, VbStrConv.ProperCase) = dg1.Item(1, i).Value And StrConv(txt_cho_apel.Text, VbStrConv.ProperCase) = dg1.Item(2, i).Value Then
                    duplicidad = 1
                End If
            Next
            If duplicidad = 1 Then
                MsgBox("Chofer, ya se encuentra registrado", vbInformation, "EVITAR DUPLICIDAD DE DATOS")
                txt_cho_nom.Clear()
                txt_cho_apel.Clear()
                txt_cho_nom.Focus()
                Exit Sub
            End If
            ' MessageBox.Show(StrConv(txt_cho_nom.Text, VbStrConv.ProperCase))
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "chofer_insert"
            cmd.Parameters.AddWithValue("@cho_nom", StrConv(txt_cho_nom.Text, VbStrConv.ProperCase))
            cmd.Parameters.AddWithValue("@cho_apel", StrConv(txt_cho_apel.Text, VbStrConv.ProperCase))
            cmd.ExecuteNonQuery()
            Cerrar()
            cmd.Parameters.Clear()

            'MsgBox(txt_cho_nom.Text + " " + txt_cho_apel.Text)
            If Registro.Visible = True Then
                Registro.mostrar_chofer()
            End If

            MsgBox("Chofer Registrado", vbInformation, "Registro Chofer")
            titulo()
            mostrar_dg(0, "")
            limpiar(True)

        Else
            If dg1.SelectedRows.Count = 0 Then
                MsgBox("seleccione un chofer para editar", vbCritical, "Seleccionar Fila")
                Exit Sub
            End If
            Dim fila2 = dg1.CurrentRow.Index
            Dim dg2_choid = dg2.Item(0, fila2).Value
            Dim dg2_chonom = dg2.Item(1, fila2).Value
            Dim dg2_choapel = dg2.Item(2, fila2).Value
            Dim dg2_choest = dg2.Item(4, fila2).Value
            Dim parameter_choest
            Dim mensaje As String = ""

            If Trim(cbo_cho_buscar.Text) = "Activo" Then
                parameter_choest = "A"
            Else
                parameter_choest = "I"
            End If

            If dg2_chonom = Trim(StrConv(txt_cho_nom.Text, VbStrConv.ProperCase)) And dg2_choapel = Trim(StrConv(txt_cho_apel.Text, VbStrConv.ProperCase)) And dg2_choest = Trim(cbo_cho_buscar.Text) Then
                MsgBox("no se realizaron cambios", vbInformation, "Actualizar Chofer")
                CheckBox1.Checked = False
            Else
                If dg2_chonom <> Trim(txt_cho_nom.Text) And dg2_choapel <> Trim(txt_cho_apel.Text) And dg2_choest <> Trim(cbo_cho_buscar.Text) Then
                    Abrir()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "chofer_update"
                    cmd.Parameters.AddWithValue("@condi", 0)
                    cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
                    cmd.Parameters.AddWithValue("@cho_nom", StrConv(txt_cho_nom.Text, VbStrConv.ProperCase))
                    cmd.Parameters.AddWithValue("@cho_apel", StrConv(txt_cho_apel.Text, VbStrConv.ProperCase))
                    cmd.Parameters.AddWithValue("@cho_est", parameter_choest)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    cmd.Parameters.Clear()
                    MsgBox("actualizado:" & vbCrLf & "de: " + dg2_chonom + " a " + StrConv(txt_cho_nom.Text, VbStrConv.ProperCase) & vbCrLf & "de: " + dg2_choapel + " a " + StrConv(txt_cho_apel.Text, VbStrConv.ProperCase) & vbCrLf & "de: " + dg2_choest + " a " + StrConv(cbo_cho_buscar.Text, VbStrConv.ProperCase), vbInformation, "Actualizar Chofer")

                    If Registro.Visible = True Then
                        Registro.mostrar_chofer()
                    End If

                    CheckBox1.Checked = False
                    titulo()
                    mostrar_dg(0, "")
                    'mensaje_ = "Actualizado: " & vbCrLf & "de: " + dg2_chonom + " a " + StrConv(txt_cho_nom.Text, VbStrConv.ProperCase) & vbCrLf & "de: " + dg2_choapel + " a " + StrConv(txt_cho_apel.Text, VbStrConv.ProperCase) & vbCrLf & "de: " + dg2_choest + " a " + StrConv(cbo_cho_buscar.Text, VbStrConv.ProperCase)
                Else
                    'Dim mensaje_ = ""
                    If dg2_chonom <> Trim(StrConv(txt_cho_nom.Text, VbStrConv.ProperCase)) Then
                        Abrir()
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "chofer_update"
                        cmd.Parameters.AddWithValue("@condi", 1)
                        cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
                        cmd.Parameters.AddWithValue("@cho_nom", StrConv(txt_cho_nom.Text, VbStrConv.ProperCase))
                        cmd.Parameters.AddWithValue("@cho_apel", "")
                        cmd.Parameters.AddWithValue("@cho_est", "")
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        cmd.Parameters.Clear()
                        mensaje += vbCrLf & " - NOMBRE: " + dg2_chonom + " -> " + StrConv(txt_cho_nom.Text, VbStrConv.ProperCase)
                    End If
                    If dg2_choapel <> Trim(StrConv(txt_cho_apel.Text, VbStrConv.ProperCase)) Then
                        Abrir()
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "chofer_update"
                        cmd.Parameters.AddWithValue("@condi", 2)
                        cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
                        cmd.Parameters.AddWithValue("@cho_nom", "")
                        cmd.Parameters.AddWithValue("@cho_apel", StrConv(txt_cho_apel.Text, VbStrConv.ProperCase))
                        cmd.Parameters.AddWithValue("@cho_est", "")
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        cmd.Parameters.Clear()
                        mensaje += vbCrLf & " - APELLIDO: " + dg2_choapel + " -> " + StrConv(txt_cho_apel.Text, VbStrConv.ProperCase)
                    End If
                    If dg2_choest <> Trim(cbo_cho_buscar.Text) Then
                        Abrir()
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "chofer_update"
                        cmd.Parameters.AddWithValue("@condi", 3)
                        cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
                        cmd.Parameters.AddWithValue("@cho_nom", "")
                        cmd.Parameters.AddWithValue("@cho_apel", "")
                        cmd.Parameters.AddWithValue("@cho_est", parameter_choest)
                        cmd.ExecuteNonQuery()
                        Cerrar()
                        cmd.Parameters.Clear()
                        mensaje += vbCrLf & " - ESTADO: " + dg2_choest + " -> " + StrConv(cbo_cho_buscar.Text, VbStrConv.ProperCase)
                    End If

                    If Registro.Visible = True Then
                        Registro.mostrar_chofer()
                    End If

                    MsgBox("ACTUALIZADO" & mensaje, vbInformation, "Actulizar Chofer")
                    CheckBox1.Checked = False
                    titulo()
                    mostrar_dg(0, "")

                End If
            End If
        End If

    End Sub
    Sub limpiar(val)
        txt_cho_nom.Clear()
        txt_cho_apel.Clear()
        If CheckBox1.Checked = False Then
            txt_cho_buscar.Clear()
        End If
    End Sub
    Sub botones(str)
        If str = 0 Then
            btn_eliminar.Visible = False
            ' cbo_cho_buscar.Visible = False
            'txt_cho_buscar.Enabled = True
            'dg1.Enabled = False
            'dg1.ClearSelection()
        Else
            btn_eliminar.Visible = True
            'cbo_cho_buscar.Visible = True
            ' txt_cho_buscar.Enabled = False
            ' dg1.Enabled = True
            dg1.ClearSelection()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            limpiar(True)
            'dg1.Enabled = True
            CheckBox1.Text = "Desactivar"

            Dim fila As Integer

            If dg1.SelectedRows.Count > 0 Then
                txt_cho_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                txt_cho_apel.Text = Convert.ToString(dg1.CurrentRow.Cells(2).Value)
                'If (dg1.CurrentRow.Cells(3).Value = "Activo") Then
                ' MessageBox.Show("jfjfjf")
                cbo_cho_buscar.SelectedItem = dg1.CurrentRow.Cells(4).Value
                'Else
                'cbo_cho_buscar.SelectedIndex = 1
                'End If

                cbo_cho_buscar.Visible = True
                fila = dg1.CurrentRow.Index

                dg2.ClearSelection()
                dg2.Rows(fila).Selected = True
                btn_eliminar.Visible = True
            Else
                MsgBox("NO SE HA SELECCIONADO FILA", vbInformation, "SELECCIONAR UNA FILA")
            End If

        Else
            'dg1.Enabled = False
            limpiar(True)
            CheckBox1.Text = "Activar Edición"
            cbo_cho_buscar.Visible = False
            'dg1.ClearSelection()
            btn_eliminar.Visible = False
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar(True)
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub dg1_Click(sender As Object, e As EventArgs) Handles dg1.Click
        If CheckBox1.Checked = True Then

            Dim fila As Integer

            If dg1.SelectedRows.Count > 0 Then
                txt_cho_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                txt_cho_apel.Text = Convert.ToString(dg1.CurrentRow.Cells(2).Value)
                'If (dg1.CurrentRow.Cells(3).Value = "Activo") Then
                ' MessageBox.Show("jfjfjf")
                cbo_cho_buscar.SelectedItem = dg1.CurrentRow.Cells(4).Value
                'Else
                'cbo_cho_buscar.SelectedIndex = 1
                'End If

                cbo_cho_buscar.Visible = True
                fila = dg1.CurrentRow.Index

                dg2.ClearSelection()
                dg2.Rows(fila).Selected = True
                btn_eliminar.Visible = True
            Else
                MsgBox("NO SE HA SELECCIONADO FILA", vbInformation, "SELECCIONAR UNA FILA")
            End If

        End If
    End Sub

    Private Sub txt_cho_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_cho_buscar.TextChanged
        titulo()
        mostrar_dg(1, Trim(txt_cho_buscar.Text))
        If CheckBox1.Checked = True Then

            Dim fila As Integer

            'If dg1.SelectedRows.Count > 0 Then
            txt_cho_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
                txt_cho_apel.Text = Convert.ToString(dg1.CurrentRow.Cells(2).Value)
                'If (dg1.CurrentRow.Cells(3).Value = "Activo") Then
                ' MessageBox.Show("jfjfjf")
                cbo_cho_buscar.SelectedItem = dg1.CurrentRow.Cells(4).Value
                'Else
                'cbo_cho_buscar.SelectedIndex = 1
                'End If

                cbo_cho_buscar.Visible = True
                fila = dg1.CurrentRow.Index

                dg2.ClearSelection()
                dg2.Rows(fila).Selected = True
                btn_eliminar.Visible = True
            'Else
            'MsgBox("NO SE HA SELECCIONADO FILA", vbInformation, "SELECCIONAR UNA FILA")
            'End If

        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dg1.SelectedRows.Count > 0 Then
            Dim fila2 = dg1.CurrentRow.Index
            Dim dg2_choid = dg2.Item(0, fila2).Value
            Dim dg2_cho = dg2.Item(3, fila2).Value

            Dim count = 0
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registro_count"
            cmd.Parameters.AddWithValue("@pat_id", "")
            cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
            cmd.Parameters.AddWithValue("@lug_id", "")
            dr = cmd.ExecuteReader
            If dr.Read Then
                count = dr("cantidad")
            End If
            Cerrar()
            cmd.Parameters.Clear()

            If count > 0 Then
                MsgBox(dg2_cho & vbCrLf & " se encuentra en: " &
                       count & " Registro/os" & vbCrLf & vbCrLf &
                       "Si desea eliminar al Chofer, elimine todos los registros que lo contienen", vbInformation, "CHOFER VINCULADO EN LA TABLA REGISTROS")
                Exit Sub
            End If

            Dim respuesta As Integer
            respuesta = MsgBox("desea eliminar al chofer:" & vbCrLf & dg2_cho, vbQuestion + vbYesNo + vbDefaultButton1, "ELIMINAR CHOFER")
            If respuesta = vbYes Then
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "chofer_delete"
                cmd.Parameters.AddWithValue("@cho_id", dg2_choid)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()
                CheckBox1.Checked = False
                titulo()
                mostrar_dg(0, "")

                If Registro.Visible = True Then
                    Registro.mostrar_chofer()
                    Registro.cbo_chofer.Text = ""
                End If
            End If
        Else
            MsgBox("Seleccionar un chofer a eliminar", vbInformation, "SELECCIONAR FILA PARA ELIMINAR")
        End If
    End Sub

    Private Sub txt_cho_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cho_nom.KeyPress
        '  Dim caracteresPermitidos As String = "1234567890.,-+" & Convert.ToChar(8)
        Dim caracteresPermitidos As String = "´" & Convert.ToChar(8)

        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) _
                                    AndAlso Not Char.IsWhiteSpace(e.KeyChar) _
            AndAlso Not caracteresPermitidos.Contains(c) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_cho_apel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cho_apel.KeyPress
        '  Dim caracteresPermitidos As String = "1234567890.,-+" & Convert.ToChar(8)
        Dim caracteresPermitidos As String = "´" & Convert.ToChar(8)

        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) _
                                    AndAlso Not Char.IsWhiteSpace(e.KeyChar) _
            AndAlso Not caracteresPermitidos.Contains(c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cho_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cho_buscar.KeyPress
        '  Dim caracteresPermitidos As String = "1234567890.,-+" & Convert.ToChar(8)
        Dim caracteresPermitidos As String = "´" & Convert.ToChar(8)

        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) _
                                    AndAlso Not Char.IsWhiteSpace(e.KeyChar) _
            AndAlso Not caracteresPermitidos.Contains(c) Then
            e.Handled = True
        End If
    End Sub

End Class