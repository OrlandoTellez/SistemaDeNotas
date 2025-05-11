Public Class Frm_Principal
    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'visualizando el formulario Encabezado
        Frm_Encabezado.MdiParent = Me
        Frm_Encabezado.Show()

        'visualizando el formulario menú
        Frm_Menu.MdiParent = Me
        Frm_Menu.Show()

        'Visualizando el Formulario Presentación
        'Frm_Presentacion.MdiParent = Me
        'Frm_Presentacion.Show()

        'visualizando el formulario pie de página
        Frm_Piedepagina.MdiParent = Me
        Frm_Piedepagina.Show()

        'Me.Text = SISTEMA
        'Me.Stb_Barra_Estado.Items(0).Text = Space(0) & "USUARIO: " & LOGIN_USER & Space(15) &
        '    "NOMBRE DEL USUARIO: " & NOMBRE_USER & Space(15) & "TIPO DE CUENTA: " & TIPO_USER
        'Me.Stb_Barra_Estado.Items(1).Text = UCase(Format(Now, "SHORT DATE"))
        'Me.Stb_Barra_Estado.Items(2).Text = UCase(Format(Now, "hh:mm: tt"))
    End Sub
End Class
