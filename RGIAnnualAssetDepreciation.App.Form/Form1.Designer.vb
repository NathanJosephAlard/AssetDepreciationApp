<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lblDoubleDecliningBalances As System.Windows.Forms.Label
        Dim lblSumOfTheYearsDigits As System.Windows.Forms.Label
        Me.lblAssetCost = New System.Windows.Forms.Label()
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.lblSalvageValue = New System.Windows.Forms.Label()
        Me.txtUsefulLife = New System.Windows.Forms.TextBox()
        Me.lblUsefulLife = New System.Windows.Forms.Label()
        Me.btnDisplayDepreciationValues = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboxDepreciationSchedules = New System.Windows.Forms.GroupBox()
        Me.lboxSumOfTheYearsDigits = New System.Windows.Forms.ListBox()
        Me.lboxDoubleDecliningBalances = New System.Windows.Forms.ListBox()
        lblDoubleDecliningBalances = New System.Windows.Forms.Label()
        lblSumOfTheYearsDigits = New System.Windows.Forms.Label()
        Me.gboxDepreciationSchedules.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDoubleDecliningBalances
        '
        lblDoubleDecliningBalances.AutoSize = True
        lblDoubleDecliningBalances.Location = New System.Drawing.Point(26, 76)
        lblDoubleDecliningBalances.Name = "lblDoubleDecliningBalances"
        lblDoubleDecliningBalances.Size = New System.Drawing.Size(304, 32)
        lblDoubleDecliningBalances.TabIndex = 9
        lblDoubleDecliningBalances.Text = "Double-declining balances:"
        '
        'lblSumOfTheYearsDigits
        '
        lblSumOfTheYearsDigits.AutoSize = True
        lblSumOfTheYearsDigits.Location = New System.Drawing.Point(465, 76)
        lblSumOfTheYearsDigits.Name = "lblSumOfTheYearsDigits"
        lblSumOfTheYearsDigits.Size = New System.Drawing.Size(280, 32)
        lblSumOfTheYearsDigits.TabIndex = 10
        lblSumOfTheYearsDigits.Text = "Sum-of-the-year's digits:"
        '
        'lblAssetCost
        '
        Me.lblAssetCost.AutoSize = True
        Me.lblAssetCost.Location = New System.Drawing.Point(27, 79)
        Me.lblAssetCost.Name = "lblAssetCost"
        Me.lblAssetCost.Size = New System.Drawing.Size(124, 32)
        Me.lblAssetCost.TabIndex = 0
        Me.lblAssetCost.Text = "Asset Cost"
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Location = New System.Drawing.Point(240, 79)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(307, 39)
        Me.txtAssetCost.TabIndex = 1
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Location = New System.Drawing.Point(240, 187)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(307, 39)
        Me.txtSalvageValue.TabIndex = 3
        '
        'lblSalvageValue
        '
        Me.lblSalvageValue.AutoSize = True
        Me.lblSalvageValue.Location = New System.Drawing.Point(27, 187)
        Me.lblSalvageValue.Name = "lblSalvageValue"
        Me.lblSalvageValue.Size = New System.Drawing.Size(161, 32)
        Me.lblSalvageValue.TabIndex = 2
        Me.lblSalvageValue.Text = "Salvage Value"
        '
        'txtUsefulLife
        '
        Me.txtUsefulLife.Location = New System.Drawing.Point(240, 298)
        Me.txtUsefulLife.Name = "txtUsefulLife"
        Me.txtUsefulLife.Size = New System.Drawing.Size(307, 39)
        Me.txtUsefulLife.TabIndex = 5
        '
        'lblUsefulLife
        '
        Me.lblUsefulLife.AutoSize = True
        Me.lblUsefulLife.Location = New System.Drawing.Point(27, 298)
        Me.lblUsefulLife.Name = "lblUsefulLife"
        Me.lblUsefulLife.Size = New System.Drawing.Size(126, 32)
        Me.lblUsefulLife.TabIndex = 4
        Me.lblUsefulLife.Text = "Useful Life"
        '
        'btnDisplayDepreciationValues
        '
        Me.btnDisplayDepreciationValues.Location = New System.Drawing.Point(27, 511)
        Me.btnDisplayDepreciationValues.Name = "btnDisplayDepreciationValues"
        Me.btnDisplayDepreciationValues.Size = New System.Drawing.Size(289, 93)
        Me.btnDisplayDepreciationValues.TabIndex = 6
        Me.btnDisplayDepreciationValues.Text = "Display depreciation values"
        Me.btnDisplayDepreciationValues.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 511)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 46)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gboxDepreciationSchedules
        '
        Me.gboxDepreciationSchedules.Controls.Add(Me.lboxSumOfTheYearsDigits)
        Me.gboxDepreciationSchedules.Controls.Add(Me.lboxDoubleDecliningBalances)
        Me.gboxDepreciationSchedules.Controls.Add(lblSumOfTheYearsDigits)
        Me.gboxDepreciationSchedules.Controls.Add(lblDoubleDecliningBalances)
        Me.gboxDepreciationSchedules.Location = New System.Drawing.Point(632, 82)
        Me.gboxDepreciationSchedules.Name = "gboxDepreciationSchedules"
        Me.gboxDepreciationSchedules.Size = New System.Drawing.Size(880, 522)
        Me.gboxDepreciationSchedules.TabIndex = 8
        Me.gboxDepreciationSchedules.TabStop = False
        Me.gboxDepreciationSchedules.Text = "Depreciation schedules"
        '
        'lboxSumOfTheYearsDigits
        '
        Me.lboxSumOfTheYearsDigits.FormattingEnabled = True
        Me.lboxSumOfTheYearsDigits.ItemHeight = 32
        Me.lboxSumOfTheYearsDigits.Location = New System.Drawing.Point(465, 119)
        Me.lboxSumOfTheYearsDigits.Name = "lboxSumOfTheYearsDigits"
        Me.lboxSumOfTheYearsDigits.Size = New System.Drawing.Size(387, 356)
        Me.lboxSumOfTheYearsDigits.TabIndex = 12
        '
        'lboxDoubleDecliningBalances
        '
        Me.lboxDoubleDecliningBalances.FormattingEnabled = True
        Me.lboxDoubleDecliningBalances.ItemHeight = 32
        Me.lboxDoubleDecliningBalances.Location = New System.Drawing.Point(26, 119)
        Me.lboxDoubleDecliningBalances.Name = "lboxDoubleDecliningBalances"
        Me.lboxDoubleDecliningBalances.Size = New System.Drawing.Size(387, 356)
        Me.lboxDoubleDecliningBalances.TabIndex = 11
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 650)
        Me.Controls.Add(Me.gboxDepreciationSchedules)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayDepreciationValues)
        Me.Controls.Add(Me.txtUsefulLife)
        Me.Controls.Add(Me.lblUsefulLife)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.lblSalvageValue)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Controls.Add(Me.lblAssetCost)
        Me.Name = "Form"
        Me.Text = "RGI Annual Asset Depreciation App"
        Me.gboxDepreciationSchedules.ResumeLayout(False)
        Me.gboxDepreciationSchedules.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssetCost As Label
    Friend WithEvents txtAssetCost As TextBox
    Friend WithEvents txtSalvageValue As TextBox
    Friend WithEvents lblSalvageValue As Label
    Friend WithEvents txtUsefulLife As TextBox
    Friend WithEvents lblUsefulLife As Label
    Friend WithEvents btnDisplayDepreciationValues As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents gboxDepreciationSchedules As GroupBox
    Friend WithEvents lboxSumOfTheYearsDigits As ListBox
    Friend WithEvents lboxDoubleDecliningBalances As ListBox
End Class
