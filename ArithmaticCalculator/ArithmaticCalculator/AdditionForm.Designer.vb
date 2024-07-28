<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionForm
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
        Me.FirstNoTxt = New System.Windows.Forms.TextBox()
        Me.SecondNoTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ResultLbl = New System.Windows.Forms.Label()
        Me.SubtractBtn = New System.Windows.Forms.Button()
        Me.MultiplyBtn = New System.Windows.Forms.Button()
        Me.DivideBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arithmatic Calculator"
        '
        'FirstNoTxt
        '
        Me.FirstNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNoTxt.Location = New System.Drawing.Point(88, 124)
        Me.FirstNoTxt.Name = "FirstNoTxt"
        Me.FirstNoTxt.Size = New System.Drawing.Size(390, 29)
        Me.FirstNoTxt.TabIndex = 1
        '
        'SecondNoTxt
        '
        Me.SecondNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNoTxt.Location = New System.Drawing.Point(88, 200)
        Me.SecondNoTxt.Name = "SecondNoTxt"
        Me.SecondNoTxt.Size = New System.Drawing.Size(390, 29)
        Me.SecondNoTxt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(85, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter the First No: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(85, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter the Second No: "
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(55, 306)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(93, 33)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "&Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ResultLbl
        '
        Me.ResultLbl.AutoSize = True
        Me.ResultLbl.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ResultLbl.Location = New System.Drawing.Point(97, 251)
        Me.ResultLbl.Name = "ResultLbl"
        Me.ResultLbl.Size = New System.Drawing.Size(183, 24)
        Me.ResultLbl.TabIndex = 6
        Me.ResultLbl.Text = "The Answer  is: "
        Me.ResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubtractBtn
        '
        Me.SubtractBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractBtn.Location = New System.Drawing.Point(183, 306)
        Me.SubtractBtn.Name = "SubtractBtn"
        Me.SubtractBtn.Size = New System.Drawing.Size(97, 33)
        Me.SubtractBtn.TabIndex = 5
        Me.SubtractBtn.Text = "Subtract"
        Me.SubtractBtn.UseVisualStyleBackColor = True
        '
        'MultiplyBtn
        '
        Me.MultiplyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplyBtn.Location = New System.Drawing.Point(304, 306)
        Me.MultiplyBtn.Name = "MultiplyBtn"
        Me.MultiplyBtn.Size = New System.Drawing.Size(93, 33)
        Me.MultiplyBtn.TabIndex = 5
        Me.MultiplyBtn.Text = "Mulitply"
        Me.MultiplyBtn.UseVisualStyleBackColor = True
        '
        'DivideBtn
        '
        Me.DivideBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideBtn.Location = New System.Drawing.Point(419, 306)
        Me.DivideBtn.Name = "DivideBtn"
        Me.DivideBtn.Size = New System.Drawing.Size(93, 33)
        Me.DivideBtn.TabIndex = 5
        Me.DivideBtn.Text = "Division"
        Me.DivideBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(183, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Subtract"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 376)
        Me.Controls.Add(Me.ResultLbl)
        Me.Controls.Add(Me.DivideBtn)
        Me.Controls.Add(Me.MultiplyBtn)
        Me.Controls.Add(Me.SubtractBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondNoTxt)
        Me.Controls.Add(Me.FirstNoTxt)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "AdditionForm"
        Me.Text = "Addition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents SecondNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents ResultLbl As System.Windows.Forms.Label
    Friend WithEvents SubtractBtn As System.Windows.Forms.Button
    Friend WithEvents MultiplyBtn As System.Windows.Forms.Button
    Friend WithEvents DivideBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
