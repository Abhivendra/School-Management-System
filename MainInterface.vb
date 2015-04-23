Imports System.Windows.Forms

Public Class MainInterface

    Private Sub MainInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        SMS_About.ShowDialog()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        User_Login.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AddStudent.Show()
        AddStudent.MdiParent = Me
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ManageStudents.Show()
        ManageStudents.MdiParent = Me
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ManageTeachers.Show()
        ManageTeachers.MdiParent = Me
    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        AddTeachers.Show()
        AddTeachers.MdiParent = Me
    End Sub

    Private Sub FA1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FA1ToolStripMenuItem1.Click
        EnterFA1.Show()
        EnterFA1.MdiParent = Me
    End Sub

    Private Sub FA2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FA2ToolStripMenuItem1.Click
        EnterFA2.Show()
        EnterFA2.MdiParent = Me
    End Sub

    Private Sub SA1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SA1ToolStripMenuItem.Click
        EnterSA1.Show()
        EnterSA1.MdiParent = Me
    End Sub

    Private Sub FA1ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FA1ToolStripMenuItem2.Click
        EnterFA3.Show()
        EnterFA3.MdiParent = Me
    End Sub

    Private Sub FA4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FA4ToolStripMenuItem.Click
        EnterFA4.Show()
        EnterFA4.MdiParent = Me
    End Sub

    Private Sub SA2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SA2ToolStripMenuItem.Click
        EnterSA2.Show()
        EnterSA2.MdiParent = Me
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        PrintResults.Show()
        PrintResults.MdiParent = Me
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        PrintReportCard.Show()
        PrintReportCard.MdiParent = Me
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        ManageUsers.Show()
        ManageUsers.MdiParent = Me
    End Sub

    Private Sub ComputeResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeResultToolStripMenuItem.Click
        ComputeResult.Show()
        ComputeResult.MdiParent = Me
    End Sub
End Class
