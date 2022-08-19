using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsAppMultiThread
{
    public partial class frmMulti : Form
    {
        public frmMulti()
        {
            InitializeComponent();
        }

        private void butnBasicThread_Click(object sender, EventArgs e)
        {


            ThreadStart THA = new ThreadStart(new frmMulti().ThreadCount);
            ThreadStart THB = new ThreadStart(new frmMulti().ThreadCount);
            ThreadStart THC = new ThreadStart(new frmMulti().ThreadCount);
            ThreadStart THD = new ThreadStart(new frmMulti().ThreadCount);
            ThreadStart THE = new ThreadStart(new frmMulti().ThreadCount);

            Thread thM1 = new Thread(THA);
            Thread thM2 = new Thread (THB);
            Thread thM3 = new Thread (THC);
            Thread thM4 = new Thread (THD);
            Thread thM5 = new Thread(THE);

            thM1.Name = "Thread 1";
            thM2.Name = "Thread 2";
            thM3.Name = "Thread 3";
            thM4.Name = "Thread 4";
            thM5.Name = "Thread 5";




            thM1.Start();
            thM2.Start();
            thM3.Start();
            thM4.Start();
            thM5.Start();


            

           



        }


        public void ThreadCount()
        {

            int intRndCount;

            Random rndTest = new Random();

            intRndCount = rndTest.Next(1000, 5000);
            


            Console.WriteLine(Thread.CurrentThread.Name + " is going to Sleep with Sleep Time" + intRndCount);

            Thread.Sleep(intRndCount);

            Console.WriteLine(Thread.CurrentThread.Name + "  Woke up from Sleep time " + intRndCount);

            

        }




           



            

        
    }
}
