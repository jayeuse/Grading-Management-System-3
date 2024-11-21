<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonFaculty = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Volte Rounded Semibold", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Who are you logging in for?"
        '
        'buttonStudent
        '
        Me.buttonStudent.Animated = True
        Me.buttonStudent.AutoRoundedCorners = True
        Me.buttonStudent.BackColor = System.Drawing.Color.Transparent
        Me.buttonStudent.BorderRadius = 22
        Me.buttonStudent.CheckedState.Parent = Me.buttonStudent
        Me.buttonStudent.CustomImages.Parent = Me.buttonStudent
        Me.buttonStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.buttonStudent.Font = New System.Drawing.Font("Celias", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonStudent.ForeColor = System.Drawing.Color.Black
        Me.buttonStudent.HoverState.Parent = Me.buttonStudent
        Me.buttonStudent.Location = New System.Drawing.Point(493, 107)
        Me.buttonStudent.Name = "buttonStudent"
        Me.buttonStudent.PressedDepth = 0
        Me.buttonStudent.ShadowDecoration.Parent = Me.buttonStudent
        Me.buttonStudent.Size = New System.Drawing.Size(256, 47)
        Me.buttonStudent.TabIndex = 1
        Me.buttonStudent.Text = "I am a Student"
        '
        'buttonFaculty
        '
        Me.buttonFaculty.Animated = True
        Me.buttonFaculty.AutoRoundedCorners = True
        Me.buttonFaculty.BackColor = System.Drawing.Color.Transparent
        Me.buttonFaculty.BorderRadius = 22
        Me.buttonFaculty.CheckedState.Parent = Me.buttonFaculty
        Me.buttonFaculty.CustomImages.Parent = Me.buttonFaculty
        Me.buttonFaculty.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.buttonFaculty.Font = New System.Drawing.Font("Celias", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonFaculty.ForeColor = System.Drawing.Color.Black
        Me.buttonFaculty.HoverState.Parent = Me.buttonFaculty
        Me.buttonFaculty.Location = New System.Drawing.Point(493, 189)
        Me.buttonFaculty.Name = "buttonFaculty"
        Me.buttonFaculty.PressedDepth = 0
        Me.buttonFaculty.ShadowDecoration.Parent = Me.buttonFaculty
        Me.buttonFaculty.Size = New System.Drawing.Size(256, 47)
        Me.buttonFaculty.TabIndex = 2
        Me.buttonFaculty.Text = "I am a part of School Faculty"
        '
        'buttonAdmin
        '
        Me.buttonAdmin.Animated = True
        Me.buttonAdmin.AutoRoundedCorners = True
        Me.buttonAdmin.BackColor = System.Drawing.Color.Transparent
        Me.buttonAdmin.BorderRadius = 22
        Me.buttonAdmin.CheckedState.Parent = Me.buttonAdmin
        Me.buttonAdmin.CustomImages.Parent = Me.buttonAdmin
        Me.buttonAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.buttonAdmin.Font = New System.Drawing.Font("Celias", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdmin.ForeColor = System.Drawing.Color.Black
        Me.buttonAdmin.HoverState.Parent = Me.buttonAdmin
        Me.buttonAdmin.Location = New System.Drawing.Point(493, 269)
        Me.buttonAdmin.Name = "buttonAdmin"
        Me.buttonAdmin.PressedDepth = 0
        Me.buttonAdmin.ShadowDecoration.Parent = Me.buttonAdmin
        Me.buttonAdmin.Size = New System.Drawing.Size(256, 47)
        Me.buttonAdmin.TabIndex = 3
        Me.buttonAdmin.Text = "I am an Admin"
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 476)
        Me.Controls.Add(Me.buttonAdmin)
        Me.Controls.Add(Me.buttonFaculty)
        Me.Controls.Add(Me.buttonStudent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLogin"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents buttonAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonFaculty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
