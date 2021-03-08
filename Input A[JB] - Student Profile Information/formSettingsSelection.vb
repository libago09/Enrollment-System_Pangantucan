Public Class formSettingsSelection


    Sub dashboardSwitchpanel(ByVal panel As Form)
            userDashboard.dashboardPanel.Controls.Clear()
            panel.TopLevel = False
            userDashboard.dashboardPanel.Controls.Add(panel)
            panel.Show()
        End Sub



    Private Sub buttonSettingsRegisterFaculty_Click(sender As Object, e As EventArgs) Handles buttonSettingsRegisterFaculty.Click
        dashboardSwitchpanel(formFacultyAdmission)
    End Sub

End Class