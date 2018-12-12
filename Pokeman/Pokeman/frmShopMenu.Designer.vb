<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopMenu
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
		Me.lblBallBuy = New System.Windows.Forms.Label()
		Me.lblLotionBuy = New System.Windows.Forms.Label()
		Me.lblMedpackBuy = New System.Windows.Forms.Label()
		Me.lblFeastBuy = New System.Windows.Forms.Label()
		Me.btnBallBuy = New System.Windows.Forms.Button()
		Me.btnLotionBuy = New System.Windows.Forms.Button()
		Me.btmMedpackBuy = New System.Windows.Forms.Button()
		Me.btnFeastBuy = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblBallBuy
		'
		Me.lblBallBuy.AutoSize = True
		Me.lblBallBuy.Location = New System.Drawing.Point(122, 69)
		Me.lblBallBuy.Name = "lblBallBuy"
		Me.lblBallBuy.Size = New System.Drawing.Size(108, 13)
		Me.lblBallBuy.TabIndex = 0
		Me.lblBallBuy.Text = "Pokeball: $something"
		'
		'lblLotionBuy
		'
		Me.lblLotionBuy.AutoSize = True
		Me.lblLotionBuy.Location = New System.Drawing.Point(122, 111)
		Me.lblLotionBuy.Name = "lblLotionBuy"
		Me.lblLotionBuy.Size = New System.Drawing.Size(121, 13)
		Me.lblLotionBuy.TabIndex = 1
		Me.lblLotionBuy.Text = "Little Lotion: $something"
		'
		'lblMedpackBuy
		'
		Me.lblMedpackBuy.AutoSize = True
		Me.lblMedpackBuy.Location = New System.Drawing.Point(122, 153)
		Me.lblMedpackBuy.Name = "lblMedpackBuy"
		Me.lblMedpackBuy.Size = New System.Drawing.Size(152, 13)
		Me.lblMedpackBuy.TabIndex = 2
		Me.lblMedpackBuy.Text = "Medium Medpack: $something"
		'
		'lblFeastBuy
		'
		Me.lblFeastBuy.AutoSize = True
		Me.lblFeastBuy.Location = New System.Drawing.Point(122, 195)
		Me.lblFeastBuy.Name = "lblFeastBuy"
		Me.lblFeastBuy.Size = New System.Drawing.Size(112, 13)
		Me.lblFeastBuy.TabIndex = 3
		Me.lblFeastBuy.Text = "Full Feast: $something"
		'
		'btnBallBuy
		'
		Me.btnBallBuy.Location = New System.Drawing.Point(311, 64)
		Me.btnBallBuy.Name = "btnBallBuy"
		Me.btnBallBuy.Size = New System.Drawing.Size(75, 23)
		Me.btnBallBuy.TabIndex = 4
		Me.btnBallBuy.Text = "Buy"
		Me.btnBallBuy.UseVisualStyleBackColor = True
		'
		'btnLotionBuy
		'
		Me.btnLotionBuy.Location = New System.Drawing.Point(311, 106)
		Me.btnLotionBuy.Name = "btnLotionBuy"
		Me.btnLotionBuy.Size = New System.Drawing.Size(75, 23)
		Me.btnLotionBuy.TabIndex = 5
		Me.btnLotionBuy.Text = "Buy"
		Me.btnLotionBuy.UseVisualStyleBackColor = True
		'
		'btmMedpackBuy
		'
		Me.btmMedpackBuy.Location = New System.Drawing.Point(311, 148)
		Me.btmMedpackBuy.Name = "btmMedpackBuy"
		Me.btmMedpackBuy.Size = New System.Drawing.Size(75, 23)
		Me.btmMedpackBuy.TabIndex = 6
		Me.btmMedpackBuy.Text = "Buy"
		Me.btmMedpackBuy.UseVisualStyleBackColor = True
		'
		'btnFeastBuy
		'
		Me.btnFeastBuy.Location = New System.Drawing.Point(311, 190)
		Me.btnFeastBuy.Name = "btnFeastBuy"
		Me.btnFeastBuy.Size = New System.Drawing.Size(75, 23)
		Me.btnFeastBuy.TabIndex = 7
		Me.btnFeastBuy.Text = "Buy"
		Me.btnFeastBuy.UseVisualStyleBackColor = True
		'
		'frmShopMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(617, 274)
		Me.Controls.Add(Me.btnFeastBuy)
		Me.Controls.Add(Me.btmMedpackBuy)
		Me.Controls.Add(Me.btnLotionBuy)
		Me.Controls.Add(Me.btnBallBuy)
		Me.Controls.Add(Me.lblFeastBuy)
		Me.Controls.Add(Me.lblMedpackBuy)
		Me.Controls.Add(Me.lblLotionBuy)
		Me.Controls.Add(Me.lblBallBuy)
		Me.Name = "frmShopMenu"
		Me.Text = "ShopMenu"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblBallBuy As Label
	Friend WithEvents lblLotionBuy As Label
	Friend WithEvents lblMedpackBuy As Label
	Friend WithEvents lblFeastBuy As Label
	Friend WithEvents btnBallBuy As Button
	Friend WithEvents btnLotionBuy As Button
	Friend WithEvents btmMedpackBuy As Button
	Friend WithEvents btnFeastBuy As Button
End Class
