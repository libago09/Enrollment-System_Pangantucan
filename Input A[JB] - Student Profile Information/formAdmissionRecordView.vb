Imports System.Data.OleDb
Imports System.IO


Public Class formAdmissionRecordView

    Dim conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim qry As String
    Dim conString As String
    Dim path As String

    Sub dashboardSwitchpanel(ByVal panel As Form)
        userDashboard.dashboardPanel.Controls.Clear()
        panel.TopLevel = False
        userDashboard.dashboardPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub formAdmissionRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        If textRStudentID.Text = "" Then
            Call notFound()
            Exit Sub
        End If
    End Sub

    Private Sub notFound()

    End Sub

    Private Sub linkAdmClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdmClose.LinkClicked
        dashboardSwitchpanel(formAdmissionSelection)
    End Sub
End Class