Imports System.Drawing

Module mod_global
    Public SQL As String
    Public db As New ADODB.Connection
    Public rs_clientes As New ADODB.Recordset
    Public rs_funcionarios As New ADODB.Recordset
    Public rs_boss As New ADODB.Recordset
    Public rs_produtos As New ADODB.Recordset
    Public rs_carrinho As New ADODB.Recordset
    Public rs_pedidos As New ADODB.Recordset
    Public rs_historico As New ADODB.Recordset


    Public dir_fotos As String = Application.StartupPath & "\fotos"
    Public dir_foto_padrao As String = dir_fotos & "\users\add_user.png"
    Public dir_foto_produto_padrao As String = dir_fotos & "\products\add_product.png"
    Public dir_foto_selecionada As String

    Public log As String
    Public cpf As Object

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DiegoPC\SQLEXPRESS;Initial Catalog=db_corleone;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("Erro ao Conectar com o Banco de Dados." & Environment.NewLine &
                   "Por favor, entre em contato com os desenvolvedores.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Application.Exit()
        End Try
    End Sub

    Public Function GerarID() As Integer
        Randomize()
        Dim tempStr As String = ""
        For i As Integer = 1 To 6
            tempStr &= CStr(Int(Rnd() * 10))
        Next
        Return Convert.ToInt32(tempStr)
    End Function
End Module