<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlayerPB = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Mover4 = New Game.mover()
        Me.Mover3 = New Game.mover()
        Me.Mover2 = New Game.mover()
        Me.Mover1 = New Game.mover()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 30
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 30
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 30
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 30
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 30
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 416)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(708, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Points"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(708, 392)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(26, 29)
        Me.scoreLabel.TabIndex = 17
        Me.scoreLabel.Text = "0"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Silver
        Me.PictureBox8.Location = New System.Drawing.Point(399, 288)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(96, 25)
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Black
        Me.PictureBox7.Location = New System.Drawing.Point(504, 275)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "restart"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(201, 49)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "restart"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(716, 169)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "gameover"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox5.Image = Global.Game.My.Resources.Resources.coin
        Me.PictureBox5.Location = New System.Drawing.Point(27, 185)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 59)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "point"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox3.Location = New System.Drawing.Point(66, 64)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(220, 25)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox2.Location = New System.Drawing.Point(499, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 25)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(22, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 26)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PlayerPB
        '
        Me.PlayerPB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PlayerPB.Image = CType(resources.GetObject("PlayerPB.Image"), System.Drawing.Image)
        Me.PlayerPB.Location = New System.Drawing.Point(12, 303)
        Me.PlayerPB.Name = "PlayerPB"
        Me.PlayerPB.Size = New System.Drawing.Size(71, 107)
        Me.PlayerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerPB.TabIndex = 0
        Me.PlayerPB.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackgroundImage = CType(resources.GetObject("picGround.BackgroundImage"), System.Drawing.Image)
        Me.picGround.Image = CType(resources.GetObject("picGround.Image"), System.Drawing.Image)
        Me.picGround.Location = New System.Drawing.Point(2, 363)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(795, 88)
        Me.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackgroundImage = CType(resources.GetObject("picAir.BackgroundImage"), System.Drawing.Image)
        Me.picAir.Location = New System.Drawing.Point(2, -4)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(795, 417)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox9.Image = Global.Game.My.Resources.Resources.coin
        Me.PictureBox9.Location = New System.Drawing.Point(66, 12)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(54, 59)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "point"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox10.Image = Global.Game.My.Resources.Resources.coin
        Me.PictureBox10.Location = New System.Drawing.Point(721, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(54, 59)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 19
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "point"
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Silver
        Me.Mover4.interval = 30
        Me.Mover4.Location = New System.Drawing.Point(399, 290)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(96, 25)
        Me.Mover4.speed = 15
        Me.Mover4.sprite = Me.PictureBox7
        Me.Mover4.TabIndex = 13
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.DarkGray
        Me.Mover3.interval = 40
        Me.Mover3.Location = New System.Drawing.Point(66, 64)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(220, 23)
        Me.Mover3.speed = 15
        Me.Mover3.sprite = Me.PictureBox6
        Me.Mover3.TabIndex = 11
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Silver
        Me.Mover2.interval = 60
        Me.Mover2.Location = New System.Drawing.Point(633, 184)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(111, 24)
        Me.Mover2.speed = 15
        Me.Mover2.sprite = Me.PictureBox4
        Me.Mover2.TabIndex = 10
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Silver
        Me.Mover1.interval = 30
        Me.Mover1.Location = New System.Drawing.Point(27, 200)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(220, 23)
        Me.Mover1.speed = 15
        Me.Mover1.sprite = Me.PictureBox5
        Me.Mover1.TabIndex = 8
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PlayerPB)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picAir)
        Me.Name = "frmGame"
        Me.Tag = "bound"
        Me.Text = "Form1"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerPB As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents picAir As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover2 As mover
    Friend WithEvents Mover3 As mover
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Mover4 As mover
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
End Class
