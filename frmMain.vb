Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mniExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub mnuPOS_Click(sender As Object, e As EventArgs) Handles mnuPOS.Click


        frmPOS.Show()

    End Sub

    Private Sub mnuUsers_Click(sender As Object, e As EventArgs) Handles mnuUsers.Click
        frmUsers.Show()
    End Sub
End Class