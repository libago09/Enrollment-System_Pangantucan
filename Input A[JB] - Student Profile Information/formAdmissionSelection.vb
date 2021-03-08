Public Class formAdmissionSelection

    Sub dashboardSwitchpanel(ByVal panel As Form)
        userDashboard.dashboardPanel.Controls.Clear()
        panel.TopLevel = False
        userDashboard.dashboardPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub buttonAdmRegistration_Click(sender As Object, e As EventArgs) Handles buttonAdmRegistration.Click
        dashboardSwitchpanel(formAdmission)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dashboardSwitchpanel(formAdmissionRecordView)
    End Sub
End Class