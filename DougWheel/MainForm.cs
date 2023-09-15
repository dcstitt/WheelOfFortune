using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DougWheel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (RichTextBox box in panel1.Controls)
            {
                box.ReadOnly = true; 
                box.BackColor = Color.MediumSeaGreen;
            }
        }

        private void Row1Box1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
