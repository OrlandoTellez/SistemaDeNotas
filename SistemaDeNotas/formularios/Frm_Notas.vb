Imports System.Data
Imports System.Data.Odbc

Public Class Frm_Notas

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Const WM_MOVE As Int32 = &H3
        If m.Msg = WM_MOVE Then Me.Location = New Point(316, 71)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Dim principal As Frm_Principal = CType(Me.MdiParent, Frm_Principal)
        Me.Close()
        principal.CambiarFormularioCentral(New Frm_Presentacion())
    End Sub

    Private Sub Frm_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaNotas()
        CargarDatos()
    End Sub

    Public Function Insertar_Notas() As Boolean
        Try
            ' Parsear valores y escapar apóstrofos
            Dim idNota = Integer.Parse(txt_idNota.Text)
            Dim noCarnet = Integer.Parse(txt_NoCarnet.Text)
            Dim apellidos = txt_Apellidos.Text.Replace("'", "''")
            Dim nombres = txt_Nombres.Text.Replace("'", "''")
            Dim docente = txt_Docente.Text.Replace("'", "''")
            Dim becadoSN = If(cb_Becado.SelectedItem IsNot Nothing, cb_Becado.SelectedItem.ToString(), "No")
            Dim asignatura = txt_Asignatura.Text.Replace("'", "''")
            'Dim iParcial = Decimal.Parse(txt_I_Parcial.Text)
            'Dim iiParcial = Decimal.Parse(txt_II_Parcial.Text)
            'Dim notFinal = Decimal.Parse(txt_Not_Final.Text)
            Dim anulada = If(chAnular.Checked, 1, 0)

            ' Construir SQL
            Dim SQL = "INSERT INTO NOTAS " &
                      "(ID_NOTA, NO_CARNET, APELLIDOS, NOMBRES, DOCENTE, BECADO_SN, ASIGNATURA, I_PARCIAL, II_PARCIAL, NOT_FINAL, ANULADA) " &
                      "VALUES (" &
                      $"{idNota}, {noCarnet}, '{apellidos}', '{nombres}', '{docente}', '{becadoSN}', '{asignatura}', " &
                      $"20, 23, 20, {anulada})"

            ' Ejecutar con tu módulo
            Variables.Consulta_Segura(SQL, Nothing)
            MessageBox.Show("Nota insertada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True

        Catch ex As Exception
            MessageBox.Show("Error al insertar la nota: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub TablaNotas()
        With ListView1.Columns
            .Clear()
            .Add("ID_NOTA", 80)
            .Add("NO_CARNET", 80)
            .Add("APELLIDOS", 120)
            .Add("NOMBRES", 120)
            .Add("DOCENTE", 150)
            .Add("BECADO_SN", 80)
            .Add("ASIGNATURA", 150)
            .Add("I_PARCIAL", 80)
            .Add("II_PARCIAL", 80)
            .Add("NOT_FINAL", 80)
            .Add("ANULADA", 80)
        End With
    End Sub

    Private Sub CargarDatos()
        Dim sql = "SELECT ID_NOTA, NO_CARNET, APELLIDOS, NOMBRES, DOCENTE, " &
                  "BECADO_SN, ASIGNATURA, I_PARCIAL, II_PARCIAL, NOT_FINAL, ANULADA " &
                  "FROM NOTAS"

        Dim dt As New DataTable()

        ' Usa la cadena de conexión del módulo Variables
        Using conn As New OdbcConnection(Variables.CAD_CONEXION),
              da As New OdbcDataAdapter(sql, conn)
            Try
                da.Fill(dt)
            Catch ex As OdbcException
                MessageBox.Show("Error al leer notas: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            Dim item = New ListViewItem(row("ID_NOTA").ToString())
            item.SubItems.Add(row("NO_CARNET").ToString())
            item.SubItems.Add(row("APELLIDOS").ToString())
            item.SubItems.Add(row("NOMBRES").ToString())
            item.SubItems.Add(row("DOCENTE").ToString())
            item.SubItems.Add(row("BECADO_SN").ToString())
            item.SubItems.Add(row("ASIGNATURA").ToString())
            item.SubItems.Add(row("I_PARCIAL").ToString())
            item.SubItems.Add(row("II_PARCIAL").ToString())
            item.SubItems.Add(row("NOT_FINAL").ToString())
            item.SubItems.Add(row("ANULADA").ToString())
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Insertar_Notas() Then CargarDatos()
    End Sub

End Class