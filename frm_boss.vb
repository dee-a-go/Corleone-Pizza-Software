Imports System.Security.Cryptography

Public Class frm_boss
    Function carregar_dgv_clientes(query As String)
        If query = "" Then
            query = "select * from tb_clientes order by nome asc"
        End If

        Dim cont As Integer = 1
        rs_clientes = db.Execute(query)
        With dgv_clientes
            ' Limpa todas as linhas do dgv
            .Rows.Clear()
            'Enquanto existir registro no banco
            Do While Not rs_clientes.EOF
                ' Salva o caminho da imagem armazenado no banco de dados
                Dim imagePath As String = rs_clientes.Fields("foto").Value
                ' Abre a imagem
                Dim image As Image = Image.FromFile(imagePath)
                ' Escolhe o tamanho das medidas para redimensionar a imagem
                Dim newSize As Size = New Size(25, 25)
                ' Redimensiona a imagem
                Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)
                ' Renderiza a imagem
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
                End Using

                ' Adiciona novas linhas ao dgv_dados com os dados obtidos do banco
                .Rows.Add(cont, rs_clientes.Fields("nome").Value, resizedImage, rs_clientes.Fields("cpf").Value, rs_clientes.Fields("status").Value, Nothing)
                ' Incrementar contador
                cont += 1
                ' Move para a próxima linha do registro
                rs_clientes.MoveNext()
            Loop

        End With
    End Function

    Function carregar_dgv_funcionarios(query As String)
        If query = "" Then
            query = "select * from tb_funcionarios order by nome asc"
        End If

        Dim cont As Integer = 1
        rs_funcionarios = db.Execute(query)
        With dgv_funcionarios
            ' Limpa todas as linhas do dgv
            .Rows.Clear()
            'Enquanto existir registro no banco
            Do While Not rs_funcionarios.EOF

                ' Salva o caminho da imagem armazenado no banco de dados
                Dim imagePath As String = rs_funcionarios.Fields("foto").Value
                ' Abre a imagem
                Dim image As Image = Image.FromFile(imagePath)
                ' Escolhe o tamanho das medidas para redimensionar a imagem
                Dim newSize As Size = New Size(25, 25)
                ' Redimensiona a imagem
                Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)
                ' Renderiza a imagem
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
                End Using

                ' Adiciona novas linhas ao dgv_dados com os dados obtidos do banco
                .Rows.Add(cont, rs_funcionarios.Fields("nome").Value, resizedImage, rs_funcionarios.Fields("cpf").Value, rs_funcionarios.Fields("status").Value, Nothing, Nothing)
                ' Incrementar contador
                cont += 1
                ' Move para a próxima linha do registro
                rs_funcionarios.MoveNext()
            Loop
        End With
    End Function

    Private Sub frm_boss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rs_boss = db.Execute("select * from tb_boss")
            lbl_status.Text = $"Status: {rs_boss.Fields("funcionamento").Value}"
            carregar_dgv_clientes("")
            carregar_dgv_funcionarios("")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub frm_boss_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' tb painel de controle ---------------------------------------------------------------------------------------------------------
    Private Sub btn_senha_Click(sender As Object, e As EventArgs) Handles btn_senha.Click
        Try
            If txt_senha.Text = rs_boss.Fields("senha").Value Then
                If txt_novasenha.Text <> "" And txt_novasenha.Text = txt_rnovasenha.Text Then
                    Dim resp As MsgBoxResult = MsgBox("Tem certeza que deseja mudar a senha?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        db.Execute($"update tb_boss set senha='{txt_novasenha.Text}'")
                        txt_senha.Clear()
                        txt_novasenha.Clear()
                        txt_rnovasenha.Clear()
                        MsgBox("Nova senha salva.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO :)")
                        rs_boss = db.Execute("select * from tb_boss")
                    End If
                Else
                    MsgBox("Campos de nova senha divergentes.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "OPS :(")
                End If
            Else
                txt_senha.Clear()
                MsgBox("Senha incorreta.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "OPS :(")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro crítico ao mudar senha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub btn_senha_MouseEnter(sender As Object, e As EventArgs) Handles btn_senha.MouseEnter
        Try
            btn_senha.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar escuro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_senha_MouseLeave(sender As Object, e As EventArgs) Handles btn_senha.MouseLeave
        Try
            btn_senha.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub chk_senha_login_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha_login.CheckedChanged
        Try
            If txt_senha.PasswordChar = "•" And txt_novasenha.PasswordChar = "•" And txt_rnovasenha.PasswordChar = "•" Then
                txt_senha.PasswordChar = ""
                txt_novasenha.PasswordChar = ""
                txt_rnovasenha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
                txt_novasenha.PasswordChar = "•"
                txt_rnovasenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txt_login.Text = rs_boss.Fields("login").Value Then
                If txt_novologin.Text <> "" Then
                    Dim resp As MsgBoxResult = MsgBox("Tem certeza que deseja mudar o login?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        db.Execute($"update tb_boss set login='{txt_novologin.Text}'")
                        txt_login.Clear()
                        txt_novologin.Clear()
                        MsgBox("Novo login salvo.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO :)")
                        rs_boss = db.Execute("select * from tb_boss")
                    End If
                Else
                    MsgBox("Campo(s) de novo login não pode(m) estar vazio(s).", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "OPS :(")
                End If
            Else
                txt_login.Clear()
                MsgBox("Login incorreto.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "OPS :(")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro crítico ao mudar login.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub btn_login_MouseEnter(sender As Object, e As EventArgs) Handles btn_login.MouseEnter
        Try
            btn_login.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar escuro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_login_MouseLeave(sender As Object, e As EventArgs) Handles btn_login.MouseLeave
        Try
            btn_login.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_status_Click(sender As Object, e As EventArgs) Handles btn_status.Click
        Try
            If rb_aberto.Checked Then
                lbl_status.Text = "Status: ABERTO"
                db.Execute("update tb_boss set funcionamento='ABERTO'")
                rb_aberto.Checked = False
            ElseIf rb_fechado.Checked Then
                lbl_status.Text = "Status: FECHADO"
                db.Execute("update tb_boss set funcionamento='FECHADO'")
                rb_fechado.Checked = False
            Else
                MsgBox("Nenhum status selecionado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_status_MouseEnter(sender As Object, e As EventArgs) Handles btn_status.MouseEnter
        Try
            btn_status.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar escuro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_status_MouseLeave(sender As Object, e As EventArgs) Handles btn_status.MouseLeave
        Try
            btn_status.Image = Image.FromFile(Application.StartupPath & "\fotos\botao confirmar.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    ' tb clientes -------------------------------------------------------------------------------------------------------------------
    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        Try
            cpf = dgv_clientes.CurrentRow.Cells(3).Value
            rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")

            If dgv_clientes.CurrentRow.Cells(4).Selected Then
                If Not rs_clientes.EOF Then
                    If rs_clientes.Fields("status").Value = "ativo" Then
                        db.Execute($"update tb_clientes set status='inativo' where cpf='{cpf}'")
                    ElseIf rs_clientes.Fields("status").Value = "inativo" Then
                        db.Execute($"update tb_clientes set status='ativo' where cpf='{cpf}'")
                    End If
                Else
                    MsgBox($"Erro ao alterar status de {rs_clientes.Fields("nome").Value}.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            End If

            If dgv_clientes.CurrentRow.Cells(5).Selected Then
                Me.Hide()
                frm_dados_clientes.Show()
                txt_filtros_cpf.Clear()
                txt_filtros_nome.Clear()
            End If

            carregar_dgv_clientes("")
        Catch ex As Exception
            MsgBox("Erro ao carregar funcionalidades da lista de clientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub txt_filtros_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_filtros_nome.TextChanged
        Try
            txt_filtros_cpf.Text = ""
            SQL = $"select * from tb_clientes where nome like '{txt_filtros_nome.Text}%' order by nome asc"
            carregar_dgv_clientes(SQL)
        Catch ex As Exception
            ' erroooooooooooooooooooooooooooooooooooooooooooooooooooooo000000000000000000000000000000000000000000000000
        End Try
    End Sub

    Private Sub txt_filtros_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_filtros_cpf.TextChanged
        Try
            txt_filtros_nome.Text = ""
            SQL = $"select * from tb_clientes where cpf like '{txt_filtros_cpf.Text}%'"
            carregar_dgv_clientes(SQL)
        Catch ex As Exception
            ' erroooooooooooooooooooooooooooooooooooooooooooooooooooooo000000000000000000000000000000000000000000000000
        End Try
    End Sub

    Private Sub txt_filtros_nome_Click(sender As Object, e As EventArgs) Handles txt_filtros_nome.Click
        txt_filtros_cpf.Clear()
    End Sub

    Private Sub txt_filtros_cpf_Click(sender As Object, e As EventArgs) Handles txt_filtros_cpf.Click
        txt_filtros_nome.Clear()
    End Sub

    Private Sub txt_filtros_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_nome.DoubleClick
        txt_filtros_nome.Clear()
    End Sub

    Private Sub txt_filtros_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_cpf.DoubleClick
        txt_filtros_cpf.Clear()
    End Sub

    ' tb funcionarios ---------------------------------------------------------------------------------------------------------------
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            cpf = ""
            Me.Hide()
            frm_dados_funcionarios.Show()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_cadastrar_MouseEnter(sender As Object, e As EventArgs) Handles btn_cadastrar.MouseEnter
        Try
            btn_cadastrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao funcionario novo escuro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_cadastrar_MouseLeave(sender As Object, e As EventArgs) Handles btn_cadastrar.MouseLeave
        Try
            btn_cadastrar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao funcionario novo.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub dgv_funcionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellClick
        Try
            cpf = dgv_funcionarios.CurrentRow.Cells(3).Value
            rs_funcionarios = db.Execute($"select * from tb_funcionarios where cpf='{cpf}'")

            If dgv_funcionarios.CurrentRow.Cells(4).Selected Then
                If Not rs_funcionarios.EOF Then
                    If rs_funcionarios.Fields("status").Value = "ativo" Then
                        db.Execute($"update tb_funcionarios set status='inativo' where cpf='{cpf}'")
                    ElseIf rs_funcionarios.Fields("status").Value = "inativo" Then
                        db.Execute($"update tb_funcionarios set status='ativo' where cpf='{cpf}'")
                    End If
                Else
                    MsgBox($"Erro ao alterar status de {rs_funcionarios.Fields("nome").Value}.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            End If

            If dgv_funcionarios.CurrentRow.Cells(5).Selected Then
                Me.Hide()
                frm_dados_funcionarios.Show()
                txt_filtros_nome_func.Clear()
                txt_filtros_cpf_func.Clear()
            End If

            If dgv_funcionarios.CurrentRow.Cells(6).Selected Then
                Dim resp As MsgBoxResult = MsgBox($"Tem certeza que deseja apagar os dados de {rs_funcionarios.Fields("nome").Value} (CPF: {cpf})?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                If resp = MsgBoxResult.Yes Then
                    db.Execute($"delete from tb_funcionarios where cpf='{cpf}'")
                    MsgBox($"Dados de {rs_funcionarios.Fields("nome").Value} apagados.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO!")
                End If
            End If

            carregar_dgv_funcionarios("")
        Catch ex As Exception
            MsgBox("Erro ao carregar funcionalidades da lista de funcionarios.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub txt_filtros_nome_func_TextChanged(sender As Object, e As EventArgs) Handles txt_filtros_nome_func.TextChanged
        Try
            txt_filtros_cpf_func.Text = ""
            SQL = $"select * from tb_funcionarios where nome like '{txt_filtros_nome_func.Text}%'"
            carregar_dgv_funcionarios(SQL)
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub txt_filtros_cpf_func_TextChanged(sender As Object, e As EventArgs) Handles txt_filtros_cpf_func.TextChanged
        Try
            txt_filtros_nome_func.Text = ""
            SQL = $"select * from tb_funcionarios where cpf like '{txt_filtros_cpf_func.Text}%'"
            carregar_dgv_funcionarios(SQL)
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub txt_filtros_cpf_func_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_cpf_func.DoubleClick
        Try
            txt_filtros_cpf_func.Clear()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub txt_filtros_nome_func_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_nome_func.DoubleClick
        Try
            txt_filtros_nome_func.Clear()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub txt_filtros_cpf_func_Click(sender As Object, e As EventArgs) Handles txt_filtros_cpf_func.Click
        Try
            txt_filtros_nome_func.Clear()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub txt_filtros_nome_func_Click(sender As Object, e As EventArgs) Handles txt_filtros_nome_func.Click
        Try
            txt_filtros_cpf_func.Clear()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    ' tb relatorios -----------------------------------------------------------------------------------------------------------------

End Class