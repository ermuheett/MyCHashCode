<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObject
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
        Me.butnClasses = New System.Windows.Forms.Button()
        Me.butnProperty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butnClasses
        '
        Me.butnClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnClasses.Location = New System.Drawing.Point(40, 28)
        Me.butnClasses.Name = "butnClasses"
        Me.butnClasses.Size = New System.Drawing.Size(126, 56)
        Me.butnClasses.TabIndex = 0
        Me.butnClasses.Text = "Classes"
        Me.butnClasses.UseVisualStyleBackColor = True
        '
        'butnProperty
        '
        Me.butnProperty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnProperty.Location = New System.Drawing.Point(40, 124)
        Me.butnProperty.Name = "butnProperty"
        Me.butnProperty.Size = New System.Drawing.Size(126, 56)
        Me.butnProperty.TabIndex = 1
        Me.butnProperty.Text = "Property"
        Me.butnProperty.UseVisualStyleBackColor = True
        '
        'frmObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 469)
        Me.Controls.Add(Me.butnProperty)
        Me.Controls.Add(Me.butnClasses)
        Me.Name = "frmObject"
        Me.Text = "Working with Classes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butnClasses As System.Windows.Forms.Button
    Friend WithEvents butnProperty As System.Windows.Forms.Button

End Class
