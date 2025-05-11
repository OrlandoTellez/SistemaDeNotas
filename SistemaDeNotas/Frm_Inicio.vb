Public Class Frm_Inicio
    'medidor del tiempo
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static btecontenedor As Byte
        If btecontenedor = 1 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
            Frm_Login.Show()
        Else
            btecontenedor = btecontenedor + 1
        End If
    End Sub
    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pb_Tiempo.Visible = True
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando la aplicacion
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            Application.Exit()
        End If
    End Sub
End Class