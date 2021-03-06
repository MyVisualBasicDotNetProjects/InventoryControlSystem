'Import Data and SqlClient namespaces...
Imports System.data
Imports System.Data.SqlClient


Public Class QuantityDivision

    Dim objConnection As New SqlConnection _
    ("Server= (local); Database= InventoryControlSystem; Integrated Security = true;")

    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataSet As DataSet

    Private Sub QuantityDivision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'TODO: This line of code loads data into the 'PInvoiceNoDataSet.Purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter1.Fill(Me.PInvoiceNoDataSet.Purchase)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub rdbManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbManually.CheckedChanged

        lblDistn.Enabled = False
        cboDistnStrategy.Enabled = False

    End Sub

    Private Sub rdbAutomatically_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAutomatically.CheckedChanged

        lblDistn.Enabled = True
        cboDistnStrategy.Enabled = True

    End Sub

    Private Sub btnDistQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistQty.Click

        If rdbAutomatically.Checked Then

            If cboDistnStrategy.Text = "Strategy 1" Then

                ' Assume Strategy1 says equal division 

                Dim totalQty, solution As Integer

                Dim noOfRows As Integer
                noOfRows = grdQtyDivision.RowCount - 1
                'MsgBox("noOfRows" & noOfRows)

                For i As Integer = 0 To noOfRows

                    Dim PartNo As String
                    PartNo = grdQtyDivision.Item(0, i).Value

                    totalQty = grdQtyDivision.Item(2, i).Value
                    'MsgBox("total" & totalQty)

                    solution = (totalQty / 2) - 2
                    'solution = 1
                    'MsgBox(solution)

                    'If (i = 0) Then
                    grdQtyDivision.Item(3, i).Value = solution
                    grdQtyDivision.Item(4, i).Value = solution
                    grdQtyDivision.Item(5, i).Value = 2
                    'End If


                    'End While

                    objDataSet.AcceptChanges()
                    objDataAdaptor.Update(objDataSet, "QuantityDivision")

                    Dim objUpdateCommand As New SqlCommand
                    objUpdateCommand.Connection = objConnection

                    'INSERT starement
                    objUpdateCommand.CommandText = _
                    "UPDATE Products " & _
                    "SET QtyAtShop1 = " & solution & ", " & _
                    "QtyAtShop2 = " & solution & ", " & _
                    "QtyAtStore = 2" & _
                    "WHERE PartNo LIKE '" & PartNo & "';"

                    objConnection.Open()
                    objUpdateCommand.ExecuteNonQuery()
                    objConnection.Close()
                Next
            Else
                MsgBox("For now no other strategy is avialable.")
            End If


            ' If manually is checked
        Else

            Dim noOfRows As Integer
            noOfRows = grdQtyDivision.RowCount - 1

            For i As Integer = 0 To noOfRows
                If grdQtyDivision.Item(2, i).Value IsNot DBNull.Value AndAlso grdQtyDivision.Item(2, i).Value <> 0 Then

                    Dim PartNo As String
                    Dim shop1, shop2, store As Double

                    PartNo = grdQtyDivision.Item(0, i).Value
                    shop1 = grdQtyDivision.Item(3, i).Value
                    shop2 = grdQtyDivision.Item(4, i).Value
                    store = grdQtyDivision.Item(5, i).Value


                    objDataSet.AcceptChanges()
                    objDataAdaptor.Update(objDataSet, "QuantityDivision")

                    Dim objUpdateCommand As New SqlCommand
                    objUpdateCommand.Connection = objConnection


                    'INSERT starement
                    objUpdateCommand.CommandText = _
                    "UPDATE Products " & _
                    "SET QtyAtShop1 = " & shop1 & " " & _
                    "SET QtyAtShop2 = " & shop2 & " " & _
                    "SET QtyAtStore = " & store & " " & _
                    "WHERE PartNo LIKE '" & PartNo & "';"

                    objConnection.Open()
                    objUpdateCommand.ExecuteNonQuery()
                    objConnection.Close()

                Else
                    MessageBox.Show("Done!", "SICS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit For
                End If
            Next
        End If

        objConnection.Open()
        objDataAdaptor.Update(objDataSet, "QuantityDivision")
        objConnection.Close()

    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Dispose()
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cboInvoiceNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInvoiceNo.SelectedIndexChanged

        ' Set the SELECTCOMMAND Propeties
        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection

        ' SELECT statement
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT PartNo,Description, TotalQuantity, QtyAtShop1, QtyAtShop2, QtyAtStore,ReorderLevel, ShelfNo FROM Products " & _
        "WHERE PInvoiceNo LIKE '" & cboInvoiceNo.Text & "';"

        objDataAdaptor.SelectCommand.CommandType = CommandType.Text

        objDataAdaptor.InsertCommand = New SqlCommand
        objDataAdaptor.InsertCommand.Connection = objConnection

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        ' Fill the DataSet object with data...
        objDataAdaptor.Fill(objDataSet, "QuantityDivision")

        'Set the DataGridView properties to bind it to our data
        grdQtyDivision.AutoGenerateColumns = True
        grdQtyDivision.DataSource = objDataSet
        grdQtyDivision.DataMember = "QuantityDivision"


    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Hide()
        Me.Hide()
        Home.Show()
    End  ~dulla^@204~ 