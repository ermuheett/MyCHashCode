using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppMyFirstApplication
{
    public partial class frmMyFristApp : Form
    {
        public frmMyFristApp()
        {
            InitializeComponent();
        }

        private void butnOK_Click(object sender, EventArgs e)
        {


            int intA;
            int intB;
            int intC;


            intA = 20;
            intB = 30;

            intC = intA + intB;



            MessageBox.Show("This is C Hash Applicaiton");
            MessageBox.Show("The Sum is " + intC);



        }

      
    }
}
