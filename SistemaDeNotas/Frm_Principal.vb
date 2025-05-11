Public Class Frm_Principal
    ' Variables de usuario y sistema
    Private SISTEMA As String = "Sistema de Gestión"
    Private LOGIN_USER As String = "usuario01"
    Private NOMBRE_USER As String = "Juan Pérez"
    Private TIPO_USER As String = "Administrador"
    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'visualizando el formulario Encabezado
        Frm_Encabezado.MdiParent = Me
        Frm_Encabezado.Show()

        'visualizando el formulario menú
        Frm_Menu.MdiParent = Me
        Frm_Menu.Show()

        'Visualizando el Formulario Presentación
        Frm_Presentacion.MdiParent = Me
        Frm_Presentacion.Show()

        'visualizando el formulario pie de página
        Frm_Piedepagina.MdiParent = Me
        Frm_Piedepagina.Show()

        Me.Text = SISTEMA
        ' Asegúrate de que haya 3 elementos en el StatusStrip
        If Me.Stb_Barra_Estado.Items.Count >= 3 Then
            Me.Stb_Barra_Estado.Items(0).Text = "USUARIO: " & LOGIN_USER & Space(5) &
                                                "NOMBRE: " & NOMBRE_USER & Space(5) &
                                                "TIPO: " & TIPO_USER

            Me.Stb_Barra_Estado.Items(1).Text = UCase(Format(Now, "Short Date"))
            Me.Stb_Barra_Estado.Items(2).Text = UCase(Format(Now, "hh:mm tt"))
        End If
    End Sub

End Class
