using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace Tim_Hortons_Cash_Register
{
    public partial class Form1 : Form
    {
        double change;
        double tendered;
        double numOfsCoffees;
        double numOfmCoffees;
        double numOflcoffees;
        double subtotal;
        double totalPrice;
        double sCoffeePrice = 1.60;
        double mCoffeePrice = 1.80;
        double lCoffeePrice = 2.00;
        double taxRate = .13;
        double tax;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        { 
            try
            {
                numOfsCoffees = Convert.ToDouble(SmallCoffeeInput.Text);
                numOfmCoffees = Convert.ToDouble(mediumCoffeeInput.Text);
                numOflcoffees = Convert.ToDouble(largeCoffeeOutput.Text);
                subtotal = sCoffeePrice * numOfsCoffees + mCoffeePrice * numOfmCoffees + lCoffeePrice * numOflcoffees;
                tax = subtotal * taxRate;
                totalPrice = subtotal + tax;
                subtotalOutput.Text = subtotal.ToString(".00 CAD");
                taxOutput.Text = tax.ToString(".00 CAD");
                totalOutput.Text = totalPrice.ToString(".00 CAD");
            } catch
            {
                recieptOutput.Text = "error please fill in all the boxes, and make sure your inputting a number";
                subtotalOutput.Text = "error";
                taxOutput.Text = "error";
                totalOutput.Text = "error";
                changeOutput.Text = "error";
                tenderedOutput.Text = "error";
            }

           

            

        }

        private void button1_Click(object sender, EventArgs e)
        {  try {
                tendered = Convert.ToDouble(tenderedOutput.Text);
                change = Convert.ToDouble(tendered - totalPrice);
                changeOutput.Text = change.ToString(".00 CAD");
            } catch
            {
                recieptOutput.Text = "error please fill in all the boxes and make sure you're using letters";
                subtotalOutput.Text = "error";
                taxOutput.Text = "error";
                totalOutput.Text = "error";
                changeOutput.Text = "error";
                tenderedOutput.Text = "error"; //
            }
            

                
            }


        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.printerSound); 
                player.Play(); 

                try {
            recieptOutput.Text = "             Tim Hortons\n ";
                recieptOutput.Text += $"Small Coffee       {numOfsCoffees}x     {sCoffeePrice.ToString("C")} \n ";
                    Thread.Sleep(1000);
                    Refresh();
                recieptOutput.Text += $"Medium Coffee      {numOfmCoffees}x     {mCoffeePrice.ToString("C")} \n ";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $"Large Coffee       {numOflcoffees}x     {lCoffeePrice.ToString("C")} \n \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $" subtotal                  {subtotal.ToString("C")} \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $" Tax                       {tax.ToString("C")} \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $" Total                     {totalPrice.ToString("C")} \n \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $" Tendered                  {tendered.ToString("C")} \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += $" Change                    {change.ToString("C")} \n";
                    Thread.Sleep(1000);
                         Refresh();
                    recieptOutput.Text += "            Come Again!";
                    

                } catch
                {
                    recieptOutput.Text = "error please fill in all the boxes, and make sure your inputting a number";
                    subtotalOutput.Text = "error";
                    taxOutput.Text = "error";
                    totalOutput.Text = "error";
                    changeOutput.Text = "error";
                    tenderedOutput.Text = "error";
                }
                {
                   
                }



            }

            {

            }



            {

            }
        }
    }
}
