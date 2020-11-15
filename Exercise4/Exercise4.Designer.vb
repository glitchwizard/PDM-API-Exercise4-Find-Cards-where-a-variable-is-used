<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise4
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
		Me.FindCardsButton = New System.Windows.Forms.Button()
		Me.VaultsComboBox = New System.Windows.Forms.ComboBox()
		Me.VaultsLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'FindCardsButton
		'
		Me.FindCardsButton.Location = New System.Drawing.Point(39, 69)
		Me.FindCardsButton.Margin = New System.Windows.Forms.Padding(2)
		Me.FindCardsButton.Name = "FindCardsButton"
		Me.FindCardsButton.Size = New System.Drawing.Size(101, 41)
		Me.FindCardsButton.TabIndex = 23
		Me.FindCardsButton.Text = "Find Cards that Use a Variable"
		Me.FindCardsButton.UseVisualStyleBackColor = True
		'
		'VaultsComboBox
		'
		Me.VaultsComboBox.FormattingEnabled = True
		Me.VaultsComboBox.Location = New System.Drawing.Point(24, 37)
		Me.VaultsComboBox.Margin = New System.Windows.Forms.Padding(2)
		Me.VaultsComboBox.Name = "VaultsComboBox"
		Me.VaultsComboBox.Size = New System.Drawing.Size(132, 21)
		Me.VaultsComboBox.TabIndex = 22
		'
		'VaultsLabel
		'
		Me.VaultsLabel.AutoSize = True
		Me.VaultsLabel.Location = New System.Drawing.Point(21, 20)
		Me.VaultsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.VaultsLabel.Name = "VaultsLabel"
		Me.VaultsLabel.Size = New System.Drawing.Size(136, 13)
		Me.VaultsLabel.TabIndex = 21
		Me.VaultsLabel.Text = "Select Preferred Vault View"
		'
		'Exercise4
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(182, 138)
		Me.Controls.Add(Me.FindCardsButton)
		Me.Controls.Add(Me.VaultsComboBox)
		Me.Controls.Add(Me.VaultsLabel)
		Me.Name = "Exercise4"
		Me.Text = "Exercise 4"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents FindCardsButton As System.Windows.Forms.Button
	Friend WithEvents VaultsComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents VaultsLabel As System.Windows.Forms.Label

End Class
