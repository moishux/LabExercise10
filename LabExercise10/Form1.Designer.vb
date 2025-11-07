<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonWrite = New System.Windows.Forms.Button()
        Me.ListBoxNumbers = New System.Windows.Forms.ListBox()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonWrite
        '
        Me.ButtonWrite.Location = New System.Drawing.Point(248, 286)
        Me.ButtonWrite.Name = "ButtonWrite"
        Me.ButtonWrite.Size = New System.Drawing.Size(55, 23)
        Me.ButtonWrite.TabIndex = 0
        Me.ButtonWrite.Text = "Write"
        Me.ButtonWrite.UseVisualStyleBackColor = True
        '
        'ListBoxNumbers
        '
        Me.ListBoxNumbers.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxNumbers.FormattingEnabled = True
        Me.ListBoxNumbers.Location = New System.Drawing.Point(244, 62)
        Me.ListBoxNumbers.Name = "ListBoxNumbers"
        Me.ListBoxNumbers.Size = New System.Drawing.Size(208, 212)
        Me.ListBoxNumbers.TabIndex = 1
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(309, 286)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(61, 23)
        Me.ButtonRead.TabIndex = 2
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a number:"
        '
        'ButtonSort
        '
        Me.ButtonSort.Location = New System.Drawing.Point(377, 286)
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.Size = New System.Drawing.Size(59, 23)
        Me.ButtonSort.TabIndex = 5
        Me.ButtonSort.Text = "Sort"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(329, 36)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(123, 20)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ButtonSort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ListBoxNumbers)
        Me.Controls.Add(Me.ButtonWrite)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonWrite As Button
    Friend WithEvents ListBoxNumbers As ListBox
    Friend WithEvents ButtonRead As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSort As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
