Public Class ManageStudents

    Private Sub ManageStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StudentsTableAdapter.Fill(Me.SMS.Students)

    End Sub

    Private Sub TextSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextSearch.KeyUp
        If TextSearch.Text = "" Then
            ManageStudents_Load(sender, e)
        Else
            Me.StudentsTableAdapter.FillByFullname(Me.SMS.Students, TextSearch.Text & "%")
        End If
    End Sub

    Private Sub ButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        AddStudent.Show()
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            Dim db As New SMSDataContext
            Dim SelectedStudent = From p In db.Students
                                  Where p.StudentID = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                  Select p
            db.Students.DeleteOnSubmit(SelectedStudent.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Student record Successfully Deleted !!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageStudents_Load(sender, e)
        Catch ex As Exception
            MsgBox("Please Select a record first !! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        End Try
    End Sub
End Class