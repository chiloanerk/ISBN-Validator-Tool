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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbISBN = New System.Windows.Forms.MaskedTextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN number:"
        '
        'mtbISBN
        '
        Me.mtbISBN.Location = New System.Drawing.Point(146, 12)
        Me.mtbISBN.Mask = "0-00-000000-&"
        Me.mtbISBN.Name = "mtbISBN"
        Me.mtbISBN.Size = New System.Drawing.Size(100, 23)
        Me.mtbISBN.TabIndex = 1
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(85, 41)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(136, 32)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Check Validity"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valid ISBN:"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(153, 79)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(69, 23)
        Me.txtOutput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 111)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.mtbISBN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ISBN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mtbISBN As MaskedTextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutput As TextBox
End Class
