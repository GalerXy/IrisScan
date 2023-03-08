Imports System.Net
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Data.OleDb
Imports System.Net.Mail
Public Class Exportación

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox_txt_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button_TXT.Click
        Dim filename As String = "C:\IrisScan\archivo.txt"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
        For Each item As Object In Datos.ListBox1.Items
            file.WriteLine(item)
        Next
        file.Close()
        MsgBox("Exportación completada")
    End Sub

    Private Sub Button_Excel_Click(sender As System.Object, e As System.EventArgs) Handles Button_Excel.Click
        Dim xlApp As Excel.Application = New Excel.Application()
        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Sheets(1)

        xlWorksheet.Cells(1, 1).Value = "CODIGO"
        xlWorksheet.Cells(1, 2).Value = "NOMBRE"
        xlWorksheet.Cells(1, 3).Value = "IP"
        For i = 0 To Datos.ListBox1.Items.Count - 1
            Dim items As String = Datos.ListBox1.Items(i)
            Dim elementos As String() = items.Split(","c)
            For j = 0 To UBound(elementos)
                MsgBox(elementos(j))
                xlWorksheet.Cells(i + 2, j + 1).value = elementos(j)
            Next
        Next
        xlWorkbook.SaveAs("C:\IrisScan\file1.xlsx")
        xlWorkbook.Close()
        xlApp.Quit()
        MsgBox("Exportacion Completada")
    End Sub

    Private Sub Button_SMTP_Click(sender As System.Object, e As System.EventArgs) Handles Button_SMTP.Click
        'Definimos un nuevo objeto de clase para el EMAIL y para el cliente SMTP'
        Dim correo As New MailMessage
        Dim envio As New SmtpClient

        'Creamos el EMAIL mediante los campos del formulario'

        correo.To.Clear()
        'Contenido vacío para evitar errores'
        correo.Body = ""
        'Asunto vacío para evitar errores'
        correo.Subject = ""
        'Contenido de la txtbox'
        For Each item In Datos.ListBox1.Items
            correo.Body += item.ToString() & vbCrLf
        Next
        'Asunto de la txtbox'
        correo.Subject = "Este es el contenido que se ha registrado"
        '
        correo.IsBodyHtml = True
        'Dirección de destino'
        correo.To.Add(Trim(TextBox_Correo.Text))

        'Credenciales de envío'

        'Correo emisor'
        correo.From = New MailAddress("ale25rojanogo@gmail.com")
        'Credenciales correo emisor'
        envio.Credentials = New NetworkCredential("ale25rojanogo@gmail.com", "guqtksslzpjocxpw")

        'Servidor SMTP y protocolo seguro'
        envio.Host = "smtp.gmail.com"
        envio.Port = 587
        envio.EnableSsl = True

        'Enviar el correo'
        envio.Send(correo)
        MsgBox("El mensaje fue enviado correctamente. ")
    End Sub

    Private Sub Button_ACCESS_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Button_Salir.Click
        End
    End Sub
End Class