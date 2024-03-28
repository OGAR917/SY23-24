<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shelby
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
        Me.termTb = New System.Windows.Forms.TextBox()
        Me.montlyPayTb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.aprTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.engine = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.msrpL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'termTb
        '
        Me.termTb.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termTb.Location = New System.Drawing.Point(583, 73)
        Me.termTb.Name = "termTb"
        Me.termTb.Size = New System.Drawing.Size(100, 31)
        Me.termTb.TabIndex = 52
        '
        'montlyPayTb
        '
        Me.montlyPayTb.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montlyPayTb.Location = New System.Drawing.Point(621, 163)
        Me.montlyPayTb.Multiline = True
        Me.montlyPayTb.Name = "montlyPayTb"
        Me.montlyPayTb.ReadOnly = True
        Me.montlyPayTb.Size = New System.Drawing.Size(100, 27)
        Me.montlyPayTb.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 27)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Payment"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(719, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 32)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'aprTb
        '
        Me.aprTb.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aprTb.Location = New System.Drawing.Point(583, 115)
        Me.aprTb.Name = "aprTb"
        Me.aprTb.Size = New System.Drawing.Size(100, 31)
        Me.aprTb.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(501, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 27)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "APR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 27)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Term"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(491, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(353, 27)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Calculate Monthly Payment"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(330, 454)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(242, 72)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "7-Speed Automatic 5.2L V8"
        '
        'engine
        '
        Me.engine.AutoSize = True
        Me.engine.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engine.Location = New System.Drawing.Point(404, 430)
        Me.engine.Name = "engine"
        Me.engine.Size = New System.Drawing.Size(74, 21)
        Me.engine.TabIndex = 43
        Me.engine.Text = "Engine"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Cars.My.Resources.Resources.engine
        Me.PictureBox4.Location = New System.Drawing.Point(381, 348)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(145, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "N/A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Mileage"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Cars.My.Resources.Resources.miles
        Me.PictureBox3.Location = New System.Drawing.Point(187, 348)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(144, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 24)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "12 city/ 18 hwy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fuel Economy"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cars.My.Resources.Resources.gaspump
        Me.PictureBox2.Location = New System.Drawing.Point(53, 338)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(95, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'msrpL
        '
        Me.msrpL.AutoSize = True
        Me.msrpL.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msrpL.Location = New System.Drawing.Point(339, 312)
        Me.msrpL.Name = "msrpL"
        Me.msrpL.Size = New System.Drawing.Size(0, 33)
        Me.msrpL.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 33)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "MSRP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Shelby GT500"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cars.My.Resources.Resources.mustang
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(673, 418)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(227, 33)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "(602) 999 - 9999"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(673, 455)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(293, 33)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Call for more info"
        '
        'shelby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 550)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.termTb)
        Me.Controls.Add(Me.montlyPayTb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.aprTb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.engine)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.msrpL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "shelby"
        Me.Text = "shelby"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents termTb As TextBox
    Friend WithEvents montlyPayTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents aprTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents engine As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents msrpL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
