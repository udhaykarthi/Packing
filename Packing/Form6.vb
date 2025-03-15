Imports System.Data.SqlClient

Public Class Form6

    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=Packing;Integrated Security=True;")


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PackingDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.PackingDataSet.Product)

    End Sub
    Private Sub LoadProductData()
        Dim query As String = "SELECT * FROM Product"
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("INSERT INTO Product (ProductID, Name, Category, Weight) VALUES (@ID, @Name, @Category, @Weight)", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Category", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(TextBox4.Text))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Product Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadProductData()
        ClearTextBoxes()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Enter ProductID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("UPDATE Product SET Name=@Name, Category=@Category, Weight=@Weight WHERE ProductID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Category", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(TextBox4.Text))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadProductData()
        ClearTextBoxes()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Enter ProductID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("DELETE FROM Product WHERE ProductID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadProductData()
        ClearTextBoxes()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ClearTextBoxes()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()

    End Sub
End Class