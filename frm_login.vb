Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
            Me.Close()
            frm_cadastro.ShowDialog()
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
