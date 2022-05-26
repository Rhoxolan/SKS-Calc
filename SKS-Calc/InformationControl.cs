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
        private BindingList<Configuration> configurations;
        private string docPath;

        public UserControl? ParentControl { get; set; }

        public List<UserControl>? ChildControls { get; set; }

        public InformationControl(BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.configurations = configurations;
            this.docPath = docPath;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (ParentControl != null)
            {
                this.Visible = false;
                ParentControl.Visible = true;
            }
        }

        private void InformationControl_Load(object sender, EventArgs e)
        {
            textBoxInformation.Text = Properties.Resources.Text;
        }
    }
}
