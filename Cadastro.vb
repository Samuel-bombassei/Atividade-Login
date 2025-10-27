Public Class cadastro
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        Try
            With dgv_usuarios
                If .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(6).Selected Then
                    aux_usuario = .CurrentRow.Cells(0).Value.ToString()

                    sql = $"SELECT * FROM tb_usuario WHERE usuario = '{aux_usuario}'"
                    rs  = db.Execute(sql)

                    If rs.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir o usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"DELETE FROM tb_usuario WHERE usuario = '{aux_usuario}'"
                            db.Execute(sql)
                        End If
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(5).Selected Then
                    'Bloquear ou Ativar usuarios
                    aux_usuario = .CurrentRow.Cells(0).Value.ToString()
                    sql = $"SELECT * FROM tb_usuario WHERE usuario = '{aux_usuario}'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        sql = $"UPDATE tb_usuario SET status = 'ativo' WHERE usuario = '{aux_usuario}'"
                        db.Execute(sql)
                        MsgBox("Usuário desbloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(4).Selected Then

                    aux_usuario = .CurrentRow.Cells(0).Value.ToString()
                    sql = $"SELECT * FROM tb_usuario WHERE usuario = '{aux_usuario}'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        sql = $"UPDATE tb_usuario SET status = 'bloqueado' WHERE usuario = '{aux_usuario}'"
                        db.Execute(sql)
                        MsgBox("Usuário bloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    Exit Sub
                End If
            End With

            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Verificação de campos vazios antes de tudo
            If txt_usuario.Text = "" Or txt_senha.Text = "" Or txt_repita.Text = "" Then
                MsgBox("Preencha todos os campos antes de cadastrar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            ' Verifica se as senhas coincidem
            If txt_senha.Text <> txt_repita.Text Then
                MsgBox("As senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            ' Verifica se o usuário já existe
            sql = $"SELECT * FROM tb_usuario WHERE usuario = '{txt_usuario.Text}'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                ' Insere novo usuário
                sql = $"INSERT INTO tb_usuario (usuario, senha, status, tipo) VALUES ('{txt_usuario.Text}', '{txt_senha.Text}', 'ativo', 'usuario')"
                db.Execute(sql)
                MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Else
                MsgBox("Usuário já cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

            limpar_cadastro()
        Catch ex As Exception
            MsgBox("Não foi possível cadastrar o usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
