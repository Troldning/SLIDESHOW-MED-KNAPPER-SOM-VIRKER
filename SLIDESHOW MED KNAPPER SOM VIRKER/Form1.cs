using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIDESHOW_MED_KNAPPER_SOM_VIRKER
{
    public partial class Form1 : Form
    {
        int _currentIndex = 0;
        int currentIndex
        {


            get
            {
                return _currentIndex;
            }
            set
            {
                if (value >= imageList1.Images.Count)
                {
                    //    if index is out of range in the large side, reset to 0
                    _currentIndex = 0;
                }
                else if (value < 0)
                {
                    //    if index is out of range in the samll side, reset to number of images - 1 (it's 0 based)
                    _currentIndex = imageList1.Images.Count - 1;
                }
                else
                {
                    _currentIndex = value;
                }
                //    update image after index is updated
                pictureBox1.Image = imageList1.Images[_currentIndex];
            }
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[currentIndex];
        }

        private void nextKnap_Click(object sender, EventArgs e)
        {
            currentIndex++;
        }

        private void prevKnap_Click(object sender, EventArgs e)
        {
            currentIndex--;
        }
    }
}
    