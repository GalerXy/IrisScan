Imports System.Net
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Data.OleDb
Imports System.Net.Mail
Public Class Sesión


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Este programa solo funciona con privilegios de administrador, si no los tienes activados, activalos.")
        MessageBox.Show("Para el correcto funcionamiento de este programa, es importante pasar un inicio de sesion.")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       'Crear la cadena de conexión a la base de datos Access
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\IrisScan\users.accdb"

        'Crear la conexión a la base de datos
        Dim connection As New OleDbConnection(connectionString)

        Try

            'Verificar si las TextBox tienen valores
            If String.IsNullOrEmpty(TextBox_USR.Text) OrElse String.IsNullOrEmpty(TextBox_PASS.Text) Then
                'Mostrar un mensaje de error y salir del bloque Try
                MessageBox.Show("Por favor, ingrese valores en ambas cajas de texto.")
                Exit Try
            End If

            'Abrir la conexión a la base de datos
            connection.Open()

            'Crear el comando SQL para insertar los datos en la base de datos

            Dim command As New OleDbCommand("INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @contraseña)", connection)

            'Agregar los parámetros al comando SQL
            command.Parameters.AddWithValue("@usuario", TextBox_USR.Text)
            command.Parameters.AddWithValue("@contraseña", TextBox_PASS.Text)

            'Ejecutar el comando SQL
            command.ExecuteNonQuery()

            'Mostrar un mensaje indicando que los datos se registraron correctamente
            MessageBox.Show("Los datos se registraron correctamente.")

        Catch ex As Exception
            'Mostrar un mensaje de error si no se pudieron registrar los datos
            MessageBox.Show("No se pudieron registrar los datos: " & ex.Message)

        Finally
            'Cerrar la conexión a la base de datos
            connection.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If TextBox_USR.Text = "" Then
            MsgBox("Debes de introducir un usuario")
        End If

        If TextBox_PASS.Text = "" Then
            MsgBox("Debes de introducir una contraseña")
        End If

        ' Definir la cadena de conexión a la base de datos
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\IrisScan\users.accdb"

        ' Crear una nueva conexión a la base de datos
        Dim connection As New OleDbConnection(connectionString)

        ' Definir la consulta SQL para buscar el usuario y la contraseña
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña"

        ' Crear un nuevo comando y asignar la consulta SQL y la conexión
        Dim command As New OleDbCommand(query, connection)

        ' Definir los parámetros de la consulta SQL
        command.Parameters.AddWithValue("@usuario", TextBox_USR.Text)
        command.Parameters.AddWithValue("@contraseña", TextBox_PASS.Text)

        ' Abrir la conexión a la base de datos
        connection.Open()

        ' Ejecutar la consulta SQL y almacenar el resultado en una variable
        Dim result As Integer = CInt(command.ExecuteScalar())

        ' Cerrar la conexión a la base de datos
        connection.Close()

        ' Verificar si se encontró un usuario y contraseña coincidentes
        If result > 0 Then
            ' Si se encontró una coincidencia, el usuario inició sesión correctamente
            MsgBox("Inicio de sesión exitoso")

            ' Permitir el acceso al siguiente formulario
            Me.Hide()
            IrisScan.Show()

        Else
            ' Si no se encontró una coincidencia, el usuario ingresó credenciales incorrectas
            MsgBox("Credenciales incorrectas")

            ' No permitir el acceso al siguiente formulario
        End If
    End Sub
End Class