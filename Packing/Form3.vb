
Imports System.Data.SqlClient
Public Class Form3
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=Packing;Integrated Security=True;")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.PackingDataSet.Customer)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("INSERT INTO Customer (CustomerID, Name, Address, MobileNumber, PaymentStatus) VALUES (@ID, @Name, @Address, @Mobile, @Status)", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Status", TextBox5.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTextBoxes()
        LoadCustomerData()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Enter CustomerID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New SqlCommand("UPDATE Customer SET Name=@Name, Address=@Address, MobileNumber=@Mobile, PaymentStatus=@Status WHERE CustomerID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Status", TextBox5.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Customer Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTextBoxes()
        LoadCustomerData()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter CustomerID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New SqlCommand("DELETE FROM Customer WHERE CustomerID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Customer Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTextBoxes()
        LoadCustomerData()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClearTextBoxes()

    End Sub

    Private Sub LoadCustomerData()
        Dim query As String = "SELECT * FROM Customer"
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class