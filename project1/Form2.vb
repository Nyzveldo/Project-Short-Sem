Imports System.Data.OleDb
Public Class Form2
    Dim dbProvider As String
    Dim dbSource As String

    Sub Connection()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb")
        conn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

        Student_Information_Detail.Show()

        Student_Information_Detail.id.Text = rd("ID")
        Student_Information_Detail.username.Text = rd("Username")
        Student_Information_Detail.password.Text = rd("Password")
        Student_Information_Detail.FirstName.Text = rd("First Name")
        Student_Information_Detail.Lastname.Text = rd("Last Name")
        Student_Information_Detail.ICNumber.Text = rd("IC Number")
        Student_Information_Detail.Role.Text = rd("Role")
        Student_Information_Detail.Gender.Text = rd("Gender")
        Student_Information_Detail.Address.Text = rd("Address")
        Student_Information_Detail.Phone.Text = rd("Phone")
        Student_Information_Detail.Email.Text = rd("Email")





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Form1.Show()



    End Sub
End Class