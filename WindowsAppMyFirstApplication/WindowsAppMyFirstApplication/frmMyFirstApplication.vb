Public Class frmMyFirstApplication

    Private Sub frmMyFirstApplication_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butnMyFirstApp_Click(sender As System.Object, e As System.EventArgs) Handles butnMyFirstApp.Click



        Dim intA As Integer
        Dim intB As Integer
        Dim intC As Integer
        Dim intE As Integer


        intA = 20
        intB = 30



        intC = intA + intB


        ''''''MsgBox("The SUm of two numbers is " & intC)
        ' This code will not be executed

        Debug.Print("The SUm of two numbers is" & intC)




    End Sub
End Class
