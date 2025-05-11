DOCUMENTACION PARA CONECTARME EN OBDC MI BASE DE DATOS A MI PROYECTO:

1- Primero hay que ir al panel de control
2- ir a sistema y seguridad -> herramientas de windows
3- elegir origenes de datos obdc( ahi escoger dependiendo del proyecto si es de 32 bits o de 64 bits, eso se ve en las propiedades del proyecto en visual studio, ir a propiedades y elegir compilar) 
4- Ir a DSN DEL SISTEMA y darle a agregar
5- Buscar el controlador de sql server(se puede encontrar como   ODBC DRIVER 17 for sql server, si no esta escoger sql server)
6- llenar los datos  como el nombre y el servidor, poner localhost o el servidor de sqlserver
7- darle a siguiente y autenticacion con window, de ahi darle a siguiente hasta probar la conexion

En sql al crear la base de datos hay que almacenarla en C:

CREATE DATABASE NOTAS
ON PRIMARY (
    NAME = NOTAS_Data,
    FILENAME = 'C:\BASES DE DATOS\SISTEMA NOTAS\BD\NOTAS.mdf',
    SIZE = 10MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)
LOG ON (
    NAME = NOTAS_Log,
    FILENAME = 'C:\BASES DE DATOS\SISTEMA NOTAS\BD\NOTAS_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB
);
GO

query de conexion en el proyecto:
Si usas autenticación de Windows: CAD_CONEXION = "DSN=BD_NOTAS;"
Si usas autenticación sql server: CAD_CONEXION = "DSN=BD_NOTAS;UID=tu_usuario;PWD=tu_contraseña;"
