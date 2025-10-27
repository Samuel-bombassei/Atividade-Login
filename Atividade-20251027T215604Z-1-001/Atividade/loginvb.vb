Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports ADODB

Public Class login
    Private Sub login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_senha.PasswordChar = "•"
        txt_usuario.Clear()
        txt_senha.Clear()
        conecta_banco_access()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            usuario = txt_usuario.Text
            senha = txt_senha.Text

            ' Verifica campos vazios
            If usuario = "" Or senha = "" Then
                MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Garante que o banco esteja aberto
            If db.State = 0 Then
                db.Open()
            End If

            sql = $"SELECT * FROM tb_usuario WHERE usuario = '{usuario}' AND senha = '{senha}'"
            rs = New ADODB.Recordset
            rs.Open(sql, db, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                tipo = rs.Fields("tipo").Value.ToString
                status = rs.Fields("status").Value.ToString

                ' Verifica se o usuário está ativo
                If status.ToLower() = "bloqueado" Then
                    MsgBox("Seu acesso está bloqueado. Contate o administrador.", MsgBoxStyle.Critical, "Acesso negado")
                    rs.Close()
                    Exit Sub
                End If

                ' Login permitido
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information, "Bem-vindo")

                ' Exibe o menu principal conforme o tipo de usuário
                menu_principal.Show()

                If tipo.ToLower() = "usuario" Then
                    menu_principal.tsm_cadastro.Visible = False
                ElseIf tipo.ToLower() = "admin" Then
                    menu_principal.tsm_cadastro.Visible = True
                End If

                Me.Hide()
            Else
                MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Exclamation, "Erro de login")
            End If

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login:" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub cb_mostra_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_mostra_senha.CheckedChanged
        If cb_mostra_senha.Checked Then
            ' Mostrar senha
            txt_senha.PasswordChar = ""
        Else
            ' Esconder senha
            txt_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

