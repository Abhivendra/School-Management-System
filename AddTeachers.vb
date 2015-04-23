Public Class AddTeachers


    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        PictureTeacher.Image = Nothing
    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        With OpenFileDialog1
            .Title = "Select a JPEG Image"
            .Multiselect = False
            .FileName = ""
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                PictureTeacher.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If TextStaffID.Text = "" Or TextFullName.Text = "" Or ComboAge.Text = "" Or ComboGender.Text = "" Or ComboDesigngnation.Text = "" Or TextContactNo.Text = "" Then
            MsgBox("Staff ID , Full Name , Age , Gender , Desingnation and Contact Number are required fields ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckTeacher = From p In db.Teachers
                           Where p.staff_id = TextStaffID.Text
                           Select p
        If CheckTeacher.Count <> 0 Then
            MsgBox("A member alreaddy present with this Staff ID! Please Correct Staff ID and Try Again .", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim NewTeacher As New Teacher With {.staff_id = TextStaffID.Text, .Address = TextAddress.Text, .age = ComboAge.Text, .Contact_No = TextContactNo.Text, .desingnation = ComboDesigngnation.Text, .email_ID = TextEmailID.Text, .full_name = TextFullName.Text, .gender = ComboGender.Text, .Picture = PictureTeacher.ImageLocation}
        db.Teachers.InsertOnSubmit(NewTeacher)
        db.SubmitChanges()
        MsgBox("Record Addedd Successfully .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

End Class