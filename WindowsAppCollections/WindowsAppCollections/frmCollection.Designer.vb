<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Me.butnArray = New System.Windows.Forms.Button()
        Me.butnArrayList = New System.Windows.Forms.Button()
        Me.butnHash = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butnArray
        '
        Me.butnArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnArray.Location = New System.Drawing.Point(27, 12)
        Me.butnArray.Name = "butnArray"
        Me.butnArray.Size = New System.Drawing.Size(132, 51)
        Me.butnArray.TabIndex = 0
        Me.butnArray.Text = "Array"
        Me.butnArray.UseVisualStyleBackColor = True
        '
        'butnArrayList
        '
        Me.butnArrayList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnArrayList.Location = New System.Drawing.Point(27, 85)
        Me.butnArrayList.Name = "butnArrayList"
        Me.butnArrayList.Size = New System.Drawing.Size(132, 51)
        Me.butnArrayList.TabIndex = 1
        Me.butnArrayList.Text = "Array List"
        Me.butnArrayList.UseVisualStyleBackColor = True
        '
        'butnHash
        '
        Me.butnHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnHash.Location = New System.Drawing.Point(27, 142)
        Me.butnHash.Name = "butnHash"
        Me.butnHash.Size = New System.Drawing.Size(132, 51)
        Me.butnHash.TabIndex = 2
        Me.butnHash.Text = "Hash Table"
        Me.butnHash.UseVisualStyleBackColor = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 652)
        Me.Controls.Add(Me.butnHash)
        Me.Controls.Add(Me.butnArrayList)
        Me.Controls.Add(Me.butnArray)
        Me.Name = "frmCollection"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butnArray As System.Windows.Forms.Button
    Friend WithEvents butnArrayList As System.Windows.Forms.Button
    Friend WithEvents butnHash As System.Windows.Forms.Button

End Class
