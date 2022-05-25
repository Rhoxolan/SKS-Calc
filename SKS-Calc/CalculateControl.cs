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
        public HistoryControl? HistoryControl { get; set; }
        public InformationControl? InformationControl { get; set; }

        public CalculateControl(BindingList<Configuration> configurations)
        {
            InitializeComponent();
            HistoryControl = null;
            InformationControl = null;
            this.configurations = configurations;
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
                numericUpDownCableHankMeterage.Enabled = false;
            }
        }

        private void OutputBlockCleaner(object? sender, EventArgs e)
        {
            textBoxOutputMinPermamentLink.Text = string.Empty;
            textBoxOutputMaxPermamentLink.Text = string.Empty;
            textBoxOutputAveragePermamentLink.Text = string.Empty;
            textBoxOutputNumberOfPorts.Text = string.Empty;
            textBoxOutputСableQuantity.Text = string.Empty;
            textBoxOutputHankQuantity.Text = string.Empty;
            textBoxOutputTotalСableQuantity.Text = string.Empty;
            numericUpDownCableHankMeterage.Enabled = false;
            if (checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = true;
                textBoxOutputСableQuantity.Enabled = true;
                labelMeters7.Enabled = true;
                labelOutputHankQuantity.Enabled = true;
                textBoxOutputHankQuantity.Enabled = true;
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if (!checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = false;
                textBoxOutputСableQuantity.Enabled = false;
                labelMeters7.Enabled = false;
                labelOutputHankQuantity.Enabled = false;
                textBoxOutputHankQuantity.Enabled = false;
                numericUpDownCableHankMeterage.Enabled = false;
            }
            buttonOutputSaveToTxt.Enabled = false;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (HistoryControl != null)
            {
                this.Visible = false;
                HistoryControl.Visible = true;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (InformationControl != null)
            {
                this.Visible = false;
                InformationControl.Visible = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double MinPermamentLink = (double)numericUpDownMinPermamentLink.Value;
            double MaxPermamentLink = (double)numericUpDownMaxPermamentLink.Value;
            double AveragePermamentLink = (MinPermamentLink + MaxPermamentLink) / 2 * 1.15;
            double? HankQuantity = null;
            double? СableQuantity = null;
            if (checkBoxCableHankMeterage.Checked) //Тут всё перепроверить
            {
                HankQuantity = (int)numericUpDownCableHankMeterage.Value;
                if (AveragePermamentLink > HankQuantity)
                {
                    MessageBox.Show("Расчет провести невозможно! Значение средней длины постояного линка " +
                        "превышает значение метража кабеля в бухте. Согласно стандарту ISO/IEC 11801, сращивание" +
                        "витой пары запрещено. Повторите расчет с друими параметрами.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
