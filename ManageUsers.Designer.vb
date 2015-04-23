<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsers))
        Me.ListExistingUsers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextFullName = New System.Windows.Forms.TextBox()
        Me.ButtonAddUser = New System.Windows.Forms.Button()
        Me.ButtonLoadPicture = New System.Windows.Forms.Button()
        Me.PictureUser = New System.Windows.Forms.PictureBox()
        Me.ComboAccessLevel = New System.Windows.Forms.ComboBox()
        Me.TextRePassword = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextUserName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListExistingUsers
        '
        Me.ListExistingUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListExistingUsers.FormattingEnabled = True
        Me.ListExistingUsers.ItemHeight = 31
        Me.ListExistingUsers.Location = New System.Drawing.Point(28, 55)
        Me.ListExistingUsers.Name = "ListExistingUsers"
        Me.ListExistingUsers.Size = New System.Drawing.Size(236, 283)
        Me.ListExistingUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Existing Users"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(28, 361)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(236, 64)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove Selected User"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextFullName)
        Me.GroupBox1.Controls.Add(Me.ButtonAddUser)
        Me.GroupBox1.Controls.Add(Me.ButtonLoadPicture)
        Me.GroupBox1.Controls.Add(Me.PictureUser)
        Me.GroupBox1.Controls.Add(Me.ComboAccessLevel)
        Me.GroupBox1.Controls.Add(Me.TextRePassword)
        Me.GroupBox1.Controls.Add(Me.TextPassword)
        Me.GroupBox1.Controls.Add(Me.TextUserName)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 370)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a New User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Access Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Name"
        '
        'TextFullName
        '
        Me.TextFullName.Location = New System.Drawing.Point(183, 133)
        Me.TextFullName.Name = "TextFullName"
        Me.TextFullName.Size = New System.Drawing.Size(189, 22)
        Me.TextFullName.TabIndex = 8
        '
        'ButtonAddUser
        '
        Me.ButtonAddUser.Location = New System.Drawing.Point(183, 321)
        Me.ButtonAddUser.Name = "ButtonAddUser"
        Me.ButtonAddUser.Size = New System.Drawing.Size(189, 48)
        Me.ButtonAddUser.TabIndex = 7
        Me.ButtonAddUser.Text = "Save New User Details"
        Me.ButtonAddUser.UseVisualStyleBackColor = True
        '
        'ButtonLoadPicture
        '
        Me.ButtonLoadPicture.Location = New System.Drawing.Point(293, 201)
        Me.ButtonLoadPicture.Name = "ButtonLoadPicture"
        Me.ButtonLoadPicture.Size = New System.Drawing.Size(79, 101)
        Me.ButtonLoadPicture.TabIndex = 6
        Me.ButtonLoadPicture.Text = "Load Picture"
        Me.ButtonLoadPicture.UseVisualStyleBackColor = True
        '
        'PictureUser
        '
        Me.PictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureUser.Location = New System.Drawing.Point(183, 201)
        Me.PictureUser.Name = "PictureUser"
        Me.PictureUser.Size = New System.Drawing.Size(94, 101)
        Me.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureUser.TabIndex = 5
        Me.PictureUser.TabStop = False
        '
        'ComboAccessLevel
        '
        Me.ComboAccessLevel.FormattingEnabled = True
        Me.ComboAccessLevel.Location = New System.Drawing.Point(183, 171)
        Me.ComboAccessLevel.Name = "ComboAccessLevel"
        Me.ComboAccessLevel.Size = New System.Drawing.Size(189, 24)
        Me.ComboAccessLevel.TabIndex = 4
        '
        'TextRePassword
        '
        Me.TextRePassword.Location = New System.Drawing.Point(183, 94)
        Me.TextRePassword.Name = "TextRePassword"
        Me.TextRePassword.Size = New System.Drawing.Size(189, 22)
        Me.TextRePassword.TabIndex = 2
        Me.TextRePassword.UseSystemPasswordChar = True
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(183, 57)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(189, 22)
        Me.TextPassword.TabIndex = 1
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'TextUserName
        '
        Me.TextUserName.Location = New System.Drawing.Point(183, 20)
        Me.TextUserName.Name = "TextUserName"
        Me.TextUserName.Size = New System.Drawing.Size(189, 22)
        Me.TextUserName.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListExistingUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListExistingUsers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextRePassword As System.Windows.Forms.TextBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextFullName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAddUser As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadPicture As System.Windows.Forms.Button
    Friend WithEvents PictureUser As System.Windows.Forms.PictureBox
    Friend WithEvents ComboAccessLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
