Imports System.Data
Imports System.Data.SqlClient

Public Class CreateUserAccount

    Dim objConnection As New SqlConnection("Server =(local);Database=InventoryControlSystem;integrated security=true;")

    Dim objCommand As New SqlCommand

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LoginDataSet.Users)

        rdbManager.Checked = True

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Dim userName, Password, confirmPassword, type, location As String
        userName = txtUserName.Text
        Password = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text
        location = cboSelect.Text
        If rdbManager.Checked Then
            type = rdbManager.Text
        ElseIf rdbSalesPerson.Checked Then
            type = rdbSalesPerson.Text
        Else
            type = rdbPurchaser.Text
        End If

        If Password.Equals(confirmPassword) Then

            Dim objInsertCommand As New SqlCommand
            objInsertCommand.Connection = objConnection


            'INSERT starement
            objInsertCommand.CommandText = _
            "INSERT INTO Users " & _
            "(UserName, Password,TypeOfUser,Location)" & _
            "VALUES (@userName, @Password, @TypeOfUser,@Location);"

            objInsertCommand.Parameters.AddWithValue("@userName", userName)
            objInsertCommand.Parameters.AddWithValue("@Password", Password)
            objInsertCommand.Parameters.AddWithValue("@TypeOfUser", type)
            objInsertCommand.Parameters.AddWithValue("@Location", location)
            objConnection.Open()

            ' Execute the SqlCommand object to insert the new data...
            Try
                objInsertCommand.ExecuteNonQuery()
            Catch SqlExceptionErr As SqlException
                MessageBox.Show(SqlExceptionErr.Message)
            End Try

            objConnection.Close()

            MessageBox.Show("User Account Created Successfully!!!", "SCIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Home.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid conformation!", "SCIS Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Dispose()
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Hide()
        Me.Hide()
        Home.Show()
    End Sub
End Class


