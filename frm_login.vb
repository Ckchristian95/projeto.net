Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "vendedor" And txt_senha.Text = "123" Then

            Me.Close()
            frm_menu_admin.btn_login.Enabled = False
            frm_menu_admin.btn_pedidos.Enabled = True
            frm_menu_admin.btn_pedir.Enabled = True
            frm_menu_admin.btn_cadastrar_cliente.Enabled = True
            frm_menu_admin.btn_estoque.Enabled = True
            frm_menu_admin.btn_logoff.Enabled = True

        ElseIf txt_usuario.Text = "comprador" And txt_senha.Text = "123" Then
            Me.Close()
            frm_menu_admin.btn_login.Enabled = False
            frm_menu_admin.btn_estoque.Enabled = True
            frm_menu_admin.btn_cadastrar_produto.Enabled = True
            frm_menu_admin.btn_logoff.Enabled = True
        ElseIf txt_usuario.Text = "adm" And txt_senha.Text = "123" Then
            Me.Close()
            frm_menu_admin.btn_login.Enabled = False
            frm_menu_admin.btn_cadastro_funcionario.Enabled = True
            frm_menu_admin.btn_relatorio.Enabled = True
            frm_menu_admin.btn_logoff.Enabled = True
        Else
            MsgBox("Usuário não encontrado!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub visualizar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles visualizar_senha.CheckedChanged
        If visualizar_senha.CheckState = False Then
            txt_senha.UseSystemPasswordChar = True
        Else
            txt_senha.UseSystemPasswordChar = False
        End If
    End Sub


End Class
