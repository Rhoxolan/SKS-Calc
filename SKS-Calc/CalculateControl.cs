using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKS_Calc
{
    public partial class CalculateControl : UserControl
    {
        private BindingList<Configuration> configurations;
        private string docPath;

        public UserControl? ParentControl { get; set; }

        public List<UserControl>? ChildControls { get; set; }

        public CalculateControl(BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.configurations = configurations;
            this.docPath = docPath;
            this.Load += OutputBlockCleaner; //Устанавливаем начальное отображение блока вывода
            buttonCalculate.Click += Saver; //Добавляем обработчик для сохранения данных списка конфигураций
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

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if(ChildControls != null && ChildControls.Count > 0)
            {
                foreach (var c in ChildControls)
                {
                    if(c is HistoryControl)
                    {
                        this.Visible = false;
                        c.Visible = true;
                    }
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (ChildControls != null && ChildControls.Count > 0)
            {
                foreach (var c in ChildControls)
                {
                    if (c is InformationControl)
                    {
                        this.Visible = false;
                        c.Visible = true;
                    }
                }
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (checkBoxCableHankMeterage.Checked)
            {
                double TechnologicalReserve = 1.10; //Коэффициент технологического запаса
                double MinPermamentLink = (double)numericUpDownMinPermamentLink.Value;
                double MaxPermamentLink = (double)numericUpDownMaxPermamentLink.Value;
                double AveragePermamentLink = (MinPermamentLink + MaxPermamentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = (int)numericUpDownNumberOfWorkplaces.Value;
                int NumberOfPorts = (int)numericUpDownNumberOfPorts.Value;
                double CableHankMeterage = (double)numericUpDownCableHankMeterage.Value;
                if (AveragePermamentLink > CableHankMeterage)
                {
                    MessageBox.Show("Расчет провести невозможно! Значение средней длины постояного линка " +
                        "превышает значение метража кабеля в бухте. Согласно стандарту ISO/IEC 11801, сращивание" +
                        "витой пары запрещено. Повторите расчет с друими параметрами.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double СableQuantity = AveragePermamentLink * NumberOfWorkplaces * NumberOfPorts;
                int HankQuantity = (int)Math.Ceiling(NumberOfWorkplaces * NumberOfPorts /
                    Math.Floor(CableHankMeterage / AveragePermamentLink));
                double TotalСableQuantity = HankQuantity * CableHankMeterage;
                configurations.Add(new(DateTime.Now, MinPermamentLink, MaxPermamentLink, AveragePermamentLink,
                    NumberOfWorkplaces, NumberOfPorts, СableQuantity, HankQuantity, TotalСableQuantity));
                textBoxOutputMinPermamentLink.Text = MinPermamentLink.ToString("F" + 2);
                textBoxOutputMaxPermamentLink.Text = MaxPermamentLink.ToString("F" + 2);
                textBoxOutputAveragePermamentLink.Text = AveragePermamentLink.ToString("F" + 2);
                textBoxOutputNumberOfPorts.Text = NumberOfPorts.ToString();
                textBoxOutputСableQuantity.Text = СableQuantity.ToString("F" + 2);
                textBoxOutputHankQuantity.Text = HankQuantity.ToString("F" + 2);
                textBoxOutputTotalСableQuantity.Text = TotalСableQuantity.ToString("F" + 2);
            }
            else
            {
                double TechnologicalReserve = 1.10; //Коэффициент технологического запаса
                double MinPermamentLink = (double)numericUpDownMinPermamentLink.Value;
                double MaxPermamentLink = (double)numericUpDownMaxPermamentLink.Value;
                double AveragePermamentLink = (MinPermamentLink + MaxPermamentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = (int)numericUpDownNumberOfWorkplaces.Value;
                int NumberOfPorts = (int)numericUpDownNumberOfPorts.Value;
                double TotalСableQuantity = AveragePermamentLink * NumberOfWorkplaces * NumberOfPorts;
                configurations.Add(new(DateTime.Now, MinPermamentLink, MaxPermamentLink, AveragePermamentLink,
                    NumberOfWorkplaces, NumberOfPorts, null, null, TotalСableQuantity));
                textBoxOutputMinPermamentLink.Text = MinPermamentLink.ToString("F" + 2);
                textBoxOutputMaxPermamentLink.Text = MaxPermamentLink.ToString("F" + 2);
                textBoxOutputAveragePermamentLink.Text = AveragePermamentLink.ToString("F" + 2);
                textBoxOutputNumberOfPorts.Text = NumberOfPorts.ToString();
                textBoxOutputTotalСableQuantity.Text = TotalСableQuantity.ToString("F" + 2);
            }
            buttonOutputSaveToTxt.Enabled = true;
        }

        private void buttonOutputSaveToTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = "Текстовые документы(*.txt)|*.txt";
            sfd.FileName = $"Конфигурация СКС {configurations[^1].RecordTime.ToShortDateString()} " +
                $"{configurations[^1].RecordTime.Hour}.{configurations[^1].RecordTime.Minute}." +
                $"{configurations[^1].RecordTime.Second}.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new(sfd.FileName, FileMode.Create);
                using (StreamWriter sw = new(fs))
                {
                    if (configurations[^1].СableQuantity != null && configurations[^1].HankQuantity != null)
                    {
                        sw.WriteLine($"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                            $"Дата записи конфигурации: {configurations[^1].RecordTime.ToString()}{Environment.NewLine}" +
                            $"Наименьшая длина постоянного линка (Permament Link):" +
                            $"{configurations[^1].MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Наибольшая длина постоянного линка (Permament Link): " +
                            $"{configurations[^1].MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Средняя длина постоянного линка (Permament Link): " +
                            $"{configurations[^1].AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Количество портов на 1 рабочее место: " +
                            $"{configurations[^1].NumberOfPorts}{Environment.NewLine}" +
                            $"Необходимое количество кабеля: " +
                            $"{configurations[^1].СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Необходимое количество бухт кабеля: " +
                            $"{configurations[^1].HankQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Итоговое необходимое количество кабеля: " +
                            $"{configurations[^1].TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}");
                    }
                    else
                    {
                        sw.WriteLine($"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                            $"Дата записи конфигурации: {configurations[^1].RecordTime.ToString()}{Environment.NewLine}" +
                            $"Наименьшая длина постоянного линка (Permament Link):" +
                            $"{configurations[^1].MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Наибольшая длина постоянного линка (Permament Link): " +
                            $"{configurations[^1].MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Средняя длина постоянного линка (Permament Link): " +
                            $"{configurations[^1].AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                            $"Количество портов на 1 рабочее место: " +
                            $"{configurations[^1].NumberOfPorts}{Environment.NewLine}" +
                            $"Итоговое необходимое количество кабеля: " +
                            $"{configurations[^1].TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}");
                    }
                }
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

        private void Saver(object? sender, EventArgs e) //Обработчик для сохранения данных списка конфигураций
        {
            using (FileStream fs = new(docPath, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, configurations);
            }
        }
    }
}
