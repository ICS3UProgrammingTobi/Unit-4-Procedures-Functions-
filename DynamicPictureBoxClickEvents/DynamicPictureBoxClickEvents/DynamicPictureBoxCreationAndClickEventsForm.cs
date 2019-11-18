using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPictureBoxClickEvents
{
    public partial class frmDynamicPictureBoxCreationAndClickEvents : Form
    {
        public frmDynamicPictureBoxCreationAndClickEvents()
        {
            InitializeComponent();
            //Hide the instructions label
            this.lblInstructions.Hide();
        }

        private void GeneratePictureBoxes()
        {
            //Generate the picture boxes
            GeneratePictureBoxes(61, 78);
            GeneratePictureBoxes(464, 78);
            GeneratePictureBoxes(61, 358);
            GeneratePictureBoxes(464, 358);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //show the label
            this.lblInstructions.Show();

            //generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void GeneratePictureBoxes(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x,y)

        }
    }
}
