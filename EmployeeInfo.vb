Public Class EmployeeInfo
    Public Shared ReadOnly Instance As New EmployeeInfo()

    Private Sub New()
    End Sub

    Private Name As String
    Public m_FirstName As String

    Public m_LastName As String
    Public m_BirthDay As Date
    Public m_DateHire As Date
    Public m_EmployeeType As String
End Class
