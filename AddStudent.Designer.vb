<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.TextRegNo = New System.Windows.Forms.TextBox()
        Me.TextFullName = New System.Windows.Forms.TextBox()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.NudAge = New System.Windows.Forms.NumericUpDown()
        Me.TextRegAdr = New System.Windows.Forms.TextBox()
        Me.TextContactNo = New System.Windows.Forms.TextBox()
        Me.TextEmailId = New System.Windows.Forms.TextBox()
        Me.TextPerAdr = New System.Windows.Forms.TextBox()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.ComboStream = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextMotherName = New System.Windows.Forms.TextBox()
        Me.TextFatherNme = New System.Windows.Forms.TextBox()
        Me.TextMotherOcc = New System.Windows.Forms.TextBox()
        Me.TextMotherCo = New System.Windows.Forms.TextBox()
        Me.TextFathrOcc = New System.Windows.Forms.TextBox()
        Me.TextFatherCo = New System.Windows.Forms.TextBox()
        Me.TextMotherIn = New System.Windows.Forms.TextBox()
        Me.TextFatherIn = New System.Windows.Forms.TextBox()
        Me.ButtonLoadPicture = New System.Windows.Forms.Button()
        Me.ButtonClearPicture = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.NudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextRegNo
        '
        Me.TextRegNo.Location = New System.Drawing.Point(43, 30)
        Me.TextRegNo.Name = "TextRegNo"
        Me.TextRegNo.Size = New System.Drawing.Size(255, 22)
        Me.TextRegNo.TabIndex = 0
        '
        'TextFullName
        '
        Me.TextFullName.Location = New System.Drawing.Point(362, 30)
        Me.TextFullName.Name = "TextFullName"
        Me.TextFullName.Size = New System.Drawing.Size(579, 22)
        Me.TextFullName.TabIndex = 1
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Location = New System.Drawing.Point(43, 79)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(121, 24)
        Me.ComboGender.TabIndex = 2
        '
        'NudAge
        '
        Me.NudAge.Location = New System.Drawing.Point(190, 79)
        Me.NudAge.Name = "NudAge"
        Me.NudAge.Size = New System.Drawing.Size(108, 22)
        Me.NudAge.TabIndex = 3
        '
        'TextRegAdr
        '
        Me.TextRegAdr.Location = New System.Drawing.Point(362, 88)
        Me.TextRegAdr.Multiline = True
        Me.TextRegAdr.Name = "TextRegAdr"
        Me.TextRegAdr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextRegAdr.Size = New System.Drawing.Size(579, 61)
        Me.TextRegAdr.TabIndex = 5
        '
        'TextContactNo
        '
        Me.TextContactNo.Location = New System.Drawing.Point(43, 242)
        Me.TextContactNo.Name = "TextContactNo"
        Me.TextContactNo.Size = New System.Drawing.Size(255, 22)
        Me.TextContactNo.TabIndex = 6
        '
        'TextEmailId
        '
        Me.TextEmailId.Location = New System.Drawing.Point(362, 288)
        Me.TextEmailId.Name = "TextEmailId"
        Me.TextEmailId.Size = New System.Drawing.Size(579, 22)
        Me.TextEmailId.TabIndex = 7
        '
        'TextPerAdr
        '
        Me.TextPerAdr.Location = New System.Drawing.Point(362, 190)
        Me.TextPerAdr.Multiline = True
        Me.TextPerAdr.Name = "TextPerAdr"
        Me.TextPerAdr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextPerAdr.Size = New System.Drawing.Size(579, 61)
        Me.TextPerAdr.TabIndex = 8
        '
        'ComboClass
        '
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Location = New System.Drawing.Point(43, 136)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(255, 24)
        Me.ComboClass.TabIndex = 9
        '
        'ComboStream
        '
        Me.ComboStream.FormattingEnabled = True
        Me.ComboStream.Location = New System.Drawing.Point(43, 190)
        Me.ComboStream.Name = "ComboStream"
        Me.ComboStream.Size = New System.Drawing.Size(255, 24)
        Me.ComboStream.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(43, 288)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextMotherName
        '
        Me.TextMotherName.Location = New System.Drawing.Point(362, 354)
        Me.TextMotherName.Name = "TextMotherName"
        Me.TextMotherName.Size = New System.Drawing.Size(579, 22)
        Me.TextMotherName.TabIndex = 12
        '
        'TextFatherNme
        '
        Me.TextFatherNme.Location = New System.Drawing.Point(362, 463)
        Me.TextFatherNme.Name = "TextFatherNme"
        Me.TextFatherNme.Size = New System.Drawing.Size(579, 22)
        Me.TextFatherNme.TabIndex = 13
        '
        'TextMotherOcc
        '
        Me.TextMotherOcc.Location = New System.Drawing.Point(362, 410)
        Me.TextMotherOcc.Name = "TextMotherOcc"
        Me.TextMotherOcc.Size = New System.Drawing.Size(255, 22)
        Me.TextMotherOcc.TabIndex = 14
        '
        'TextMotherCo
        '
        Me.TextMotherCo.Location = New System.Drawing.Point(686, 410)
        Me.TextMotherCo.Name = "TextMotherCo"
        Me.TextMotherCo.Size = New System.Drawing.Size(255, 22)
        Me.TextMotherCo.TabIndex = 15
        '
        'TextFathrOcc
        '
        Me.TextFathrOcc.Location = New System.Drawing.Point(362, 517)
        Me.TextFathrOcc.Name = "TextFathrOcc"
        Me.TextFathrOcc.Size = New System.Drawing.Size(255, 22)
        Me.TextFathrOcc.TabIndex = 16
        '
        'TextFatherCo
        '
        Me.TextFatherCo.Location = New System.Drawing.Point(686, 517)
        Me.TextFatherCo.Name = "TextFatherCo"
        Me.TextFatherCo.Size = New System.Drawing.Size(255, 22)
        Me.TextFatherCo.TabIndex = 17
        '
        'TextMotherIn
        '
        Me.TextMotherIn.Location = New System.Drawing.Point(362, 573)
        Me.TextMotherIn.Name = "TextMotherIn"
        Me.TextMotherIn.Size = New System.Drawing.Size(255, 22)
        Me.TextMotherIn.TabIndex = 18
        '
        'TextFatherIn
        '
        Me.TextFatherIn.Location = New System.Drawing.Point(686, 573)
        Me.TextFatherIn.Name = "TextFatherIn"
        Me.TextFatherIn.Size = New System.Drawing.Size(255, 22)
        Me.TextFatherIn.TabIndex = 19
        '
        'ButtonLoadPicture
        '
        Me.ButtonLoadPicture.Location = New System.Drawing.Point(215, 288)
        Me.ButtonLoadPicture.Name = "ButtonLoadPicture"
        Me.ButtonLoadPicture.Size = New System.Drawing.Size(83, 46)
        Me.ButtonLoadPicture.TabIndex = 20
        Me.ButtonLoadPicture.Text = "Load"
        Me.ButtonLoadPicture.UseVisualStyleBackColor = True
        '
        'ButtonClearPicture
        '
        Me.ButtonClearPicture.Location = New System.Drawing.Point(215, 344)
        Me.ButtonClearPicture.Name = "ButtonClearPicture"
        Me.ButtonClearPicture.Size = New System.Drawing.Size(83, 75)
        Me.ButtonClearPicture.TabIndex = 21
        Me.ButtonClearPicture.Text = "Clear"
        Me.ButtonClearPicture.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(43, 447)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(255, 55)
        Me.ButtonReset.TabIndex = 22
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(43, 522)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(255, 73)
        Me.ButtonSave.TabIndex = 23
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Registration Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Residential Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Permanent Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Class"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Contact Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(359, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Email Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Picture"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(359, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Mother's Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(359, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Mother's Occupation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(683, 390)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Mother's Contact Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(359, 443)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 17)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Father's Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(359, 497)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 17)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Father's Occupation"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(683, 497)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 17)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Father's Contact Number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(359, 553)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(159, 17)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Mother's Annual Income"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(683, 553)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(156, 17)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Father's Annual Income"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(953, 619)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonClearPicture)
        Me.Controls.Add(Me.ButtonLoadPicture)
        Me.Controls.Add(Me.TextFatherIn)
        Me.Controls.Add(Me.TextMotherIn)
        Me.Controls.Add(Me.TextFatherCo)
        Me.Controls.Add(Me.TextFathrOcc)
        Me.Controls.Add(Me.TextMotherCo)
        Me.Controls.Add(Me.TextMotherOcc)
        Me.Controls.Add(Me.TextFatherNme)
        Me.Controls.Add(Me.TextMotherName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboStream)
        Me.Controls.Add(Me.ComboClass)
        Me.Controls.Add(Me.TextPerAdr)
        Me.Controls.Add(Me.TextEmailId)
        Me.Controls.Add(Me.TextContactNo)
        Me.Controls.Add(Me.TextRegAdr)
        Me.Controls.Add(Me.NudAge)
        Me.Controls.Add(Me.ComboGender)
        Me.Controls.Add(Me.TextFullName)
        Me.Controls.Add(Me.TextRegNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Student"
        CType(Me.NudAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextRegNo As System.Windows.Forms.TextBox
    Friend WithEvents TextFullName As System.Windows.Forms.TextBox
    Friend WithEvents ComboGender As System.Windows.Forms.ComboBox
    Friend WithEvents NudAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextRegAdr As System.Windows.Forms.TextBox
    Friend WithEvents TextContactNo As System.Windows.Forms.TextBox
    Friend WithEvents TextEmailId As System.Windows.Forms.TextBox
    Friend WithEvents TextPerAdr As System.Windows.Forms.TextBox
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents ComboStream As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextMotherName As System.Windows.Forms.TextBox
    Friend WithEvents TextFatherNme As System.Windows.Forms.TextBox
    Friend WithEvents TextMotherOcc As System.Windows.Forms.TextBox
    Friend WithEvents TextMotherCo As System.Windows.Forms.TextBox
    Friend WithEvents TextFathrOcc As System.Windows.Forms.TextBox
    Friend WithEvents TextFatherCo As System.Windows.Forms.TextBox
    Friend WithEvents TextMotherIn As System.Windows.Forms.TextBox
    Friend WithEvents TextFatherIn As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLoadPicture As System.Windows.Forms.Button
    Friend WithEvents ButtonClearPicture As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
