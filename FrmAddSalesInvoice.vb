Imports System.Data.SqlClient

Public Class FrmAddSalesInvoice
    Public InvoiceID As Integer = 0

    Private CustomersDT As DataTable
    Private IsFiltering As Boolean = False

    Private CurrentRowIndex As Integer = -1

    Private CurrentProductID As Integer = 0

    Private ReadOnly NavigationColumns As String() =
        {
            "colProduct",
            "colUnit",
            "colQty",
            "colPrice"
        }

    Private Sub FrmAddSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCustomers()

        If InvoiceID = 0 Then

            GenerateInvoiceNo()

        Else

            LoadInvoice()

        End If

        dgvItems.SelectionMode = DataGridViewSelectionMode.CellSelect

        dgvItems.EditMode = DataGridViewEditMode.EditOnEnter

        dgvItems.MultiSelect = False

    End Sub

    Private Sub LoadCustomers()

        Try

            Dim cmd As New SqlCommand("SELECT CustomerID, CustomerName FROM Customers   ORDER BY CustomerName")

            CustomersDT = DatabaseHelper.GetDataTable(cmd)

            cmbCustomer.DataSource = CustomersDT.Copy()

            cmbCustomer.DisplayMember = "CustomerName"

            cmbCustomer.ValueMember = "CustomerID"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub GenerateInvoiceNo()

        Try
            Dim InvoiceYear As Integer = dtInvoiceDate.Value.Year

            Dim cmd As New SqlCommand("SELECT COUNT(*) + 1 FROM SalesInvoices WHERE YEAR(InvoiceDate)=@Year")

            cmd.Parameters.AddWithValue("@Year", InvoiceYear)

            Dim NextNo As Integer = Convert.ToInt32(DatabaseHelper.ExecuteScalar(cmd))

            txtInvoiceNo.Text = $"INV-{InvoiceYear}-{NextNo.ToString("00000")}"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadInvoice()

        Try

            Dim cmd As New SqlCommand("SELECT
                                        InvoiceNo,
                                        InvoiceDate,
                                        CustomerID,
                                        GrandTotal

                                     FROM SalesInvoices

                                     WHERE InvoiceID=@InvoiceID")

            cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count = 0 Then Exit Sub

            txtInvoiceNo.Text = dt.Rows(0)("InvoiceNo").ToString()

            dtInvoiceDate.Value = Convert.ToDateTime(dt.Rows(0)("InvoiceDate"))

            cmbCustomer.SelectedValue = dt.Rows(0)("CustomerID")

            txtGrandTotal.Text = Convert.ToDecimal(dt.Rows(0)("GrandTotal")).ToString("N2")

            LoadInvoiceDetails()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadInvoiceDetails()

        Try

            Dim cmd As New SqlCommand("SELECT
                                            SID.ProductID,
                                            P.ProductName,
                                            SID.ProductUnitID,
                                            U.UnitName,
                                            SID.Qty,
                                            SID.UnitPrice,
                                            SID.LineTotal

                                        FROM SalesInvoiceDetails SID

                                        INNER JOIN Products P
                                            ON SID.ProductID = P.ProductID

                                        INNER JOIN ProductUnits PU
                                            ON SID.ProductUnitID = PU.ProductUnitID

                                        INNER JOIN Units U
                                            ON PU.UnitID = U.UnitID

                                        WHERE SID.InvoiceID=@InvoiceID")

            cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            dgvItems.Rows.Clear()

            For Each row As DataRow In dt.Rows

                Dim r As Integer = dgvItems.Rows.Add()

                dgvItems.Rows(r).Cells("colProductID").Value = row("ProductID")

                dgvItems.Rows(r).Cells("colProduct").Value = row("ProductName")

                dgvItems.Rows(r).Cells("colProductUnitID").Value = row("ProductUnitID")

                dgvItems.Rows(r).Cells("colUnit").Value = row("UnitName")

                dgvItems.Rows(r).Cells("colQty").Value = row("Qty")

                dgvItems.Rows(r).Cells("colPrice").Value = row("UnitPrice")

                dgvItems.Rows(r).Cells("colTotal").Value = row("LineTotal")

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadProductsColumn()

        Dim cmd As New SqlCommand("SELECT ProductID, ProductName FROM Products  WHERE IsActive = 1
                                    ORDER BY ProductName")

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        Dim col As DataGridViewComboBoxColumn = CType(dgvItems.Columns("colProduct"), DataGridViewComboBoxColumn)

        col.DataSource = dt

        col.FlatStyle = FlatStyle.Standard

        col.DisplayMember = "ProductName"
        col.ValueMember = "ProductID"

    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        Try

            If cmbCustomer.SelectedValue Is Nothing Then Exit Sub

            Dim cmd As New SqlCommand("SELECT WorkDomain  FROM Customers  WHERE CustomerID=@CustomerID")

            cmd.Parameters.AddWithValue("@CustomerID", cmbCustomer.SelectedValue)

            Dim dt As DataTable =
            DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                txtWorkDomain.Text =
                dt.Rows(0)("WorkDomain").ToString()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtInvoiceDate_ValueChanged(sender As Object, e As EventArgs) Handles dtInvoiceDate.ValueChanged
        If InvoiceID = 0 Then
            GenerateInvoiceNo()
        End If
    End Sub


    Private Sub cmbCustomer_TextUpdate(sender As Object, e As EventArgs) Handles cmbCustomer.TextUpdate

        If IsFiltering Then Exit Sub

        IsFiltering = True

        Dim SearchText As String = cmbCustomer.Text

        Dim dv As New DataView(CustomersDT)

        dv.RowFilter = $"CustomerName LIKE '%{SearchText.Replace("'", "''")}%'"

        cmbCustomer.DataSource = Nothing

        cmbCustomer.Items.Clear()

        For Each row As DataRowView In dv

            cmbCustomer.Items.Add(row("CustomerName").ToString())

        Next

        cmbCustomer.Text = SearchText

        cmbCustomer.SelectionStart = SearchText.Length

        cmbCustomer.SelectionLength = 0

        cmbCustomer.DroppedDown = True

        IsFiltering = False

    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If dgvItems.Columns(e.ColumnIndex).Name = "colSearch" Then

            CurrentRowIndex = e.RowIndex

            Using frm As New FrmProductSearch

                If frm.ShowDialog() = DialogResult.OK Then

                    dgvItems.Rows(CurrentRowIndex).Cells("colProductID").Value = frm.SelectedProductID

                    dgvItems.Rows(CurrentRowIndex).Cells("colProduct").Value = frm.SelectedProductName

                    'LoadProductUnits(frm.SelectedProductID, CurrentRowIndex)

                End If

            End Using

        ElseIf dgvItems.Columns(e.ColumnIndex).Name = "colUnitSearch" Then

            CurrentRowIndex = e.RowIndex

            If dgvItems.Rows(e.RowIndex).Cells("colProductID").Value Is Nothing Then

                MessageBox.Show("اختر المنتج أولاً")

                Exit Sub

            End If

            CurrentProductID = Convert.ToInt32(dgvItems.Rows(e.RowIndex).Cells("colProductID").Value)

            LoadUnitsList(CurrentProductID)

        End If

    End Sub

    Private Sub LoadUnitsList(ProductID As Integer)

        lstUnits.Items.Clear()

        Dim cmd As New SqlCommand("SELECT  PU.ProductUnitID, U.UnitName  FROM ProductUnits PU
                                     INNER JOIN Units U
                                        ON PU.UnitID = U.UnitID

                                     WHERE PU.ProductID=@ProductID

                                     ORDER BY U.UnitName")

        cmd.Parameters.AddWithValue("@ProductID", ProductID)

        Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

        For Each row As DataRow In dt.Rows

            Dim item As New UnitItem

            item.ProductUnitID = Convert.ToInt32(row("ProductUnitID"))

            item.UnitName = row("UnitName").ToString()

            lstUnits.Items.Add(item)

        Next

        lstUnits.Visible = True

        lstUnits.BringToFront()

    End Sub

    Private Sub lstUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnits.SelectedIndexChanged

    End Sub

    Private Sub lstUnits_DoubleClick(sender As Object, e As EventArgs) Handles lstUnits.DoubleClick

        If lstUnits.SelectedItem Is Nothing Then Exit Sub

        Dim item As UnitItem = CType(lstUnits.SelectedItem, UnitItem)

        dgvItems.Rows(CurrentRowIndex).Cells("colUnit").Value = item.UnitName

        dgvItems.Rows(CurrentRowIndex).Cells("colProductUnitID").Value = item.ProductUnitID

        lstUnits.Items.Clear()

        lstUnits.Visible = False

    End Sub

    Private Sub CalculateRowTotal(RowIndex As Integer)

        If RowIndex < 0 Then Exit Sub

        Dim Qty As Decimal = 0
        Dim Price As Decimal = 0

        Decimal.TryParse(Convert.ToString(dgvItems.Rows(RowIndex).Cells("colQty").Value), Qty)

        Decimal.TryParse(Convert.ToString(dgvItems.Rows(RowIndex).Cells("colPrice").Value), Price)

        dgvItems.Rows(RowIndex).Cells("colTotal").Value = (Qty * Price).ToString("N2")

    End Sub

    Private Sub dgvItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellEndEdit

        If e.RowIndex < 0 Then Exit Sub

        Dim ColName As String = dgvItems.Columns(e.ColumnIndex).Name

        If ColName = "colQty" OrElse ColName = "colPrice" Then

            CalculateRowTotal(e.RowIndex)

            CalculateGrandTotal()

        End If

    End Sub

    Private Sub CalculateGrandTotal()

        Dim GrandTotal As Decimal = 0

        Dim InvoiceDiscount As Decimal = 0

        Dim LinesDiscount As Decimal = 0

        Dim ValueAddedTax As Decimal = 0

        Dim ExtraInvoiceDiscount As Decimal = 0

        For Each row As DataGridViewRow In dgvItems.Rows

            If row.IsNewRow Then Continue For

            Dim LineTotal As Decimal = 0

            Decimal.TryParse(Convert.ToString(row.Cells("colTotal").Value), LineTotal)

            GrandTotal += LineTotal

        Next

        txtGrandTotal.Text = GrandTotal.ToString("N2")

        ValueAddedTax = ((GrandTotal * 14) / 100)

        txtValueAddedTax.Text = ValueAddedTax.ToString("N2")

        Decimal.TryParse(txtInvoiceDiscount.Text, InvoiceDiscount)
        Decimal.TryParse(txtLinesDiscount.Text, LinesDiscount)
        Decimal.TryParse(txtExtraInvoiceDiscount.Text, ExtraInvoiceDiscount)

        txtInvoiceTotal.Text = ((GrandTotal + ValueAddedTax) -
                                (InvoiceDiscount + LinesDiscount + ExtraInvoiceDiscount)).ToString("N2")

    End Sub

    Private Sub dgvItems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItems.KeyDown

        If e.KeyCode = Keys.Enter OrElse
           e.KeyCode = Keys.Tab Then

            e.SuppressKeyPress = True

            MoveToNextCell()

        End If

    End Sub

    Private Sub MoveToNextCell()

        If dgvItems.CurrentCell Is Nothing Then Exit Sub

        Dim CurrentRow As Integer = dgvItems.CurrentCell.RowIndex

        Dim CurrentColumnName As String = dgvItems.Columns(dgvItems.CurrentCell.ColumnIndex).Name

        Dim CurrentIndex As Integer = Array.IndexOf(NavigationColumns, CurrentColumnName)

        If CurrentIndex = -1 Then Exit Sub

        If CurrentIndex < NavigationColumns.Length - 1 Then

            Dim NextColumnName = NavigationColumns(CurrentIndex + 1)

            dgvItems.CurrentCell = dgvItems.Rows(CurrentRow).Cells(NextColumnName)

        Else

            If dgvItems.Rows(CurrentRow).IsNewRow Then Exit Sub

            Dim NextRow As Integer = CurrentRow + 1

            If NextRow >= dgvItems.Rows.Count Then Exit Sub

            dgvItems.CurrentCell = dgvItems.Rows(NextRow).Cells(NavigationColumns(0))

        End If

        'dgvItems.BeginEdit(True)

    End Sub

    Private Function ValidateInvoice() As Boolean

        If cmbCustomer.SelectedValue Is Nothing Then

            MessageBox.Show("Please select customer")

            Return False

        End If

        Dim HasItem As Boolean = False

        For Each row As DataGridViewRow In dgvItems.Rows

            If row.IsNewRow Then Continue For

            If row.Cells("colProductID").Value IsNot Nothing Then

                HasItem = True

                Exit For

            End If

        Next

        If Not HasItem Then

            MessageBox.Show("Please add products")

            Return False

        End If

        Return True

    End Function

    Private Sub SaveInvoice()

        Using con As SqlConnection = DatabaseHelper.GetConnection()

            con.Open()

            Dim tran As SqlTransaction = con.BeginTransaction()

            Try

                '==========================
                ' Save Invoice Header
                '==========================

                Dim cmdInvoice As New SqlCommand("INSERT INTO SalesInvoices
                                                    (
                                                        InvoiceNo,
                                                        InvoiceDate,
                                                        CustomerID,
                                                        Notes,
                                                        GrandTotal,
                                                        InvoiceDiscount,
                                                        LinesDiscount,
                                                        ValueAddedTax,
                                                        ExtraInvoiceDiscount,
                                                        InvoiceTotal
                                                    )
                                                    VALUES
                                                    (
                                                        @InvoiceNo,
                                                        @InvoiceDate,
                                                        @CustomerID,
                                                        @Notes,
                                                        @GrandTotal,
                                                        @InvoiceDiscount,
                                                        @LinesDiscount,
                                                        @ValueAddedTax,
                                                        @ExtraInvoiceDiscount,
                                                        @InvoiceTotal
                                                    )

                                                    SELECT CAST(SCOPE_IDENTITY() AS INT)",
                                                        con,
                                                        tran)

                cmdInvoice.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text)

                cmdInvoice.Parameters.AddWithValue("@InvoiceDate", dtInvoiceDate.Value)

                cmdInvoice.Parameters.AddWithValue("@CustomerID", cmbCustomer.SelectedValue)

                cmdInvoice.Parameters.AddWithValue("@Notes", txtNotes.Text)

                cmdInvoice.Parameters.AddWithValue("@GrandTotal", Convert.ToDecimal(txtGrandTotal.Text))

                cmdInvoice.Parameters.AddWithValue("@InvoiceDiscount", Convert.ToDecimal(txtInvoiceDiscount.Text))

                cmdInvoice.Parameters.AddWithValue("@LinesDiscount", Convert.ToDecimal(txtLinesDiscount.Text))

                cmdInvoice.Parameters.AddWithValue("@ValueAddedTax", Convert.ToDecimal(txtValueAddedTax.Text))

                cmdInvoice.Parameters.AddWithValue("@ExtraInvoiceDiscount", Convert.ToDecimal(txtExtraInvoiceDiscount.Text))

                cmdInvoice.Parameters.AddWithValue("@InvoiceDiscount", Convert.ToDecimal(txtInvoiceDiscount.Text))

                Dim InvoiceID As Integer = Convert.ToInt32(cmdInvoice.ExecuteScalar())

                '==========================
                ' Save Details
                '==========================

                For Each row As DataGridViewRow In dgvItems.Rows

                    If row.IsNewRow Then Continue For

                    If row.Cells("colProductID").Value Is Nothing Then
                        Continue For
                    End If

                    'MessageBox.Show(row.Cells("colTotal").Value.ToString())

                    Dim cmdDetail As New SqlCommand("INSERT INTO SalesInvoiceDetails
                                                    (
                                                        InvoiceID,
                                                        ProductID,
                                                        ProductUnitID,
                                                        Qty,
                                                        UnitPrice,
                                                        LineTotal
                                                    )
                                                    VALUES
                                                    (
                                                        @InvoiceID,
                                                        @ProductID,
                                                        @ProductUnitID,
                                                        @Qty,
                                                        @UnitPrice,
                                                        @LineTotal
                                                    )",
                                                        con,
                                                        tran)

                    cmdDetail.Parameters.AddWithValue("@InvoiceID", InvoiceID)

                    cmdDetail.Parameters.AddWithValue("@ProductID", row.Cells("colProductID").Value)

                    cmdDetail.Parameters.AddWithValue("@ProductUnitID", row.Cells("colProductUnitID").Value)

                    cmdDetail.Parameters.AddWithValue("@Qty", Val(row.Cells("colQty").Value))

                    cmdDetail.Parameters.AddWithValue("@UnitPrice", Val(row.Cells("colPrice").Value))

                    cmdDetail.Parameters.AddWithValue("@LineTotal", Convert.ToDecimal(row.Cells("colTotal").Value))

                    cmdDetail.ExecuteNonQuery()

                Next

                tran.Commit()

                MessageBox.Show("Invoice Saved Successfully")

                Me.DialogResult = DialogResult.OK

                Me.Close()

            Catch ex As Exception

                tran.Rollback()

                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Sub

    Private Sub UpdateInvoice()

        Using con As SqlConnection = DatabaseHelper.GetConnection()

            con.Open()

            Dim tran As SqlTransaction = con.BeginTransaction()

            Try

                '=================================
                ' Update Header
                '=================================

                Dim cmdUpdate As New SqlCommand("UPDATE SalesInvoices
                                                 SET
                                                    InvoiceNo=@InvoiceNo,
                                                    InvoiceDate=@InvoiceDate,
                                                    CustomerID=@CustomerID,
                                                    GrandTotal=@GrandTotal
                                                    InvoiceDiscount=@InvoiceDiscount,
                                                    LinesDiscount=@LinesDiscount,
                                                    ValueAddedTax=@ValueAddedTax,
                                                    ExtraInvoiceDiscount=@ExtraInvoiceDiscount,
                                                    InvoiceTotal=@InvoiceTotal

                                                 WHERE InvoiceID=@InvoiceID", con, tran)

                cmdUpdate.Parameters.AddWithValue("@InvoiceID", InvoiceID)

                cmdUpdate.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text)

                cmdUpdate.Parameters.AddWithValue("@InvoiceDate", dtInvoiceDate.Value)

                cmdUpdate.Parameters.AddWithValue("@CustomerID", cmbCustomer.SelectedValue)

                cmdUpdate.Parameters.AddWithValue("@GrandTotal", Val(txtGrandTotal.Text))

                cmdUpdate.Parameters.AddWithValue("@InvoiceDiscount", Convert.ToDecimal(txtInvoiceDiscount.Text))

                cmdUpdate.Parameters.AddWithValue("@LinesDiscount", Convert.ToDecimal(txtLinesDiscount.Text))

                cmdUpdate.Parameters.AddWithValue("@ValueAddedTax", Convert.ToDecimal(txtValueAddedTax.Text))

                cmdUpdate.Parameters.AddWithValue("@ExtraInvoiceDiscount", Convert.ToDecimal(txtExtraInvoiceDiscount.Text))

                cmdUpdate.Parameters.AddWithValue("@InvoiceDiscount", Convert.ToDecimal(txtInvoiceDiscount.Text))

                cmdUpdate.ExecuteNonQuery()

                '=================================
                ' Delete Old Details
                '=================================

                Dim cmdDelete As New SqlCommand("DELETE FROM SalesInvoiceDetails
                                                    WHERE InvoiceID=@InvoiceID", con, tran)

                cmdDelete.Parameters.AddWithValue("@InvoiceID", InvoiceID)

                cmdDelete.ExecuteNonQuery()

                '=================================
                ' Insert Details Again
                '=================================

                For Each row As DataGridViewRow In dgvItems.Rows

                    If row.IsNewRow Then Continue For

                    If row.Cells("colProductID").Value Is Nothing Then
                        Continue For
                    End If

                    Dim cmdDetail As New SqlCommand("INSERT INTO SalesInvoiceDetails
                                                        (
                                                            InvoiceID,
                                                            ProductID,
                                                            ProductUnitID,
                                                            Qty,
                                                            UnitPrice,
                                                            LineTotal
                                                        )
                                                        VALUES
                                                        (
                                                            @InvoiceID,
                                                            @ProductID,
                                                            @ProductUnitID,
                                                            @Qty,
                                                            @UnitPrice,
                                                            @LineTotal
                                                        )", con, tran)

                    cmdDetail.Parameters.AddWithValue("@InvoiceID", InvoiceID)

                    cmdDetail.Parameters.AddWithValue("@ProductID", row.Cells("colProductID").Value)

                    cmdDetail.Parameters.AddWithValue("@ProductUnitID", row.Cells("colProductUnitID").Value)

                    cmdDetail.Parameters.AddWithValue("@Qty", Val(row.Cells("colQty").Value))

                    cmdDetail.Parameters.AddWithValue("@UnitPrice", Val(row.Cells("colPrice").Value))

                    cmdDetail.Parameters.AddWithValue("@LineTotal", Convert.ToDecimal(row.Cells("colTotal").Value))

                    cmdDetail.ExecuteNonQuery()

                Next

                tran.Commit()

                MessageBox.Show(
                "Invoice Updated Successfully")

                Me.DialogResult = DialogResult.OK

                Me.Close()

            Catch ex As Exception

                tran.Rollback()

                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not ValidateInvoice() Then Exit Sub

        If InvoiceID = 0 Then

            SaveInvoice()

        Else

            UpdateInvoice()

        End If

    End Sub

    Private Sub dgvItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        If e.RowIndex < 0 Then Exit Sub

        If dgvItems.Columns(e.ColumnIndex).Name = "colDelete" Then

            Dim result As DialogResult = MessageBox.Show("هل تريد حذف هذا السطر ؟", "تأكيد",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                dgvItems.Rows.RemoveAt(e.RowIndex)

                CalculateGrandTotal()

            End If

        End If
    End Sub

    Private Sub txtInvoiceDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceDiscount.TextChanged
        CalculateGrandTotal()
    End Sub

    Private Sub txtLinesDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtLinesDiscount.TextChanged
        CalculateGrandTotal()
    End Sub

    Private Sub txtExtraInvoiceDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtExtraInvoiceDiscount.TextChanged
        CalculateGrandTotal()
    End Sub
End Class
