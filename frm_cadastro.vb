Imports System.Diagnostics.Eventing.Reader

Public Class frm_cadastro


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "admin" And txt_senha_login.Text = "admin" Then
            gb_1.Enabled = True
            dgv_dados.Enabled = True
            btn_sair.Enabled = True
            txt_senha_login.Enabled = False
            txt_usuario.Enabled = False
            btn_entrar.Enabled = False
            chk_box.Enabled = False
            txt_usuario.Text = ""
            txt_senha_login.Text = ""
            carregar_dados()


        Else
            sql = "select * from tb_colaboradores where USUARIO = '" & txt_usuario.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                MsgBox("Usuário inválido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            ElseIf rs.Fields(6).Value <> txt_senha_login.Text Then
                MsgBox("Senha inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            ElseIf rs.Fields(9).Value = "BLOQUEADO" Then
                MsgBox("Usuário bloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Else


                dgv_dados.Enabled = False
                btn_sair.Enabled = True
                txt_senha_login.Enabled = False
                txt_usuario.Enabled = False
                btn_entrar.Enabled = False
                dgv_editar.Visible = False
                dgv_excluir.Visible = False
                dgv_status.Visible = False
                txt_usuario.Text = ""
                txt_senha_login.Text = ""
                MsgBox("Entrou como Usuário", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")


            End If
        End If

    End Sub

    Private Sub chk_box_CheckedChanged(sender As Object, e As EventArgs) Handles chk_box.CheckedChanged
        If chk_box.Checked = True Then
            txt_senha_login.PasswordChar = ""
        Else
            txt_senha_login.PasswordChar = "*"

        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click

        limpar_dados()


        dgv_dados.Enabled = False
        btn_sair.Enabled = False
        gb_1.Enabled = False
        txt_senha_login.Enabled = True
        txt_usuario.Enabled = True
        btn_entrar.Enabled = True
        dgv_editar.Visible = True
        dgv_excluir.Visible = True
        dgv_status.Visible = True
        dgv_dados.Rows.Clear()
        txt_usuario.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txt_cpf.Text = "" Or txt_cargo.Text = "" Or txt_email.Text = "" Or txt_nome.Text = "" Or txt_login.Text = "" Or txt_senha.Text = "" Or cmb_data_nasc.Text = "" Or txt_endereco.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
            Exit Sub
        End If
        sql = "select * from tb_colaboradores where CPF = '" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            sql = "update tb_colaboradores set NOME = '" & txt_nome.Text & "', " &
                                             "CPF = '" & txt_cpf.Text & "', " &
                                             "CARGO = '" & txt_cargo.Text & "', " &
                                             "DATA_NASC = '" & cmb_data_nasc.Text & "', " &
                                             "USUARIO = '" & txt_login.Text & "', " &
                                             "SENHA = '" & txt_senha.Text & "', " &
                                             "EMAIL = '" & txt_email.Text & "', " &
                                             "ENDERECO = '" & txt_endereco.Text & "' where cpf= '" & txt_cpf.Text & "'"

            db.Execute(UCase(sql))
            limpar_dados()
            carregar_dados()
        Else
            sql = "insert into tb_colaboradores (NOME, CPF, CARGO,DATA_NASC,USUARIO,SENHA,EMAIL,ENDERECO,STATUS) values
                ('" & txt_nome.Text & "','" & txt_cpf.Text & "','" & txt_cargo.Text & "','" & cmb_data_nasc.Text & "','" & txt_login.Text & "', " &
                "'" & txt_senha.Text & "','" & txt_email.Text & "','" & txt_endereco.Text & "','ATIVO')"

            rs = db.Execute(UCase(sql))
            MsgBox("Dados Salvos com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limpar_dados()
            carregar_dados()

        End If


    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

        If dgv_dados.CurrentRow.Cells(5).Selected = True Then

            sql = "select * from tb_colaboradores where CPF = '" & dgv_dados.CurrentRow.Cells(3).Value & "'"
            rs = db.Execute(sql)

            txt_nome.Text = rs.Fields(1).Value
            txt_cargo.Text = rs.Fields(3).Value
            txt_email.Text = rs.Fields(7).Value
            txt_endereco.Text = rs.Fields(8).Value
            cmb_data_nasc.Text = rs.Fields(4).Value
            txt_login.Text = rs.Fields(5).Value
            txt_senha.Text = rs.Fields(6).Value
            txt_cpf.Text = rs.Fields(2).Value



        ElseIf dgv_dados.CurrentRow.Cells(6).Selected = True Then
            resp = MsgBox("Deseja mesmo excluir esse usuário?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete from tb_colaboradores where ID ='" & dgv_dados.CurrentRow.Cells(0).Value & "'"
                rs = db.Execute(sql)
                MsgBox("Usuário excluido com sucesso!")
                carregar_dados()

            End If
        ElseIf dgv_dados.CurrentRow.Cells(7).Selected = True Then
            sql = "select * from tb_colaboradores where ID = '" & dgv_dados.CurrentRow.Cells(0).Value & "'"
            rs = db.Execute(sql)
            If rs.Fields(9).Value = "ATIVO" Then
                sql = "update tb_colaboradores set STATUS = 'BLOQUEADO' where CPF= '" & dgv_dados.CurrentRow.Cells(3).Value & "';"
                rs = db.Execute(sql)
            Else
                sql = "update tb_colaboradores set STATUS = 'ATIVO'  where CPF= '" & dgv_dados.CurrentRow.Cells(3).Value & "';"
                rs = db.Execute(sql)

            End If
            carregar_dados()


        End If
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipo.Items.Add("ID")
        cmb_tipo.Items.Add("CPF")
        cmb_tipo.Items.Add("NOME")
    End Sub


    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If cmb_tipo.Text = "" Then
            Exit Sub
        Else
            sql = "select * from tb_colaboradores where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)

            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing, rs.Fields(9).Value)
                    rs.MoveNext()
                Loop
            End With
        End If
    End Sub


    Sub carregar_dados()
        sql = "select * from tb_colaboradores order by id asc"
        rs = db.Execute(sql)

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing, rs.Fields(9).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_dados()
        txt_cpf.Text = ""
        txt_cargo.Text = ""
        txt_email.Text = ""
        txt_endereco.Text = ""
        cmb_data_nasc.Text = ""
        txt_login.Text = ""
        txt_senha.Text = ""
        txt_nome.Text = ""
        txt_cpf.Focus()
    End Sub
End Class