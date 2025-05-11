Imports System.Data.Odbc

Module Variables
    'Declaración de Variables Globales
    Public Respuesta As Integer
    Public Si_Agrego As Boolean
    Public xCod As Integer
    Public I As Integer, Val_Band As Integer, Int_Informe As Integer
    Public LOGIN_USER As String, NOMBRE_USER As String, TIPO_USER As String
    Public TURNO_USER As String, IMAGEN_FOTO As String
    Public Const SISTEMA As String = "SISTEMA DE NOTAS"

    'Variables de Conexión y Manejo de Datos
    Public CONEXION As Odbc.OdbcConnection
    Public COMANDO As Odbc.OdbcCommand
    Public RS_CONSULTA As Odbc.OdbcDataReader
    Public CAD_CONEXION As String
    Public CONSULTA As String

    'Variables para ListView
    Public Columna As ColumnHeader
    Public Fila_View As ListViewItem

    'Función para ejecutar consultas seguras
    Public Function Consulta_Segura(ByVal SQL As String, ByVal RS As Odbc.OdbcDataReader) As Odbc.OdbcDataReader
        Dim Seleccionar As Integer

        'Cadena de Conexión
        CAD_CONEXION = "DSN=NOTAS;"
        CONEXION = New Odbc.OdbcConnection(CAD_CONEXION)
        'MsgBox(CAD_CONEXION)
        CONEXION.Open()

        'Ejecutar consulta
        COMANDO = New Odbc.OdbcCommand(SQL, CONEXION)
        Seleccionar = InStrRev(SQL, "SELECT", , CompareMethod.Text)

        If (Seleccionar > 0) Then
            RS = COMANDO.ExecuteReader()
            Consulta_Segura = RS
        Else
            COMANDO.ExecuteNonQuery()
            Call Cierra_Conexion()
            Consulta_Segura = Nothing
        End If
    End Function

    'Cierra la conexión
    Public Sub Cierra_Conexion()
        COMANDO = Nothing
        CONEXION.Close()
    End Sub

    'Función para obtener consecutivo de un campo
    Public Function Consecutivo(ByVal Tabla As String, ByVal Campo As String, ByVal RS As Odbc.OdbcDataReader) As Double
        Dim Dbl_Resultado As Double
        CONSULTA = "SELECT MAX(" & Campo & ") FROM " & Tabla
        RS = Variables.Consulta_Segura(CONSULTA, RS)

        If RS.HasRows Then
            RS.Read()
            If IsDBNull(RS.Item(0)) Then
                Dbl_Resultado = 1
            Else
                Dbl_Resultado = CDbl(RS.Item(0).ToString) + 1
            End If
        Else
            Dbl_Resultado = 1
        End If

        Call Variables.Cierra_Conexion()
        Consecutivo = Dbl_Resultado
    End Function
End Module
