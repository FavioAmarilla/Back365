Imports Oracle.DataAccess.Client

Public Class ContFndUsuarios

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContFndUsuarios"

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            cmd = New OracleCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ControlMensajes.mensaje("Error al realizar consulta: " + ex.Message, titulo, "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function getIdUsuario() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_FND_USUARIOS.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function
        
    Public Function insertarUsuario(nombreCompleto As String, idPerfil As Integer, nombre As String, claveAcceso As String, activo As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_USUARIOS(IDENTIFICADOR, NOMBRE_COMPLETO, ID_PERFIL, NOMBRE, CLAVE_ACCESO, ACTIVO, USR_CRE,FEC_CRE)
                                                VALUES(:IDENTIFICADOR, :NOMBRE_COMPLETO, :ID_PERFIL, :NOMBRE, :CLAVE_ACCESO, :ACTIVO, :USR_CRE, SYSDATE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", getIdUsuario())
            comand.Parameters.Add(":NOMBRE_COMPLETO", nombreCompleto)
            comand.Parameters.Add(":ID_PERFIL", idPerfil)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":CLAVE_ACCESO", claveAcceso)
            comand.Parameters.Add(":ACTIVO", activo)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizarUsuario(identificador As Integer, nombreCompleto As String, idPerfil As Integer, nombre As String, claveAcceso As String, activo As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE FND_USUARIOS SET NOMBRE_COMPLETO=:NOMBRE_COMPLETO, ID_PERFIL=:ID_PERFIL, NOMBRE=:NOMBRE, 
                                                CLAVE_ACCESO=:CLAVE_ACCESO, ACTIVO=:ACTIVO, USR_MOD=:USR_MOD, FEC_MOD=SYSDATE
                                                WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":NOMBRE_COMPLETO", nombreCompleto)
            comand.Parameters.Add(":ID_PERFIL", idPerfil)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":CLAVE_ACCESO", claveAcceso)
            comand.Parameters.Add(":ACTIVO", activo)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertarMenues(usuario As String, idMenu As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_MENUES_USR(USUARIO, ID_MENU, FECHA_DESDE, USR_CRE,FEC_CRE)
                                                VALUES(:USUARIO, :ID_MENU, SYSDATE, :USR_CRE, SYSDATE)", cnn)

            comand.Parameters.Add(":USUARIO", usuario)
            comand.Parameters.Add(":ID_MENU", idMenu)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminarMenu(usuario As String, idMenu As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("DELETE FROM FND_MENUES_USR WHERE USUARIO=:USUARIO AND ID_MENU=:ID_MENU", cnn)

            comand.Parameters.Add(":USUARIO", usuario)
            comand.Parameters.Add(":ID_MENU", idMenu)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function



End Class
