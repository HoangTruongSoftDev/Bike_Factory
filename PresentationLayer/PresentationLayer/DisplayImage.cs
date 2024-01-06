using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class DisplayImage : Form
    {
        public DisplayImage()
        {
            InitializeComponent();
        }

        #region//This region is about Delegate and declare Fields, Essential Methods

        public delegate void DelegateData(string passedData);
        public DelegateData linkData;

        string checkedBike = "Undefined";
        string chooseBike;

        private void DisplayImageBike()
        {
            if (checkedBike == "Road Bike" && radioButtonRed.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = "https://i.pinimg.com/736x/f0/16/d9/f016d9cdef715d091af765dc7ecfc2fb.jpg";

            }
            if (checkedBike == "Road Bike" && radioButtonBlue.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = "http://bikerumor.com/wp-content/uploads/2016/11/2016-Blue-Axino-road-bike-review02.jpg";

            }
            if (checkedBike == "Road Bike" && radioButtonDark.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = "https://i.stack.imgur.com/jqb5Y.png";

            }
            if (checkedBike == "Road Bike" && radioButtonUndefined.Checked == true)
            {
                MessageBox.Show("No Specific Color is Chosen", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (checkedBike == "Mountain Bike" && radioButtonRed.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = "https://i5.walmartimages.ca/images/Large/179/391/6000202179391.jpg";

            }
            if (checkedBike == "Mountain Bike" && radioButtonBlue.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = " https://www.huffybikes.com/media/catalog/product/cache/4f821af9573d574e43ab6dcbedb6481a/3/6/36338-1.jpg";

            }
            if (checkedBike == "Mountain Bike" && radioButtonDark.Checked == true)
            {
                pictureBoxDisplay.ImageLocation = "https://p.vitalmtb.com/photos/users/31831/setup_checks/26852/photos/29660/s780_IMG_8739.jpg?1411859263";

            }
            if (checkedBike == "Mountain Bike" && radioButtonUndefined.Checked == true)
            {
                MessageBox.Show("No Specific Color is Chosen", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (checkedBike == "Undefined")
            {
                MessageBox.Show("Please choose the type of Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linkData(chooseBike);
            }
        }

        private void AddBikeColor()
        {
            if (this.radioButtonRed.Checked == true)
            {
                chooseBike = "Red";
            }
            if (this.radioButtonBlue.Checked == true)
            {
                chooseBike = "Blue";
            }
            if (this.radioButtonDark.Checked == true)
            {
                chooseBike = "Dark";
            }
            if (this.radioButtonUndefined.Checked == true)
            {
                chooseBike = "Undefined";
            }
            if (checkedBike == "Mountain Bike")
            {
                MessageBox.Show("The Color of Mountain Bike has been chosen successfully", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkData(chooseBike);
            }
            if (checkedBike == "Road Bike")
            {
                MessageBox.Show("The Color of Road Bike has been chosen successfully", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkData(chooseBike);
            }
            if (checkedBike == "Undefined")
            {
                MessageBox.Show("Please choose the type of Bike", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linkData(chooseBike);
            }
        }
        #endregion

        #region//This region is about Buttons
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayImageBike();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddBikeColor();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void roadBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedBike = "Road Bike";
            MessageBox.Show("Road Bike has been chosen", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.labelTitleColor.Text = "Road Bike Color";
        }

        private void mountainBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedBike = "Mountain Bike";
            MessageBox.Show("Mountain Bike has been chosen", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.labelTitleColor.Text = "Mountain Bike Color";
        }
    }
}
