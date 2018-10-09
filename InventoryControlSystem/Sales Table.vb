'Import Data and SqlClient namespaces...
Imports System.data
Imports System.Data.SqlClient

Public Class SalesTable

    Dim objConnection As New SqlConnection _
       ("Server= (local); Database= InventoryControlSystem; Integrated Security = true;")

    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataAdaptor2 As New SqlDataAdapter
    Dim objDataSet As DataSet
    Dim objDataSet2 As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Dim SalesInvoiceNo, TotalInWords As String
    Dim DateOfSale As Date
    Dim Amt As Integer
    Dim TotalAmt As Integer = 0
    Dim VATAmt, GrandTotal As Double

    Private Sub SalesTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prod4SalesDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter2.Fill(Me.Prod4SalesDataSet.Products)
        'TODO: This line of code loads data into the 'ProductsTableDataSet.Products' table. You can move, or remove it, as needed.
        'Me.ProductsTableAdapter1.Fill(Me.ProductsTableDataSet.Products)
        'TODO: This line of code loads data into the 'SalesInfoDataSet2.SalesInfo' table. You can move, or remove it, as needed.
        Me.SalesInfoTableAdapter2.Fill(Me.SalesInfoDataSet2.SalesInfo)
        'TODO: This line of code loads data into the 'SalesInfoDataSet.SalesInfo' table. You can move, or remove it, as needed.
        'Me.SalesInfoTableAdapter1.Fill(Me.SalesInfoDataSet2.SalesInfo)
        'TODO: This line of code loads data into the 'SalesDataSet.SalesInfo' table. You can move, or remove it, as needed.
        'Me.SalesInfoTableAdapter.Fill(Me.SalesDataSet.SalesInfo)

        ' Disable Sale button before calculating cost of products
        btnSale.Enabled = False

        'Find the maximum among InvoiceNo
        Dim SelectCmdMaxInvoiceNo As New SqlCommand
        SelectCmdMaxInvoiceNo.Connection = objConnection

        'SELECT command of maximum of Purchase
        SelectCmdMaxInvoiceNo.CommandText = _
        "SELECT COUNT(CashSalesInvoiceNo) FROM CashSales"

        objConnection.Open()
        Dim ObjInvoiceNo As Object = SelectCmdMaxInvoiceNo.ExecuteScalar
        objConnection.Close()

        SalesInvoiceNo = CType(ObjInvoiceNo, String)

        SalesInvoiceNo += 1
        'MsgBox("Assigning invoice no")
        lblInvoiceNo.Text = SalesInvoiceNo


        DateTimePicker1.Value = Date.Now
    End Sub


    Private Sub btnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSale.Click

        ' Get the date specified in the DateTimePicker
        DateOfSale = DateTimePicker1.Value.Date

        Totalinwords = txtGrandTotalInWords.Text


        ' The following code deducts the sold quantity from Products table

        Dim noOfRows As Integer
        noOfRows = grdSales.RowCount - 1
        ' MsgBox("noOfRows" & noOfRows)

        For i As Integer = 0 To noOfRows

            If grdSales.Item(0, i).Value IsNot DBNull.Value AndAlso grdSales.Item(2, i).Value <> 0 Then

                Dim PartNo As String  ', Description 
                Dim quantity As Integer
                PartNo = grdSales.Item(0, i).Value
                'Description = grdSales.Item(1, i).Value
                quantity = grdSales.Item(1, i).Value
                'MsgBox(quantity)

                Dim QtyBalance As Integer
                QtyBalance = 10 - quantity

                Dim objSelectCommand As New SqlCommand
                objSelectCommand.Connection = objConnection

                'SELECT command
                objSelectCommand.CommandText = _
                "SELECT TotalQuantity " & _
                "FROM Products " & _
                "WHERE PartNo LIKE '" & PartNo & "';"

                objConnection.Open()
                Dim ObjQuantity As Object = objSelectCommand.ExecuteScalar
                objConnection.Close()

                Dim avialableQuantity, newQuantity As Integer
                avialableQuantity = CType(ObjQuantity, String)

                'MsgBox("avialableQuantity " & avialableQuantity)
                'MsgBox("Quantity " & quantity)

                Dim objUpdateCommand As New SqlCommand
                objUpdateCommand.Connection = objConnection

                If quantity < avialableQuantity Then
                    newQuantity = avialableQuantity - quantity
                    'MsgBox("new Quantity " & newQuantity)
                    lblStrip.Text = "Processing sales..."


                    ' The following registers the sales info in cashSales table

                    Dim InsertCmdCashSales As New SqlCommand
                    InsertCmdCashSales.Connection = objConnection

                    'INSERT command to cashSales table
                    InsertCmdCashSales.CommandText = _
                    "INSERT INTO CashSales " & _
                    "(CashSalesInvoiceNo, DateOfSale, TotalAmount, VAT, GrandTotal, TotalInWords)" & _
                    "VALUES (@CashSalesInvoiceNo, @DateOfSale, @TotalAmount, @VAT, @GrandTotal, @TotalInWords);"

                    InsertCmdCashSales.Parameters.AddWithValue("@CashSalesInvoiceNo", SalesInvoiceNo)
                    InsertCmdCashSales.Parameters.AddWithValue("@DateOfSale", DateOfSale)
                    InsertCmdCashSales.Parameters.AddWithValue("@TotalAmount", TotalAmt)
                    InsertCmdCashSales.Parameters.AddWithValue("@VAT", VATAmt)
                    InsertCmdCashSales.Parameters.AddWithValue("@GrandTotal", GrandTotal)
                    InsertCmdCashSales.Parameters.AddWithValue("@TotalInWords", TotalInWords)

                    objConnection.Open()
                    InsertCmdCashSales.ExecuteNonQuery()
                    'MsgBox("Created in CashSales!")
                    lblStrip.Text = "The sold products are registered in CashSales table."
                    objConnection.Close()


                    'UPDATE statement of Product's table quantity
                    objUpdateCommand.CommandText = _
                    "UPDATE Products " & _
                    "SET TotalQuantity ='" & newQuantity & "'" & _
                    "WHERE PartNo LIKE '" & PartNo & "';"

                    objConnection.Open()
                    objUpdateCommand.ExecuteNonQuery()
                    objConnection.Close()
                    'MsgBox("Products table updated")

                    lblStrip.Text = "Products table updated"

                    ' Storing the amount sold in each products stock card

                    ' Check if the product has  its own stock card

                    Dim SelectCmdStockCard As New SqlCommand
                    SelectCmdStockCard.Connection = objConnection

                    'SELECT command
                    SelectCmdStockCard.CommandText = _
                    "SELECT PartNo " & _
                    "FROM StockCard " & _
                    "WHERE PartNo LIKE '" & PartNo & "';"

                    objConnection.Open()
                    Dim isAvialable As Object = SelectCmdStockCard.ExecuteScalar
                    objConnection.Close()

                    'Dim avialablePartNo, newQuantity As String

                    'avialableQuantity = CType(ObjQuantity, String)

                    If isAvialable <> PartNo And isAvialable IsNot DBNull.Value Then

                        'Find the maximum among StockCardNo

                        Dim SelectCmdMaxStockCard As New SqlCommand
                        SelectCmdMaxStockCard.Connection = objConnection

                        'SELECT command of maximum of stock card
                        SelectCmdMaxStockCard.CommandText = _
                        "SELECT COUNT(StockCardNo) FROM StockCard"

                        objConnection.Open()
                        Dim ObjStockCardNo As Object = SelectCmdMaxStockCard.ExecuteScalar
                        objConnection. ~dulla^@204~ ~dulla^@204~         Dim StockCardNo As String
  ~dulla^@204~          StockCardNo = CType(ObjStock~dulla^@204~ g)

                        StockCa~dulla^@204~ 
                        Dim InsertC~dulla^@204~ s New SqlCommand
                   ~dulla^@204~ dStockCard.Connection = objConnection~dulla^@204~                'INSERT command to sto~dulla^@204~ 
                        InsertCmdSto~dulla^@204~ dText = _
                        "I~dulla^@204~ ockCard " & _
                      ~dulla^@204~ No, PartNo)" & _
                   ~dulla^@204~ (@StockCardNo, @PartNo);"

        ~dulla^@204~    'Extention to the command with the~dulla^@204~ xt lines
                        ', ~dulla^@204~ llingPrice)" & _
                   ~dulla^@204~ Price, @SellingPrice);"

          ~dulla^@204~  InsertCmdStockCard.Parameters.AddWit~dulla^@204~ kCardNo", StockCardNo)
             ~dulla^@204~ sertCmdStockCard.Parameters.AddWithVa~dulla^@204~ , PartNo)
                        'I~dulla^@204~ Card.Parameters.AddWithValue("@Descri~dulla^@204~ iption)
                        'Ins~dulla^@204~ rd.Parameters.AddWithValue("@CostPric~dulla^@204~ )
                        'InsertCmd~dulla^@204~ ameters.AddWithValue("@SellingPrice",~dulla^@204~ )

                        objConne~dulla^@204~ 
                        InsertCmdSto~dulla^@204~ eNonQuery()
                        ~dulla^@204~ ted in stock card! Congra Ur dream co~dulla^@204~                        lblStrip.Text ~dulla^@204~  is created for all the new products"~dulla^@204~              objConnection.Close()
~dulla^@204~             ' Adding the sold product~dulla^@204~  in stock card Detail table

      ~dulla^@204~      Dim InsertCmdStockCardDetail As ~dulla^@204~ d
                        InsertCmdS~dulla^@204~ l.Connection = objConnection

     ~dulla^@204~       'INSERT command to stockcard ta~dulla^@204~                 InsertCmdStockCardDet~dulla^@204~ xt = _
                        "INSE~dulla^@204~ CardDetail " & _
                   ~dulla^@204~ nvoiceNo, DateOfSale, DateRecieved, Q~dulla^@204~ tyIssued, QtyBalance, StockCardNo)" &~dulla^@204~                "VALUES (@SalesInvoice~dulla^@204~ le, @DateRecieved, @QtyRecieved, @Qty~dulla^@204~ alance, @StockCardNo);"


        ~dulla^@204~    InsertCmdStockCardDetail.Parameter~dulla^@204~ e("@SalesInvoiceNo", SalesInvoiceNo)~dulla^@204~             InsertCmdStockCardDetail.~dulla^@204~ dWithValue("@DateOfSale", DateOfSale)~dulla^@204~              InsertCmdStockCardDetail~dulla^@204~ ddWithValue("@DateRecieved", "1/1/200~dulla^@204~      '  DateRecieved)
              ~dulla^@204~ ertCmdStockCardDetail.Parameters.AddW~dulla^@204~ yRecieved", 10)                      ~dulla^@204~ ieved)
                        Inser~dulla^@204~ Detail.Parameters.AddWithValue("@QtyI~dulla^@204~ ity)
                        InsertC~dulla^@204~ tail.Parameters.AddWithValue("@QtyBal~dulla^@204~ ance)
                        Insert~dulla^@204~ etail.Parameters.AddWithValue("@Stock~dulla^@204~ kCardNo)

                        o~dulla^@204~ Open()
                        Inser~dulla^@204~ Detail.ExecuteNonQuery()
           ~dulla^@204~ 'MsgBox("INSERTED in stock card DETAI~dulla^@204~ dream come true!")
                 ~dulla^@204~ ip.Text = "New products information i~dulla^@204~ ockCardDetail table"
               ~dulla^@204~ onnection.Close()
                  ~dulla^@204~                      ' Select the Sto~dulla^@204~ he particular PartNo that is being re~dulla^@204~                        Dim SelectCmdS~dulla^@204~  New SqlCommand
                    ~dulla^@204~ StockCardNo.Connection = objConnectio~dulla^@204~                 'SELECT command of ma~dulla^@204~ k card
                        Selec~dulla^@204~ No.CommandText = _
                 ~dulla^@204~ T StockCardNo " & _
                ~dulla^@204~  StockCard " & _
                   ~dulla^@204~ artNo LIKE '" & PartNo & "';"

    ~dulla^@204~        objConnection.Open()
        ~dulla^@204~    Dim ObjStockCardNo As Object = Sel~dulla^@204~ rdNo.ExecuteScalar
                 ~dulla^@204~ nection.Close()

                  ~dulla^@204~ ckCardNoOfPartNo As String
         ~dulla^@204~   StockCardNoOfPartNo = CType(ObjStoc~dulla^@204~ ng)

                        Dim Up~dulla^@204~ ardDetail As New SqlCommand
        ~dulla^@204~    UpdateCmdStockCardDetail.Connectio~dulla^@204~ tion

                        'INSE~dulla^@204~  stockcard table
                   ~dulla^@204~ dStockCardDetail.CommandText = _
   ~dulla^@204~         " Update StockCardDetail" & _~dulla^@204~              " SET DateOfSale =" & Da~dulla^@204~ 
                        ",QtyRecieve~dulla^@204~ 
                        ",QtyIssued~dulla^@204~ ty & _
                        ",Qty~dulla^@204~  QtyBalance & _
                    ~dulla^@204~ tockCardNo =" & StockCardNoOfPartNo &~dulla^@204~                    objConnection.Open~dulla^@204~                UpdateCmdStockCardDeta~dulla^@204~ Query()
                        'Msg~dulla^@204~ E PRODUCTS INFO INSERTED in stock car~dulla^@204~                         lblStrip.Text~dulla^@204~ d Detail is updated for the old Produ~dulla^@204~                   objConnection.Close~dulla^@204~              End If


            ~dulla^@204~ ing products to order table

      ~dulla^@204~  Dim objSelectCommand2 As New SqlComm~dulla^@204~             objSelectCommand2.Connect~dulla^@204~ ection

                    'SELECT~dulla^@204~                    objSelectCommand2.~dulla^@204~  _
                    "SELECT Reord~dulla^@204~ 
                    "FROM Products ~dulla^@204~               "WHERE PartNo LIKE '" &~dulla^@204~ "

                    objConnectio~dulla^@204~                  Dim ObjReorderLevel ~dulla^@204~ bjSelectCommand2.ExecuteScalar
     ~dulla^@204~   objConnection.Close()

          ~dulla^@204~  ReorderLevel As String
            ~dulla^@204~ erLevel = CType(ObjReorderLevel, Stri~dulla^@204~               If newQuantity <= Reord~dulla^@204~ 

                        'MsgBox("O~dulla^@204~ 1")
                        Dim objS~dulla^@204~  As New SqlCommand
                 ~dulla^@204~ ectCommand3.Connection = objConnectio~dulla^@204~                 'SELECT command 3
  ~dulla^@204~          objSelectCommand3.CommandTex~dulla^@204~                   "SELECT COUNT(Order~dulla^@204~ rs"

                        objCon~dulla^@204~ )
                        Dim ObjOrd~dulla^@204~ t = objSelectCommand3.ExecuteScalar
~dulla^@204~            objConnection.Close()

 ~dulla^@204~           Dim OrderNo As String
    ~dulla^@204~        OrderNo = CType(ObjOrderNo, St~dulla^@204~                     OrderNo += 1

 ~dulla^@204~           Dim objInsertCommand As New~dulla^@204~                         objInsertComm~dulla^@204~ n = objConnection

                ~dulla^@204~ RT command to order table
          ~dulla^@204~  objInsertCommand.CommandText = _
  ~dulla^@204~          "INSERT INTO Orders " & _
 ~dulla^@204~           "(OrderNo, PartNo)" & _
  ~dulla^@204~          "VALUES (@OrderNo, @PartNo);~dulla^@204~                 objInsertCommand.Para~dulla^@204~ hValue("@OrderNo", OrderNo)
        ~dulla^@204~    objInsertCommand.Parameters.AddWit~dulla^@204~ No", PartNo)
                       ~dulla^@204~ mmand.Parameters.AddWithValue("@Descr~dulla^@204~ ription)

                        o~dulla^@204~ Open()
                        objIn~dulla^@204~ xecuteNonQuery()
                   ~dulla^@204~ "Order exexuted!!!!!!!!!!!! Congra Ur~dulla^@204~ rue!")
                        lblSt~dulla^@204~ he product must be ordered. It is ins~dulla^@204~ rs Table."
                        o~dulla^@204~ Close()


                        ~dulla^@204~ g the sold products in SalesInfo tabl~dulla^@204~                 'Me.SalesInfoTableAda~dulla^@204~ e.SalesDataSet.SalesInfo)


      ~dulla^@204~  End If
                Else
      ~dulla^@204~  MessageBox.Show("That much quantity ~dulla^@204~ ble.", "SICS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
             ~dulla^@204~ ip.Text = "That much quantity is NOT ~dulla^@204~                 End If

           ~dulla^@204~           'MessageBox.Show("Done or N~dulla^@204~ l")
                lblStrip.Text = ~dulla^@204~         End If

        Next


 ~dulla^@204~ 
    Private Sub picClose_Click(ByVal~dulla^@204~ stem.Object, ByVal e As System.EventA~dulla^@204~ picClose.Click
        Me.Dispose()~dulla^@204~ 

    Private Sub picMinimize_Click(~dulla^@204~ As System.Object, ByVal e As System.E~dulla^@204~ dles picMinimize.Click
        Me.Wi~dulla^@204~ ormWindowState.Minimized
    End Sub~dulla^@204~ te Sub btnHome_Click(ByVal sender As ~dulla^@204~ , ByVal e As System.EventArgs) Handle~dulla^@204~ ck
        Home.Hide()
        Me.D~dulla^@204~      Home.Show()
    End Sub

    ~dulla^@204~ rdSales_RowLeave(ByVal sender As Obje~dulla^@204~ s System.Windows.Forms.DataGridViewCe~dulla^@204~ Handles grdSales.RowLeave
        Di~dulla^@204~ ce As Integer
        i = grdSales.C~dulla^@204~ wIndex

        If grdSales.Item(2,~dulla^@204~ ot DBNull.Value AndAlso grdSales.Item~dulla^@204~ ToString <> "" Then
            qty ~dulla^@204~ em(1, i).Value
            price = g~dulla^@204~ 2, i).Value
            grdSales.Ite~dulla^@204~  = qty * price
        End If

   ~dulla^@204~  the content of the GrandTotal
     ~dulla^@204~ ws As Integer
        noOfRows = grd~dulla^@204~ t - 1

        For k As Integer = 0~dulla^@204~ 
            Dim blankCheck As String~dulla^@204~  blankCheck = CType(grdSales.Item(1, ~dulla^@204~ ing)
            If grdSales.Item(1,~dulla^@204~ ot DBNull.Value AndAlso blankCheck <>~dulla^@204~ Sales.Item(1, k).Value

           ~dulla^@204~ dSales.Item(3, k).Value
            ~dulla^@204~ mt)
                TotalAmt += Amt~dulla^@204~ End If
        Next

        txtTo~dulla^@204~  TotalAmt

        VATAmt = 0.15 * ~dulla^@204~      txtVat.Text = VATAmt

        ~dulla^@204~ TotalAmt + VATAmt
        txtGrandTo~dulla^@204~ andTotal

        lblStrip.Text = "~dulla^@204~  done."

        ' Enable Sale butt~dulla^@204~ ulating cost of products
        btn~dulla^@204~ = True

    End Sub

    Private ~dulla^@204~ aGridViewTextBoxColumn_Disposed(ByVal~dulla^@204~ ject, ByVal e As System.EventArgs)
 ~dulla^@204~ e.Text = "Disposed"
    End Sub

 ~dulla^@204~ b btnGoToProducts_Click(ByVal sender ~dulla^@204~ ect, ByVal e As System.EventArgs) Han~dulla^@204~ roducts.Click
        Products.Show()
    End Sub
End Class

