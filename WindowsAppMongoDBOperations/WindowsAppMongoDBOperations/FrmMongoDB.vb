Imports System
Imports MongoDB.Bson
Imports MongoDB.Driver


Imports System.Data.SqlClient
Imports System.Data.OleDb




Public Class FrmMongoDB

    Private Sub ButnCreateDatabase_Click(sender As System.Object, e As System.EventArgs) Handles ButnCreateDatabase.Click


        Dim CN As String = "mongodb://Localhost"
        Dim strDBName As String = "CAPSData"



        'Get Database 

        Dim MngServer As MongoServer = MongoServer.Create(CN)

        Dim Database As MongoDatabase = MngServer.GetDatabase(strDBName)


        'Create Data


        Dim employees As MongoCollection(Of BsonDocument) = Database.GetCollection("EMPLOYEE")

        For i As Integer = 1 To 5



            Dim emp As BsonDocument = New BsonDocument()

            emp.Add("empno", "EmpNo_" & i)
            emp.Add("ename", "Emp_Name_" & i)
            emp.Add("eadd", "Emp_Add_" & i)



            employees.Insert(emp)


        Next



        MsgBox("The Datbase and Tables (Collections) Has been Created Successfully")


    End Sub

    Private Sub ButnExpMongo_Click(sender As System.Object, e As System.EventArgs) Handles ButnExpMongo.Click

        Dim strPath As String = "C:\Users\Er Muheet Ahmed Butt\Documents\Database1.accdb"

        Dim CN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strPath)

        Dim cmdGetData As New OleDbCommand("Select * from MongoImport", CN)


        '***************************************

        'Initialize MOngo DB variables 


        Dim CNMongo As String = "mongodb://Localhost"
        Dim strDBName As String = "capsdata"

        'Get Database 

        Dim MngServer As MongoServer = MongoServer.Create(CNMongo)
        Dim Database As MongoDatabase = MngServer.GetDatabase(strDBName)


        'Create Collection [Tables in RDBMS] 


        Dim cmdResult As CommandResult = Database.CreateCollection("MongoImport")
        Dim Customers As MongoCollection(Of BsonDocument) = Database.GetCollection("MongoImport")

        '**************************************


        CN.Open()


        Dim rdrGetData As OleDbDataReader = cmdGetData.ExecuteReader



        While rdrGetData.Read

            Dim CustRecord As BsonDocument = New BsonDocument()

            CustRecord.Add("University", rdrGetData.Item("University").ToString)
            CustRecord.Add("First_Name", rdrGetData.Item("First_Name").ToString)
            CustRecord.Add("Last_Name", rdrGetData.Item("Last_Name").ToString)
            CustRecord.Add("Email", rdrGetData.Item("Email").ToString)
            CustRecord.Add("Interested", rdrGetData.Item("Interested").ToString)
            CustRecord.Add("Phone", rdrGetData.Item("Phone").ToString)
            CustRecord.Add("City", rdrGetData.Item("City").ToString)
            CustRecord.Add("School_Year", rdrGetData.Item("School_Year").ToString)
            CustRecord.Add("Agnel_Investor", rdrGetData.Item("Angel_Investor").ToString)
            CustRecord.Add("No_of_startups", rdrGetData.Item("No_of_Startups").ToString)
            CustRecord.Add("Startups_Name", rdrGetData.Item("Startups_Name").ToString)
            CustRecord.Add("Annual_Investment", rdrGetData.Item("Annual_Investment").ToString)
            CustRecord.Add("amt_perdeal", rdrGetData.Item("amt_perdeal").ToString)
            CustRecord.Add("Industries_Angel", rdrGetData.Item("Industries_Angel").ToString)
            CustRecord.Add("Alumni_angel_group", rdrGetData.Item("Alumni_angel_group").ToString)
            CustRecord.Add("Affiliated_VC", rdrGetData.Item("Affiliated_VC").ToString)
            CustRecord.Add("VC_Firm", rdrGetData.Item("VC_Firm").ToString)
            CustRecord.Add("VC_Position", rdrGetData.Item("VC_Position").ToString)
            CustRecord.Add("VC_Firm_Annual", rdrGetData.Item("VC_Firm_Annual").ToString)
            CustRecord.Add("VC_Amt_Investment", rdrGetData.Item("VC_Amt_Investment").ToString)
            CustRecord.Add("Criteria_Philosophy", rdrGetData.Item("Criteria_Philosophy").ToString)
            CustRecord.Add("VC_Firm_Size", rdrGetData.Item("VC_Firm_Size").ToString)
            CustRecord.Add("VC_Fellow_Alumni", rdrGetData.Item("VC_Fellow_Alumni").ToString)
            CustRecord.Add("About", rdrGetData.Item("About").ToString)
            CustRecord.Add("Profession", rdrGetData.Item("Profession").ToString)
            CustRecord.Add("Involved_Group", rdrGetData.Item("Involved_Group").ToString)
            CustRecord.Add("Pro_Bono", rdrGetData.Item("Pro_Bono").ToString)
            CustRecord.Add("Pro_Bono_Role", rdrGetData.Item("Pro_Bono_Role").ToString)
            CustRecord.Add("Group_Club", rdrGetData.Item("Group_Club").ToString)
            CustRecord.Add("Alumni_Organization", rdrGetData.Item("Alumni_Organization").ToString)
            CustRecord.Add("Group_Club_Name", rdrGetData.Item("Group_Club_Name").ToString)


            Customers.Insert(CustRecord)



        End While


        CN.Close()



        MsgBox("Data has been Successfully Migrated....!!!!")






    End Sub
End Class




