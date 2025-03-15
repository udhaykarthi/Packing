Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=Packing;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Admin WHERE Name=@AdminID AND Password=@Password", conn)


        cmd.Parameters.AddWithValue("@AdminID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

        Try
            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            If count > 0 Then
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim form2 As New Form2()
                form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
