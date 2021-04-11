Public Class frmUsers
    ' Public Logged As String
    Private SQL As New SQLControl
    Dim NewEmployeeInfo = EmployeeInfo.Instance
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        QueryTable()
    End Sub
    Private Sub ClearText()

    End Sub

    Private Sub QueryTable()
        'SQL.AddParam("@User", Username)
        'SQL.AddParam("@PW", Password)

        'SQL.ExecQuery("SELECT UserName, Password FROM Dim_Users WHERE UserName = Lower(@User) and Password = @PW; ")

        SQL.ExecQuery("SELECT * FROM Dim_Users")

        If SQL.HasException(True) Then Exit Sub

        dgvUsers.DataSource = SQL.DBDT


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        frmEmployeeInformation.Show()
        'Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        dgvUsers.Rows.Add(New String() {"Value1", "Value2", "Value3"})
    End Sub

    Sub AddRow()



    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        QueryTable()
    End Sub
End Class