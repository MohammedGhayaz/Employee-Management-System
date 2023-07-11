Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Reports
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer2.RefreshReport()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("select * from EmployeeTbl", con)
        Dim sd As New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sd.Fill(dt)
        With Me.ReportViewer2.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report2.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub HomeB_Click(sender As Object, e As EventArgs) Handles HomeB.Click
        HomeForm.Show()
        Me.Close()
    End Sub
End Class