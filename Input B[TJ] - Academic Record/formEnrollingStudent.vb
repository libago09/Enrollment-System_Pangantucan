Public Class formEnrollingStudent


    Sub dashboardSwitchpanel(ByVal panel As Form)
        userDashboard.dashboardPanel.Controls.Clear()
        panel.TopLevel = False
        userDashboard.dashboardPanel.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub formEnrollmentSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dashboardSwitchpanel(formAcademicRecord)
    End Sub

    Private Sub linkAdmClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdmClose.LinkClicked
        Me.Close()
    End Sub
End Class