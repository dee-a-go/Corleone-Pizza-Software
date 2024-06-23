Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 25 Then
                lbl_load.Text = "Carregando Menus"
            ElseIf ProgressBar1.Value = 50 Then
                lbl_load.Text = "Conectando Banco de dados"
                conectar_banco()
            ElseIf ProgressBar1.Value = 75 Then
                lbl_load.Text = "Carregando Registros"
            End If
        Else
            Timer1.Stop()
            ProgressBar1.Value = 0
            Me.Hide()
            frm_login.Show()
        End If
    End Sub

End Class