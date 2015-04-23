Public Class ManageUsers


    Private Sub ManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim db As New SMSDataContext
        Dim UserList = From p In db.Users
                       Select p Order By p.UserName Ascending

        ListExistingUsers.Items.Clear()
        If UserList.Count <> 0 Then
            For j = 1 To UserList.Count
                ListExistingUsers.Items.Add(UserList.ToList(j - 1).UserName)
            Next
        End If
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        If ListExistingUsers.Text = "" Then
            MsgBox("Please select an existing User first!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If ListExistingUsers.Items.Count = 1 Then
            MsgBox("You can't remove all the user. One account must be present so that software can be accessible !!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim SelectedUser = From p In db.Users
                          Where p.UserName = ListExistingUsers.Text
                          Select p

        db.Users.DeleteOnSubmit(SelectedUser.FirstOrDefault)
        db.SubmitChanges()
        MsgBox("Selected User Successfully Removed. ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        ManageUsers_Load(sender, e)
        Exit Sub
    End Sub

    Private Sub ButtonLoadPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadPicture.Click
        With OpenFileDialog1
            .Title = "Select a JPG Image "
            .FileName = ""
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureUser.Load(.FileName)

            End If
        End With
    End Sub

    Private Sub ButtonAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddUser.Click
        If TextUserName.Text = "" Or TextPassword.Text = "" Or TextRePassword.Text = "" Or TextFullName.Text = "" Or ComboAccessLevel.Text = "" Then
            MsgBox("Enter Username , Password , Fullname and Access Level to proceed !! ", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextPassword.Text <> TextRePassword.Text Then
            MsgBox("Passwords You have entered do not match !!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckUser = From p In db.Users
                        Where p.UserName = TextUserName.Text
                        Select p

        If CheckUser.Count <> 0 Then
            MsgBox("User already Registered !!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim NewUserDetails As New User With {.UserName = TextUserName.Text, .Password = TextPassword.Text, .FullName = TextFullName.Text, .AccessLevel = ComboAccessLevel.Text, .UserPicture = PictureUser.ImageLocation}
        db.Users.InsertOnSubmit(NewUserDetails)
        db.SubmitChanges()
        MsgBox("User Addedd Successfully. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        TextFullName.Clear()
        TextUserName.Clear()
        TextPassword.Clear()
        TextRePassword.Clear()
        PictureUser.Image = Nothing
        TextUserName.Focus()
        ManageUsers_Load(sender, e)
        Exit Sub
    End Sub
End Class