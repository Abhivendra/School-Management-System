Public Class PrintResults

    Private Sub ButtonComputeResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComputeResults.Click
        If ComboClass.Text = "" Or ComboStream.Text = "" Or ComboSubject.Text = "" Then
            MsgBox("Select all options to proceed !!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.AssessmentsTableAdapter.FillByclassstreamsubject(Me.SMS.Assessments, ComboClass.Text, ComboStream.Text, ComboSubject.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class