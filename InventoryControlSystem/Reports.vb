Public Class Reports

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Dispose()
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRptProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptProducts.Click
        ReportOfProducts.Show()
    End Sub

    Private Sub btnOrdersReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdersReport.Click
        ReportOfOrders.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportOfStockCard.Show()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Hide()
        Me.Hide()
        Home.Show()
    End Sub
End Class