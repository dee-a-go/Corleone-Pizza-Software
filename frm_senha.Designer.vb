<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_senha))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.btn_senha = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        CType(Me.btn_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(15, 117)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(200, 22)
        Me.txt_email.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Login:"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(16, 46)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(199, 22)
        Me.txt_login.TabIndex = 8
        '
        'btn_senha
        '
        Me.btn_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_senha.Image = CType(resources.GetObject("btn_senha.Image"), System.Drawing.Image)
        Me.btn_senha.Location = New System.Drawing.Point(40, 241)
        Me.btn_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_senha.Name = "btn_senha"
        Me.btn_senha.Size = New System.Drawing.Size(160, 33)
        Me.btn_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_senha.TabIndex = 14
        Me.btn_senha.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(15, 191)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(200, 22)
        Me.txt_cpf.TabIndex = 15
        '
        'frm_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(256, 289)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        CType(Me.btn_senha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents btn_senha As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
End Class
