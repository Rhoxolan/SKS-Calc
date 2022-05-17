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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermamentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).BeginInit();
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
            this.labelNumberOfWorkplaces.Location = new System.Drawing.Point(4, 88);
            this.labelNumberOfWorkplaces.Name = "labelNumberOfWorkplaces";
            this.labelNumberOfWorkplaces.Size = new System.Drawing.Size(154, 15);
            this.labelNumberOfWorkplaces.TabIndex = 4;
            this.labelNumberOfWorkplaces.Text = "Количество рабочих мест:";
            // 
            // numericUpDownNumberOfWorkplaces
            // 
            this.numericUpDownNumberOfWorkplaces.Location = new System.Drawing.Point(4, 106);
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
            this.labelNumberOfPorts.Location = new System.Drawing.Point(4, 132);
            this.labelNumberOfPorts.Name = "labelNumberOfPorts";
            this.labelNumberOfPorts.Size = new System.Drawing.Size(227, 15);
            this.labelNumberOfPorts.TabIndex = 6;
            this.labelNumberOfPorts.Text = "Количество портов на 1 рабочее место:";
            // 
            // numericUpDownNumberOfPorts
            // 
            this.numericUpDownNumberOfPorts.Location = new System.Drawing.Point(4, 150);
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
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownNumberOfPorts);
            this.Controls.Add(this.labelNumberOfPorts);
            this.Controls.Add(this.numericUpDownNumberOfWorkplaces);
            this.Controls.Add(this.labelNumberOfWorkplaces);
            this.Controls.Add(this.numericUpDownMaxPermamentLink);
            this.Controls.Add(this.labelMaxPermamentLink);
            this.Controls.Add(this.numericUpDownMinPermamentLink);
            this.Controls.Add(this.labelMinPermamentLink);
            this.Name = "CalculateControl";
            this.Size = new System.Drawing.Size(616, 395);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermamentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).EndInit();
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
    }
}
