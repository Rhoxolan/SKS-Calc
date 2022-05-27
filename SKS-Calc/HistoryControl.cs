﻿using System;
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
    public partial class HistoryControl : UserControl
    {
        private BindingList<Configuration> configurations;
        private string docPath;

        public UserControl? ParentControl { get; set; }

        public List<UserControl>? ChildControls { get; set; }

        public HistoryControl(BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.configurations = configurations;
            this.docPath = docPath;
            listBoxConfigurationsList.DataSource = configurations;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (ParentControl != null)
            {
                this.Visible = false;
                ParentControl.Visible = true;
            }
        }

        private void listBoxConfigurationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configurations[listBoxConfigurationsList.SelectedIndex].СableQuantity != null
                && configurations[listBoxConfigurationsList.SelectedIndex].HankQuantity != null)
            {
                textBoxShowConfigurationDetails.Text = configurations[listBoxConfigurationsList.SelectedIndex].ToLongOutputString();
            }
            else
            {
                textBoxShowConfigurationDetails.Text = configurations[listBoxConfigurationsList.SelectedIndex].ToLongOutputString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxConfigurationsList.SelectedValue != null)
            {
                if(MessageBox.Show("Вы точно хотите удалить запись конфигурации?", "Удаление записи конфигурации",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configurations.RemoveAt(listBoxConfigurationsList.SelectedIndex);
                    textBoxShowConfigurationDetails.Text = String.Empty;
                    using (FileStream fs = new(docPath, FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, configurations);
                    }
                }
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (configurations.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить ВСЕ записи конфигурации?", "Удаление записей конфигурации",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = configurations.Count - 1; i >= 0; i--)
                    {
                        configurations.RemoveAt(i);
                    }
                    textBoxShowConfigurationDetails.Text = String.Empty;
                    using (FileStream fs = new(docPath, FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, configurations);
                    }
                }
            }
        }

        private void buttonOutputSaveToTxt_Click(object sender, EventArgs e)
        {
            if (listBoxConfigurationsList.SelectedIndex != -1)
            {
                SaveFileDialog sfd = new();
                sfd.Filter = "Текстовые документы(*.txt)|*.txt";
                sfd.FileName = $"Конфигурация СКС {configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.ToShortDateString()} " +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.Hour}.{configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.Minute}." +
                    $"{configurations[listBoxConfigurationsList.SelectedIndex].RecordTime.Second}.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new(sfd.FileName, FileMode.Create);
                    using (StreamWriter sw = new(fs))
                    {
                        if (configurations[listBoxConfigurationsList.SelectedIndex].СableQuantity != null &&
                            configurations[listBoxConfigurationsList.SelectedIndex].HankQuantity != null)
                        {
                            sw.WriteLine(
                                configurations[listBoxConfigurationsList.SelectedIndex].ToLongSaveString());
                        }
                        else
                        {
                            sw.WriteLine(
                                configurations[listBoxConfigurationsList.SelectedIndex].ToLongSaveString());
                        }
                    }
                }
            }
        }
    }
}
