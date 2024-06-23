Imports System.ComponentModel

Public Class frm_dados_clientes
    Private Sub frm_dados_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")
            lbl_bairro.Text = rs_clientes.Fields("bairro").Value
            lbl_cep.Text = rs_clientes.Fields("cep").Value
            lbl_cidade.Text = rs_clientes.Fields("cidade").Value
            lbl_complemento.Text = rs_clientes.Fields("complemento").Value
            lbl_cpf.Text = rs_clientes.Fields("cpf").Value
            lbl_email.Text = rs_clientes.Fields("email").Value
            lbl_endereco.Text = rs_clientes.Fields("endereco").Value
            lbl_nascimento.Text = rs_clientes.Fields("nascimento").Value
            lbl_nome.Text = rs_clientes.Fields("nome").Value
            lbl_numero.Text = rs_clientes.Fields("numero").Value
            lbl_status.Text = rs_clientes.Fields("status").Value
            lbl_telefone.Text = rs_clientes.Fields("tel").Value
            lbl_uf.Text = rs_clientes.Fields("uf").Value
            img_cliente.Image = Image.FromFile(rs_clientes.Fields("foto").Value)
        Catch ex As Exception
            MsgBox("Erro ao carregar dados de cliente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub frm_dados_clientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            cpf = ""
            Me.Hide()
            frm_boss.Show()
        Catch ex As Exception
            MsgBox("Erro ao retornar à janela de gerenciamento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub
End Class