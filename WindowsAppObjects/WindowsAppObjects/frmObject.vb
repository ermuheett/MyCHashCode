Public Class frmObject

    Private Sub butnClasses_Click(sender As System.Object, e As System.EventArgs) Handles butnClasses.Click

        Dim objA As New MyFirstClass
        Dim objB As New MyFirstClass




        'objA.AddNum(23, 34)



        ' MsgBox(objA.GetHashCode)


        ' MsgBox(objA.GetType().ToString)

        ' Object: USer Defined Type..

        ' MsgBox(objA.ToString

        objA = objB


        ' MsgBox(objA.Equals(objB))


        MsgBox(MyFirstClass.ReferenceEquals(objA, objB))








    End Sub

    Private Sub butnProperty_Click(sender As System.Object, e As System.EventArgs) Handles butnProperty.Click


        Dim objA As New MyFirstClass


        objA.Age = 30
        Debug.Print("Age is " & objA.Age)

        objA.Age = 35
        Debug.Print("Age is " & objA.Age)

        objA.Age = 45
        Debug.Print("Age is " & objA.Age)

        objA.Age = 55
        Debug.Print("Age is " & objA.Age)

        objA.Age = 20
        Debug.Print("Age is " & objA.Age)

        objA.Age = 18
        Debug.Print("Age is " & objA.Age)

        objA.Age = 5
        Debug.Print("Age is " & objA.Age)

        objA.Age = 55
        Debug.Print("Age is " & objA.Age)




    End Sub
End Class
