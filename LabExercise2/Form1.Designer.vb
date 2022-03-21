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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdditionBtn = New System.Windows.Forms.Button()
        Me.MultiplicationBtn = New System.Windows.Forms.Button()
        Me.DivisionBtn = New System.Windows.Forms.Button()
        Me.SubtractBtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SupBtn = New System.Windows.Forms.Button()
        Me.IgnoredBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OperatorLabel = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Operator2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Operator1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simple Calculator"
        '
        'AdditionBtn
        '
        Me.AdditionBtn.Location = New System.Drawing.Point(8, 25)
        Me.AdditionBtn.Name = "AdditionBtn"
        Me.AdditionBtn.Size = New System.Drawing.Size(75, 36)
        Me.AdditionBtn.TabIndex = 0
        Me.AdditionBtn.Text = "+"
        Me.AdditionBtn.UseVisualStyleBackColor = True
        '
        'MultiplicationBtn
        '
        Me.MultiplicationBtn.Location = New System.Drawing.Point(8, 67)
        Me.MultiplicationBtn.Name = "MultiplicationBtn"
        Me.MultiplicationBtn.Size = New System.Drawing.Size(75, 36)
        Me.MultiplicationBtn.TabIndex = 0
        Me.MultiplicationBtn.Text = "×"
        Me.MultiplicationBtn.UseVisualStyleBackColor = True
        '
        'DivisionBtn
        '
        Me.DivisionBtn.Location = New System.Drawing.Point(89, 67)
        Me.DivisionBtn.Name = "DivisionBtn"
        Me.DivisionBtn.Size = New System.Drawing.Size(75, 36)
        Me.DivisionBtn.TabIndex = 1
        Me.DivisionBtn.Text = "÷"
        Me.DivisionBtn.UseVisualStyleBackColor = True
        '
        'SubtractBtn
        '
        Me.SubtractBtn.Location = New System.Drawing.Point(89, 25)
        Me.SubtractBtn.Name = "SubtractBtn"
        Me.SubtractBtn.Size = New System.Drawing.Size(75, 36)
        Me.SubtractBtn.TabIndex = 2
        Me.SubtractBtn.Text = "-"
        Me.SubtractBtn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(156, 36)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Mod"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.SupBtn)
        Me.GroupBox1.Controls.Add(Me.IgnoredBtn)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.DivisionBtn)
        Me.GroupBox1.Controls.Add(Me.AdditionBtn)
        Me.GroupBox1.Controls.Add(Me.SubtractBtn)
        Me.GroupBox1.Controls.Add(Me.MultiplicationBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 215)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operators"
        '
        'SupBtn
        '
        Me.SupBtn.Location = New System.Drawing.Point(89, 109)
        Me.SupBtn.Name = "SupBtn"
        Me.SupBtn.Size = New System.Drawing.Size(75, 36)
        Me.SupBtn.TabIndex = 4
        Me.SupBtn.Text = "^"
        Me.SupBtn.UseVisualStyleBackColor = True
        '
        'IgnoredBtn
        '
        Me.IgnoredBtn.Location = New System.Drawing.Point(8, 109)
        Me.IgnoredBtn.Name = "IgnoredBtn"
        Me.IgnoredBtn.Size = New System.Drawing.Size(75, 36)
        Me.IgnoredBtn.TabIndex = 3
        Me.IgnoredBtn.Text = "\"
        Me.IgnoredBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.OperatorLabel)
        Me.GroupBox2.Controls.Add(Me.ResultBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Operator2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Operator1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(183, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 215)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation"
        '
        'OperatorLabel
        '
        Me.OperatorLabel.Location = New System.Drawing.Point(122, 68)
        Me.OperatorLabel.Name = "OperatorLabel"
        Me.OperatorLabel.ReadOnly = True
        Me.OperatorLabel.Size = New System.Drawing.Size(47, 29)
        Me.OperatorLabel.TabIndex = 7
        Me.OperatorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(94, 138)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(100, 29)
        Me.ResultBox.TabIndex = 6
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Result"
        '
        'Operator2
        '
        Me.Operator2.Location = New System.Drawing.Point(94, 103)
        Me.Operator2.Name = "Operator2"
        Me.Operator2.Size = New System.Drawing.Size(100, 29)
        Me.Operator2.TabIndex = 3
        Me.Operator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operator 2"
        '
        'Operator1
        '
        Me.Operator1.Location = New System.Drawing.Point(94, 33)
        Me.Operator1.Name = "Operator1"
        Me.Operator1.Size = New System.Drawing.Size(100, 29)
        Me.Operator1.TabIndex = 1
        Me.Operator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Operator 1"
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(309, 254)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 36)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(228, 254)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 36)
        Me.ClearBtn.TabIndex = 0
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(390, 297)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AdditionBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DivisionBtn As Button
    Friend WithEvents SubtractBtn As Button
    Friend WithEvents MultiplicationBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OperatorLabel As TextBox
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Operator2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Operator1 As TextBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents SupBtn As Button
    Friend WithEvents IgnoredBtn As Button
End Class
