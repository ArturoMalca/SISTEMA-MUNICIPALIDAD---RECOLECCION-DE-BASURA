Public Class Registro
    Dim reg_id = 1
    Dim l_patente = "", l_chofer = "", year = "", month = "", nomday = "", day = "", hour = "", minute = ""
    Dim fecha_insertE = ""
    Dim fecha_insertS_ordenada As Date
    Dim fecha_insertE_ordenada As Date

    Dim total_neto = 0
    Dim btn_save = 0

    Dim matrix = ""
    Dim str_ = 0

    Dim check_FA_S_nomday = "" ', yesterday = ""

    Sub mostrar_patente()
        Cbo_patente.Items.Clear()

        Abrir()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT*FROM Patente order by pat_id desc"
        dr = cmd.ExecuteReader
        While dr.Read
            Cbo_patente.Items.Add(dr("pat_nom"))
        End While
        Cerrar()

        If Patente.Visible = True Then
            If Trim(txt_buscarP.Text) = "" And Trim(txt_buscarC.Text) = "" And dt_year_b.Checked = False Then
                titulo_registro()
                mostrar_registro(0, "", "", "", "", "", "", "", "", "")
            Else
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            End If
            If Trim(Patente.txt_patnom_dg1.Text) <> "" Then
                Cbo_patente.SelectedItem = Trim(Patente.txt_patnom_dg1.Text)
            Else
                Cbo_patente.SelectedItem = Trim(Patente.txt_patnom.Text)
            End If
        End If
    End Sub
    Sub mostrar_chofer()
        cbo_chofer.Items.Clear()

        Abrir()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT*FROM v_chofer order by chofer"
        dr = cmd.ExecuteReader
        While dr.Read
            cbo_chofer.Items.Add(dr("chofer"))
        End While
        Cerrar()

        If chofer.Visible = True Then
            If Trim(txt_buscarP.Text) = "" And Trim(txt_buscarC.Text) = "" And dt_year_b.Checked = False Then
                titulo_registro()
                mostrar_registro(0, "", "", "", "", "", "", "", "", "")
            Else
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            End If
            If Trim(chofer.txt_cho_apel.Text) <> "" And Trim(chofer.txt_cho_nom.Text) <> "" Then
                cbo_chofer.Text = Trim(chofer.txt_cho_apel.Text) + " " + Trim(chofer.txt_cho_nom.Text)
                'MsgBox("hola pruebas: " + chofer.txt_cho_apel.Text + " " + chofer.txt_cho_nom.Text)
                ' Else
                ' Cbo_patente.SelectedItem = Trim(Patente.txt_patnom.Text)
            End If
        End If
    End Sub
    Sub mostrar_lugar()
        Cbo_lugar.Items.Clear()
        Abrir()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT*FROM lugar order by lug_nom"
        dr = cmd.ExecuteReader
        While dr.Read
            Cbo_lugar.Items.Add(dr("lug_nom"))
        End While
        Cerrar()
    End Sub
    Sub titulo_lugar()
        dg_lugar.ColumnCount = 0
        dg_lugar.Columns.Add("rec_id", "rec_id")
        dg_lugar.Columns.Add("reg_id", "reg_id")
        dg_lugar.Columns.Add("lugar", "lugar")

        dg_lugar.Columns("rec_id").Visible = False
        dg_lugar.Columns("reg_id").Visible = False
    End Sub
    Sub titulo_lugar_origen()
        dg_lugar_origen.ColumnCount = 0
        dg_lugar_origen.Columns.Add("rec_id", "rec_id")
        dg_lugar_origen.Columns.Add("reg_id", "reg_id")
        dg_lugar_origen.Columns.Add("lugar", "lugar")
    End Sub

    Sub agregar_titulo_lugar(rec_id, reg_id, lugar)
        dg_lugar.Rows.Add(rec_id, reg_id, lugar)
        dg_lugar.ClearSelection()
        btn_quitar_lugar.Visible = False
    End Sub
    Sub obtener_reg_id()
        Abrir()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT TOP 1 reg_id from registro order by reg_id desc"
        dr = cmd.ExecuteReader
        If dr.Read Then
            reg_id = dr("reg_id") + 1
        End If
        Cerrar()
    End Sub
    Sub limpiar()
        Cbo_patente.SelectedIndex = -1
        cbo_chofer.SelectedIndex = -1
        dt_h_insertS.Checked = False
        Cbo_lugar.SelectedIndex = -1
        'dataGridView1.Rows.Clear();
        dg_lugar.Rows.Clear()
    End Sub
    Sub titulo_registro()
        dg_registro.ColumnCount = 0
        dg_registro.Columns.Add("Nº", "Nº")
        dg_registro.Columns.Add("reg_id", "reg_id")
        dg_registro.Columns.Add("Patente", "Patente")
        dg_registro.Columns.Add("Chofer", "chofer")
        dg_registro.Columns.Add("Fecha_Salida", "Fecha Salida")
        dg_registro.Columns.Add("ruta", "ruta")
        dg_registro.Columns.Add("Fecha_Entrada", "Fecha Entrada")
        dg_registro.Columns.Add("Peso_Bruto", "Peso Bruto (tn)")
        dg_registro.Columns.Add("Peso_Tara", "Peso Tara (tn)")
        dg_registro.Columns.Add("Neto", "Neto (tn)")

        dg_registro.Columns("Nº").Width = 28
        dg_registro.Columns("reg_id").Visible = False
        dg_registro.Columns("Patente").Width = 70
        dg_registro.Columns("Chofer").Width = 185
        dg_registro.Columns("Fecha_Salida").Width = 155
        dg_registro.Columns("ruta").Width = 215
        dg_registro.Columns("Fecha_Entrada").Width = 155
        dg_registro.Columns("Peso_Bruto").Width = 45
        dg_registro.Columns("Peso_Tara").Width = 45
        dg_registro.Columns("Neto").Width = 45
    End Sub
    Sub mostrar_dias(valor, dia)
        MessageBox.Show(dia)
        Select Case valor
            Case "Monday"
                dia = "Lunes"
            Case "Tuesday"
                dia = "Martes"
            Case "Wednesday"
                dia = "Miércoles"
            Case "Thursday"
                dia = "Jueves"
            Case "Friday"
                dia = "Viernes"
            Case "Saturday"
                dia = "Sábado"
            Case Else
                dia = "Domingo"
        End Select
    End Sub
    Sub mostrar_registro(cambio, control, patente, chofer, year, month, day, nomday, hour, minute)
        'exec registroS_search 0,'','','2022','05','','sunday','',''
        Dim num = 0
        Dim fecha_salida = ""
        Dim fecha_entrada = ""
        Dim neto = "", peso_bruto = "", peso_tara = ""

        Abrir()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "recorrido_coun"
        dr = cmd.ExecuteReader
        While dr.Read
            If str_ = 0 Then
                matrix = New String(dr("cuenta"), 1) {}
                matrix(0, 0) = dr("rec_reg_id")
                matrix(0, 1) = dr("lug_nom")

                ' MessageBox.Show(str_ & "str-0-")
                str_ += 1
            Else
                ' MessageBox.Show(str_ & "str")
                If dr("rec_reg_id") = matrix(str_ - 1, 0) Then
                    matrix(str_ - 1, 1) = matrix(str_ - 1, 1) + ", " + dr("lug_nom")
                Else
                    matrix(str_, 0) = dr("rec_reg_id")
                    matrix(str_, 1) = dr("lug_nom")
                    str_ += 1
                End If
            End If
        End While
        Cerrar()
        str_ = 0

        If cambio = 0 Then
            total_neto = 0
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select top 20 *from v_registro_s order by reg_fecs desc"
            dr = cmd.ExecuteReader
            While dr.Read
                Dim valor = dr("fecs_nomday")
                Dim dia = ""
                Dim valor1 = dr("fece_nomday")
                Dim dia1 = ""

                Select Case valor
                    Case "Monday"
                        dia = "Lunes"
                    Case "Tuesday"
                        dia = "Martes"
                    Case "Wednesday"
                        dia = "Miércoles"
                    Case "Thursday"
                        dia = "Jueves"
                    Case "Friday"
                        dia = "Viernes"
                    Case "Saturday"
                        dia = "Sábado"
                    Case Else
                        dia = "Domingo"
                End Select

                Select Case valor1
                    Case "Monday"
                        dia1 = "Lunes"
                    Case "Tuesday"
                        dia1 = "Martes"
                    Case "Wednesday"
                        dia1 = "Miércoles"
                    Case "Thursday"
                        dia1 = "Jueves"
                    Case "Friday"
                        dia1 = "Viernes"
                    Case "Saturday"
                        dia1 = "Sábado"
                    Case Else
                        dia1 = "Domingo"
                End Select

                ' If dr("fecs_h") = "00" And dr("fecs_min") = "00" Then
                'fecha_salida = dia + " " + dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y")
                ' Else
                fecha_salida = dia + " " + dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y") + " " + dr("fecs_h") + ":" + dr("fecs_min")
                'End If
                ' MessageBox.Show(dr("fece_y"))
                If dr("fece_y") = "1900" Then
                    fecha_entrada = ""
                    neto = ""
                    peso_bruto = ""
                    peso_tara = ""
                Else
                    neto = Math.Round((Val(dr("pesobruto")) - Val(dr("pesotara"))) / 1000, 1)
                    fecha_entrada = dia1 + " " + dr("fece_d") + "-" + dr("fece_m") + "-" + dr("fece_y") + " " + dr("fece_h") + ":" + dr("fece_min")
                    peso_bruto = Math.Round(Val(dr("pesobruto")) / 1000, 1)
                    peso_tara = Math.Round(Val(dr("pesotara")) / 1000, 1)
                End If

                num += 1
                If neto <> "" Then
                    total_neto += neto
                End If
                dg_registro.Rows.Add(num, dr("reg_id"), dr("pat_nom"), dr("chofer"), fecha_salida, matrix(str_, 1), fecha_entrada, peso_bruto, peso_tara, neto)
                str_ += 1
            End While
            Cerrar()
            ' If Check_edicion.Checked = False Then
            dg_registro.ClearSelection()
            ' End If
            lbl_total_neto.Text = "Total Neto (tn) = " & Math.Round(total_neto, 1)
            str_ = 0
        Else
            total_neto = 0

            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registroS_search"
            cmd.Parameters.AddWithValue("@control", control)
            cmd.Parameters.AddWithValue("@patente", patente)
            cmd.Parameters.AddWithValue("@chofer", chofer)
            cmd.Parameters.AddWithValue("@fec_y", year)
            cmd.Parameters.AddWithValue("@fec_m", month)
            cmd.Parameters.AddWithValue("@fec_d", day)
            cmd.Parameters.AddWithValue("@fec_nomday", nomday)
            cmd.Parameters.AddWithValue("@fec_h", hour)
            cmd.Parameters.AddWithValue("@fec_min", minute)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim valor = dr("fecs_nomday")
                Dim dia = ""

                Dim valor1 = dr("fece_nomday")
                Dim dia1 = ""

                Select Case valor
                    Case "Monday"
                        dia = "Lunes"
                    Case "Tuesday"
                        dia = "Martes"
                    Case "Wednesday"
                        dia = "Miércoles"
                    Case "Thursday"
                        dia = "Jueves"
                    Case "Friday"
                        dia = "Viernes"
                    Case "Saturday"
                        dia = "Sábado"
                    Case Else
                        dia = "Domingo"
                End Select

                Select Case valor1
                    Case "Monday"
                        dia1 = "Lunes"
                    Case "Tuesday"
                        dia1 = "Martes"
                    Case "Wednesday"
                        dia1 = "Miércoles"
                    Case "Thursday"
                        dia1 = "Jueves"
                    Case "Friday"
                        dia1 = "Viernes"
                    Case "Saturday"
                        dia1 = "Sábado"
                    Case Else
                        dia1 = "Domingo"
                End Select
                'mostrar_dias(dr("fecs_nomday"), nom_day_s)
                'mostrar_dias(dr("fece_nomday"), nom_day_e)

                'If dr("fecs_h") = "00" And dr("fecs_min") = "00" Then
                'fecha_salida = dia + " " + dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y")
                'Else
                fecha_salida = dia + " " + dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y") + " " + dr("fecs_h") + ":" + dr("fecs_min")
                'End If

                If dr("fece_y") <> "1900" Then
                    fecha_entrada = dia1 + " " + dr("fece_d") + "-" + dr("fece_m") + "-" + dr("fece_y") + " " + dr("fece_h") + ":" + dr("fece_min")
                    neto = Math.Round((Val(dr("pesobruto")) - Val(dr("pesotara"))) / 1000, 1)
                    peso_bruto = Math.Round(Val(dr("pesobruto")) / 1000, 1)
                    peso_tara = Math.Round(Val(dr("pesotara")) / 1000, 1)

                Else
                    neto = ""
                    peso_bruto = ""
                    peso_tara = ""
                    fecha_entrada = ""
                End If

                num += 1
                total_neto += Val(neto)
                dg_registro.Rows.Add(num, dr("reg_id"), dr("pat_nom"), dr("chofer"), fecha_salida, matrix(str_, 1), fecha_entrada, peso_bruto, peso_tara, neto)
                str_ += 1
            End While
            Cerrar()
            cmd.Parameters.Clear()
            lbl_total_neto.Text = "Total Neto (tn) = " & Math.Round(total_neto, 1)
            str_ = 0
        End If
    End Sub
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_patente()
        mostrar_chofer()
        mostrar_lugar()

        titulo_lugar()
        titulo_lugar_origen()

        titulo_registro()
        mostrar_registro(0, "", "", "", "", "", "", "", "", "")

        ' MessageBox.Show(Date.Now)
    End Sub

    Private Sub btn_lugar_Click(sender As Object, e As EventArgs) Handles btn_lugar.Click
        Lugar.Show()
    End Sub

    Private Sub btn_quitar_lugar_Click(sender As Object, e As EventArgs) Handles btn_quitar_lugar.Click

        If dg_lugar.Rows.Count > 0 Then
            Dim question = MsgBox("Desea quitar a:" + dg_lugar.Item(2, dg_lugar.CurrentRow.Index).Value, vbYesNo Or vbQuestion, "Quitar lugar")
            If question = vbYes Then
                dg_lugar.Rows.Remove(dg_lugar.CurrentRow)
                Cbo_lugar.SelectedIndex = -1
                dg_lugar.ClearSelection()
            End If
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Cbo_patente.SelectedIndex = -1 Then
            If Check_edicion.Checked = False Then
                MsgBox("seleccionar patente", vbInformation, "Patente Vacía")
                Cbo_patente.SelectedIndex = 0
                Exit Sub
            Else
                MsgBox("seleccionar patente para actualizar", vbInformation, "Patente Vacía")
                'Cbo_patente.SelectedIndex = 0
                Exit Sub
            End If
        Else
            If cbo_chofer.SelectedIndex = -1 Then
                If Check_edicion.Checked = False Then
                    MsgBox("seleccionar chofer", vbInformation, "Chofer Vacío")
                    cbo_chofer.SelectedIndex = 0
                    Exit Sub
                Else
                    MsgBox("seleccionar chofer para actualizar", vbInformation, "Chofer Vacío")
                    'cbo_chofer.SelectedIndex = 0
                    Exit Sub
                End If
            Else
                If dg_lugar.Rows.Count = 0 Then
                    If Check_edicion.Checked = False Then
                        MsgBox("asignar lugar a ruta", vbInformation, "Ruta vacía")
                        Cbo_lugar.Focus()
                        Exit Sub
                    Else
                        MsgBox("asignar lugar a ruta al actualizar", vbInformation, "Ruta vacía")
                        Cbo_lugar.Focus()
                        Exit Sub
                    End If
                End If
            End If
        End If

        Dim fecha_insert = ""
        If Check_tomarFS.Checked = False Then
            fecha_insert = Format(dt_fecha_insertS.Value, "yyyy-MM-dd")
            If dt_h_insertS.Checked = True Then
                fecha_insert = fecha_insert + " " + Format(dt_h_insertS.Value, "HH:mm")
            End If

            If dt_h_insertS.Enabled = True Then
                If dt_h_insertS.Checked = False Then
                    MsgBox("Recuerde ingresar Hora de Salida", vbInformation, "Hora de salida, vacía")
                    dt_h_insertS.Focus()
                    Exit Sub
                End If
            End If

            fecha_insertS_ordenada = Format(dt_fecha_insertS.Value, "dd-MM-yyyy") + " " + Format(dt_h_insertS.Value, "HH:mm")
            If fecha_insertS_ordenada > Date.Now.AddMonths(1) Then
                'MsgBox(fecha_insertS_ordenada)
                'MsgBox(Date.Now)
                MsgBox("La fecha de salida, no puede superar, un mes después a la fecha actual" & vbCrLf & vbCrLf &
                       " - FECHA PERMITIDA, HASTA: " & Date.Now.AddMonths(1), vbInformation, "FECHA DE SALIDA, EXCEDE LO PERMITIDO")
                Exit Sub
            End If
        End If

            'MessageBox.Show(fecha_insert)
            'Exit Sub
            obtener_reg_id()
        'MessageBox.Show(reg_id)

        If Check_edicion.Checked = False Then
            'MessageBox.Show(fecha_insert)
            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registroS_insert"
            cmd.Parameters.AddWithValue("@reg_id", reg_id)
            cmd.Parameters.AddWithValue("@patente", Cbo_patente.SelectedItem)
            cmd.Parameters.AddWithValue("@chofer", cbo_chofer.SelectedItem)
            cmd.Parameters.AddWithValue("@fecha", fecha_insert)
            cmd.ExecuteNonQuery()
            Cerrar()
            cmd.Parameters.Clear()

            For i = 0 To dg_lugar.Rows.Count - 1
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "recorrido_insert"
                cmd.Parameters.AddWithValue("@reg_id", reg_id)
                cmd.Parameters.AddWithValue("@lugar", dg_lugar.Item(2, i).Value)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()
            Next
            MsgBox("Registro almacenado correctamente", vbInformation, "Guardar registro")
            limpiar()
            titulo_registro()
            mostrar_registro(0, "", "", "", "", "", "", "", "", "")

        Else
            Dim dg_reg_id As Integer = Val(dg_registro.CurrentRow.Cells(1).Value)
            Dim dg_cbo_patente = Cbo_patente.SelectedItem
            Dim dg_cbo_chofer = cbo_chofer.SelectedItem
            Dim cambios = 0

            If dg_registro.SelectedRows.Count = 0 Then
                MsgBox("Seleccionar con CLICK una fila de registro, para editar el contenido de la misma", vbInformation, "Actualizar registro")
                Exit Sub
            End If

            Dim diferencia = 0
            Dim obten_fecha = 0
            For i = 0 To dg_lugar.Rows.Count - 1
                If dg_lugar.Item(0, i).Value = -1 Then
                    diferencia += 1
                End If
            Next
            If dg_lugar_origen.Rows.Count > dg_lugar.Rows.Count Then
                diferencia = 1
            End If


            If dt_fecha_insertS.Value <> dt_h_insertS.Value Then
                'MessageBox.Show(Format(dt_fecha_insertS.Value, "dd-MM-yyyy HH:mm"))
                'MessageBox.Show(Format(dt_h_insertS.Value, "dd-MM-yyyy HH:mm"))
                obten_fecha += 1
            End If
            'MessageBox.Show(obten_fecha)

            If dg_cbo_patente = dg_registro.CurrentRow.Cells(2).Value And dg_cbo_chofer = dg_registro.CurrentRow.Cells(3).Value And obten_fecha = 0 And diferencia = 0 And Check_tomarFS.Checked = False Then
                'MsgBox("No se realizaron cambios-----", vbInformation, "Actualizar registro")
                'Exit Sub
                cambios = 0
            Else

                If dg_cbo_patente = dg_registro.CurrentRow.Cells(2).Value Then
                    dg_cbo_patente = ""
                End If
                If dg_cbo_chofer = dg_registro.CurrentRow.Cells(3).Value Then
                    dg_cbo_chofer = ""
                End If

                'MessageBox.Show(fecha_insert)

                'MessageBox.Show(" " + dg_cbo_patente + " " + dg_cbo_chofer + " " + fecha_insert)
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "registroS_update"
                cmd.Parameters.AddWithValue("@reg_id", dg_reg_id)
                cmd.Parameters.AddWithValue("@patente", dg_cbo_patente)
                cmd.Parameters.AddWithValue("@chofer", dg_cbo_chofer)
                cmd.Parameters.AddWithValue("@fecha", fecha_insert)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()

                Dim array_val_add(diferencia)
                Dim aviso = 0, num = 0, indice = 0
                For i = 0 To dg_lugar_origen.Rows.Count - 1

                    If dg_lugar_origen.Rows.Count = dg_lugar.Rows.Count Then
                        rec_query(0, dg_lugar_origen.Item(0, i).Value, 0, dg_lugar.Item(2, i).Value)
                    End If

                    If dg_lugar_origen.Rows.Count < dg_lugar.Rows.Count Then
                        rec_query(0, dg_lugar_origen.Item(0, i).Value, 0, dg_lugar.Item(2, i).Value)

                        If i = dg_lugar_origen.Rows.Count - 1 Then
                            If i = 0 Then
                                i = 1
                            End If
                            For a = i To dg_lugar.Rows.Count - 1
                                rec_query(1, 0, dg_registro.CurrentRow.Cells(1).Value, dg_lugar.Item(2, a).Value)
                            Next
                        End If
                    End If

                    If dg_lugar_origen.Rows.Count > dg_lugar.Rows.Count Then
                        If i <= dg_lugar.Rows.Count - 1 Then
                            rec_query(0, dg_lugar_origen.Item(0, i).Value, 0, dg_lugar.Item(2, i).Value)
                        Else
                            rec_query(2, dg_lugar_origen.Item(0, i).Value, 0, "")
                        End If
                    End If

                Next
                cambios += 1
            End If
            '--------------------------------------------------------------------------------
            Dim cambios1 = 0
            If Trim(txt_bruto_RE.Text) <> "" Or dt_hora_RE.Checked = True Or check_tomarFA_RE.Checked = True Then
                Dim fecha_salida_format As Date = Format(dt_fecha_insertS.Value, "dd-MM-yyyy") + " " + Format(dt_h_insertS.Value, "HH:mm")
                Dim fecha_entrada_format As Date = Format(dt_fecha_RE.Value, "dd-MM-yyyy") + " " + Format(dt_hora_RE.Value, "HH:mm")

                If check_tomarFA_RE.Checked = False Then
                    fecha_insertE = Format(dt_fecha_RE.Value, "yyyy-MM-dd")
                    If dt_hora_RE.Checked = True Then
                        fecha_insertE = fecha_insertE + " " + Format(dt_hora_RE.Value, "HH:mm")
                    End If

                    fecha_insertE_ordenada = Format(dt_fecha_RE.Value, "dd-MM-yyyy") + " " + Format(dt_hora_RE.Value, "HH:mm")
                    If fecha_insertE_ordenada > fecha_salida_format.AddMonths(1) Then
                        MsgBox("La fecha de entrada, no puede superar un mes a la fecha actual" & vbCrLf & vbCrLf &
                               " - FECHA PERMITIDA, HASTA: " & fecha_salida_format.AddMonths(1), vbInformation, "FECHA DE ENTRADA, EXCEDE LO PERMITIDO")
                        Exit Sub
                    End If
                End If

                If Trim(txt_bruto_RE.Text) = "" Then
                    MsgBox("Ingresar peso en bruto en registro de Entrada", vbInformation, "peso en bruto en registro de Entrada, vacío")
                    txt_bruto_RE.Focus()
                    Exit Sub
                Else
                    If Trim(txt_tara_RE.Text) = "" Then
                        MsgBox("Ingresar peso tara en registro de Entrada", vbInformation, "peso tara en registro de Entrada, vacío")
                        txt_tara_RE.Focus()
                        Exit Sub
                        'Else
                        'If dt_hora_RE.Enabled = True Then
                        'If dt_hora_RE.Checked = False Then
                        'MsgBox("Recuerde ingresar Hora de Entrada", vbInformation, "Hora de Entrada, vacía")
                        'dt_hora_RE.Focus()
                        'Exit Sub
                        'End If
                        'End If
                    End If
                End If

                If (Val(txt_bruto_RE.Text) < 2000) Then
                    MsgBox("El peso en bruto debe tener como mínimo 2000 kg", vbInformation, "AUMENTAR PESO EN BRUTO")
                    Exit Sub
                End If
                If (Val(txt_tara_RE.Text) < 1000) Then
                    MsgBox("El peso de la tara debe tener como mínimo 1000 kg", vbInformation, "AUMENTAR PESO EN TARA")
                    Exit Sub
                End If

                If Val(txt_bruto_RE.Text) <= Val(txt_tara_RE.Text) Then
                    MsgBox("El peso bruto debe ser mayor al peso de la tara", vbCritical, "AUMENTAR PESO BRUTO")
                    txt_bruto_RE.Focus()
                    Exit Sub
                End If
                'If txt_bruto_RE.Text <> "" Then
                ' If check_tomarFA_RE.Checked = False Then
                If dt_hora_RE.Enabled = True Then
                    If dt_hora_RE.Checked = False Then
                        MsgBox("Recuerde ingresar Hora de Entrada", vbInformation, "Hora de Entrada, vacía")
                        dt_hora_RE.Focus()
                        Exit Sub
                    End If
                End If
                ' End If

                If check_tomarFA_RE.Checked = True Then
                    If fecha_salida_format.AddMinutes(30) > Date.Now Then
                        MsgBox("LA FECHA DE ENTRADA DEBE SER MAYOR A LA FECHA DE SALIDA:" & vbCrLf &
                               " Mínimo 30 minutos", vbInformation, "AUMENTAR FECHA ENTRADA")
                        Exit Sub
                    End If
                Else
                    If fecha_salida_format.AddMinutes(30) > fecha_entrada_format Then
                        MsgBox("LA FECHA DE ENTRADA DEBE SER MAYOR A LA FECHA DE SALIDA:" & vbCrLf &
                               " Mínimo 30 minutos", vbInformation, "AUMENTAR FECHA ENTRADA")
                        Exit Sub
                    End If
                End If

                'End If
                '-------------------------------------------------------------------------------------------------
                If dt_fecha_RE.Value = dt_hora_RE.Value And Trim(txt_bruto_RE.Text) = dg_registro.CurrentRow.Cells(6).Value And Trim(txt_tara_RE.Text) = dg_registro.CurrentRow.Cells(7).Value And check_tomarFA_RE.Checked = False Then
                    cambios1 = 0
                    'If check_tomarFA_RE.Checked = True Then
                    'cambios1 += 1
                    'End If
                Else
                    'MsgBox(fecha_insertE + "hohohoho")
                    Abrir()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "registroE_update"
                    cmd.Parameters.AddWithValue("@reg_id", dg_registro.CurrentRow.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@fecha", fecha_insertE)
                    cmd.Parameters.AddWithValue("@pesb", txt_bruto_RE.Text)
                    cmd.Parameters.AddWithValue("@pest", txt_tara_RE.Text)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    cmd.Parameters.Clear()
                    cambios1 += 1
                End If

            End If
            '----------------------------------------------------------------------------------------


            If cambios > 0 Or cambios1 > 0 Then
                MsgBox("Se realizaron cambios", vbInformation, "Actualizar registro")

                If Trim(txt_buscarP.Text) = "" And Trim(txt_buscarC.Text) = "" And dt_year_b.Checked = False Then
                    titulo_registro()
                    mostrar_registro(0, "", "", "", "", "", "", "", "", "")
                    'valores_búsqueda(Cbo_patente.SelectedItem, cbo_chofer.SelectedItem, dt_fecha_insertS.Value.Year, dt_fecha_insertS.Value.Month, dt_fecha_insertS.Value.Day, "", dt_h_insertS.Value.Hour, dt_h_insertS.Value.Minute)
                Else
                    btn_save = 1
                    valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                    btn_save = 0
                End If

                For c = 0 To dg_registro.Rows.Count - 1
                    If Mid(Microsoft.VisualBasic.Right(dg_registro.Item(4, c).Value, 16), 1, 10) = Format(dt_fecha_insertS.Value, "dd-MM-yyyy") And Microsoft.VisualBasic.Right(dg_registro.Item(4, c).Value, 5) = Format(dt_h_insertS.Value, "HH:mm") Then
                        dg_registro.Rows(c).Selected = True
                        Exit For
                    End If
                Next

                limpiar()
                limpiar_botones_entrada()
                botones_entrada(False)
            Else
                MsgBox("No se realizaron cambios", vbInformation, "Actualizar registro")

                'titulo_registro()
                'titulo_registro()
                'Dim fec_y = "", fec_m = "", fec_d = "", fec_h=""

                limpiar()
                limpiar_botones_entrada()
                botones_entrada(False)

            End If

        End If
    End Sub

    Private Sub Cbo_lugar_Click(sender As Object, e As EventArgs) Handles Cbo_lugar.Click
        Dim dg_lug_rec_id = -1

        If Cbo_lugar.SelectedIndex > -1 Then
            'MessageBox.Show(dg_lugar.Rows.Count)
            If dg_lugar.Rows.Count > 0 Then
                For i = 0 To dg_lugar.Rows.Count - 1
                    If dg_lugar.Item(2, i).Value = Cbo_lugar.SelectedItem Then
                        MsgBox(Cbo_lugar.SelectedItem + " ya se encuentra asignado, ingrese un lugar diferente", vbInformation, "AGREGAR LUGAR")
                        Cbo_lugar.SelectedIndex = -1
                        Exit Sub
                    End If
                Next
            End If

            If Check_edicion.Checked = True Then
                If dg_registro.SelectedRows.Count = 0 Or Panel2.Enabled = False Then
                    MsgBox("aplicar CLICK sobre la fila selecciona en la tabla de REGISTRO, para editar", vbInformation, "SELECCIONAR CON CLICK PARA EDICIÓN")
                    Exit Sub
                End If
                For i = 0 To dg_lugar_origen.Rows.Count - 1

                    If dg_lugar_origen.Item(2, i).Value = Cbo_lugar.SelectedItem Then
                        'MessageBox.Show("tú ya estás")
                        dg_lug_rec_id = 0
                    End If

                Next
            End If

            agregar_titulo_lugar(dg_lug_rec_id, -1, Cbo_lugar.SelectedItem)
            Cbo_lugar.SelectedIndex = -1
        End If
    End Sub

    Private Sub Check_tomarFS_CheckedChanged(sender As Object, e As EventArgs) Handles Check_tomarFS.CheckedChanged
        If Check_tomarFS.Checked = True Then
            dt_fecha_insertS.Enabled = False
            dt_h_insertS.Checked = False
            dt_h_insertS.Enabled = False

            'MsgBox(CDate(Date.Now).ToString("dddd"))
            If dt_fecha_insertS.Checked = True Then

                If Check_edicion.Checked = False Then

                    If Cbo_patente.SelectedItem <> "LBVZ-11" Then 'Or Cbo_patente.SelectedItem <> "HRGV-54" Then
                        'MsgBox("diferencia")
                        dg_lugar.Rows.Clear()
                        'Exit Sub
                        If Cbo_patente.SelectedItem <> "HRGV-54" Then
                            'MsgBox("diferencia")
                            dg_lugar.Rows.Clear()
                            Exit Sub
                        End If
                    End If

                    Dim j = 0
                    Select Case CDate(Date.Now).ToString("dddd")
                        Case "lunes"
                            If Cbo_patente.SelectedItem = "LBVZ-11" Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Paredones"}}

                            ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                            End If

                        Case "martes"
                            j = 3
                            If Cbo_patente.SelectedItem = "LBVZ-11" Then
                                check_FA_S_nomday = New String(3, 2) {{-1, -1, "El Cardal"}, {-1, -1, "El Peral"},
                                {-1, -1, "Los Briones"}, {-1, -1, "Panilongo"}}

                            ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then

                                check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Queseria"},
                                    {-1, -1, "San Francisco"}, {-1, -1, "Cabeceras"}, {-1, -1, "Bucalemu"}}
                            End If

                        Case "miércoles"
                            If Cbo_patente.SelectedItem = "LBVZ-11" Then
                                j = 2
                                check_FA_S_nomday = New String(2, 2) {{-1, -1, "Paredones"}, {-1, -1, "El Casuto"},
                                {-1, -1, "La Población"}}

                            ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                                j = 7
                                check_FA_S_nomday = New String(7, 2) {{-1, -1, "Los Romeros"},
                                    {-1, -1, "San Pedro de Alcantara"}, {-1, -1, "El Berdigadero"},
                                {-1, -1, "Las Papas"}, {-1, -1, "Carizarillo"}, {-1, -1, "Los Barros"},
                                {-1, -1, "Cutemu"}, {-1, -1, "La Huertilla"}}

                            End If

                        Case "jueves"
                            If Cbo_patente.SelectedItem = "LBVZ-11" Then
                                j = 6
                                'MsgBox(j & "valor jueves")
                                check_FA_S_nomday = New String(6, 2) {{-1, -1, "El Calvario"}, {-1, -1, "Querelema"},
                                {-1, -1, "Las Viñas"}, {-1, -1, "El Rincon de las Viñas"}, {-1, -1, "El Quillay"},
                                {-1, -1, "La Ligua"}, {-1, -1, "Cabeceras"}}

                            ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                                j = 3
                                check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Capilla"},
                                    {-1, -1, "Rincón de Boyeruca"}, {-1, -1, "Lo Valdivia"}, {-1, -1, "Bucalemu"}}
                            End If

                        Case "viernes"
                            If Cbo_patente.SelectedItem = "LBVZ-11" Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                            ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                            End If

                        Case "sábado"
                            If Cbo_patente.SelectedItem = "LBVZ-11" And Date.Now.Month < 3 Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                                'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            Else
                                dg_lugar.Rows.Clear()
                                Exit Sub
                            End If

                        Case Else
                            If Cbo_patente.SelectedItem = "LBVZ-11" And Date.Now.Month < 3 Then
                                check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                                'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            Else
                                dg_lugar.Rows.Clear()
                                Exit Sub
                            End If
                    End Select


                    If (CDate(dt_fecha_insertS.Value).ToString("dddd") = "domingo" Or
                        CDate(dt_fecha_insertS.Value).ToString("dddd") = "sábado") And Date.Now.Month > 2 Then
                        'MsgBox(Date.Now.Month)
                        dg_lugar.Rows.Clear()
                        'dg_lugar.Rows.Remove(dg_lugar.CurrentRow)
                        Exit Sub
                    End If

                    'Dim f
                    'Dim gara
                    titulo_lugar()
                    For f = 0 To j
                        'gara = 0
                        'If dg_lugar.Rows.Count > 0 Then
                        'For g = 0 To dg_lugar.Rows.Count - 1
                        'If dg_lugar.Item(2, g).Value = check_FA_S_nomday(f, 2) Then
                        'gara = 1
                        'End If
                        'Next
                        'End If

                        'If gara = 0 Then
                        dg_lugar.Rows.Add(check_FA_S_nomday(f, 0), check_FA_S_nomday(f, 1), check_FA_S_nomday(f, 2))
                        'End If
                        'MsgBox(f)
                    Next
                    dg_lugar.ClearSelection()
                End If


                'check_FA_S_nomday = ""
                'MsgBox(f)
            End If

            'MsgBox(f)
        Else
            dt_fecha_insertS.Enabled = True
            dt_h_insertS.Enabled = True

            If Check_edicion.Checked = False Then
                If Cbo_patente.SelectedItem <> "LBVZ-11" Or Cbo_patente.SelectedItem <> "HRGV-54" Then
                    dg_lugar.Rows.Clear()
                End If
            End If

        End If
    End Sub

    Private Sub txt_buscarP_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarP.KeyUp
        If Trim(txt_buscarP.Text) = "" Then
            If Trim(txt_buscarC.Text) <> "" Or dt_year_b.Checked = True Then
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                Exit Sub
            End If
            titulo_registro()
            mostrar_registro(0, "", "", "", "", "", "", "", "", "")
        Else
            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)

            If dg_registro.Rows.Count = 0 Then
                MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
                txt_buscarP.Clear()
            End If
        End If
    End Sub

    Private Sub txt_buscarC_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscarC.KeyUp
        If Trim(txt_buscarC.Text) = "" Then
            If Trim(txt_buscarP.Text) <> "" Or dt_year_b.Checked = True Then
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                Exit Sub
            End If
            titulo_registro()
            mostrar_registro(0, "", "", "", "", "", "", "", "", "")
        Else
            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)

            If dg_registro.Rows.Count = 0 Then
                MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
                txt_buscarC.Clear()
            End If
        End If

    End Sub

    Private Sub dt_year_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_year_b.ValueChanged
        If dt_year_b.Checked = True Then
            dt_month_b.Enabled = True

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            If dg_registro.Rows.Count = 0 Then
                'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")

                If Trim(txt_buscarP.Text) <> "" Or Trim(txt_buscarC.Text) <> "" Then
                    valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                    Exit Sub
                End If
                'titulo_registro()
                ' mostrar_registro(0, "", "", "", "", "", "", "", "", "")
            End If

        Else
            dt_month_b.Checked = False
            dt_month_b.Enabled = False
            dt_day_b.Checked = False
            dt_day_b.Enabled = False

            Check_nom_day_b.Checked = False
            Check_nom_day_b.Enabled = False

            dt_hour_b.Checked = False
            dt_hour_b.Enabled = False
            dt_minute_b.Checked = False
            dt_minute_b.Enabled = False

            If Trim(txt_buscarP.Text) <> "" Or Trim(txt_buscarC.Text) <> "" Then
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                Exit Sub
            End If
            titulo_registro()
            mostrar_registro(0, "", "", "", "", "", "", "", "", "")
        End If
    End Sub

    Private Sub dt_month_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_month_b.ValueChanged
        If dt_month_b.Checked = True Then
            dt_day_b.Enabled = True
            Check_nom_day_b.Enabled = True

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            'If dg_registro.Rows.Count = 0 Then
            'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
            'End If
        Else
            dt_day_b.Checked = False
            dt_day_b.Enabled = False

            Check_nom_day_b.Checked = False
            Check_nom_day_b.Enabled = False

            dt_hour_b.Checked = False
            dt_hour_b.Enabled = False
            dt_minute_b.Checked = False
            dt_minute_b.Enabled = False

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            'titulo_registro()
            'mostrar_registro(0, "", "", "", "", "", "", "", "", "")
        End If
    End Sub

    Private Sub dt_day_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_day_b.ValueChanged
        If dt_day_b.Checked = True Then
            dt_hour_b.Enabled = True
            Check_nom_day_b.Checked = False

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            'If dg_registro.Rows.Count = 0 Then
            'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
            'End If

        Else
            dt_hour_b.Checked = False
            dt_hour_b.Enabled = False
            dt_minute_b.Checked = False
            dt_minute_b.Enabled = False

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
        End If
    End Sub

    Private Sub dt_hour_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_hour_b.ValueChanged
        If dt_hour_b.Checked = True Then
            dt_minute_b.Enabled = True

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            ' If dg_registro.Rows.Count = 0 Then
            'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
            'End If
        Else
            dt_minute_b.Checked = False
            dt_minute_b.Enabled = False

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
        End If
    End Sub

    Private Sub dt_minute_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_minute_b.ValueChanged
        If dt_minute_b.Checked = True Then

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            'If dg_registro.Rows.Count = 0 Then
            'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
            'End If
        Else
            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
        End If
    End Sub

    Private Sub dg_registro_Click(sender As Object, e As EventArgs) Handles dg_registro.Click
        If Check_edicion.Checked = True Then
            mostrar_registro_editar()
        End If
    End Sub

    Private Sub dg_lugar_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dg_lugar.RowsRemoved
        ' MessageBox.Show("hhhh")
        btn_quitar_lugar.Visible = False
    End Sub

    Private Sub dg_lugar_Click(sender As Object, e As EventArgs) Handles dg_lugar.Click
        If dg_lugar.SelectedRows.Count > 0 Then
            btn_quitar_lugar.Visible = True
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
        If Check_edicion.Checked = True Then
            limpiar_botones_entrada()
            botones_entrada(False)
            If Trim(txt_buscarP.Text) = "" And Trim(txt_buscarC.Text) = "" And dt_year_b.Checked = False Then
                dg_registro.ClearSelection()
            End If
        End If

    End Sub

    Private Sub Check_edicion_CheckedChanged(sender As Object, e As EventArgs) Handles Check_edicion.CheckedChanged
        If Check_edicion.Checked = True Then
            limpiar()
            mostrar_registro_editar()
            'dg_registro.ClearSelection()
        Else
            limpiar()
            'dg_registro.ClearSelection()
            limpiar_controles_búsqueda()
            limpiar_botones_entrada()
            botones_entrada(False)
            titulo_registro()
            mostrar_registro(0, "", "", "", "", "", "", "", "", "")

            Check_tomarFS.Enabled = True
            dt_fecha_insertS.Enabled = True
            dt_h_insertS.Enabled = True
        End If
    End Sub

    Private Sub Check_nom_day_b_CheckedChanged(sender As Object, e As EventArgs) Handles Check_nom_day_b.CheckedChanged
        If Check_nom_day_b.Checked = True Then
            dt_day_b.Checked = False
            'dt_day_b.Enabled = False
            Cbo_nom_day_b.Enabled = True
        Else
            Cbo_nom_day_b.SelectedIndex = -1
            Cbo_nom_day_b.Enabled = False
            'dt_day_b.Enabled = True
            'Check_nom_day_b.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)
        If dt_year_b.Checked = True Then
            Dim year = Format(dt_year_b.Value, "yyyy")
            'MessageBox.Show(year)
            Dim month = "", nomday = "", day = "", hour = "", minute = ""
            If dt_month_b.Checked = True Then
                month = Format(dt_month_b.Value, "MM")
                'MessageBox.Show(month)
            End If

            If dt_day_b.Checked = True Then
                day = Format(dt_day_b.Value, "dd")
                'MessageBox.Show(day)
            End If
            If Check_nom_day_b.Checked = True Then
                If Cbo_nom_day_b.SelectedIndex = -1 Then
                    MsgBox("Seleccionar nombre de Día a buscar", vbInformation, "Nombre día, no seleccionada")
                    Cbo_nom_day_b.Focus()
                    Exit Sub
                End If
                Dim dia = ""
                Select Case Trim(Cbo_nom_day_b.Text)
                    Case "Lunes"
                        dia = "Monday"
                    Case "Martes"
                        dia = "Tuesday"
                    Case "Miércoles"
                        dia = "Wednesday"
                    Case "Jueves"
                        dia = "Thursday"
                    Case "Viernes"
                        dia = "Friday"
                    Case "Sábado"
                        dia = "Saturday"
                    Case Else
                        dia = "Sunday"
                End Select
                nomday = dia
                '.Show(nomday)
            End If
            If dt_hour_b.Checked = True Then
                hour = Format(dt_hour_b.Value, "HH")
                'MessageBox.Show(hour)
            End If
            If dt_minute_b.Checked = True Then
                minute = Format(dt_minute_b.Value, "mm")
                'MessageBox.Show(minute)
            End If
            'MsgBox("hola?")
            titulo_registro()
            mostrar_registro(1, 0, Trim(txt_buscarP.Text), Trim(txt_buscarC.Text), year, month, day, nomday, hour, minute)
            'exec registroS_search 0,'','','2022','05','','sunday','',''
            If dg_registro.Rows.Count = 0 Then
                MsgBox("El valor búscado no se encuentra registrado", vbInformation, "sin resultados con datos de Búsqueda")

                titulo_registro()
                mostrar_registro(0, 0, "", "", "", "", "", "", "", "")
            End If
        Else
            MsgBox("Seleccione fecha para incluir en la búsqueda", vbInformation, "Búsquedas con fechas")
        End If
    End Sub
    Sub limpiar_controles_búsqueda()
        If Trim(txt_buscarP.Text) <> "" Or Trim(txt_buscarC.Text) <> "" Or dt_year_b.Checked = True Then
            txt_buscarP.Clear()
            txt_buscarC.Clear()

            dt_year_b.Checked = False

            dt_month_b.Checked = False
            dt_month_b.Enabled = False

            dt_day_b.Checked = False
            dt_day_b.Enabled = False

            Check_nom_day_b.Checked = False
            Check_nom_day_b.Enabled = False

            dt_hour_b.Checked = False
            dt_hour_b.Enabled = False

            dt_minute_b.Checked = False
            dt_minute_b.Enabled = False

        End If
    End Sub

    Private Sub check_tomarFA_RE_CheckedChanged(sender As Object, e As EventArgs) Handles check_tomarFA_RE.CheckedChanged
        If check_tomarFA_RE.Checked = True Then
            dt_fecha_RE.Enabled = False
            dt_hora_RE.Checked = False
            dt_hora_RE.Enabled = False
        Else
            dt_fecha_RE.Enabled = True
            dt_hora_RE.Enabled = True
        End If
    End Sub

    Private Sub btn_limpiar_RE_Click(sender As Object, e As EventArgs) Handles btn_limpiar_RE.Click
        limpiar_botones_entrada()
    End Sub

    Private Sub Cbo_patente_MouseHover(sender As Object, e As EventArgs) Handles Cbo_patente.MouseHover
        If Check_edicion.Checked = True Then
            If dg_registro.SelectedRows.Count = 0 Or dg_lugar.Rows.Count = 0 Then
                MsgBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cbo_chofer_MouseHover(sender As Object, e As EventArgs) Handles cbo_chofer.MouseHover
        If Check_edicion.Checked = True Then
            If dg_registro.SelectedRows.Count = 0 Or dg_lugar.Rows.Count = 0 Then
                MsgBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dt_h_insertS_MouseHover(sender As Object, e As EventArgs) Handles dt_h_insertS.MouseHover
        If Check_edicion.Checked = True Then
            If dg_registro.SelectedRows.Count = 0 Or dg_lugar.Rows.Count = 0 Then
                MsgBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
                Exit Sub
            End If
        Else
            If Cbo_patente.SelectedIndex = -1 Then
                MsgBox("Seleccionar Patente", vbInformation, "PATENTE NO SELECCIONADA")
                Cbo_patente.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dt_fecha_insertS_MouseHover(sender As Object, e As EventArgs) Handles dt_fecha_insertS.MouseHover
        If Check_edicion.Checked = True Then
            If dg_registro.SelectedRows.Count = 0 Or dg_lugar.Rows.Count = 0 Then
                MsgBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
                Exit Sub
            End If
        Else
            If Cbo_patente.SelectedIndex = -1 Then
                MsgBox("Seleccionar Patente", vbInformation, "PATENTE NO SELECCIONADA")
                Cbo_patente.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Cbo_lugar_MouseHover(sender As Object, e As EventArgs) Handles Cbo_lugar.MouseHover
        'If Check_edicion.Checked = True Then
        'If dg_registro.SelectedRows.Count = 0 Then
        'gBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
        'Exit Sub
        'End If
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar_controles_búsqueda()
        If dg_registro.SelectedRows.Count > 0 Then
            titulo_registro()
            mostrar_registro(0, 0, "", "", "", "", "", "", "", "")
        End If
    End Sub

    Private Sub dg_registro_SelectionChanged(sender As Object, e As EventArgs) Handles dg_registro.SelectionChanged
        If dg_registro.SelectedRows.Count = 0 Then
            limpiar()
        End If
    End Sub

    Private Sub btn_patente_Click(sender As Object, e As EventArgs) Handles btn_patente.Click
        If Check_edicion.Checked = False Then
            Cbo_patente.SelectedIndex = -1
        Else
            If Cbo_patente.SelectedIndex <> -1 Then
                Patente.txt_bus_pat.Text = Cbo_patente.SelectedItem
            End If
        End If
        Patente.Show()
    End Sub

    Private Sub btn_chofer_Click(sender As Object, e As EventArgs) Handles btn_chofer.Click
        If Check_edicion.Checked = False Then
            If cbo_chofer.Items.Count > 0 Then
                cbo_chofer.SelectedIndex = -1
            End If
        Else
            If cbo_chofer.SelectedIndex <> -1 Then
                chofer.txt_cho_buscar.Text = cbo_chofer.SelectedItem
            End If
        End If

        chofer.Show()
    End Sub

    Private Sub txt_buscarP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscarP.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) Then _
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

    Private Sub txt_buscarC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscarC.KeyPress
        Dim caracteresPermitidos As String = "´" & Convert.ToChar(8)

        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) _
                                    AndAlso Not Char.IsWhiteSpace(e.KeyChar) _
            AndAlso Not caracteresPermitidos.Contains(c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_bruto_RE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bruto_RE.KeyPress
        'If Char.IsLetter(e.KeyChar) Then _
        'AndAlso Not Char.IsControl(e.KeyChar) Then '_
        'AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
        'e.Handled = False
        'End If
        e.Handled = True
        If Char.IsNumber(e.KeyChar) Then 'AndAlso Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            ' e.Handled = False
        End If
        Check_tomarFS.Checked = False
        Check_tomarFS.Enabled = False
        dt_fecha_insertS.Enabled = False
        dt_h_insertS.Enabled = False
    End Sub

    Private Sub txt_tara_RE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tara_RE.KeyPress
        e.Handled = True
        If Char.IsNumber(e.KeyChar) Then 'AndAlso Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            ' e.Handled = False
        End If
        If Trim(txt_bruto_RE.Text) = "" Then
            txt_bruto_RE.Focus()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dg_registro.Rows.Count = 0 Then
            MsgBox("Ingrese Registros para realizar la operación de Eliminar", vbCritical, "NO HAY REGISTROS")
            Exit Sub
        End If
        If dg_registro.SelectedRows.Count > 0 Then
            Dim d_num = dg_registro.CurrentRow.Cells(0).Value
            Dim d_patente = dg_registro.CurrentRow.Cells(2).Value
            Dim d_chofer = dg_registro.CurrentRow.Cells(3).Value
            Dim d_fecs = dg_registro.CurrentRow.Cells(4).Value
            Dim d_ruta = dg_registro.CurrentRow.Cells(5).Value
            Dim d_fece = dg_registro.CurrentRow.Cells(6).Value
            Dim d_pesb = dg_registro.CurrentRow.Cells(7).Value
            Dim d_pest = dg_registro.CurrentRow.Cells(8).Value
            Dim d_pesn = dg_registro.CurrentRow.Cells(9).Value
            Dim texto = ""

            If d_fece <> "" Then
                texto = "Desea elminar el registro:" & vbCrLf &
                    " - Nº:                           " & d_num & vbCrLf &
                    " - Patente:                  " + d_patente & vbCrLf &
                    " - Chofer:                   " + d_chofer & vbCrLf &
                    " - Fecha de Salida:    " + d_fecs & vbCrLf &
                    " - Fecha de Entrada: " + d_fece & vbCrLf &
                    " - Ruta: " + d_ruta & vbCrLf &
                    " - Peso Bruto:            " + d_pesb + " toneladas" & vbCrLf &
                    " - Peso tara:               " + d_pest + " toneladas" & vbCrLf &
                    " - Peso Neto:               " + d_pesn + " toneladas"
            Else
                'texto = "Eliminar"
                texto = "Los datos de entrada, aún no se han ingresado, ElIMINAR DE TODOS MODOS ?:" & vbCrLf &
                  " - Nº:                        " & d_num & vbCrLf &
                  " - Patente:               " + d_patente & vbCrLf &
                  " - Chofer:                " + d_chofer & vbCrLf &
                  " - Fecha de Salida: " + d_fecs & vbCrLf &
                  " - Ruta: " + d_ruta
            End If
            Dim respuesta = MsgBox(texto, vbQuestion + vbYesNo + vbDefaultButton1, "ELIMINAR REGISTRO")

            If respuesta = vbYes Then
                'MsgBox("holllaaa")
                Abrir()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "registroS_delete"
                cmd.Parameters.AddWithValue("@reg_id", dg_registro.CurrentRow.Cells(1).Value)
                cmd.ExecuteNonQuery()
                Cerrar()
                cmd.Parameters.Clear()

                If Trim(txt_buscarP.Text) = "" And Trim(txt_buscarC.Text) = "" And dt_year_b.Checked = False Then
                    titulo_registro()
                    mostrar_registro(0, "", "", "", "", "", "", "", "", "")
                Else
                    valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
                End If
            End If
        Else
            MsgBox("Seleccione un registro para eliminar", vbInformation, "ELIMINAR REGISTRO")
        End If
    End Sub

    Private Sub btn_reportes_Click(sender As Object, e As EventArgs) Handles btn_reportes.Click
        Reporte.Show()
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        If Check_edicion.Checked = True Then
            If dg_registro.SelectedRows.Count = 0 Or dg_lugar.Rows.Count = 0 Then
                MsgBox("seleccionar fila, el modo EDICIÓN se encuentra activo", vbInformation, "MODO EDICIÓN ACTIVO")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Check_activaFB_RE_CheckedChanged(sender As Object, e As EventArgs) Handles Check_activaFB_RE.CheckedChanged
        If Check_activaFB_RE.Checked = True Then
            If dt_year_b.Checked = True Then
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            End If
        Else
            If dt_year_b.Checked = True Then
                valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            End If
        End If
    End Sub

    Private Sub dt_h_insertS_ValueChanged(sender As Object, e As EventArgs) Handles dt_h_insertS.ValueChanged
        If dt_h_insertS.Checked = True Then

            If Check_edicion.Checked = False Then
                If Cbo_patente.SelectedItem <> "LBVZ-11" Then 'Or Cbo_patente.SelectedItem <> "HRGV-54" Then
                    'MsgBox("diferencia")
                    dg_lugar.Rows.Clear()
                    ' Exit Sub
                    If Cbo_patente.SelectedItem <> "HRGV-54" Then
                        'MsgBox("diferencia")
                        dg_lugar.Rows.Clear()
                        Exit Sub
                    End If
                End If

                Dim j = 0
                Select Case CDate(dt_fecha_insertS.Value).ToString("dddd")
                    Case "lunes"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Paredones"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                        End If

                    Case "martes"
                        j = 3
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "El Cardal"}, {-1, -1, "El Peral"},
                                {-1, -1, "Los Briones"}, {-1, -1, "Panilongo"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then

                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Queseria"},
                                    {-1, -1, "San Francisco"}, {-1, -1, "Cabeceras"}, {-1, -1, "Bucalemu"}}
                        End If

                    Case "miércoles"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            j = 2
                            check_FA_S_nomday = New String(2, 2) {{-1, -1, "Paredones"}, {-1, -1, "El Casuto"},
                                {-1, -1, "La Población"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            j = 7
                            check_FA_S_nomday = New String(7, 2) {{-1, -1, "Los Romeros"},
                                    {-1, -1, "San Pedro de Alcantara"}, {-1, -1, "El Berdigadero"},
                                {-1, -1, "Las Papas"}, {-1, -1, "Carizarillo"}, {-1, -1, "Los Barros"},
                                {-1, -1, "Cutemu"}, {-1, -1, "La Huertilla"}}

                        End If

                    Case "jueves"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            j = 6
                            'MsgBox(j & "valor jueves")
                            check_FA_S_nomday = New String(6, 2) {{-1, -1, "El Calvario"}, {-1, -1, "Querelema"},
                                {-1, -1, "Las Viñas"}, {-1, -1, "El Rincon de las Viñas"}, {-1, -1, "El Quillay"},
                                {-1, -1, "La Ligua"}, {-1, -1, "Cabeceras"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            j = 3
                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Capilla"},
                                    {-1, -1, "Rincón de Boyeruca"}, {-1, -1, "Lo Valdivia"}, {-1, -1, "Bucalemu"}}
                        End If

                    Case "viernes"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                        End If

                    Case "sábado"
                        If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                            'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        Else
                            dg_lugar.Rows.Clear()
                            Exit Sub
                        End If

                    Case Else
                        If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                            'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        Else
                            dg_lugar.Rows.Clear()
                            Exit Sub
                        End If
                End Select


                If (CDate(dt_fecha_insertS.Value).ToString("dddd") = "domingo" Or
                    CDate(dt_fecha_insertS.Value).ToString("dddd") = "sábado") And dt_fecha_insertS.Value.Month > 2 Then
                    'MsgBox(Date.Now.Month)
                    dg_lugar.Rows.Clear()
                    'dg_lugar.Rows.Remove(dg_lugar.CurrentRow)
                    Exit Sub
                End If

                'Dim f
                ' Dim gara
                titulo_lugar()
                For f = 0 To j
                    'gara = 0
                    'If dg_lugar.Rows.Count > 0 Then
                    'For g = 0 To dg_lugar.Rows.Count - 1
                    'If dg_lugar.Item(2, g).Value = check_FA_S_nomday(f, 2) Then
                    'gara = 1
                    'End If
                    'Next
                    'End If

                    'If gara = 0 Then
                    dg_lugar.Rows.Add(check_FA_S_nomday(f, 0), check_FA_S_nomday(f, 1), check_FA_S_nomday(f, 2))
                    'End If
                    'MsgBox(f)
                Next
                dg_lugar.ClearSelection()
            End If


            'check_FA_S_nomday = ""
            'MsgBox(f)
        End If
    End Sub

    Private Sub dt_fecha_insertS_ValueChanged(sender As Object, e As EventArgs) Handles dt_fecha_insertS.ValueChanged
        If dt_fecha_insertS.Checked = True Then

            If Check_edicion.Checked = False Then

                If Cbo_patente.SelectedItem <> "LBVZ-11" Then 'Or Cbo_patente.SelectedItem <> "HRGV-54" Then
                    'MsgBox("diferencia")
                    dg_lugar.Rows.Clear()
                    'Exit Sub
                    If Cbo_patente.SelectedItem <> "HRGV-54" Then
                        'MsgBox("diferencia")
                        dg_lugar.Rows.Clear()
                        Exit Sub
                    End If

                End If
                'MsgBox("Pase")

                Dim j = 0
                Select Case CDate(dt_fecha_insertS.Value).ToString("dddd")
                    Case "lunes"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Paredones"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                        End If

                    Case "martes"
                        j = 3
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "El Cardal"}, {-1, -1, "El Peral"},
                                {-1, -1, "Los Briones"}, {-1, -1, "Panilongo"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then

                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Queseria"},
                                    {-1, -1, "San Francisco"}, {-1, -1, "Cabeceras"}, {-1, -1, "Bucalemu"}}
                        End If

                    Case "miércoles"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            j = 2
                            check_FA_S_nomday = New String(2, 2) {{-1, -1, "Paredones"}, {-1, -1, "El Casuto"},
                                {-1, -1, "La Población"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            j = 7
                            check_FA_S_nomday = New String(7, 2) {{-1, -1, "Los Romeros"},
                                    {-1, -1, "San Pedro de Alcantara"}, {-1, -1, "El Berdigadero"},
                                {-1, -1, "Las Papas"}, {-1, -1, "Carizarillo"}, {-1, -1, "Los Barros"},
                                {-1, -1, "Cutemu"}, {-1, -1, "La Huertilla"}}

                        End If

                    Case "jueves"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            j = 6
                            'MsgBox(j & "valor jueves")
                            check_FA_S_nomday = New String(6, 2) {{-1, -1, "El Calvario"}, {-1, -1, "Querelema"},
                                {-1, -1, "Las Viñas"}, {-1, -1, "El Rincon de las Viñas"}, {-1, -1, "El Quillay"},
                                {-1, -1, "La Ligua"}, {-1, -1, "Cabeceras"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            j = 3
                            check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Capilla"},
                                    {-1, -1, "Rincón de Boyeruca"}, {-1, -1, "Lo Valdivia"}, {-1, -1, "Bucalemu"}}
                        End If

                    Case "viernes"
                        If Cbo_patente.SelectedItem = "LBVZ-11" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                        ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                        End If

                    Case "sábado"
                        If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                            'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        Else
                            dg_lugar.Rows.Clear()
                            Exit Sub
                        End If

                    Case Else
                        If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                            check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                            'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        Else
                            dg_lugar.Rows.Clear()
                            Exit Sub
                        End If
                End Select


                If (CDate(dt_fecha_insertS.Value).ToString("dddd") = "domingo" Or
                    CDate(dt_fecha_insertS.Value).ToString("dddd") = "sábado") And dt_fecha_insertS.Value.Month > 2 Then
                    'MsgBox(Date.Now.Month)
                    dg_lugar.Rows.Clear()
                    'dg_lugar.Rows.Remove(dg_lugar.CurrentRow)
                    Exit Sub
                End If

                'Dim f
                'Dim gara
                titulo_lugar()
                For f = 0 To j
                    'gara = 0
                    'If dg_lugar.Rows.Count > 0 Then
                    'For g = 0 To dg_lugar.Rows.Count - 1
                    'If dg_lugar.Item(2, g).Value = check_FA_S_nomday(f, 2) Then
                    'gara = 1
                    'End If
                    'Next
                    'End If

                    'If gara = 0 Then
                    dg_lugar.Rows.Add(check_FA_S_nomday(f, 0), check_FA_S_nomday(f, 1), check_FA_S_nomday(f, 2))
                    'End If
                    'MsgBox(f)
                Next
                dg_lugar.ClearSelection()
            End If


            'check_FA_S_nomday = ""
            'MsgBox(f)
        End If
    End Sub

    Private Sub Check_tomarFS_MouseHover(sender As Object, e As EventArgs) Handles Check_tomarFS.MouseHover
        If Check_edicion.Checked = False Then
            If Cbo_patente.SelectedIndex = -1 Then
                MsgBox("Seleccionar Patente", vbInformation, "PATENTE NO SELECCIONADA")
                Cbo_patente.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Cbo_nom_day_b_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_nom_day_b.SelectedIndexChanged
        If Cbo_nom_day_b.SelectedIndex <> -1 Then
            dt_hour_b.Enabled = True
            dt_minute_b.Enabled = False

            valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
            'If dg_registro.Rows.Count = 0 Then
            'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "Sin resultados con datos de Búsqueda")
            'End If
        Else
            valores_búsqueda(Patente, chofer, year, month, day, nomday, hour, minute, btn_save)
        End If
    End Sub

    Private Sub Cbo_patente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_patente.SelectedIndexChanged
        If Cbo_patente.SelectedIndex <> -1 Then
            If Check_edicion.Checked = False Then
                If Trim(txt_buscarP.Text) <> "" Or Trim(txt_buscarC.Text) <> "" Or dt_year_b.Checked = True Then
                    titulo_registro()
                    mostrar_registro(0, "", "", "", "", "", "", "", "", "")
                End If
                limpiar_controles_búsqueda()
                dg_registro.ClearSelection()
            End If

            '--------------------------------------------------------------------------------------
            If Cbo_patente.SelectedItem <> "LBVZ-11" Then 'Or Cbo_patente.SelectedItem <> "HRGV-54" Then
                'MsgBox("diferencia")
                dg_lugar.Rows.Clear()
                'Exit Sub
                If Cbo_patente.SelectedItem <> "HRGV-54" Then
                    'MsgBox("diferencia")
                    dg_lugar.Rows.Clear()
                    Exit Sub
                End If
            End If

            If dt_h_insertS.Checked = False Then
                Exit Sub
            End If

            Dim j = 0
            Select Case CDate(dt_fecha_insertS.Value).ToString("dddd")
                Case "lunes"
                    If Cbo_patente.SelectedItem = "LBVZ-11" Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Paredones"}}

                    ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                    End If

                Case "martes"
                    j = 3
                    If Cbo_patente.SelectedItem = "LBVZ-11" Then
                        check_FA_S_nomday = New String(3, 2) {{-1, -1, "El Cardal"}, {-1, -1, "El Peral"},
                                {-1, -1, "Los Briones"}, {-1, -1, "Panilongo"}}

                    ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then

                        check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Queseria"},
                                    {-1, -1, "San Francisco"}, {-1, -1, "Cabeceras"}, {-1, -1, "Bucalemu"}}
                    End If

                Case "miércoles"
                    If Cbo_patente.SelectedItem = "LBVZ-11" Then
                        j = 2
                        check_FA_S_nomday = New String(2, 2) {{-1, -1, "Paredones"}, {-1, -1, "El Casuto"},
                                {-1, -1, "La Población"}}

                    ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        j = 7
                        check_FA_S_nomday = New String(7, 2) {{-1, -1, "Los Romeros"},
                                    {-1, -1, "San Pedro de Alcantara"}, {-1, -1, "El Berdigadero"},
                                {-1, -1, "Las Papas"}, {-1, -1, "Carizarillo"}, {-1, -1, "Los Barros"},
                                {-1, -1, "Cutemu"}, {-1, -1, "La Huertilla"}}

                    End If

                Case "jueves"
                    If Cbo_patente.SelectedItem = "LBVZ-11" Then
                        j = 6
                        'MsgBox(j & "valor jueves")
                        check_FA_S_nomday = New String(6, 2) {{-1, -1, "El Calvario"}, {-1, -1, "Querelema"},
                                {-1, -1, "Las Viñas"}, {-1, -1, "El Rincon de las Viñas"}, {-1, -1, "El Quillay"},
                                {-1, -1, "La Ligua"}, {-1, -1, "Cabeceras"}}

                    ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        j = 3
                        check_FA_S_nomday = New String(3, 2) {{-1, -1, "La Capilla"},
                                    {-1, -1, "Rincón de Boyeruca"}, {-1, -1, "Lo Valdivia"}, {-1, -1, "Bucalemu"}}
                    End If

                Case "viernes"
                    If Cbo_patente.SelectedItem = "LBVZ-11" Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                    ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}
                    End If

                Case "sábado"
                    If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                        'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                    Else
                        dg_lugar.Rows.Clear()
                        Exit Sub
                    End If

                Case Else
                    If Cbo_patente.SelectedItem = "LBVZ-11" And (dt_fecha_insertS.Value.Month = 1 Or dt_fecha_insertS.Value.Month = 2) Then
                        check_FA_S_nomday = New String(0, 2) {{-1, -1, "Bucalemu"}}

                        'ElseIf Cbo_patente.SelectedItem = "HRGV-54" Then
                    Else
                        dg_lugar.Rows.Clear()
                        Exit Sub
                    End If
            End Select


            If (CDate(dt_fecha_insertS.Value).ToString("dddd") = "domingo" Or
                        CDate(dt_fecha_insertS.Value).ToString("dddd") = "sábado") And dt_fecha_insertS.Value.Month > 2 Then
                        'MsgBox(Date.Now.Month)
                        dg_lugar.Rows.Clear()
                        'dg_lugar.Rows.Remove(dg_lugar.CurrentRow)
                        Exit Sub
                    End If

            'Dim f
            'Dim gara
            titulo_lugar()
            For f = 0 To j
                dg_lugar.Rows.Add(check_FA_S_nomday(f, 0), check_FA_S_nomday(f, 1), check_FA_S_nomday(f, 2))
            Next

            dg_lugar.ClearSelection()
            '--------------------------------------------------------------------------------------
        End If
    End Sub
    Sub valores_búsqueda(l_patente, l_chofer, year, month, day, nomday, hour, minute, btn_save)
        l_patente = Trim(txt_buscarP.Text)
        l_chofer = Trim(txt_buscarC.Text)

        If dt_year_b.Checked = True Then
            year = Format(dt_year_b.Value, "yyyy")
            'MessageBox.Show(year)
            If dt_month_b.Checked = True Then
                month = Format(dt_month_b.Value, "MM")
                'MessageBox.Show(month)
            End If

            If dt_day_b.Checked = True Then
                day = Format(dt_day_b.Value, "dd")
                'MessageBox.Show(day)
            End If
            If Check_nom_day_b.Checked = True Then
                If Cbo_nom_day_b.SelectedIndex = -1 Then
                    MsgBox("Seleccionar nombre de Día a buscar", vbInformation, "Nombre día, no seleccionada")
                    Cbo_nom_day_b.Focus()
                    Exit Sub
                End If
                Dim dia = ""
                Select Case Trim(Cbo_nom_day_b.Text)
                    Case "Lunes"
                        dia = "Monday"
                    Case "Martes"
                        dia = "Tuesday"
                    Case "Miércoles"
                        dia = "Wednesday"
                    Case "Jueves"
                        dia = "Thursday"
                    Case "Viernes"
                        dia = "Friday"
                    Case "Sábado"
                        dia = "Saturday"
                    Case Else
                        dia = "Sunday"
                End Select
                nomday = dia
                '.Show(nomday)
            End If
            If dt_hour_b.Checked = True Then
                hour = Format(dt_hour_b.Value, "HH")
                'MessageBox.Show(hour)
            End If
            If dt_minute_b.Checked = True Then
                minute = Format(dt_minute_b.Value, "mm")
                'MessageBox.Show(minute)
            End If
        End If

        limpiar()
        If Trim(txt_bruto_RE.Text) <> "" And Trim(txt_tara_RE.Text) <> "" And dt_hora_RE.Checked = True Then
            limpiar_botones_entrada()
        End If
        'End If
        'MsgBox(year)
        titulo_registro()
        If Check_activaFB_RE.Checked = False Then
            mostrar_registro(1, 0, l_patente, l_chofer, year, month, day, nomday, hour, minute)
        Else
            mostrar_registro(1, 1, l_patente, l_chofer, year, month, day, nomday, hour, minute)
        End If

        If Check_edicion.Checked = True Then
            'botones_entrada(False)
            If dg_registro.Rows.Count > 0 Then
                If btn_save = 0 Then
                    mostrar_registro_editar()
                End If
            End If
        End If
        'exec registroS_search 0,'','','2022','05','','sunday','',''

        'If dg_registro.Rows.Count = 0 Then
        'MsgBox("El valor búscado no se encuentra registrado", vbInformation, "sin resultados con datos de Búsqueda")

        'titulo_registro()
        'mostrar_registro(0, 0, "", "", "", "", "", "", "", "")
        'End If
        l_patente = ""
        l_chofer = ""
        year = ""
        month = ""
        nomday = ""
        day = ""
        hour = ""
        minute = ""
    End Sub

    Sub rec_query(num, rec_id, reg_id, lug_n)
        Abrir()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "recorrido_update"
        cmd.Parameters.AddWithValue("@num", num)
        cmd.Parameters.AddWithValue("@rec_id", rec_id)
        cmd.Parameters.AddWithValue("@reg_id", reg_id)
        cmd.Parameters.AddWithValue("@lug_n", lug_n)
        cmd.ExecuteNonQuery()
        Cerrar()
        cmd.Parameters.Clear()
    End Sub
    Sub botones_entrada(estado)
        check_tomarFA_RE.Enabled = estado
        Panel2.Enabled = estado
    End Sub
    Sub limpiar_botones_entrada()
        If Check_edicion.Checked = False Then
            check_tomarFA_RE.Checked = False
        End If

        dt_hora_RE.Checked = False
        txt_bruto_RE.Clear()
        txt_tara_RE.Clear()
    End Sub
    Sub mostrar_registro_editar()
        Dim fecha_edita = Microsoft.VisualBasic.Right(dg_registro.CurrentRow.Cells(4).Value, 16)
        Dim fecha_edita_entrada = Microsoft.VisualBasic.Right(dg_registro.CurrentRow.Cells(6).Value, 16)
        'MessageBox.Show("jojojo")

        'Dim fila As Integer
        'Dim fila
        '        MessageBox.Show(dt_fecha_insertS.Value)
        ' MessageBox.Show(dt_h_insertS.Value)
        If dg_registro.SelectedRows.Count > 0 Then
            Cbo_patente.SelectedItem = dg_registro.CurrentRow.Cells(2).Value
            cbo_chofer.SelectedItem = dg_registro.CurrentRow.Cells(3).Value

            dt_fecha_insertS.Value = fecha_edita
            dt_h_insertS.Value = fecha_edita

            botones_entrada(True)
            If dg_registro.CurrentRow.Cells(6).Value <> "" Then
                'check_tomarFA_RE.Checked = False
                dt_fecha_RE.Value = fecha_edita_entrada
                dt_hora_RE.Value = fecha_edita_entrada

                If check_tomarFA_RE.Checked = False Then
                    dt_hora_RE.Checked = True
                End If

                Check_tomarFS.Checked = False
                Check_tomarFS.Enabled = False
                dt_fecha_insertS.Enabled = False
                dt_h_insertS.Enabled = False

                txt_bruto_RE.Text = Val(dg_registro.CurrentRow.Cells(7).Value) * 1000
                txt_tara_RE.Text = Val(dg_registro.CurrentRow.Cells(8).Value) * 1000
            Else
                Check_tomarFS.Enabled = True
                dt_fecha_insertS.Enabled = True
                dt_h_insertS.Enabled = True

                If Check_tomarFS.Checked = False Then
                    dt_h_insertS.Checked = True
                End If

                dt_fecha_RE.Value = fecha_edita
                dt_hora_RE.Value = fecha_edita
                txt_bruto_RE.Text = ""
                txt_tara_RE.Text = ""
            End If

            'End If

            ' MessageBox.Show(dg_registro.CurrentRow.Cells(1).Value)
            titulo_lugar()
            titulo_lugar_origen()

            Abrir()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "recorrido_select"
            cmd.Parameters.AddWithValue("@reg_id", dg_registro.CurrentRow.Cells(1).Value)
            dr = cmd.ExecuteReader
            While dr.Read
                dg_lugar.Rows.Add(dr("rec_id"), dr("rec_reg_id"), dr("lug_nom"))
                dg_lugar_origen.Rows.Add(dr("rec_id"), dr("rec_reg_id"), dr("lug_nom"))
            End While
            Cerrar()
            cmd.Parameters.Clear()
            dg_lugar.ClearSelection()
            'MessageBox.Show(Microsoft.VisualBasic.Right(dg_registro.CurrentRow.Cells(4).Value, 16))
            'End If
            'MessageBox.Show("ingresamos")
            'Exit Sub
            'txt_lugar_nom.Text = Convert.ToString(dg1.CurrentRow.Cells(1).Value)
            'txt_lugar_nom.Text = dg1.CurrentRow.Cells(1).Value
            'fila = dg1.CurrentRow.Index

            'dg2.ClearSelection()
            'dg2.Rows(fila).Selected = True
            ' btn_eliminar.Visible = True
        Else
            MsgBox("Selecciona una fila para modificar", vbInformation, "OPCIONES DE EDICIÓN ACTIVAS")
        End If
    End Sub
End Class