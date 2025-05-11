Public Class Frm_Inicio
    'medidor del tiempo
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Pb_Tiempo.Value < Pb_Tiempo.Maximum Then
            Pb_Tiempo.Value += 1
        Else
            Timer1.Stop()
            Pb_Tiempo.Visible = False

            ' abrir el siguiente formulario
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
            Frm_Login.Show()
        End If
    End Sub
    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pb_Tiempo.Visible = True
        Pb_Tiempo.Minimum = 0
        Pb_Tiempo.Maximum = 50
        Pb_Tiempo.Value = 0

        Timer1.Interval = 1 ' Intervalo de 1 milisegundo
        Timer1.Start()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando la aplicacion
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = vbYes) Then
            Application.Exit()
        End If
    End Sub
End Class