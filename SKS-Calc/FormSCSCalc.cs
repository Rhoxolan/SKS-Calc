using System.ComponentModel;

namespace SKS_Calc
{
    public partial class FormSCSCalc : Form
    {
        private BindingList<Configuration> configurations;
        private CalculateControl calculateControl;
        private HistoryControl historyControl;
        private InformationControl informationControl;

        public FormSCSCalc()
        {
            InitializeComponent();
            configurations = new();
            calculateControl = new(configurations); //Передача контролам ссылки на BindingList
            historyControl = new(configurations);
            informationControl = new();
            calculateControl.HistoryControl = historyControl; //Передача ссылок контролам на другие контролы для скрытия/отображения на форме
            calculateControl.InformationControl = informationControl;
            historyControl.CalculateControl = calculateControl;
            informationControl.CalculateControl = calculateControl;
        }

        private void FormSCSCalc_Load(object sender, EventArgs e)
        {
            calculateControl.Location = new Point(5, 7);
            this.Controls.Add(calculateControl);
            historyControl.Location = new Point(5, 7);
            this.Controls.Add(historyControl);
            informationControl.Location = new Point(5, 7);
            this.Controls.Add(informationControl);
            historyControl.Visible = false;
            informationControl.Visible = false;
        }
    }
}