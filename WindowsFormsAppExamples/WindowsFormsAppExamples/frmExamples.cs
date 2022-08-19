using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppExamples
{
    public partial class frmExamples : Form
    {
        public frmExamples()
        {
            InitializeComponent();
        }

        private void butnAccessSpecifier_Click(object sender, EventArgs e)
        {



            TestNameSpace.NameSpaceClass objTest = new TestNameSpace.NameSpaceClass();
            objTest.Test();


            TestNameSpace.NameSpaceSec objSecond = new TestNameSpace.NameSpaceSec();
            objSecond.Test();


        }

        private void butnSimpleClass_Click(object sender, EventArgs e)
        {



            TestClass objTest = new TestClass("Welcome to Test Messaging");            

            objTest.TestMessage ();

            











        }


        public class TestClass
        {

            public TestClass(string strMessage)
            {

                MessageBox.Show("This is the Test Message" + strMessage);



            }


            ~TestClass()
            {

                MessageBox.Show("Object is out of scope");

            
            
            }


            public void TestMessage()
            {

                MessageBox.Show("This is a Test Message");

            
            
            }

        }

        private void butnAccSpec_Click(object sender, EventArgs e)
        {



            // Every Public Member can be accessed outside the class


            RectAngle rect = new RectAngle();

            rect.dblen = 10;
            rect.dblWdth = 12;

           MessageBox .Show (rect.GetArea().ToString ());



        }

        private void butnPrivate_Click(object sender, EventArgs e)
        {


            RectAnglePri objTest = new RectAnglePri();


            objTest.GetValues(10, 23);


            MessageBox .Show (objTest.GetArea().ToString ());






        }

        private void butnProTect_Click(object sender, EventArgs e)
        {




            TEstProTect objTest = new TEstProTect();


        }

        struct Book
        {


            public string title;
            public string author;
            public string subject;


            public void GetValues(string t, string a, string s)
            {


                title = t;
                author = a;
                subject = s;


            }


            public void Display()
            {

                string strOutput = "";



                strOutput = strOutput + title + "  " + author + "  " + subject;

                MessageBox.Show(strOutput);


            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            // Structures are Value types and Class is Reference Type
            // Structures do not support Inhertance
            // Strcutures cannot have default constructors.


            Book book1, book2;


            book1.author = "Majid";
            book1.subject = "Computer Science";
            book1.title = "Let us C";


            Book bkTest = new Book();

            bkTest.GetValues("James", "CS", "Welcome to C");


            MessageBox.Show(book1.title);

            bkTest.Display();




           

        }

        enum ROMAN { I=1, II=2, III=3, IV=4, V=5, VI=6, VII=7, VIII=8, IX=9, X=10 };



        private void butnEnum_Click(object sender, EventArgs e)
        {

            ROMAN rmnA, rmnB, rmnC;
            int intA, intB, intC;


            intA = (int)ROMAN.IV;
            intB = (int)ROMAN.II;


             intC = intA + intB;

             rmnC = (ROMAN)intC;


            MessageBox.Show(rmnC.ToString ());


         }

        private void frmExamples_Load(object sender, EventArgs e)
        {

        }
          
               


    }


    public class TEstProTect
    {
        internal double dblWidth;
        internal double dblHeight;


        double GetArea()
        {
            return (dblHeight * dblWidth );

        }

        
        public void Display()
        {

            dblWidth = 20;
            dblHeight = 20;

            MessageBox.Show(GetArea().ToString());


        }


    }



    public class RectAnglePri
    {

        private double dblen;
        private double dblWdth;

        public void GetValues(double dlen, double dWdth)
        {

            dblen = dlen;
            dblWdth = dWdth;



        }


        public double GetArea()
        {

            return (dblen * dblWdth);


        }



    }





    public class RectAngle
    {

        public double dblen;
        public double dblWdth;

        public double GetArea()
        {

            return (dblen * dblWdth);


        }



    }





}

namespace TestNameSpace
{

    public class NameSpaceClass
    {

        public void Test()
        {


            MessageBox.Show("This is the Class NameSpaceClass");

        }

    }


        public class NameSpaceSec
        {

            public void Test()
            {

                MessageBox .Show ("This is Class NameSpaceSec");

            }



        }

}

