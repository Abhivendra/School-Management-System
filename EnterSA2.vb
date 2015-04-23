Public Class EnterSA2

    Private Sub ButtonLoadRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadRecords.Click
        If ComboClass.Text = "" Or ComboStream.Text = "" Or ComboSubject.Text = "" Then
            MsgBox("Please select a class , subject and stream to proceed !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                               Where p.Class = ComboClass.Text And p.Stream = ComboStream.Text And p.Subject = ComboSubject.Text
                               Select p


        If AssessmentRecords.Count <> 0 Then
            Me.AssessmentsTableAdapter.FillByclassstreamsubject(Me.SMS.Assessments, ComboClass.Text, ComboStream.Text, ComboSubject.Text)
        Else
            Dim StudentsRecord = From p In db.Students
                                 Where p.Class = ComboClass.Text And p.Stream = ComboStream.Text
                                 Select p

            If StudentsRecord.Count = 0 Then
                MsgBox("No Student in the system matches your criteria !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            Else
                For j = 1 To StudentsRecord.Count
                    Dim NewAssessmentRecord As New Assessment With {.SA2 = 0, .Class = ComboClass.Text, .Total2 = 0, .Full_Name = StudentsRecord.ToList(j - 1).Full_Name, .Registration_No = StudentsRecord.ToList(j - 1).Registration_No, .Stream = ComboStream.Text, .Subject = ComboSubject.Text}
                    db.Assessments.InsertOnSubmit(NewAssessmentRecord)
                    RecordPosition = 0
                    db.SubmitChanges()
                Next
                Me.AssessmentsTableAdapter.FillByclassstreamsubject(Me.SMS.Assessments, ComboClass.Text, ComboStream.Text, ComboSubject.Text)
                LabelCurrentStudent.Text = AssessmentRecords.FirstOrDefault.Full_Name
                TextScore.Focus()
            End If
        End If
    End Sub
    Dim RecordPosition As Integer

    Private Sub ButtonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnter.Click
        If TextScore.Text = "" Then
            MsgBox("Continuous Assessment Score Can't be empty !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Not IsNumeric(TextScore.Text) Then
            MsgBox("Score Must Be Numeric!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim AssessmentRecord = From p In db.Assessments
                               Where p.Class = ComboClass.Text And p.Stream = ComboStream.Text And p.Subject = ComboSubject.Text
                               Select p

        If RecordPosition > (AssessmentRecord.Count - 1) Then
            MsgBox("End of records reached !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        AssessmentRecord.ToList(RecordPosition).SA2 = Val(TextScore.Text)
        db.SubmitChanges()
        RecordPosition += 1
        If RecordPosition = (AssessmentRecord.Count) Then
            MsgBox("End of Record Reached!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        TextScore.Clear()
        TextScore.Focus()

    End Sub
End Class