Public Class PrintReportCard

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click

        If TextRegistrationNo.Text = "" Then
            MsgBox("Fill Registration Number to proceed !!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.AssessmentsTableAdapter.Fill(Me.SMS.Assessments)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PrintReportCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Assessments' table. You can move, or remove it, as needed.
        Me.AssessmentsTableAdapter.Fill(Me.SMS.Assessments)

    End Sub
End Class