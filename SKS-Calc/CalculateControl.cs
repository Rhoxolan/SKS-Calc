using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKS_Calc
{
    public partial class CalculateControl : UserControl
    {
        public CalculateControl()
        {
            InitializeComponent();
        }

        private void CalculateControl_Load(object sender, EventArgs e)
        {
            numericUpDownCableHankMeterage.Enabled = false;
        }

        private void checkBoxCableHankMeterage_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCableHankMeterage.Checked)
            {
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if(!checkBoxCableHankMeterage.Checked)
            {
                checkBoxCableHankMeterage.Enabled = false;
            }
        }
    }
}
