<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_cadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_recursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerpointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LToolStripMenuItem, Me.tsm_cadastro, Me.tsm_recursos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.LToolStripMenuItem.Text = "Login"
        '
        'tsm_cadastro
        '
        Me.tsm_cadastro.Name = "tsm_cadastro"
        Me.tsm_cadastro.Size = New System.Drawing.Size(163, 24)
        Me.tsm_cadastro.Text = "Cadastro de Usuários"
        '
        'tsm_recursos
        '
        Me.tsm_recursos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.WordToolStripMenuItem, Me.PowerpointToolStripMenuItem})
        Me.tsm_recursos.Name = "tsm_recursos"
        Me.tsm_recursos.Size = New System.Drawing.Size(81, 24)
        Me.tsm_recursos.Text = "Recursos"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = CType(resources.GetObject("ExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Image = CType(resources.GetObject("WordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.WordToolStripMenuItem.Text = "Word "
        '
        'PowerpointToolStripMenuItem
        '
        Me.PowerpointToolStripMenuItem.Image = CType(resources.GetObject("PowerpointToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PowerpointToolStripMenuItem.Name = "PowerpointToolStripMenuItem"
        Me.PowerpointToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.PowerpointToolStripMenuItem.Text = "Powerpoint"
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu_principal"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm_cadastro As ToolStripMenuItem
    Friend WithEvents tsm_recursos As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowerpointToolStripMenuItem As ToolStripMenuItem
End Class
