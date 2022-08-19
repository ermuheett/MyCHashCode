<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilterData
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
        Me.TxtFilterData = New System.Windows.Forms.TextBox()
        Me.ButnPopulate = New System.Windows.Forms.Button()
        Me.ButnFilePop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtFilterData
        '
        Me.TxtFilterData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtFilterData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtFilterData.Location = New System.Drawing.Point(100, 65)
        Me.TxtFilterData.Name = "TxtFilterData"
        Me.TxtFilterData.Size = New System.Drawing.Size(519, 22)
        Me.TxtFilterData.TabIndex = 0
        '
        'ButnPopulate
        '
        Me.ButnPopulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnPopulate.Location = New System.Drawing.Point(36, 388)
        Me.ButnPopulate.Name = "ButnPopulate"
        Me.ButnPopulate.Size = New System.Drawing.Size(136, 53)
        Me.ButnPopulate.TabIndex = 1
        Me.ButnPopulate.Text = "Populate"
        Me.ButnPopulate.UseVisualStyleBackColor = True
        '
        'ButnFilePop
        '
        Me.ButnFilePop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnFilePop.Location = New System.Drawing.Point(178, 388)
        Me.ButnFilePop.Name = "ButnFilePop"
        Me.ButnFilePop.Size = New System.Drawing.Size(136, 53)
        Me.ButnFilePop.TabIndex = 2
        Me.ButnFilePop.Text = "File Poplulate"
        Me.ButnFilePop.UseVisualStyleBackColor = True
        '
        'FrmFilterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 509)
        Me.Controls.Add(Me.ButnFilePop)
        Me.Controls.Add(Me.ButnPopulate)
        Me.Controls.Add(Me.TxtFilterData)
        Me.Name = "FrmFilterData"
        Me.Text = "Filtering Data Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtFilterData As System.Windows.Forms.TextBox
    Friend WithEvents ButnPopulate As System.Windows.Forms.Button
    Friend WithEvents ButnFilePop As System.Windows.Forms.Button

End Class
