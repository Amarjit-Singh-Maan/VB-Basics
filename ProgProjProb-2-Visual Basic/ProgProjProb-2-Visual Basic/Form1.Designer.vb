<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.grpBloodWork = New System.Windows.Forms.GroupBox()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.radCholesterol = New System.Windows.Forms.RadioButton()
        Me.radCholSugar = New System.Windows.Forms.RadioButton()
        Me.radAllFour = New System.Windows.Forms.RadioButton()
        Me.grpNutEvaluation = New System.Windows.Forms.GroupBox()
        Me.radBronze = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.grpNutJournals = New System.Windows.Forms.GroupBox()
        Me.radIntake = New System.Windows.Forms.RadioButton()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.chkNutJournals = New System.Windows.Forms.CheckBox()
        Me.chkNutEvaluation = New System.Windows.Forms.CheckBox()
        Me.chkBloodWork = New System.Windows.Forms.CheckBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblCostMeal = New System.Windows.Forms.Label()
        Me.txtTotalBill = New System.Windows.Forms.TextBox()
        Me.grpBloodWork.SuspendLayout()
        Me.grpNutEvaluation.SuspendLayout()
        Me.grpNutJournals.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBloodWork
        '
        Me.grpBloodWork.Controls.Add(Me.radBasic)
        Me.grpBloodWork.Controls.Add(Me.radCholesterol)
        Me.grpBloodWork.Controls.Add(Me.radCholSugar)
        Me.grpBloodWork.Controls.Add(Me.radAllFour)
        Me.grpBloodWork.Location = New System.Drawing.Point(156, 12)
        Me.grpBloodWork.Name = "grpBloodWork"
        Me.grpBloodWork.Size = New System.Drawing.Size(616, 121)
        Me.grpBloodWork.TabIndex = 0
        Me.grpBloodWork.TabStop = False
        Me.grpBloodWork.Text = "Choices for Blood Work"
        Me.grpBloodWork.Visible = False
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Checked = True
        Me.radBasic.Location = New System.Drawing.Point(38, 23)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(122, 17)
        Me.radBasic.TabIndex = 5
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "Basic panel ($79.99)"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'radCholesterol
        '
        Me.radCholesterol.AutoSize = True
        Me.radCholesterol.Location = New System.Drawing.Point(38, 46)
        Me.radCholesterol.Name = "radCholesterol"
        Me.radCholesterol.Size = New System.Drawing.Size(276, 17)
        Me.radCholesterol.TabIndex = 6
        Me.radCholesterol.TabStop = True
        Me.radCholesterol.Text = "Basic panel + advanced cholesterol testing ($129.99)"
        Me.radCholesterol.UseVisualStyleBackColor = True
        '
        'radCholSugar
        '
        Me.radCholSugar.AutoSize = True
        Me.radCholSugar.Location = New System.Drawing.Point(38, 69)
        Me.radCholSugar.Name = "radCholSugar"
        Me.radCholSugar.Size = New System.Drawing.Size(399, 17)
        Me.radCholSugar.TabIndex = 7
        Me.radCholSugar.TabStop = True
        Me.radCholSugar.Text = "Basic panel + advanced cholesterol testing + advanced sugar testing ($179.99)"
        Me.radCholSugar.UseVisualStyleBackColor = True
        '
        'radAllFour
        '
        Me.radAllFour.AutoSize = True
        Me.radAllFour.Location = New System.Drawing.Point(38, 92)
        Me.radAllFour.Name = "radAllFour"
        Me.radAllFour.Size = New System.Drawing.Size(530, 17)
        Me.radAllFour.TabIndex = 8
        Me.radAllFour.TabStop = True
        Me.radAllFour.Text = "Basic panel + advanced cholesterol testing + advanced sugar testing + vitamin abs" & _
    "orption testing ($229.99)"
        Me.radAllFour.UseVisualStyleBackColor = True
        '
        'grpNutEvaluation
        '
        Me.grpNutEvaluation.Controls.Add(Me.radBronze)
        Me.grpNutEvaluation.Controls.Add(Me.radSilver)
        Me.grpNutEvaluation.Controls.Add(Me.radGold)
        Me.grpNutEvaluation.Location = New System.Drawing.Point(156, 139)
        Me.grpNutEvaluation.Name = "grpNutEvaluation"
        Me.grpNutEvaluation.Size = New System.Drawing.Size(616, 100)
        Me.grpNutEvaluation.TabIndex = 1
        Me.grpNutEvaluation.TabStop = False
        Me.grpNutEvaluation.Text = "Choices for Nutritional Evaluation"
        Me.grpNutEvaluation.Visible = False
        '
        'radBronze
        '
        Me.radBronze.AutoSize = True
        Me.radBronze.Checked = True
        Me.radBronze.Location = New System.Drawing.Point(38, 26)
        Me.radBronze.Name = "radBronze"
        Me.radBronze.Size = New System.Drawing.Size(106, 17)
        Me.radBronze.TabIndex = 2
        Me.radBronze.TabStop = True
        Me.radBronze.Text = "Bronze ($199.99)"
        Me.radBronze.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(38, 49)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(99, 17)
        Me.radSilver.TabIndex = 3
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver ($299.99)"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(38, 72)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(95, 17)
        Me.radGold.TabIndex = 4
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold ($399.99)"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'grpNutJournals
        '
        Me.grpNutJournals.Controls.Add(Me.radIntake)
        Me.grpNutJournals.Controls.Add(Me.radBoth)
        Me.grpNutJournals.Location = New System.Drawing.Point(156, 246)
        Me.grpNutJournals.Name = "grpNutJournals"
        Me.grpNutJournals.Size = New System.Drawing.Size(616, 70)
        Me.grpNutJournals.TabIndex = 0
        Me.grpNutJournals.TabStop = False
        Me.grpNutJournals.Text = "Choices for Nutritional Journals"
        Me.grpNutJournals.Visible = False
        '
        'radIntake
        '
        Me.radIntake.AutoSize = True
        Me.radIntake.Checked = True
        Me.radIntake.Location = New System.Drawing.Point(38, 24)
        Me.radIntake.Name = "radIntake"
        Me.radIntake.Size = New System.Drawing.Size(156, 17)
        Me.radIntake.TabIndex = 2
        Me.radIntake.TabStop = True
        Me.radIntake.Text = "Food intake journals ($9.99)"
        Me.radIntake.UseVisualStyleBackColor = True
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Location = New System.Drawing.Point(38, 47)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(214, 17)
        Me.radBoth.TabIndex = 3
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "Food intake and activity journal ($14.99)"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'chkNutJournals
        '
        Me.chkNutJournals.AutoSize = True
        Me.chkNutJournals.Location = New System.Drawing.Point(26, 271)
        Me.chkNutJournals.Name = "chkNutJournals"
        Me.chkNutJournals.Size = New System.Drawing.Size(115, 17)
        Me.chkNutJournals.TabIndex = 4
        Me.chkNutJournals.Text = "Nutritional Journals"
        Me.chkNutJournals.UseVisualStyleBackColor = True
        '
        'chkNutEvaluation
        '
        Me.chkNutEvaluation.AutoSize = True
        Me.chkNutEvaluation.Location = New System.Drawing.Point(26, 166)
        Me.chkNutEvaluation.Name = "chkNutEvaluation"
        Me.chkNutEvaluation.Size = New System.Drawing.Size(126, 17)
        Me.chkNutEvaluation.TabIndex = 3
        Me.chkNutEvaluation.Text = "Nutritional Evaluation"
        Me.chkNutEvaluation.UseVisualStyleBackColor = True
        '
        'chkBloodWork
        '
        Me.chkBloodWork.AutoSize = True
        Me.chkBloodWork.Location = New System.Drawing.Point(26, 35)
        Me.chkBloodWork.Name = "chkBloodWork"
        Me.chkBloodWork.Size = New System.Drawing.Size(86, 17)
        Me.chkBloodWork.TabIndex = 2
        Me.chkBloodWork.Text = "BLood Work"
        Me.chkBloodWork.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(824, 216)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(125, 47)
        Me.btnCompute.TabIndex = 5
        Me.btnCompute.Text = "Compute total bill"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblCostMeal
        '
        Me.lblCostMeal.AutoSize = True
        Me.lblCostMeal.Location = New System.Drawing.Point(797, 272)
        Me.lblCostMeal.Name = "lblCostMeal"
        Me.lblCostMeal.Size = New System.Drawing.Size(50, 13)
        Me.lblCostMeal.TabIndex = 6
        Me.lblCostMeal.Text = "Total Bill:"
        '
        'txtTotalBill
        '
        Me.txtTotalBill.Location = New System.Drawing.Point(866, 269)
        Me.txtTotalBill.Name = "txtTotalBill"
        Me.txtTotalBill.Size = New System.Drawing.Size(83, 20)
        Me.txtTotalBill.TabIndex = 7
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 328)
        Me.Controls.Add(Me.txtTotalBill)
        Me.Controls.Add(Me.lblCostMeal)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.chkNutJournals)
        Me.Controls.Add(Me.chkNutEvaluation)
        Me.Controls.Add(Me.chkBloodWork)
        Me.Controls.Add(Me.grpNutJournals)
        Me.Controls.Add(Me.grpNutEvaluation)
        Me.Controls.Add(Me.grpBloodWork)
        Me.Name = "frmBill"
        Me.Text = "Menu"
        Me.grpBloodWork.ResumeLayout(False)
        Me.grpBloodWork.PerformLayout()
        Me.grpNutEvaluation.ResumeLayout(False)
        Me.grpNutEvaluation.PerformLayout()
        Me.grpNutJournals.ResumeLayout(False)
        Me.grpNutJournals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBloodWork As System.Windows.Forms.GroupBox
    Friend WithEvents radBasic As System.Windows.Forms.RadioButton
    Friend WithEvents radCholesterol As System.Windows.Forms.RadioButton
    Friend WithEvents radCholSugar As System.Windows.Forms.RadioButton
    Friend WithEvents radAllFour As System.Windows.Forms.RadioButton
    Friend WithEvents grpNutEvaluation As System.Windows.Forms.GroupBox
    Friend WithEvents radBronze As System.Windows.Forms.RadioButton
    Friend WithEvents radSilver As System.Windows.Forms.RadioButton
    Friend WithEvents radGold As System.Windows.Forms.RadioButton
    Friend WithEvents grpNutJournals As System.Windows.Forms.GroupBox
    Friend WithEvents radIntake As System.Windows.Forms.RadioButton
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents chkNutJournals As System.Windows.Forms.CheckBox
    Friend WithEvents chkNutEvaluation As System.Windows.Forms.CheckBox
    Friend WithEvents chkBloodWork As System.Windows.Forms.CheckBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblCostMeal As System.Windows.Forms.Label
    Friend WithEvents txtTotalBill As System.Windows.Forms.TextBox

End Class
