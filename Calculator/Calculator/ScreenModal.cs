using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ScreenModal : Form
    {
        public ScreenModal()
        {
            InitializeComponent();
        }

        private void Click_exitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
