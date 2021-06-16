<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_new_book
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.cmbcat = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtcopies = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(139, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(59, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name of Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(59, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Book Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(59, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Book author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(59, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Date of publication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(59, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Number of copies"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(265, 116)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(170, 26)
        Me.txtname.TabIndex = 2
        '
        'txtauthor
        '
        Me.txtauthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauthor.Location = New System.Drawing.Point(265, 208)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(170, 26)
        Me.txtauthor.TabIndex = 2
        '
        'cmbcat
        '
        Me.cmbcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Education", "Sport", "Novels", "History", "Religious", "Geographical", "Children", "Magazines", "Electrical", "Information", "Literature"})
        Me.cmbcat.Location = New System.Drawing.Point(265, 163)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(170, 28)
        Me.cmbcat.TabIndex = 3
        Me.cmbcat.Text = "select...."
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(265, 252)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(170, 26)
        Me.DateTimePicker.TabIndex = 4
        Me.DateTimePicker.TabStop = False
        Me.DateTimePicker.Value = New Date(2021, 6, 12, 0, 0, 0, 0)
        '
        'txtcopies
        '
        Me.txtcopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcopies.Location = New System.Drawing.Point(265, 305)
        Me.txtcopies.Name = "txtcopies"
        Me.txtcopies.Size = New System.Drawing.Size(48, 26)
        Me.txtcopies.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Location = New System.Drawing.Point(63, 366)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(156, 32)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add "
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(339, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(236, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 32)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "( GAL-IT-2019-F-0005 : N . Lahiru Pramod De Silva )"
        '
        'Add_new_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 442)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.cmbcat)
        Me.Controls.Add(Me.txtcopies)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "Add_new_book"
        Me.Text = "Add_new_book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents cmbcat As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcopies As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
