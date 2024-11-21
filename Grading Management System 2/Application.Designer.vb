<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formApplication
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.buttonAboutUs = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.panelDesktop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.buttonAboutUs)
        Me.Guna2Panel1.Controls.Add(Me.buttonLogin)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1200, 97)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1157, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(35, 21)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'buttonAboutUs
        '
        Me.buttonAboutUs.CheckedState.Parent = Me.buttonAboutUs
        Me.buttonAboutUs.CustomImages.Parent = Me.buttonAboutUs
        Me.buttonAboutUs.FillColor = System.Drawing.Color.Transparent
        Me.buttonAboutUs.Font = New System.Drawing.Font("Celias", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAboutUs.ForeColor = System.Drawing.Color.Black
        Me.buttonAboutUs.HoverState.Parent = Me.buttonAboutUs
        Me.buttonAboutUs.Location = New System.Drawing.Point(1037, 25)
        Me.buttonAboutUs.Name = "buttonAboutUs"
        Me.buttonAboutUs.ShadowDecoration.Parent = Me.buttonAboutUs
        Me.buttonAboutUs.Size = New System.Drawing.Size(112, 45)
        Me.buttonAboutUs.TabIndex = 5
        Me.buttonAboutUs.Text = "About us"
        '
        'buttonLogin
        '
        Me.buttonLogin.CheckedState.Parent = Me.buttonLogin
        Me.buttonLogin.CustomImages.Parent = Me.buttonLogin
        Me.buttonLogin.FillColor = System.Drawing.Color.Transparent
        Me.buttonLogin.Font = New System.Drawing.Font("Celias", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogin.ForeColor = System.Drawing.Color.Black
        Me.buttonLogin.HoverState.Parent = Me.buttonLogin
        Me.buttonLogin.Location = New System.Drawing.Point(952, 25)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.ShadowDecoration.Parent = Me.buttonLogin
        Me.buttonLogin.Size = New System.Drawing.Size(71, 45)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Text = "Log in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Volte Rounded Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LAMOK SCENT SLAYER"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(70, 25)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'panelDesktop
        '
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(0, 97)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.ShadowDecoration.Parent = Me.panelDesktop
        Me.panelDesktop.Size = New System.Drawing.Size(1200, 603)
        Me.panelDesktop.TabIndex = 2
        '
        'formApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Celias", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "formApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents buttonAboutUs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents panelDesktop As Guna.UI2.WinForms.Guna2Panel
End Class
