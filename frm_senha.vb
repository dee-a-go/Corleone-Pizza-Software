Imports System.ComponentModel

Public Class frm_senha
    Private Sub frm_senha_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btn_senha_Click(sender As Object, e As EventArgs) Handles btn_senha.Click
        Try
            Dim cpf As String = txt_cpf.Text
            Dim login As String = txt_login.Text
            Dim email As String = txt_email.Text

            If login = "" Or email = "" Or cpf = "   .   .   -" Then
                MsgBox("Você precisa informar seu CPF, login e email para recuperar a senha.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            Else
                rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}' and login='{login}' and email='{email}'")
                rs_funcionarios = db.Execute($"select * from tb_funcionarios where cpf='{cpf}' and login='{login}' and email='{email}'")
                If Not rs_clientes.EOF Then
                    MsgBox($"Olá, {rs_clientes.Fields("nome").Value}! Sua senha é: {rs_clientes.Fields("senha").Value}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    txt_cpf.Clear()
                    txt_login.Clear()
                    txt_email.Clear()
                    Me.Hide()
                ElseIf Not rs_funcionarios.EOF Then
                    MsgBox($"Olá, {rs_funcionarios.Fields("nome").Value}! Sua senha é: {rs_funcionarios.Fields("senha").Value}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    txt_cpf.Clear()
                    txt_login.Clear()
                    txt_email.Clear()
                    Me.Hide()
                Else
                    MsgBox("CPF, login ou email inválido(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao recuperar senha. Entre em contato com os desenvolvedores.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub btn_senha_MouseEnter(sender As Object, e As EventArgs) Handles btn_senha.MouseEnter
        btn_senha.Image = Image.FromFile(Application.StartupPath & "\fotos\botao escuro recuperar senha.png")
    End Sub

    Private Sub btn_senha_MouseLeave(sender As Object, e As EventArgs) Handles btn_senha.MouseLeave
        btn_senha.Image = Image.FromFile(Application.StartupPath & "\fotos\botao recuperar senha.png")
    End Sub
End Class