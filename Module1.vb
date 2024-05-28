Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Timers
Imports ADODB

Module Module1
    'Public nf As New frm_cadastro With {.TopMost = False, .AutoSize = True}
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp As String
    Public cont As Integer

    Sub conectar_banco()

        db = CreateObject("ADODB.Connection")
        db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-TU83IG2;Initial Catalog=db_colaboradores;trusted_connection=yes;")
        MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

    End Sub
End Module
