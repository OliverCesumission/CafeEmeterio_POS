

Public Class frmEmployeeInformation
    Dim Employee = EmployeeInfo.Instance
    Dim dt As String
    Dim frmUSers As frmUsers
    Private SQL As New SQLControl
    Dim AccessID As String
    Dim SelectedAccessType As Char
    Dim isEmployeeActive As String
    Dim isActive As String

    Private Sub btnCreateEmployee_Click(sender As Object, e As EventArgs) Handles btnCreateEmployee.Click

        'Dim Employee As EmployeeInfo = New EmployeeInfo()

        'dt = dtBirthday.Value.Year.ToString() + "-" + dtBirthday.Value.Month.ToString("D2") + "-" + dtBirthday.Value.Day.ToString("D2")

        'MessageBox.Show(cmbEmployeeType.SelectedItem.ToString)

        SelectedAccessType = cmbEmployeeType.SelectedItem.ToString


        Select Case SelectedAccessType
            Case "Admin"
                AccessID = "1"
            Case "Auditor"
                AccessID = "2"
            Case "POS_ser"
                AccessID = "3"
            Case "Regular"
                AccessID = "4"
        End Select

        isEmployeeActive = cmbIsActive.SelectedItem.ToString
        Select Case isEmployeeActive
            Case "YES"
                isActive = "1"
            Case "NO"
                isActive = "0"
        End Select

        SQL.AddParam("@FirstName", txtFirstName.Text)
        SQL.AddParam("@LastName", txtLastName.Text)
        SQL.AddParam("@NickName", txtFirstName.Text)
        SQL.AddParam("@Birthday", dtBirthday.Value.ToShortDateString)
        SQL.AddParam("@DateHired", dtDateHired.Value.ToShortDateString)
        SQL.AddParam("@Position", cmbEmployeeType.SelectedItem.ToString)
        SQL.AddParam("@AccessID", AccessID)
        SQL.AddParam("@UserName", txtFirstName.Text + txtLastName.Text)
        SQL.AddParam("@Password", txtPassword.Text)
        SQL.AddParam("@IsActive", isActive)

        SQL.ExecQuery("INSERT INTO Dim_Users (LastName,FirstName,NickName,Birthday,DateHired,Position,AccessID,UserName,Password,IsActive) VALUES(@FirstName, @LastName, @NickName, @Birthday, @DateHired, @Position, @AccessID, @UserName, @Password, @IsActive); ")
        'SQL.ExecQuery("insert into CafeBillTemp (BillNo, BillDate, Cashier) values(@BillNo, @BillDate, @Logged); ")
        SQL.ExecQuery("SELECT * FROM Dim_Users")

        If SQL.HasException(True) Then Exit Sub

        Me.Close()
    End Sub

    Private Sub frmEmployeeInformation_Load(sender As Object, e As EventArgs) Handles Me.Load

        SQL.ExecQuery("SELECT AccessType FROM DIM_AccessType")

        Dim Data As DataTable = SQL.DBDT

        For Each Row As DataRow In Data.Rows
            cmbEmployeeType.Items.Add(Row.Item(0)).ToString()
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class