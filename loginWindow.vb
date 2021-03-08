


Public Class loginWindow
#Region "Declares"

#End Region



    Private Sub loginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginCancelButton_Click(sender As Object, e As EventArgs) Handles loginCancelButton.Click
        If MessageBox.Show("Are you sure you ant to cancel? The program will close.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class