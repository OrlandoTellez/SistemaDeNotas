﻿Public Class Frm_Menu
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
        Dim principal As Frm_Principal = CType(Me.MdiParent, Frm_Principal)
        principal.CambiarFormularioCentral(New Frm_Usuarios())
    End Sub

    Private Sub Btn_Alumnos_Click(sender As Object, e As EventArgs) Handles Btn_Alumnos.Click
        Dim principal As Frm_Principal = CType(Me.MdiParent, Frm_Principal)
        principal.CambiarFormularioCentral(New Frm_Alumnos())
    End Sub

    Private Sub Btn_Notas_Click(sender As Object, e As EventArgs) Handles Btn_Notas.Click
        Dim principal As Frm_Principal = CType(Me.MdiParent, Frm_Principal)
        principal.CambiarFormularioCentral(New Frm_Notas())
    End Sub
End Class