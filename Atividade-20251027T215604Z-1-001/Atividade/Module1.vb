Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dir_banco = Application.StartupPath & "\Banco\cadastro.mdb"
    Public usuario, senha, sql, tipo, status, aux_usuario, resp As String
    Public cont As Integer


    Sub conecta_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_dados()
        With cadastro.dgv_usuarios
            sql = "select *from tb_usuario order by usuario asc"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub limpar_cadastro()
        Try
            With cadastro
                .txt_usuario.Clear()
                .txt_senha.Clear()
                .txt_repita.Clear()
                .txt_usuario.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try



    End Sub
End Module
