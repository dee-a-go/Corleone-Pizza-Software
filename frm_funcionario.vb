Public Class frm_funcionario
    Function carregar_dgv_clientes(query As String)
        Try
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
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Function

    Function carregar_dgv_produtos(query As String)
        Try
            If query = "" Then
                query = "select * from tb_produtos order by produto asc"
            End If

            Dim cont As Integer = 1
            rs_produtos = db.Execute(query)
            With dgv_produtos
                ' Limpa todas as linhas do dgv
                .Rows.Clear()
                'Enquanto existir registro no banco
                Do While Not rs_produtos.EOF
                    ' Salva o caminho da imagem armazenado no banco de dados
                    Dim imagePath As String = rs_produtos.Fields("foto").Value
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
                    .Rows.Add(cont, resizedImage, rs_produtos.Fields("categoria").Value, rs_produtos.Fields("subcategoria").Value, rs_produtos.Fields("produto").Value, rs_produtos.Fields("disponibilidade").Value, Nothing, Nothing)
                    ' Incrementar contador
                    cont += 1
                    ' Move para a próxima linha do registro
                    rs_produtos.MoveNext()
                Loop
            End With
        Catch ex As Exception
            ' erroooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        End Try
    End Function

    Sub carregar_menu_produtos()
        Try
            txt_produto.Clear()
            txt_preco.Clear()
            txt_descricao.Clear()
            img_produtos.Load(dir_foto_produto_padrao)
            chk_disponivel.Checked = False

            With cmb_categoria.Items
                .Clear()
                .Add("Pizzas")
                .Add("Sobremesas")
                .Add("Bebidas")
            End With

            With cmb_subcategoria
                .Items.Clear()
                .Enabled = False
            End With
        Catch ex As Exception
            MsgBox("Deu ruim", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "OPS :(")
        End Try
    End Sub

    Sub carregar_filtros_cardapio()
        Try
            With cmb_filtros_categoria.Items
                .Clear()
                .Add("Sem Filtros")
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

    Sub carregar_dgv_pedidos()
        rs_pedidos = db.Execute($"select * from tb_pedidos")

        Dim cont As Integer = 1
        With dgv_pedidos
            .Rows.Clear()

            Do While Not rs_pedidos.EOF
                rs_clientes = db.Execute($"select * from tb_clientes where cpf='{rs_pedidos.Fields("cpf").Value}'")

                .Rows.Add(cont, rs_pedidos.Fields("status").Value, rs_clientes.Fields("nome").Value, rs_clientes.Fields("cpf").Value, rs_clientes.Fields("endereco").Value, rs_pedidos.Fields("produtos").Value, rs_pedidos.Fields("preco").Value, rs_pedidos.Fields("entrega").Value, rs_pedidos.Fields("data").Value, rs_pedidos.Fields("hora").Value)
                cont += 1
                rs_pedidos.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_dgv_historico()
        rs_historico = db.Execute($"select * from tb_historico")

        Dim cont As Integer = 1
        With dgv_historico

            .Rows.Clear()

            Do While Not rs_historico.EOF
                rs_clientes = db.Execute($"select * from tb_clientes where cpf='{rs_historico.Fields("cpf").Value}'")

                .Rows.Add(cont, rs_clientes.Fields("nome").Value, rs_historico.Fields("produtos").Value, rs_historico.Fields("preco").Value, rs_historico.Fields("status").Value, rs_historico.Fields("data").Value, rs_historico.Fields("hora").Value)
                cont += 1
                rs_historico.MoveNext()
            Loop
        End With
    End Sub

    Private Sub frm_funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_menu_produtos()
        carregar_filtros_cardapio()
        carregar_dgv_clientes("")
        carregar_dgv_produtos("")
        carregar_dgv_pedidos()
        carregar_dgv_historico()
    End Sub

    ' tab pedidos -------------------------------------------------------------------------------------------------------------------
    Private Sub dgv_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellClick
        cpf = dgv_pedidos.CurrentRow.Cells(3).Value
        rs_pedidos = db.Execute($"select * from tb_pedidos where cpf='{cpf}'")

        With dgv_pedidos.CurrentRow

            If .Cells(1).Selected Then
                Dim status As String = rs_pedidos.Fields("status").Value
                If status = "Aguardando confirmação" Then
                    db.Execute($"update tb_pedidos set status='Em preparação' where cpf='{rs_pedidos.Fields("cpf").Value}'")
                ElseIf status = "Em preparação" Then
                    db.Execute($"update tb_pedidos set status='Saiu pra entrega' where cpf='{rs_pedidos.Fields("cpf").Value}'")
                ElseIf status = "Saiu pra entrega" Then
                    db.Execute($"insert into tb_historico values ('{rs_pedidos.Fields("cpf").Value}', '{rs_pedidos.Fields("produtos").Value}', '{rs_pedidos.Fields("preco").Value}', '{rs_pedidos.Fields("entrega").Value}', 'Concluido', '{rs_pedidos.Fields("data").Value}', '{rs_pedidos.Fields("hora").Value}')")
                    db.Execute($"delete from tb_pedidos where cpf='{rs_pedidos.Fields("cpf").Value}'")
                    MsgBox("Pedido concluído!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                End If
            End If

            If .Cells(3).Selected Or .Cells(2).Selected Then
                Me.Hide()
                frm_dados_clientes2.Show()
            End If

        End With


        carregar_dgv_pedidos()
        carregar_dgv_historico()

    End Sub

    ' tab cardapio ------------------------------------------------------------------------------------------------------------------

    Private Sub cmb_categoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_categoria.SelectedValueChanged
        Try
            With cmb_categoria
                If .SelectedItem = "Pizzas" Then
                    With cmb_subcategoria
                        .Items.Clear()
                        .Items.Add("Salgadas")
                        .Items.Add("Doces")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Sobremesas" Then
                    With cmb_subcategoria
                        .Items.Clear()
                        .Items.Add("Bolos")
                        .Items.Add("Mousses")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Bebidas" Then
                    With cmb_subcategoria
                        .Items.Clear()
                        .Items.Add("Refrigerantes")
                        .Items.Add("Sucos Naturais")
                        .Items.Add("Sucos de Caixa")
                        .Items.Add("Alcoólicas")
                        .Enabled = True
                        .SelectedItem = 0
                    End With

                Else
                    cmb_subcategoria.Enabled = False
                End If
            End With
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            Dim dir_img_atual As String = img_produtos.ImageLocation

            If txt_produto.Text <> "" And
            txt_preco.Text <> "  .  " And
            txt_descricao.Text <> "" And
            cmb_categoria.SelectedItem <> "" And
            cmb_subcategoria.SelectedItem <> "" And
            dir_img_atual <> dir_foto_produto_padrao And
            dir_img_atual <> "" Then
                Dim id As Integer = GerarID()
                Dim disponibilidade As String = ""
                If chk_disponivel.Checked Then
                    disponibilidade = "disponivel"
                ElseIf Not chk_disponivel.Checked Then
                    disponibilidade = "indisponivel"
                End If
                rs_produtos = db.Execute($"select * from tb_produtos where produto='{txt_produto.Text}'")
                If rs_produtos.EOF Then
                    SQL = $"insert into tb_produtos values ('{id}',
                                                            '{cmb_categoria.SelectedItem}',
                                                            '{cmb_subcategoria.SelectedItem}',
                                                            '{txt_produto.Text}',
                                                            '{txt_descricao.Text}',
                                                            '{txt_preco.Text}',
                                                            '{disponibilidade}',
                                                            '{dir_foto_selecionada}'
                                                            )"
                    db.Execute(SQL)
                    MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                    carregar_menu_produtos()
                    carregar_dgv_produtos("")
                Else
                    Dim resp As MsgBoxResult = MsgBox($"Atualizar dados do produto {rs_produtos.Fields("produto").Value}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "update tb_produtos set
                                       id='" & id & "', " &
                                       "categoria='" & cmb_categoria.SelectedItem & "', " &
                                       "subcategoria='" & cmb_subcategoria.SelectedItem & "', " &
                                       "produto='" & txt_produto.Text & "', " &
                                       "descricao='" & txt_descricao.Text & "', " &
                                       "preco='" & txt_preco.Text & "', " &
                                       "disponibilidade='" & disponibilidade & "', " &
                                       "foto='" & dir_img_atual & "'
                               where produto='" & txt_produto.Text & "'"
                        db.Execute(SQL)
                        MsgBox("Dados Atualizados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO :)")
                        carregar_menu_produtos()
                        carregar_dgv_produtos("")
                    End If
                End If
            Else
                MsgBox("Preencha todos os campos e selecione uma foto!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "OPS :(")
            End If

            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao gravar dados.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS : (")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            rs_produtos = db.Execute($"select * from tb_produtos where produto='{txt_produto.Text}'")
            If Not rs_produtos.EOF Then
                Dim resp As MsgBoxResult = MsgBox($"Tem certeza que deseja apagar o produto {rs_produtos.Fields("produto").Value}?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                If resp = MsgBoxResult.Yes Then
                    db.Execute($"delete from tb_produtos where produto='{txt_produto.Text}'")
                    MsgBox($"Produto apagado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO!")
                End If
                carregar_dgv_produtos("")
            End If
        Catch ex As Exception
            ' EERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub img_produtos_Click(sender As Object, e As EventArgs) Handles img_produtos.Click
        Try
            ' Configura as propriedades da caixa de diálogo para que o usuário escolha uma foto
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = dir_fotos & "\products"
                .ShowDialog()
                ' Salva o diretório da foto selecionada
                dir_foto_selecionada = .FileName
                ' Carrega a foto selecionada
                If dir_foto_selecionada = "OpenFileDialog1" Then
                    img_produtos.Load(dir_foto_produto_padrao)
                Else
                    img_produtos.Load(dir_foto_selecionada)
                End If
            End With
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro ao carregar foto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    Private Sub cmb_filtros_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtros_categoria.SelectedIndexChanged
        Try
            With cmb_filtros_categoria
                If .SelectedItem = "Pizzas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Sem Filtros")
                        .Items.Add("Salgadas")
                        .Items.Add("Doces")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Sobremesas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Sem Filtros")
                        .Items.Add("Bolos")
                        .Items.Add("Mousses")
                        .Enabled = True
                        .SelectedItem = 0
                    End With
                ElseIf .SelectedItem = "Bebidas" Then
                    With cmb_filtros_subcategoria
                        .Items.Clear()
                        .Items.Add("Sem Filtros")
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
            If cmb_filtros_categoria.SelectedItem = "Sem Filtros" Then
                carregar_dgv_produtos("")
            ElseIf cmb_filtros_categoria.SelectedItem = "Pizzas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Salgadas" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Doces" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_produtos($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
                End If

            ElseIf cmb_filtros_categoria.SelectedItem = "Sobremesas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Bolos" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Mousses" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_produtos($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
                End If

            ElseIf cmb_filtros_categoria.SelectedItem = "Bebidas" Then
                If cmb_filtros_subcategoria.SelectedItem = "Refrigerantes" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Sucos Naturais" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Sucos de Caixa" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                ElseIf cmb_filtros_subcategoria.SelectedItem = "Alcoólicas" Then
                    carregar_dgv_produtos($"select * from tb_produtos where subcategoria='{cmb_filtros_subcategoria.SelectedItem}'")
                Else
                    carregar_dgv_produtos($"select * from tb_produtos where categoria='{cmb_filtros_categoria.SelectedItem}'")
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

    Private Sub dgv_produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellClick
        Try
            Dim produto As String = dgv_produtos.CurrentRow.Cells(4).Value
            rs_produtos = db.Execute($"select * from tb_produtos where produto='{produto}'")

            If dgv_produtos.CurrentRow.Cells(5).Selected Then
                If Not rs_produtos.EOF Then
                    If rs_produtos.Fields("disponibilidade").Value = "disponivel" Then
                        db.Execute($"update tb_produtos set disponibilidade='indisponivel' where produto='{produto}'")
                    ElseIf rs_produtos.Fields("disponibilidade").Value = "indisponivel" Then
                        db.Execute($"update tb_produtos set disponibilidade='disponivel' where produto='{produto}'")
                    End If
                Else
                    MsgBox($"Erro ao alterar disponibilidade de {rs_produtos.Fields("produto").Value}.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
                End If
            End If

            If dgv_produtos.CurrentRow.Cells(6).Selected Then
                tab_produtos.SelectTab(0)
                txt_produto.Text = rs_produtos.Fields("produto").Value
                txt_preco.Text = rs_produtos.Fields("preco").Value
                txt_descricao.Text = rs_produtos.Fields("descricao").Value
                img_produtos.Load(rs_produtos.Fields("foto").Value)
                cmb_categoria.SelectedItem = rs_produtos.Fields("categoria").Value
                cmb_subcategoria.SelectedItem = rs_produtos.Fields("subcategoria").Value
                Dim disponibilidade As String = rs_produtos.Fields("disponibilidade").Value
                If disponibilidade = "disponivel" Then
                    chk_disponivel.Checked = True
                ElseIf disponibilidade = "indisponivel" Then
                    chk_disponivel.Checked = False
                End If
            End If

            If dgv_produtos.CurrentRow.Cells(7).Selected Then
                Dim resp As MsgBoxResult = MsgBox($"Tem certeza que deseja apagar o produto {rs_produtos.Fields("produto").Value}?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO!")
                If resp = MsgBoxResult.Yes Then
                    db.Execute($"delete from tb_produtos where produto='{produto}'")
                    MsgBox($"Produto apagado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SUCESSO!")
                End If
            End If

            carregar_dgv_produtos("")
        Catch ex As Exception
            MsgBox("Erro ao carregar funcionalidades do cardapio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "OPS :(")
        End Try
    End Sub

    ' tab clientes ------------------------------------------------------------------------------------------------------------------

    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        Try
            cpf = dgv_clientes.CurrentRow.Cells(3).Value
            rs_clientes = db.Execute($"select * from tb_clientes where cpf='{cpf}'")

            If dgv_clientes.CurrentRow.Cells(5).Selected Then
                Me.Hide()
                frm_dados_clientes2.Show()
                txt_filtros_nome.Clear()
                txt_filtros_cpf.Clear()
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

    Private Sub txt_filtros_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_nome.DoubleClick
        txt_filtros_nome.Clear()
    End Sub

    Private Sub txt_filtros_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_filtros_cpf.DoubleClick
        txt_filtros_cpf.Clear()
    End Sub

    Private Sub txt_filtros_nome_Click(sender As Object, e As EventArgs) Handles txt_filtros_nome.Click
        txt_filtros_cpf.Clear()
    End Sub

    Private Sub txt_filtros_cpf_Click(sender As Object, e As EventArgs) Handles txt_filtros_cpf.Click
        txt_filtros_nome.Clear()
    End Sub

    Private Sub frm_funcionario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class