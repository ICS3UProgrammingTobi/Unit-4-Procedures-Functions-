using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersTobi
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }
        //Procedure: PrintAdress
        //Input: String apptNumber,String streetAdress,String City,String Province,String postalCode.
        //Ouput; Void
        //Description: This procedure displays a message box with the given five parameters: apptNumber,streetAdress,City,Province,postalCode
        public void PrintAdress(string apptNumber,string streetAdress,string City,string Province,string postalCode)
        {
            MessageBox.Show("Your Appartement Number is:" +  apptNumber +  "Your Street Name is:" +  streetAdress  +  "The name of your City is:"  +  City  +  "Your province is:"  +  Province  +  "Your postal code is:"  +  postalCode);
        }
        //Procedure: PrintAdress
        //Input: String apptNumber,String streetAdress,String City,String Province,String postalCode.
        //Ouput; Void
        //Description: This procedure displays a message box with the given four parameters: streetAdress,City,Province,postalCode
        public void PrintAdress(string streetAdress, string City, string Province, string postalCode)
        {
            MessageBox.Show("Your Street Name is:" + streetAdress + "The name of your City is:" + City + "Your province is:" + Province + "Your postal code is:" + postalCode);
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string UserAppartementNumber, UserStreetAdress, Usercity, UserProvince,UserPostalCode;

            //Get Inputs from message box
            UserAppartementNumber = this.txtAptNumber.Text;
            UserStreetAdress = this.txtStreetAdress.Text;
            Usercity = this.txtCity.Text;



        }

    }
}
