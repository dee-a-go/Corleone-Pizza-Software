<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_funcionario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_funcionario))
        Me.tab_usuarios = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_historico = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tab_produtos = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txt_preco = New System.Windows.Forms.MaskedTextBox()
        Me.chk_disponivel = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar = New System.Windows.Forms.ToolStripButton()
        Me.btn_excluir = New System.Windows.Forms.ToolStripButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.img_produtos = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_subcategoria = New System.Windows.Forms.ComboBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btn_filtros = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmb_filtros_subcategoria = New System.Windows.Forms.ComboBox()
        Me.cmb_filtros_categoria = New System.Windows.Forms.ComboBox()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_filtros_cpf = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_filtros_nome = New System.Windows.Forms.TextBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_usuarios.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.tab_produtos.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.img_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.btn_filtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_usuarios
        '
        Me.tab_usuarios.Controls.Add(Me.TabPage3)
        Me.tab_usuarios.Controls.Add(Me.TabPage4)
        Me.tab_usuarios.Controls.Add(Me.TabPage2)
        Me.tab_usuarios.Location = New System.Drawing.Point(12, 11)
        Me.tab_usuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_usuarios.Name = "tab_usuarios"
        Me.tab_usuarios.SelectedIndex = 0
        Me.tab_usuarios.Size = New System.Drawing.Size(692, 643)
        Me.tab_usuarios.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.dgv_historico)
        Me.TabPage3.Controls.Add(Me.dgv_pedidos)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(684, 614)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pedidos"
        '
        'dgv_historico
        '
        Me.dgv_historico.AllowUserToAddRows = False
        Me.dgv_historico.AllowUserToDeleteRows = False
        Me.dgv_historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_historico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_historico.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.Column13, Me.Column17, Me.Column11, Me.Column12})
        Me.dgv_historico.Location = New System.Drawing.Point(5, 330)
        Me.dgv_historico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_historico.Name = "dgv_historico"
        Me.dgv_historico.ReadOnly = True
        Me.dgv_historico.RowHeadersWidth = 62
        Me.dgv_historico.RowTemplate.Height = 28
        Me.dgv_historico.Size = New System.Drawing.Size(615, 247)
        Me.dgv_historico.TabIndex = 4
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 77
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Pedido"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'Column13
        '
        Me.Column13.HeaderText = "Preço"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 72
        '
        'Column17
        '
        Me.Column17.HeaderText = "Status"
        Me.Column17.MinimumWidth = 6
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 73
        '
        'Column11
        '
        Me.Column11.HeaderText = "Data"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 65
        '
        'Column12
        '
        Me.Column12.HeaderText = "Hora"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 66
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToAddRows = False
        Me.dgv_pedidos.AllowUserToDeleteRows = False
        Me.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column10, Me.DataGridViewTextBoxColumn6, Me.Column19, Me.Column8, Me.Column9, Me.Column16, Me.Column18, Me.Column14, Me.Column15})
        Me.dgv_pedidos.Location = New System.Drawing.Point(5, 48)
        Me.dgv_pedidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.ReadOnly = True
        Me.dgv_pedidos.RowHeadersWidth = 62
        Me.dgv_pedidos.RowTemplate.Height = 28
        Me.dgv_pedidos.Size = New System.Drawing.Size(615, 247)
        Me.dgv_pedidos.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(3, 306)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(157, 17)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Histórico de pedidos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(253, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Gerenciar pedidos em andamento"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.tab_produtos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(684, 614)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Gerenciar Cardápio"
        '
        'tab_produtos
        '
        Me.tab_produtos.Controls.Add(Me.TabPage5)
        Me.tab_produtos.Controls.Add(Me.TabPage6)
        Me.tab_produtos.Location = New System.Drawing.Point(17, 42)
        Me.tab_produtos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_produtos.Name = "tab_produtos"
        Me.tab_produtos.SelectedIndex = 0
        Me.tab_produtos.Size = New System.Drawing.Size(639, 537)
        Me.tab_produtos.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.txt_preco)
        Me.TabPage5.Controls.Add(Me.chk_disponivel)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.txt_descricao)
        Me.TabPage5.Controls.Add(Me.txt_produto)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.ToolStrip2)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.img_produtos)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.cmb_subcategoria)
        Me.TabPage5.Controls.Add(Me.cmb_categoria)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Size = New System.Drawing.Size(631, 508)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Adicionar Produto"
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(375, 250)
        Me.txt_preco.Mask = "99.99"
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(59, 22)
        Me.txt_preco.TabIndex = 16
        '
        'chk_disponivel
        '
        Me.chk_disponivel.AutoSize = True
        Me.chk_disponivel.Location = New System.Drawing.Point(42, 384)
        Me.chk_disponivel.Name = "chk_disponivel"
        Me.chk_disponivel.Size = New System.Drawing.Size(93, 20)
        Me.chk_disponivel.TabIndex = 15
        Me.chk_disponivel.Text = "Disponível"
        Me.chk_disponivel.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(345, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "R$"
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(41, 332)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(544, 22)
        Me.txt_descricao.TabIndex = 10
        '
        'txt_produto
        '
        Me.txt_produto.Location = New System.Drawing.Point(41, 250)
        Me.txt_produto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(281, 22)
        Me.txt_produto.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(345, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Preço:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar, Me.btn_excluir})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(625, 27)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_salvar
        '
        Me.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(29, 24)
        Me.btn_salvar.Text = "Salvar"
        '
        'btn_excluir
        '
        Me.btn_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(29, 24)
        Me.btn_excluir.Text = "Apagar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(39, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Descrição:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(461, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Imagem:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(39, 231)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Produto:"
        '
        'img_produtos
        '
        Me.img_produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_produtos.Image = CType(resources.GetObject("img_produtos.Image"), System.Drawing.Image)
        Me.img_produtos.InitialImage = Nothing
        Me.img_produtos.Location = New System.Drawing.Point(464, 179)
        Me.img_produtos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_produtos.Name = "img_produtos"
        Me.img_produtos.Size = New System.Drawing.Size(123, 118)
        Me.img_produtos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produtos.TabIndex = 5
        Me.img_produtos.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(200, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 16)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Sub-Categoria:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(39, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Categoria:"
        '
        'cmb_subcategoria
        '
        Me.cmb_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_subcategoria.FormattingEnabled = True
        Me.cmb_subcategoria.Location = New System.Drawing.Point(203, 172)
        Me.cmb_subcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_subcategoria.Name = "cmb_subcategoria"
        Me.cmb_subcategoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_subcategoria.TabIndex = 1
        '
        'cmb_categoria
        '
        Me.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(41, 172)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_categoria.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.btn_filtros)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Controls.Add(Me.cmb_filtros_subcategoria)
        Me.TabPage6.Controls.Add(Me.cmb_filtros_categoria)
        Me.TabPage6.Controls.Add(Me.dgv_produtos)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage6.Size = New System.Drawing.Size(631, 508)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Cardapio"
        '
        'btn_filtros
        '
        Me.btn_filtros.BackColor = System.Drawing.Color.Transparent
        Me.btn_filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtros.ErrorImage = Nothing
        Me.btn_filtros.Image = CType(resources.GetObject("btn_filtros.Image"), System.Drawing.Image)
        Me.btn_filtros.InitialImage = Nothing
        Me.btn_filtros.Location = New System.Drawing.Point(484, 13)
        Me.btn_filtros.Name = "btn_filtros"
        Me.btn_filtros.Size = New System.Drawing.Size(107, 33)
        Me.btn_filtros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_filtros.TabIndex = 42
        Me.btn_filtros.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(238, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 16)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Sub-Categoria:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(20, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Categoria:"
        '
        'cmb_filtros_subcategoria
        '
        Me.cmb_filtros_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtros_subcategoria.FormattingEnabled = True
        Me.cmb_filtros_subcategoria.Location = New System.Drawing.Point(341, 13)
        Me.cmb_filtros_subcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_filtros_subcategoria.Name = "cmb_filtros_subcategoria"
        Me.cmb_filtros_subcategoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_filtros_subcategoria.TabIndex = 5
        '
        'cmb_filtros_categoria
        '
        Me.cmb_filtros_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtros_categoria.FormattingEnabled = True
        Me.cmb_filtros_categoria.Location = New System.Drawing.Point(95, 13)
        Me.cmb_filtros_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_filtros_categoria.Name = "cmb_filtros_categoria"
        Me.cmb_filtros_categoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_filtros_categoria.TabIndex = 4
        '
        'dgv_produtos
        '
        Me.dgv_produtos.AllowUserToAddRows = False
        Me.dgv_produtos.AllowUserToDeleteRows = False
        Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewImageColumn2, Me.DataGridViewImageColumn3})
        Me.dgv_produtos.Location = New System.Drawing.Point(5, 58)
        Me.dgv_produtos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.ReadOnly = True
        Me.dgv_produtos.RowHeadersWidth = 62
        Me.dgv_produtos.RowTemplate.Height = 28
        Me.dgv_produtos.Size = New System.Drawing.Size(617, 446)
        Me.dgv_produtos.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Imagem"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 62
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Subcategoria"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 117
        '
        'Column7
        '
        Me.Column7.HeaderText = "Produto"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 83
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Disponibilidade"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 131
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Editar"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.MinimumWidth = 8
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 48
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Excluir"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.MinimumWidth = 8
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 52
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.dgv_clientes)
        Me.TabPage2.Controls.Add(Me.DataGridView5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(684, 614)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de Clientes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_filtros_cpf)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_filtros_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(75, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nome:"
        '
        'txt_filtros_cpf
        '
        Me.txt_filtros_cpf.Location = New System.Drawing.Point(417, 20)
        Me.txt_filtros_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_filtros_cpf.Name = "txt_filtros_cpf"
        Me.txt_filtros_cpf.Size = New System.Drawing.Size(89, 22)
        Me.txt_filtros_cpf.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(373, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "CPF:"
        '
        'txt_filtros_nome
        '
        Me.txt_filtros_nome.Location = New System.Drawing.Point(128, 18)
        Me.txt_filtros_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_filtros_nome.Name = "txt_filtros_nome"
        Me.txt_filtros_nome.Size = New System.Drawing.Size(89, 22)
        Me.txt_filtros_nome.TabIndex = 3
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column6, Me.Column2, Me.Column5, Me.Column4})
        Me.dgv_clientes.GridColor = System.Drawing.SystemColors.WindowFrame
        Me.dgv_clientes.Location = New System.Drawing.Point(19, 92)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 62
        Me.dgv_clientes.RowTemplate.Height = 28
        Me.dgv_clientes.Size = New System.Drawing.Size(632, 281)
        Me.dgv_clientes.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 73
        '
        'Column6
        '
        Me.Column6.HeaderText = "Foto"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 62
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 73
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ver"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 34
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.Size = New System.Drawing.Size(659, 566)
        Me.DataGridView5.TabIndex = 49
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Status"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.Width = 73
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 77
        '
        'Column19
        '
        Me.Column19.HeaderText = "CPF"
        Me.Column19.MinimumWidth = 6
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 62
        '
        'Column8
        '
        Me.Column8.HeaderText = "Endereço"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 95
        '
        'Column9
        '
        Me.Column9.HeaderText = "Pedido"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 80
        '
        'Column16
        '
        Me.Column16.HeaderText = "Preço"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 72
        '
        'Column18
        '
        Me.Column18.HeaderText = "Entrega"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 83
        '
        'Column14
        '
        Me.Column14.HeaderText = "Data"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 65
        '
        'Column15
        '
        Me.Column15.HeaderText = "Hora"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 66
        '
        'frm_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 674)
        Me.Controls.Add(Me.tab_usuarios)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_funcionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        Me.tab_usuarios.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.tab_produtos.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.img_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.btn_filtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_usuarios As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_filtros_cpf As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_filtros_nome As TextBox
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents tab_produtos As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btn_salvar As ToolStripButton
    Friend WithEvents btn_excluir As ToolStripButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents img_produtos As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmb_subcategoria As ComboBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents dgv_historico As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cmb_filtros_subcategoria As ComboBox
    Friend WithEvents cmb_filtros_categoria As ComboBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chk_disponivel As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents txt_preco As MaskedTextBox
    Friend WithEvents btn_filtros As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
End Class
