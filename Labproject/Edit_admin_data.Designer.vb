<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_admin_data
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnall = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnbar = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtadd = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(317, 633)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(253, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "( GAL-IT-2019-F-0005 : N . Lahiru Pramod De Silva )"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(83, 422)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(646, 208)
        Me.DataGridView1.TabIndex = 44
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Red
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(342, 358)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(126, 27)
        Me.btndelete.TabIndex = 41
        Me.btndelete.Text = "Remove admin"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnall
        '
        Me.btnall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnall.Location = New System.Drawing.Point(559, 282)
        Me.btnall.Name = "btnall"
        Me.btnall.Size = New System.Drawing.Size(243, 26)
        Me.btnall.TabIndex = 40
        Me.btnall.Text = "Display All Records"
        Me.btnall.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnbar)
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.Txtsearch)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(559, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 169)
        Me.Panel1.TabIndex = 39
        '
        'btnbar
        '
        Me.btnbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbar.Location = New System.Drawing.Point(129, 89)
        Me.btnbar.Name = "btnbar"
        Me.btnbar.Size = New System.Drawing.Size(102, 23)
        Me.btnbar.TabIndex = 3
        Me.btnbar.Text = "Clear serach Bar"
        Me.btnbar.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.Location = New System.Drawing.Point(63, 89)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(60, 23)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Txtsearch
        '
        Me.Txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsearch.Location = New System.Drawing.Point(99, 62)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(130, 21)
        Me.Txtsearch.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "For Delete Record Click   : 'DELETE' button."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Admin Email :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 30)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Admin Panel Details Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           (Delete Section)"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(320, 314)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(170, 26)
        Me.txtemail.TabIndex = 34
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(320, 182)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(170, 26)
        Me.txtage.TabIndex = 33
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(320, 140)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(170, 26)
        Me.txtlname.TabIndex = 35
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(320, 96)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(170, 26)
        Me.txtfname.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(149, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(149, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Age (years)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Last name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "First name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 33)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Admin Panel Details"
        '
        'Txtadd
        '
        Me.Txtadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtadd.Location = New System.Drawing.Point(320, 272)
        Me.Txtadd.Name = "Txtadd"
        Me.Txtadd.Size = New System.Drawing.Size(170, 26)
        Me.Txtadd.TabIndex = 33
        '
        'cmbgender
        '
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(320, 228)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(170, 28)
        Me.cmbgender.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "(Admin Password doesn't appear in table for security reasons)"
        '
        'Edit_admin_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(865, 655)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnall)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Txtadd)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_admin_data"
        Me.Text = "Edit_admin_data"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnall As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnbar As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtadd As System.Windows.Forms.TextBox
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
