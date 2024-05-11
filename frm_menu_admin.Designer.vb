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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.menu_img = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
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
        Me.left_panel.Controls.Add(Me.Panel2)
        Me.left_panel.Controls.Add(Me.btn_logout)
        Me.left_panel.Controls.Add(Me.btn_cadastro)
        Me.left_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_panel.Location = New System.Drawing.Point(0, 0)
        Me.left_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.left_panel.Name = "left_panel"
        Me.left_panel.Size = New System.Drawing.Size(151, 412)
        Me.left_panel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.menu_img)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.menu_img.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.menu_img.Name = "menu_img"
        Me.menu_img.Size = New System.Drawing.Size(45, 31)
        Me.menu_img.TabIndex = 2
        Me.menu_img.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(0, 229)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(151, 41)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastro.Image = CType(resources.GetObject("btn_cadastro.Image"), System.Drawing.Image)
        Me.btn_cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastro.Location = New System.Drawing.Point(0, 168)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(151, 38)
        Me.btn_cadastro.TabIndex = 0
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(151, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 31)
        Me.Panel1.TabIndex = 2
        '
        'center_panel
        '
        Me.center_panel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.center_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.center_panel.Location = New System.Drawing.Point(151, 31)
        Me.center_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.center_panel.Name = "center_panel"
        Me.center_panel.Size = New System.Drawing.Size(580, 381)
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
        Me.ClientSize = New System.Drawing.Size(731, 412)
        Me.Controls.Add(Me.center_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.left_panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents center_panel As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents menu_img As PictureBox
End Class
