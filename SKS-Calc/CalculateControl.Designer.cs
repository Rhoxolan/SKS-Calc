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
            this.labelMinPermamentLinkOutput = new System.Windows.Forms.Label();
            this.textBoxMinPermamentLinkOutput = new System.Windows.Forms.TextBox();
            this.labelMeters4 = new System.Windows.Forms.Label();
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
            this.buttonCalculate.Size = new System.Drawing.Size(85, 23);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelMeters4);
            this.groupBoxOutput.Controls.Add(this.textBoxMinPermamentLinkOutput);
            this.groupBoxOutput.Controls.Add(this.labelMinPermamentLinkOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 262);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(384, 169);
            this.groupBoxOutput.TabIndex = 14;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // labelMinPermamentLinkOutput
            // 
            this.labelMinPermamentLinkOutput.AutoSize = true;
            this.labelMinPermamentLinkOutput.Location = new System.Drawing.Point(6, 30);
            this.labelMinPermamentLinkOutput.Name = "labelMinPermamentLinkOutput";
            this.labelMinPermamentLinkOutput.Size = new System.Drawing.Size(229, 15);
            this.labelMinPermamentLinkOutput.TabIndex = 1;
            this.labelMinPermamentLinkOutput.Text = "Наименьшая длина постоянного линка:";
            // 
            // textBoxMinPermamentLinkOutput
            // 
            this.textBoxMinPermamentLinkOutput.Location = new System.Drawing.Point(241, 22);
            this.textBoxMinPermamentLinkOutput.Name = "textBoxMinPermamentLinkOutput";
            this.textBoxMinPermamentLinkOutput.ReadOnly = true;
            this.textBoxMinPermamentLinkOutput.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinPermamentLinkOutput.TabIndex = 2;
            // 
            // labelMeters4
            // 
            this.labelMeters4.AutoSize = true;
            this.labelMeters4.Location = new System.Drawing.Point(347, 30);
            this.labelMeters4.Name = "labelMeters4";
            this.labelMeters4.Size = new System.Drawing.Size(19, 15);
            this.labelMeters4.TabIndex = 9;
            this.labelMeters4.Text = "м.";
            // 
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(616, 463);
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
        private TextBox textBoxMinPermamentLinkOutput;
        private Label labelMinPermamentLinkOutput;
    }
}
