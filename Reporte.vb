Imports iTextSharp.text
Imports iTextSharp.text.pdf

Imports SpreadsheetLight
'
Imports System.IO

'Imports System.Data
'Imports Excel = Baltsoft.Microsoft.Office2019.Interop

'Imports Microsoft.Office.Interop.Excel

Public Class Reporte
    Dim num = 0
    Dim fecha_desde = "", fecha_hasta = ""
    Dim fecha_salida = ""
    Dim fecha_entrada = ""
    Dim neto = "", peso_bruto = "", peso_tara = ""
    Dim dia = "", dia1 = "", total_neto = 0

    Dim pdfWrite As PdfWriter
    Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
    Dim f_mes As String = "", f_year As String = ""

    Dim b_day = "", b_month = "", b_year = ""

    Dim matrix = "" 'New String(str, 1) {}
    Dim str_ = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Cbo_nom_day.SelectedIndex <> -1 Or dt_year_b.Checked = True Or fec_hasta.Checked = True Then
            Cbo_nom_day.SelectedIndex = -1
            dt_day_b.Checked = False
            dt_month_b.Checked = False
            dt_year_b.Checked = False
            fec_hasta.Checked = False
            titulo_reporte()
            mostrar_reporte()
        End If
    End Sub
    Private Sub dt_day_b_MouseHover(sender As Object, e As EventArgs) Handles dt_day_b.MouseHover
        'If dt_month_b.Checked = False Then
        'MsgBox("Para activar Día, primero activar MES", vbInformation, "MES ESTÁ DESACTIVADO")
        'Exit Sub
        'End If
    End Sub

    Private Sub dt_year_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_year_b.ValueChanged
        If dt_year_b.Checked = True Then
            buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        Else
            dt_month_b.Checked = False
            dt_day_b.Checked = False
            fec_hasta.Checked = False

            titulo_reporte()
            mostrar_reporte()
            'buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        End If
    End Sub

    Private Sub dt_month_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_month_b.ValueChanged
        If dt_month_b.Checked = True Then
            buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        Else
            dt_day_b.Checked = False
            buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        End If
    End Sub

    Private Sub fec_hasta_ValueChanged(sender As Object, e As EventArgs) Handles fec_hasta.ValueChanged
        If fec_hasta.Checked = True Then
            dt_year_b.Checked = True
            dt_month_b.Checked = True
            dt_day_b.Checked = True
            ' MessageBox.Show("holan hola?")
            'Exit Sub
            buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        Else
            dt_day_b.Checked = False
            If dt_year_b.Checked = False Then
                titulo_reporte()
                mostrar_reporte()
            Else
                buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
            End If

            'buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
        End If
    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        If dt_year_b.Checked = False Then
            'If fec_hasta.Checked = False Then
            MsgBox("Seleccionar Fechas para Reportar", vbInformation, "NO HA SELECCIONADO FECHAS QUE INDIQUEN EL REPORTE")
            Exit Sub
            'End If
        Else
            If dg_reporte.Rows.Count = 0 Then
                MsgBox("Para reportar, es necesario que la búsqueda muestre registros", vbInformation, "NO HAY REGISTROS PARA REPORTAR")
                Exit Sub
            End If
        End If

        'fecha_desde = Format(dt_year_b.Value, "yyyy")
        Dim n_cantidad = dg_reporte.Rows.Count - 1
        Dim n_desde As Date, n_hasta As Date
        n_desde = dg_reporte.Item(7, 0).Value
        n_hasta = dg_reporte.Item(7, n_cantidad).Value

        If fec_hasta.Checked = False Then
            If dt_month_b.Checked = True Then
                f_mes = MonthName(dt_month_b.Value.Month)
            End If
            f_year = Format(dt_year_b.Value, "yyyy")
        Else
            If Format(n_desde, "yyyy") = Format(n_hasta, "yyyy") Then
                If Format(n_desde, "MM") = Format(n_hasta, "MM") Then
                    f_mes = MonthName(n_desde.Month)
                Else
                    f_mes = Format(n_desde, "dd") + " " + MonthName(n_desde.Month) + " - " + Format(n_hasta, "dd") + " " + MonthName(n_hasta.Month)
                End If
                f_year = Format(n_desde, "yyyy")
            Else
                f_mes = Format(n_desde, "dd") + " " + MonthName(n_desde.Month) + " - " + Format(n_hasta, "dd") + " " + MonthName(n_hasta.Month)
                f_year = Format(n_desde, "yyyy") + " - " + Format(n_hasta, "yyyy")
            End If
        End If
        'MessageBox.Show("hollaala")
        'Exit Sub

        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        ' String pdfFileName = String.Format("{0}_{1:yyyyMMdd_hhmm}.pdf", txtid.Text, DateTime.Now);
        'String pdfPath = Path.Combine(@"C:\Usuarios\Reporte", pdfFileName);
        'PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

        With SaveFileDialog
            .Title = "Guardar Reporte - Recolección de Basura en Excel"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Archivos Excel (*.xlsx)|*.xlsx"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With
        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If

        Dim sl As New SLDocument()
        Dim style As New SLStyle()
        style.font.fontsize = 12
        style.font.bold = True

        sl.SetCellValue(1, 1, "REPORTE DE INGRESO, ILUSTRE MUNICIPALIDAD DE PAREDONES")
        sl.SetCellValue(2, 1, f_mes + " (" + f_year + ")")
        'sl.SetCellValue(1, 1
        'sl.SetCellValue(1, 2, f_mes + " (" + f_year + ")")
        sl.SetCellStyle(1, 1, style)
        sl.SetCellStyle(2, 1, style)


        Dim ic = 1
        For Each column In dg_reporte.Columns
            sl.SetCellValue(4, ic, column.headerText.ToString)
            sl.SetCellStyle(4, ic, style)
            ic += 1
        Next

        Dim ir = 5
        For Each row In dg_reporte.Rows
            sl.SetCellValue(ir, 1, row.cells(0).value)
            sl.SetCellValue(ir, 2, row.cells(1).value.ToString())
            sl.SetCellValue(ir, 3, row.cells(2).value.ToString())
            sl.SetCellValue(ir, 4, row.cells(3).value.ToString())
            sl.SetCellValue(ir, 5, row.cells(4).value.ToString())
            sl.SetCellValue(ir, 6, row.cells(5).value.ToString())
            sl.SetCellValue(ir, 7, row.cells(6).value.ToString())
            sl.SetCellValue(ir, 8, row.cells(7).value.ToString())
            sl.SetCellValue(ir, 9, row.cells(8).value)
            sl.SetCellValue(ir, 10, row.cells(9).value)
            sl.SetCellValue(ir, 11, row.cells(10).value)
            'sl.SetCellValue(ir, 9, row.cells(10).value.ToString())
            ir += 1
        Next
        sl.SetCellValue(ir, 10, "Total Neto:")
        sl.SetCellValue(ir, 11, Val(Lbl_total_neto.Text))

        sl.SaveAs(ruta)
        'sl.SaveAS("D:\exporteddata.xlsx")

        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim i As Integer
        'Dim j As Integer

        'xlApp = New Excel.Application
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkBook = xlWorkBook.Sheets("sheet1")

        'For i = 0 To dg_reporte.RowCount - 2
        '  For j = 0 To dg_reporte.ColumnCount - 1
        '     xlWorkSheet.Cells(i + 1, j + 1) =
        ' dg_reporte(j, i).Value.ToString()
        '   Next
        '  Next

        ' xlWorkSheet.SaveAs("D:\exporteddata.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        ' releaseObject(xlApp)
        'releaseobject(xlWorkBook)
        ' releaseobject(xlWorkSheet)
        'MsgBox("you can find your dile in excel")

        ' Dim ValorInicial As Integer = 7 ''Celda donde empezamos a insertar los articulos
        'Dim Total As Double = 0

        ''For i = 0 To dg_reporte.Rows.Count - 1
        'xlibro.Range("A" & ValorInicial).Value = dg_reporte.Item(0, i) 'fila("Descripcion")
        'xlibro.Range("B" & ValorInicial).Value = dg_reporte.Item(1, i) 'fila("precio")
        'xlibro.Range("C" & ValorInicial).Value = dg_reporte.Item(2, i) 'fila("Cantidad")
        '  xlibro.Range("D" & ValorInicial).Value = dg_reporte.Item(3, i) 'fila("cantidad") * fila("precio")
        'Total = Total + (fila("cantidad") * fila("precio"))

        'ValorInicial += 1

        'Next

        'xlibro.Range("D17").Value = Lbl_total_neto.Text  'Total
        'End If

        'Conexion.Close()
    End Sub

    Private Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Cbo_nom_day_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_nom_day.SelectedIndexChanged
        buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        If Cbo_nom_day.SelectedIndex <> -1 Or dt_year_b.Checked = True Or fec_hasta.Checked = True Then
            Cbo_nom_day.SelectedIndex = -1
            dt_day_b.Checked = False
            dt_month_b.Checked = False
            dt_year_b.Checked = False
            fec_hasta.Checked = False
            titulo_reporte()
            mostrar_reporte()
        End If
    End Sub


    Private Sub dt_day_b_ValueChanged(sender As Object, e As EventArgs) Handles dt_day_b.ValueChanged
        If dt_day_b.Checked = True Then
            If fec_hasta.Checked = True Then
                buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
            End If
        Else
            If fec_hasta.Checked = True Then
                fec_hasta.Checked = False
                buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)
            End If
        End If
    End Sub

    Private Sub dt_month_b_MouseHover(sender As Object, e As EventArgs) Handles dt_month_b.MouseHover
        'If dt_year_b.Checked = False Then
        'MsgBox("Para activar MES, primero activar AÑO", vbInformation, "AÑO, ESTÁ DESACTIVADO")
        'Exit Sub
        'End If
    End Sub

    Private Sub btn_rep_pdf_Click(sender As Object, e As EventArgs) Handles btn_rep_pdf.Click
        If dt_year_b.Checked = False Then
            'If fec_hasta.Checked = False Then
            MsgBox("Seleccionar Fechas para Reportar", vbInformation, "NO HA SELECCIONADO FECHAS QUE INDIQUEN EL REPORTE")
            Exit Sub
            'End If
        Else
            If dg_reporte.Rows.Count = 0 Then
                MsgBox("Para reportar, es necesario que la búsqueda muestre registros", vbInformation, "NO HAY REGISTROS PARA REPORTAR")
                Exit Sub
            End If
        End If

        'fecha_desde = Format(dt_year_b.Value, "yyyy")
        Dim n_cantidad = dg_reporte.Rows.Count - 1
        Dim n_desde As Date, n_hasta As Date
        n_desde = dg_reporte.Item(7, 0).Value
        n_hasta = dg_reporte.Item(7, n_cantidad).Value

        If fec_hasta.Checked = False Then
            If dt_month_b.Checked = True Then
                f_mes = MonthName(dt_month_b.Value.Month)
            End If
            f_year = Format(dt_year_b.Value, "yyyy")
        Else
            If Format(n_desde, "yyyy") = Format(n_hasta, "yyyy") Then
                If Format(n_desde, "MM") = Format(n_hasta, "MM") Then
                    f_mes = MonthName(n_desde.Month)
                Else
                    f_mes = Format(n_desde, "dd") + " " + MonthName(n_desde.Month) + " - " + Format(n_hasta, "dd") + " " + MonthName(n_hasta.Month)
                End If
                f_year = Format(n_desde, "yyyy")
            Else
                f_mes = Format(n_desde, "dd") + " " + MonthName(n_desde.Month) + " - " + Format(n_hasta, "dd") + " " + MonthName(n_hasta.Month)
                f_year = Format(n_desde, "yyyy") + " - " + Format(n_hasta, "yyyy")
            End If
        End If
        'MessageBox.Show("hollaala")
        'Exit Sub

        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        ' String pdfFileName = String.Format("{0}_{1:yyyyMMdd_hhmm}.pdf", txtid.Text, DateTime.Now);
        'String pdfPath = Path.Combine(@"C:\Usuarios\Reporte", pdfFileName);
        'PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

        With SaveFileDialog
            .Title = "Guardar Reporte - Recolección de Basura en pdf"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Archivos pdf (*.pdf)|*.pdf"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With
        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If

        pdfWrite = PdfWriter.GetInstance(pdfDoc, New FileStream(ruta, FileMode.Create))

        Dim FontB10 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD))
        Dim Font10 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL))
        Dim Font12 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL))
        Dim FontB12 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD))
        Dim FontB14 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD))
        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0

        pdfDoc.Open()

        Dim table1 As PdfPTable = New PdfPTable(4)

        Dim col1 As PdfPCell
        Dim col2 As PdfPCell
        Dim col3 As PdfPCell
        Dim col4 As PdfPCell
        Dim col5 As PdfPCell
        Dim col6 As PdfPCell
        Dim col7 As PdfPCell
        Dim col8 As PdfPCell
        Dim col9 As PdfPCell
        Dim ILine As Integer
        Dim iFila As Integer

        table1.WidthPercentage = 95

        Dim withs As Single() = New Single() {4.0F, 10.0F, 1.0F, 4.0F}
        table1.SetWidths(withs)

#Region "Tabla1 - Encabezado"
        Dim imagenURL As String = "D:\software_fran\images\mu_paredones.png"
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        imagenBMP.ScaleToFit(130.0F, 134.0F)
        imagenBMP.SpacingBefore = 20.0F
        imagenBMP.SpacingAfter = 10.0F
        'imagenBMP.SetAbsolutePosition(40, 780)
        imagenBMP.SetAbsolutePosition(20, 700)
        pdfDoc.Add(imagenBMP)

        table1.AddCell(CVacio)

        col2 = New PdfPCell(New Phrase("MUNICIPALIDAD DE PAREDONES", FontB14))
        col2.Column.Alignment = Element.ALIGN_JUSTIFIED_ALL
        col2.Border = 0
        table1.AddCell(col2)

        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase("INFORME", FontB14))
        col3.BorderWidthBottom = 0
        col3.Column.Alignment = Element.ALIGN_CENTER
        table1.AddCell(col3)

        '--------------------------------------------------------------------------------------------
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("C H I L E", FontB14))
        col2.Column.Alignment = Element.ALIGN_CENTER
        col2.Border = 0
        'col2.PaddingLeft = 8
        table1.AddCell(col2)

        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase("Recolección de basura", Font12))
        col3.BorderWidthTop = 0
        col3.BorderWidthBottom = 0
        col3.Column.Alignment = Element.ALIGN_CENTER
        table1.AddCell(col3)
        '------------------------------------------------------------------------------------------
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Región: General Libertador Bernardo O'Higgins", Font12))
        col2.Border = 0
        col2.PaddingLeft = 8
        table1.AddCell(col2)

        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase("Ingreso", Font12))
        col3.BorderWidthTop = 0
        col3.BorderWidthBottom = 0
        col3.Column.Alignment = Element.ALIGN_CENTER
        table1.AddCell(col3)
        '--------------------------------------------------------------------------------------------
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Provincia: Cardenal Caro", Font12))
        col2.Border = 0
        col2.PaddingLeft = 8
        table1.AddCell(col2)

        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase(f_mes, Font12))
        col3.BorderWidthTop = 0
        col3.BorderWidthBottom = 0
        col3.Column.Alignment = Element.ALIGN_CENTER
        table1.AddCell(col3)
        '--------------------------------------------------------------------------------------------
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Dirección: Doctor Moore Nº 15 - Paredones", Font12))
        col2.Border = 0
        col2.PaddingLeft = 8
        table1.AddCell(col2)

        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase(f_year, Font12))
        col3.BorderWidthTop = 0
        col3.Column.Alignment = Element.ALIGN_CENTER
        table1.AddCell(col3)

        '---------------------------------------------------------------------------------------------
        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("Sitio Web: http://comunaparedones.cl/", Font12))
        col2.Border = 0
        col2.PaddingLeft = 8
        col2.PaddingBottom = 25
        table1.AddCell(col2)

        table1.AddCell(CVacio)
        table1.AddCell(CVacio)

        pdfDoc.Add(table1)
#End Region

#Region "Tabla - Registro"
        Dim Table2 As PdfPTable = New PdfPTable(9)
        Dim withs2 As Single() = New Single() {1.0F, 3.0F, 5.0F, 5.0F, 8.0F, 5.0F, 2.0F, 2.0F, 2.0F}
        Table2.WidthPercentage = 99
        Table2.SetWidths(withs2)

        CVacio.Border = 2
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)

        col1 = New PdfPCell(New Phrase("Nº", FontB10))
        col1.BorderWidthLeft = 0
        col1.BorderWidthRight = 0
        Table2.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Patente", FontB10))
        col2.Column.Alignment = Element.ALIGN_CENTER
        col2.BorderWidthLeft = 0
        col2.BorderWidthRight = 0
        Table2.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Chofer", FontB10))
        col3.Column.Alignment = Element.ALIGN_CENTER
        col3.BorderWidthLeft = 0
        col3.BorderWidthRight = 0
        Table2.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Salida", FontB10))
        col4.Column.Alignment = Element.ALIGN_CENTER
        col4.BorderWidthLeft = 0
        col4.BorderWidthRight = 0
        Table2.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Ruta", FontB10))
        col5.BorderWidthLeft = 0
        col5.BorderWidthRight = 0
        col5.Column.Alignment = Element.ALIGN_CENTER
        Table2.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Entrada", FontB10))
        col6.Column.Alignment = Element.ALIGN_CENTER
        col6.BorderWidthLeft = 0
        col6.BorderWidthRight = 0
        Table2.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Bruto (tn)", FontB10))
        col7.Column.Alignment = Element.ALIGN_CENTER
        col7.BorderWidthLeft = 0
        col7.BorderWidthRight = 0
        Table2.AddCell(col7)

        col8 = New PdfPCell(New Phrase("Tara (tn)", FontB10))
        col8.Column.Alignment = Element.ALIGN_CENTER
        col8.BorderWidthLeft = 0
        col8.BorderWidthRight = 0
        col8.PaddingBottom = 2
        Table2.AddCell(col8)

        col9 = New PdfPCell(New Phrase("Neto (tn)", FontB10))
        col9.Column.Alignment = Element.ALIGN_CENTER
        col9.BorderWidthLeft = 0
        col9.BorderWidthRight = 0
        col9.PaddingBottom = 2
        Table2.AddCell(col9)

        '--------------------------------------------------------------------------
        For i = 0 To dg_reporte.Rows.Count - 1
            col1 = New PdfPCell(New Phrase(dg_reporte.Item(0, i).Value, Font10))
            col2 = New PdfPCell(New Phrase(dg_reporte.Item(1, i).Value, Font10))
            col3 = New PdfPCell(New Phrase(dg_reporte.Item(2, i).Value, Font10))
            col4 = New PdfPCell(New Phrase(dg_reporte.Item(4, i).Value, Font10))
            col5 = New PdfPCell(New Phrase(dg_reporte.Item(5, i).Value, Font10))
            col6 = New PdfPCell(New Phrase(dg_reporte.Item(7, i).Value, Font10))
            col7 = New PdfPCell(New Phrase(dg_reporte.Item(8, i).Value, Font10))
            col8 = New PdfPCell(New Phrase(dg_reporte.Item(9, i).Value, Font10))
            col9 = New PdfPCell(New Phrase(dg_reporte.Item(10, i).Value, Font10))

            col1.Border = 0
            col2.Border = 0
            col3.Border = 0
            col4.Border = 0
            col5.Border = 0
            col6.Border = 0
            col7.Border = 0
            col8.Border = 0
            col9.Border = 0

            Table2.AddCell(col1)
            Table2.AddCell(col2)
            Table2.AddCell(col3)
            Table2.AddCell(col4)
            Table2.AddCell(col5)
            Table2.AddCell(col6)
            Table2.AddCell(col7)
            Table2.AddCell(col8)
            Table2.AddCell(col9)
        Next
        col1 = New PdfPCell(New Phrase("TOTAL (NETO), " + f_mes.ToUpper + " (" + f_year + ") : " + Lbl_total_neto.Text + " TONELADAS", FontB10))
        col1.Column.Alignment = Element.ALIGN_RIGHT
        col1.BorderWidthLeft = 0
        col1.BorderWidthRight = 0
        'col1.PaddingRight = 2
        col1.Colspan = 9
        Table2.AddCell(col1)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)
        Table2.AddCell(CVacio)

        'col9 = New PdfPCell(New Phrase(Lbl_total_neto.Text, FontB10))

        'col9.BorderWidthLeft = 0
        'col9.BorderWidthRight = 0
        'Table2.AddCell(col9)


        pdfDoc.Add(Table2)
#End Region

        For iFila = 1 To 40
            pdfDoc.Add(New Phrase(""))
            ILine = pdfWrite.GetVerticalPosition(True)
            If ILine < 200 Then
                Exit For
            End If
        Next

        pdfDoc.Close()
    End Sub

    Sub titulo_reporte()
        dg_reporte.ColumnCount = 0
        dg_reporte.Columns.Add("Nº", "Nº")
        'dg_reporte.Columns.Add("reg_id", "reg_id")
        dg_reporte.Columns.Add("Patente", "Patente")
        dg_reporte.Columns.Add("Chofer", "chofer")
        dg_reporte.Columns.Add("Dia_Salida", "Dia Salida")
        dg_reporte.Columns.Add("Fecha_Salida", "Fecha Salida")
        dg_reporte.Columns.Add("Ruta", "Ruta")
        dg_reporte.Columns.Add("Dia_Entrada", "Dia Entrada")
        dg_reporte.Columns.Add("Fecha_Entrada", "Fecha Entrada")
        dg_reporte.Columns.Add("Peso_Bruto", "Peso Bruto (tn)")
        dg_reporte.Columns.Add("Peso_Tara", "Peso Tara (tn)")
        dg_reporte.Columns.Add("Neto", "Neto (tn)")

        dg_reporte.Columns("Nº").Width = 30
        'dg_reporte.Columns("reg_id").Visible = False
        dg_reporte.Columns("Patente").Width = 60
        dg_reporte.Columns("Chofer").Width = 170
        dg_reporte.Columns("Dia_Salida").Width = 65
        dg_reporte.Columns("Fecha_Salida").Width = 100
        dg_reporte.Columns("Ruta").Width = 590
        dg_reporte.Columns("Dia_Entrada").Width = 65
        dg_reporte.Columns("Fecha_Entrada").Width = 100
        dg_reporte.Columns("Peso_Bruto").Width = 40
        dg_reporte.Columns("Peso_Tara").Width = 40
        dg_reporte.Columns("Neto").Width = 40
    End Sub
    Sub mostrar_reporte()
        'exec registroS_search 0,'','','2022','05','','sunday','',''
        num = 0
        total_neto = 0

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

        Abrir()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select top 50 * from v_registro_s where pesobruto <>'' order by reg_fece"
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
            fecha_salida = dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y") + " " + dr("fecs_h") + ":" + dr("fecs_min")
            'End If
            ' MessageBox.Show(dr("fece_y"))
            neto = Math.Round((Val(dr("pesobruto")) - Val(dr("pesotara"))) / 1000, 1)
            fecha_entrada = dr("fece_d") + "-" + dr("fece_m") + "-" + dr("fece_y") + " " + dr("fece_h") + ":" + dr("fece_min")
            peso_bruto = Math.Round(Val(dr("pesobruto")) / 1000, 1)
            peso_tara = Math.Round(Val(dr("pesotara")) / 1000, 1)

            num += 1
            total_neto += neto
            dg_reporte.Rows.Add(num, dr("pat_nom"), dr("chofer"), dia, fecha_salida, matrix(str_, 1), dia1, fecha_entrada, peso_bruto, peso_tara, neto)
            str_ += 1
        End While
        Cerrar()
        ' If Check_edicion.Checked = False Then
        dg_reporte.ClearSelection()
        Lbl_total_neto.Text = Math.Round(total_neto, 1)
        str_ = 0
        ' End I
    End Sub
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titulo_reporte()
        mostrar_reporte()

        'Dim matrix = New String(0, 1) {} '{{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}
    End Sub
    Sub file_nom()
        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        ' String pdfFileName = String.Format("{0}_{1:yyyyMMdd_hhmm}.pdf", txtid.Text, DateTime.Now);
        'String pdfPath = Path.Combine(@"C:\Usuarios\Reporte", pdfFileName);

        'Dim ruta As String

        With SaveFileDialog
            .Title = "Guardar"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Archivos pdf (*.pdf)|*.pdf"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With
        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If

        pdfWrite = PdfWriter.GetInstance(pdfDoc, New FileStream(ruta, FileMode.Create))
    End Sub
    Sub buscador(b_day, b_month, b_year, fecha_desde, fecha_hasta)

        If Format(dt_day_b.Value, "dd") + "-" + Format(dt_month_b.Value, "MM") + "-" + Format(dt_year_b.Value, "yyyy") > Format(fec_hasta.Value, "dd-MM-yyyy") Then
            MsgBox("Ingresar FECHA FINAL, mayor o igual a FECHA INICIAL", vbInformation, "AUMENTAR FECHA FINAL")
            Exit Sub
        End If

        If fec_hasta.Checked = False Then
            If dt_year_b.Checked = True Then
                b_year = Format(dt_year_b.Value, "yyyy")

                If dt_month_b.Checked = True Then
                    b_month = Format(dt_month_b.Value, "MM")
                    'MessageBox.Show(month)
                End If
            Else
                Exit Sub
            End If
            'MessageBox.Show(year)
            fecha_hasta = ""
        Else

            b_year = Format(dt_year_b.Value, "yyyy")
            b_month = Format(dt_month_b.Value, "MM")

            fecha_desde = b_year + "-" + b_month + "-" + Format(dt_day_b.Value, "dd")
            fecha_hasta = Format(fec_hasta.Value, "yyyy-MM-dd")
        End If


        If Cbo_nom_day.SelectedIndex <> -1 Then
            Select Case Trim(Cbo_nom_day.Text)
                Case "Lunes"
                    b_day = "Monday"
                Case "Martes"
                    b_day = "Tuesday"
                Case "Miércoles"
                    b_day = "Wednesday"
                Case "Jueves"
                    b_day = "Thursday"
                Case "Viernes"
                    b_day = "Friday"
                Case "Sábado"
                    b_day = "Saturday"
                Case Else
                    b_day = "Sunday"
            End Select
        Else
            b_day = ""
        End If

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

        titulo_reporte()
        num = 0
        total_neto = 0
        Abrir()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "registro_report"
        cmd.Parameters.AddWithValue("@nomday", b_day)
        cmd.Parameters.AddWithValue("@fec_y", b_year)
        cmd.Parameters.AddWithValue("@fec_m", b_month)
        cmd.Parameters.AddWithValue("@fecha_desde", fecha_desde)
        cmd.Parameters.AddWithValue("@fecha_hasta", fecha_hasta)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim valor = dr("fecs_nomday")
            Dim valor1 = dr("fece_nomday")

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

            fecha_salida = dr("fecs_d") + "-" + dr("fecs_m") + "-" + dr("fecs_y") + " " + dr("fecs_h") + ":" + dr("fecs_min")
            neto = Math.Round((Val(dr("pesobruto")) - Val(dr("pesotara"))) / 1000, 1)
            fecha_entrada = dr("fece_d") + "-" + dr("fece_m") + "-" + dr("fece_y") + " " + dr("fece_h") + ":" + dr("fece_min")
            peso_bruto = Math.Round(Val(dr("pesobruto")) / 1000, 1)
            peso_tara = Math.Round(Val(dr("pesotara")) / 1000, 1)

            num += 1
            total_neto += neto
            dg_reporte.Rows.Add(num, dr("pat_nom"), dr("chofer"), dia, fecha_salida, matrix(str_, 1), dia1, fecha_entrada, peso_bruto, peso_tara, neto)
            str_ += 1
        End While
        Cerrar()
        cmd.Parameters.Clear()
        Lbl_total_neto.Text = Math.Round(total_neto, 1)
        str_ = 0
    End Sub
End Class
