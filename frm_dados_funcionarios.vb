Imports System.ComponentModel

Public Class frm_dados_funcionarios
    Sub sair()
        txt_cpf.Clear()
        txt_email.Clear()
        txt_login.Clear()
        txt_nome.Clear()
        txt_rsenha.Clear()
        txt_senha.Clear()
        txt_tel.Clear()
        img_dados_foto.Load(dir_foto_padrao)
        dtm_nascimento.Value = Now
        txt_cpf.Enabled = True
        frm_boss.carregar_dgv_funcionarios("")
        Me.Hide()
        frm_boss.Show()
    End Sub

    Private Sub frm_dados_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rs_funcionarios = db.Execute($"select * from tb_funcionarios where cpf='{cpf}'")
            If Not rs_funcionarios.EOF Then
                txt_cpf.Text = rs_funcionarios.Fields("cpf").Value
                txt_email.Text = rs_funcionarios.Fields("email").Value
                txt_login.Text = rs_funcionarios.Fields("login").Value
                txt_nome.Text = rs_funcionarios.Fields("nome").Value
                txt_tel.Text = rs_funcionarios.Fields("tel").Value
                dtm_nascimento.Value = rs_funcionarios.Fields("nascimento").Value
                txt_senha.Text = rs_funcionarios.Fields("senha").Value
                txt_rsenha.Text = rs_funcionarios.Fields("senha").Value
                img_dados_foto.Load(rs_funcionarios.Fields("foto").Value)
                txt_cpf.Enabled = False
                btn_excluir.Enabled = True
            Else
                btn_excluir.Enabled = False
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub frm_dados_funcionarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            sair()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            rs_funcionarios = db.Execute($"select * from tb_funcionarios where cpf='{txt_cpf.Text}'")
            Dim dir_img_atual As String = img_dados_foto.ImageLocation

            If txt_cpf.Text = "   .   .   -" Or
               txt_email.Text = "" Or
               txt_login.Text = "" Or
               txt_nome.Text = "" Or
               txt_senha.Text = "" Or
               txt_rsenha.Text = "" Or
               txt_tel.Text = "(  )     -" Or
               dir_img_atual = dir_foto_padrao Or
               dir_img_atual = "" Then
                MsgBox("Preencha todos os campos e selecione uma foto válida", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Campos de senha não conferem.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            Else
                If rs_funcionarios.EOF Then
                    rs_funcionarios = db.Execute($"select * from tb_funcionarios where login='{txt_login.Text}'")
                    rs_clientes = db.Execute($"select * from tb_clientes where login='{txt_login.Text}'")

                    If rs_funcionarios.EOF And rs_clientes.EOF Then
                        SQL = $"insert into tb_funcionarios values (
                        '{txt_cpf.Text}', 
                        '{txt_login.Text}', 
                        '{txt_nome.Text}', 
                        '{dtm_nascimento.Text}', 
                        '{txt_email.Text}', 
                        '{txt_tel.Text}', 
                        '{txt_senha.Text}', 
                        'ativo', 
                        '{dir_img_atual}'
                        )"
                        db.Execute(SQL)
                        MsgBox("Cadastro realizado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                        sair()
                    Else
                        MsgBox($"Login já está sendo utilizado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                    End If
                Else
                    Dim resp As MsgBoxResult = MsgBox($"Atualizar dados de {rs_funcionarios.Fields("nome").Value}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "update tb_funcionarios
                               set cpf='" & txt_cpf.Text & "', " &
                                       "login='" & txt_login.Text & "', " &
                                       "nome='" & txt_nome.Text & "', " &
                                       "nascimento='" & dtm_nascimento.Text & "', " &
                                       "email='" & txt_email.Text & "', " &
                                       "tel='" & txt_tel.Text & "', " &
                                       "senha='" & txt_senha.Text & "', " &
                                       "foto='" & dir_img_atual & "'
                               where cpf='" & txt_cpf.Text & "'"
                        db.Execute(SQL)
                        MsgBox("Dados Atualizados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                        sair()
                    End If
                End If
            End If

        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            rs_funcionarios = db.Execute($"select * from tb_funcionarios where cpf='{txt_cpf.Text}'")
            If Not rs_funcionarios.EOF Then
                Dim resp As MsgBoxResult = MsgBox($"Tem certeza que deseja apagar os dados de {rs_funcionarios.Fields("nome").Value} (CPF: {cpf})?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                If resp = MsgBoxResult.Yes Then
                    db.Execute($"delete from tb_funcionarios where cpf='{txt_cpf.Text}'")
                    MsgBox($"Dados de {rs_funcionarios.Fields("nome").Value} apagados.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO!")
                    sair()
                End If
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub img_dados_foto_Click(sender As Object, e As EventArgs) Handles img_dados_foto.Click
        Try
            ' Configura as propriedades da caixa de diálogo para que o usuário escolha uma foto
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = dir_fotos & "\users"
                .ShowDialog()
                ' Salva o diretório da foto selecionada
                dir_foto_selecionada = .FileName
                ' Carrega a foto selecionada
                If dir_foto_selecionada = "OpenFileDialog1" Then
                    img_dados_foto.Load(dir_foto_padrao)
                Else
                    img_dados_foto.Load(dir_foto_selecionada)
                End If
            End With
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao carregar foto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        Try
            If txt_senha.PasswordChar = "•" Then
                txt_senha.PasswordChar = ""
                txt_rsenha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
                txt_rsenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub
End Class