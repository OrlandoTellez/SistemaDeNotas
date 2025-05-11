Public Class Frm_Menu
    'Procedimiento que Inmoviliza a un formulario en un Punto de la Pantalla
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        Select Case m.Msg
            Case WM_MOVE
                Me.Location = New Point(0, 71)
        End Select
    End Sub
    Private Sub Frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando la aplicacion
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            Application.Exit()
        End If
    End Sub

    ' Botón para registrar usuarios
    Private Sub Btn_RegistrarUsuarios_Click(sender As Object, e As EventArgs) Handles Btn_RegistrarUsuarios.Click
        ' Crear y mostrar el formulario de usuarios
        Dim Frm_Usuarios As New Frm_Usuarios
        Frm_Usuarios.Show()

        ' Cerrar el formulario principal después de ocultar los formularios hijos
        CloseMainForm()
    End Sub

    ' Método para cerrar el formulario principal
    Private Sub CloseMainForm()
        ' cerrar todos los formularios hijos MDI
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        ' Cerrar el formulario principal
        Dim parentForm As Form = Me.MdiParent
        If parentForm IsNot Nothing Then
            parentForm.Close()
        End If
    End Sub
End Class