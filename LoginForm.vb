Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String
        Dim pass As String
        uname = UidTB.Text
        pass = PassTB.Text
        If (uname = "" Or pass = "") Then
            MsgBox(" Enter Your Credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel, "Employee Management System")
        ElseIf (uname.Equals("Admin") And pass.Equals("Admin@123")) Then
            HomeForm.Show()
            Me.Hide()
            UidTB.Text = ""
            PassTB.Text = ""

            MsgBox("Login Success", vbInformation + vbOKOnly, "Employee Management System")
        Else
            MsgBox("Wrong Username Or Password", MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "Employee Management System")
            PassTB.Text = ""
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UidTB.Clear()
        PassTB.Clear()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles PassTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(200, 0, 0, 0)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class