Public Class frm_menu_admin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()
        End While

        Dim nf As New frm_cadastro With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()
        End While
    End Sub

    Private Sub menu_img_Click(sender As Object, e As EventArgs) Handles menu_img.Click
        If left_panel.Width > 50 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If left_panel.Width > 50 Then
            left_panel.Width -= 5
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If left_panel.Width < 149 Then
            left_panel.Width += 5
        Else
            Timer2.Enabled = False

        End If
    End Sub



    Private Sub left_panel_SizeChanged(sender As Object, e As EventArgs) Handles left_panel.SizeChanged
        If left_panel.Width < 100 Then
            btn_cadastro.Text = ""
            btn_logout.Text = ""


        Else
            btn_logout.Text = "Logout"
            btn_cadastro.Text = "Cadastro"
            menu_img.Dock = DockStyle.Right
        End If
    End Sub

    Private Sub menu_img_Click_1(sender As Object, e As EventArgs) Handles menu_img.Click

    End Sub
End Class