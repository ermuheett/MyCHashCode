<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMongoDB
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
        Me.ButnCreateDatabase = New System.Windows.Forms.Button()
        Me.ButnExpMongo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButnCreateDatabase
        '
        Me.ButnCreateDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCreateDatabase.Location = New System.Drawing.Point(22, 33)
        Me.ButnCreateDatabase.Name = "ButnCreateDatabase"
        Me.ButnCreateDatabase.Size = New System.Drawing.Size(140, 60)
        Me.ButnCreateDatabase.TabIndex = 0
        Me.ButnCreateDatabase.Text = "Create Database"
        Me.ButnCreateDatabase.UseVisualStyleBackColor = True
        '
        'ButnExpMongo
        '
        Me.ButnExpMongo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnExpMongo.Location = New System.Drawing.Point(22, 99)
        Me.ButnExpMongo.Name = "ButnExpMongo"
        Me.ButnExpMongo.Size = New System.Drawing.Size(140, 60)
        Me.ButnExpMongo.TabIndex = 1
        Me.ButnExpMongo.Text = "Export to Mongo"
        Me.ButnExpMongo.UseVisualStyleBackColor = True
        '
        'FrmMongoDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 567)
        Me.Controls.Add(Me.ButnExpMongo)
        Me.Controls.Add(Me.ButnCreateDatabase)
        Me.Name = "FrmMongoDB"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButnCreateDatabase As System.Windows.Forms.Button
    Friend WithEvents ButnExpMongo As System.Windows.Forms.Button

End Class
