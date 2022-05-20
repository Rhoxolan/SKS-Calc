﻿using System;
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
        public CalculateControl()
        {
            InitializeComponent();
        }

        private void CalculateControl_Load(object sender, EventArgs e)
        {
            numericUpDownCableHankMeterage.Enabled = false;
            OutputBlockCleaner();
        }

        private void OutputBlockCleaner()
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

        private void checkBoxCableHankMeterage_CheckedChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
            if (checkBoxCableHankMeterage.Checked)
            {
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if(!checkBoxCableHankMeterage.Checked)
            {
                checkBoxCableHankMeterage.Enabled = false;
            }
        }

        private void numericUpDownMinPermamentLink_ValueChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
        }

        private void numericUpDownMaxPermamentLink_ValueChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
        }

        private void numericUpDownNumberOfWorkplaces_ValueChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
        }

        private void numericUpDownNumberOfPorts_ValueChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
        }

        private void numericUpDownCableHankMeterage_ValueChanged(object sender, EventArgs e)
        {
            OutputBlockCleaner();
        }
    }
}
