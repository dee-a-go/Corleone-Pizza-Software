Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class frm_cadastro
    Sub limpar_cadastro()
        Try
            ' Limpa todos os campos do cadastro
            txt_cpf.Clear()
            txt_login.Clear()
            dtm_nascimento.Value = Now
            img_dados_foto.Load(dir_foto_padrao)
            txt_nome.Clear()
            txt_email.Clear()
            txt_cep.Clear()
            txt_endereco.Clear()
            txt_numero.Clear()
            txt_complemento.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            txt_tel.Clear()
            txt_senha.Clear()
            txt_rsenha.Clear()
            txt_cpf.Focus()
        Catch ex As Exception
            MsgBox("Erro ao limpar cadastro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Limpa o formulário de cadastro
        limpar_cadastro()
        txt_cpf.Focus() ' Essa bosta funciona?
    End Sub

    Private Sub frm_login_atividade_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
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

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Obter e salvar caminho da foto de perfil setada na picturebox
            Dim dir_img_atual As String = img_dados_foto.ImageLocation
            ' Se todos os campos estiverem preenchidos e a foto for diferente da foto padrão
            If txt_cpf.Text <> "   .   .   -" And
            txt_login.Text <> "" And
            dtm_nascimento.Text <> "" And
            txt_nome.Text <> "" And
            txt_email.Text <> "" And
            txt_cep.Text <> "     -" And
            txt_endereco.Text <> "" And
            txt_numero.Text <> "" And
            txt_bairro.Text <> "" And
            txt_cidade.Text <> "" And
            txt_uf.Text <> "" And
            txt_tel.Text <> "(  )     -" And
            txt_senha.Text <> "" And
            txt_rsenha.Text <> "" And
            dir_img_atual <> dir_foto_padrao And
            dir_img_atual <> "" Then
                ' Se os campos de senha forem iguais
                If txt_senha.Text = txt_rsenha.Text Then
                    ' Verificar se o CPF já está cadastrado
                    rs_clientes = db.Execute($"select * from tb_clientes where cpf='{txt_cpf.Text}'")
                    If rs_clientes.EOF Then
                        ' Se não existir o cpf na tabela tb_clientes, verifica se o login também não existe na tb clientes e na tb funcionarios
                        rs_clientes = db.Execute($"select * from tb_clientes where login='{txt_login.Text}'")
                        rs_funcionarios = db.Execute($"select * from tb_funcionarios where login='{txt_login.Text}'")
                        If rs_clientes.EOF And rs_funcionarios.EOF Then
                            ' Query para escrever valores no banco de dados
                            SQL = "insert into tb_clientes values ('" & txt_cpf.Text & "', '" &
                                                                txt_login.Text & "', '" &
                                                                txt_nome.Text & "', '" &
                                                                txt_email.Text & "', '" &
                                                                dtm_nascimento.Text & "', '" &
                                                                txt_cep.Text & "', '" &
                                                                txt_endereco.Text & "', '" &
                                                                txt_numero.Text & "', '" &
                                                                txt_complemento.Text & "', '" &
                                                                txt_bairro.Text & "', '" &
                                                                txt_cidade.Text & "', '" &
                                                                txt_uf.Text & "', '" &
                                                                txt_tel.Text & "', '" &
                                                                txt_senha.Text & "', '" &
                                                                "ativo', '" &
                                                                dir_foto_selecionada & "')"
                            db.Execute(SQL)
                            MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                            ' Limpar campos de cadastro
                            limpar_cadastro()
                            ' ir pro frm_login
                            Me.Hide()
                            frm_login.Show()
                        Else
                            MsgBox("Login já existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                        End If
                    Else
                        MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                    End If
                Else
                    MsgBox("Campos de senha não conferem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            Else
                MsgBox("Por favor, preencha todos os campos e selecione uma foto.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao gravar dados.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS : (")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            SQL = $"select * from tb_cep where cep='{txt_cep.Text}'"
            rs_clientes = db.Execute(SQL)
            If Not rs_clientes.EOF Then
                txt_endereco.Text = rs_clientes.Fields("endereco").Value
                txt_cidade.Text = rs_clientes.Fields("cidade").Value
                txt_bairro.Text = rs_clientes.Fields("bairro").Value
                txt_uf.Text = rs_clientes.Fields("uf").Value
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao tentar obter endereço a partir do CEP.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub chk_senha_login_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha_login.CheckedChanged
        Try
            If txt_senha.PasswordChar = "•" And txt_rsenha.PasswordChar = "•" Then
                txt_senha.PasswordChar = ""
                txt_rsenha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
                txt_rsenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro ao setar PasswordChar. Entre em contato com os devs.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS : (")
        End Try
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_cadastrar_MouseEnter(sender As Object, e As EventArgs) Handles btn_cadastrar.MouseEnter
        btn_cadastrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao cadastrar escuro.png")
    End Sub

    Private Sub btn_cadastrar_MouseLeave(sender As Object, e As EventArgs) Handles btn_cadastrar.MouseLeave
        btn_cadastrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao.png")
    End Sub
End Class