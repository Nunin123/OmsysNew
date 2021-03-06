Public Class frmMainScreen
    Sub dgv_styleRow()
        For i As Integer = 0 To OMSys_OrdersV2DBDataGridView.RowCount - 1
            If i Mod 2 = 0 Then
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersV2DB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        dgv_styleRow()
    End Sub
    Private Sub OMSys_OrdersDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OMSys_OrdersV2DBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        OMSys_OrdersV2DBBindingSource.AddNew()
        dgv_styleRow()
    End Sub

    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If IDTextBox.Text = "" Or Customer_NameTextBox.Text = "" Or Product_NameTextBox.Text = "" Or
            QuantityTextBox.Text = "" Or cboStatus.Text = "" Then

            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Order saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call doNothing()
            Exit Sub
        Else
            OMSys_OrdersV2DBBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Customer_Name LIKE '" & txtSearch.Text & "') OR (Product_Name LIKE '" & txtSearch.Text & "')" &
                "OR (Address LIKE '" & txtSearch.Text & "') OR (Status LIKE '" & txtSearch.Text & "')"

            If OMSys_OrdersV2DBBindingSource.Count <> 0 Then
                With OMSys_OrdersV2DBDataGridView
                    .DataSource = OMSys_OrdersV2DBBindingSource
                End With
            Else
                MessageBox.Show("Nothing found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'OMSys_OrdersV2DBBindingSource = Nothing
                Call displayAll()
            End If
        End If
    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        Me.OMSys_OrdersV2DBBindingSource.RemoveFilter()
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        Dim total As Decimal

        total = Val(txtPrice.Text) * Val(QuantityTextBox.Text)
        Total_PriceTextBox.Text = total
    End Sub

    Private Sub OMSys_OrdersV2DBDataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles OMSys_OrdersV2DBDataGridView.DataSourceChanged
        dgv_styleRow()
    End Sub
End Class