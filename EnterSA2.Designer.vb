<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterSA2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterSA2))
        Me.RegistrationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS = New School_Management_System.SMS()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboSubject = New System.Windows.Forms.ComboBox()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.AssessmentsTableAdapter = New School_Management_System.SMSTableAdapters.AssessmentsTableAdapter()
        Me.LabelCurrentStudent = New System.Windows.Forms.Label()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelStream = New System.Windows.Forms.Label()
        Me.TextScore = New System.Windows.Forms.TextBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ButtonLoadRecords = New System.Windows.Forms.Button()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.ComboStream = New System.Windows.Forms.ComboBox()
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrationNoDataGridViewTextBoxColumn
        '
        Me.RegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "Registration_No"
        Me.RegistrationNoDataGridViewTextBoxColumn.HeaderText = "Reg No#"
        Me.RegistrationNoDataGridViewTextBoxColumn.Name = "RegistrationNoDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'AssessmentsBindingSource1
        '
        Me.AssessmentsBindingSource1.DataMember = "Assessments"
        Me.AssessmentsBindingSource1.DataSource = Me.SMS
        '
        'SMS
        '
        Me.SMS.DataSetName = "SMS"
        Me.SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RegistrationNoDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.FA3DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AssessmentsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(28, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(643, 242)
        Me.DataGridView1.TabIndex = 64
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
        'FA3DataGridViewTextBoxColumn
        '
        Me.FA3DataGridViewTextBoxColumn.DataPropertyName = "FA3"
        Me.FA3DataGridViewTextBoxColumn.HeaderText = "FA3"
        Me.FA3DataGridViewTextBoxColumn.Name = "FA3DataGridViewTextBoxColumn"
        '
        'ComboSubject
        '
        Me.ComboSubject.DataSource = Me.AssessmentsBindingSource1
        Me.ComboSubject.DisplayMember = "Subject"
        Me.ComboSubject.FormattingEnabled = True
        Me.ComboSubject.Location = New System.Drawing.Point(28, 91)
        Me.ComboSubject.Name = "ComboSubject"
        Me.ComboSubject.Size = New System.Drawing.Size(502, 24)
        Me.ComboSubject.TabIndex = 69
        Me.ComboSubject.ValueMember = "Subject"
        '
        'ComboClass
        '
        Me.ComboClass.DataSource = Me.AssessmentsBindingSource1
        Me.ComboClass.DisplayMember = "Class"
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Location = New System.Drawing.Point(28, 32)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(243, 24)
        Me.ComboClass.TabIndex = 65
        Me.ComboClass.ValueMember = "Class"
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Location = New System.Drawing.Point(25, 12)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(42, 17)
        Me.LabelClass.TabIndex = 67
        Me.LabelClass.Text = "Class"
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'LabelCurrentStudent
        '
        Me.LabelCurrentStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCurrentStudent.Location = New System.Drawing.Point(333, 141)
        Me.LabelCurrentStudent.Name = "LabelCurrentStudent"
        Me.LabelCurrentStudent.Size = New System.Drawing.Size(337, 38)
        Me.LabelCurrentStudent.TabIndex = 74
        Me.LabelCurrentStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'LabelStream
        '
        Me.LabelStream.AutoSize = True
        Me.LabelStream.Location = New System.Drawing.Point(297, 12)
        Me.LabelStream.Name = "LabelStream"
        Me.LabelStream.Size = New System.Drawing.Size(55, 17)
        Me.LabelStream.TabIndex = 68
        Me.LabelStream.Text = "Section"
        '
        'TextScore
        '
        Me.TextScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextScore.Location = New System.Drawing.Point(28, 141)
        Me.TextScore.Name = "TextScore"
        Me.TextScore.Size = New System.Drawing.Size(155, 38)
        Me.TextScore.TabIndex = 72
        Me.TextScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(205, 141)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(107, 38)
        Me.ButtonEnter.TabIndex = 73
        Me.ButtonEnter.Text = "Enter CA"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ButtonLoadRecords
        '
        Me.ButtonLoadRecords.Location = New System.Drawing.Point(550, 32)
        Me.ButtonLoadRecords.Name = "ButtonLoadRecords"
        Me.ButtonLoadRecords.Size = New System.Drawing.Size(121, 82)
        Me.ButtonLoadRecords.TabIndex = 71
        Me.ButtonLoadRecords.Text = "Load Records"
        Me.ButtonLoadRecords.UseVisualStyleBackColor = True
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Location = New System.Drawing.Point(25, 71)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(55, 17)
        Me.LabelSubject.TabIndex = 70
        Me.LabelSubject.Text = "Subject"
        '
        'ComboStream
        '
        Me.ComboStream.DataSource = Me.AssessmentsBindingSource1
        Me.ComboStream.DisplayMember = "Stream"
        Me.ComboStream.FormattingEnabled = True
        Me.ComboStream.Location = New System.Drawing.Point(300, 32)
        Me.ComboStream.Name = "ComboStream"
        Me.ComboStream.Size = New System.Drawing.Size(230, 24)
        Me.ComboStream.TabIndex = 66
        Me.ComboStream.ValueMember = "Stream"
        '
        'EnterSA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 512)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboSubject)
        Me.Controls.Add(Me.ComboClass)
        Me.Controls.Add(Me.LabelClass)
        Me.Controls.Add(Me.LabelCurrentStudent)
        Me.Controls.Add(Me.LabelStream)
        Me.Controls.Add(Me.TextScore)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.ButtonLoadRecords)
        Me.Controls.Add(Me.LabelSubject)
        Me.Controls.Add(Me.ComboStream)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnterSA2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter SA 2"
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssessmentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SMS As School_Management_System.SMS
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents LabelClass As System.Windows.Forms.Label
    Friend WithEvents AssessmentsTableAdapter As School_Management_System.SMSTableAdapters.AssessmentsTableAdapter
    Friend WithEvents LabelCurrentStudent As System.Windows.Forms.Label
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelStream As System.Windows.Forms.Label
    Friend WithEvents TextScore As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadRecords As System.Windows.Forms.Button
    Friend WithEvents LabelSubject As System.Windows.Forms.Label
    Friend WithEvents ComboStream As System.Windows.Forms.ComboBox
End Class
