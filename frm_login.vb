Public Class frm_login
    Private Sub frm_login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub link_cadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_cadastro.LinkClicked
        Try
            Me.Hide()
            frm_cadastro.Show()
        Catch ex As Exception
            MsgBox("Erro ao iniciar janela de cadastro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub link_senha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_senha.LinkClicked
        Try
            frm_senha.Show()
        Catch ex As Exception
            MsgBox("Erro ao iniciar janela de recuperação de senha.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub chk_senha_login_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha_login.CheckedChanged
        Try
            If txt_senha.PasswordChar = "•" Then
                txt_senha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro ao setar PasswordChar. Entre em contato com os devs.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS : (")
        End Try
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            Dim login As String = txt_login.Text
            Dim senha As String = txt_senha.Text
            rs_clientes = db.Execute($"select * from tb_clientes where senha='{senha}' and (login='{login}' or email='{login}')")
            rs_funcionarios = db.Execute($"select * from tb_funcionarios where senha='{senha}' and (login='{login}' or email='{login}')")
            rs_boss = db.Execute($"select * from tb_boss where login='{login}' and senha='{senha}'")

            If login = "" Or senha = "" Then
                MsgBox("Por favor, preencha os campos de login e senha.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            ElseIf Not rs_boss.EOF Then
                Me.Hide()
                frm_boss.Show()
            ElseIf Not rs_clientes.EOF Then
                If rs_clientes.Fields("status").Value = "ativo" Then
                    cpf = rs_clientes.Fields("cpf").Value
                    Me.Hide()
                    frm_cliente.Show()
                Else
                    MsgBox("Cliente bloqueado. Por favor, entre em contato com a administração.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            ElseIf Not rs_funcionarios.EOF Then
                If rs_funcionarios.Fields("status").Value = "ativo" Then
                    cpf = rs_funcionarios.Fields("cpf").Value
                    Me.Hide()
                    frm_funcionario.Show()
                Else
                    MsgBox("Funcionário bloqueado. Por favor, entre em contato com a administração.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            Else
                MsgBox("Usuário e/ou senha inválido(s).", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro crítico ao logar. Entre em contato com os desenvolvedores.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub link_cardapio_Click(sender As Object, e As EventArgs) Handles link_cardapio.Click
        Try
            Me.Hide()
            frm_cardapio.Show()
        Catch ex As Exception
            MsgBox("Erro ao iniciar janela de cardapio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub link_cardapio_MouseEnter(sender As Object, e As EventArgs) Handles link_cardapio.MouseEnter
        link_cardapio.Image = Image.FromFile(Application.StartupPath & "\fotos\texto e linha escura.png")
    End Sub

    Private Sub link_cardapio_MouseLeave(sender As Object, e As EventArgs) Handles link_cardapio.MouseLeave
        link_cardapio.Image = Image.FromFile(Application.StartupPath & "\fotos\texto e linha 2.png")
    End Sub

    Private Sub btn_entrar_MouseEnter(sender As Object, e As EventArgs) Handles btn_entrar.MouseEnter
        btn_entrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao 2 escuro.png")
    End Sub

    Private Sub btn_entrar_MouseLeave(sender As Object, e As EventArgs) Handles btn_entrar.MouseLeave
        btn_entrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao 2.png")
    End Sub

End Class