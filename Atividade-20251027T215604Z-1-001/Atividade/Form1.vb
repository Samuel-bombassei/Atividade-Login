Public Class menu_principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()

    End Sub

    Private Sub LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LToolStripMenuItem.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Process.Start("excel.exe")
    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        Process.Start("winword.exe")
    End Sub

    Private Sub PowerpointToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerpointToolStripMenuItem.Click
        Process.Start("powerpnt.exe")
    End Sub

    Private Sub tsm_cadastro_Click(sender As Object, e As EventArgs) Handles tsm_cadastro.Click
        cadastro.Show()
    End Sub
End Class
