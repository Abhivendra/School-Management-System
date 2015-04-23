Public Class ComputeResult



    Private Sub ButtonComputeResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComputeResults.Click
        If ComboClass.Text = "" Or ComboStream.Text = "" Then
            MsgBox("Select a class and stream to proceed !!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                                Where p.Class = ComboClass.Text And p.Stream = ComboStream.Text
                                Select p

        If AssessmentRecords.Count = 0 Then
            MsgBox("No record found !! Please select a new set of options to proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        For j = 1 To AssessmentRecords.Count
            AssessmentRecords.ToList(j - 1).Total1 = Val(AssessmentRecords.ToList(j - 1).FA1) + Val(AssessmentRecords.ToList(j - 1).FA2) + Val(AssessmentRecords.ToList(j - 1).SA1)
            AssessmentRecords.ToList(j - 1).Total2 = Val(AssessmentRecords.ToList(j - 1).FA3) + Val(AssessmentRecords.ToList(j - 1).FA4) + Val(AssessmentRecords.ToList(j - 1).SA2)
            AssessmentRecords.ToList(j - 1).TotalFA = Val(AssessmentRecords.ToList(j - 1).FA1) + Val(AssessmentRecords.ToList(j - 1).FA2) + Val(AssessmentRecords.ToList(j - 1).FA3) + Val(AssessmentRecords.ToList(j - 1).FA4)
            AssessmentRecords.ToList(j - 1).TotalSA = Val(AssessmentRecords.ToList(j - 1).SA1) + Val(AssessmentRecords.ToList(j - 1).SA2)
            AssessmentRecords.ToList(j - 1).Total = Val(AssessmentRecords.ToList(j - 1).TotalFA) + Val(AssessmentRecords.ToList(j - 1).TotalSA)

            If AssessmentRecords.ToList(j - 1).Total > 90 Then
                AssessmentRecords.ToList(j - 1).GPA = 10.0
                AssessmentRecords.ToList(j - 1).Grade = "A1"
                AssessmentRecords.ToList(j - 1).Remark = "Out Standing!"

            ElseIf AssessmentRecords.ToList(j - 1).Total > 80 Then
                AssessmentRecords.ToList(j - 1).Grade = "A2"
                AssessmentRecords.ToList(j - 1).Remark = "Exclent!"
                AssessmentRecords.ToList(j - 1).GPA = 9.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 70 Then
                AssessmentRecords.ToList(j - 1).Grade = "B1"
                AssessmentRecords.ToList(j - 1).Remark = "Good!"
                AssessmentRecords.ToList(j - 1).GPA = 8.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 60 Then
                AssessmentRecords.ToList(j - 1).Grade = "B2"
                AssessmentRecords.ToList(j - 1).Remark = "Fair!"
                AssessmentRecords.ToList(j - 1).GPA = 7.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 50 Then
                AssessmentRecords.ToList(j - 1).Grade = "C1"
                AssessmentRecords.ToList(j - 1).Remark = "Average!"
                AssessmentRecords.ToList(j - 1).GPA = 6.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 40 Then
                AssessmentRecords.ToList(j - 1).Grade = "C2"
                AssessmentRecords.ToList(j - 1).Remark = "Below Average!"
                AssessmentRecords.ToList(j - 1).GPA = 5.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 33 Then
                AssessmentRecords.ToList(j - 1).Grade = "D"
                AssessmentRecords.ToList(j - 1).Remark = "Poor!"
                AssessmentRecords.ToList(j - 1).GPA = 4.0

            ElseIf AssessmentRecords.ToList(j - 1).Total > 21 Then
                AssessmentRecords.ToList(j - 1).Grade = "E1"
                AssessmentRecords.ToList(j - 1).Remark = "Poor!"
                AssessmentRecords.ToList(j - 1).GPA = 3.0

            Else
                AssessmentRecords.ToList(j - 1).Grade = "E2"
                AssessmentRecords.ToList(j - 1).Remark = "Very Poor!"
                AssessmentRecords.ToList(j - 1).GPA = 2.0
            End If
        Next
        db.SubmitChanges()

        Dim Totaledrecords = From p In db.Assessments
                                Where p.Class = ComboClass.Text And p.Stream = ComboStream.Text
                                Select p
                                Order By p.Total Descending

        For j = 1 To Totaledrecords.Count
            Totaledrecords.ToList(j - 1).Position = j
        Next
        db.SubmitChanges()
        Me.AssessmentsTableAdapter.FillByclassstream(Me.SMS.Assessments, ComboClass.Text, ComboStream.Text)
    End Sub




    Private Sub ComputeResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Assessments' table. You can move, or remove it, as needed.
        Me.AssessmentsTableAdapter.Fill(Me.SMS.Assessments)

    End Sub
End Class