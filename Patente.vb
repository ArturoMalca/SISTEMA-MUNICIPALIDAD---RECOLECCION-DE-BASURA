Public Class Patente
    Dim conta = 0
    Private Sub btn_patingresar_Click(sender As Object, e As EventArgs) Handles btn_patingresar.Click

        If btn_edit_guardar.Visible = True Then
            MsgBox("DESACTIVAR MODO EDICIÓN PARA PODER REGISTRAR" & vbCrLf & vbCrLf & "Puede desactivar, presionando 'Limpiar'", vbInformation, "Modo Edición de Patente")
            Exit Sub
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(txt_patnom.Text, "[A-Z]{2}-[0-9]{2}") Then
            If (Trim(txt_patnom.Text) = "") Then
                MsgBox("ingresar patente válida", vbOKOnly Or vbInformation, "Ingresando patente")
                txt_patnom.Focus()
            Else
                Dim duplicado = 0
                For i = 0 To DataGridView1.Rows.Count - 1
                    If txt_patnom.Text = DataGridView1.Item(1, i).Value Then
                        duplicado = 1
                    End If
                Next
                If duplicado = 1 Then
                    MsgBox("LA PATENTE YA SE ENCUENTRA REGISTRADA", vbInformation, "DATO REGISTRADO - EVITE DUPLICIDAD")
                    'txt_patnom.Clear()
                    txt_patnom.Focus()
                    Exit Sub
                End If

                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "patente_insert"
                cmd.Parameters.AddWithValue("@patente", txt_patnom.Text)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()

                If Registro.Visible = True Then
                    Registro.mostrar_patente()
                    'Registro.Cbo_patente.SelectedItem = txt_patnom_dg1.Text
                End If

                patente(0)
                Titulo()
                mostrar_patente_dg(0, "")
                'DataGridView1.ClearSelection()


                limpiar(True)
                MsgBox("Patente Registrada", vbOKOnly Or vbInformation, "Ingresando patente")
                txt_patnom.Clear()

            End If
        Else
            MsgBox("ingresar patente válida" & vbCrLf & vbCrLf +
       "EJEMPLO: LBVZ-11", vbOKOnly Or vbInformation, "Ingresando patente")
            patente(1)
            txt_patnom.Focus()
        End If

    End Sub

    Private Sub Patente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg1(True)
        Titulo()
        mostrar_patente_dg(0, "")
        DataGridView1.ClearSelection()
        tools_edit(False)

        'DataGridView1.Rows(0).ReadOnly = True
        'dgvLista.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(“#bfdbff”);
        'dgvLista.EnableHeadersVisualStyles = false;
        If Registro.Visible = True Then
            If Trim(txt_bus_pat.Text) <> "" Then
                Titulo()
                mostrar_patente_dg(1, Trim(txt_bus_pat.Text))

                Dim fila As Integer
                    txt_patnom_dg1.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
                If (DataGridView1.CurrentRow.Cells(2).Value = "Activo") Then
                    ' MessageBox.Show("jfjfjf")
                    cbo_patest_dg1.SelectedIndex = 0
                Else
                    cbo_patest_dg1.SelectedIndex = 1
                End If

                tools_edit(True)

                fila = DataGridView1.CurrentRow.Index

                DataGridView2.ClearSelection()
                DataGridView2.Rows(fila).Selected = True
            End If
        End If
    End Sub

    Private Sub txt_patnom_Click(sender As Object, e As EventArgs) Handles txt_patnom.Click
        patente(1)
        txt_bus_pat.Clear()
        tools_edit(False)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub txt_patnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_patnom.KeyPress
        Dim caracteresPermitidos As String = "-" & Convert.ToChar(1)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) _
                        AndAlso Not caracteresPermitidos.Contains(e.KeyChar) Then
            'AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            'e.Handled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub Titulo()
        DataGridView1.ColumnCount = 0
        DataGridView1.Columns.Add("Codigo", "Codigo")
        DataGridView1.Columns.Add("Patente", "Petente")
        DataGridView1.Columns.Add("Estado", "Estado")
        DataGridView1.Columns("Codigo").Visible = False

        DataGridView1.Columns("Estado").Width = 70

        DataGridView2.ColumnCount = 0
        DataGridView2.Columns.Add("Codigo", "Codigo")
        DataGridView2.Columns.Add("Patente", "Petente")
        DataGridView2.Columns.Add("Estado", "Estado")
        'DataGridView1.Columns.Add("Codigo", "Codigo")

        'DataGridView1.Columns("Codigo").ReadOnly = True
        'DataGridView1.Columns("Patente").Width = 100
        'DataGridView1.Columns("Estado").Width = 180

        'DataGridView1.Columns("Estado").Visible = False
        ' Dg.Columns("PVENTA").Visible = False
    End Sub
    Sub mostrar_patente_dg(val, val_busca)
        If (val = 0) Then
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "patente_select"
            dr = cmd.ExecuteReader
            While dr.Read
                Dim estado = dr("pat_est")
                If (estado = "A") Then
                    estado = "Activo"
                Else
                    estado = "Inactivo"
                End If

                DataGridView1.Rows.Add(dr("pat_id"), dr("pat_nom"), estado)
                DataGridView2.Rows.Add(dr("pat_id"), dr("pat_nom"), estado)
            End While
            Cerrar()
            ' MsgBox("LOS DATOS SE GRABARON CORRECTAMENTE", 64, "Aviso")
        Else
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "patente_search"
            cmd.Parameters.AddWithValue("@param", val_busca)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim estado = dr("pat_est")
                If (estado = "A") Then
                    estado = "Activo"
                Else
                    estado = "Inactivo"
                End If

                DataGridView1.Rows.Add(dr("pat_id"), dr("pat_nom"), estado)
                DataGridView2.Rows.Add(dr("pat_id"), dr("pat_nom"), estado)
            End While
            Cerrar()
            cmd.Parameters.Clear()
        End If

    End Sub

    Private Sub txt_bus_pat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_pat.KeyPress
        Dim caracteresPermitidos As String = "-" & Convert.ToChar(1)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) _
                        AndAlso Not caracteresPermitidos.Contains(e.KeyChar) Then
            'AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            'e.Handled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar(True)
        txt_patnom.Clear()
        'DataGridView1.ClearSelection()
    End Sub

    Private Sub txt_bus_pat_Leave(sender As Object, e As EventArgs) Handles txt_bus_pat.Leave
        ' If (Trim(txt_bus_pat.Text = "")) Then
        'txt_bus_pat.Text = "buscar patente"
        'End If
    End Sub

    Private Sub txt_bus_pat_Click(sender As Object, e As EventArgs) Handles txt_bus_pat.Click
        'txt_bus_pat.Text = ""
        txt_patnom.Clear()
        'tools_edit(False)
        'DataGridView1.ClearSelection()
    End Sub
    Sub dg1(val)
        DataGridView1.ReadOnly = val
    End Sub
    Sub limpiar(valor)
        'patente(0)
        'txt_bus_pat.Text = "Buscar Patente"
        'Titulo()
        'mostrar_patente_dg(0, "")
        'DataGridView1.ClearSelection()
        If Trim(txt_bus_pat.Text) <> "" Then
            DataGridView1.ClearSelection()
            txt_bus_pat.Clear()
        End If
        tools_edit(False)
    End Sub
    Sub patente(str)
        'If (str = 0) Then
        'txt_patnom.Text = "ingresar patente"
        'Else
        'txt_patnom.Clear()
        ' End If
    End Sub

    Private Sub txt_bus_pat_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_bus_pat.KeyUp
        ' If (Trim(txt_bus_pat.Text) = "") Then
        '     Titulo()
        '     mostrar_patente_dg(0, "")
        '     DataGridView1.ClearSelection()
        ' Else
        '     Titulo()
        '     mostrar_patente_dg(1, Trim(txt_bus_pat.Text))
        ' End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim fila As Integer

        If DataGridView1.SelectedRows.Count > 0 Then
            txt_patnom.Clear()
            txt_patnom_dg1.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
            If (DataGridView1.CurrentRow.Cells(2).Value = "Activo") Then
                ' MessageBox.Show("jfjfjf")
                cbo_patest_dg1.SelectedIndex = 0
            Else
                cbo_patest_dg1.SelectedIndex = 1
            End If

            tools_edit(True)

            fila = DataGridView1.CurrentRow.Index

            DataGridView2.ClearSelection()
            DataGridView2.Rows(fila).Selected = True
        Else
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub
    Sub tools_edit(state)
        Panel2.Visible = state
        txt_patnom_dg1.Visible = state
        cbo_patest_dg1.Visible = state
        btn_edit_guardar.Visible = state
        btn_eliminar.Visible = state
    End Sub

    Private Sub btn_edit_guardar_Click(sender As Object, e As EventArgs) Handles btn_edit_guardar.Click
        ' DataGridView2.ClearSelection()
        Dim fila2 = DataGridView1.CurrentRow.Index
        Dim dg2_patid = DataGridView2.Item(0, fila2).Value
        Dim dg2_patnom = DataGridView2.Item(1, fila2).Value
        Dim dg2_patest = DataGridView2.Item(2, fila2).Value

        '--------------------------------------------------------------------------------------------------------
        If Trim(txt_patnom_dg1.Text) = "" Then
            MsgBox("Ingresar un valor a editar", vbInformation, "Patente de ACTUALIZAR, Vacía")
            Exit Sub
        End If

        'System.Text.RegularExpressions.Regex.IsMatch(txt_patnom_dg1.Text, "[A-Z]")
        If System.Text.RegularExpressions.Regex.IsMatch(txt_patnom_dg1.Text, "[A-Z]{2}-[0-9]{2}") = False Then
            MsgBox("ingresar patente válida" & vbCrLf & vbCrLf +
                   "EJEMPLO: LBVZ-11", vbInformation, "Ingresando patente")
            txt_patnom_dg1.Focus()
            Exit Sub
        End If

        Dim parameter_patest
        If Trim(cbo_patest_dg1.Text) = "Activo" Then
            parameter_patest = "A"
        Else
            parameter_patest = "I"
        End If

        If dg2_patnom = Trim(txt_patnom_dg1.Text) And dg2_patest = Trim(cbo_patest_dg1.Text) Then
            MsgBox("No se realizaron cambios", vbInformation, "Actualizar Patente")
        Else
            If dg2_patnom <> Trim(txt_patnom_dg1.Text) And dg2_patest <> Trim(cbo_patest_dg1.Text) Then
                '-----------------------------------------------------------------------------------------------------------
                Dim i
                For i = 0 To DataGridView1.Rows.Count - 1
                    If Trim(txt_patnom_dg1.Text) = DataGridView1.Item(1, i).Value Then
                        MsgBox("LA PATENTE: " + txt_patnom_dg1.Text & vbCrLf & vbCrLf &
                           " YA SE ENCUENTRA REGISTRADA" +
                           " - ACTUALIZAR A UNA PATENTE DIFERENTE", vbInformation, "DATO REGISTRADO - EVITE DUPLICIDAD")
                        txt_patnom_dg1.Text = DataGridView1.Item(1, i).Value
                        i = -1
                        Exit For
                    End If
                Next
                If i = -1 Then

                    Exit Sub
                End If
                '-----------------------------------------------------------------------------------------------------------

                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "patente_update"
                cmd.Parameters.AddWithValue("@condicion", 0)
                cmd.Parameters.AddWithValue("@pat_id", dg2_patid)
                cmd.Parameters.AddWithValue("@pat_nom", Trim(txt_patnom_dg1.Text))
                cmd.Parameters.AddWithValue("@pat_est", parameter_patest)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()
                limpiar(True)
                Titulo()
                mostrar_patente_dg(0, "")
                DataGridView1.ClearSelection()
                MsgBox("Actualizado:" & vbCrLf & "de: " + dg2_patnom + " a " + txt_patnom_dg1.Text & vbCrLf & "de: " + dg2_patest + " a " + cbo_patest_dg1.Text, vbInformation, "Actualizar Patente")
            Else
                If dg2_patnom <> Trim(txt_patnom_dg1.Text) Then
                    '-----------------------------------------------------------------------------------------------------------
                    Dim f
                    For f = 0 To DataGridView1.Rows.Count - 1
                        If Trim(txt_patnom_dg1.Text) = DataGridView1.Item(1, f).Value Then
                            MsgBox("LA PATENTE: " + txt_patnom_dg1.Text +
                           " YA SE ENCUENTRA REGISTRADA" +
                           " - ACTUALIZAR A UNA PATENTE DIFERENTE", vbInformation, "DATO REGISTRADO - EVITE DUPLICIDAD")
                            txt_patnom_dg1.Text = DataGridView1.Item(1, f).Value
                            f = -1
                            Exit For
                        End If
                    Next
                    If f = -1 Then

                        Exit Sub
                    End If
                    '-----------------------------------------------------------------------------------------------------------

                    'MessageBox.Show("cambios en txt_patnom_dg1")
                    Abrir()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "patente_update"
                    cmd.Parameters.AddWithValue("@condicion", 1)
                    cmd.Parameters.AddWithValue("@pat_id", dg2_patid)
                    cmd.Parameters.AddWithValue("@pat_nom", Trim(txt_patnom_dg1.Text))
                    cmd.Parameters.AddWithValue("@pat_est", "")
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    cmd.Parameters.Clear()
                    limpiar(True)
                    Titulo()
                    mostrar_patente_dg(0, "")
                    DataGridView1.ClearSelection()
                    MsgBox("actualizado patente:" & vbCrLf & "de: " + dg2_patnom + " a " + txt_patnom_dg1.Text, vbInformation, "Actualizar Patente")
                Else
                    Abrir()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "patente_update"
                    cmd.Parameters.AddWithValue("@condicion", 2)
                    cmd.Parameters.AddWithValue("@pat_id", dg2_patid)
                    cmd.Parameters.AddWithValue("@pat_nom", "")
                    cmd.Parameters.AddWithValue("@pat_est", parameter_patest)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    cmd.Parameters.Clear()
                    limpiar(True)
                    Titulo()
                    mostrar_patente_dg(0, "")
                    DataGridView1.ClearSelection()
                    MsgBox("actualizado estado de patente :" & vbCrLf & "de: " + dg2_patest + " a " + cbo_patest_dg1.Text, vbInformation, "Actualizar Patente")
                End If
            End If

            If Registro.Visible = True Then
                Registro.mostrar_patente()
                txt_patnom_dg1.Clear()
            End If

        End If

        'MessageBox.Show(DataGridView2.Item(1, fila2).Value)
    End Sub

    Private Sub txt_patnom_dg1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_patnom_dg1.KeyPress
        Dim caracteresPermitidos As String = "-" & Convert.ToChar(1)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) _
                        AndAlso Not caracteresPermitidos.Contains(e.KeyChar) Then
            'AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            'e.Handled = False
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim fila2 = DataGridView1.CurrentRow.Index
        Dim dg2_patid = DataGridView2.Item(0, fila2).Value
        Dim dg2_patnom = DataGridView2.Item(1, fila2).Value

        Dim count = 0
        Abrir()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "registro_count"
        cmd.Parameters.AddWithValue("@pat_id", dg2_patid)
        cmd.Parameters.AddWithValue("@cho_id", "")
        cmd.Parameters.AddWithValue("@lug_id", "")
        dr = cmd.ExecuteReader
        If dr.Read Then
            count = dr("cantidad")
        End If
        Cerrar()
        cmd.Parameters.Clear()

        If count > 0 Then
            MsgBox(dg2_patnom & vbCrLf & " se encuentra en: " &
                       count & " Registro/os" & vbCrLf & vbCrLf &
                       "Si desea eliminar la pantente, elimine todos los registros que la contienen", vbInformation, "AVISO!, PATENTE VINCULADA EN LA TABLA REGISTROS")
            Exit Sub
        End If

        Dim respuesta As Integer
        respuesta = MsgBox("desea eliminar la patente" & vbCrLf & dg2_patnom, vbQuestion + vbYesNo + vbDefaultButton1, "ELIMINAR PATENTE")
        If respuesta = vbYes Then
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "patente_delete"
            cmd.Parameters.AddWithValue("@pat_id", dg2_patid)
            cmd.ExecuteNonQuery()
            Cerrar()
            cmd.Parameters.Clear()

            limpiar(True)
            Titulo()
            mostrar_patente_dg(0, "")
            DataGridView1.ClearSelection()

            If Registro.Visible = True Then
                Registro.mostrar_patente()
            End If
        End If
    End Sub

    Private Sub txt_bus_pat_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_pat.TextChanged
        If (Trim(txt_bus_pat.Text) = "") Then
            Titulo()
            mostrar_patente_dg(0, "")
            DataGridView1.ClearSelection()
            tools_edit(False)
        Else
            ' MsgBox("hila soy loxuas")
            Titulo()
            mostrar_patente_dg(1, Trim(txt_bus_pat.Text))
            If DataGridView1.Rows.Count = 0 Then
                tools_edit(False)
                DataGridView1.ClearSelection()
            Else
                Dim fila As Integer
                txt_patnom_dg1.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
                If (DataGridView1.CurrentRow.Cells(2).Value = "Activo") Then
                    ' MessageBox.Show("jfjfjf")
                    cbo_patest_dg1.SelectedIndex = 0
                Else
                    cbo_patest_dg1.SelectedIndex = 1
                End If

                tools_edit(True)

                fila = DataGridView1.CurrentRow.Index

                DataGridView2.ClearSelection()
                DataGridView2.Rows(fila).Selected = True
            End If
        End If

    End Sub
End Class