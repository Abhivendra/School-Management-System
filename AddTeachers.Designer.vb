<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeachers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTeachers))
        Me.TextStaffID = New System.Windows.Forms.TextBox()
        Me.TextFullName = New System.Windows.Forms.TextBox()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.ComboAge = New System.Windows.Forms.ComboBox()
        Me.ComboDesigngnation = New System.Windows.Forms.ComboBox()
        Me.PictureTeacher = New System.Windows.Forms.PictureBox()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextContactNo = New System.Windows.Forms.TextBox()
        Me.TextEmailID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextStaffID
        '
        Me.TextStaffID.Location = New System.Drawing.Point(281, 45)
        Me.TextStaffID.Name = "TextStaffID"
        Me.TextStaffID.Size = New System.Drawing.Size(237, 22)
        Me.TextStaffID.TabIndex = 0
        '
        'TextFullName
        '
        Me.TextFullName.Location = New System.Drawing.Point(281, 90)
        Me.TextFullName.Name = "TextFullName"
        Me.TextFullName.Size = New System.Drawing.Size(237, 22)
        Me.TextFullName.TabIndex = 1
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Location = New System.Drawing.Point(281, 143)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(142, 24)
        Me.ComboGender.TabIndex = 4
        '
        'ComboAge
        '
        Me.ComboAge.FormattingEnabled = True
        Me.ComboAge.Location = New System.Drawing.Point(281, 192)
        Me.ComboAge.Name = "ComboAge"
        Me.ComboAge.Size = New System.Drawing.Size(142, 24)
        Me.ComboAge.TabIndex = 5
        '
        'ComboDesigngnation
        '
        Me.ComboDesigngnation.FormattingEnabled = True
        Me.ComboDesigngnation.Location = New System.Drawing.Point(281, 241)
        Me.ComboDesigngnation.Name = "ComboDesigngnation"
        Me.ComboDesigngnation.Size = New System.Drawing.Size(237, 24)
        Me.ComboDesigngnation.TabIndex = 6
        '
        'PictureTeacher
        '
        Me.PictureTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureTeacher.Location = New System.Drawing.Point(560, 45)
        Me.PictureTeacher.Name = "PictureTeacher"
        Me.PictureTeacher.Size = New System.Drawing.Size(141, 157)
        Me.PictureTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureTeacher.TabIndex = 7
        Me.PictureTeacher.TabStop = False
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(560, 220)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(104, 45)
        Me.ButtonLoad.TabIndex = 8
        Me.ButtonLoad.Text = "Load Image"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(670, 220)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(31, 45)
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "X"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'TextAddress
        '
        Me.TextAddress.Location = New System.Drawing.Point(281, 295)
        Me.TextAddress.Multiline = True
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextAddress.Size = New System.Drawing.Size(420, 72)
        Me.TextAddress.TabIndex = 10
        '
        'TextContactNo
        '
        Me.TextContactNo.Location = New System.Drawing.Point(281, 390)
        Me.TextContactNo.Name = "TextContactNo"
        Me.TextContactNo.Size = New System.Drawing.Size(237, 22)
        Me.TextContactNo.TabIndex = 11
        '
        'TextEmailID
        '
        Me.TextEmailID.Location = New System.Drawing.Point(281, 431)
        Me.TextEmailID.Name = "TextEmailID"
        Me.TextEmailID.Size = New System.Drawing.Size(420, 22)
        Me.TextEmailID.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Desingnation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Contact Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Email Address"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(281, 473)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(237, 42)
        Me.ButtonSave.TabIndex = 21
        Me.ButtonSave.Text = "Save Details"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddTeachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 538)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEmailID)
        Me.Controls.Add(Me.TextContactNo)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.PictureTeacher)
        Me.Controls.Add(Me.ComboDesigngnation)
        Me.Controls.Add(Me.ComboAge)
        Me.Controls.Add(Me.ComboGender)
        Me.Controls.Add(Me.TextFullName)
        Me.Controls.Add(Me.TextStaffID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddTeachers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Teacher"
        CType(Me.PictureTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextStaffID As System.Windows.Forms.TextBox
    Friend WithEvents TextFullName As System.Windows.Forms.TextBox
    Friend WithEvents ComboGender As System.Windows.Forms.ComboBox
    Friend WithEvents ComboAge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboDesigngnation As System.Windows.Forms.ComboBox
    Friend WithEvents PictureTeacher As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextContactNo As System.Windows.Forms.TextBox
    Friend WithEvents TextEmailID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
