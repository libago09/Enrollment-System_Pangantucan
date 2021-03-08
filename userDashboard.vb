Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.Hosting


Public Class userDashboard

    Sub dashboardSwitchpanel(ByVal panel As Form)
        dashboardPanel.Controls.Clear()
        panel.TopLevel = False
        dashboardPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub StatusButton_Click(sender As Object, e As EventArgs) Handles StatusButton.Click
        dashboardSwitchpanel(formStatus)
    End Sub

    Private Sub AdmissionButton_Click(sender As Object, e As EventArgs) Handles AdmissionButton.Click
        dashboardSwitchpanel(formAdmissionSelection)
    End Sub

    Private Sub EnrollmentButton_Click(sender As Object, e As EventArgs) Handles EnrollmentButton.Click
        dashboardSwitchpanel(formEnrollmentSelection)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        dashboardSwitchpanel(formSettingsSelection)
    End Sub
End Class