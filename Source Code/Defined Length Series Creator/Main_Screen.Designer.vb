<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.InputStart = New System.Windows.Forms.TextBox
        Me.InputEnd = New System.Windows.Forms.TextBox
        Me.InputStep = New System.Windows.Forms.TextBox
        Me.OutputSeries = New System.Windows.Forms.RichTextBox
        Me.ButtonLaunch = New System.Windows.Forms.Button
        Me.InputLength = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'InputStart
        '
        Me.InputStart.Location = New System.Drawing.Point(12, 25)
        Me.InputStart.Name = "InputStart"
        Me.InputStart.Size = New System.Drawing.Size(46, 20)
        Me.InputStart.TabIndex = 0
        Me.InputStart.Text = "1"
        Me.ToolTip1.SetToolTip(Me.InputStart, "Series Starting Number")
        '
        'InputEnd
        '
        Me.InputEnd.Location = New System.Drawing.Point(64, 25)
        Me.InputEnd.Name = "InputEnd"
        Me.InputEnd.Size = New System.Drawing.Size(45, 20)
        Me.InputEnd.TabIndex = 1
        Me.InputEnd.Text = "100"
        Me.ToolTip1.SetToolTip(Me.InputEnd, "Series Ending Number")
        '
        'InputStep
        '
        Me.InputStep.Location = New System.Drawing.Point(115, 25)
        Me.InputStep.Name = "InputStep"
        Me.InputStep.Size = New System.Drawing.Size(45, 20)
        Me.InputStep.TabIndex = 2
        Me.InputStep.Text = "1"
        Me.ToolTip1.SetToolTip(Me.InputStep, "Series Step")
        '
        'OutputSeries
        '
        Me.OutputSeries.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OutputSeries.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputSeries.Location = New System.Drawing.Point(5, 101)
        Me.OutputSeries.Name = "OutputSeries"
        Me.OutputSeries.ReadOnly = True
        Me.OutputSeries.Size = New System.Drawing.Size(220, 353)
        Me.OutputSeries.TabIndex = 3
        Me.OutputSeries.Text = ""
        '
        'ButtonLaunch
        '
        Me.ButtonLaunch.Location = New System.Drawing.Point(54, 61)
        Me.ButtonLaunch.Name = "ButtonLaunch"
        Me.ButtonLaunch.Size = New System.Drawing.Size(116, 23)
        Me.ButtonLaunch.TabIndex = 4
        Me.ButtonLaunch.Text = "Generate Series"
        Me.ButtonLaunch.UseVisualStyleBackColor = True
        '
        'InputLength
        '
        Me.InputLength.Location = New System.Drawing.Point(166, 25)
        Me.InputLength.Name = "InputLength"
        Me.InputLength.Size = New System.Drawing.Size(51, 20)
        Me.InputLength.TabIndex = 5
        Me.InputLength.Text = "3"
        Me.ToolTip1.SetToolTip(Me.InputLength, "Character String Length")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.Label1, "Series Starting Number")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "End"
        Me.ToolTip1.SetToolTip(Me.Label2, "Series Ending Number")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Step"
        Me.ToolTip1.SetToolTip(Me.Label3, "Series Step")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Chars"
        Me.ToolTip1.SetToolTip(Me.Label4, "Character String Length")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        Me.SaveFileDialog1.Title = "Select File to Save Series To"
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputLength)
        Me.Controls.Add(Me.ButtonLaunch)
        Me.Controls.Add(Me.OutputSeries)
        Me.Controls.Add(Me.InputStep)
        Me.Controls.Add(Me.InputEnd)
        Me.Controls.Add(Me.InputStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(238, 493)
        Me.MinimumSize = New System.Drawing.Size(238, 493)
        Me.Name = "Main_Screen"
        Me.Text = "DL Series Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputStart As System.Windows.Forms.TextBox
    Friend WithEvents InputEnd As System.Windows.Forms.TextBox
    Friend WithEvents InputStep As System.Windows.Forms.TextBox
    Friend WithEvents OutputSeries As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonLaunch As System.Windows.Forms.Button
    Friend WithEvents InputLength As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
