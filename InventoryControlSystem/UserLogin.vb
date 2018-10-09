Imports System.Data
Imports System.Data.SqlClient
Public Class UserLogin

    Dim objConnection As New SqlConnection("server =(local);database=InventoryControlSystem;integrated security=true;")

    Dim userDataSet As DataSet
    Dim objDV As DataView

    Dim objCommand As New SqlCommand

    Public Manager, SalesPerson, Purchaser As Boolean
    Public loginName As String

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Opacity = 0
        trVisible.Start()

        lblType.Hide()
        txtPassword.Focus()

        'TODO: This line of code loads data into the 'LoginDataSetWithType.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter1.Fill(Me.LoginDataSetWithType.Users)
        'TODO: This line of code loads data into the 'LoginDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LoginDataSet.Users)

    End Sub

    Private Sub trVisible_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trVisible.Tick
        If Me.Opacity > 1 Then
            trVisible.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.05
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim type As String
        type = lblType.Text.Trim
        loginName = cboUserName.Text

        Dim rowCount As String

        Dim objDataAdaptor As New SqlDataAdapter

        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT * from Users where UserName='" + cboUserName.Text + "'AND Password='" + txtPassword.Text + "'"

        userDataSet = New DataSet()
        objDataAdaptor.Fill(userDataSet, "Users")

        'set the dataview object to the dataset object...
        objDV = New DataView(userDataSet.Tables("Users"))
        Dim objDataTable As DataTable

        objDataTable = userDataSet.Tables("Users")
        rowCount = (objDataTable.Rows.Count - 1)

        If rowCount = -1 Then
            MessageBox.Show("Access Denied!", "SCIS - Exception Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtPassword.Focus()
        Else
            'MsgBox("Access Granted!")

            If type.Equals("Sales Person") Then

                SalesPerson = True

            ElseIf type.Equals("Manager") Then
                Manager = True

            ElseIf type.Equals("Purchaser") Then
                Purchaser = True
                'Else
                '   MessageBox.Show("Unknown user type!")
            End If

            Home.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub LinkChangePassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkChangePassword.LinkClicked

        ChangeUserPassword.Show()

    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click

        Me.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cboUserName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUserName.SelectionChangeCommitted
        txtPassword.Focus()
    End Sub
End ~dulla^@204~ 