Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Net.Dns

Public Class IrisScan

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button_TEST.Click

        Dim ip As String = TextBox_IP.Text 'Dirección IP
        Dim ping As New Ping()

        ProgressBar1.Value = 0 'Establecer el valor inicial de la barra de progreso
        ProgressBar1.Maximum = TextBox_IPFI.Text 'Establecer el valor máximo de la barra de progreso
        For i As Integer = TextBox_IPINI.Text To TextBox_IPFI.Text 'Recorrer todas las IP
            Dim contador As Integer
            If My.Computer.Network.Ping(ip & i) Then
                contador = contador + 1
                Try
                    Dim hostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(ip & i)
                    Datos.ListBox1.Items.Add(contador) 'Codigo autonumerico
                    Datos.ListBox1.Items.Add(hostEntry.HostName) ' Nombre de la maquina
                    Datos.ListBox1.Items.Add(ip & i) 'Agregar la direccion a la lista
                Catch ex As Exception
                    Datos.ListBox1.Items.Add(contador & " - " & "APAGADO" & " - " & ip & i)
                End Try
                
            End If
            ProgressBar1.Value = i 'Actualizar el valor de la barra de progreso
            If ProgressBar1.Value <> 0 Then
                TextBox_COM.BackColor = Color.Green
            End If
            If Datos.ListBox1.Items.Count = 0 Then
                TextBox_COM.BackColor = Color.Red
            End If
        Next

    End Sub

    Private Sub Button_NEXT_Click(sender As System.Object, e As System.EventArgs) Handles Button_NEXT.Click
        Me.Hide()
        Datos.Show()
    End Sub

    Private Sub Button_INTODUCIR_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub TextBox_Code_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_Code.TextChanged

    End Sub

    Private Sub Button_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles Button_SALIR.Click
        End
    End Sub

    Private Sub IP_Click(sender As System.Object, e As System.EventArgs) Handles IP.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
