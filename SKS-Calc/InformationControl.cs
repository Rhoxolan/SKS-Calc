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
        public List<UserControl> OtherControls { get; set; }

        public InformationControl()
        {
            InitializeComponent();
            OtherControls = new();
        }
    }
}
