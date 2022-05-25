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
    public partial class InformationControl : UserControl
    {
        public CalculateControl? CalculateControl { get; set; }

        public InformationControl()
        {
            InitializeComponent();
            CalculateControl = null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (CalculateControl != null)
            {
                this.Visible = false;
                CalculateControl.Visible = true;
            }
        }
    }
}
