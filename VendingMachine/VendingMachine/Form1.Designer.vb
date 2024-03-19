<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.QPB = New System.Windows.Forms.PictureBox()
        Me.NPB = New System.Windows.Forms.PictureBox()
        Me.DiPB = New System.Windows.Forms.PictureBox()
        Me.DollarCoin = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        Me.ProductControl16 = New VendingMachine.ProductControl()
        Me.ProductControl15 = New VendingMachine.ProductControl()
        Me.ProductControl14 = New VendingMachine.ProductControl()
        Me.ProductControl13 = New VendingMachine.ProductControl()
        Me.ProductControl12 = New VendingMachine.ProductControl()
        Me.ProductControl11 = New VendingMachine.ProductControl()
        Me.ProductControl10 = New VendingMachine.ProductControl()
        Me.ProductControl9 = New VendingMachine.ProductControl()
        Me.ProductControl8 = New VendingMachine.ProductControl()
        Me.ProductControl7 = New VendingMachine.ProductControl()
        Me.ProductControl6 = New VendingMachine.ProductControl()
        Me.ProductControl5 = New VendingMachine.ProductControl()
        Me.ProductControl4 = New VendingMachine.ProductControl()
        Me.ProductControl3 = New VendingMachine.ProductControl()
        Me.ProductControl2 = New VendingMachine.ProductControl()
        Me.ProductControl1 = New VendingMachine.ProductControl()
        CType(Me.QPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "$0.00"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 480)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 34)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'QPB
        '
        Me.QPB.Image = Global.VendingMachine.My.Resources.Resources.quarter
        Me.QPB.Location = New System.Drawing.Point(736, 84)
        Me.QPB.Name = "QPB"
        Me.QPB.Size = New System.Drawing.Size(100, 66)
        Me.QPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QPB.TabIndex = 9
        Me.QPB.TabStop = False
        Me.QPB.Visible = False
        '
        'NPB
        '
        Me.NPB.Image = Global.VendingMachine.My.Resources.Resources.nickel
        Me.NPB.Location = New System.Drawing.Point(736, 228)
        Me.NPB.Name = "NPB"
        Me.NPB.Size = New System.Drawing.Size(100, 66)
        Me.NPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NPB.TabIndex = 8
        Me.NPB.TabStop = False
        Me.NPB.Visible = False
        '
        'DiPB
        '
        Me.DiPB.Image = Global.VendingMachine.My.Resources.Resources.dimes
        Me.DiPB.Location = New System.Drawing.Point(736, 156)
        Me.DiPB.Name = "DiPB"
        Me.DiPB.Size = New System.Drawing.Size(100, 66)
        Me.DiPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiPB.TabIndex = 7
        Me.DiPB.TabStop = False
        Me.DiPB.Visible = False
        '
        'DollarCoin
        '
        Me.DollarCoin.Image = Global.VendingMachine.My.Resources.Resources.dollar
        Me.DollarCoin.Location = New System.Drawing.Point(736, 12)
        Me.DollarCoin.Name = "DollarCoin"
        Me.DollarCoin.Size = New System.Drawing.Size(100, 66)
        Me.DollarCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarCoin.TabIndex = 6
        Me.DollarCoin.TabStop = False
        Me.DollarCoin.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dollar
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 66)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.VendingMachine.My.Resources.Resources.nickel
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 66)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nickels"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dimes
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Dime"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VendingMachine.My.Resources.Resources.quarter
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quarter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 346)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 33)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(12, 385)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 27
        '
        'ProductPicture
        '
        Me.ProductPicture.Location = New System.Drawing.Point(711, 324)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(125, 134)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPicture.TabIndex = 28
        Me.ProductPicture.TabStop = False
        '
        'ProductControl16
        '
        Me.ProductControl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl16.Location = New System.Drawing.Point(553, 480)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.ProductCount = 5
        Me.ProductControl16.ProductID = "D4"
        Me.ProductControl16.ProductImage = Global.VendingMachine.My.Resources.Resources.rock41
        Me.ProductControl16.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl16.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl16.TabIndex = 25
        '
        'ProductControl15
        '
        Me.ProductControl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl15.Location = New System.Drawing.Point(422, 480)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.ProductCount = 5
        Me.ProductControl15.ProductID = "D3"
        Me.ProductControl15.ProductImage = Global.VendingMachine.My.Resources.Resources.rock3
        Me.ProductControl15.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl15.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl15.TabIndex = 24
        '
        'ProductControl14
        '
        Me.ProductControl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl14.Location = New System.Drawing.Point(291, 480)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.ProductCount = 5
        Me.ProductControl14.ProductID = "D2"
        Me.ProductControl14.ProductImage = Global.VendingMachine.My.Resources.Resources.rock2
        Me.ProductControl14.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl14.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl14.TabIndex = 23
        '
        'ProductControl13
        '
        Me.ProductControl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl13.Location = New System.Drawing.Point(160, 480)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.ProductCount = 2
        Me.ProductControl13.ProductID = "D1"
        Me.ProductControl13.ProductImage = Global.VendingMachine.My.Resources.Resources.rock
        Me.ProductControl13.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl13.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl13.TabIndex = 22
        '
        'ProductControl12
        '
        Me.ProductControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl12.Location = New System.Drawing.Point(553, 324)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.ProductCount = 6
        Me.ProductControl12.ProductID = "C4"
        Me.ProductControl12.ProductImage = Global.VendingMachine.My.Resources.Resources.red41
        Me.ProductControl12.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl12.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl12.TabIndex = 21
        '
        'ProductControl11
        '
        Me.ProductControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl11.Location = New System.Drawing.Point(422, 324)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.ProductCount = 4
        Me.ProductControl11.ProductID = "C3"
        Me.ProductControl11.ProductImage = Global.VendingMachine.My.Resources.Resources.red31
        Me.ProductControl11.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl11.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl11.TabIndex = 20
        '
        'ProductControl10
        '
        Me.ProductControl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl10.Location = New System.Drawing.Point(291, 324)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.ProductCount = 2
        Me.ProductControl10.ProductID = "C2"
        Me.ProductControl10.ProductImage = Global.VendingMachine.My.Resources.Resources.red2
        Me.ProductControl10.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl10.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl10.TabIndex = 19
        '
        'ProductControl9
        '
        Me.ProductControl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl9.Location = New System.Drawing.Point(160, 324)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.ProductCount = 8
        Me.ProductControl9.ProductID = "C1"
        Me.ProductControl9.ProductImage = Global.VendingMachine.My.Resources.Resources.red
        Me.ProductControl9.ProductPrice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ProductControl9.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl9.TabIndex = 18
        '
        'ProductControl8
        '
        Me.ProductControl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl8.Location = New System.Drawing.Point(553, 168)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.ProductCount = 1
        Me.ProductControl8.ProductID = "B4"
        Me.ProductControl8.ProductImage = Global.VendingMachine.My.Resources.Resources.celsius4
        Me.ProductControl8.ProductPrice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl8.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl8.TabIndex = 17
        '
        'ProductControl7
        '
        Me.ProductControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl7.Location = New System.Drawing.Point(422, 168)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.ProductCount = 3
        Me.ProductControl7.ProductID = "B3"
        Me.ProductControl7.ProductImage = Global.VendingMachine.My.Resources.Resources.celsius31
        Me.ProductControl7.ProductPrice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl7.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl7.TabIndex = 16
        '
        'ProductControl6
        '
        Me.ProductControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl6.Location = New System.Drawing.Point(291, 168)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.ProductCount = 5
        Me.ProductControl6.ProductID = "B2"
        Me.ProductControl6.ProductImage = Global.VendingMachine.My.Resources.Resources.celsius2
        Me.ProductControl6.ProductPrice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl6.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl6.TabIndex = 15
        '
        'ProductControl5
        '
        Me.ProductControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl5.Location = New System.Drawing.Point(160, 168)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.ProductCount = 5
        Me.ProductControl5.ProductID = "B1"
        Me.ProductControl5.ProductImage = Global.VendingMachine.My.Resources.Resources.celsius
        Me.ProductControl5.ProductPrice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl5.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl5.TabIndex = 14
        '
        'ProductControl4
        '
        Me.ProductControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl4.Location = New System.Drawing.Point(553, 12)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.ProductCount = 4
        Me.ProductControl4.ProductID = "A4"
        Me.ProductControl4.ProductImage = Global.VendingMachine.My.Resources.Resources.monster41
        Me.ProductControl4.ProductPrice = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.ProductControl4.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl4.TabIndex = 13
        '
        'ProductControl3
        '
        Me.ProductControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl3.Location = New System.Drawing.Point(422, 12)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.ProductCount = 6
        Me.ProductControl3.ProductID = "A3"
        Me.ProductControl3.ProductImage = Global.VendingMachine.My.Resources.Resources.monster3
        Me.ProductControl3.ProductPrice = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.ProductControl3.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl3.TabIndex = 12
        '
        'ProductControl2
        '
        Me.ProductControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl2.Location = New System.Drawing.Point(291, 12)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.ProductCount = 2
        Me.ProductControl2.ProductID = "A2"
        Me.ProductControl2.ProductImage = Global.VendingMachine.My.Resources.Resources.monster2
        Me.ProductControl2.ProductPrice = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.ProductControl2.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl2.TabIndex = 11
        '
        'ProductControl1
        '
        Me.ProductControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl1.Location = New System.Drawing.Point(160, 12)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.ProductCount = 5
        Me.ProductControl1.ProductID = "A1"
        Me.ProductControl1.ProductImage = Global.VendingMachine.My.Resources.Resources.monster
        Me.ProductControl1.ProductPrice = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.ProductControl1.Size = New System.Drawing.Size(125, 150)
        Me.ProductControl1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 648)
        Me.Controls.Add(Me.ProductPicture)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.QPB)
        Me.Controls.Add(Me.NPB)
        Me.Controls.Add(Me.DiPB)
        Me.Controls.Add(Me.DollarCoin)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.QPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarCoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents DollarCoin As PictureBox
    Friend WithEvents DiPB As PictureBox
    Friend WithEvents NPB As PictureBox
    Friend WithEvents QPB As PictureBox
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl5 As ProductControl
    Friend WithEvents ProductControl6 As ProductControl
    Friend WithEvents ProductControl7 As ProductControl
    Friend WithEvents ProductControl8 As ProductControl
    Friend WithEvents ProductControl9 As ProductControl
    Friend WithEvents ProductControl10 As ProductControl
    Friend WithEvents ProductControl11 As ProductControl
    Friend WithEvents ProductControl12 As ProductControl
    Friend WithEvents ProductControl13 As ProductControl
    Friend WithEvents ProductControl14 As ProductControl
    Friend WithEvents ProductControl15 As ProductControl
    Friend WithEvents ProductControl16 As ProductControl
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ProductPicture As PictureBox
End Class
