<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_admin))
        Me.left_panel = New System.Windows.Forms.Panel()
        Me.btn_cadastro_funcionario = New System.Windows.Forms.Button()
        Me.btn_logoff = New System.Windows.Forms.Button()
        Me.btn_relatorio = New System.Windows.Forms.Button()
        Me.btn_cadastrar_produto = New System.Windows.Forms.Button()
        Me.btn_estoque = New System.Windows.Forms.Button()
        Me.btn_cadastrar_cliente = New System.Windows.Forms.Button()
        Me.btn_pedir = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.menu_img = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.center_panel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.left_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.menu_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'left_panel
        '
        Me.left_panel.BackColor = System.Drawing.SystemColors.Highlight
        Me.left_panel.Controls.Add(Me.btn_cadastro_funcionario)
        Me.left_panel.Controls.Add(Me.btn_logoff)
        Me.left_panel.Controls.Add(Me.btn_relatorio)
        Me.left_panel.Controls.Add(Me.btn_cadastrar_produto)
        Me.left_panel.Controls.Add(Me.btn_estoque)
        Me.left_panel.Controls.Add(Me.btn_cadastrar_cliente)
        Me.left_panel.Controls.Add(Me.btn_pedir)
        Me.left_panel.Controls.Add(Me.btn_pedidos)
        Me.left_panel.Controls.Add(Me.btn_login)
        Me.left_panel.Controls.Add(Me.Panel2)
        Me.left_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_panel.Location = New System.Drawing.Point(0, 0)
        Me.left_panel.Margin = New System.Windows.Forms.Padding(2)
        Me.left_panel.Name = "left_panel"
        Me.left_panel.Size = New System.Drawing.Size(151, 668)
        Me.left_panel.TabIndex = 1
        '
        'btn_cadastro_funcionario
        '
        Me.btn_cadastro_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastro_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastro_funcionario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastro_funcionario.Image = CType(resources.GetObject("btn_cadastro_funcionario.Image"), System.Drawing.Image)
        Me.btn_cadastro_funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastro_funcionario.Location = New System.Drawing.Point(2, 474)
        Me.btn_cadastro_funcionario.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastro_funcionario.Name = "btn_cadastro_funcionario"
        Me.btn_cadastro_funcionario.Size = New System.Drawing.Size(149, 50)
        Me.btn_cadastro_funcionario.TabIndex = 0
        Me.btn_cadastro_funcionario.Text = "Funcionários"
        Me.btn_cadastro_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastro_funcionario.UseVisualStyleBackColor = True
        '
        'btn_logoff
        '
        Me.btn_logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logoff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logoff.Image = CType(resources.GetObject("btn_logoff.Image"), System.Drawing.Image)
        Me.btn_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logoff.Location = New System.Drawing.Point(2, 582)
        Me.btn_logoff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logoff.Name = "btn_logoff"
        Me.btn_logoff.Size = New System.Drawing.Size(151, 50)
        Me.btn_logoff.TabIndex = 11
        Me.btn_logoff.Text = "Logoff"
        Me.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_logoff.UseVisualStyleBackColor = True
        '
        'btn_relatorio
        '
        Me.btn_relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_relatorio.Image = CType(resources.GetObject("btn_relatorio.Image"), System.Drawing.Image)
        Me.btn_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_relatorio.Location = New System.Drawing.Point(0, 528)
        Me.btn_relatorio.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_relatorio.Name = "btn_relatorio"
        Me.btn_relatorio.Size = New System.Drawing.Size(151, 50)
        Me.btn_relatorio.TabIndex = 10
        Me.btn_relatorio.Text = "Gerar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Relatório"
        Me.btn_relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_relatorio.UseVisualStyleBackColor = True
        '
        'btn_cadastrar_produto
        '
        Me.btn_cadastrar_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastrar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar_produto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_produto.Image = CType(resources.GetObject("btn_cadastrar_produto.Image"), System.Drawing.Image)
        Me.btn_cadastrar_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_produto.Location = New System.Drawing.Point(2, 420)
        Me.btn_cadastrar_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastrar_produto.Name = "btn_cadastrar_produto"
        Me.btn_cadastrar_produto.Size = New System.Drawing.Size(151, 50)
        Me.btn_cadastrar_produto.TabIndex = 9
        Me.btn_cadastrar_produto.Text = "Cadastrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Produto"
        Me.btn_cadastrar_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_produto.UseVisualStyleBackColor = True
        '
        'btn_estoque
        '
        Me.btn_estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estoque.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), System.Drawing.Image)
        Me.btn_estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estoque.Location = New System.Drawing.Point(2, 366)
        Me.btn_estoque.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(151, 50)
        Me.btn_estoque.TabIndex = 8
        Me.btn_estoque.Text = "Situação do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "estoque"
        Me.btn_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_estoque.UseVisualStyleBackColor = True
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.Image = CType(resources.GetObject("btn_cadastrar_cliente.Image"), System.Drawing.Image)
        Me.btn_cadastrar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(0, 312)
        Me.btn_cadastrar_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(151, 50)
        Me.btn_cadastrar_cliente.TabIndex = 7
        Me.btn_cadastrar_cliente.Text = "Cadastrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        Me.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_cliente.UseVisualStyleBackColor = True
        '
        'btn_pedir
        '
        Me.btn_pedir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pedir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedir.Image = CType(resources.GetObject("btn_pedir.Image"), System.Drawing.Image)
        Me.btn_pedir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pedir.Location = New System.Drawing.Point(0, 258)
        Me.btn_pedir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedir.Name = "btn_pedir"
        Me.btn_pedir.Size = New System.Drawing.Size(151, 50)
        Me.btn_pedir.TabIndex = 6
        Me.btn_pedir.Text = "Fazer Pedido"
        Me.btn_pedir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pedir.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedidos.Image = CType(resources.GetObject("btn_pedidos.Image"), System.Drawing.Image)
        Me.btn_pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pedidos.Location = New System.Drawing.Point(2, 204)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(151, 50)
        Me.btn_pedidos.TabIndex = 5
        Me.btn_pedidos.Text = "Pedidos"
        Me.btn_pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_login.Location = New System.Drawing.Point(2, 150)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(151, 50)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Fazer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Login"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.menu_img)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 31)
        Me.Panel2.TabIndex = 3
        '
        'menu_img
        '
        Me.menu_img.BackgroundImage = CType(resources.GetObject("menu_img.BackgroundImage"), System.Drawing.Image)
        Me.menu_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu_img.Dock = System.Windows.Forms.DockStyle.Right
        Me.menu_img.Location = New System.Drawing.Point(106, 0)
        Me.menu_img.Margin = New System.Windows.Forms.Padding(2)
        Me.menu_img.Name = "menu_img"
        Me.menu_img.Size = New System.Drawing.Size(45, 31)
        Me.menu_img.TabIndex = 2
        Me.menu_img.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 31)
        Me.Panel1.TabIndex = 2
        '
        'center_panel
        '
        Me.center_panel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.center_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.center_panel.Location = New System.Drawing.Point(151, 31)
        Me.center_panel.Margin = New System.Windows.Forms.Padding(2)
        Me.center_panel.Name = "center_panel"
        Me.center_panel.Size = New System.Drawing.Size(580, 637)
        Me.center_panel.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'frm_menu_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 668)
        Me.Controls.Add(Me.center_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.left_panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_menu_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WORKSPACE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.left_panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.menu_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents left_panel As Panel
    Friend WithEvents btn_cadastro_funcionario As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents center_panel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents menu_img As PictureBox
    Friend WithEvents btn_logoff As Button
    Friend WithEvents btn_relatorio As Button
    Friend WithEvents btn_cadastrar_produto As Button
    Friend WithEvents btn_estoque As Button
    Friend WithEvents btn_cadastrar_cliente As Button
    Friend WithEvents btn_pedir As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents btn_login As Button
End Class
