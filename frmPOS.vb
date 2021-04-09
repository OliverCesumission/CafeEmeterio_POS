Public Class frmPOS
    Public SQL As New SQLControl
    Dim ProductCat As Integer
    Dim UnitItem As Integer
    Dim LastBillItemNo As Integer


    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        FetchOrderType()
        FetchCatList()
        lblDateTime.Text = Now()
        lblLogged.Text = frmLogin.txtUser.Text
        txtBillTotal.Text = Format("0.00")
        txtPromo.Text = Format("0.00")
        txtSubTotal.Text = Format("0.00")
        txtCash.Text = Format("0.00")
        txtChange.Text = Format("0.00")
        CreateBillNo()
        LoadDgv()

        If txtItem.Text = "" Then
            cmdAddToList.Enabled = False
        Else
            cmdAddToList.Enabled = True
        End If


    End Sub

    Private Sub CreateBillNo()
        Dim Bill As Integer
        Dim BillNo As String
        Dim NewBill As String
        '  Dim mo As String
        SQL.ExecQuery("Select BillNo from BillNoTracker;")

        If SQL.HasException(True) Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            Bill = r("BillNo") + 1
        Next

        BillNo = Format(Bill, "D4").ToString()
        '   mo = Now.Month.ToString()

        NewBill = Now.Year.ToString() + "-" + BillNo
        lblBillNo.Text = NewBill
        SQL.AddParam("@Bill", Bill)
        SQL.ExecQuery("Update BillNoTracker set BillNo = @Bill; ")

        SQL.AddParam("@BillNo", NewBill)
        SQL.AddParam("@BillDate", lblDateTime.Text)
        SQL.AddParam("@Logged", lblLogged.Text)

        SQL.ExecQuery("insert into CafeBillTemp (BillNo, BillDate, Cashier) values(@BillNo, @BillDate, @Logged); ")

    End Sub


    Private Sub FetchCatList()
        ' REFRESH LISTBOX
        lbxCategory.Items.Clear()
        ' RUN QUERY
        SQL.ExecQuery("SELECT ProductCategory from Dim_ProductCategory where IsActive= 1 ORDER BY ProductCategory;")
        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO LISTBOX
        For Each r As DataRow In SQL.DBDT.Rows
            lbxCategory.Items.Add(r("ProductCategory").ToString)
        Next

    End Sub


    Private Sub FetchItemList(Category As Integer)
        ' REFRESH LISTBOX
        lbxItem.Items.Clear()
        SQL.AddParam("@Item", Category)
        ' RUN QUERY

        SQL.ExecQuery("SELECT ItemID, Item, Price from Dim_Items where IsActive= 1  and ProductCategoryID = @Item ORDER BY Item;")
        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO LISTBOX
        For Each r As DataRow In SQL.DBDT.Rows
            lbxItem.Items.Add(r("Item").ToString)
        Next



    End Sub

    Private Sub FetchOrderType()
        ' REFRESH COMBOBOX
        cmbOrderType.Items.Clear()
        ' RUN QUERY
        SQL.ExecQuery("SELECT OrderType from Dim_OrderType ORDER BY OrderTypeID;")
        If SQL.HasException(True) Then Exit Sub
        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cmbOrderType.Items.Add(r("OrderType").ToString)
        Next
        cmbOrderType.Text = "Dine-in"

    End Sub

    Private Sub lbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCategory.SelectedIndexChanged
        Dim CategoryID As Integer
        SQL.AddParam("@CatID", lbxCategory.Text)
        SQL.ExecQuery("Select ProductCategoryID from Dim_ProductCategory where IsActive= 1 and ProductCategory = @CatID")
        For Each r As DataRow In SQL.DBDT.Rows
            CategoryID = r("ProductCategoryID")
        Next
        FetchItemList(CategoryID)
    End Sub

    Private Sub lbxItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxItem.SelectedIndexChanged
        txtItem.Text = lbxItem.Text
        SQL.AddParam("@Item", lbxItem.Text)
        SQL.ExecQuery("select Price from Dim_Items where Item = @Item ")
        If SQL.HasException(True) Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            txtPrice.Text = r("Price")
        Next

        txtQty.Text = 1
        txtDisc.Text = 0
        CalculateItemTotal()
        cmdAddToList.Enabled = True


    End Sub

    Private Sub LoadDgv()
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("Select BillItemNo, Item, Quantity, Price, Discount, ItemTotal from CafeSalesTemp where BillNo = @BillNo order by BillItemNo ; ")

        If SQL.HasException(True) Then Exit Sub

        dgvPOS.DataSource = SQL.DBDT


    End Sub




    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CalculateItemTotal()
    End Sub

    Private Sub CalculateItemTotal()
        Dim number As Decimal
        Dim ItemTotal As Decimal

        If Not String.IsNullOrEmpty(txtQty.Text) AndAlso Not String.IsNullOrEmpty(txtPrice.Text) AndAlso Not String.IsNullOrEmpty(txtDisc.Text) Then

            If Decimal.TryParse(txtQty.Text, number) Then
                txtQty.Text = Format(number, "0.00")
            End If
            If Decimal.TryParse(txtPrice.Text, number) Then
                txtPrice.Text = Format(number, "0.00")
            End If
            If Decimal.TryParse(txtDisc.Text, number) Then
                txtDisc.Text = Format(number, "0.00")
            End If

            ItemTotal = (txtQty.Text * txtPrice.Text)

            If txtDisc.Text > 0 Then
                ItemTotal = ItemTotal - (ItemTotal * (txtDisc.Text / 100))
            End If

            txtTotal.Text = ItemTotal


        End If

    End Sub

    Private Sub txtDisc_TextChanged(sender As Object, e As EventArgs) Handles txtDisc.TextChanged
        CalculateItemTotal()
    End Sub

    Private Sub GetIDs()
        SQL.AddParam("@ProductCategory", lbxCategory.Text)
        SQL.AddParam("@Item", lbxItem.Text)

        SQL.ExecQuery("select ProductCategoryID, ItemID from vwProductItems where ProductCategory = @ProductCategory and Item = @Item; ")
        If SQL.HasException(True) Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            ProductCat = r("ProductCategoryID")
            UnitItem = r("ItemID")
        Next



    End Sub

    Private Sub GetLastBillItemNo()
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("select isnull(max(BillItemNo),0) maxitemno from CafeSalesTemp where BillNo = @BillNo;")

        For Each r As DataRow In SQL.DBDT.Rows
            LastBillItemNo = r("maxitemno") + 1
        Next

    End Sub



    Private Sub cmdAddToList_Click(sender As Object, e As EventArgs) Handles cmdAddToList.Click
        GetIDs()
        GetLastBillItemNo()

        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.AddParam("@ProductCategoryID", ProductCat)
        SQL.AddParam("@ProductCategory", lbxCategory.Text)
        SQL.AddParam("@ItemID", UnitItem)
        SQL.AddParam("@Item", lbxItem.Text)
        SQL.AddParam("@Discount", txtDisc.Text)
        SQL.AddParam("@Quantity", txtQty.Text)
        SQL.AddParam("@Price", txtPrice.Text)
        SQL.AddParam("@ItemTotal", txtTotal.Text)
        SQL.AddParam("@LastBillItemNo", LastBillItemNo)

        SQL.ExecQuery("INSERT INTO CafeSalesTemp (BillNo, ProductCategoryID, ProductCategory, ItemID, Item, Discount, Quantity, Price, ItemTotal,BillItemNo) " & _
                      "VALUES (@BillNo, @ProductCategoryID, @ProductCategory, @ItemID, @Item, @Discount, @Quantity, @Price, @ItemTotal, @LastBillItemNo); ", True)

        If SQL.HasException(True) Then Exit Sub

        LoadDgv()
        cmdAddToList.Enabled = False
        txtItem.Clear()
        txtQty.Clear()
        txtPrice.Clear()
        txtDisc.Clear()
        txtTotal.Clear()

        CalculateBillTotal()

    End Sub
    Private Sub CalculateBillTotal()
        Dim BillTotal As Decimal
        Dim SubTotal As Decimal
        Dim number As Decimal
        '  Dim promodisc As Decimal


        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("select isnull(sum(ItemTotal),0) BillTotal from CafeSalesTemp where BillNo = @BillNo; ")

        If SQL.HasException(True) Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            BillTotal = r("BillTotal")
        Next
        txtBillTotal.Text = BillTotal

        If Decimal.TryParse(txtBillTotal.Text, number) Then
            txtBillTotal.Text = Format(number, "0.00")
        End If

        If Not String.IsNullOrEmpty(txtPromo.Text) Then

            If Decimal.TryParse(txtPromo.Text, number) Then
                txtPromo.Text = Format(number, "0.00")
            End If



            If txtPromo.Text > 0 Then

                SubTotal = BillTotal - (BillTotal * (txtPromo.Text / 100))
            Else
                SubTotal = BillTotal

            End If
        End If

        txtSubTotal.Text = SubTotal

    End Sub



    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim c As Integer
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("SELECT COUNT(*) c FROM CafeSalesTemp WHERE BillNo = @BillNo; ")

        If SQL.HasException(True) Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            c = r("c")
        Next

        If c > 0 Then

            Dim index As Integer = dgvPOS.CurrentRow.Index

            SQL.AddParam("@BillItemNo", index + 1)

            SQL.AddParam("@BillNo", lblBillNo.Text)

            SQL.ExecQuery("DELETE FROM CafeSalesTemp WHERE BillItemNo = @BillItemNo and BillNo = @BillNo; ")
            If SQL.HasException(True) Then Exit Sub
            SQL.ExecQuery("UPDATE x SET x.BillItemNo = x.New_BillItemNo FROM ( " & _
                    "SELECT BillItemNo, ROW_NUMBER() OVER (ORDER BY [BillItemNo]) AS New_BillItemNo FROM CafeSalesTemp) x; ", True)
            If SQL.HasException(True) Then Exit Sub
            LoadDgv()

            '  End If

            ' MessageBox.Show(index.ToString())
        End If

    End Sub

    Private Sub txtPromo_TextChanged(sender As Object, e As EventArgs) Handles txtPromo.TextChanged
        CalculateBillTotal()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        If txtItem.Text = "" Then
            cmdAddToList.Enabled = False
        Else
            cmdAddToList.Enabled = True
        End If
    End Sub

    Private Sub txtSave_Click(sender As Object, e As EventArgs) Handles txtSave.Click
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.AddParam("@TableNo", txtTableNo.Text)
        SQL.AddParam("@CustomerName", txtCustomer.Text)
        SQL.AddParam("@IDType", txtIDType.Text)
        SQL.AddParam("@IDNumber", txtIDNo.Text)
        SQL.AddParam("@BillTotal", txtBillTotal.Text)
        SQL.AddParam("@BillSub", txtSubTotal.Text)
        SQL.AddParam("@Promo", txtPromo.Text)
        SQL.AddParam("@Cash", txtCash.Text)
        SQL.AddParam("@Change", txtChange.Text)

        SQL.ExecQuery("Update CafeBillTemp " & _
                      "set TableNo = @TableNo, CustomerName = @CustomerName, IDType = @IDType, IDNumber = @IDNumber, PromoDiscount = @Promo, BillTotal = @BillTotal, BillSubTotal = @BillSub, Cash = @Cash, Change = @Change " & _
                      "where BillNo = @BillNo; ", True)

        If SQL.HasException(True) Then Exit Sub

        MsgBox("Record saved!")
    End Sub

    Private Sub txtCheckout_Click(sender As Object, e As EventArgs) Handles txtCheckout.Click
        
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("INSERT INTO CafeBill (BillNo, BillDate, Cashier,TableNo,CustomerName,IDType,IDNumber,PromoDiscount,BillTotal,BillSubTotal) " & _
        "SELECT BillNo, BillDate, Cashier,TableNo,CustomerName,IDType,IDNumber,PromoDiscount,BillTotal,BillSubTotal FROM CafeBillTemp " & _
        "WHERE BillNo = @BillNo;", True)

        If SQL.HasException(True) Then Exit Sub
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("INSERT INTO CafeSales (BillNo,ProductCategoryID,ProductCategory,ItemID,Item,Discount,Quantity,Price,ItemTotal,BillItemNo) " & _
        "SELECT BillNo,ProductCategoryID,ProductCategory,ItemID,Item,Discount,Quantity,Price,ItemTotal,BillItemNo FROM CafeSalesTemp " & _
        "WHERE BillNo = @BillNo;", True)

        If SQL.HasException(True) Then Exit Sub
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("DELETE FROM CafeSalesTemp WHERE BillNo = @BillNo;", True)
        If SQL.HasException(True) Then Exit Sub
        SQL.AddParam("@BillNo", lblBillNo.Text)
        SQL.ExecQuery("DELETE FROM CafeBillTemp WHERE BillNo = @BillNo;", True)
        If SQL.HasException(True) Then Exit Sub

        MsgBox("Bill check-out successful.")

        lblBillNo.Visible = False
        txtTableNo.Clear()
        txtCustomer.Clear()
        txtIDType.Clear()
        txtIDNo.Clear()
        txtBillTotal.Clear()
        txtSubTotal.Clear()
        txtPromo.Clear()
        cmdAddToList.Enabled = False
        txtItem.Clear()
        txtQty.Clear()
        txtPrice.Clear()
        txtDisc.Clear()
        txtTotal.Clear()
        txtChange.Clear()
        txtCash.Clear()
        lblBillNo.Text = "Posted"
        LoadDgv()


    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        CreateBillNo()
        lblBillNo.Visible = True
    End Sub


    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim Change As Decimal
        Dim number As Decimal

        If Not String.IsNullOrEmpty(txtCash.Text) Then

            If Decimal.TryParse(txtCash.Text, number) Then
                txtCash.Text = Format(number, "0.00")
            End If

            If Decimal.TryParse(txtSubTotal.Text, number) Then
                txtSubTotal.Text = Format(number, "0.00")
            End If

            Change = txtCash.Text - txtSubTotal.Text
            txtChange.Text = Change

            If Decimal.TryParse(txtChange.Text, number) Then
                txtChange.Text = Format(number, "0.00")
            End If
            'txtChange.Text = Format(Change, "0.00")
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class