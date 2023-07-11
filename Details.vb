Imports System.Data.SqlClient
Public Class Details
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()
        Try
            con.Open()
            Dim query = "select * from EmployeeTbl where EmpId=" & EmpID.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Employee ID not found.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
            For Each dr As DataRow In dt.Rows
                empnamelbl.Text = dr(1).ToString
                empaddlbl.Text = dr(2).ToString
                empposilbl.Text = dr(3).ToString
                empdoblbl.Text = dr(4).ToString
                empphonelbl.Text = dr(5).ToString
                empedulbl.Text = dr(6).ToString
                empgenderlbl.Text = dr(7).ToString
                empnamelbl.Visible = True
                empaddlbl.Visible = True
                empposilbl.Visible = True
                empphonelbl.Visible = True
                empdoblbl.Visible = True
                empedulbl.Visible = True
                empgenderlbl.Visible = True

            Next
            con.Close()

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HomeForm.Show()
        Me.Close()
    End Sub
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpID.Text = "" Then
            MsgBox("Please Enter The Employee Id", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If
        FetchEmployeeData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim printpreviewdialog1 As New PrintPreviewDialog
            printpreviewdialog1.Document = PrintDocument1
            printpreviewdialog1.TopMost = True
            PrintPreviewDialog1.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Bookman Old Style", 26, FontStyle.Bold), Brushes.Maroon, 180, 40)
        e.Graphics.DrawString("***Employee Summary***", New Font("Bookman Old Style", 23, FontStyle.Bold), Brushes.Maroon, 250, 100)
        e.Graphics.DrawString(" Name:       " + empnamelbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 210)
        e.Graphics.DrawString(" Address:    " + empaddlbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 260)
        e.Graphics.DrawString(" Position:   " + empposilbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 310)
        e.Graphics.DrawString(" Education:  " + empedulbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 360)
        e.Graphics.DrawString(" Phone:      " + empphonelbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 410)
        e.Graphics.DrawString(" Gender:     " + empgenderlbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 460)
        e.Graphics.DrawString(" DOB:        " + empdoblbl.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 140, 510)
        e.Graphics.DrawString("----- Thank You! -----", New Font("Bookman Old Style", 23, FontStyle.Bold), Brushes.Maroon, 250, 640)
    End Sub

    Private Sub EmpID_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub


End Class