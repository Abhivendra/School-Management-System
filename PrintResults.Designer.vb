<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintResults
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintResults))
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS = New School_Management_System.SMS()
        Me.ButtonComputeResults = New System.Windows.Forms.Button()
        Me.ComboSubject = New System.Windows.Forms.ComboBox()
        Me.ComboStream = New System.Windows.Forms.ComboBox()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.AssessmentsTableAdapter = New School_Management_System.SMSTableAdapters.AssessmentsTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'SMS
        '
        Me.SMS.DataSetName = "SMS"
        Me.SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonComputeResults
        '
        Me.ButtonComputeResults.Location = New System.Drawing.Point(959, 35)
        Me.ButtonComputeResults.Name = "ButtonComputeResults"
        Me.ButtonComputeResults.Size = New System.Drawing.Size(127, 82)
        Me.ButtonComputeResults.TabIndex = 46
        Me.ButtonComputeResults.Text = "Print Results"
        Me.ButtonComputeResults.UseVisualStyleBackColor = True
        '
        'ComboSubject
        '
        Me.ComboSubject.DataSource = Me.AssessmentsBindingSource
        Me.ComboSubject.DisplayMember = "Subject"
        Me.ComboSubject.FormattingEnabled = True
        Me.ComboSubject.Location = New System.Drawing.Point(348, 93)
        Me.ComboSubject.Name = "ComboSubject"
        Me.ComboSubject.Size = New System.Drawing.Size(582, 24)
        Me.ComboSubject.TabIndex = 45
        Me.ComboSubject.ValueMember = "Subject"
        '
        'ComboStream
        '
        Me.ComboStream.DataSource = Me.AssessmentsBindingSource
        Me.ComboStream.DisplayMember = "Stream"
        Me.ComboStream.FormattingEnabled = True
        Me.ComboStream.Location = New System.Drawing.Point(700, 34)
        Me.ComboStream.Name = "ComboStream"
        Me.ComboStream.Size = New System.Drawing.Size(230, 24)
        Me.ComboStream.TabIndex = 44
        Me.ComboStream.ValueMember = "Stream"
        '
        'ComboClass
        '
        Me.ComboClass.DataSource = Me.AssessmentsBindingSource
        Me.ComboClass.DisplayMember = "Class"
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Location = New System.Drawing.Point(348, 35)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(243, 24)
        Me.ComboClass.TabIndex = 43
        Me.ComboClass.ValueMember = "Class"
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ResultsDS"
        ReportDataSource1.Value = Me.AssessmentsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "School_Management_System.ResultReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(43, 130)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1266, 455)
        Me.ReportViewer1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Subject"
        '
        'PrintResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 597)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ButtonComputeResults)
        Me.Controls.Add(Me.ComboSubject)
        Me.Controls.Add(Me.ComboStream)
        Me.Controls.Add(Me.ComboClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Results"
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonComputeResults As System.Windows.Forms.Button
    Friend WithEvents ComboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents ComboStream As System.Windows.Forms.ComboBox
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SMS As School_Management_System.SMS
    Friend WithEvents AssessmentsTableAdapter As School_Management_System.SMSTableAdapters.AssessmentsTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
