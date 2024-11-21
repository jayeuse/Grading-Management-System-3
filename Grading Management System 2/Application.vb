Public Class formApplication

    Private currentChildForm As Form
    Private Sub formApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New formOutsidePage)

    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs)
        OpenChildForm(New formLogin)
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(childForm)
        panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        panelDesktop.BringToFront()


    End Sub

    Private Sub buttonLogin_Click_1(sender As Object, e As EventArgs) Handles buttonLogin.Click
        OpenChildForm(New formLogin)
    End Sub
End Class
