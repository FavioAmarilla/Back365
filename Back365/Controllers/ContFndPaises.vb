
Imports Oracle.DataAccess.Client

Public Class ContFndPaises

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "FndPaises"

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

    Public Function getIdentificador() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_FND_PAISES.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar(identificador As Integer, nombre As String, abreviatura As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_PAISES(IDENTIFICADOR, NOMBRE, ABREVIATURA, FEC_CRE, USR_CRE)
                                            VALUES (:IDENTIFICADOR, :DESCRIPCION, :ABREVIATURA, SYSDATE, :USR_CRE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":ABREVIATURA", abreviatura)
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

    Public Function actualizar(identificador As Integer, nombre As String, abreviatura As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE FND_PAISES SET NOMBRE=:NOMBRE, ABREVIATURA=:ABREVIATURA, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":ABREVIATURA", abreviatura)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
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
End Class
