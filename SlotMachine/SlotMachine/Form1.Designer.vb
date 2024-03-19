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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Reelcontrol3 = New SlotMachine.reelcontrol1()
        Me.Reelcontrol2 = New SlotMachine.reelcontrol1()
        Me.Reelcontrol1 = New SlotMachine.reelcontrol1()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(205, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "$1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(304, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "$5"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(403, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 43)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "$20"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(502, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 43)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "$100"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(381, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "$0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reelcontrol3.insert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Reelcontrol3.itemValue = 0
        Me.Reelcontrol3.Location = New System.Drawing.Point(483, 84)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(148, 148)
        Me.Reelcontrol3.spinTime = 2000
        Me.Reelcontrol3.TabIndex = 4
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reelcontrol2.insert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Reelcontrol2.itemValue = 0
        Me.Reelcontrol2.Location = New System.Drawing.Point(329, 84)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(148, 148)
        Me.Reelcontrol2.spinTime = 2000
        Me.Reelcontrol2.TabIndex = 3
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reelcontrol1.insert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Reelcontrol1.itemValue = 0
        Me.Reelcontrol1.Location = New System.Drawing.Point(173, 84)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol1.spinTime = 2000
        Me.Reelcontrol1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reelcontrol1 As reelcontrol1
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Reelcontrol2 As reelcontrol1
    Friend WithEvents Reelcontrol3 As reelcontrol1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
