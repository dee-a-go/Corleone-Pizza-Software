<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_filtros_cpf = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_filtros_nome = New System.Windows.Forms.TextBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_usuarios = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_inicio = New System.Windows.Forms.PictureBox()
        Me.btn_cadastrar = New System.Windows.Forms.PictureBox()
        Me.chk_senha_login = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtm_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.img_dados_foto = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_usuarios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btn_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_dados_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.dgv_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(627, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de Clientes"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.IndianRed
        Me.Label17.Location = New System.Drawing.Point(3, 331)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(543, 38)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "ESSA ABA SERÁ DELETADA, MAS DEIXAR AQUI POR ENQUANTO PARA QUE EU POSSA COPIAR E A" &
    "DAPTAR O CÓDIGO DO BACKEND!!!!!!!!"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_filtros_cpf)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_filtros_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(323, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nome:"
        '
        'txt_filtros_cpf
        '
        Me.txt_filtros_cpf.Location = New System.Drawing.Point(216, 20)
        Me.txt_filtros_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_filtros_cpf.Name = "txt_filtros_cpf"
        Me.txt_filtros_cpf.Size = New System.Drawing.Size(89, 22)
        Me.txt_filtros_cpf.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(172, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "CPF:"
        '
        'txt_filtros_nome
        '
        Me.txt_filtros_nome.Location = New System.Drawing.Point(64, 20)
        Me.txt_filtros_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_filtros_nome.Name = "txt_filtros_nome"
        Me.txt_filtros_nome.Size = New System.Drawing.Size(89, 22)
        Me.txt_filtros_nome.TabIndex = 3
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados.Location = New System.Drawing.Point(5, 71)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(615, 247)
        Me.dgv_dados.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "Foto"
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
        'Column3
        '
        Me.Column3.HeaderText = "Nome"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 73
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editar"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 48
        '
        'Column5
        '
        Me.Column5.HeaderText = "Excluir"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 52
        '
        'tab_usuarios
        '
        Me.tab_usuarios.Controls.Add(Me.TabPage1)
        Me.tab_usuarios.Controls.Add(Me.TabPage2)
        Me.tab_usuarios.Location = New System.Drawing.Point(3, -25)
        Me.tab_usuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_usuarios.Name = "tab_usuarios"
        Me.tab_usuarios.SelectedIndex = 0
        Me.tab_usuarios.Size = New System.Drawing.Size(635, 442)
        Me.tab_usuarios.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.btn_inicio)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.chk_senha_login)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txt_login)
        Me.TabPage1.Controls.Add(Me.txt_rsenha)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txt_senha)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_numero)
        Me.TabPage1.Controls.Add(Me.txt_cidade)
        Me.TabPage1.Controls.Add(Me.txt_complemento)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_tel)
        Me.TabPage1.Controls.Add(Me.txt_bairro)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_endereco)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dtm_nascimento)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.img_dados_foto)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(627, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Pessoais"
        '
        'btn_inicio
        '
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio.Image = CType(resources.GetObject("btn_inicio.Image"), System.Drawing.Image)
        Me.btn_inicio.Location = New System.Drawing.Point(4, 4)
        Me.btn_inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(147, 27)
        Me.btn_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_inicio.TabIndex = 35
        Me.btn_inicio.TabStop = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.Location = New System.Drawing.Point(461, 332)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(132, 50)
        Me.btn_cadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cadastrar.TabIndex = 33
        Me.btn_cadastrar.TabStop = False
        '
        'chk_senha_login
        '
        Me.chk_senha_login.AutoSize = True
        Me.chk_senha_login.BackColor = System.Drawing.Color.Transparent
        Me.chk_senha_login.Location = New System.Drawing.Point(307, 352)
        Me.chk_senha_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_senha_login.Name = "chk_senha_login"
        Me.chk_senha_login.Size = New System.Drawing.Size(136, 21)
        Me.chk_senha_login.TabIndex = 15
        Me.chk_senha_login.Text = "Mostrar Senha"
        Me.chk_senha_login.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(145, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 17)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Login"
        '
        'txt_login
        '
        Me.txt_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_login.Location = New System.Drawing.Point(141, 73)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(96, 23)
        Me.txt_login.TabIndex = 1
        '
        'txt_rsenha
        '
        Me.txt_rsenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_rsenha.Location = New System.Drawing.Point(148, 350)
        Me.txt_rsenha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_rsenha.Size = New System.Drawing.Size(132, 23)
        Me.txt_rsenha.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(145, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Repita a senha"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(16, 350)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(111, 23)
        Me.txt_senha.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(13, 332)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Senha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(459, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Número (Logradouro)"
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_numero.ForeColor = System.Drawing.Color.Black
        Me.txt_numero.Location = New System.Drawing.Point(461, 182)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(136, 23)
        Me.txt_numero.TabIndex = 7
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cidade.Location = New System.Drawing.Point(16, 292)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(244, 23)
        Me.txt_cidade.TabIndex = 10
        '
        'txt_complemento
        '
        Me.txt_complemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_complemento.Location = New System.Drawing.Point(16, 236)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(415, 23)
        Me.txt_complemento.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(265, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "UF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(293, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Complemento ou Referência (Opcional)"
        '
        'txt_uf
        '
        Me.txt_uf.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_uf.Location = New System.Drawing.Point(268, 292)
        Me.txt_uf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(89, 23)
        Me.txt_uf.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(435, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Telefone"
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_tel.Location = New System.Drawing.Point(437, 292)
        Me.txt_tel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tel.Mask = "(99)99999-9999"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(111, 23)
        Me.txt_tel.TabIndex = 12
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_bairro.Location = New System.Drawing.Point(437, 236)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(123, 23)
        Me.txt_bairro.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(435, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Bairro"
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_endereco.Location = New System.Drawing.Point(127, 182)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(312, 23)
        Me.txt_endereco.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(124, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(253, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Data de Nascimento"
        '
        'dtm_nascimento
        '
        Me.dtm_nascimento.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtm_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_nascimento.Location = New System.Drawing.Point(256, 73)
        Me.dtm_nascimento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtm_nascimento.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtm_nascimento.Name = "dtm_nascimento"
        Me.dtm_nascimento.Size = New System.Drawing.Size(177, 23)
        Me.dtm_nascimento.TabIndex = 2
        Me.dtm_nascimento.Value = New Date(2024, 5, 7, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(16, 130)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(232, 23)
        Me.txt_nome.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CEP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(253, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(256, 130)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(222, 23)
        Me.txt_email.TabIndex = 4
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(16, 73)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(111, 23)
        Me.txt_cpf.TabIndex = 0
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cep.Location = New System.Drawing.Point(16, 182)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(73, 23)
        Me.txt_cep.TabIndex = 5
        '
        'img_dados_foto
        '
        Me.img_dados_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_dados_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_dados_foto.Image = CType(resources.GetObject("img_dados_foto.Image"), System.Drawing.Image)
        Me.img_dados_foto.InitialImage = Nothing
        Me.img_dados_foto.Location = New System.Drawing.Point(484, 38)
        Me.img_dados_foto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_dados_foto.Name = "img_dados_foto"
        Me.img_dados_foto.Size = New System.Drawing.Size(129, 118)
        Me.img_dados_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_dados_foto.TabIndex = 0
        Me.img_dados_foto.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(621, 25)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(637, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.tab_usuarios)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_usuarios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.btn_inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_dados_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_filtros_cpf As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_filtros_nome As TextBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents tab_usuarios As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chk_senha_login As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtm_nascimento As DateTimePicker
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents img_dados_foto As PictureBox
    Friend WithEvents btn_cadastrar As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_inicio As PictureBox
End Class
