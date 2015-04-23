<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputeResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComputeResult))
        Me.ButtonComputeResults = New System.Windows.Forms.Button()
        Me.ComboSubject = New System.Windows.Forms.ComboBox()
        Me.AssessmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS = New School_Management_System.SMS()
        Me.ComboStream = New System.Windows.Forms.ComboBox()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SA1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SA2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalSADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentsTableAdapter = New School_Management_System.SMSTableAdapters.AssessmentsTableAdapter()
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonComputeResults
        '
        Me.ButtonComputeResults.Location = New System.Drawing.Point(954, 30)
        Me.ButtonComputeResults.Name = "ButtonComputeResults"
        Me.ButtonComputeResults.Size = New System.Drawing.Size(127, 82)
        Me.ButtonComputeResults.TabIndex = 50
        Me.ButtonComputeResults.Text = "Compute Results"
        Me.ButtonComputeResults.UseVisualStyleBackColor = True
        '
        'ComboSubject
        '
        Me.ComboSubject.FormattingEnabled = True
        Me.ComboSubject.Location = New System.Drawing.Point(124, 91)
        Me.ComboSubject.Name = "ComboSubject"
        Me.ComboSubject.Size = New System.Drawing.Size(790, 24)
        Me.ComboSubject.TabIndex = 49
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
        'ComboStream
        '
        Me.ComboStream.DataSource = Me.AssessmentsBindingSource1
        Me.ComboStream.DisplayMember = "Stream"
        Me.ComboStream.FormattingEnabled = True
        Me.ComboStream.Location = New System.Drawing.Point(602, 32)
        Me.ComboStream.Name = "ComboStream"
        Me.ComboStream.Size = New System.Drawing.Size(312, 24)
        Me.ComboStream.TabIndex = 48
        Me.ComboStream.ValueMember = "Stream"
        '
        'ComboClass
        '
        Me.ComboClass.DataSource = Me.AssessmentsBindingSource1
        Me.ComboClass.DisplayMember = "Class"
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Location = New System.Drawing.Point(124, 32)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(359, 24)
        Me.ComboClass.TabIndex = 47
        Me.ComboClass.ValueMember = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Subject"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RegistrationNoDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.FA1DataGridViewTextBoxColumn, Me.FA2DataGridViewTextBoxColumn, Me.SA1DataGridViewTextBoxColumn, Me.Total1DataGridViewTextBoxColumn, Me.FA3DataGridViewTextBoxColumn, Me.FA4DataGridViewTextBoxColumn, Me.SA2DataGridViewTextBoxColumn, Me.Total2DataGridViewTextBoxColumn, Me.TotalFADataGridViewTextBoxColumn, Me.TotalSADataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AssessmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(61, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1020, 321)
        Me.DataGridView1.TabIndex = 54
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'RegistrationNoDataGridViewTextBoxColumn
        '
        Me.RegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "Registration_No"
        Me.RegistrationNoDataGridViewTextBoxColumn.HeaderText = "Reg#"
        Me.RegistrationNoDataGridViewTextBoxColumn.Name = "RegistrationNoDataGridViewTextBoxColumn"
        Me.RegistrationNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StreamDataGridViewTextBoxColumn
        '
        Me.StreamDataGridViewTextBoxColumn.DataPropertyName = "Stream"
        Me.StreamDataGridViewTextBoxColumn.HeaderText = "Stream"
        Me.StreamDataGridViewTextBoxColumn.Name = "StreamDataGridViewTextBoxColumn"
        Me.StreamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FA1DataGridViewTextBoxColumn
        '
        Me.FA1DataGridViewTextBoxColumn.DataPropertyName = "FA1"
        Me.FA1DataGridViewTextBoxColumn.HeaderText = "FA1"
        Me.FA1DataGridViewTextBoxColumn.Name = "FA1DataGridViewTextBoxColumn"
        Me.FA1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FA2DataGridViewTextBoxColumn
        '
        Me.FA2DataGridViewTextBoxColumn.DataPropertyName = "FA2"
        Me.FA2DataGridViewTextBoxColumn.HeaderText = "FA2"
        Me.FA2DataGridViewTextBoxColumn.Name = "FA2DataGridViewTextBoxColumn"
        Me.FA2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SA1DataGridViewTextBoxColumn
        '
        Me.SA1DataGridViewTextBoxColumn.DataPropertyName = "SA1"
        Me.SA1DataGridViewTextBoxColumn.HeaderText = "SA1"
        Me.SA1DataGridViewTextBoxColumn.Name = "SA1DataGridViewTextBoxColumn"
        Me.SA1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Total1DataGridViewTextBoxColumn
        '
        Me.Total1DataGridViewTextBoxColumn.DataPropertyName = "Total1"
        Me.Total1DataGridViewTextBoxColumn.HeaderText = "Total1"
        Me.Total1DataGridViewTextBoxColumn.Name = "Total1DataGridViewTextBoxColumn"
        Me.Total1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FA3DataGridViewTextBoxColumn
        '
        Me.FA3DataGridViewTextBoxColumn.DataPropertyName = "FA3"
        Me.FA3DataGridViewTextBoxColumn.HeaderText = "FA3"
        Me.FA3DataGridViewTextBoxColumn.Name = "FA3DataGridViewTextBoxColumn"
        Me.FA3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FA4DataGridViewTextBoxColumn
        '
        Me.FA4DataGridViewTextBoxColumn.DataPropertyName = "FA4"
        Me.FA4DataGridViewTextBoxColumn.HeaderText = "FA4"
        Me.FA4DataGridViewTextBoxColumn.Name = "FA4DataGridViewTextBoxColumn"
        Me.FA4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SA2DataGridViewTextBoxColumn
        '
        Me.SA2DataGridViewTextBoxColumn.DataPropertyName = "SA2"
        Me.SA2DataGridViewTextBoxColumn.HeaderText = "SA2"
        Me.SA2DataGridViewTextBoxColumn.Name = "SA2DataGridViewTextBoxColumn"
        Me.SA2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Total2DataGridViewTextBoxColumn
        '
        Me.Total2DataGridViewTextBoxColumn.DataPropertyName = "Total2"
        Me.Total2DataGridViewTextBoxColumn.HeaderText = "Total2"
        Me.Total2DataGridViewTextBoxColumn.Name = "Total2DataGridViewTextBoxColumn"
        Me.Total2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFADataGridViewTextBoxColumn
        '
        Me.TotalFADataGridViewTextBoxColumn.DataPropertyName = "TotalFA"
        Me.TotalFADataGridViewTextBoxColumn.HeaderText = "TotalFA"
        Me.TotalFADataGridViewTextBoxColumn.Name = "TotalFADataGridViewTextBoxColumn"
        Me.TotalFADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalSADataGridViewTextBoxColumn
        '
        Me.TotalSADataGridViewTextBoxColumn.DataPropertyName = "TotalSA"
        Me.TotalSADataGridViewTextBoxColumn.HeaderText = "TotalSA"
        Me.TotalSADataGridViewTextBoxColumn.Name = "TotalSADataGridViewTextBoxColumn"
        Me.TotalSADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        Me.GPADataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'ComputeResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 519)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonComputeResults)
        Me.Controls.Add(Me.ComboSubject)
        Me.Controls.Add(Me.ComboStream)
        Me.Controls.Add(Me.ComboClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ComputeResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compute Result"
        CType(Me.AssessmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonComputeResults As System.Windows.Forms.Button
    Friend WithEvents ComboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents ComboStream As System.Windows.Forms.ComboBox
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SMS As School_Management_System.SMS
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssessmentsTableAdapter As School_Management_System.SMSTableAdapters.AssessmentsTableAdapter
    Friend WithEvents AssessmentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SA1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SA2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalSADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
