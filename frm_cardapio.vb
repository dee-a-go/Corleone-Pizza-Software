Imports System.ComponentModel

Public Class frm_cardapio
    Function carregar_dgv_produtos(query As String)
        If query = "" Then
            query = "select * from tb_produtos order by produto asc"
        End If

        Dim cont As Integer = 1
        rs_produtos = db.Execute(query)
        With dgv_produtos.Rows()
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

                    .Add(cont, resizedImage, rs_produtos.Fields("categoria").Value, rs_produtos.Fields("subcategoria").Value, rs_produtos.Fields("produto").Value, rs_produtos.Fields("descricao").Value)
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

    Private Sub frm_cardapio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dgv_produtos("")
        carregar_filtros_cardapio()
    End Sub
    Private Sub frm_cardapio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
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

    Private Sub btn_logar_MouseEnter(sender As Object, e As EventArgs) Handles btn_logar.MouseEnter
        Try
            btn_logar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao escuro faca login.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub
    Private Sub btn_logar_MouseLeave(sender As Object, e As EventArgs) Handles btn_logar.MouseLeave
        Try
            btn_logar.Image = Image.FromFile(Application.StartupPath & "\fotos\botao faca login.png")
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub

    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        Try
            Me.Hide()
            frm_login.Show()
        Catch ex As Exception
            ' ERROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        End Try
    End Sub
End Class