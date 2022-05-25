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
        public CalculateControl? CalculateControl { get; set; }

        public HistoryControl(BindingList<Configuration> configurations)
        {
            InitializeComponent();
            CalculateControl = null;
            this.configurations = configurations;
            listBoxConfigurationsList.DataSource = configurations;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (CalculateControl != null)
            {
                this.Visible = false;
                CalculateControl.Visible = true;
            }
        }

        private void listBoxConfigurationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configurations[listBoxConfigurationsList.SelectedIndex].СableQuantity != null
                && configurations[listBoxConfigurationsList.SelectedIndex].HankQuantity != null)
            {
                textBoxShowConfigurationDetails.Text =
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].NumberOfPorts}{Environment.NewLine}" +
                    $"Необходимое количество кабеля: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Необходимое количество бухт кабеля: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].HankQuantity}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].TotalСableQuantity.ToString("F" + 2)}{Environment.NewLine}";
            }
            else
            {
                textBoxShowConfigurationDetails.Text =
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].NumberOfPorts}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].TotalСableQuantity.ToString("F" + 2)}{Environment.NewLine}";
            }
        }
    }
}
