<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOutsidePage
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
        Me.panelDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelDisplay
        '
        Me.panelDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.panelDisplay.Controls.Add(Me.Label4)
        Me.panelDisplay.Controls.Add(Me.Guna2Panel3)
        Me.panelDisplay.Controls.Add(Me.Label3)
        Me.panelDisplay.Controls.Add(Me.Label2)
        Me.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDisplay.Location = New System.Drawing.Point(0, 0)
        Me.panelDisplay.Name = "panelDisplay"
        Me.panelDisplay.ShadowDecoration.Parent = Me.panelDisplay
        Me.panelDisplay.Size = New System.Drawing.Size(1200, 700)
        Me.panelDisplay.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Celias", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(818, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 60)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Welcome Page"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 175
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(-51, 359)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(350, 350)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Volte Rounded Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(745, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(496, 144)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PORTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Volte Rounded Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(801, 144)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PLP STUDENT"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'formOutsidePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelDisplay)
        Me.Font = New System.Drawing.Font("Celias", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "formOutsidePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelDisplay.ResumeLayout(False)
        Me.panelDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents panelDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
