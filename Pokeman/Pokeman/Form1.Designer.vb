<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblEHp = New System.Windows.Forms.Label()
        Me.lblEType = New System.Windows.Forms.Label()
        Me.lblEName = New System.Windows.Forms.Label()
        Me.lblYHp = New System.Windows.Forms.Label()
        Me.lblYType = New System.Windows.Forms.Label()
        Me.lblYName = New System.Windows.Forms.Label()
        Me.picEPokemon = New System.Windows.Forms.PictureBox()
        Me.picYPokemon = New System.Windows.Forms.PictureBox()
        Me.btnFF = New System.Windows.Forms.Button()
        Me.btnMM = New System.Windows.Forms.Button()
        Me.btnLL = New System.Windows.Forms.Button()
        Me.btnPokeball = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMove4 = New System.Windows.Forms.Button()
        Me.btnMove3 = New System.Windows.Forms.Button()
        Me.btnMove2 = New System.Windows.Forms.Button()
        Me.btnMove1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ydamage = New System.Windows.Forms.Timer(Me.components)
        Me.edamage = New System.Windows.Forms.Timer(Me.components)
        Me.yspec = New System.Windows.Forms.Timer(Me.components)
        Me.espec = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picEPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblEHp
        '
        Me.lblEHp.AutoSize = True
        Me.lblEHp.Location = New System.Drawing.Point(36, 89)
        Me.lblEHp.Name = "lblEHp"
        Me.lblEHp.Size = New System.Drawing.Size(63, 13)
        Me.lblEHp.TabIndex = 41
        Me.lblEHp.Text = "Hp/Max Hp"
        '
        'lblEType
        '
        Me.lblEType.AutoSize = True
        Me.lblEType.Location = New System.Drawing.Point(36, 64)
        Me.lblEType.Name = "lblEType"
        Me.lblEType.Size = New System.Drawing.Size(31, 13)
        Me.lblEType.TabIndex = 40
        Me.lblEType.Text = "Type"
        '
        'lblEName
        '
        Me.lblEName.AutoSize = True
        Me.lblEName.Location = New System.Drawing.Point(36, 38)
        Me.lblEName.Name = "lblEName"
        Me.lblEName.Size = New System.Drawing.Size(35, 13)
        Me.lblEName.TabIndex = 39
        Me.lblEName.Text = "Name"
        '
        'lblYHp
        '
        Me.lblYHp.AutoSize = True
        Me.lblYHp.Location = New System.Drawing.Point(465, 325)
        Me.lblYHp.Name = "lblYHp"
        Me.lblYHp.Size = New System.Drawing.Size(63, 13)
        Me.lblYHp.TabIndex = 38
        Me.lblYHp.Text = "Hp/Max Hp"
        '
        'lblYType
        '
        Me.lblYType.AutoSize = True
        Me.lblYType.Location = New System.Drawing.Point(465, 300)
        Me.lblYType.Name = "lblYType"
        Me.lblYType.Size = New System.Drawing.Size(31, 13)
        Me.lblYType.TabIndex = 37
        Me.lblYType.Text = "Type"
        '
        'lblYName
        '
        Me.lblYName.AutoSize = True
        Me.lblYName.Location = New System.Drawing.Point(465, 274)
        Me.lblYName.Name = "lblYName"
        Me.lblYName.Size = New System.Drawing.Size(35, 13)
        Me.lblYName.TabIndex = 36
        Me.lblYName.Text = "Name"
        '
        'picEPokemon
        '
        Me.picEPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEPokemon.Image = Global.Pokeman.My.Resources.Resources.CharmanderF
        Me.picEPokemon.Location = New System.Drawing.Point(555, 38)
        Me.picEPokemon.Name = "picEPokemon"
        Me.picEPokemon.Size = New System.Drawing.Size(164, 137)
        Me.picEPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEPokemon.TabIndex = 35
        Me.picEPokemon.TabStop = False
        '
        'picYPokemon
        '
        Me.picYPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picYPokemon.Image = Global.Pokeman.My.Resources.Resources.OnixB
        Me.picYPokemon.Location = New System.Drawing.Point(77, 255)
        Me.picYPokemon.Name = "picYPokemon"
        Me.picYPokemon.Size = New System.Drawing.Size(246, 212)
        Me.picYPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYPokemon.TabIndex = 34
        Me.picYPokemon.TabStop = False
        '
        'btnFF
        '
        Me.btnFF.Location = New System.Drawing.Point(19, 578)
        Me.btnFF.Name = "btnFF"
        Me.btnFF.Size = New System.Drawing.Size(102, 22)
        Me.btnFF.TabIndex = 33
        Me.btnFF.Text = "Full Feast"
        Me.btnFF.UseVisualStyleBackColor = True
        '
        'btnMM
        '
        Me.btnMM.Location = New System.Drawing.Point(19, 552)
        Me.btnMM.Name = "btnMM"
        Me.btnMM.Size = New System.Drawing.Size(102, 22)
        Me.btnMM.TabIndex = 32
        Me.btnMM.Text = "Medium Medpack"
        Me.btnMM.UseVisualStyleBackColor = True
        '
        'btnLL
        '
        Me.btnLL.Location = New System.Drawing.Point(19, 524)
        Me.btnLL.Name = "btnLL"
        Me.btnLL.Size = New System.Drawing.Size(102, 22)
        Me.btnLL.TabIndex = 31
        Me.btnLL.Text = "Little Lotion"
        Me.btnLL.UseVisualStyleBackColor = True
        '
        'btnPokeball
        '
        Me.btnPokeball.Location = New System.Drawing.Point(19, 473)
        Me.btnPokeball.Name = "btnPokeball"
        Me.btnPokeball.Size = New System.Drawing.Size(102, 36)
        Me.btnPokeball.TabIndex = 30
        Me.btnPokeball.Text = "Pokeball"
        Me.btnPokeball.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(614, 573)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 573)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(614, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'btnMove4
        '
        Me.btnMove4.Location = New System.Drawing.Point(617, 534)
        Me.btnMove4.Name = "btnMove4"
        Me.btnMove4.Size = New System.Drawing.Size(102, 36)
        Me.btnMove4.TabIndex = 25
        Me.btnMove4.Text = "Move 4"
        Me.btnMove4.UseVisualStyleBackColor = True
        '
        'btnMove3
        '
        Me.btnMove3.Location = New System.Drawing.Point(428, 534)
        Me.btnMove3.Name = "btnMove3"
        Me.btnMove3.Size = New System.Drawing.Size(102, 36)
        Me.btnMove3.TabIndex = 24
        Me.btnMove3.Text = "Move 3"
        Me.btnMove3.UseVisualStyleBackColor = True
        '
        'btnMove2
        '
        Me.btnMove2.Location = New System.Drawing.Point(617, 473)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(102, 36)
        Me.btnMove2.TabIndex = 23
        Me.btnMove2.Text = "Move 2"
        Me.btnMove2.UseVisualStyleBackColor = True
        '
        'btnMove1
        '
        Me.btnMove1.Location = New System.Drawing.Point(428, 473)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(102, 36)
        Me.btnMove1.TabIndex = 22
        Me.btnMove1.Text = "Move 1"
        Me.btnMove1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(330, 631)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Label7"
        '
        'ydamage
        '
        Me.ydamage.Interval = 300
        '
        'edamage
        '
        Me.edamage.Interval = 300
        '
        'yspec
        '
        Me.yspec.Interval = 300
        '
        'espec
        '
        Me.espec.Interval = 300
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 693)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEHp)
        Me.Controls.Add(Me.lblEType)
        Me.Controls.Add(Me.lblEName)
        Me.Controls.Add(Me.lblYHp)
        Me.Controls.Add(Me.lblYType)
        Me.Controls.Add(Me.lblYName)
        Me.Controls.Add(Me.picEPokemon)
        Me.Controls.Add(Me.picYPokemon)
        Me.Controls.Add(Me.btnFF)
        Me.Controls.Add(Me.btnMM)
        Me.Controls.Add(Me.btnLL)
        Me.Controls.Add(Me.btnPokeball)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMove4)
        Me.Controls.Add(Me.btnMove3)
        Me.Controls.Add(Me.btnMove2)
        Me.Controls.Add(Me.btnMove1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picEPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblEHp As Label
    Friend WithEvents lblEType As Label
    Friend WithEvents lblEName As Label
    Friend WithEvents lblYHp As Label
    Friend WithEvents lblYType As Label
    Friend WithEvents lblYName As Label
    Friend WithEvents picEPokemon As PictureBox
    Friend WithEvents picYPokemon As PictureBox
    Friend WithEvents btnFF As Button
    Friend WithEvents btnMM As Button
    Friend WithEvents btnLL As Button
    Friend WithEvents btnPokeball As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMove4 As Button
    Friend WithEvents btnMove3 As Button
    Friend WithEvents btnMove2 As Button
    Friend WithEvents btnMove1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ydamage As Timer
    Friend WithEvents edamage As Timer
    Friend WithEvents yspec As Timer
    Friend WithEvents espec As Timer
End Class
