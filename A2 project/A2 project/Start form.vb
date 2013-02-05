Public Class Start_form

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label2.Text = My.User.Name
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim parts() As String = Split(My.User.Name, "\")
        Label2.Text = parts(1)
    End Sub

    Private Sub Start_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class