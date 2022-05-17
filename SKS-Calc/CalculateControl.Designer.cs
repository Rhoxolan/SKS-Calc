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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).BeginInit();
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
            this.numericUpDownMinPermamentLink.Name = "numericUpDownMinPermamentLink";
            this.numericUpDownMinPermamentLink.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMinPermamentLink.TabIndex = 1;
            // 
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownMinPermamentLink);
            this.Controls.Add(this.labelMinPermamentLink);
            this.Name = "CalculateControl";
            this.Size = new System.Drawing.Size(616, 395);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermamentLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMinPermamentLink;
        private NumericUpDown numericUpDownMinPermamentLink;
    }
}
