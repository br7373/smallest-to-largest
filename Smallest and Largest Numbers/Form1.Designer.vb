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
        Me.lblSmall = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLarge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Smallest Number"
        '
        'lblSmall
        '
        Me.lblSmall.AutoSize = True
        Me.lblSmall.Location = New System.Drawing.Point(113, 138)
        Me.lblSmall.Name = "lblSmall"
        Me.lblSmall.Size = New System.Drawing.Size(10, 13)
        Me.lblSmall.TabIndex = 1
        Me.lblSmall.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Largest Number"
        '
        'lblLarge
        '
        Me.lblLarge.AutoSize = True
        Me.lblLarge.Location = New System.Drawing.Point(339, 138)
        Me.lblLarge.Name = "lblLarge"
        Me.lblLarge.Size = New System.Drawing.Size(10, 13)
        Me.lblLarge.TabIndex = 3
        Me.lblLarge.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 356)
        Me.Controls.Add(Me.lblLarge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSmall)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSmall As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLarge As Label
End Class
