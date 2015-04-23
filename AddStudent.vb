Public Class AddStudent


    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        TextRegNo.Clear()
        TextFullName.Clear()
        ComboGender.Text = ""
        NudAge.Value = 0
        ComboClass.Text = ""
        ComboStream.Text = ""
        PictureBox1.Image = Nothing
        TextPerAdr.Clear()
        TextRegAdr.Clear()
        TextContactNo.Clear()
        TextEmailId.Clear()
        TextMotherName.Clear()
        TextMotherCo.Clear()
        TextMotherOcc.Clear()
        TextFatherNme.Clear()
        TextFatherCo.Clear()
        TextFathrOcc.Clear()
        TextMotherIn.Clear()
        TextFatherIn.Clear()
        TextRegNo.Focus()
    End Sub

    Private Sub ButtonClearPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearPicture.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ButtonLoadPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadPicture.Click
        With OpenFileDialog1
            .Title = "Select a JPG Image "
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)

            End If
        End With
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If TextRegNo.Text = "" Or TextFullName.Text = "" Or ComboGender.Text = "" Or ComboClass.Text = "" Or ComboStream.Text = "" Then
            MsgBox("Registration Number , Full Name , Gender , Class and Stream are required feilds!! Complete them to Proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckStudentDetails = From p In db.Students
                                  Where p.Registration_No = TextRegNo.Text
                                  Select p
        If CheckStudentDetails.Count <> 0 Then
            MsgBox("A student is alredy present with this Registration Number ! You have to correct Registation Number and try again . ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim NewStudent As New Student With {.Registration_No = TextRegNo.Text, .Full_Name = TextFullName.Text, .Age = NudAge.Value, .Gender = ComboGender.Text, .Ressedential_Address = TextRegAdr.Text, .Class = ComboClass.Text, .Contact_No = TextContactNo.Text, .Stream = ComboStream.Text, .Email_ID = TextEmailId.Text, .Permanent_Address = TextPerAdr.Text, .Picture = PictureBox1.ImageLocation, .Mother_name = TextMotherName.Text, .mother_occ = TextMotherOcc.Text, .mother_contact = TextMotherCo.Text, .father_name = TextFatherNme.Text, .father_occ = TextFathrOcc.Text, .father_contact = TextFatherCo.Text, .mother_salary = TextMotherIn.Text, .father_salary = TextFatherIn.Text}
        db.Students.InsertOnSubmit(NewStudent)
        db.SubmitChanges()
        MsgBox("Student Record Successfully addedd !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        ButtonClearPicture_Click(sender, e)

    End Sub
End Class