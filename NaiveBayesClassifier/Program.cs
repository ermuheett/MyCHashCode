using System;
using System.Data;
using System.Data.SqlClient;


namespace ProbabilityFunctions
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            // Poplulate Datatable with attributes ... 


            DataTable table = new DataTable();
            table.Columns.Add("Rainfall");
            table.Columns.Add("WindSpeed");
            table.Columns.Add("Temperature");
            table.Columns.Add("SLP");
            table.Columns.Add("Humidity");


            // Read the Complete Dataset based on the above attributes


            SqlConnection CNData = new SqlConnection("Data Source=95JK040\\SQLEXPRESS;Initial Catalog=DataAnalysis;Integrated Security=True;MultipleActiveResultSets=True");

            SqlCommand cmdData = new SqlCommand ("Select * from FormattedData",CNData );


            SqlDataReader rdrData;

            CNData.Open();


                rdrData = cmdData.ExecuteReader ();

                while (rdrData.Read()) 
                {

                    table.Rows.Add(rdrData["Rainfall"].ToString (), rdrData["WindSpeed"].ToString (), rdrData["Temperature"].ToString (), rdrData["SLP"].ToString (), rdrData["Humidity"].ToString ());

                }




            CNData.Close ();




          
            // Train the Dataset 
                    Classifier classifier = new Classifier();
            classifier.TrainClassifier(table);

            
            // Sample Data set 
//            Console.WriteLine("The Severity/Threat of Expliotation for OpenSSL Heartbleed Vulnerability is:"
  //              + classifier.Classify(new double[] { 3, 5, 3, 4}));



            SqlCommand cmdTestData = new SqlCommand ("Select * from TestDataFormatted",CNData );
            
            SqlDataReader rdrTestData;
            SqlCommand cmdUpdateFinal;


            string strOutput;

            CNData.Open ();

             
            rdrTestData = cmdTestData .ExecuteReader ();


            while (rdrTestData.Read ())
            {
            
                
                strOutput = classifier.Classify(new double[] { Convert.ToInt16 (rdrTestData ["WindSpeed"]), Convert.ToInt16 (rdrTestData ["Temperature"]), Convert.ToInt16 (rdrTestData ["SLP"]), Convert.ToInt16 (rdrTestData ["Humidity"])});

                
                cmdUpdateFinal = new SqlCommand("update TestDataFormatted set RainFall = '" + strOutput + "' Where ID = " + Convert.ToInt64(rdrTestData["ID"]), CNData);
                cmdUpdateFinal.ExecuteNonQuery();

                
            }

            
            CNData.Close();

            Console.WriteLine("The Process has been Completed Successfully...!!!!");


            Console.Read();
        }
    }
}