<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaffeine
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lbl65mg = New System.Windows.Forms.Label()
        Me.lbl24Hours = New System.Windows.Forms.Label()
        Me.lblHourly = New System.Windows.Forms.Label()
        Me.txt65mg = New System.Windows.Forms.TextBox()
        Me.txt24hours = New System.Windows.Forms.TextBox()
        Me.txtHourly = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(90, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 28)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Values"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lbl65mg
        '
        Me.lbl65mg.Location = New System.Drawing.Point(12, 58)
        Me.lbl65mg.Name = "lbl65mg"
        Me.lbl65mg.Size = New System.Drawing.Size(111, 28)
        Me.lbl65mg.TabIndex = 1
        Me.lbl65mg.Text = "One cup: When will 65mg will remain?"
        '
        'lbl24Hours
        '
        Me.lbl24Hours.Location = New System.Drawing.Point(12, 124)
        Me.lbl24Hours.Name = "lbl24Hours"
        Me.lbl24Hours.Size = New System.Drawing.Size(102, 29)
        Me.lbl24Hours.TabIndex = 2
        Me.lbl24Hours.Text = "One cup: Quantity after 24 hours:"
        '
        'lblHourly
        '
        Me.lblHourly.Location = New System.Drawing.Point(12, 191)
        Me.lblHourly.Name = "lblHourly"
        Me.lblHourly.Size = New System.Drawing.Size(126, 32)
        Me.lblHourly.TabIndex = 3
        Me.lblHourly.Text = "Hourly cups: Quantity after 24 hours:"
        '
        'txt65mg
        '
        Me.txt65mg.Location = New System.Drawing.Point(144, 58)
        Me.txt65mg.Name = "txt65mg"
        Me.txt65mg.Size = New System.Drawing.Size(100, 20)
        Me.txt65mg.TabIndex = 4
        '
        'txt24hours
        '
        Me.txt24hours.Location = New System.Drawing.Point(144, 124)
        Me.txt24hours.Name = "txt24hours"
        Me.txt24hours.Size = New System.Drawing.Size(100, 20)
        Me.txt24hours.TabIndex = 5
        '
        'txtHourly
        '
        Me.txtHourly.Location = New System.Drawing.Point(144, 191)
        Me.txtHourly.Name = "txtHourly"
        Me.txtHourly.Size = New System.Drawing.Size(100, 20)
        Me.txtHourly.TabIndex = 6
        '
        'frmCaffeine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 261)
        Me.Controls.Add(Me.txtHourly)
        Me.Controls.Add(Me.txt24hours)
        Me.Controls.Add(Me.txt65mg)
        Me.Controls.Add(Me.lblHourly)
        Me.Controls.Add(Me.lbl24Hours)
        Me.Controls.Add(Me.lbl65mg)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCaffeine"
        Me.Text = "Caffeine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lbl65mg As System.Windows.Forms.Label
    Friend WithEvents lbl24Hours As System.Windows.Forms.Label
    Friend WithEvents lblHourly As System.Windows.Forms.Label
    Friend WithEvents txt65mg As System.Windows.Forms.TextBox
    Friend WithEvents txt24hours As System.Windows.Forms.TextBox
    Friend WithEvents txtHourly As System.Windows.Forms.TextBox

End Class
