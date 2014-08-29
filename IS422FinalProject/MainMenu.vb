Public Class EvOrdBtn

    ' Handles "New Food Order" button being clicked
    Private Sub NewFoodOrderBtn_Click(sender As Object, e As EventArgs) Handles NewFoodOrderBtn.Click
        ' Instantiate and show a new form
        Dim foodOrderForm As New NewFoodOrder
        foodOrderForm.Show()
    End Sub

    ' Handles "New Supply Order" button being clicked
    Private Sub NewSupplyOrderBtn_Click(sender As Object, e As EventArgs) Handles NewSupplyOrderBtn.Click

        ' Instantiate and show a new form
        Dim supplyForm As New NewSupplyOrder
        supplyForm.Show()

    End Sub

    ' Handles "Add Manager" button being clicked
    Private Sub AddManagerBtn_Click(sender As Object, e As EventArgs) Handles AddManagerBtn.Click
        ' Instantiate and show a new form
        Dim addManagerForm As New AddManager
        addManagerForm.Show()
    End Sub

    ' Handles "Add Student" button being clicked
    Private Sub AddStudentBtn_Click(sender As Object, e As EventArgs) Handles AddStudentBtn.Click
        ' Instantiate and show a new form
        Dim addstudentviewForm As New addstudentview
        addstudentviewForm.Show()
    End Sub

    ' Handles "Scheduling" button being clicked
    Private Sub SchedulingBtn_Click(sender As Object, e As EventArgs) Handles SchedulingBtn.Click
        ' Instantiate and show a new form
        Dim schedulingForm As New employeesched
        schedulingForm.Show()
    End Sub

    ' Handles "Invoices" button being clicked
    Private Sub InvoicesBtn_Click(sender As Object, e As EventArgs) Handles InvoicesBtn.Click
        ' Instantiate and show a new form
        Dim invoiceViewForm As New InvoiceView
        invoiceViewForm.Show()
    End Sub

    ' Handles "Event-Order Summary" button being clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Instantiate and show a new form
        Dim eventOrderForm As New EventOrder
        eventOrderForm.Show()
    End Sub

    ' Handles "Cost of Labor" button being clicked
    Private Sub CostofLaborBtn_Click(sender As Object, e As EventArgs) Handles CostofLaborBtn.Click
        ' Instantiate and show a new form
        Dim costOfLaborForm As New CostOfLabor
        costOfLaborForm.Show()
    End Sub

    ' Handles "View Inventory" button being clicked
    Private Sub ViewInvBtn_Click(sender As Object, e As EventArgs) Handles ViewInvBtn.Click
        ' Instantiate and show a new form
        Dim inventoryForm As New Inventory
        inventoryForm.Show()
    End Sub

    ' Handles "Delivery Reports" button being clicked
    Private Sub DeliveryReportsBtn_Click(sender As Object, e As EventArgs) Handles DeliveryReportsBtn.Click
        ' Instantiate and show a new form
        Dim deliveryReportsForm As New Delivery_Reports
        deliveryReportsForm.Show()
    End Sub

    ' Handles "Add Delivery Driver" button being clicked
    Private Sub DriverInfoBtn_Click(sender As Object, e As EventArgs) Handles DriverInfoBtn.Click
        ' Instantiate and show a new form
        Dim deliveryDriverForm As New Delivery_Driver
        deliveryDriverForm.Show()
    End Sub

    ' Handles "Food Usage/Cost" button being clicked
    Private Sub FoodUsageBtn_Click(sender As Object, e As EventArgs) Handles FoodUsageBtn.Click
        ' Instantiate and show a new form
        Dim foodUsageForm As New FoodUsageCost
        foodUsageForm.Show()
    End Sub

    ' Handles "Event Revenues" button being clicked
    Private Sub eventRevBtn_Click(sender As Object, e As EventArgs) Handles eventRevBtn.Click
        ' Instantiate and show a new form
        Dim eventRevForm As New RevenueView
        eventRevForm.Show()
    End Sub

    ' Handles "Food Item View" button being clicked
    Private Sub FoodItemViewBtn_Click(sender As Object, e As EventArgs) Handles FoodItemViewBtn.Click
        ' Instantiate and show a new form
        Dim foodItemViewForm As New fooditemview
        foodItemViewForm.Show()
    End Sub

    ' Handles "Food Item View" button being clicked
    Private Sub FoodUsageReport_Click(sender As System.Object, e As System.EventArgs) Handles FoodUsageReport.Click
        ' Instantiate and show a new form
        Dim FoodUsageReportForm As New FoodUsageReport
        FoodUsageReportForm.Show()
    End Sub

    ' Handles "Occupancy" button being clicked
    Private Sub OccupancyBtn_Click(sender As Object, e As EventArgs) Handles OccupancyBtn.Click
        ' Instantiate and show a new form
        Dim OccupancyForm As New Occupancy_Data
        Occupancy_Data.Show()
    End Sub

    ' Handles "Occupancy" button being clicked
    Private Sub AddRmInfoBtn_Click(sender As Object, e As EventArgs) Handles AddRmInfoBtn.Click
        ' Instantiate and show a new form
        Dim AddRoomInputForm As New RoomInfoInput
        AddRoomInputForm.Show()
    End Sub
End Class