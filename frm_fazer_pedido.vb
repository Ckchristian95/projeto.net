Imports System.Runtime.InteropServices

Public Class frm_fazer_pedido
    Private Sub btn_ver_carrinho_Click(sender As Object, e As EventArgs) Handles btn_ver_carrinho.Click
        frm_carrinho.ShowDialog()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

        dgv_dados.CurrentRow.Cells(4).Selected = True
        txt_id.Text = dgv_dados.CurrentRow.Cells(0).Value
        txt_nome_produto.Text = dgv_dados.CurrentRow.Cells(1).Value
        txt_preco.Text = dgv_dados.CurrentRow.Cells(2).Value
        txt_qtde_estoque.Text = dgv_dados.CurrentRow.Cells(3).Value
    End Sub

    Private Sub frm_fazer_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "select * from tb_PRODUTOS order by ID_PRODUTO asc"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Private Sub btn_adicionar_carrinho_Click(sender As Object, e As EventArgs) Handles btn_adicionar_carrinho.Click

        sql = "select * from tb_clientes where CPF_CLIENTE = '" & txt_cpf_cliente.Text.Replace(",", ".") & "'"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            MsgBox("CPF não cadastrado!", MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf txt_nome_produto.Text = "" Then
            MsgBox("Selecione o Produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "select * from  tb_carrinho where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_carrinho set QTDE_PEDIDO = '" & (rs.Fields(6).Value + 1) & "' where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
                rs = db.Execute(UCase(sql))


                sql = "select * from tb_carrinho"
                rs = db.Execute(sql)
                qtde = rs.Fields(6).Value
                mult = rs.Fields(7).Value
                total = qtde * mult

                sql = "update tb_carrinho set TOTAL_ITEM = '" & total.ToString(".") & "'"
                rs = db.Execute(sql)

            Else

                sql = "insert into tb_carrinho (NOME_PRODUTO, PRECO_VENDA, QTDE_PEDIDO, STATUS, TOTAL_ITEM, DATA_COMPRA, CPF_FUNCIONARIO, CPF_CLIENTE) values ('" & txt_nome_produto.Text & "' , '" & txt_preco.Text.Replace(",", ".") & "', '1' ,'PENDENTE' , '" & txt_preco.Text.Replace(",", ".") & "' , '" & Date.Now.ToShortDateString & "', '" & cpf_func & "', '" & txt_cpf_cliente.Text.Replace(",", ".") & "');"
                rs = db.Execute(UCase(sql))
            End If
        End If

    End Sub

End Class