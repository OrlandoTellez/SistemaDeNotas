Imports System.Data.Odbc

Public Class Frm_Usuarios

    Private Sub Frm_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaClientes()
        CargarDatos() ' Cargar los datos al iniciar el formulario
    End Sub

    ' Método para insertar cliente
    Public Function Insertar_Clientes() As Boolean
        Dim ID_Usuario As String = txt_idUsuario.Text
        Dim Usuario As String = txt_Usuario.Text
        Dim Clave As String = txtPass.Text
        Dim Nombre_Usuario As String = txt_NomUsu.Text
        Dim Tipo_Usuario As String = cb_tipoUsu.SelectedItem.ToString()
        Dim Activo As String = If(CheckActivo.Checked, "1", "2")

        ' SQL para insertar el nuevo cliente
        Dim SQL As String = "INSERT INTO Usuarios (ID_Usuario, Usuario, Clave, Nombre_Usuario, Tipo_Usuario, Activo) 
                             VALUES ('" & ID_Usuario & "', '" & Usuario & "', '" & Clave & "', '" & Nombre_Usuario & "', '" & Tipo_Usuario & "', '" & Activo & "')"

        ' Llamamos a la función Consulta_Segura del módulo Variables
        Try
            Variables.Consulta_Segura(SQL, Nothing) ' Ejecutar la consulta para insertar
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar el cliente: " & ex.Message)
            Return False
        End Try
    End Function

    ' Evento del botón Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Insertar_Clientes() Then
            CargarDatos() ' Cargar nuevamente los datos después de la inserción
        End If
    End Sub

    ' Configurar las columnas del ListView
    Private Sub TablaClientes()
        ListView1.Columns.Add("ID Usuario", 100)
        ListView1.Columns.Add("Usuario", 150)
        ListView1.Columns.Add("Nombre Usuario", 150)
        ListView1.Columns.Add("Tipo Usuario", 100)
        ListView1.Columns.Add("Activo", 100)
    End Sub

    ' Método para cargar los datos en el ListView
    Private Sub CargarDatos()
        ' SQL para obtener los usuarios
        Dim SQL As String = "SELECT ID_Usuario, Usuario, Nombre_Usuario, Tipo_Usuario, Activo FROM Usuarios"

        Dim RS As Odbc.OdbcDataReader = Nothing
        RS = Variables.Consulta_Segura(SQL, RS) ' Llamamos a la consulta segura

        ListView1.Items.Clear()

        If RS.HasRows Then
            While RS.Read()
                Dim item As New ListViewItem(RS("ID_Usuario").ToString())
                item.SubItems.Add(RS("Usuario").ToString())
                item.SubItems.Add(RS("Nombre_Usuario").ToString())
                item.SubItems.Add(RS("Tipo_Usuario").ToString())
                item.SubItems.Add(RS("Activo").ToString())
                ListView1.Items.Add(item)
            End While
        End If

        Variables.Cierra_Conexion() ' Cerramos la conexión
    End Sub

    ' Método para eliminar un cliente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ID_Usuario As String = txt_idUsuario.Text

        ' SQL para eliminar el usuario
        Dim SQL As String = "DELETE FROM Usuarios WHERE ID_Usuario = '" & ID_Usuario & "'"

        Try
            Variables.Consulta_Segura(SQL, Nothing) ' Ejecutamos la consulta para eliminar
            CargarDatos() ' Recargar los datos después de eliminar
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Dim Frm_Principal As New Frm_Principal
        Frm_Principal.Show()
        Close()
    End Sub
End Class
