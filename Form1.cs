using Combo_Box_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box_Exercise
{

    
    public partial class frmBox : Form
    {
        public frmBox()
        {
            InitializeComponent();
        }
        
        void changeComboBox(ComboBox cb)
        {
            switch (cb.SelectedIndex)
            {
                case  0 :
                    pb1.Image = Resources.Book;
                    lblTitlePicture.Text = "Book";
                    break;
                case 1 :
                    pb1.Image = Resources.Girl;
                    lblTitlePicture.Text = "Girl";
                    break;
                case 2:
                    pb1.Image = Resources.Boy;
                    lblTitlePicture.Text = "Boy";
                    break;
                case 3:
                    pb1.Image = Resources.Pen;
                    lblTitlePicture.Text = "Pen";
                    break;
        
            }

        }

        private void pb1_Click(object sender, EventArgs e)
        {
           
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeComboBox((ComboBox) sender);
        }
    }
}
