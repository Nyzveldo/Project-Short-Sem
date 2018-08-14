Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminStu_details.Show()
        Me.Hide()

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Close()
        Form1.Show()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
    End Sub
End Class