
Imports System
Imports MongoDB.Bson
Imports MongoDB.Driver



Module ModMongo

    Sub Main()


        Dim CN As String = "mongodb://Localhost"
        Dim strDBName As String = "VbNET"

        Console.WriteLine(">> Get Database")

        Dim MngServer As MongoServer = MongoServer.Create(CN)

        Dim Database As MongoDatabase = MngServer.GetDatabase(strDBName)


        'Create Collection 


        Console.WriteLine(">>> Create Database Collection")

        Dim cmdResult As CommandResult = Database.CreateCollection("EMPLOYEE")


        If cmdResult.Ok Then

            Console.WriteLine("Database Created Successfully...!!!!")

        Else

            Console.WriteLine(cmdResult.ErrorMessage)




        End If


        Console.ReadKey()














    End Sub

End Module
