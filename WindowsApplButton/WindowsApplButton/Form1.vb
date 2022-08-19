Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim butnTest As New Button

        butnTest.Visible = True
        butnTest.Name = "butnTest"

        butnTest.Text = "Click Me"


        Controls.Add(butnTest)

    End Sub
End Class
