<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.link_senha = New System.Windows.Forms.LinkLabel()
        Me.link_cadastro = New System.Windows.Forms.LinkLabel()
        Me.link_cardapio = New System.Windows.Forms.PictureBox()
        Me.AlphaBlendTextBox7 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox5 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox4 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox3 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox2 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox1 = New ZBobb.AlphaBlendTextBox()
        Me.btn_entrar = New System.Windows.Forms.PictureBox()
        Me.chk_senha_login = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.link_cardapio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(11, 108)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(232, 22)
        Me.txt_login.TabIndex = 11
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(12, 178)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(233, 22)
        Me.txt_senha.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.prj_adsva2_24_1S.My.Resources.Resources.fundo_pizzaria_1_0_mais_borrado
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.link_senha)
        Me.GroupBox1.Controls.Add(Me.link_cadastro)
        Me.GroupBox1.Controls.Add(Me.link_cardapio)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox7)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox5)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox4)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox3)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox2)
        Me.GroupBox1.Controls.Add(Me.AlphaBlendTextBox1)
        Me.GroupBox1.Controls.Add(Me.btn_entrar)
        Me.GroupBox1.Controls.Add(Me.chk_senha_login)
        Me.GroupBox1.Controls.Add(Me.txt_senha)
        Me.GroupBox1.Controls.Add(Me.txt_login)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(547, 281)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'link_senha
        '
        Me.link_senha.AutoSize = True
        Me.link_senha.BackColor = System.Drawing.Color.Transparent
        Me.link_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.link_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.link_senha.LinkColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.link_senha.Location = New System.Drawing.Point(112, 155)
        Me.link_senha.Name = "link_senha"
        Me.link_senha.Size = New System.Drawing.Size(134, 17)
        Me.link_senha.TabIndex = 38
        Me.link_senha.TabStop = True
        Me.link_senha.Text = "Esqueceu a senha?"
        '
        'link_cadastro
        '
        Me.link_cadastro.AutoSize = True
        Me.link_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.link_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.link_cadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.link_cadastro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.link_cadastro.Location = New System.Drawing.Point(157, 54)
        Me.link_cadastro.Name = "link_cadastro"
        Me.link_cadastro.Size = New System.Drawing.Size(88, 17)
        Me.link_cadastro.TabIndex = 37
        Me.link_cadastro.TabStop = True
        Me.link_cadastro.Text = "Cadastre-se!"
        '
        'link_cardapio
        '
        Me.link_cardapio.BackColor = System.Drawing.Color.Transparent
        Me.link_cardapio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_cardapio.Image = CType(resources.GetObject("link_cardapio.Image"), System.Drawing.Image)
        Me.link_cardapio.Location = New System.Drawing.Point(323, 171)
        Me.link_cardapio.Margin = New System.Windows.Forms.Padding(4)
        Me.link_cardapio.Name = "link_cardapio"
        Me.link_cardapio.Size = New System.Drawing.Size(185, 103)
        Me.link_cardapio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.link_cardapio.TabIndex = 36
        Me.link_cardapio.TabStop = False
        '
        'AlphaBlendTextBox7
        '
        Me.AlphaBlendTextBox7.BackAlpha = 10
        Me.AlphaBlendTextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox7.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaBlendTextBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AlphaBlendTextBox7.Location = New System.Drawing.Point(287, 34)
        Me.AlphaBlendTextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox7.Multiline = True
        Me.AlphaBlendTextBox7.Name = "AlphaBlendTextBox7"
        Me.AlphaBlendTextBox7.ReadOnly = True
        Me.AlphaBlendTextBox7.Size = New System.Drawing.Size(260, 129)
        Me.AlphaBlendTextBox7.TabIndex = 33
        Me.AlphaBlendTextBox7.Text = "Bem-vindo à Pizzaria Corleone, onde cada mordida é uma experência de felicidade."
        '
        'AlphaBlendTextBox5
        '
        Me.AlphaBlendTextBox5.BackAlpha = 10
        Me.AlphaBlendTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox5.Location = New System.Drawing.Point(39, 208)
        Me.AlphaBlendTextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox5.Multiline = True
        Me.AlphaBlendTextBox5.Name = "AlphaBlendTextBox5"
        Me.AlphaBlendTextBox5.ReadOnly = True
        Me.AlphaBlendTextBox5.Size = New System.Drawing.Size(133, 25)
        Me.AlphaBlendTextBox5.TabIndex = 31
        Me.AlphaBlendTextBox5.Text = "Mostrar Senha"
        '
        'AlphaBlendTextBox4
        '
        Me.AlphaBlendTextBox4.BackAlpha = 10
        Me.AlphaBlendTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox4.Location = New System.Drawing.Point(12, 54)
        Me.AlphaBlendTextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox4.Multiline = True
        Me.AlphaBlendTextBox4.Name = "AlphaBlendTextBox4"
        Me.AlphaBlendTextBox4.ReadOnly = True
        Me.AlphaBlendTextBox4.Size = New System.Drawing.Size(133, 25)
        Me.AlphaBlendTextBox4.TabIndex = 30
        Me.AlphaBlendTextBox4.Text = "Não tem uma conta?"
        '
        'AlphaBlendTextBox3
        '
        Me.AlphaBlendTextBox3.BackAlpha = 10
        Me.AlphaBlendTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AlphaBlendTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaBlendTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.AlphaBlendTextBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AlphaBlendTextBox3.Location = New System.Drawing.Point(7, 15)
        Me.AlphaBlendTextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox3.Multiline = True
        Me.AlphaBlendTextBox3.Name = "AlphaBlendTextBox3"
        Me.AlphaBlendTextBox3.ReadOnly = True
        Me.AlphaBlendTextBox3.Size = New System.Drawing.Size(133, 37)
        Me.AlphaBlendTextBox3.TabIndex = 29
        Me.AlphaBlendTextBox3.Text = "Login"
        '
        'AlphaBlendTextBox2
        '
        Me.AlphaBlendTextBox2.BackAlpha = 10
        Me.AlphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox2.Location = New System.Drawing.Point(11, 158)
        Me.AlphaBlendTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox2.Name = "AlphaBlendTextBox2"
        Me.AlphaBlendTextBox2.ReadOnly = True
        Me.AlphaBlendTextBox2.Size = New System.Drawing.Size(133, 15)
        Me.AlphaBlendTextBox2.TabIndex = 28
        Me.AlphaBlendTextBox2.Text = "Senha:"
        '
        'AlphaBlendTextBox1
        '
        Me.AlphaBlendTextBox1.BackAlpha = 10
        Me.AlphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox1.Location = New System.Drawing.Point(11, 86)
        Me.AlphaBlendTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaBlendTextBox1.Name = "AlphaBlendTextBox1"
        Me.AlphaBlendTextBox1.ReadOnly = True
        Me.AlphaBlendTextBox1.Size = New System.Drawing.Size(133, 15)
        Me.AlphaBlendTextBox1.TabIndex = 27
        Me.AlphaBlendTextBox1.Text = "Login ou Email:"
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.Location = New System.Drawing.Point(43, 233)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(160, 38)
        Me.btn_entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.TabStop = False
        '
        'chk_senha_login
        '
        Me.chk_senha_login.AutoSize = True
        Me.chk_senha_login.BackColor = System.Drawing.Color.Transparent
        Me.chk_senha_login.Location = New System.Drawing.Point(12, 208)
        Me.chk_senha_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_senha_login.Name = "chk_senha_login"
        Me.chk_senha_login.Size = New System.Drawing.Size(18, 17)
        Me.chk_senha_login.TabIndex = 26
        Me.chk_senha_login.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 288)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.link_cardapio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_entrar As PictureBox
    Friend WithEvents AlphaBlendTextBox1 As ZBobb.AlphaBlendTextBox
    Friend WithEvents AlphaBlendTextBox2 As ZBobb.AlphaBlendTextBox
    Friend WithEvents AlphaBlendTextBox3 As ZBobb.AlphaBlendTextBox
    Friend WithEvents AlphaBlendTextBox4 As ZBobb.AlphaBlendTextBox
    Friend WithEvents AlphaBlendTextBox5 As ZBobb.AlphaBlendTextBox
    Friend WithEvents chk_senha_login As CheckBox
    Friend WithEvents AlphaBlendTextBox7 As ZBobb.AlphaBlendTextBox
    Friend WithEvents link_cardapio As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents link_cadastro As LinkLabel
    Friend WithEvents link_senha As LinkLabel
End Class
