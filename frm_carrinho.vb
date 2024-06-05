Public Class frm_carrinho
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_carrinho.CellContentClick

    End Sub

    Private Sub frm_carrinho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub

    Sub carregar_dados()

        sql = "select * from tb_carrinho "
        rs = db.Execute(UCase(sql))

        With dgv_dados_carrinho
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(7).Value, rs.Fields(6).Value, Nothing)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Private Sub btn_finalizar_pedido_Click(sender As Object, e As EventArgs) Handles btn_finalizar_pedido.Click

        sql = "insert into tb_pedidos(CPF_FUNCIONARIO, CPF_CLIENTE, NOME_PRODUTO, STATUS, DATA_COMPRA, QTDE_PEDIDO, PRECO_VENDA, TOTAL_ITEM) 
        select CPF_FUNCIONARIO, CPF_CLIENTE, NOME_PRODUTO, STATUS, DATA_COMPRA, QTDE_PEDIDO, PRECO_VENDA, TOTAL_ITEM from tb_carrinho"
        rs = db.Execute(sql)


    End Sub
End Class
