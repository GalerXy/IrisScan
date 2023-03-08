<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exportación
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exportación))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_TXT = New System.Windows.Forms.Button()
        Me.Button_Excel = New System.Windows.Forms.Button()
        Me.Button_SMTP = New System.Windows.Forms.Button()
        Me.TextBox_Correo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DONDE LO QUIERES EXPORTAR"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button_TXT
        '
        Me.Button_TXT.BackColor = System.Drawing.Color.Transparent
        Me.Button_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_TXT.Location = New System.Drawing.Point(121, 127)
        Me.Button_TXT.Name = "Button_TXT"
        Me.Button_TXT.Size = New System.Drawing.Size(112, 32)
        Me.Button_TXT.TabIndex = 6
        Me.Button_TXT.Text = "TXT"
        Me.Button_TXT.UseVisualStyleBackColor = False
        '
        'Button_Excel
        '
        Me.Button_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Excel.Location = New System.Drawing.Point(239, 128)
        Me.Button_Excel.Name = "Button_Excel"
        Me.Button_Excel.Size = New System.Drawing.Size(112, 31)
        Me.Button_Excel.TabIndex = 7
        Me.Button_Excel.Text = "EXCEL"
        Me.Button_Excel.UseVisualStyleBackColor = True
        '
        'Button_SMTP
        '
        Me.Button_SMTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SMTP.Location = New System.Drawing.Point(357, 129)
        Me.Button_SMTP.Name = "Button_SMTP"
        Me.Button_SMTP.Size = New System.Drawing.Size(118, 30)
        Me.Button_SMTP.TabIndex = 9
        Me.Button_SMTP.Text = "CORREO"
        Me.Button_SMTP.UseVisualStyleBackColor = True
        '
        'TextBox_Correo
        '
        Me.TextBox_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Correo.Location = New System.Drawing.Point(378, 258)
        Me.TextBox_Correo.Name = "TextBox_Correo"
        Me.TextBox_Correo.Size = New System.Drawing.Size(214, 22)
        Me.TextBox_Correo.TabIndex = 10
        Me.TextBox_Correo.Text = "tucorreo@ejemplo.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dirección de correo a la que se desea exportar"
        '
        'Button_Salir
        '
        Me.Button_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salir.Location = New System.Drawing.Point(146, 246)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(118, 34)
        Me.Button_Salir.TabIndex = 12
        Me.Button_Salir.Text = "SALIR"
        Me.Button_Salir.UseVisualStyleBackColor = True
        '
        'Exportación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(604, 306)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Correo)
        Me.Controls.Add(Me.Button_SMTP)
        Me.Controls.Add(Me.Button_Excel)
        Me.Controls.Add(Me.Button_TXT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Exportación"
        Me.Text = "Exportación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button_TXT As System.Windows.Forms.Button
    Friend WithEvents Button_Excel As System.Windows.Forms.Button
    Friend WithEvents Button_SMTP As System.Windows.Forms.Button
    Friend WithEvents TextBox_Correo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_Salir As System.Windows.Forms.Button
End Class
