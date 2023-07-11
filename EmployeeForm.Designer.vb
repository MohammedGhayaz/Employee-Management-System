<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EDOBdtp = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EEducation = New System.Windows.Forms.ComboBox()
        Me.EPhone = New System.Windows.Forms.TextBox()
        Me.EPosition = New System.Windows.Forms.ComboBox()
        Me.EGender = New System.Windows.Forms.ComboBox()
        Me.Eaddress = New System.Windows.Forms.TextBox()
        Me.Ename = New System.Windows.Forms.TextBox()
        Me.HomeB = New System.Windows.Forms.Button()
        Me.DeleteB = New System.Windows.Forms.Button()
        Me.EditB = New System.Windows.Forms.Button()
        Me.AddB = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.EDOBdtp)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.EEducation)
        Me.Panel1.Controls.Add(Me.EPhone)
        Me.Panel1.Controls.Add(Me.EPosition)
        Me.Panel1.Controls.Add(Me.EGender)
        Me.Panel1.Controls.Add(Me.Eaddress)
        Me.Panel1.Controls.Add(Me.Ename)
        Me.Panel1.Controls.Add(Me.HomeB)
        Me.Panel1.Controls.Add(Me.DeleteB)
        Me.Panel1.Controls.Add(Me.EditB)
        Me.Panel1.Controls.Add(Me.AddB)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 527)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(514, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 51)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(701, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(643, 475)
        Me.DataGridView1.TabIndex = 18
        '
        'EDOBdtp
        '
        Me.EDOBdtp.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EDOBdtp.Location = New System.Drawing.Point(144, 337)
        Me.EDOBdtp.Name = "EDOBdtp"
        Me.EDOBdtp.Size = New System.Drawing.Size(257, 36)
        Me.EDOBdtp.TabIndex = 17
        Me.EDOBdtp.Value = New Date(1989, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(178, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 28)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Employee DOB"
        '
        'EEducation
        '
        Me.EEducation.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EEducation.FormattingEnabled = True
        Me.EEducation.Items.AddRange(New Object() {"Diploma", "BBA", "BCOM", "BCA", "MBA", "MCA"})
        Me.EEducation.Location = New System.Drawing.Point(304, 235)
        Me.EEducation.Name = "EEducation"
        Me.EEducation.Size = New System.Drawing.Size(204, 36)
        Me.EEducation.TabIndex = 15
        '
        'EPhone
        '
        Me.EPhone.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EPhone.Location = New System.Drawing.Point(55, 236)
        Me.EPhone.Name = "EPhone"
        Me.EPhone.Size = New System.Drawing.Size(175, 36)
        Me.EPhone.TabIndex = 14
        '
        'EPosition
        '
        Me.EPosition.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EPosition.FormattingEnabled = True
        Me.EPosition.Items.AddRange(New Object() {"Analyst", "Developer", "Manager", "Tester", "Assistant Manager", "Back-End Developer", "Front-End Developer", "Full-Stack Developer"})
        Me.EPosition.Location = New System.Drawing.Point(304, 147)
        Me.EPosition.Name = "EPosition"
        Me.EPosition.Size = New System.Drawing.Size(204, 36)
        Me.EPosition.TabIndex = 13
        '
        'EGender
        '
        Me.EGender.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EGender.FormattingEnabled = True
        Me.EGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.EGender.Location = New System.Drawing.Point(55, 147)
        Me.EGender.Name = "EGender"
        Me.EGender.Size = New System.Drawing.Size(175, 36)
        Me.EGender.TabIndex = 12
        '
        'Eaddress
        '
        Me.Eaddress.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Eaddress.Location = New System.Drawing.Point(304, 69)
        Me.Eaddress.Name = "Eaddress"
        Me.Eaddress.Size = New System.Drawing.Size(204, 36)
        Me.Eaddress.TabIndex = 11
        '
        'Ename
        '
        Me.Ename.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Ename.Location = New System.Drawing.Point(55, 69)
        Me.Ename.Name = "Ename"
        Me.Ename.Size = New System.Drawing.Size(175, 36)
        Me.Ename.TabIndex = 10
        '
        'HomeB
        '
        Me.HomeB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HomeB.BackColor = System.Drawing.Color.Black
        Me.HomeB.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HomeB.ForeColor = System.Drawing.Color.White
        Me.HomeB.Location = New System.Drawing.Point(312, 465)
        Me.HomeB.Name = "HomeB"
        Me.HomeB.Size = New System.Drawing.Size(101, 54)
        Me.HomeB.TabIndex = 9
        Me.HomeB.Text = "Home"
        Me.HomeB.UseVisualStyleBackColor = False
        '
        'DeleteB
        '
        Me.DeleteB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteB.BackColor = System.Drawing.Color.Black
        Me.DeleteB.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteB.ForeColor = System.Drawing.Color.White
        Me.DeleteB.Location = New System.Drawing.Point(369, 396)
        Me.DeleteB.Name = "DeleteB"
        Me.DeleteB.Size = New System.Drawing.Size(100, 51)
        Me.DeleteB.TabIndex = 8
        Me.DeleteB.Text = "Delete"
        Me.DeleteB.UseVisualStyleBackColor = False
        '
        'EditB
        '
        Me.EditB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditB.BackColor = System.Drawing.Color.Black
        Me.EditB.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditB.ForeColor = System.Drawing.Color.White
        Me.EditB.Location = New System.Drawing.Point(229, 396)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(101, 51)
        Me.EditB.TabIndex = 7
        Me.EditB.Text = "Edit"
        Me.EditB.UseVisualStyleBackColor = False
        '
        'AddB
        '
        Me.AddB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddB.BackColor = System.Drawing.Color.Black
        Me.AddB.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AddB.ForeColor = System.Drawing.Color.White
        Me.AddB.Location = New System.Drawing.Point(102, 396)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(91, 51)
        Me.AddB.TabIndex = 6
        Me.AddB.Text = "Add"
        Me.AddB.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(299, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Employee Education"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(51, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Employee Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(299, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Employee Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(51, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Employee Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(299, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Employee City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(51, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage Employee"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 122)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1306, -2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 36)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "X"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1266, -11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 45)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "-"
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1345, 720)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents HomeB As Button
    Friend WithEvents DeleteB As Button
    Friend WithEvents EditB As Button
    Friend WithEvents AddB As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EDOBdtp As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents EEducation As ComboBox
    Friend WithEvents EPhone As TextBox
    Friend WithEvents EPosition As ComboBox
    Friend WithEvents EGender As ComboBox
    Friend WithEvents Eaddress As TextBox
    Friend WithEvents Ename As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
End Class
