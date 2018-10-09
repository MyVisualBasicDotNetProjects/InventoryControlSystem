'Import Data and SqlClient namespaces...
Imports System.data
Imports System.Data.SqlClient

Public Class Products

    Dim objConnection As New SqlConnection _
    ("Server= (local); Database= InventoryControlSystem; Integrated Security = true;")

    Dim objDataAdaptor As New SqlDataAdapter
    'Dim objDataAdaptor2 As New SqlDataAdapter
    Dim objDataSet As DataSet
    'Dim objDataSet2 As DataSet
    'Dim objDataView As DataView
    'Dim objCurrencyManager As CurrencyManager

    Private Sub Products_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtSearch.Text = ""
        txtSearch.Focus()

        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        'Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)

        ' Set the SELECTCOMMAND Propeties
        '   objDataAdaptor.SelectCommand = New SqlCommand()
        '  objDataAdaptor.SelectCommand.Connection = objConnection
        ' Set the SELECTCOMMAND Propeties
        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection

        ' SELECT statement
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT PartNo, Description, Price, SellingPrice1, SellingPrice2, QtyAtShop1,QtyAtShop2," & _
            "QtyAtStore,TotalQuantity, ReorderLevel, ShelfNo FROM Products"

        objDataAdaptor.SelectCommand.CommandType = CommandType.Text

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        ' Fill the DataSet object with data...
        objDataAdaptor.Fill(objDataSet, "Products")

        ' My work

        grdProducts.DataSource = objDataSet

        grdProducts.DataMember = "Products"
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim searchContent As String = txtSearch.Text

        Dim selectDataAdaptor As New SqlDataAdapter
        selectDataAdaptor.SelectCommand = New SqlCommand

        selectDataAdaptor.SelectCommand.Connection = objConnection

        selectDataAdaptor.SelectCommand.CommandText = _
       ("SELECT * FROM Products WHERE PartNo like '" & searchContent & "%'")

        selectDataAdaptor.Fill(objDataSet, "ProductsSearch")
        selectDataAdaptor.AcceptChangesDuringFill = True

        grdProducts.DataSource = objDataSet
        grdProducts.DataMember = "ProductsSearch"

        If grdProducts.RowCount = 0 Then
            MessageBox.Show("No match found!", "SCIS - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call btnRefresh_Click(Nothing, Nothing)
        End If

    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        Me.ProductsTableAdapter.Update(Me.ProductsDataSet.Products)

        grdProducts.DataSource = ProductsDataSet

        grdProducts.DataMember = "Products"

        Products_Load(Nothing, Nothing)
    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Dispose()
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnGoToSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoToSales.Click
        SalesTable.Show()
        Me.Dispose()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Hide()
        Me.Hide()
        SalesTable.Hide()
        Home.Show()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'Call btnGo_Click(Nothing, Nothing)
    End Sub
End Class
