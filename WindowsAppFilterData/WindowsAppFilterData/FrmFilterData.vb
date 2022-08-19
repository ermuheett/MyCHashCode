Imports System.Data.SqlClient


Public Class FrmFilterData

    Private Sub ButnPopulate_Click(sender As System.Object, e As System.EventArgs) Handles ButnPopulate.Click


        Dim CN As New SqlConnection("Data Source=95JK040;Initial Catalog=TouristTrackingSystem;Integrated Security=True")

        Dim cmdGetData As New SqlCommand("Select * from UserMaster", CN)



        CN.Open()

        Dim rdrGetData As SqlDataReader = cmdGetData.ExecuteReader

        TxtFilterData.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtFilterData.AutoCompleteMode = AutoCompleteMode.Suggest


        While rdrGetData.Read



            TxtFilterData.AutoCompleteCustomSource.Add(rdrGetData.Item("UserDetName"))






        End While


        CN.Close()



    End Sub

    Private Sub ButnFilePop_Click(sender As System.Object, e As System.EventArgs) Handles ButnFilePop.Click

        Dim strFileValues As String = My.Computer.FileSystem.ReadAllText("C:\FSO\Text.txt")

        Dim strValue() As String = Split(strFileValues, Chr(10), -1)

        TxtFilterData.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtFilterData.AutoCompleteSource = AutoCompleteSource.CustomSource


        For Each strv As String In strValue



            TxtFilterData.AutoCompleteCustomSource.Add(strv)



        Next

       



    End Sub
End Class
