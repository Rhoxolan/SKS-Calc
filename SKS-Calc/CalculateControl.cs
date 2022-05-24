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
        private BindingList<Configuration> configurations;

        public List<UserControl> OtherControls { get; set; }

        public CalculateControl(BindingList<Configuration> configurations)
        {
            InitializeComponent();
            this.configurations = configurations;
            OtherControls = new();
            this.Load += OutputBlockCleaner; //Устанавливаем начальное отображение блока вывода
            numericUpDownMinPermamentLink.ValueChanged += OutputBlockCleaner; //Очищаем блок вывода при любых изменениях
            numericUpDownMaxPermamentLink.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfWorkplaces.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfPorts.ValueChanged += OutputBlockCleaner;
            checkBoxCableHankMeterage.CheckedChanged += OutputBlockCleaner;
            numericUpDownCableHankMeterage.ValueChanged += OutputBlockCleaner;
        }

        private void CalculateControl_Load(object sender, EventArgs e)
        {
            checkBoxCableHankMeterage.Checked = false;
        }

        private void checkBoxCableHankMeterage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCableHankMeterage.Checked)
            {
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if(!checkBoxCableHankMeterage.Checked)
            {
                checkBoxCableHankMeterage.Enabled = false;
            }
        }

        private void OutputBlockCleaner(object? sender, EventArgs? e)
        {
            textBoxOutputMinPermamentLink.Text = string.Empty;
            textBoxOutputMaxPermamentLink.Text = string.Empty;
            textBoxOutputAveragePermamentLink.Text = string.Empty;
            textBoxOutputNumberOfPorts.Text = string.Empty;
            textBoxOutputСableQuantity.Text = string.Empty;
            textBoxOutputHankQuantity.Text = string.Empty;
            textBoxOutputTotalСableQuantity.Text = string.Empty;
            if (checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = true;
                textBoxOutputСableQuantity.Enabled = true;
                labelMeters7.Enabled = true;
                labelOutputHankQuantity.Enabled = true;
                textBoxOutputHankQuantity.Enabled = true;
            }
            if (!checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = false;
                textBoxOutputСableQuantity.Enabled = false;
                labelMeters7.Enabled = false;
                labelOutputHankQuantity.Enabled = false;
                textBoxOutputHankQuantity.Enabled = false;
            }
            buttonOutputSaveToTxt.Enabled = false;
        }
    }
}
