/*
 * Created by: Tobi Adebayo
 * Created on: 28-10-30
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program gets the degrees Celsius from the user, passes it by value to a procedure that converts it to Fahrenheit, and then inside the procedure displays the degrees Fahrenheit in a message box
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByValue_TempConverterTobi
{
    public partial class frmPassByValueTempConverter : Form
    {
        public frmPassByValueTempConverter()
        {
            InitializeComponent();

        }
        public void ConvertTofar(double celsius)
        {
            //declare local variables
            double fahrenheit;

            // convert the celsius to fahrenheit
            fahrenheit = celsius * (Double)9 / (Double)5 + 32;

            //display a message box with the answer
            MessageBox.Show(celsius + " degrees celsius" + " = " + fahrenheit + " degrees fahrenheit");
        }



        private void Frm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare local variables
            double UserCelsius;

            //convert the input celsius to double and assign to variable
            UserCelsius = Convert.ToDouble(this.txtCelsius.Text);

            //call the function to convert from celsius to fahrenheit 
            this.ConvertTofar(UserCelsius);
        }
    }
}
