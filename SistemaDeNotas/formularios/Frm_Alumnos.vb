Public Class Frm_Alumnos
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(316, 71)
        End Select
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        ' Guardar referencia al formulario principal ANTES de cerrar
        Dim principal As Frm_Principal = CType(Me.MdiParent, Frm_Principal)

        Me.Close()

        ' Luego cambiar el formulario central
        principal.CambiarFormularioCentral(New Frm_Presentacion())
    End Sub

    Private Sub Frm_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaClientes()
        CargarDatos() ' Cargar los datos al iniciar el formulario
    End Sub

    ' Método para insertar alumno
    Public Function Insertar_Aluno() As Boolean
        Dim no_carnet As String = txt_NoCarnet.Text
        Dim apellidos As String = txt_Apellidos.Text
        Dim nombres As String = txtNombres.Text
        Dim fecha_nacimiento As Date = dt_FechaNacimiento.Value
        Dim edad As Int16 = numeric_Edad.Value
        Dim no_cedula As String = txt_Cedula.Text
        Dim activo As String = If(CheckActivo.Checked, "1", "2")
        Dim direccion As String = txt_Direccion.Text
        Dim telefono As String = txt_Telefono.Text
        Dim carrera As String = txt_Carrera.Text
        Dim turno As String = cb_Turno.SelectedItem.ToString()


        ' SQL para insertar el nuevo cliente
        Dim SQL As String = "INSERT INTO ALUMNOS VALUES ('" & no_carnet & "', '" & apellidos & "', '" & nombres & "', '" & fecha_nacimiento & "', '" & edad & "', 
                            '" & no_cedula & "', '" & direccion & "', '" & telefono & "', '" & carrera & "', '" & turno & "', '" & activo & "');"

        ' Llamamos a la función Consulta_Segura del módulo Variables
        Try
            Variables.Consulta_Segura(SQL, Nothing) ' Ejecutar la consulta para insertar
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar el cliente: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub TablaClientes()
        ListView1.Columns.Add("No. carnet", 100)
        ListView1.Columns.Add("Nombres", 150)
        ListView1.Columns.Add("Apellidos", 150)
        ListView1.Columns.Add("Fecha nacimiento", 100)
        ListView1.Columns.Add("edad", 100)
        ListView1.Columns.Add("No. cedula", 100)
        ListView1.Columns.Add("Direccion", 100)
        ListView1.Columns.Add("No. telefono", 100)
        ListView1.Columns.Add("Carrera", 100)
        ListView1.Columns.Add("turno", 100)
        ListView1.Columns.Add("Activo", 100)
    End Sub

    ' Método para cargar los datos en el ListView
    Private Sub CargarDatos()
        ' SQL para obtener los usuarios
        Dim SQL As String = "SELECT * FROM ALUMNOS"

        Dim RS As Odbc.OdbcDataReader = Nothing
        RS = Variables.Consulta_Segura(SQL, RS) ' Llamamos a la consulta segura

        ListView1.Items.Clear()

        If RS.HasRows Then
            While RS.Read()
                Dim item As New ListViewItem(RS("NO_CARNET").ToString())
                item.SubItems.Add(RS("NOMBRES").ToString())
                item.SubItems.Add(RS("APELLIDOS").ToString())
                item.SubItems.Add(RS("FECHA_NAC").ToString())
                item.SubItems.Add(RS("EDAD").ToString())
                item.SubItems.Add(RS("NO_CEDULA").ToString())
                item.SubItems.Add(RS("DIRECCION").ToString())
                item.SubItems.Add(RS("TELEFONO").ToString())
                item.SubItems.Add(RS("CARRERA").ToString())
                item.SubItems.Add(RS("TURNO").ToString())
                item.SubItems.Add(RS("ACTIVO").ToString())
                ListView1.Items.Add(item)
            End While
        End If

        Variables.Cierra_Conexion() ' Cerramos la conexión
    End Sub

    ' Método para eliminar un cliente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim no_carnet As String = txt_NoCarnet.Text

        ' SQL para eliminar el usuario
        Dim SQL As String = "DELETE FROM ALUMNOS WHERE NO_CARNET = '" & no_carnet & "'"

        Try
            Variables.Consulta_Segura(SQL, Nothing) ' Ejecutamos la consulta para eliminar
            CargarDatos() ' Recargar los datos después de eliminar
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Insertar_Aluno() Then
            CargarDatos() ' Cargar nuevamente los datos después de la inserción
        End If
    End Sub
End Class