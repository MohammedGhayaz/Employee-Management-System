Imports System.Data.SqlClient
Public Class SalaryForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HomeForm.Show()
        Me.Close()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
    Private Sub FetchEmployeeData()
        Try
            con.Open()
            Dim query = "select * from EmployeeTbl where EmpId = " & EmpIdTxt.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Employee ID Not Found.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
            For Each dr As DataRow In dt.Rows
                EmpNameLbl.Text = dr(1).ToString
                EmpPosiLbl.Text = dr(3).ToString
                EmpNameLbl.Visible = True
                EmpPosiLbl.Visible = True
            Next
            con.Close()
        Catch ex As Exception

            con.Close()
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpIdTxt.Text = "" Then
            MsgBox("Please Enter The Employee Id", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If
        FetchEmployeeData()

    End Sub
    Dim dailypay
    Dim netsal
    Dim hra, da, tax
    Private Sub calculate()

        hra = dailypay * 10 / 100
        da = dailypay * 15 / 100
        tax = dailypay * 18 / 100
        netsal = dailypay + da + hra - tax
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (EmpPosiLbl.Text = "") Then
                MsgBox("Select an Employee", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                If EmpPosiLbl.Text = "Manager" Then
                    dailypay = 30000
                ElseIf EmpPosiLbl.Text = "Front-End Developer" Then
                    dailypay = 50000
                ElseIf EmpPosiLbl.Text = "Back-End Developer" Then
                    dailypay = 60000
                ElseIf EmpPosiLbl.Text = "Full-Stack Developer" Then
                    dailypay = 80000
                ElseIf EmpPosiLbl.Text = "Developer" Then
                    dailypay = 63000
                ElseIf EmpPosiLbl.Text = "Analyst" Then
                    dailypay = 47000
                ElseIf EmpPosiLbl.Text = "Assistant Manager" Then
                    dailypay = 25000
                ElseIf EmpPosiLbl.Text = "Tester" Then
                    dailypay = 25000
                End If
                calculate()
                Dim total = netsal
                SalaryRichTB.Text = "Employee ID:            " + EmpIdTxt.Text + vbCrLf + "Employee Name:      " + EmpNameLbl.Text + vbCrLf + "Employee Position:    " + EmpPosiLbl.Text + vbCrLf + "Basic Salary:            " + Convert.ToString(dailypay) + vbCrLf + "DA:                        " + Convert.ToString(da) + vbCrLf + "HRA:                          " + Convert.ToString(hra) + vbCrLf + "TAX:                         " + Convert.ToString(tax) + vbCrLf + "Net Salary:                          " + Convert.ToString(total)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim printpreviewdialog1 As New PrintPreviewDialog
            printpreviewdialog1.Document = PrintDocument1
            printpreviewdialog1.TopMost = True
            printpreviewdialog1.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Bookman Old Style", 25, FontStyle.Bold), Brushes.Maroon, 180, 40)
        e.Graphics.DrawString("***PaySlip***", New Font("Bookman Old Style", 20, FontStyle.Bold), Brushes.Maroon, 330, 100)
        e.Graphics.DrawString(SalaryRichTB.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, 150, 190)
        e.Graphics.DrawString("----- Thanks For Your Services -----", New Font("Bookman Old Style", 18, FontStyle.Bold), Brushes.Maroon, 200, 530)
    End Sub

    Private Sub EmpIdTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpIdTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class