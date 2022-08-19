using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestAlias = System.Text.StringBuilder;


namespace WindowsFormsAppOOPS
{
    public partial class frmOOPS : Form
    {
        public frmOOPS()
        {
            InitializeComponent();
        }

        private void butnStaticVar_Click(object sender, EventArgs e)
        {



            StaticVarEx objNum1 = new StaticVarEx();
            StaticVarEx objNum2 = new StaticVarEx();

            objNum1.count();
            objNum1.count();
            objNum1.count();
            objNum1.count();
            objNum1.count();
            
            objNum2.count();
            objNum2.count();
            objNum2.count();
            objNum2.count();
            objNum2.count();



            MessageBox.Show("The Count of Number 1 is : " + StaticVarEx.getVal().ToString());

            



        }

        private void butnStaticFunc_Click(object sender, EventArgs e)
        {


            StaticVarEx objNum1 = new StaticVarEx();
            StaticVarEx objNum2 = new StaticVarEx();

            objNum1.count();
            objNum1.count();
            objNum1.count();
            objNum1.count();
            objNum1.count();

            objNum2.count();
            objNum2.count();
            objNum2.count();
            objNum2.count();
            objNum2.count();



            MessageBox.Show("The Count of Number 1 is : " + StaticVarEx.getVal().ToString());

            }

        private void frmOOPS_Load(object sender, EventArgs e)
        {

        }

        private void butnInherit_Click(object sender, EventArgs e)
        {


            Rectangle  objRect = new Rectangle ();


            objRect.SetHeight(10);
            objRect.setWidth(10);


           MessageBox .Show ("The Area of RectAngle is " +  objRect.getArea().ToString());









        }

        private void butnMultiInher_Click(object sender, EventArgs e)
        {


            DerivedTest objTest = new DerivedTest();

            objTest.setLength(10);
            objTest.setWidth(20);

            MessageBox.Show("THe Areaa is " + objTest.getVal());





        }

        private void butnPolyMor_Click(object sender, EventArgs e)
        {


            Box bxA = new Box();
            Box bxB = new Box();
            Box bxC = new Box();


            // Set Values for Boxes


            bxA.setBreadth (10);
            bxA.setHeight (10);
            bxA.setLength (10);
            MessageBox.Show("The Volume of Box 1 is " + bxA.getVolume().ToString());


            bxB.setBreadth(10);
            bxB.setHeight(10);
            bxB.setLength(10);
            MessageBox.Show("The Volume of Box 2 is " + bxB.getVolume().ToString());


            bxC = bxA + bxB;
            MessageBox.Show("The Volume of Box 3 is " + bxC.getVolume().ToString());

            
        }

        private void butnStaticClass_Click(object sender, EventArgs e)
        {


           
            TestStatic.printMessage ();



        }

        private void butnParClass_Click(object sender, EventArgs e)
        {

    

        }

        private void butnAilas_Click(object sender, EventArgs e)
        {


            TestAlias tstTest = new TestAlias();

            tstTest.Append("Hello");

            MessageBox.Show(tstTest.ToString());

        }

    }


    

    // Static Class Code


    static class TestStatic
    {

        public static void printMessage()
        {

            MessageBox.Show("I am Printing this Message");


        }
    }




    // Code for Poly MorPhism

    class Box
    {


        private double dblLength;
        private double dblHeight;
        private double dblBreadth;



        public void setLength(double dblL)
        {
            dblLength = dblL;

        }


        public void setHeight(double dblH)
        {

            dblHeight = dblH;
        }

        public void setBreadth(double dblB)
        {

            dblBreadth = dblB;


        }

        public double getVolume()
        {

            return (dblBreadth * dblLength * dblHeight);
        }
    
    
        // Overload + operator to add Boxes

        public static Box operator+ (Box b, Box c)
        {


            Box box = new Box();

            box.dblLength = b.dblLength + c.dblLength;
            box.dblBreadth = b.dblBreadth + c.dblBreadth;
            box.dblHeight = b.dblHeight + c.dblHeight;

            return box;


        
        }

    }





    class StaticVarEx
    {
        public static int intA;



        public void count()
        {

            intA++;
        }


        public static int getVal()
        {

            return intA;
        }




    }
        

    // Code for Inheritance 

    class Shape
    {

        protected double  dblHeight;
        protected double dblWidth;

        public void setWidth(double w)
        {

            dblWidth = w;

        }


        public void SetHeight(double h)
        {

            dblHeight = h;

        }

      }


    // Derivied CLass

    class Rectangle : Shape
    {

        public double getArea()
        {

            return (dblWidth * dblHeight);

        }

        public void display()
        {



        }



    }


    // Base Class Initialization code 

    class Square
    {

        protected double dblLength;
        protected double dblWidth;


        public Square(double l, double w)
        {

            dblLength = l;
            dblWidth = w;


        }



        public double getArea()
        {

            return (dblLength * dblWidth);

        }



        public void display()
        {

            MessageBox.Show ("The Area is " + getArea ());


        }
    }

    class BigSquare : Square
    {

        private double dblCost;

        public BigSquare(double l, double w) 
            : base(l, w)

        {

        }


        public double getCost()
        {

            dblCost = getArea() * 10;
            return dblCost;

        }

        public void display()
        {

            base.display ();
            MessageBox.Show ("The Total Cost is " + getCost ().ToString ());
            
        }



        }

// Code for Multiple Intheritance 



    class BaseClass
    {

        protected double dblLength;
        protected double dblwidth;

        public void setLength(double l)
        {
            dblLength = l;
        }

        public void setWidth(double w)
        {

            dblwidth = w;
        }

        
    }

    public interface InterTest
    {

      double  getVal ();

    }


    class DerivedTest : BaseClass, InterTest
    {



        public double getVal()
        {

            return (dblLength * dblwidth);
        
        }

    }



        
}


