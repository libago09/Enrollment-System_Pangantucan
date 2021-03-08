Imports System.Data.OleDb
Imports System.IO


Public Class formAdmission

    Private Sub formAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Sub dashboardSwitchpanel(ByVal panel As Form)
        userDashboard.dashboardPanel.Controls.Clear()
        panel.TopLevel = False
        userDashboard.dashboardPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub linkAdmClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdmClose.LinkClicked
        dashboardSwitchpanel(formAdmissionSelection)
    End Sub

    Private Sub buttonStudentPhoto_Click(sender As Object, e As EventArgs) Handles buttonStudentPhoto.Click

        Using StudentImage As OpenFileDialog = New OpenFileDialog()
            StudentImage.Filter = "Choose Image(*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp"

            If StudentImage.ShowDialog() = DialogResult.OK Then
                pictureStudentPhoto.Image = Image.FromFile(StudentImage.FileName)
            End If
        End Using

    End Sub

    Private Sub admissionSaveButton_Click(sender As Object, e As EventArgs) Handles admissionSaveButton.Click
        'From Admission Tab Function



        If textStudentLastName.Text = "" Or
           textStudentFirstName.Text = "" Or
           textStudentMiddleName.Text = "" Or
           comboStudentGender.Text = "" Or
           comboStudentBeneficiary.Text = "" Or
           dateStudentBirthDate.Text = "" Or
           textStudentEthnicGroup.Text = "" Or
           textStudentPlaceOfBirth.Text = "" Or
           textStudentContactNumber.Text = "" Or
           textStudentReligion.Text = "" Or
           textStudentCitizenship.Text = "" Or
           textStudentAddress.Text = "" Or
           textMotherLastName.Text = "" Or
           textMotherFirstName.Text = "" Or
           textMotherMiddleName.Text = "" Or
           textMotherOccupation.Text = "" Or
           textMotherContactNumber.Text = "" Or
           textFatherLastName.Text = "" Or
           textFatherFirstName.Text = "" Or
           textFatherMiddleName.Text = "" Or
           textFatherOccupation.Text = "" Or
           textFatherContactNumber.Text = "" Or
           textGuardianLastName.Text = "" Or
           textGuardianFirstName.Text = "" Or
           textGuardianMiddleName.Text = "" Or
           textGuardianOccupation.Text = "" Or
           textGuardianContactNumber.Text = "" Or
           textGuardianRelationship.Text = "" Or
           textGuardianAddress.Text = "" Then

            MessageBox.Show("Please, fill all fields.", "Admission", MessageBoxButtons.OK)
            Exit Sub
        End If

        Try
            Dim SQLConnection As New OleDb.OleDbConnection
            Dim SQLQuery As New OleDb.OleDbCommand
            Dim ConString As String

            ConString = "provider=microsoft.ACE.OLEDB.12.0;Data source=EnrollmentSystem.accdb"

            SQLConnection.ConnectionString = ConString
            SQLQuery.Connection = SQLConnection
            SQLConnection.Open()

            SQLQuery.CommandText = "Insert into tblRegistration values(@studentID,@studentLastName,@studentFirstName,@studentMiddlename,@studentGender,@studentBirthDate,@studentPlaceOfBirth,@studentContactNumber,@studentReligion,@studentCitizenship,@studentAddress,@motherLastName,@motherFirstName,@motherMiddleName,@motherOccupation,@motherContactNumber,@fatherLastName,@fatherFirstName,@fatherMiddleName,@fatherOccupation,@fatherContactNumber,@guardianLastName,@guardianFirstName,@guardianMiddleName,@guardianOccupation,@guardianContactNumber,@guardianRelationship,@guardianAddress)"

            SQLQuery.Parameters.AddWithValue("@studentID", textStudentID.Text)
            SQLQuery.Parameters.AddWithValue("@studentLastName", textStudentLastName.Text)
            SQLQuery.Parameters.AddWithValue("@studentFirstName", textStudentFirstName.Text)
            SQLQuery.Parameters.AddWithValue("@studentMiddlename", textStudentMiddleName.Text)
            SQLQuery.Parameters.AddWithValue("@studentGender", comboStudentGender.Text)
            SQLQuery.Parameters.AddWithValue("@studentAge", textStudentAge.Text)
            SQLQuery.Parameters.AddWithValue("@studentBeneficiary", comboStudentBeneficiary.Text)
            SQLQuery.Parameters.AddWithValue("@studentBirthDate", dateStudentBirthDate.Text)
            SQLQuery.Parameters.AddWithValue("@studentPlaceOfBirth", textStudentPlaceOfBirth.Text)
            SQLQuery.Parameters.AddWithValue("@studentContactNumber", textStudentContactNumber.Text)
            SQLQuery.Parameters.AddWithValue("@studentReligion", textStudentReligion.Text)
            SQLQuery.Parameters.AddWithValue("@studentCitizenship", textStudentCitizenship.Text)
            SQLQuery.Parameters.AddWithValue("@studentAddress", textStudentAddress.Text)
            SQLQuery.Parameters.AddWithValue("@motherLastName", textMotherLastName.Text)
            SQLQuery.Parameters.AddWithValue("@motherFirstName", textMotherFirstName.Text)
            SQLQuery.Parameters.AddWithValue("@motherMiddleName", textMotherMiddleName.Text)
            SQLQuery.Parameters.AddWithValue("@motherOccupation", textMotherOccupation.Text)
            SQLQuery.Parameters.AddWithValue("@motherContactNumber", textMotherContactNumber.Text)
            SQLQuery.Parameters.AddWithValue("@fatherLastName", textFatherLastName.Text)
            SQLQuery.Parameters.AddWithValue("@fatherFirstName", textFatherFirstName.Text)
            SQLQuery.Parameters.AddWithValue("@fatherMiddleName", textFatherMiddleName.Text)
            SQLQuery.Parameters.AddWithValue("@fatherOccupation", textFatherOccupation.Text)
            SQLQuery.Parameters.AddWithValue("@fatherContactNumber", textFatherContactNumber.Text)
            SQLQuery.Parameters.AddWithValue("@guardianLastName", textGuardianLastName.Text)
            SQLQuery.Parameters.AddWithValue("@guardianFirstName", textGuardianFirstName.Text)
            SQLQuery.Parameters.AddWithValue("@guardianMiddleName", textGuardianMiddleName.Text)
            SQLQuery.Parameters.AddWithValue("@guardianOccupation", textGuardianOccupation.Text)
            SQLQuery.Parameters.AddWithValue("@guardianContactNumber", textGuardianContactNumber.Text)
            SQLQuery.Parameters.AddWithValue("@guardianRelationship", textGuardianRelationship.Text)
            SQLQuery.Parameters.AddWithValue("@guardianAddress", textGuardianAddress.Text)
            SQLQuery.Parameters.AddWithValue("@studentPicture", labelStudentImage.Text)
            SQLQuery.ExecuteNonQuery()
            SQLConnection.Close()

            MessageBox.Show("Successfully Registered.", "Admission", MessageBoxButtons.OK)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub admissionCancelButton_Click(sender As Object, e As EventArgs) Handles admissionCancelButton.Click
        Me.Close()
    End Sub

    Private Sub TblRegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()


    End Sub


End Class