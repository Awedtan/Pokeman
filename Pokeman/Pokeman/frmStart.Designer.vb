<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
		Me.PictureBox43 = New System.Windows.Forms.PictureBox()
		Me.lblDialogue = New System.Windows.Forms.Label()
		Me.btnSquirtle = New System.Windows.Forms.Button()
		Me.btnBulbasaur = New System.Windows.Forms.Button()
		Me.btnCharmander = New System.Windows.Forms.Button()
		Me.picBulbasaur = New System.Windows.Forms.PictureBox()
		Me.picCharmander = New System.Windows.Forms.PictureBox()
		Me.picSquirtle = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picBulbasaur, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCharmander, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSquirtle, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox43
		'
		Me.PictureBox43.Image = Global.Pokeman.My.Resources.Resources._3701
		Me.PictureBox43.Location = New System.Drawing.Point(285, 12)
		Me.PictureBox43.Name = "PictureBox43"
		Me.PictureBox43.Size = New System.Drawing.Size(148, 125)
		Me.PictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox43.TabIndex = 47
		Me.PictureBox43.TabStop = False
		'
		'lblDialogue
		'
		Me.lblDialogue.Location = New System.Drawing.Point(176, 155)
		Me.lblDialogue.Name = "lblDialogue"
		Me.lblDialogue.Size = New System.Drawing.Size(367, 29)
		Me.lblDialogue.TabIndex = 48
		Me.lblDialogue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSquirtle
		'
		Me.btnSquirtle.Location = New System.Drawing.Point(131, 294)
		Me.btnSquirtle.Name = "btnSquirtle"
		Me.btnSquirtle.Size = New System.Drawing.Size(75, 23)
		Me.btnSquirtle.TabIndex = 49
		Me.btnSquirtle.Text = "Squirtle"
		Me.btnSquirtle.UseVisualStyleBackColor = True
		Me.btnSquirtle.Visible = False
		'
		'btnBulbasaur
		'
		Me.btnBulbasaur.Location = New System.Drawing.Point(325, 294)
		Me.btnBulbasaur.Name = "btnBulbasaur"
		Me.btnBulbasaur.Size = New System.Drawing.Size(75, 23)
		Me.btnBulbasaur.TabIndex = 50
		Me.btnBulbasaur.Text = "Bulbasaur"
		Me.btnBulbasaur.UseVisualStyleBackColor = True
		Me.btnBulbasaur.Visible = False
		'
		'btnCharmander
		'
		Me.btnCharmander.Location = New System.Drawing.Point(523, 294)
		Me.btnCharmander.Name = "btnCharmander"
		Me.btnCharmander.Size = New System.Drawing.Size(75, 23)
		Me.btnCharmander.TabIndex = 51
		Me.btnCharmander.Text = "Charmander"
		Me.btnCharmander.UseVisualStyleBackColor = True
		Me.btnCharmander.Visible = False
		'
		'picBulbasaur
		'
		Me.picBulbasaur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picBulbasaur.Image = Global.Pokeman.My.Resources.Resources.bulbasaur
		Me.picBulbasaur.Location = New System.Drawing.Point(325, 217)
		Me.picBulbasaur.Name = "picBulbasaur"
		Me.picBulbasaur.Size = New System.Drawing.Size(75, 71)
		Me.picBulbasaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picBulbasaur.TabIndex = 52
		Me.picBulbasaur.TabStop = False
		Me.picBulbasaur.Visible = False
		'
		'picCharmander
		'
		Me.picCharmander.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picCharmander.Image = Global.Pokeman.My.Resources.Resources.charmander
		Me.picCharmander.Location = New System.Drawing.Point(523, 217)
		Me.picCharmander.Name = "picCharmander"
		Me.picCharmander.Size = New System.Drawing.Size(75, 71)
		Me.picCharmander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picCharmander.TabIndex = 53
		Me.picCharmander.TabStop = False
		Me.picCharmander.Visible = False
		'
		'picSquirtle
		'
		Me.picSquirtle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picSquirtle.Image = Global.Pokeman.My.Resources.Resources.squirtle
		Me.picSquirtle.Location = New System.Drawing.Point(131, 217)
		Me.picSquirtle.Name = "picSquirtle"
		Me.picSquirtle.Size = New System.Drawing.Size(75, 71)
		Me.picSquirtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picSquirtle.TabIndex = 54
		Me.picSquirtle.TabStop = False
		Me.picSquirtle.Visible = False
		'
		'frmStart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.picSquirtle)
		Me.Controls.Add(Me.picCharmander)
		Me.Controls.Add(Me.picBulbasaur)
		Me.Controls.Add(Me.btnCharmander)
		Me.Controls.Add(Me.btnBulbasaur)
		Me.Controls.Add(Me.btnSquirtle)
		Me.Controls.Add(Me.lblDialogue)
		Me.Controls.Add(Me.PictureBox43)
		Me.Name = "frmStart"
		Me.Text = "frmStart"
		CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picBulbasaur, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCharmander, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSquirtle, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox43 As PictureBox
	Friend WithEvents lblDialogue As Label
	Friend WithEvents btnSquirtle As Button
	Friend WithEvents btnBulbasaur As Button
	Friend WithEvents btnCharmander As Button
	Friend WithEvents picBulbasaur As PictureBox
	Friend WithEvents picCharmander As PictureBox
	Friend WithEvents picSquirtle As PictureBox
End Class
