Public Class ManageTeachers

    Private Sub ManageTeachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TeachersTableAdapter.Fill(Me.SMS.Teachers)

    End Sub

    Private Sub TextSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextSearch.KeyUp
        Me.TeachersTableAdapter.FillBySearchString(Me.SMS.Teachers, TextSearch.Text & "%", TextSearch.Text)
    End Sub


    Private Sub ButtonNewTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewTeacher.Click
        AddTeachers.ShowDialog()
        ManageTeachers_Load(sender, e)
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        ManageTeachers_Load(sender, e)
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            Dim db As New SMSDataContext
            Dim SelectedTeacher = From p In db.Teachers
                                  Where p.id = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                  Select p

            db.Teachers.DeleteOnSubmit(SelectedTeacher.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Selected Record is successfully Deleted !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageTeachers_Load(sender, e)

        Catch ex As Exception
            MsgBox("Select a teacher's record from the list first ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class