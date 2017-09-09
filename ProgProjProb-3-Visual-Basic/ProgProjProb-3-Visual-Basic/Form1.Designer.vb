<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblBloodKits = New System.Windows.Forms.Label()
        Me.lblHeartKits = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtBloodKits = New System.Windows.Forms.TextBox()
        Me.txtHeartKits = New System.Windows.Forms.TextBox()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtActivityMonitors = New System.Windows.Forms.TextBox()
        Me.lblActivityMonitors = New System.Windows.Forms.Label()
        Me.txtIntakeJournals = New System.Windows.Forms.TextBox()
        Me.lblIntakeJournals = New System.Windows.Forms.Label()
        Me.txtBothJournals = New System.Windows.Forms.TextBox()
        Me.lblBothJournals = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(82, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(127, 32)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Patient name (Last, First):"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(161, 55)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(130, 90)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(79, 13)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City, State, Zip:"
        '
        'lblBloodKits
        '
        Me.lblBloodKits.Location = New System.Drawing.Point(16, 125)
        Me.lblBloodKits.Name = "lblBloodKits"
        Me.lblBloodKits.Size = New System.Drawing.Size(193, 31)
        Me.lblBloodKits.TabIndex = 3
        Me.lblBloodKits.Text = "Number of blood pressure kits ordered:"
        '
        'lblHeartKits
        '
        Me.lblHeartKits.Location = New System.Drawing.Point(16, 160)
        Me.lblHeartKits.Name = "lblHeartKits"
        Me.lblHeartKits.Size = New System.Drawing.Size(193, 32)
        Me.lblHeartKits.TabIndex = 4
        Me.lblHeartKits.Text = "Number of heart pressure kits ordered:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(221, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 20)
        Me.txtName.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(221, 52)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(228, 20)
        Me.txtAddress.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(221, 87)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(228, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtBloodKits
        '
        Me.txtBloodKits.Location = New System.Drawing.Point(221, 122)
        Me.txtBloodKits.Name = "txtBloodKits"
        Me.txtBloodKits.Size = New System.Drawing.Size(100, 20)
        Me.txtBloodKits.TabIndex = 11
        '
        'txtHeartKits
        '
        Me.txtHeartKits.Location = New System.Drawing.Point(221, 157)
        Me.txtHeartKits.Name = "txtHeartKits"
        Me.txtHeartKits.Size = New System.Drawing.Size(100, 20)
        Me.txtHeartKits.TabIndex = 12
        '
        'lstInvoice
        '
        Me.lstInvoice.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 14
        Me.lstInvoice.Location = New System.Drawing.Point(623, 18)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(364, 284)
        Me.lstInvoice.TabIndex = 19
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(471, 20)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(146, 48)
        Me.btnProcess.TabIndex = 16
        Me.btnProcess.Text = "Process Order"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(471, 137)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 48)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(471, 254)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(146, 48)
        Me.btnQuit.TabIndex = 18
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtActivityMonitors
        '
        Me.txtActivityMonitors.Location = New System.Drawing.Point(221, 192)
        Me.txtActivityMonitors.Name = "txtActivityMonitors"
        Me.txtActivityMonitors.Size = New System.Drawing.Size(100, 20)
        Me.txtActivityMonitors.TabIndex = 13
        '
        'lblActivityMonitors
        '
        Me.lblActivityMonitors.Location = New System.Drawing.Point(16, 195)
        Me.lblActivityMonitors.Name = "lblActivityMonitors"
        Me.lblActivityMonitors.Size = New System.Drawing.Size(193, 32)
        Me.lblActivityMonitors.TabIndex = 5
        Me.lblActivityMonitors.Text = "Number of activity monitors ordered:"
        '
        'txtIntakeJournals
        '
        Me.txtIntakeJournals.Location = New System.Drawing.Point(221, 227)
        Me.txtIntakeJournals.Name = "txtIntakeJournals"
        Me.txtIntakeJournals.Size = New System.Drawing.Size(100, 20)
        Me.txtIntakeJournals.TabIndex = 14
        '
        'lblIntakeJournals
        '
        Me.lblIntakeJournals.Location = New System.Drawing.Point(16, 230)
        Me.lblIntakeJournals.Name = "lblIntakeJournals"
        Me.lblIntakeJournals.Size = New System.Drawing.Size(193, 32)
        Me.lblIntakeJournals.TabIndex = 6
        Me.lblIntakeJournals.Text = "Number of food intake journals ordered:"
        '
        'txtBothJournals
        '
        Me.txtBothJournals.Location = New System.Drawing.Point(221, 262)
        Me.txtBothJournals.Name = "txtBothJournals"
        Me.txtBothJournals.Size = New System.Drawing.Size(100, 20)
        Me.txtBothJournals.TabIndex = 15
        '
        'lblBothJournals
        '
        Me.lblBothJournals.Location = New System.Drawing.Point(16, 265)
        Me.lblBothJournals.Name = "lblBothJournals"
        Me.lblBothJournals.Size = New System.Drawing.Size(193, 32)
        Me.lblBothJournals.TabIndex = 7
        Me.lblBothJournals.Text = "Number of food intake and activity journals ordered:"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 319)
        Me.Controls.Add(Me.txtBothJournals)
        Me.Controls.Add(Me.lblBothJournals)
        Me.Controls.Add(Me.txtIntakeJournals)
        Me.Controls.Add(Me.lblIntakeJournals)
        Me.Controls.Add(Me.txtActivityMonitors)
        Me.Controls.Add(Me.lblActivityMonitors)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.txtHeartKits)
        Me.Controls.Add(Me.txtBloodKits)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHeartKits)
        Me.Controls.Add(Me.lblBloodKits)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmOrder"
        Me.Text = "Patient Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblBloodKits As System.Windows.Forms.Label
    Friend WithEvents lblHeartKits As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBloodKits As System.Windows.Forms.TextBox
    Friend WithEvents txtHeartKits As System.Windows.Forms.TextBox
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtActivityMonitors As System.Windows.Forms.TextBox
    Friend WithEvents lblActivityMonitors As System.Windows.Forms.Label
    Friend WithEvents txtIntakeJournals As System.Windows.Forms.TextBox
    Friend WithEvents lblIntakeJournals As System.Windows.Forms.Label
    Friend WithEvents txtBothJournals As System.Windows.Forms.TextBox
    Friend WithEvents lblBothJournals As System.Windows.Forms.Label

End Class
