<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dados_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dados_funcionarios))
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chk_senha = New System.Windows.Forms.CheckBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar = New System.Windows.Forms.ToolStripButton()
        Me.btn_excluir = New System.Windows.Forms.ToolStripButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtm_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.img_dados_foto = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_dados_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(33, 199)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(128, 22)
        Me.txt_login.TabIndex = 51
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(29, 180)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 16)
        Me.Label33.TabIndex = 52
        Me.Label33.Text = "Login"
        '
        'chk_senha
        '
        Me.chk_senha.AutoSize = True
        Me.chk_senha.Location = New System.Drawing.Point(27, 288)
        Me.chk_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_senha.Name = "chk_senha"
        Me.chk_senha.Size = New System.Drawing.Size(116, 20)
        Me.chk_senha.TabIndex = 50
        Me.chk_senha.Text = "Mostrar Senha"
        Me.chk_senha.UseVisualStyleBackColor = True
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Location = New System.Drawing.Point(283, 261)
        Me.txt_rsenha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_rsenha.Size = New System.Drawing.Size(244, 22)
        Me.txt_rsenha.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(280, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 16)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Repita a senha"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(31, 261)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(244, 22)
        Me.txt_senha.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Senha"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar, Me.btn_excluir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 45
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar
        '
        Me.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(29, 24)
        Me.btn_salvar.Text = "ToolStripButton1"
        Me.btn_salvar.ToolTipText = "Salvar Dados"
        '
        'btn_excluir
        '
        Me.btn_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(29, 24)
        Me.btn_excluir.Text = "ToolStripButton1"
        Me.btn_excluir.ToolTipText = "Excluir Dados"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Telefone"
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(271, 199)
        Me.txt_tel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tel.Mask = "(99)99999-9999"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(111, 22)
        Me.txt_tel.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Data de Nascimento"
        '
        'dtm_nascimento
        '
        Me.dtm_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_nascimento.Location = New System.Drawing.Point(271, 82)
        Me.dtm_nascimento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtm_nascimento.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtm_nascimento.Name = "dtm_nascimento"
        Me.dtm_nascimento.Size = New System.Drawing.Size(177, 22)
        Me.dtm_nascimento.TabIndex = 36
        Me.dtm_nascimento.Value = New Date(2024, 5, 7, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(31, 139)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(232, 22)
        Me.txt_nome.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nome"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(271, 137)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(231, 22)
        Me.txt_email.TabIndex = 38
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(31, 82)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(111, 22)
        Me.txt_cpf.TabIndex = 35
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'img_dados_foto
        '
        Me.img_dados_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_dados_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_dados_foto.Image = CType(resources.GetObject("img_dados_foto.Image"), System.Drawing.Image)
        Me.img_dados_foto.InitialImage = Nothing
        Me.img_dados_foto.Location = New System.Drawing.Point(512, 119)
        Me.img_dados_foto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_dados_foto.Name = "img_dados_foto"
        Me.img_dados_foto.Size = New System.Drawing.Size(129, 118)
        Me.img_dados_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_dados_foto.TabIndex = 34
        Me.img_dados_foto.TabStop = False
        '
        'frm_dados_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.chk_senha)
        Me.Controls.Add(Me.txt_rsenha)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtm_nascimento)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.img_dados_foto)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_dados_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_dados_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_salvar As ToolStripButton
    Friend WithEvents btn_excluir As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtm_nascimento As DateTimePicker
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents img_dados_foto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
