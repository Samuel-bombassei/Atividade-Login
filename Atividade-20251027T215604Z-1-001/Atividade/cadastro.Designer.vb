<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_repita = New System.Windows.Forms.TextBox()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmn_bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmn_excluir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Usuário"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(74, 92)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(247, 28)
        Me.txt_usuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(74, 175)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(247, 28)
        Me.txt_senha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Repita a Senha"
        '
        'txt_repita
        '
        Me.txt_repita.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repita.Location = New System.Drawing.Point(367, 175)
        Me.txt_repita.Name = "txt_repita"
        Me.txt_repita.Size = New System.Drawing.Size(247, 28)
        Me.txt_repita.TabIndex = 5
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usuario, Me.senha, Me.status, Me.tipo, Me.cmn_bloquear, Me.Column1, Me.cmn_excluir})
        Me.dgv_usuarios.Location = New System.Drawing.Point(2, 222)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.RowHeadersWidth = 51
        Me.dgv_usuarios.RowTemplate.Height = 24
        Me.dgv_usuarios.Size = New System.Drawing.Size(743, 162)
        Me.dgv_usuarios.TabIndex = 6
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(245, 412)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(157, 45)
        Me.btn_cadastrar.TabIndex = 7
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "USUÁRIO"
        Me.usuario.MinimumWidth = 8
        Me.usuario.Name = "usuario"
        Me.usuario.Width = 97
        '
        'senha
        '
        Me.senha.HeaderText = "SENHA"
        Me.senha.MinimumWidth = 8
        Me.senha.Name = "senha"
        Me.senha.Width = 83
        '
        'status
        '
        Me.status.HeaderText = "STATUS"
        Me.status.MinimumWidth = 8
        Me.status.Name = "status"
        Me.status.Width = 91
        '
        'tipo
        '
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.MinimumWidth = 8
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 67
        '
        'cmn_bloquear
        '
        Me.cmn_bloquear.HeaderText = "BLOQUEAR"
        Me.cmn_bloquear.Image = CType(resources.GetObject("cmn_bloquear.Image"), System.Drawing.Image)
        Me.cmn_bloquear.MinimumWidth = 6
        Me.cmn_bloquear.Name = "cmn_bloquear"
        Me.cmn_bloquear.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmn_bloquear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmn_bloquear.Width = 110
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESBLOQUEAR"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 115
        '
        'cmn_excluir
        '
        Me.cmn_excluir.HeaderText = "EXCLUIR"
        Me.cmn_excluir.Image = CType(resources.GetObject("cmn_excluir.Image"), System.Drawing.Image)
        Me.cmn_excluir.MinimumWidth = 6
        Me.cmn_excluir.Name = "cmn_excluir"
        Me.cmn_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmn_excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmn_excluir.Width = 92
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 483)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.txt_repita)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cadastro"
        Me.Text = "Cadastro de Usuários"
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_repita As TextBox
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents cmn_bloquear As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents cmn_excluir As DataGridViewImageColumn
End Class
