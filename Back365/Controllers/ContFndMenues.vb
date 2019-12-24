Imports Oracle.DataAccess.Client

Public Class ContFndMenues

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContFndMenues"

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

    Public Function getIdMenu() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_MENUES.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar(identificador As Integer, nombre As String, usr_cre As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_MENUES(IDENTIFICADOR, NOMBRE, USR_CRE, FEC_CRE)
                                            VALUES (:IDENTIFICADOR, :NOMBRE, :USR_CRE, SYSDATE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":NOMBRE", nombre)
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

End Class
