Imports Oracle.DataAccess.Client

Public Class ContFndSitios

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContFndSitios"

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
            ControlMensajes.mensaje("Error al realizar consulta: " & ex.Message, titulo, "ERR")
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

    Public Function insertar(identificador As Integer, descripcion As String, id_empresa As Integer, id_unidad As Integer, direccion As String, codigo_ctrl_comp As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_SITIOS(IDENTIFICADOR, DESCRIPCION, ID_EMPRESA, ID_UNIDAD, USR_CRE, FEC_CRE, DIRECCION, CODIGO_CTRL_COMP)
                                            VALUES(:IDENTIFICADOR, :DESCRIPCION, :ID_EMPRESA, :ID_UNIDAD, :USR_CRE, SYSDATE, :DIRECCION, :CODIGO_CTRL_COMP)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":DESCRIPCION", descripcion)
            comand.Parameters.Add(":ID_EMPRESA", id_empresa)
            comand.Parameters.Add(":ID_UNIDAD", id_unidad)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":DIRECCION", direccion)
            comand.Parameters.Add(":CODIGO_CTRL_COMP", codigo_ctrl_comp)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al insertar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(descripcion As String, id_empresa As Integer, id_unidad As Integer, direccion As Integer, codigo_ctrl_comp As String, identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE FND_SITIOS SET DESCRIPCION=:DESCRIPCION, ID_EMPRESA=:ID_EMPRESA, ID_UNIDAD=:ID_UNIDAD, USR_MOD=:USR_MOD, FEC_MOD=SYSDATE, DIRECCION=:DIRECCION, CODIGO_CTRL_COMP=:CODIGO_CTRL_COMP
                                            WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":DESCRIPCION", descripcion)
            comand.Parameters.Add(":ID_EMPRESA", id_empresa)
            comand.Parameters.Add(":ID_UNIDAD", id_unidad)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":DIRECCION", direccion)
            comand.Parameters.Add(":CODIGO_CTRL_COMP", codigo_ctrl_comp)
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
