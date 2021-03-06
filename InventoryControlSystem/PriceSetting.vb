'Import Data and SqlClient namespaces...
Imports System.data
Imports System.Data.SqlClient

Public Class PriceSetting

    Dim objConnection As New SqlConnection _
            ("Server= (local); Database= InventoryControlSystem; Integrated Security = true;")

    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataSet As DataSet

    
    Private Sub PriceSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PInvoiceNoDataSet.Purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter1.Fill(Me.PInvoiceNoDataSet.Purchase)
        
    End Sub

    Private Sub rdbManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbManually.CheckedChanged

        gbTaxes.Enabled = False
        gbCosts.Enabled = False
        cboPricingStrategy.Enabled = False

    End Sub

    Private Sub rdbAutomatically_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAutomatically.CheckedChanged

        gbTaxes.Enabled = True
        gbCosts.Enabled = True
        cboPricingStrategy.Enabled = True

    End Sub

    Private Sub btnSetPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPrice.Click

        If rdbAutomatically.Checked Then

            grdPriceSetting.AllowUserToAddRows = False
            grdPriceSetting.AllowUserToDeleteRows = False
            grdPriceSetting.AllowUserToDeleteRows = False

            Dim frieghtCost, miscellaneousCost, customTaxRate, surTaxRate, unitCost, profitMargin, solution As Double

            frieghtCost = lblFrieghtCost.Text
            miscellaneousCost = lblMiscellaneousCost.Text

            'Accepting customTaxRate as a double cutting the '%' sign
            customTaxRate = cboCustomTax.Text.Remove(2)
            customTaxRate = CType("0." & customTaxRate, Double)

            'Accepting surTaxRate as a double cutting the '%' sign
            surTaxRate = cboSurTax.Text.Remove(2)
            surTaxRate = CType("0." & surTaxRate, Double)

            If cboPricingStrategy.Text = "Strategy 1" Then

                profitMargin = 0.25

                Dim noOfRows As Integer
                noOfRows = grdPriceSetting.RowCount - 1
                ' MsgBox("noOfRows" & noOfRows)

                For i As Integer = 0 To noOfRows

                    If grdPriceSetting.Item(2, i).Value IsNot DBNull.Value AndAlso grdPriceSetting.Item(2, i).Value <> 0 Then

                        Dim PartNo As String
                        PartNo = grdPriceSetting.Item(0, i).Value

                        unitCost = grdPriceSetting.Item(2, i).Value
                        solution = (frieghtCost / noOfRows) + (miscellaneousCost / noOfRows)
                        'solution = 100
                        grdPriceSetting.Item(4, i).Value = solution
                        objDataSet.AcceptChanges()
                        objDataAdaptor.Update(objDataSet, "PriceSetting")

                        Dim objUpdateCommand As New SqlCommand
                        objUpdateCommand.Connection = objConnection

                        'UPDATE statement
                        objUpdateCommand.CommandText = _
                        "UPDATE Products " & _
                        "SET SellingPrice1 = " & solution & " " & _
                        "WHERE PartNo LIKE '" & PartNo & "';"

                        objConnection.Open()
                        objUpdateCommand.ExecuteNonQuery()
                        objConnection.Close()

                    Else
                        MsgBox("Done!")

                        Exit For
                    End If
                Next
               
            End If
        Else        ' if rdbManually.checked = true

            Dim noOfRows As Integer
            noOfRows = grdPriceSetting.RowCount - 1

            For i As Integer = 0 To noOfRows
                If grdPriceSetting.Item(2, i).Value IsNot DBNull.Value AndAlso grdPriceSetting.Item(2, i).Value <> 0 Then

                    Dim PartNo As String
                    Dim SP1, unitCost As Double

                    PartNo = grdPriceSetting.Item(0, i).Value
                    SP1 = grdPriceSetting.Item(4, i).Value
                    unitCost = grdPriceSetting.Item(2, i).Value

                    objDataSet.AcceptChanges()
                    objDataAdaptor.Update(objDataSet, "PriceSetting")

                    Dim objUpdateCommand As New SqlCommand
                    objUpdateCommand.Connection = objConnection


                    'INSERT starement
                    objUpdateCommand.CommandText = _
                    "UPDATE Products " & _
                    "SET SellingPrice1 = " & SP1 & " " & _
                    "WHERE PartNo LIKE '" & PartNo & "';"

                    objConnection.Open()
                    objUpdateCommand.ExecuteNonQuery()
                    objConnection.Close()

                Else
                    MsgBox("Done!")

                    Exit For
                End If
            Next
        End If

        objConnection.Open()
        objDataAdaptor.Update(objDataSet, "PriceSetting")
        objConnection.Close()
    End Sub

  
    Private Sub btnQuantityDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantityDivision.Click
        QuantityDivision.Show()
        Me.Dispose()
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
        "SELECT PartNo,Description, Price, TotalQuantity, SellingPrice1, SellingPrice2 FROM Products " & _
        "WHERE PInvoiceNo LIKE '" & cboInvoiceNo.Text & "';"

        objDataAdaptor.SelectCommand.CommandType = CommandType.Text

        objDataAdaptor.InsertCommand = New SqlCommand
        objDataAdaptor.InsertCommand.Connection = objConnection

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        ' Fill the DataSet object with data...
        objDataAdaptor.Fill(objDataSet, "PriceSetting")

        'Set the DataGridView properties to bind it to our data
        grdPriceSetting.AutoGenerateColumns = True
        grdPriceSetting.DataSource = objDataSet
        grdPriceSetting.DataMember = "PriceSetting"


    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Hide()
        Me.Hide()
        Home.Show()
    End  ~dulla^@204~ 