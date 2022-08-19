<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileComparison
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.ButnFIleComp = New System.Windows.Forms.Button()
        Me.ChrtCryptAnalytics = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PGEncrypt = New System.Windows.Forms.ProgressBar()
        Me.ButnCommulative = New System.Windows.Forms.Button()
        CType(Me.ChrtCryptAnalytics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButnFIleComp
        '
        Me.ButnFIleComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnFIleComp.Location = New System.Drawing.Point(12, 462)
        Me.ButnFIleComp.Name = "ButnFIleComp"
        Me.ButnFIleComp.Size = New System.Drawing.Size(153, 60)
        Me.ButnFIleComp.TabIndex = 0
        Me.ButnFIleComp.Text = "Comparative"
        Me.ButnFIleComp.UseVisualStyleBackColor = True
        '
        'ChrtCryptAnalytics
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChrtCryptAnalytics.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChrtCryptAnalytics.Legends.Add(Legend1)
        Me.ChrtCryptAnalytics.Location = New System.Drawing.Point(12, 12)
        Me.ChrtCryptAnalytics.Name = "ChrtCryptAnalytics"
        Me.ChrtCryptAnalytics.Size = New System.Drawing.Size(738, 381)
        Me.ChrtCryptAnalytics.TabIndex = 1
        Me.ChrtCryptAnalytics.Text = "Cryptanalytics"
        '
        'PGEncrypt
        '
        Me.PGEncrypt.Location = New System.Drawing.Point(12, 399)
        Me.PGEncrypt.Maximum = 4
        Me.PGEncrypt.Name = "PGEncrypt"
        Me.PGEncrypt.Size = New System.Drawing.Size(737, 17)
        Me.PGEncrypt.TabIndex = 2
        '
        'ButnCommulative
        '
        Me.ButnCommulative.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCommulative.Location = New System.Drawing.Point(171, 462)
        Me.ButnCommulative.Name = "ButnCommulative"
        Me.ButnCommulative.Size = New System.Drawing.Size(147, 60)
        Me.ButnCommulative.TabIndex = 3
        Me.ButnCommulative.Text = "Commulative"
        Me.ButnCommulative.UseVisualStyleBackColor = True
        '
        'frmFileComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 534)
        Me.Controls.Add(Me.ButnCommulative)
        Me.Controls.Add(Me.PGEncrypt)
        Me.Controls.Add(Me.ChrtCryptAnalytics)
        Me.Controls.Add(Me.ButnFIleComp)
        Me.Name = "frmFileComparison"
        Me.Text = "Cryptanalytics for Bit Change"
        CType(Me.ChrtCryptAnalytics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButnFIleComp As System.Windows.Forms.Button
    Friend WithEvents ChrtCryptAnalytics As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PGEncrypt As System.Windows.Forms.ProgressBar
    Friend WithEvents ButnCommulative As System.Windows.Forms.Button

End Class
