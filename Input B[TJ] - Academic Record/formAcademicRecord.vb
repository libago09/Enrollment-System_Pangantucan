Public Class formAcademicRecord
    Private Sub formAcademicRecordViewGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonAddNew_Click(sender As Object, e As EventArgs) Handles buttonAddNew.Click
        formEnrollingStudent.Show()
    End Sub
End Class