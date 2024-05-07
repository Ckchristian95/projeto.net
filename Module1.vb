Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Sub conectar_banco()
        db = CreateObject("ADODB.Connection")
        db.Open("Provider=Microsoft.JET.OLEDB.4.0;DataSource=" & Application.StartupPath & "\banco\tb_cadastro.mdb")
        MsgBox("CONEXÃO FEITA COM SUCESSO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    End Sub
End Module
