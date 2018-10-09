Imports System.Data
Imports System.Data.SqlClient

Public Class ChangeUserPassword
    Dim objConnection As New SqlConnection("Server =(local);Database=InventoryControlSystem;integrated security=true;")
    Dim objDataAdaptor As New SqlDataAdapter
    Dim objCommand As New SqlCommand
    Dim userDataSet As DataSet
    Dim objDV As DataView

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LoginDataSet.Users)
        lblUserName.Text = InventoryControlSystem.UserLogin.loginName
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Dim oldPassword, newPassword, confirmPassword, userName, rowCount As String

        oldPassword = txtOldPassword.Text
        newPassword = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text
        userName = lblUserName.Text

        ' Check the old password for authentication
        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT * from Users where UserName='" + lblUserName.Text + "'AND Password='" + oldPassword + "'"

        userDataSet = New DataSet()
        objDataAdaptor.Fill(userDataSet, "Users")
        '    'set the dataview object to the dataset object...
        objDV = New DataView(userDataSet.Tables("Users"))

        Dim objDataTable As DataTable

        objDataTable = userDataSet.Tables("Users")
        rowCount = (objDataTable.Rows.Count - 1)

        ' If no match is found
        If rowCount = -1 Then
            MessageBox.Show("Incorrect old password!")
            txtOldPassword.Text = ""
            txtOldPassword.Focus()
        Else

            If newPassword.Equals(confirmPassword) Then 'new passwords are same

                Dim objUpdateCommand As New SqlCommand
                objUpdateCommand.Connection = objConnection

                'UPDATE statement
                objUpdateCommand.CommandText = _
                "UPDATE Users " & _
                "SET password = '" & newPassword & "'" & _
                "WHERE username ='" & userName & "';"

                objConnection.Open()
                objUpdateCommand.ExecuteNonQuery()
                objConnection.Close()

                MessageBox.Show("Passwords successfully changed !!!", "SCIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Invalid Conformation!", "SCIS Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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