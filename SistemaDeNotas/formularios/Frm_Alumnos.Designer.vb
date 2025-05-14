<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Alumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Alumnos))
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.cb_Turno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Apellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NoCarnet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Carrera = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.numeric_Edad = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.numeric_Edad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(288, 149)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(55, 17)
        Me.CheckActivo.TabIndex = 48
        Me.CheckActivo.Text = "activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'cb_Turno
        '
        Me.cb_Turno.FormattingEnabled = True
        Me.cb_Turno.Items.AddRange(New Object() {"Vespertino", "Matutino"})
        Me.cb_Turno.Location = New System.Drawing.Point(766, 278)
        Me.cb_Turno.Name = "cb_Turno"
        Me.cb_Turno.Size = New System.Drawing.Size(203, 21)
        Me.cb_Turno.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(216, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "TELÉFONO"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(350, 179)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(221, 20)
        Me.txtNombres.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(216, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "APELLIDOS"
        '
        'txt_Apellidos
        '
        Me.txt_Apellidos.Location = New System.Drawing.Point(164, 179)
        Me.txt_Apellidos.Name = "txt_Apellidos"
        Me.txt_Apellidos.Size = New System.Drawing.Size(196, 20)
        Me.txt_Apellidos.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(64, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "ALUMNO:"
        '
        'txt_NoCarnet
        '
        Me.txt_NoCarnet.Location = New System.Drawing.Point(164, 147)
        Me.txt_NoCarnet.Name = "txt_NoCarnet"
        Me.txt_NoCarnet.Size = New System.Drawing.Size(118, 20)
        Me.txt_NoCarnet.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(64, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "No. Carnet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(19, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Datos generales de los Estudiantes:"
        '
        'ListView1
        '
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(23, 333)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(975, 255)
        Me.ListView1.TabIndex = 32
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 67)
        Me.Panel1.TabIndex = 31
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(953, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(45, 40)
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de alumnos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(419, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "NOMBRES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(575, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 18)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "FECHA DE NACIMIENTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(839, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "EDAD"
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(164, 233)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(196, 20)
        Me.txt_Cedula.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label10.Location = New System.Drawing.Point(216, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 18)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "NO. CÉDULA"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(350, 233)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(619, 20)
        Me.txt_Direccion.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label11.Location = New System.Drawing.Point(565, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "DIRECCIÓN"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(164, 279)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(196, 20)
        Me.txt_Telefono.TabIndex = 62
        '
        'txt_Carrera
        '
        Me.txt_Carrera.Location = New System.Drawing.Point(350, 279)
        Me.txt_Carrera.Name = "txt_Carrera"
        Me.txt_Carrera.Size = New System.Drawing.Size(421, 20)
        Me.txt_Carrera.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(507, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "CARRERA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label13.Location = New System.Drawing.Point(839, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 18)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "TURNO"
        '
        'dt_FechaNacimiento
        '
        Me.dt_FechaNacimiento.Location = New System.Drawing.Point(568, 179)
        Me.dt_FechaNacimiento.Name = "dt_FechaNacimiento"
        Me.dt_FechaNacimiento.Size = New System.Drawing.Size(203, 20)
        Me.dt_FechaNacimiento.TabIndex = 66
        '
        'numeric_Edad
        '
        Me.numeric_Edad.Location = New System.Drawing.Point(766, 179)
        Me.numeric_Edad.Name = "numeric_Edad"
        Me.numeric_Edad.Size = New System.Drawing.Size(203, 20)
        Me.numeric_Edad.TabIndex = 67
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(842, 74)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(31, 21)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 74
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(578, 74)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 73
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(317, 74)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 21)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 72
        Me.PictureBox4.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(766, 65)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(263, 40)
        Me.btnEditar.TabIndex = 71
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(510, 65)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(261, 40)
        Me.btnEliminar.TabIndex = 70
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(245, 65)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(269, 40)
        Me.btnGuardar.TabIndex = 69
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(0, 65)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(248, 40)
        Me.btnAgregar.TabIndex = 68
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(67, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'Frm_Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 600)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.numeric_Edad)
        Me.Controls.Add(Me.dt_FechaNacimiento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_Carrera)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Cedula)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.cb_Turno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Apellidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_NoCarnet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Alumnos"
        Me.Text = "Frm_Alumnos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numeric_Edad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents cb_Turno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Apellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_NoCarnet As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_Direccion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Telefono As TextBox
    Friend WithEvents txt_Carrera As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dt_FechaNacimiento As DateTimePicker
    Friend WithEvents numeric_Edad As NumericUpDown
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
