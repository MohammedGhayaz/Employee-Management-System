Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class EmployeeForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles HomeB.Click

        HomeForm.Show()
        Me.Hide()
    End Sub
    Private Sub displayetb()
        con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddB.Click
        Try
            If Ename.Text = "" Or Eaddress.Text = "" Or EGender.Text = "-1" Or EPosition.Text = "-1" Or EPhone.Text = "" Or EEducation.Text = "-1" Then
                MsgBox("Please Enter The Credentials", MsgBoxStyle.Exclamation)


            Else
                    con.Open()
                Dim query As String
                query = "insert into EmployeeTbl values('" & Ename.Text & "','" & Eaddress.Text & "','" & EPosition.SelectedItem.ToString() & "','" & EDOBdtp.Value & "','" & EPhone.Text & "','" & EEducation.SelectedItem.ToString() & "','" & EGender.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Added", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success!")
                con.Close()
                displayetb()
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()

    End Sub
    Dim key = 0

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteB.Click
        If key = 0 Then
            MsgBox("Select The Employee To Be Deleted")
        Else
            Try
                con.Open()
                Dim query As String
                query = "Delete from EmployeeTbl where EmpId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                con.Close()
                displayetb()
                clear()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End Try

        End If
    End Sub
    Private Sub clear()
        Ename.Clear()
        Eaddress.Clear()
        EPhone.Clear()
        EEducation.Text = ""
        EGender.Text = ""
        EPosition.Text = ""
        key = 0

    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            key = Convert.ToInt32(row.Cells(0).Value.ToString())
            Ename.Text = row.Cells(1).Value.ToString()
            Eaddress.Text = row.Cells(2).Value.ToString()
            EPosition.Text = row.Cells(3).Value.ToString()
            EDOBdtp.Value = row.Cells(4).Value.ToString()
            EPhone.Text = row.Cells(5).Value.ToString()
            EEducation.Text = row.Cells(6).Value.ToString()
            EGender.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EditB.Click
        If Ename.Text = "" Or Eaddress.Text = "" Or EPhone.Text = "" Then
            MsgBox("Missing Information ")
        Else
            con.Open()
            Dim query As String
            query = "Update EmployeeTbl set EmpName='" & Ename.Text & "',EmpAdd='" & Eaddress.Text & "',EmpPos='" & EPosition.SelectedItem.ToString() & "',EmpDob='" & EDOBdtp.Value & "',EmpPhone='" & EPhone.Text & "',EmpEdu='" & EEducation.SelectedItem.ToString() & "',EmpGen='" & EGender.SelectedItem.ToString() & "'where EmpId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            con.Close()
            displayetb()
            clear()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub Ename_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ename.Validating
        Dim name As String = Ename.Text
        Dim regex As New Regex("^[a-zA-Z\s]+$")
        If Not regex.IsMatch(name) Then
            MsgBox("Invalid name entered.Name should only contain letters and spaces")
            e.Cancel = True
        End If
        If name.Length < 2 Or name.Length > 25 Then
            MsgBox("Incorrect name. Name should b between 2 and 25 characters ")
            e.Cancel = True
        End If

    End Sub

    Private Sub EPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EPhone.Validating
        Dim phone As String = EPhone.Text
        Dim regex As New Regex("^\d{10}$")
        If Not regex.IsMatch(phone) Then
            MsgBox("Incorrect phone number.Phone numeber should be 10 digits long")
            e.Cancel = True
        End If
    End Sub

    Private Sub Eaddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Eaddress.Validating
        Dim city As String = Eaddress.Text
        Dim regex As New Regex("^[a-zA-z\s]+$")
        If Not regex.IsMatch(city) Then
            MsgBox("Incorrect city name.City name should only contain letters and spaces")
            e.Cancel = True
        End If
    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayetb()
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub EDOBdtp_ValueChanged(sender As Object, e As EventArgs) Handles EDOBdtp.ValueChanged
        Try
            Dim selectedDate As Date = EDOBdtp.Value
            Dim currentYear As Integer = DateTime.Now.Year
            Dim maximumYear As Integer = currentYear - 15

            If selectedDate.Year > maximumYear Then
                MessageBox.Show("Date cannot be less than 10 years from current year")
                EDOBdtp.Value = New Date(1990, 1, 1)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class