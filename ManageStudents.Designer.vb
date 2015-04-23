<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudents
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudents))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RessedentialAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermanentAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherOccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherOccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS = New School_Management_System.SMS()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.StudentsTableAdapter = New School_Management_System.SMSTableAdapters.StudentsTableAdapter()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.RegistrationNoDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.RessedentialAddressDataGridViewTextBoxColumn, Me.PermanentAddressDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn, Me.RegistrationDateDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.MotherOccDataGridViewTextBoxColumn, Me.MotherContactDataGridViewTextBoxColumn, Me.MotherSalaryDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.FatherOccDataGridViewTextBoxColumn, Me.FatherContactDataGridViewTextBoxColumn, Me.FatherSalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(46, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(938, 326)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Visible = False
        '
        'RegistrationNoDataGridViewTextBoxColumn
        '
        Me.RegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "Registration No"
        Me.RegistrationNoDataGridViewTextBoxColumn.HeaderText = "Registration No"
        Me.RegistrationNoDataGridViewTextBoxColumn.Name = "RegistrationNoDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'RessedentialAddressDataGridViewTextBoxColumn
        '
        Me.RessedentialAddressDataGridViewTextBoxColumn.DataPropertyName = "Ressedential Address"
        Me.RessedentialAddressDataGridViewTextBoxColumn.HeaderText = "Ress. Address"
        Me.RessedentialAddressDataGridViewTextBoxColumn.Name = "RessedentialAddressDataGridViewTextBoxColumn"
        '
        'PermanentAddressDataGridViewTextBoxColumn
        '
        Me.PermanentAddressDataGridViewTextBoxColumn.DataPropertyName = "Permanent Address"
        Me.PermanentAddressDataGridViewTextBoxColumn.HeaderText = "Per. Address"
        Me.PermanentAddressDataGridViewTextBoxColumn.Name = "PermanentAddressDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact No"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "Contact No"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "Email ID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "Email ID"
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'StreamDataGridViewTextBoxColumn
        '
        Me.StreamDataGridViewTextBoxColumn.DataPropertyName = "Stream"
        Me.StreamDataGridViewTextBoxColumn.HeaderText = "Stream"
        Me.StreamDataGridViewTextBoxColumn.Name = "StreamDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewTextBoxColumn
        '
        Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
        '
        'RegistrationDateDataGridViewTextBoxColumn
        '
        Me.RegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration Date"
        Me.RegistrationDateDataGridViewTextBoxColumn.HeaderText = "Registration Date"
        Me.RegistrationDateDataGridViewTextBoxColumn.Name = "RegistrationDateDataGridViewTextBoxColumn"
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood Group"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group"
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "Mother name"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "Mother's Name"
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        '
        'MotherOccDataGridViewTextBoxColumn
        '
        Me.MotherOccDataGridViewTextBoxColumn.DataPropertyName = "mother occ"
        Me.MotherOccDataGridViewTextBoxColumn.HeaderText = "Mother's Occ."
        Me.MotherOccDataGridViewTextBoxColumn.Name = "MotherOccDataGridViewTextBoxColumn"
        '
        'MotherContactDataGridViewTextBoxColumn
        '
        Me.MotherContactDataGridViewTextBoxColumn.DataPropertyName = "mother contact"
        Me.MotherContactDataGridViewTextBoxColumn.HeaderText = "Mother's Contact No."
        Me.MotherContactDataGridViewTextBoxColumn.Name = "MotherContactDataGridViewTextBoxColumn"
        '
        'MotherSalaryDataGridViewTextBoxColumn
        '
        Me.MotherSalaryDataGridViewTextBoxColumn.DataPropertyName = "mother salary"
        Me.MotherSalaryDataGridViewTextBoxColumn.HeaderText = "Mother Annual Salary"
        Me.MotherSalaryDataGridViewTextBoxColumn.Name = "MotherSalaryDataGridViewTextBoxColumn"
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "father name"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "Father's Name"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        '
        'FatherOccDataGridViewTextBoxColumn
        '
        Me.FatherOccDataGridViewTextBoxColumn.DataPropertyName = "father occ"
        Me.FatherOccDataGridViewTextBoxColumn.HeaderText = "Father Occ."
        Me.FatherOccDataGridViewTextBoxColumn.Name = "FatherOccDataGridViewTextBoxColumn"
        '
        'FatherContactDataGridViewTextBoxColumn
        '
        Me.FatherContactDataGridViewTextBoxColumn.DataPropertyName = "father contact"
        Me.FatherContactDataGridViewTextBoxColumn.HeaderText = "Father's Contact No."
        Me.FatherContactDataGridViewTextBoxColumn.Name = "FatherContactDataGridViewTextBoxColumn"
        '
        'FatherSalaryDataGridViewTextBoxColumn
        '
        Me.FatherSalaryDataGridViewTextBoxColumn.DataPropertyName = "father salary"
        Me.FatherSalaryDataGridViewTextBoxColumn.HeaderText = "Father Annual Salary"
        Me.FatherSalaryDataGridViewTextBoxColumn.Name = "FatherSalaryDataGridViewTextBoxColumn"
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.SMS
        '
        'SMS
        '
        Me.SMS.DataSetName = "SMS"
        Me.SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextSearch
        '
        Me.TextSearch.Location = New System.Drawing.Point(46, 38)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(938, 22)
        Me.TextSearch.TabIndex = 1
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(527, 433)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(219, 65)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "Delete Selected Record(s)"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(42, 432)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(239, 65)
        Me.ButtonNew.TabIndex = 5
        Me.ButtonNew.Text = "Add New Student(s)"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(287, 433)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(234, 65)
        Me.ButtonRefresh.TabIndex = 6
        Me.ButtonRefresh.Text = "Refresh List"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(752, 432)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(228, 65)
        Me.ButtonPrint.TabIndex = 7
        Me.ButtonPrint.Text = "Print List"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 510)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Students"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextSearch As System.Windows.Forms.TextBox
    Friend WithEvents SMS As School_Management_System.SMS
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As School_Management_System.SMSTableAdapters.StudentsTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RessedentialAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermanentAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherOccDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherSalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherOccDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherSalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
End Class
