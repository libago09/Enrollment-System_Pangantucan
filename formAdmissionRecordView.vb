Imports System.Data.OleDb
Imports System.IO


Public Class formAdmissionRecordView

    Dim conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim qry As String
    Dim conString As String
    Dim path As String

    Private Sub formAdmissionRecordView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "provider=microsoft.ACE.OLEDB.12.0;Data source=EnrollmentSystem.accdb"

        Catch ex As Exception

        End Try
    End Sub


    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        If textRStudentID.Text = "" Then
            Call notFound()
            Exit Sub
        End If
    End Sub

    Private Sub notFound()

    End Sub

End Class