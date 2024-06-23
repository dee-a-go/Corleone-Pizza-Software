<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cardapio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cardapio))
        Me.btn_logar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_filtros = New System.Windows.Forms.PictureBox()
        CType(Me.btn_logar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_filtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logar
        '
        Me.btn_logar.BackColor = System.Drawing.Color.Transparent
        Me.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logar.Image = CType(resources.GetObject("btn_logar.Image"), System.Drawing.Image)
        Me.btn_logar.Location = New System.Drawing.Point(276, 564)
        Me.btn_logar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(264, 41)
        Me.btn_logar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_logar.TabIndex = 19
        Me.btn_logar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(313, 536)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ficou com fome?"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(352, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 17)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Sub-Categoria:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(120, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 17)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Categoria:"
        '
        'cmb_filtros_subcategoria
        '
        Me.cmb_filtros_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtros_subcategoria.FormattingEnabled = True
        Me.cmb_filtros_subcategoria.Location = New System.Drawing.Point(475, 27)
        Me.cmb_filtros_subcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_filtros_subcategoria.Name = "cmb_filtros_subcategoria"
        Me.cmb_filtros_subcategoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_filtros_subcategoria.TabIndex = 29
        '
        'cmb_filtros_categoria
        '
        Me.cmb_filtros_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtros_categoria.FormattingEnabled = True
        Me.cmb_filtros_categoria.Location = New System.Drawing.Point(209, 27)
        Me.cmb_filtros_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_filtros_categoria.Name = "cmb_filtros_categoria"
        Me.cmb_filtros_categoria.Size = New System.Drawing.Size(121, 24)
        Me.cmb_filtros_categoria.TabIndex = 28
        '
        'dgv_produtos
        '
        Me.dgv_produtos.AllowUserToAddRows = False
        Me.dgv_produtos.AllowUserToDeleteRows = False
        Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.Column1})
        Me.dgv_produtos.Location = New System.Drawing.Point(12, 78)
        Me.dgv_produtos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.ReadOnly = True
        Me.dgv_produtos.RowHeadersWidth = 62
        Me.dgv_produtos.RowTemplate.Height = 28
        Me.dgv_produtos.Size = New System.Drawing.Size(805, 446)
        Me.dgv_produtos.TabIndex = 27
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
        'Column1
        '
        Me.Column1.HeaderText = "Descrição"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 98
        '
        'btn_filtros
        '
        Me.btn_filtros.BackColor = System.Drawing.Color.Transparent
        Me.btn_filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtros.ErrorImage = Nothing
        Me.btn_filtros.Image = CType(resources.GetObject("btn_filtros.Image"), System.Drawing.Image)
        Me.btn_filtros.InitialImage = Nothing
        Me.btn_filtros.Location = New System.Drawing.Point(642, 10)
        Me.btn_filtros.Name = "btn_filtros"
        Me.btn_filtros.Size = New System.Drawing.Size(124, 55)
        Me.btn_filtros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_filtros.TabIndex = 32
        Me.btn_filtros.TabStop = False
        '
        'frm_cardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_filtros)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmb_filtros_subcategoria)
        Me.Controls.Add(Me.cmb_filtros_categoria)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_logar)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_cardapio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corleone"
        CType(Me.btn_logar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_filtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_logar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cmb_filtros_subcategoria As ComboBox
    Friend WithEvents cmb_filtros_categoria As ComboBox
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btn_filtros As PictureBox
End Class
