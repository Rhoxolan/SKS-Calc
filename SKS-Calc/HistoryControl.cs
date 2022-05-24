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
    public partial class HistoryControl : UserControl
    {
        private BindingList<Configuration> configurations;

        public List<UserControl> OtherControls { get; set; }

        public HistoryControl(BindingList<Configuration> configurations)
        {
            InitializeComponent();
            OtherControls = new();
            this.configurations = configurations;
        }
    }
}
