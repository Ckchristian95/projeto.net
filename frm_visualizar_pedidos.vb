Public Class frm_visualizar_pedidos
    Private Sub frm_visualizar_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * from tb_pedidos "
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(8).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class