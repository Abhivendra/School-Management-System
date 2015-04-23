<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterFA1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterFA1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS = New School_Management_System.SMS()
        Me.LabelStream = New System.Windows.Forms.Label()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.ComboStream = New System.Windows.Forms.ComboBox()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.ComboSubject = New System.Windows.Forms.ComboBox()
        Me.ButtonLoadRecords = New System.Windows.Forms.Button()
        Me.TextScore = New System.Windows.Forms.TextBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelCurrentStudent = New System.Windows.Forms.Label()
        Me.AssessmentsTableAdapter = New School_Management_System.SMSTableAdapters.AssessmentsTableAdapter()
        Me.SMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.FA1DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AssessmentsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(39, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(643, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registration_No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reg. No#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Full_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'FA1DataGridViewTextBoxColumn
        '
        Me.FA1DataGridViewTextBoxColumn.DataPropertyName = "FA1"
        Me.FA1DataGridViewTextBoxColumn.HeaderText = "FA1"
        Me.FA1DataGridViewTextBoxColumn.Name = "FA1DataGridViewTextBoxColumn"
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
        'LabelStream
        '
        Me.LabelStream.AutoSize = True
        Me.LabelStream.Location = New System.Drawing.Point(308, 25)
        Me.LabelStream.Name = "LabelStream"
        Me.LabelStream.Size = New System.Drawing.Size(55, 17)
        Me.LabelStream.TabIndex = 35
        Me.LabelStream.Text = "Section"
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Location = New System.Drawing.Point(36, 25)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(42, 17)
        Me.LabelClass.TabIndex = 34
        Me.LabelClass.Text = "Class"
        '
        'ComboStream
        '
        Me.ComboStream.DataSource = Me.AssessmentsBindingSource1
        Me.ComboStream.DisplayMember = "Stream"
        Me.ComboStream.FormattingEnabled = True
        Me.ComboStream.Location = New System.Drawing.Point(311, 45)
        Me.ComboStream.Name = "ComboStream"
        Me.ComboStream.Size = New System.Drawing.Size(230, 24)
        Me.ComboStream.TabIndex = 33
        Me.ComboStream.ValueMember = "Stream"
        '
        'ComboClass
        '
        Me.ComboClass.DataSource = Me.AssessmentsBindingSource
        Me.ComboClass.DisplayMember = "Class"
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Location = New System.Drawing.Point(39, 45)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(243, 24)
        Me.ComboClass.TabIndex = 32
        Me.ComboClass.ValueMember = "Class"
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Location = New System.Drawing.Point(36, 84)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(55, 17)
        Me.LabelSubject.TabIndex = 37
        Me.LabelSubject.Text = "Subject"
        '
        'ComboSubject
        '
        Me.ComboSubject.DataSource = Me.AssessmentsBindingSource1
        Me.ComboSubject.DisplayMember = "Subject"
        Me.ComboSubject.FormattingEnabled = True
        Me.ComboSubject.Location = New System.Drawing.Point(39, 104)
        Me.ComboSubject.Name = "ComboSubject"
        Me.ComboSubject.Size = New System.Drawing.Size(502, 24)
        Me.ComboSubject.TabIndex = 36
        Me.ComboSubject.ValueMember = "Subject"
        '
        'ButtonLoadRecords
        '
        Me.ButtonLoadRecords.Location = New System.Drawing.Point(561, 45)
        Me.ButtonLoadRecords.Name = "ButtonLoadRecords"
        Me.ButtonLoadRecords.Size = New System.Drawing.Size(121, 82)
        Me.ButtonLoadRecords.TabIndex = 38
        Me.ButtonLoadRecords.Text = "Load Records"
        Me.ButtonLoadRecords.UseVisualStyleBackColor = True
        '
        'TextScore
        '
        Me.TextScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextScore.Location = New System.Drawing.Point(39, 154)
        Me.TextScore.Name = "TextScore"
        Me.TextScore.Size = New System.Drawing.Size(155, 38)
        Me.TextScore.TabIndex = 39
        Me.TextScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(216, 154)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(107, 38)
        Me.ButtonEnter.TabIndex = 40
        Me.ButtonEnter.Text = "Enter Score"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'LabelCurrentStudent
        '
        Me.LabelCurrentStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCurrentStudent.Location = New System.Drawing.Point(344, 154)
        Me.LabelCurrentStudent.Name = "LabelCurrentStudent"
        Me.LabelCurrentStudent.Size = New System.Drawing.Size(337, 38)
        Me.LabelCurrentStudent.TabIndex = 41
        Me.LabelCurrentStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'SMSBindingSource
        '
        Me.SMSBindingSource.DataSource = Me.SMS
        Me.SMSBindingSource.Position = 0
        '
        'EnterFA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 522)
        Me.Controls.Add(Me.LabelCurrentStudent)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.TextScore)
        Me.Controls.Add(Me.ButtonLoadRecords)
        Me.Controls.Add(Me.LabelSubject)
        Me.Controls.Add(Me.ComboSubject)
        Me.Controls.Add(Me.LabelStream)
        Me.Controls.Add(Me.LabelClass)
        Me.Controls.Add(Me.ComboStream)
        Me.Controls.Add(Me.ComboClass)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EnterFA1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter FA1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SMS As School_Management_System.SMS
    Friend WithEvents AssessmentsTableAdapter As School_Management_System.SMSTableAdapters.AssessmentsTableAdapter
    Friend WithEvents RegistrationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelStream As System.Windows.Forms.Label
    Friend WithEvents LabelClass As System.Windows.Forms.Label
    Friend WithEvents ComboStream As System.Windows.Forms.ComboBox
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSubject As System.Windows.Forms.Label
    Friend WithEvents ComboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonLoadRecords As System.Windows.Forms.Button
    Friend WithEvents TextScore As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
    Friend WithEvents LabelCurrentStudent As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssessmentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SMSBindingSource As System.Windows.Forms.BindingSource
End Class
