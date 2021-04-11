<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeInformation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIsActive = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbEmployeeType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtDateHired = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnCreateEmployee = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(75, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIsActive)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbEmployeeType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtDateHired)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtBirthday)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 277)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE INFORMATION"
        '
        'cmbIsActive
        '
        Me.cmbIsActive.FormattingEnabled = True
        Me.cmbIsActive.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbIsActive.Location = New System.Drawing.Point(339, 207)
        Me.cmbIsActive.Name = "cmbIsActive"
        Me.cmbIsActive.Size = New System.Drawing.Size(200, 31)
        Me.cmbIsActive.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(409, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(335, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "IS ACTIVE"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(10, 241)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(240, 23)
        Me.txtPassword.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(112, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 23)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "SET PASSWORD"
        '
        'cmbEmployeeType
        '
        Me.cmbEmployeeType.FormattingEnabled = True
        Me.cmbEmployeeType.Location = New System.Drawing.Point(10, 174)
        Me.cmbEmployeeType.Name = "cmbEmployeeType"
        Me.cmbEmployeeType.Size = New System.Drawing.Size(240, 31)
        Me.cmbEmployeeType.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(112, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Employee Type"
        '
        'dtDateHired
        '
        Me.dtDateHired.AllowDrop = True
        Me.dtDateHired.CustomFormat = "yyyy-MM-dd"
        Me.dtDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateHired.Location = New System.Drawing.Point(339, 137)
        Me.dtDateHired.Name = "dtDateHired"
        Me.dtDateHired.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtDateHired.Size = New System.Drawing.Size(200, 30)
        Me.dtDateHired.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(409, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Date Hired"
        '
        'dtBirthday
        '
        Me.dtBirthday.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dtBirthday.CustomFormat = "yyyy-MM-dd"
        Me.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBirthday.Location = New System.Drawing.Point(339, 70)
        Me.dtBirthday.Name = "dtBirthday"
        Me.dtBirthday.Size = New System.Drawing.Size(200, 30)
        Me.dtBirthday.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Birthday"
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Location = New System.Drawing.Point(10, 122)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(240, 23)
        Me.txtLastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(75, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LastName"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Location = New System.Drawing.Point(10, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(240, 23)
        Me.txtFirstName.TabIndex = 2
        '
        'btnCreateEmployee
        '
        Me.btnCreateEmployee.Image = CType(resources.GetObject("btnCreateEmployee.Image"), System.Drawing.Image)
        Me.btnCreateEmployee.Location = New System.Drawing.Point(705, 295)
        Me.btnCreateEmployee.Name = "btnCreateEmployee"
        Me.btnCreateEmployee.Size = New System.Drawing.Size(197, 58)
        Me.btnCreateEmployee.TabIndex = 3
        Me.btnCreateEmployee.Text = "CREATE EMPLOYEE"
        Me.btnCreateEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateEmployee.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Image = CType(resources.GetObject("btnUploadImage.Image"), System.Drawing.Image)
        Me.btnUploadImage.Location = New System.Drawing.Point(29, 227)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(200, 62)
        Me.btnUploadImage.TabIndex = 5
        Me.btnUploadImage.Text = "UPLOAD PHOTO"
        Me.btnUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUploadImage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(564, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 58)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEmployeeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUploadImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCreateEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEmployeeInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW EMPLOYEE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtDateHired As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbEmployeeType As ComboBox
    Friend WithEvents btnCreateEmployee As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents dtBirthday As DateTimePicker
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbIsActive As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExit As Button
End Class
