Public Class frm_cliente

    Dim total As Decimal = 0.0

    Sub carregar_tab_dados()
        rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")
        txt_bairro.Text = rs_clientes.Fields("bairro").Value
        txt_cep.Text = rs_clientes.Fields("cep").Value
        txt_cidade.Text = rs_clientes.Fields("cidade").Value
        txt_complemento.Text = rs_clientes.Fields("complemento").Value
        txt_cpf.Text = rs_clientes.Fields("cpf").Value
        txt_email.Text = rs_clientes.Fields("email").Value
        txt_endereco.Text = rs_clientes.Fields("endereco").Value
        txt_login.Text = rs_clientes.Fields("login").Value
        dtm_nascimento.Text = rs_clientes.Fields("nascimento").Value
        txt_nome.Text = rs_clientes.Fields("nome").Value
        txt_numero.Text = rs_clientes.Fields("numero").Value
        txt_tel.Text = rs_clientes.Fields("tel").Value
        txt_uf.Text = rs_clientes.Fields("uf").Value
        img_cliente.Load(rs_clientes.Fields("foto").Value)
        txt_cpf.Enabled = False
    End Sub

    Sub limpar_cadastro()
        txt_bairro.Clear()
        txt_cep.Clear()
        txt_cidade.Clear()
        txt_complemento.Clear()
        txt_cpf.Clear()
        txt_email.Clear()
        txt_endereco.Clear()
        txt_login.Clear()
        txt_nome.Clear()
        txt_numero.Clear()
        txt_rsenha.Clear()
        txt_senha.Clear()
        txt_tel.Clear()
        txt_uf.Clear()
        img_cliente.Load(dir_foto_padrao)
    End Sub

    Function carregar_dgv_carrinho()
        Dim cont As Integer = 1
        rs_carrinho = db.Execute($"select * from tb_carrinho where cpf='{cpf}'")

        With dgv_carrinho.Rows()
            .Clear()
            Do While Not rs_carrinho.EOF
                Dim produto As String = rs_carrinho.Fields("produto").Value
                rs_produtos = db.Execute($"select * from tb_produtos where produto='{produto}'")

                Dim imagePath As String = rs_produtos.Fields("foto").Value
                Dim image As Image = Image.FromFile(imagePath)
                Dim newSize As Size = New Size(25, 25)
                Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
                End Using

                Dim preco As String = rs_carrinho.Fields("preco").Value
                Dim qtde As String = rs_carrinho.Fields("qtde").Value


                .Add(cont, resizedImage, rs_produtos.Fields("categoria").Value, rs_produtos.Fields("subcategoria").Value, rs_produtos.Fields("produto").Value, qtde, preco, Nothing, rs_produtos.Fields("descricao").Value)
                cont += 1

                rs_carrinho.MoveNext()
            Loop
        End With
    End Function

    Sub atualizar_total()
        total = 0.0
        rs_carrinho = db.Execute($"select * from tb_carrinho where cpf='{cpf}'")
        Do While Not rs_carrinho.EOF
            total = total + CDec(rs_carrinho.Fields("preco").Value)
            rs_carrinho.MoveNext()
        Loop
        lbl_total.Text = $"Preço Total: R$ {total}"
    End Sub
    Sub atualizar_pedido()
        rs_pedidos = db.Execute($"select * from tb_pedidos where cpf='{cpf}'")
        If Not rs_pedidos.EOF Then
            txt_pedido_data.Text = rs_pedidos.Fields("data").Value
            txt_pedido_hora.Text = rs_pedidos.Fields("hora").Value
            txt_pedido_entrega.Text = rs_pedidos.Fields("entrega").Value
            txt_pedido_pedido.Text = rs_pedidos.Fields("produtos").Value
            txt_pedido_preco.Text = rs_pedidos.Fields("preco").Value
            txt_pedido_status.Text = rs_pedidos.Fields("status").Value
        Else
            txt_pedido_data.Text = ""
            txt_pedido_hora.Text = ""
            txt_pedido_entrega.Text = ""
            txt_pedido_pedido.Text = ""
            txt_pedido_preco.Text = ""
            txt_pedido_status.Text = ""
        End If
    End Sub

    Function carregar_dgv_cardapio(query As String)
        If query = "" Then
            query = "select * from tb_produtos order by produto asc"
        End If

        Dim cont As Integer = 1
        rs_produtos = db.Execute(query)
        With dgv_cardapio.Rows()
            .Clear()
            Do While Not rs_produtos.EOF
                If rs_produtos.Fields("disponibilidade").Value = "disponivel" Then
                    Dim imagePath As String = rs_produtos.Fields("foto").Value
                    Dim image As Image = Image.FromFile(imagePath)
                    Dim newSize As Size = New Size(25, 25)
                    Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)
                    Using g As Graphics = Graphics.FromImage(resizedImage)
                        g.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
                    End Using

                    .Add(cont, resizedImage, rs_produtos.Fields("produto").Value, rs_produtos.Fields("descricao").Value, rs_produtos.Fields("preco").Value, Nothing)
                    cont += 1
                End If
                rs_produtos.MoveNext()
            Loop
        End With
    End Function

    Sub carregar_filtros_cardapio()
        Try
            With cmb_filtros_categoria.Items
                .Clear()
                .Add("Todas")
                .Add("Pizzas")
                .Add("Sobremesas")
                .Add("Bebidas")
            End With
            cmb_filtros_categoria.SelectedItem = "Sem Filtros"

            With cmb_filtros_subcategoria
                .Items.Clear()
                .Enabled = False
            End With
        Catch ex As Exception
            MsgBox("Deu ruim", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "OPS :(")
        End Try
    End Sub

    Sub carregar_dgv_historico()
        rs_historico = db.Execute($"select * from tb_historico where cpf='{cpf}'")

        Dim cont As Integer = 1
        With dgv_historico

            .Rows.Clear()

            Do While Not rs_historico.EOF

                .Rows.Add(cont, rs_historico.Fields("data").Value, rs_historico.Fields("hora").Value, rs_historico.Fields("preco").Value, rs_historico.Fields("produtos").Value, rs_historico.Fields("status").Value)
                cont += 1
                rs_historico.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_historico()
        lbl_hist_data.Text = ""
        lbl_hist_entrega.Text = ""
        lbl_hist_hora.Text = ""
        lbl_hist_pedido.Text = ""
        lbl_hist_total.Text = ""
        lbl_hist_status.Text = ""
    End Sub

    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            limpar_cadastro()
            carregar_tab_dados()
            carregar_dgv_cardapio("")
            carregar_filtros_cardapio()
            carregar_dgv_carrinho()
            atualizar_total()
            atualizar_pedido()
            carregar_dgv_historico()
            limpar_historico()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub frm_cliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    ' tab menu ----------------------------------------------------------------------------------------------------------------

    Private Sub dgv_cardapio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cardapio.CellClick
        'Try
        Dim produto As String = dgv_cardapio.CurrentRow.Cells(2).Value

        If dgv_cardapio.CurrentRow.Cells(5).Selected Then
            rs_carrinho = db.Execute($"select * from tb_carrinho where cpf='{cpf}' and produto='{produto}'")
            If rs_carrinho.EOF Then
                rs_produtos = db.Execute($"select * from tb_produtos where produto='{produto}'")
                SQL = $"insert into tb_carrinho values (
                          '{cpf}',
                          '{produto}',
                          '1',
                          {rs_produtos.Fields("preco").Value}
                          )"
                db.Execute(SQL)
            Else
                MsgBox("Produto já está no carrinho.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "OPS :(")
            End If
        End If

        carregar_dgv_carrinho()
            atualizar_total()
        'Catch ex As Exception
        'MsgBox("Erro ao adicionar produto no carrinho.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        'End Try
    End Sub

    Private Sub cmb_filtros_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtros_categoria.SelectedIndexChanged
        Try
            With cmb_filtros_categoria
                If .SelectedItem = "Pizzas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Todas")
                        .Items.Add("Salgadas")
                        .Items.Add("Doces")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Sobremesas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Todas")
                        .Items.Add("Bolos")
                        .Items.Add("Mousses")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Bebidas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Todas")
                        .Items.Add("Refrigerantes")
                        .Items.Add("Sucos Naturais")
                        .Items.Add("Sucos de Caixa")
                        .Items.Add("Alcoólicas")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                Else
                    cmb_filtros_subcategoria.Enabled = False
                End If
            End With
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_filtros_Click(sender As Object, e As EventArgs) Handles btn_filtros.Click
        Try
            If cmb_filtros_categoria.SelectedItem = "Todas" Then
                carregar_dgv_cardapio("")
            ElseIf cmb_filtros_categoria.SelectedItem = "Pizzas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Salgadas" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Doces" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_cardapio($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
                End If

            ElseIf cmb_filtros_categoria.SelectedItem = "Sobremesas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Bolos" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Mousses" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_cardapio($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
                End If

            ElseIf cmb_filtros_categoria.SelectedItem = "Bebidas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Refrigerantes" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Sucos Naturais" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Sucos de Caixa" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Alcoólicas" Then
                    carregar_dgv_cardapio($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_cardapio($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
                End If
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_filtros_MouseEnter(sender As Object, e As EventArgs) Handles btn_filtros.MouseEnter
        Try
            btn_filtros.Image = Image.FromFile(Application.StartupPath & "\fotos\botao aplicar filtro escuro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_filtros_MouseLeave(sender As Object, e As EventArgs) Handles btn_filtros.MouseLeave
        Try
            btn_filtros.Image = Image.FromFile(Application.StartupPath & "\fotos\botao aplicar filtro.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub dgv_carrinho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_carrinho.CellClick
        Try
            With dgv_carrinho.CurrentRow
                Dim produto As String = .Cells(4).Value
                rs_carrinho = db.Execute($"select * from tb_carrinho where produto='{produto}'")
                rs_produtos = db.Execute($"select * from tb_produtos where produto='{produto}'")

                If .Cells(5).Selected Then
                    If Not rs_carrinho.EOF Then
                        Dim qtde As String = rs_carrinho.Fields("qtde").Value
                        Dim nova_qtde As Integer = CInt(InputBox("Digite a quantidade desejada", "Quantidade", qtde))
                        Dim preco As Decimal = CDec(rs_produtos.Fields("preco").Value)
                        Dim novo_preco As Decimal = CDec(nova_qtde * preco)
                        Dim qtde_final As String = nova_qtde.ToString()
                        Dim preco_final As String = novo_preco.ToString("0.00")
                        db.Execute($"update tb_carrinho set qtde='{qtde_final}', preco='{preco_final}' where produto='{produto}' and cpf='{cpf}'")
                    Else
                        MsgBox("Produto não encontrado no banco de dados. Favor, entrar em contato com a pizzaria.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "OPS :(")
                    End If
                End If

                If .Cells(7).Selected Then
                    If Not rs_carrinho.EOF Then
                        db.Execute($"delete from tb_carrinho where produto='{produto}' and cpf='{cpf}'")
                    Else
                        MsgBox("Produto não encontrado no banco de dados. Favor, entrar em contato com a pizzaria.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "OPS :(")
                    End If
                End If

            End With

            atualizar_total()
            carregar_dgv_carrinho()
        Catch ex As Exception
            MsgBox("Erro crítico ao atualizar dados do carrinho.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub btn_pedido_Click(sender As Object, e As EventArgs) Handles btn_pedido.Click
        'Try
        rs_boss = db.Execute("select * from tb_boss")
        If rs_boss.Fields("funcionamento").Value = "ABERTO" Then
            rs_pedidos = db.Execute($"select * from tb_pedidos where cpf='{cpf}'")
            If rs_pedidos.EOF Then
                rs_carrinho = db.Execute($"select * from tb_carrinho where cpf='{cpf}'")
                If (rb_balcao.Checked Or rb_casa.Checked) And Not rs_carrinho.EOF Then
                    Dim nome As String = db.Execute($"select * from tb_clientes where cpf='{cpf}'").Fields("nome").Value
                    Dim produtos As String = $""
                    Do While Not rs_carrinho.EOF
                        produtos += $"{rs_carrinho.Fields("qtde").Value} x {rs_carrinho.Fields("produto").Value}, "
                        rs_carrinho.MoveNext()
                    Loop
                    produtos = produtos.Substring(0, produtos.LastIndexOf(", "))
                    Dim preco As String = total.ToString("0.00")
                    Dim entrega As String = ""
                    If rb_balcao.Checked Then
                        entrega = "Balcao"
                    ElseIf rb_casa.Checked Then
                        entrega = "Casa"
                    End If
                    Dim data As String = DateTime.Now.ToString("dd/MM/yyyy")
                    Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim status As String = "Aguardando confirmação"

                    SQL = $"insert into tb_pedidos values (
                        '{cpf}',
                        '{nome}',
                        '{produtos}',
                        '{preco}',
                        '{entrega}',
                        '{data}',
                        '{hora}',
                        '{status}'
                    )"
                    db.Execute(SQL)
                    rb_balcao.Checked = False
                    rb_casa.Checked = False
                    db.Execute($"delete from tb_carrinho where cpf='{cpf}'")
                    carregar_dgv_carrinho()
                    atualizar_total()
                    If rb_casa.Checked Then
                        MsgBox("Pedido feito!" & Environment.NewLine & "Pode se arrumar pra vir buscar aqui na Corleone :)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "SUCESSO :)")
                    Else
                        MsgBox("Pedido feito!" & Environment.NewLine & "Agora é só esperar chegar :)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "SUCESSO :)")
                    End If
                    TabControl1.SelectTab(2)
                    atualizar_pedido()

                Else
                    MsgBox("Você não tem ítens no carrinho ou não selecionou a forma de entrega.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            Else
                MsgBox("Você já tem um pedido em andamento. Confira na aba Acompanhar Pedido ou ligue para nós.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If
        Else
            MsgBox("A Pizzaria Corleone está fechada no momento :(" & Environment.NewLine & "Tente novamente mais tarde!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
        End If

        'Catch ex As Exception
        ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOoooooooooooooooooooooooooooooooooo
        'End Try
    End Sub

    Private Sub btn_pedido_MouseEnter(sender As Object, e As EventArgs) Handles btn_pedido.MouseEnter
        btn_pedido.Image = Image.FromFile(Application.StartupPath & "\fotos\botao fazer pedido escuro.png")
    End Sub

    Private Sub btn_pedido_MouseLeave(sender As Object, e As EventArgs) Handles btn_pedido.MouseLeave
        btn_pedido.Image = Image.FromFile($"{Application.StartupPath}\fotos\botao fazer pedido.png")
    End Sub



    ' tab dados ---------------------------------------------------------------------------------------------------------------

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            Dim dir_img_atual As String = img_cliente.ImageLocation
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
            dir_img_atual <> dir_foto_padrao And
            dir_img_atual <> "" Then
                If txt_senha.Text = "" And txt_rsenha.Text = "" Then
                    Dim resp As MsgBoxResult = MsgBox("Tem certeza que deseja salvar os dados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")
                        SQL = $"update tb_clientes
                            set login = '{txt_login.Text}',
                            nome = '{txt_nome.Text}',
                            email = '{txt_email.Text}',
                            nascimento = '{dtm_nascimento.Text}',
                            cep = '{txt_cep.Text}',
                            endereco = '{txt_endereco.Text}',
                            numero = '{txt_numero.Text}',
                            complemento = '{txt_complemento.Text}',
                            bairro = '{txt_bairro.Text}',
                            cidade = '{txt_cidade.Text}',
                            uf = '{txt_uf.Text}',
                            tel = '{txt_tel.Text}',
                            foto = '{dir_img_atual}'
                            where cpf = '{cpf}'"
            db.Execute(SQL)
                        MsgBox("Dados Gravados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                    End If
                ElseIf txt_senha.Text = txt_rsenha.Text Then
                    Dim resp As MsgBoxResult = MsgBox("Tem certeza que deseja salvar os dados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")
                        SQL = $"update tb_clientes
                            set login = '{txt_login.Text}',
                            nome = '{txt_nome.Text}',
                            email = '{txt_email.Text}',
                            nascimento = '{dtm_nascimento.Text}',
                            cep = '{txt_cep.Text}',
                            endereco = '{txt_endereco.Text}',
                            numero = '{txt_numero.Text}',
                            complemento = '{txt_complemento.Text}',
                            bairro = '{txt_bairro.Text}',
                            cidade = '{txt_cidade.Text}',
                            uf = '{txt_uf.Text}',
                            tel = '{txt_tel.Text}',
                            senha = '{txt_senha.Text}',
                            foto = '{dir_img_atual}'
                            WHERE cpf = '{cpf}'"
                        db.Execute(SQL)
                        MsgBox("Dados Gravados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                    End If
                Else
                    MsgBox("Campos de senha não conferem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            Else
                MsgBox("Por favor, preencha todos os campos e selecione uma foto.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_salvar_MouseEnter(sender As Object, e As EventArgs) Handles btn_salvar.MouseEnter
        btn_salvar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao salvar alteracoes escuro.png")
    End Sub

    Private Sub btn_salvar_MouseLeave(sender As Object, e As EventArgs) Handles btn_salvar.MouseLeave
        btn_salvar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao salvar alteracoes.png")
    End Sub

    Private Sub img_cliente_Click(sender As Object, e As EventArgs) Handles img_cliente.Click
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
                    img_cliente.Load(dir_foto_padrao)
                Else
                    img_cliente.Load(dir_foto_selecionada)
                End If
            End With
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao carregar foto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
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


    ' tab pedido --------------------------------------------------------------------------------------------------------------
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        rs_pedidos = db.Execute($"select * from tb_pedidos where cpf='{cpf}'")
        If Not rs_pedidos.EOF Then
            Dim resp As MsgBoxResult = MsgBox("Tem certeza que deseja cancelar seu pedido?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO!")
            If resp = MsgBoxResult.Yes Then
                db.Execute($"insert into tb_historico values ('{rs_pedidos.Fields("cpf").Value}', '{rs_pedidos.Fields("produtos").Value}', '{rs_pedidos.Fields("preco").Value}', '{rs_pedidos.Fields("entrega").Value}', 'Cancelado', '{rs_pedidos.Fields("data").Value}', '{rs_pedidos.Fields("hora").Value}')")
                db.Execute($"delete from tb_pedidos where cpf='{cpf}'")
                atualizar_pedido()
                carregar_dgv_historico()
            End If
        End If
    End Sub



    ' tab historico -----------------------------------------------------------------------------------------------------------
    Private Sub dgv_historico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historico.CellClick
        Try
            limpar_historico()
            With dgv_historico.CurrentRow
                Dim produtos As String = .Cells(4).Value
                Dim data As String = .Cells(1).Value
                Dim hora As String = .Cells(2).Value
                rs_historico = db.Execute($"select * from tb_historico where cpf='{cpf}' and data='{data}' and hora='{hora}'")
                lbl_hist_data.Text = rs_historico.Fields("data").Value
                lbl_hist_entrega.Text = rs_historico.Fields("entrega").Value
                lbl_hist_hora.Text = rs_historico.Fields("hora").Value
                lbl_hist_pedido.Text = rs_historico.Fields("produtos").Value
                lbl_hist_total.Text = rs_historico.Fields("preco").Value
                lbl_hist_status.Text = rs_historico.Fields("status").Value
            End With
        Catch ex As Exception
            MsgBox("Erro crítico ao atualizar dados do histórico de pedidos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

End Class