﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainerBattleStart
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
		Me.lblDialogue = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.lblName = New System.Windows.Forms.Label()
		Me.picTrainer = New System.Windows.Forms.PictureBox()
		CType(Me.picTrainer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblDialogue
		'
		Me.lblDialogue.AutoSize = True
		Me.lblDialogue.Location = New System.Drawing.Point(430, 225)
		Me.lblDialogue.Name = "lblDialogue"
		Me.lblDialogue.Size = New System.Drawing.Size(39, 13)
		Me.lblDialogue.TabIndex = 49
		Me.lblDialogue.Text = "Label1"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(362, 326)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 50
		Me.Button1.Text = "Start Battle!"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(196, 116)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(39, 13)
		Me.lblName.TabIndex = 51
		Me.lblName.Text = "Label1"
		'
		'picTrainer
		'
		Me.picTrainer.Location = New System.Drawing.Point(401, 21)
		Me.picTrainer.Name = "picTrainer"
		Me.picTrainer.Size = New System.Drawing.Size(190, 190)
		Me.picTrainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picTrainer.TabIndex = 48
		Me.picTrainer.TabStop = False
		'
		'frmTrainerBattleStart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.lblDialogue)
		Me.Controls.Add(Me.picTrainer)
		Me.Name = "frmTrainerBattleStart"
		Me.Text = "frmTrainerBattleStart"
		CType(Me.picTrainer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picTrainer As PictureBox
	Friend WithEvents lblDialogue As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents lblName As Label
End Class
