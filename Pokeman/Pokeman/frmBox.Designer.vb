<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBox
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
		Me.lblMedpack = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblMedpack
		'
		Me.lblMedpack.AutoSize = True
		Me.lblMedpack.Location = New System.Drawing.Point(60, 66)
		Me.lblMedpack.Name = "lblMedpack"
		Me.lblMedpack.Size = New System.Drawing.Size(114, 13)
		Me.lblMedpack.TabIndex = 13
		Me.lblMedpack.Text = "# of Medium Medpack"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(60, 79)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(114, 13)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "# of Medium Medpack"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(60, 105)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(114, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "# of Medium Medpack"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(60, 131)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(114, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "# of Medium Medpack"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(60, 92)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(114, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "# of Medium Medpack"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(60, 118)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(114, 13)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "# of Medium Medpack"
		'
		'frmBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(613, 279)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblMedpack)
		Me.Name = "frmBox"
		Me.Text = "frmBox"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblMedpack As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
End Class
