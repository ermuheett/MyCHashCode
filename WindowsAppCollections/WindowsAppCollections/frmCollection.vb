Public Class frmCollection

    Private Sub frmCollection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



       



    End Sub

    Private Sub butnArray_Click(sender As System.Object, e As System.EventArgs) Handles butnArray.Click


        Dim intArr() As Integer = {1, 3, 4, 5, 23, 21, 6, 7, 4, 2, 1, 3, 4, 33, 7, 8}


        Dim strOutput As String = ""

        Array.Sort(intArr)


        For Each intVal As Integer In intArr




            strOutput = strOutput & "     " & intVal

        Next

        MsgBox(strOutput)


        Dim intele As Integer = InputBox("Enter the Element to be searched")


        Dim intPos As Integer = Array.BinarySearch(intArr, intele)



        MsgBox(intele & " has been Searched in " & intPos & " Position")

















    End Sub

    Private Sub butnArrayList_Click(sender As System.Object, e As System.EventArgs) Handles butnArrayList.Click


        Dim arrList As New ArrayList

        Dim arrTest() As Integer = {34, 56, 78, 12, 4}


        Dim arrInsert() As Integer = {1, 2, 3, 4, 5, 6, 6, 7, 7, 8}


        arrList.Add(23)

        arrList.AddRange(arrTest)


        arrList.Insert(3, 555)

        arrList.InsertRange(5, arrInsert)



        'arrList.RemoveRange(1, 4)


        Dim strOutput As String = ""


        For Each intVal As Integer In arrList


            strOutput = strOutput & "   " & intVal





        Next

        




        MsgBox(strOutput)


        strOutput = ""


        For i As Integer = 0 To arrList.Count - 1


            strOutput = strOutput & "  " & arrList(i)






        Next


        MsgBox(strOutput)


    End Sub

    Private Sub butnHash_Click(sender As System.Object, e As System.EventArgs) Handles butnHash.Click

        ' Hash has two things one is value and other is key


        Dim hshTest As New Hashtable


        hshTest.Add("Jammu", 23.4)
        hshTest.Add("Srinagar", 2.3)
        hshTest.Add("Rajouri", 12.4)

        hshTest.Add("Baramulla", 15.6)

        hshTest.Add("Pulwama", 33.4)



        Dim strOutput As String = ""


        For Each strCity As String In hshTest.Keys


            strOutput = strOutput & "   " & strCity


        Next



        MsgBox(strOutput)

        strOutput = ""


        For Each intVal As String In hshTest.Values


            strOutput = strOutput & "  " & intVal


        Next



        MsgBox(strOutput)



        ' Getting BOth 


        strOutput = ""


        For Each strKey As String In hshTest.Keys


            strOutput = strOutput & strKey & "   =    " & hshTest.Item(strKey) & vbCrLf



        Next


        MsgBox(strOutput)

        ' SOrtedList 















    End Sub
End Class
