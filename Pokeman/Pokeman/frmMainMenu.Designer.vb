<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
		Me.btnBattle = New System.Windows.Forms.Button()
		Me.btnBox = New System.Windows.Forms.Button()
		Me.lblPokeman1 = New System.Windows.Forms.Label()
		Me.lblPokeman2 = New System.Windows.Forms.Label()
		Me.lblPokeman3 = New System.Windows.Forms.Label()
		Me.lblPokeman4 = New System.Windows.Forms.Label()
		Me.lblPokeman5 = New System.Windows.Forms.Label()
		Me.lblPokeman6 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBox11 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnBattle
		'
		Me.btnBattle.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBattle.Location = New System.Drawing.Point(339, 223)
		Me.btnBattle.Name = "btnBattle"
		Me.btnBattle.Size = New System.Drawing.Size(110, 56)
		Me.btnBattle.TabIndex = 0
		Me.btnBattle.Text = "Battle!"
		Me.btnBattle.UseVisualStyleBackColor = True
		'
		'btnBox
		'
		Me.btnBox.Location = New System.Drawing.Point(614, 286)
		Me.btnBox.Name = "btnBox"
		Me.btnBox.Size = New System.Drawing.Size(110, 36)
		Me.btnBox.TabIndex = 2
		Me.btnBox.Text = "Pokemon Box"
		Me.btnBox.UseVisualStyleBackColor = True
		'
		'lblPokeman1
		'
		Me.lblPokeman1.AutoSize = True
		Me.lblPokeman1.Location = New System.Drawing.Point(74, 261)
		Me.lblPokeman1.Name = "lblPokeman1"
		Me.lblPokeman1.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman1.TabIndex = 3
		Me.lblPokeman1.Text = "Pokeman 1"
		'
		'lblPokeman2
		'
		Me.lblPokeman2.AutoSize = True
		Me.lblPokeman2.Location = New System.Drawing.Point(74, 286)
		Me.lblPokeman2.Name = "lblPokeman2"
		Me.lblPokeman2.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman2.TabIndex = 4
		Me.lblPokeman2.Text = "Pokeman 2"
		'
		'lblPokeman3
		'
		Me.lblPokeman3.AutoSize = True
		Me.lblPokeman3.Location = New System.Drawing.Point(74, 312)
		Me.lblPokeman3.Name = "lblPokeman3"
		Me.lblPokeman3.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman3.TabIndex = 5
		Me.lblPokeman3.Text = "Pokeman 3"
		'
		'lblPokeman4
		'
		Me.lblPokeman4.AutoSize = True
		Me.lblPokeman4.Location = New System.Drawing.Point(74, 339)
		Me.lblPokeman4.Name = "lblPokeman4"
		Me.lblPokeman4.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman4.TabIndex = 6
		Me.lblPokeman4.Text = "Pokeman 4"
		'
		'lblPokeman5
		'
		Me.lblPokeman5.AutoSize = True
		Me.lblPokeman5.Location = New System.Drawing.Point(74, 365)
		Me.lblPokeman5.Name = "lblPokeman5"
		Me.lblPokeman5.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman5.TabIndex = 7
		Me.lblPokeman5.Text = "Pokeman 5"
		'
		'lblPokeman6
		'
		Me.lblPokeman6.AutoSize = True
		Me.lblPokeman6.Location = New System.Drawing.Point(74, 391)
		Me.lblPokeman6.Name = "lblPokeman6"
		Me.lblPokeman6.Size = New System.Drawing.Size(61, 13)
		Me.lblPokeman6.TabIndex = 8
		Me.lblPokeman6.Text = "Pokeman 6"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 1
		'
		'PictureBox11
		'
		Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Default
		Me.PictureBox11.Image = Global.Pokeman.My.Resources.Resources.Pokemon_logo_497D61B223_seeklogo_com
		Me.PictureBox11.Location = New System.Drawing.Point(201, 12)
		Me.PictureBox11.Name = "PictureBox11"
		Me.PictureBox11.Size = New System.Drawing.Size(420, 188)
		Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox11.TabIndex = 58
		Me.PictureBox11.TabStop = False
		'
		'frmMainMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.PictureBox11)
		Me.Controls.Add(Me.lblPokeman6)
		Me.Controls.Add(Me.lblPokeman5)
		Me.Controls.Add(Me.lblPokeman4)
		Me.Controls.Add(Me.lblPokeman3)
		Me.Controls.Add(Me.lblPokeman2)
		Me.Controls.Add(Me.lblPokeman1)
		Me.Controls.Add(Me.btnBox)
		Me.Controls.Add(Me.btnBattle)
		Me.Name = "frmMainMenu"
		Me.Text = "Form1"
		CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnBattle As Button
	Friend WithEvents btnBox As Button
	Friend WithEvents lblPokeman1 As Label
	Friend WithEvents lblPokeman2 As Label
	Friend WithEvents lblPokeman3 As Label
	Friend WithEvents lblPokeman4 As Label
	Friend WithEvents lblPokeman5 As Label
	Friend WithEvents lblPokeman6 As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents PictureBox11 As PictureBox
End Class
