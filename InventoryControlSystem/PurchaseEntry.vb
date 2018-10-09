'Import Data and SqlClient namespaces...
Imports System.data
Imports System.Data.SqlClient

Public Class PurchaseEntry

    Dim objConnection As New SqlConnection _
        ("Server= (local); Database= InventoryControlSystem; Integrated Security = True;")

    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataSet As New DataSet
    Dim objCommand As New SqlCommand
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Dim objDataAdapter As New SqlDataAdapter( _
"SELECT SupplierID, SupplierName, Address, City, Country, Phone, Fax, " & _
"PostalAddress, Website, Email " & _
"FROM Supplier " & _
"ORDER BY SupplierID", objConnection)


    Dim objDataAdaptor2 As New SqlDataAdapter
    Dim objDataSet2 As New DataSet
    Dim objCommand2 As New SqlCommand
    Dim objDataView2 As DataView
    Dim objCurrencyManager2 As CurrencyManager
    Dim objDataAdapter2 As New SqlDataAdapter( _
"SELECT PurchaseInvoiceNo, DateOfPurchase, TotalAmount, FrieghtCharge, " & _
"MiscellaneousCost, GrandTotal,SupplierID " & _
"FROM Purchase", objConnection) '"ORDER BY PurchaseInvoiceNo"
    
    'Dim objDataAdaptor3 As SqlDataAdapter
    Dim objDataSet3 As DataSet
    Dim objCommand3 As New SqlCommand
    Dim objDataAdaptor3 As New SqlDataAdapter( _
"SELECT PartNo,Description, Brand, Origin, NetWeight, Quantity, Price,Amount FROM PurchaseInfo", objConnection)

    Dim objCmdProducts As New SqlCommand


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''' Update the DataSet of the grid
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Me.PurchaseInfoTableAdapter.Update(Me.PurchaseInfoDataSet.PurchaseInfo)

        Dim noOfRows As Integer
        noOfRows = grdPurchaseInfo.RowCount - 1
        'MsgBox("noOfRows" & noOfRows)

        For i As Integer = 0 To noOfRows
            If grdPurchaseInfo.Item(0, i).Value IsNot DBNull.Value AndAlso grdPurchaseInfo.Item(0, i).Value <> "" Then

                Dim PartNo, Description, Price, InvoiceNo, Quantity As String
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                PartNo = grdPurchaseInfo.Item(0, i).Value
                Description = grdPurchaseInfo.Item(1, i).Value
                Quantity = grdPurchaseInfo.Item(5, i).Value
                Price = grdPurchaseInfo.Item(6, i).Value
                InvoiceNo = grdPurchaseInfo.Item(9, i).Value

                '       MsgBox(PartNo)

                Dim objSelectCommand As New SqlCommand
                objSelectCommand.Connection = objConnection

                'SELECT command
                objSelectCommand.CommandText = _
                "SELECT PartNo " & _
                "FROM Products " & _
                "WHERE PartNo LIKE '" & PartNo & "';"

                objConnection.Open()
                Dim ObjPartNo As Object = objSelectCommand.ExecuteScalar

                Dim avialablePartNo As String
                avialablePartNo = CType(ObjPartNo, String)
                '      MsgBox("avialablePartNo" & avialablePartNo)

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim objSelectCommand2 As New SqlCommand
                objSelectCommand2.Connection = objConnection

                'SELECTcommand
                objSelectCommand2.CommandText = _
                "SELECT TotalQuantity " & _
                "FROM Products " & _
                "WHERE PartNo LIKE '" & PartNo & "';"

                Dim ObjQuantity As Object = objSelectCommand2.ExecuteScalar
                objConnection.Close()

                Dim avialableQuantity, newQuantity As String
                avialableQuantity = CType(ObjQuantity, String)

                '     MsgBox("avialableQuantity " & avialableQuantity)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If avialablePartNo IsNot DBNull.Value Then
                    '        MsgBox("not Null")
                    If avialablePartNo IsNot PartNo Then  ' if the product is new

                        ' Me.PurchaseInfoTableAdapter.Update(Me.PurchaseInfoDataSet2.PurchaseInfo)

                        'For j As Integer = 0 To noOfRows
                        'If grdPurchaseInfo.Item(0, j).Value IsNot DBNull.Value Then

                        ' Set the SqlCommand object properties...
                        objCmdProducts.Connection = objConnection

                        objCmdProducts.CommandText = _
                "INSERT INTO Products (PartNo, Description, TotalQuantity, Price, PInvoiceNo)" & _
                "VALUES(@PNo, @Description, @Qty, @Price, @PInvoiceNo);"

                        '                        MsgBox("PN in if" & PartNo)
                        ' Add parameters for the placeholders in the SQL in the
                        ' CommandText property...
                        ' Parameter for the PurchaseInvoiceNo column...
                        objCmdProducts.Parameters.AddWithValue("@PNo", PartNo)
                        ' Parameter for the DatePfPurchase column...
                        objCmdProducts.Parameters.AddWithValue("@Description", Description)
                        ' Parameter for the TotalAmount column
                        objCmdProducts.Parameters.AddWithValue("@Qty", Quantity)
                        ' Parameter for the FrieghtCharge column...
                        objCmdProducts.Parameters.AddWithValue("@Price", Price)
                        ' Parameter for the FrieghtCharge column...
                        objCmdProducts.Parameters.AddWithValue("@PInvoiceNo", InvoiceNo)


                        ' Execute the SqlCommand object to insert the new data...


                        Try
                            objConnection.Open()
                            objCmdProducts.ExecuteNonQuery()
                            'MsgBox("THANK YOU GOD!!! It is INSERTED")
                            lblStrip.Text = "The products are inserted in PurchaseInfo table."
                        Catch SqlExceptionErr As SqlException
                            MessageBox.Show(SqlExceptionErr.Message)
                            '              MsgBox("Next time it works. Believe in God!")
                        End Try
                        objConnection.Close()
                        'Next
                        'MessageBox.Show("That much quantity is NOT avialable!")

                    Else

                        'if the product is avialable, update its quantity


                        Dim objUpdateCommand As New SqlCommand
                        objUpdateCommand.Connection = objConnection

                        ' MsgBox("trying to update")

                        Dim intAvialableQuantity, intQuantity As Integer

                        intAvialableQuantity = CType(avialableQuantity, Integer)
                        intQuantity = CType(Quantity, Integer)

                        newQuantity = intAvialableQuantity + intQuantity
                        newQuantity = newQuantity.ToString
                        'MsgBox("newQuantity" & newQuantity)

                        'UPDATE statement 
                        objUpdateCommand.CommandText = _
                        "UPDATE Products " & _
                        "SET TotalQuantity ='" & newQuantity & "'" & _
                        "WHERE PartNo LIKE '" & PartNo & "';"

                        objConnection.Open()
                        objUpdateCommand.ExecuteNonQuery()
                        lblStrip.Text = "Products table quantity is updated."
                        objConnection.Close()
                    End ~dulla^@204~ ~dulla^@204~                     'MessageBox.Show(~dulla^@204~ or Done or Nothing to sell")
       ~dulla^@204~ lblStrip.Text = "Done."
            ~dulla^@204~            End If
        Next

  ~dulla^@204~     Private Sub PurchaseEntry_Load(By~dulla^@204~  System.Object, ByVal e As System.Eve~dulla^@204~ es MyBase.Load
        'TODO: This l~dulla^@204~ oads data into the 'PurchaseInfoDataS~dulla^@204~ fo' table. You can move, or remove it~dulla^@204~ 
        'Me.PurchaseInfoTableAdapter~dulla^@204~ haseInfoDataSet.PurchaseInfo)
      ~dulla^@204~ Name.Focus()
        grdPurchaseInfo~dulla^@204~ lse
        lblStrip.Text = "Please ~dulla^@204~  and Invoice information."
    End S~dulla^@204~ vate Sub btnAddSupInv_Click(ByVal sen~dulla^@204~ .Object, ByVal e As System.EventArgs)~dulla^@204~ ddSupInv.Click

        ' Initializ~dulla^@204~ nce of the DataSet object...
       ~dulla^@204~  New DataSet()
        ' Fill the Da~dulla^@204~ with data...
        objDataAdapter.~dulla^@204~ et, "Supplier")
        ' Set the Da~dulla^@204~  to the DataSet object...
        ob~dulla^@204~ ew DataView(objDataSet.Tables("Suppli~dulla^@204~   ' Set our CurrencyManager object to~dulla^@204~  object...
        objCurrencyManage~dulla^@204~ BindingContext(objDataView), Currency~dulla^@204~        ' Declare local variables and ~dulla^@204~ 
        'Dim intSupID As Integer
  ~dulla^@204~ ID As String
        Dim objCommand ~dulla^@204~  = New SqlCommand()

        ' Crea~dulla^@204~ ommand object...
        Dim maxIdCo~dulla^@204~ ommand = New SqlCommand _
        ("~dulla^@204~ SupplierID) FROM Supplier", objConnec~dulla^@204~ SupplierID LIKE 'sup%'

        ' O~dulla^@204~ ction, execute the command
        o~dulla^@204~ Open()

        Dim maxId As Object~dulla^@204~ nd.ExecuteScalar

        ' Set the~dulla^@204~ le to the value in MaxID...
        ~dulla^@204~ (maxId, String)
        'intSupID = ~dulla^@204~ Integer)

        ' Get the integer~dulla^@204~ string...
        'intSupID = CType(~dulla^@204~ 0, 3), Integer)

        'Increment~dulla^@204~ vaue to create the next value
      ~dulla^@204~ = 1

        ' Finally, set the new~dulla^@204~    'strID = "sup" & intSupID.ToString~dulla^@204~ trID += 1

        ' Declare a vari~dulla^@204~  the SupplierID
        '        Dim~dulla^@204~ ing

        '       SupID = strID~dulla^@204~ Set the SqlCommand object properties.~dulla^@204~ bjCommand.Connection = objConnection~dulla^@204~ jCommand.CommandText = "INSERT INTO S~dulla^@204~ 
"(SupplierID, SupplierName, Address~dulla^@204~ ry, Phone, Fax,PostalAddress, Website~dulla^@204~ 
"VALUES(@SupplierID,@SupplierName,@~dulla^@204~ ,@Country, @Phone, @Fax, @PostalAddre~dulla^@204~  @Email);" '& _

        ' Add para~dulla^@204~ e placeholders in the SQL in the
   ~dulla^@204~ dText property...
        ' Paramete~dulla^@204~ plierID column...
        objCommand~dulla^@204~ ddWithValue("@SupplierID", strID)
  ~dulla^@204~ eter for the SupplierName column...
~dulla^@204~ mmand.Parameters.AddWithValue("@Suppl~dulla^@204~ SupplierName.Text)
        ' Paramet~dulla^@204~ dress column
        objCommand.Para~dulla^@204~ hValue("@Address", txtAddress.Text)
~dulla^@204~ ameter for the City column...
      ~dulla^@204~ Parameters.AddWithValue("@City", txtC~dulla^@204~       ' Parameter for the Country col~dulla^@204~ objCommand.Parameters.AddWithValue("@~dulla^@204~ Country.Text)
        ' Parameter fo~dulla^@204~ olumn
        objCommand.Parameters.~dulla^@204~ "@Phone", txtTel.Text)
        ' Par~dulla^@204~ e Fax column
        objCommand.Para~dulla^@204~ hValue("@Fax", txtFax.Text)
        ~dulla^@204~ or the PostalAddress column
        ~dulla^@204~ rameters.AddWithValue("@PostalAddress~dulla^@204~ ddress.Text)
        ' Parameter for~dulla^@204~ column
        objCommand.Parameters~dulla^@204~ ("@Website", txtWebsite.Text)
      ~dulla^@204~  for the Email column
        objCom~dulla^@204~ rs.AddWithValue("@Email", txtEmail.Te~dulla^@204~ ' Parameter for the SupplierID column~dulla^@204~ jCommand.Parameters.AddWithValue("@Su~dulla^@204~ rID)

        ' Execute the SqlComm~dulla^@204~  insert the new data...
        Try~dulla^@204~ objCommand.ExecuteNonQuery()
       ~dulla^@204~ .Text = "Inserted in Supplier table."~dulla^@204~ ch SqlExceptionErr As SqlException
 ~dulla^@204~ ssageBox.Show(SqlExceptionErr.Message~dulla^@204~ d Try

        ' Close the connecti~dulla^@204~   '      objConnection.Close()


 ~dulla^@204~ '''''''''''''''''''''''''''''''''''''~dulla^@204~ ''''''''''''''''''''''''''
        '~dulla^@204~  Invoice Info Group box
        ''''~dulla^@204~ '''''''''''''''''''''''''''''''''''''~dulla^@204~ '''''''''''''''

        ' Initiali~dulla^@204~ ance of the DataSet object...
      ~dulla^@204~  = New DataSet()

        ' Fill th~dulla^@204~ ect with data...
        objDataAdap~dulla^@204~ DataSet2, "Purchase")

        ' Se~dulla^@204~ w object to the DataSet object...
  ~dulla^@204~ View2 = New DataView(objDataSet2.Tabl~dulla^@204~ ))

        ' Set our CurrencyManag~dulla^@204~ the DataView object...
        objCu~dulla^@204~ 2 = CType(Me.BindingContext(objDataVi~dulla^@204~ yManager)

        ' Declare an obj~dulla^@204~    Dim objCommand2 As SqlCommand = Ne~dulla^@204~ )

        Dim maxIdCommand2 As Sql~dulla^@204~  SqlCommand _
        ("SELECT MAX(P~dulla^@204~ eNo) AS MaxID FROM Purchase", objConn~dulla^@204~       ' Open the connection, execute ~dulla^@204~         'objConnection.Open()

    ~dulla^@204~  SqlCommand object properties...
   ~dulla^@204~ nd2.Connection = objConnection

   ~dulla^@204~ nd2.CommandText = "INSERT INTO Purcha~dulla^@204~ urchaseInvoiceNo, DateOfPurchase, Tot~dulla^@204~ eghtCharge, MiscellaneousCost, GrandT~dulla^@204~ ID)" & _
"VALUES(@PurchaseInvoiceNo,~dulla^@204~ ase, cast(@TotalAmount as money), cas~dulla^@204~ rge as money), cast(@MiscellaneousCos~dulla^@204~ cast(@GrandTotal as money),@SupplierI~dulla^@204~      ' Add parameters for the placeho~dulla^@204~ SQL in the
        ' CommandText pro~dulla^@204~      ' Parameter for the PurchaseInvo~dulla^@204~ ..
        objCommand2.Parameters.Ad~dulla^@204~ PurchaseInvoiceNo", txtPInvoiceNo.Tex~dulla^@204~  Parameter for the DatePfPurchase col~dulla^@204~    objCommand2.Parameters.AddWithValu~dulla^@204~ chase", txtDate.Text)
        ' Para~dulla^@204~  TotalAmount column
        objComma~dulla^@204~ s.AddWithValue("@TotalAmount", txtTot~dulla^@204~      ' Parameter for the FrieghtCharg~dulla^@204~         objCommand2.Parameters.AddWit~dulla^@204~ ghtCharge", txtFrieghtCost.Text)
   ~dulla^@204~ ter for the MiscellaneousCost column~dulla^@204~ ommand2.Parameters.AddWithValue("@Mis~dulla^@204~ t", txtMiscellaneousCost.Text)
     ~dulla^@204~ r for the GrandTotal column
        ~dulla^@204~ arameters.AddWithValue("@GrandTotal",~dulla^@204~ l.Text)
        'Parameter for the S~dulla^@204~ umn
        objCommand2.Parameters.A~dulla^@204~ @SupplierID", strID)

        ' Exe~dulla^@204~ ommand object to insert the new data.~dulla^@204~ ry
            objCommand2.ExecuteNo~dulla^@204~          lblStrip.Text = "Inserted in~dulla^@204~ le."
        Catch SqlExceptionErr A~dulla^@204~ n
            MessageBox.Show(SqlExc~dulla^@204~ sage)
        End Try

        ' C~dulla^@204~ ection...
        objConnection.Clos~dulla^@204~     ' Inform the Supplier ID
       ~dulla^@204~ Show("The suplier ID is " & strID)
 ~dulla^@204~ o.Text = strID
        lblInfo2.Text~dulla^@204~ eNo.Text


        ' Let the user ~dulla^@204~ ed products

        grdPurchaseInf~dulla^@204~ rue
        lblStrip.Text = "Now you~dulla^@204~ he products purchased in the grid."
~dulla^@204~ jCommand3.Connection = objConnection~dulla^@204~ bjCommand3.CommandText = "INSERT INTO~dulla^@204~  " & _
        '"PartNo,Description,~dulla^@204~ n, NetWeight, Quantity, Price,Amount ~dulla^@204~ Info)" & _
        '"VALUES(@PartNo,~dulla^@204~  @Brand, @Origin, @NetWeight, @Quanti~dulla^@204~ mount)"



        ' Add parameters for the placeholders in the SQL in the~dulla^@204~ mmandText property...
        ' Para~dulla^@204~  SupplierID column...

        ' Di~dulla^@204~  Integer

        'For intCount = 0~dulla^@204~ aseInfo.RowCount - 1)
        '     ~dulla^@204~ As String
        '      PartNo = gr~dulla^@204~ .Item(0, 0).Value
        '     objC~dulla^@204~ eters.AddWithValue("@PartNo", PartNo)~dulla^@204~   MsgBox(PartNo)
        'Next

  ~dulla^@204~     Private Sub btnSetPrice_Click(ByV~dulla^@204~ System.Object, ByVal e As System.Even~dulla^@204~ s btnSetPrice.Click
        PriceSet~dulla^@204~     End Sub

    Private Sub picClo~dulla^@204~ l sender As System.Object, ByVal e As~dulla^@204~ Args) Handles picClose.Click
       ~dulla^@204~ 
    End Sub

    Private Sub picM~dulla^@204~ (ByVal sender As System.Object, ByVal~dulla^@204~ EventArgs) Handles picMinimize.Click~dulla^@204~ indowState = FormWindowState.Minimize~dulla^@204~ b

    Private Sub btnHome_Click(By~dulla^@204~  System.Object, ByVal e As System.Eve~dulla^@204~ es btnHome.Click
        Home.Hide()~dulla^@204~ Hide()
        Home.Show()
    End ~dulla^@204~ ivate Sub grdPurchaseInfo_RowLeave(By~dulla^@204~  Object, ByVal e As System.Windows.Fo~dulla^@204~ iewCellEventArgs) Handles grdPurchase~dulla^@204~ 

        Dim noOfRows As Integer
~dulla^@204~ ows = grdPurchaseInfo.RowCount - 1
~dulla^@204~ i As Integer = 0 To noOfRows
       ~dulla^@204~ rchaseInfo.Item(0, i).Value IsNot DBN~dulla^@204~ Also grdPurchaseInfo.Item(0, i).Value~dulla^@204~                 grdPurchaseInfo.Item(~dulla^@204~  lblInfo.Text
                grdPur~dulla^@204~ m(9, i).Value = lblInfo2.Text
      ~dulla^@204~ 
        Next

    End Sub

    P~dulla^@204~ tMiscellaneousCost_Leave(ByVal sender~dulla^@204~ yVal e As System.EventArgs) Handles t~dulla^@204~ usCost.Leave
        Dim total, frie~dulla^@204~ eous As Double
        total = txtTo~dulla^@204~      frieght = txtFrieghtCost.Text
 ~dulla^@204~ aneous = txtMiscellaneousCost.Text
~dulla^@204~ randTotal.Text = total + frieght + misellaneous
    End Sub
End Class