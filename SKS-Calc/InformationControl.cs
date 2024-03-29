﻿using System.ComponentModel;
using System.Diagnostics;

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

        private void buttonBack_Click(object sender, EventArgs e) //Переход в предыдущий режим
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

        private void labelAuthorName_DoubleClick(object sender, EventArgs e) //Переход по ссылке на профиль GitHub автора приложения
        {
            try
            {
                using (Process process = new())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "https://github.com/Rhoxolan";
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
