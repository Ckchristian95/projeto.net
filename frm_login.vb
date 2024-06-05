Imports System.Net.Mail
Imports System.Runtime
Imports System.Runtime.InteropServices

Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        sql = " select * from tb_funcionarios where USUARIO = '" & txt_usuario.Text & "'And SENHA = '" & txt_senha.Text & "'"
        rs = db.Execute(sql)

        If txt_usuario.Text = "adm" And txt_senha.Text = "123" Then
            Me.Close()
            frm_menu_admin.btn_login.Enabled = False
            frm_menu_admin.btn_cadastro_funcionario.Enabled = True
            frm_menu_admin.btn_relatorio.Enabled = True
            frm_menu_admin.btn_logoff.Enabled = True


        ElseIf rs.EOF = False Then
            cpf_func = rs.Fields(2).Value
            If rs.Fields(5).Value <> txt_usuario.Text Or rs.Fields(6).Value <> txt_senha.Text Then
                MsgBox("Usuario ou senha invalidos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

            ElseIf rs.Fields(3).Value = "VENDEDOR" Then
                Me.Close()
                frm_menu_admin.btn_login.Enabled = False
                frm_menu_admin.btn_pedidos.Enabled = True
                frm_menu_admin.btn_pedir.Enabled = True
                frm_menu_admin.btn_cadastrar_cliente.Enabled = True
                frm_menu_admin.btn_estoque.Enabled = True
                frm_menu_admin.btn_logoff.Enabled = True

            ElseIf rs.Fields(3).Value = "COMPRADOR" Then
                Me.Close()
                frm_menu_admin.btn_login.Enabled = False
                frm_menu_admin.btn_estoque.Enabled = True
                frm_menu_admin.btn_cadastrar_produto.Enabled = True
                frm_menu_admin.btn_logoff.Enabled = True

            Else
                MsgBox("Usuário não encontrado!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
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

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
