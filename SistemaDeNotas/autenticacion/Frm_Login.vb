Public Class Frm_Login

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Limpiando campos
        Txt_Login.Text = ""
        Txt_Password.Text = ""
        Txt_Login.Focus()

        'Desbloqueando Campos
        Txt_Login.ReadOnly = False
        Txt_Password.ReadOnly = False
        Pb_Tiempo.Visible = False
    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        On Error GoTo HORROR

        If Txt_Login.Text = "" Or Txt_Password.Text = "" Then
            MessageBox.Show("Debe de digitar el Usuario o el Password!!!", SISTEMA,
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        CONSULTA = "SELECT Usuario,Nombre_Usuario,Tipo_Usuario FROM Usuarios " &
               "WHERE (Usuario = '" & Txt_Login.Text.Trim() & "') AND (Clave = '" & Txt_Password.Text.Trim() & "') AND (Activo = 1)"
        RS_CONSULTA = Variables.Consulta_Segura(CONSULTA, RS_CONSULTA)

        If RS_CONSULTA.HasRows = True Then
            RS_CONSULTA.Read()
            LOGIN_USER = RS_CONSULTA.Item(0).ToString
            NOMBRE_USER = RS_CONSULTA.Item(1).ToString
            TIPO_USER = RS_CONSULTA.Item(2).ToString
            Call Variables.Cierra_Conexion()
            RS_CONSULTA.Close()

            ' Mostrar progreso
            Pb_Tiempo.Visible = True
            Pb_Tiempo.Minimum = 0
            Pb_Tiempo.Maximum = 10
            Pb_Tiempo.Value = 0

            Timer1.Interval = 30
            Timer1.Start()

        Else
            MessageBox.Show("Cuenta de Acceso No Existe o está de Baja!!!", SISTEMA,
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_Login.Text = ""
            Txt_Password.Text = ""
            Txt_Password.UseSystemPasswordChar = True
            Txt_Login.Focus()
        End If

        Exit Sub

HORROR:
        MessageBox.Show("Datos Incorrectos de la Cuenta de Acceso!!!", SISTEMA,
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Txt_Login.Text = ""
        Txt_Password.Text = ""
        Txt_Login.Focus()
        Txt_Password.Focus()
    End Sub

    Private Sub Txt_Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Login.KeyPress
        'Ir al otro control
        If e.KeyChar = Chr(Keys.Enter) Then
            Txt_Password.Focus()
        End If
    End Sub

    Private Sub Txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Password.KeyPress
        'Ir al otro control
        If e.KeyChar = Chr(Keys.Enter) Then
            Btn_Ok_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        'Cerrando la aplicación
        Dim Respuesta As DialogResult
        Respuesta = MessageBox.Show("¿Desea Salir del Sistema?", SISTEMA,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Respuesta = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Pb_Tiempo.Value < Pb_Tiempo.Maximum Then
            Pb_Tiempo.Value += 1
        Else
            Timer1.Stop()
            Pb_Tiempo.Visible = False

            ' Mostrar el siguiente formulario y cerrar este
            Frm_Principal.Show()
            Me.Dispose()
        End If
    End Sub
End Class
