<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IrisScan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IrisScan))
        Me.TextBox_Code = New System.Windows.Forms.TextBox()
        Me.IP = New System.Windows.Forms.Label()
        Me.TextBox_IP = New System.Windows.Forms.TextBox()
        Me.Button_TEST = New System.Windows.Forms.Button()
        Me.Button_SALIR = New System.Windows.Forms.Button()
        Me.Button_NEXT = New System.Windows.Forms.Button()
        Me.TextBox_COM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_IPINI = New System.Windows.Forms.TextBox()
        Me.TextBox_IPFI = New System.Windows.Forms.TextBox()
        Me.Funcionamiento = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Funcionamiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_Code
        '
        Me.TextBox_Code.Location = New System.Drawing.Point(714, 91)
        Me.TextBox_Code.Name = "TextBox_Code"
        Me.TextBox_Code.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Code.TabIndex = 1
        Me.TextBox_Code.Text = "1"
        '
        'IP
        '
        Me.IP.AutoSize = True
        Me.IP.BackColor = System.Drawing.Color.Transparent
        Me.IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IP.Location = New System.Drawing.Point(194, 304)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(95, 20)
        Me.IP.TabIndex = 3
        Me.IP.Text = "RANGO IP"
        '
        'TextBox_IP
        '
        Me.TextBox_IP.Location = New System.Drawing.Point(356, 304)
        Me.TextBox_IP.Name = "TextBox_IP"
        Me.TextBox_IP.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IP.TabIndex = 8
        Me.TextBox_IP.Text = "192.168.0."
        '
        'Button_TEST
        '
        Me.Button_TEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_TEST.Location = New System.Drawing.Point(12, 218)
        Me.Button_TEST.Name = "Button_TEST"
        Me.Button_TEST.Size = New System.Drawing.Size(142, 39)
        Me.Button_TEST.TabIndex = 12
        Me.Button_TEST.Text = "TEST"
        Me.Button_TEST.UseVisualStyleBackColor = True
        '
        'Button_SALIR
        '
        Me.Button_SALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SALIR.Location = New System.Drawing.Point(12, 263)
        Me.Button_SALIR.Name = "Button_SALIR"
        Me.Button_SALIR.Size = New System.Drawing.Size(143, 39)
        Me.Button_SALIR.TabIndex = 14
        Me.Button_SALIR.Text = "SALIR"
        Me.Button_SALIR.UseVisualStyleBackColor = True
        '
        'Button_NEXT
        '
        Me.Button_NEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_NEXT.Location = New System.Drawing.Point(27, 389)
        Me.Button_NEXT.Name = "Button_NEXT"
        Me.Button_NEXT.Size = New System.Drawing.Size(107, 38)
        Me.Button_NEXT.TabIndex = 15
        Me.Button_NEXT.Text = "NEXT"
        Me.Button_NEXT.UseVisualStyleBackColor = True
        '
        'TextBox_COM
        '
        Me.TextBox_COM.Location = New System.Drawing.Point(533, 387)
        Me.TextBox_COM.Multiline = True
        Me.TextBox_COM.Name = "TextBox_COM"
        Me.TextBox_COM.Size = New System.Drawing.Size(52, 40)
        Me.TextBox_COM.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "LEYENDA"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(20, 150)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 39)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Lime
        Me.TextBox2.Location = New System.Drawing.Point(20, 105)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(52, 39)
        Me.TextBox2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(78, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "OK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(78, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "FALLO"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(194, 404)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(262, 23)
        Me.ProgressBar1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(194, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "IP FINAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(194, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "IP INICIAL"
        '
        'TextBox_IPINI
        '
        Me.TextBox_IPINI.Location = New System.Drawing.Point(356, 333)
        Me.TextBox_IPINI.Name = "TextBox_IPINI"
        Me.TextBox_IPINI.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IPINI.TabIndex = 26
        Me.TextBox_IPINI.Text = "1"
        '
        'TextBox_IPFI
        '
        Me.TextBox_IPFI.Location = New System.Drawing.Point(356, 363)
        Me.TextBox_IPFI.Name = "TextBox_IPFI"
        Me.TextBox_IPFI.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IPFI.TabIndex = 27
        Me.TextBox_IPFI.Text = "255"
        '
        'Funcionamiento
        '
        Me.Funcionamiento.BackColor = System.Drawing.Color.Transparent
        Me.Funcionamiento.Controls.Add(Me.Label4)
        Me.Funcionamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Funcionamiento.ForeColor = System.Drawing.SystemColors.Control
        Me.Funcionamiento.Location = New System.Drawing.Point(274, 28)
        Me.Funcionamiento.Name = "Funcionamiento"
        Me.Funcionamiento.Size = New System.Drawing.Size(325, 116)
        Me.Funcionamiento.TabIndex = 28
        Me.Funcionamiento.TabStop = False
        Me.Funcionamiento.Text = "GroupBox1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 48)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "En este apartado, se debe de introducir en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el apartado RANGO IP su IP de la mane" & _
    "ra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que está ilustada abajo"
        '
        'IrisScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(611, 469)
        Me.Controls.Add(Me.Funcionamiento)
        Me.Controls.Add(Me.TextBox_IPFI)
        Me.Controls.Add(Me.TextBox_IPINI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_COM)
        Me.Controls.Add(Me.Button_NEXT)
        Me.Controls.Add(Me.Button_SALIR)
        Me.Controls.Add(Me.Button_TEST)
        Me.Controls.Add(Me.TextBox_IP)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.TextBox_Code)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IrisScan"
        Me.Text = "IrisScan"
        Me.Funcionamiento.ResumeLayout(False)
        Me.Funcionamiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Code As System.Windows.Forms.TextBox
    Friend WithEvents IP As System.Windows.Forms.Label
    Friend WithEvents TextBox_IP As System.Windows.Forms.TextBox
    Friend WithEvents Button_TEST As System.Windows.Forms.Button
    Friend WithEvents Button_SALIR As System.Windows.Forms.Button
    Friend WithEvents Button_NEXT As System.Windows.Forms.Button
    Friend WithEvents TextBox_COM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_IPINI As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_IPFI As System.Windows.Forms.TextBox
    Friend WithEvents Funcionamiento As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
