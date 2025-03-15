Imports System.Data.SqlClient

Public Class Form5

    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=Packing;Integrated Security=True;")
    Private Sub LoadPackagingData()
        Dim query As String = "SELECT * FROM Packaging"
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
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PackingDataSet.Packaging' table. You can move, or remove it, as needed.
        Me.PackagingTableAdapter.Fill(Me.PackingDataSet.Packaging)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("INSERT INTO Packaging (PackagingID, OrderID, Manf_date, Exp_date, WeightLimit) VALUES (@ID, @Order, @Manf, @Exp, @Weight)", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Order", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Manf", Convert.ToDateTime(TextBox3.Text))
        cmd.Parameters.AddWithValue("@Exp", Convert.ToDateTime(TextBox4.Text))
        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(TextBox5.Text))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Packaging Details Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadPackagingData()
        ClearTextBoxes()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Enter PackagingID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("DELETE FROM Packaging WHERE PackagingID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Packaging Details Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadPackagingData()
        ClearTextBoxes()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Enter PackagingID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand("UPDATE Packaging SET OrderID=@Order, Manf_date=@Manf, Exp_date=@Exp, WeightLimit=@Weight WHERE PackagingID=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Order", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Manf", Convert.ToDateTime(TextBox3.Text))
        cmd.Parameters.AddWithValue("@Exp", Convert.ToDateTime(TextBox4.Text))
        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(TextBox5.Text))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Packaging Details Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadPackagingData()
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