namespace SKS_Calc
{
    partial class CalculateControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMinPermamentLink = new System.Windows.Forms.Label();
            this.numericUpDownMinPermamentLink = new System.Windows.Forms.NumericUpDown();
            this.labelMaxPermamentLink = new System.Windows.Forms.Label();
            this.numericUpDownMaxPermamentLink = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfWorkplaces = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfWorkplaces = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfPorts = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfPorts = new System.Windows.Forms.NumericUpDown();
            this.labelMeters1 = new System.Windows.Forms.Label();
            this.labelMeters2 = new System.Windows.Forms.Label();
            this.checkBoxCableHankMeterage = new System.Windows.Forms.CheckBox();
            this.numericUpDownCableHankMeterage = new System.Windows.Forms.NumericUpDown();
            this.labelMeters3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonOutputSaveToTxt = new System.Windows.Forms.Button();
            this.labelOutputTotalСableQuantity = new System.Windows.Forms.Label();
            this.labelMetersTotal = new System.Windows.Forms.Label();
            this.textBoxOutputTotalСableQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputHankQuantity = new System.Windows.Forms.Label();
            this.textBoxOutputHankQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputСableQuantity = new System.Windows.Forms.Label();
            this.labelMeters7 = new System.Windows.Forms.Label();
            this.textBoxOutputСableQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputNumberOfPorts = new System.Windows.Forms.Label();
            this.textBoxOutputNumberOfPorts = new System.Windows.Forms.TextBox();
            this.labelOutputAveragePermamentLink = new System.Windows.Forms.Label();
            this.labelMeters6 = new System.Windows.Forms.Label();
            this.textBoxOutputAveragePermamentLink = new System.Windows.Forms.TextBox();
            this.labelOutputMaxPermamentLink = new System.Windows.Forms.Label();
            this.labelMeters5 = new System.Windows.Forms.Label();
            this.textBoxOutputMaxPermamentLink = new System.Windows.Forms.TextBox();
            this.labelMeters4 = new System.Windows.Forms.Label();
            this.textBoxOutputMinPermamentLink = new System.Windows.Forms.TextBox();
            this.labelOutputMinPermamentLink = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermamentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCableHankMeterage)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinPermamentLink
            // 
            this.labelMinPermamentLink.AutoSize = true;
            this.labelMinPermamentLink.Location = new System.Drawing.Point(3, 0);
            this.labelMinPermamentLink.Name = "labelMinPermamentLink";
            this.labelMinPermamentLink.Size = new System.Drawing.Size(229, 15);
            this.labelMinPermamentLink.TabIndex = 0;
            this.labelMinPermamentLink.Text = "Наименьшая длина постоянного линка:";
            // 
            // numericUpDownMinPermamentLink
            // 
            this.numericUpDownMinPermamentLink.DecimalPlaces = 2;
            this.numericUpDownMinPermamentLink.Location = new System.Drawing.Point(3, 18);
            this.numericUpDownMinPermamentLink.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinPermamentLink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMinPermamentLink.Name = "numericUpDownMinPermamentLink";
            this.numericUpDownMinPermamentLink.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMinPermamentLink.TabIndex = 1;
            this.numericUpDownMinPermamentLink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinPermamentLink.ValueChanged += new System.EventHandler(this.numericUpDownMinPermamentLink_ValueChanged);
            // 
            // labelMaxPermamentLink
            // 
            this.labelMaxPermamentLink.AutoSize = true;
            this.labelMaxPermamentLink.Location = new System.Drawing.Point(3, 44);
            this.labelMaxPermamentLink.Name = "labelMaxPermamentLink";
            this.labelMaxPermamentLink.Size = new System.Drawing.Size(228, 15);
            this.labelMaxPermamentLink.TabIndex = 2;
            this.labelMaxPermamentLink.Text = "Наибольшая длина постоянного линка:";
            // 
            // numericUpDownMaxPermamentLink
            // 
            this.numericUpDownMaxPermamentLink.DecimalPlaces = 2;
            this.numericUpDownMaxPermamentLink.Location = new System.Drawing.Point(3, 62);
            this.numericUpDownMaxPermamentLink.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxPermamentLink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMaxPermamentLink.Name = "numericUpDownMaxPermamentLink";
            this.numericUpDownMaxPermamentLink.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMaxPermamentLink.TabIndex = 3;
            this.numericUpDownMaxPermamentLink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxPermamentLink.ValueChanged += new System.EventHandler(this.numericUpDownMaxPermamentLink_ValueChanged);
            // 
            // labelNumberOfWorkplaces
            // 
            this.labelNumberOfWorkplaces.AutoSize = true;
            this.labelNumberOfWorkplaces.Location = new System.Drawing.Point(3, 88);
            this.labelNumberOfWorkplaces.Name = "labelNumberOfWorkplaces";
            this.labelNumberOfWorkplaces.Size = new System.Drawing.Size(154, 15);
            this.labelNumberOfWorkplaces.TabIndex = 4;
            this.labelNumberOfWorkplaces.Text = "Количество рабочих мест:";
            // 
            // numericUpDownNumberOfWorkplaces
            // 
            this.numericUpDownNumberOfWorkplaces.Location = new System.Drawing.Point(3, 106);
            this.numericUpDownNumberOfWorkplaces.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNumberOfWorkplaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfWorkplaces.Name = "numericUpDownNumberOfWorkplaces";
            this.numericUpDownNumberOfWorkplaces.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNumberOfWorkplaces.TabIndex = 5;
            this.numericUpDownNumberOfWorkplaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfWorkplaces.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfWorkplaces_ValueChanged);
            // 
            // labelNumberOfPorts
            // 
            this.labelNumberOfPorts.AutoSize = true;
            this.labelNumberOfPorts.Location = new System.Drawing.Point(3, 132);
            this.labelNumberOfPorts.Name = "labelNumberOfPorts";
            this.labelNumberOfPorts.Size = new System.Drawing.Size(227, 15);
            this.labelNumberOfPorts.TabIndex = 6;
            this.labelNumberOfPorts.Text = "Количество портов на 1 рабочее место:";
            // 
            // numericUpDownNumberOfPorts
            // 
            this.numericUpDownNumberOfPorts.Location = new System.Drawing.Point(3, 150);
            this.numericUpDownNumberOfPorts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNumberOfPorts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfPorts.Name = "numericUpDownNumberOfPorts";
            this.numericUpDownNumberOfPorts.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNumberOfPorts.TabIndex = 7;
            this.numericUpDownNumberOfPorts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfPorts.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfPorts_ValueChanged);
            // 
            // labelMeters1
            // 
            this.labelMeters1.AutoSize = true;
            this.labelMeters1.Location = new System.Drawing.Point(129, 26);
            this.labelMeters1.Name = "labelMeters1";
            this.labelMeters1.Size = new System.Drawing.Size(19, 15);
            this.labelMeters1.TabIndex = 8;
            this.labelMeters1.Text = "м.";
            // 
            // labelMeters2
            // 
            this.labelMeters2.AutoSize = true;
            this.labelMeters2.Location = new System.Drawing.Point(129, 70);
            this.labelMeters2.Name = "labelMeters2";
            this.labelMeters2.Size = new System.Drawing.Size(19, 15);
            this.labelMeters2.TabIndex = 9;
            this.labelMeters2.Text = "м.";
            // 
            // checkBoxCableHankMeterage
            // 
            this.checkBoxCableHankMeterage.AutoSize = true;
            this.checkBoxCableHankMeterage.Location = new System.Drawing.Point(3, 179);
            this.checkBoxCableHankMeterage.Name = "checkBoxCableHankMeterage";
            this.checkBoxCableHankMeterage.Size = new System.Drawing.Size(156, 19);
            this.checkBoxCableHankMeterage.TabIndex = 10;
            this.checkBoxCableHankMeterage.Text = "Метраж кабеля в бухте:";
            this.checkBoxCableHankMeterage.UseVisualStyleBackColor = true;
            this.checkBoxCableHankMeterage.CheckedChanged += new System.EventHandler(this.checkBoxCableHankMeterage_CheckedChanged);
            // 
            // numericUpDownCableHankMeterage
            // 
            this.numericUpDownCableHankMeterage.DecimalPlaces = 2;
            this.numericUpDownCableHankMeterage.Location = new System.Drawing.Point(3, 204);
            this.numericUpDownCableHankMeterage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCableHankMeterage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCableHankMeterage.Name = "numericUpDownCableHankMeterage";
            this.numericUpDownCableHankMeterage.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCableHankMeterage.TabIndex = 11;
            this.numericUpDownCableHankMeterage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCableHankMeterage.ValueChanged += new System.EventHandler(this.numericUpDownCableHankMeterage_ValueChanged);
            // 
            // labelMeters3
            // 
            this.labelMeters3.AutoSize = true;
            this.labelMeters3.Location = new System.Drawing.Point(129, 212);
            this.labelMeters3.Name = "labelMeters3";
            this.labelMeters3.Size = new System.Drawing.Size(19, 15);
            this.labelMeters3.TabIndex = 12;
            this.labelMeters3.Text = "м.";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(3, 233);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(105, 23);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.buttonOutputSaveToTxt);
            this.groupBoxOutput.Controls.Add(this.labelOutputTotalСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelMetersTotal);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputTotalСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputHankQuantity);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputHankQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelMeters7);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputNumberOfPorts);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputNumberOfPorts);
            this.groupBoxOutput.Controls.Add(this.labelOutputAveragePermamentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters6);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputAveragePermamentLink);
            this.groupBoxOutput.Controls.Add(this.labelOutputMaxPermamentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters5);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputMaxPermamentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters4);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputMinPermamentLink);
            this.groupBoxOutput.Controls.Add(this.labelOutputMinPermamentLink);
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 262);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(509, 256);
            this.groupBoxOutput.TabIndex = 14;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // buttonOutputSaveToTxt
            // 
            this.buttonOutputSaveToTxt.Location = new System.Drawing.Point(7, 225);
            this.buttonOutputSaveToTxt.Name = "buttonOutputSaveToTxt";
            this.buttonOutputSaveToTxt.Size = new System.Drawing.Size(105, 23);
            this.buttonOutputSaveToTxt.TabIndex = 15;
            this.buttonOutputSaveToTxt.Text = "Сохранить в TXT";
            this.buttonOutputSaveToTxt.UseVisualStyleBackColor = true;
            // 
            // labelOutputTotalСableQuantity
            // 
            this.labelOutputTotalСableQuantity.AutoSize = true;
            this.labelOutputTotalСableQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutputTotalСableQuantity.Location = new System.Drawing.Point(6, 204);
            this.labelOutputTotalСableQuantity.Name = "labelOutputTotalСableQuantity";
            this.labelOutputTotalСableQuantity.Size = new System.Drawing.Size(251, 15);
            this.labelOutputTotalСableQuantity.TabIndex = 25;
            this.labelOutputTotalСableQuantity.Text = "Итоговое необходимое количество кабеля:";
            // 
            // labelMetersTotal
            // 
            this.labelMetersTotal.AutoSize = true;
            this.labelMetersTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMetersTotal.Location = new System.Drawing.Point(480, 204);
            this.labelMetersTotal.Name = "labelMetersTotal";
            this.labelMetersTotal.Size = new System.Drawing.Size(19, 15);
            this.labelMetersTotal.TabIndex = 24;
            this.labelMetersTotal.Text = "м.";
            // 
            // textBoxOutputTotalСableQuantity
            // 
            this.textBoxOutputTotalСableQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputTotalСableQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOutputTotalСableQuantity.Location = new System.Drawing.Point(374, 196);
            this.textBoxOutputTotalСableQuantity.Name = "textBoxOutputTotalСableQuantity";
            this.textBoxOutputTotalСableQuantity.ReadOnly = true;
            this.textBoxOutputTotalСableQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputTotalСableQuantity.TabIndex = 23;
            // 
            // labelOutputHankQuantity
            // 
            this.labelOutputHankQuantity.AutoSize = true;
            this.labelOutputHankQuantity.Location = new System.Drawing.Point(7, 175);
            this.labelOutputHankQuantity.Name = "labelOutputHankQuantity";
            this.labelOutputHankQuantity.Size = new System.Drawing.Size(225, 15);
            this.labelOutputHankQuantity.TabIndex = 22;
            this.labelOutputHankQuantity.Text = "Необходимое количество бухт кабеля: ";
            // 
            // textBoxOutputHankQuantity
            // 
            this.textBoxOutputHankQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputHankQuantity.Location = new System.Drawing.Point(374, 167);
            this.textBoxOutputHankQuantity.Name = "textBoxOutputHankQuantity";
            this.textBoxOutputHankQuantity.ReadOnly = true;
            this.textBoxOutputHankQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputHankQuantity.TabIndex = 21;
            // 
            // labelOutputСableQuantity
            // 
            this.labelOutputСableQuantity.AutoSize = true;
            this.labelOutputСableQuantity.Location = new System.Drawing.Point(7, 146);
            this.labelOutputСableQuantity.Name = "labelOutputСableQuantity";
            this.labelOutputСableQuantity.Size = new System.Drawing.Size(198, 15);
            this.labelOutputСableQuantity.TabIndex = 20;
            this.labelOutputСableQuantity.Text = "Необходимое количество кабеля: ";
            // 
            // labelMeters7
            // 
            this.labelMeters7.AutoSize = true;
            this.labelMeters7.Location = new System.Drawing.Point(480, 146);
            this.labelMeters7.Name = "labelMeters7";
            this.labelMeters7.Size = new System.Drawing.Size(19, 15);
            this.labelMeters7.TabIndex = 19;
            this.labelMeters7.Text = "м.";
            // 
            // textBoxOutputСableQuantity
            // 
            this.textBoxOutputСableQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputСableQuantity.Location = new System.Drawing.Point(374, 138);
            this.textBoxOutputСableQuantity.Name = "textBoxOutputСableQuantity";
            this.textBoxOutputСableQuantity.ReadOnly = true;
            this.textBoxOutputСableQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputСableQuantity.TabIndex = 18;
            // 
            // labelOutputNumberOfPorts
            // 
            this.labelOutputNumberOfPorts.AutoSize = true;
            this.labelOutputNumberOfPorts.Location = new System.Drawing.Point(6, 117);
            this.labelOutputNumberOfPorts.Name = "labelOutputNumberOfPorts";
            this.labelOutputNumberOfPorts.Size = new System.Drawing.Size(227, 15);
            this.labelOutputNumberOfPorts.TabIndex = 17;
            this.labelOutputNumberOfPorts.Text = "Количество портов на 1 рабочее место:";
            // 
            // textBoxOutputNumberOfPorts
            // 
            this.textBoxOutputNumberOfPorts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputNumberOfPorts.Location = new System.Drawing.Point(374, 109);
            this.textBoxOutputNumberOfPorts.Name = "textBoxOutputNumberOfPorts";
            this.textBoxOutputNumberOfPorts.ReadOnly = true;
            this.textBoxOutputNumberOfPorts.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputNumberOfPorts.TabIndex = 16;
            // 
            // labelOutputAveragePermamentLink
            // 
            this.labelOutputAveragePermamentLink.AutoSize = true;
            this.labelOutputAveragePermamentLink.Location = new System.Drawing.Point(7, 88);
            this.labelOutputAveragePermamentLink.Name = "labelOutputAveragePermamentLink";
            this.labelOutputAveragePermamentLink.Size = new System.Drawing.Size(300, 15);
            this.labelOutputAveragePermamentLink.TabIndex = 15;
            this.labelOutputAveragePermamentLink.Text = "Средняя длина постоянного линка (Permament Link):";
            // 
            // labelMeters6
            // 
            this.labelMeters6.AutoSize = true;
            this.labelMeters6.Location = new System.Drawing.Point(480, 88);
            this.labelMeters6.Name = "labelMeters6";
            this.labelMeters6.Size = new System.Drawing.Size(19, 15);
            this.labelMeters6.TabIndex = 14;
            this.labelMeters6.Text = "м.";
            // 
            // textBoxOutputAveragePermamentLink
            // 
            this.textBoxOutputAveragePermamentLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputAveragePermamentLink.Location = new System.Drawing.Point(374, 80);
            this.textBoxOutputAveragePermamentLink.Name = "textBoxOutputAveragePermamentLink";
            this.textBoxOutputAveragePermamentLink.ReadOnly = true;
            this.textBoxOutputAveragePermamentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputAveragePermamentLink.TabIndex = 13;
            // 
            // labelOutputMaxPermamentLink
            // 
            this.labelOutputMaxPermamentLink.AutoSize = true;
            this.labelOutputMaxPermamentLink.Location = new System.Drawing.Point(7, 59);
            this.labelOutputMaxPermamentLink.Name = "labelOutputMaxPermamentLink";
            this.labelOutputMaxPermamentLink.Size = new System.Drawing.Size(326, 15);
            this.labelOutputMaxPermamentLink.TabIndex = 12;
            this.labelOutputMaxPermamentLink.Text = "Наибольшая длина постоянного линка (Permament Link):";
            // 
            // labelMeters5
            // 
            this.labelMeters5.AutoSize = true;
            this.labelMeters5.Location = new System.Drawing.Point(480, 59);
            this.labelMeters5.Name = "labelMeters5";
            this.labelMeters5.Size = new System.Drawing.Size(19, 15);
            this.labelMeters5.TabIndex = 11;
            this.labelMeters5.Text = "м.";
            // 
            // textBoxOutputMaxPermamentLink
            // 
            this.textBoxOutputMaxPermamentLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputMaxPermamentLink.Location = new System.Drawing.Point(374, 51);
            this.textBoxOutputMaxPermamentLink.Name = "textBoxOutputMaxPermamentLink";
            this.textBoxOutputMaxPermamentLink.ReadOnly = true;
            this.textBoxOutputMaxPermamentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputMaxPermamentLink.TabIndex = 10;
            // 
            // labelMeters4
            // 
            this.labelMeters4.AutoSize = true;
            this.labelMeters4.Location = new System.Drawing.Point(480, 30);
            this.labelMeters4.Name = "labelMeters4";
            this.labelMeters4.Size = new System.Drawing.Size(19, 15);
            this.labelMeters4.TabIndex = 9;
            this.labelMeters4.Text = "м.";
            // 
            // textBoxOutputMinPermamentLink
            // 
            this.textBoxOutputMinPermamentLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOutputMinPermamentLink.Location = new System.Drawing.Point(374, 22);
            this.textBoxOutputMinPermamentLink.Name = "textBoxOutputMinPermamentLink";
            this.textBoxOutputMinPermamentLink.ReadOnly = true;
            this.textBoxOutputMinPermamentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputMinPermamentLink.TabIndex = 2;
            // 
            // labelOutputMinPermamentLink
            // 
            this.labelOutputMinPermamentLink.AutoSize = true;
            this.labelOutputMinPermamentLink.Location = new System.Drawing.Point(6, 30);
            this.labelOutputMinPermamentLink.Name = "labelOutputMinPermamentLink";
            this.labelOutputMinPermamentLink.Size = new System.Drawing.Size(327, 15);
            this.labelOutputMinPermamentLink.TabIndex = 1;
            this.labelOutputMinPermamentLink.Text = "Наименьшая длина постоянного линка (Permament Link):";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(407, 233);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(105, 23);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(296, 233);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(105, 23);
            this.buttonHistory.TabIndex = 16;
            this.buttonHistory.Text = "История";
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelMeters3);
            this.Controls.Add(this.numericUpDownCableHankMeterage);
            this.Controls.Add(this.checkBoxCableHankMeterage);
            this.Controls.Add(this.labelMeters2);
            this.Controls.Add(this.labelMeters1);
            this.Controls.Add(this.numericUpDownNumberOfPorts);
            this.Controls.Add(this.labelNumberOfPorts);
            this.Controls.Add(this.numericUpDownNumberOfWorkplaces);
            this.Controls.Add(this.labelNumberOfWorkplaces);
            this.Controls.Add(this.numericUpDownMaxPermamentLink);
            this.Controls.Add(this.labelMaxPermamentLink);
            this.Controls.Add(this.numericUpDownMinPermamentLink);
            this.Controls.Add(this.labelMinPermamentLink);
            this.Name = "CalculateControl";
            this.Size = new System.Drawing.Size(514, 520);
            this.Load += new System.EventHandler(this.CalculateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermamentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCableHankMeterage)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMinPermamentLink;
        private NumericUpDown numericUpDownMinPermamentLink;
        private Label labelMaxPermamentLink;
        private NumericUpDown numericUpDownMaxPermamentLink;
        private Label labelNumberOfWorkplaces;
        private NumericUpDown numericUpDownNumberOfWorkplaces;
        private Label labelNumberOfPorts;
        private NumericUpDown numericUpDownNumberOfPorts;
        private Label labelMeters1;
        private Label labelMeters2;
        private CheckBox checkBoxCableHankMeterage;
        private NumericUpDown numericUpDownCableHankMeterage;
        private Label labelMeters3;
        private Button buttonCalculate;
        private GroupBox groupBoxOutput;
        private Label labelMeters4;
        private TextBox textBoxOutputMinPermamentLink;
        private Label labelOutputMinPermamentLink;
        private Label labelOutputAveragePermamentLink;
        private Label labelMeters6;
        private TextBox textBoxOutputAveragePermamentLink;
        private Label labelOutputMaxPermamentLink;
        private Label labelMeters5;
        private TextBox textBoxOutputMaxPermamentLink;
        private Label labelOutputNumberOfPorts;
        private TextBox textBoxOutputNumberOfPorts;
        private Button buttonOutputSaveToTxt;
        private Label labelOutputTotalСableQuantity;
        private Label labelMetersTotal;
        private TextBox textBoxOutputTotalСableQuantity;
        private Label labelOutputHankQuantity;
        private TextBox textBoxOutputHankQuantity;
        private Label labelOutputСableQuantity;
        private Label labelMeters7;
        private TextBox textBoxOutputСableQuantity;
        private Button buttonInfo;
        private Button buttonHistory;
    }
}
