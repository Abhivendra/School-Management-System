' This Code is Property of Abhivendra Singh( CTO AnkArp IT Solutions Private Limited )
Public Class User_Login

    ' TODO:authentication using the provided username and password 
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Enter Your User Name and Password First !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckUser = From p In db.Users Where p.UserName = UsernameTextBox.Text And p.Password = PasswordTextBox.Text Select p

        If CheckUser.Count = 0 Then
            MsgBox("Invalid Username or Password Entered ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            MainInterface.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
