Public Class formFacultyAdmission
    Private Sub buttonFAdmissionSave_Click(sender As Object, e As EventArgs)

        'From Faculty Admission Tab Function

        If textFacultyLastName.Text = "" Or
               textFacultyFirstName.Text = "" Or
               textFacultyMiddleName.Text = "" Or
               dateFacultyBirthDate.Text = "" Or
               textFacultyPlaceOfBirth.Text = "" Or
               textFacultyReligion.Text = "" Or
               textFacultyAge.Text = "" Or
               comboFacultyGender.Text = "" Or
               textFacultyContactNumber.Text = "" Or
               comboFacultyPosition.Text = "" Or
               textFacultyAddress.Text = "" Then

            MessageBox.Show("Please, fill all fields.", "Faculty Admission", MessageBoxButtons.OK)
            Exit Sub
        End If

    End Sub
End Class