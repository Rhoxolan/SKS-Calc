using System.ComponentModel;
using System.Text.Json;

namespace SKS_Calc
{
    public partial class FormSCSCalc : Form
    {
        private BindingList<Configuration> configurations;
        private CalculateControl calculateControl;
        private HistoryControl historyControl;
        private InformationControl informationControl;
        private string folderPath;
        private string docPath;

        public FormSCSCalc()
        {
            InitializeComponent();
            folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SCS-Calc Data Folder");
            docPath = Path.Combine(folderPath, "SCS-CalcData.json");
            Loader();
            calculateControl = new(configurations, docPath); //Передача контролам ссылки на список конфигураций (BindingList)
            historyControl = new(configurations, docPath);
            informationControl = new(configurations, docPath);
            calculateControl.ChildControls.Add(historyControl);
            calculateControl.ChildControls.Add(informationControl);
            historyControl.ParentControl = calculateControl;
            informationControl.ParentControl = calculateControl;

            /* При добавлении в приложение новых UserControl-ов, которые будут представлять новый режим, уровень или
              пункт меню, необходимо указать, какой U.Control является родительским (с какого U.Control-а был вызван
              этот U.Control) и какие U.Control-ы являются дочерними (какие U.Control-ы вызываются с этого U.Control-а).
              Примеры взаимодействия U.Control-ов можно посмотреть в любом уже созданном.
              При загрузке формы на ней размещаются все созданные U.Control-ы, все незадействованные скрываются.
              При переходе с одного режима на другой родительский U.Control скрывается, выбранный дочерний -
              отображается. Пример скрытия/отображения можно посмотреть в любом созданном U.Control-е. */
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

        private void Loader() //Метод для загрузки данных
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if(File.Exists(docPath))
            {
                using (FileStream fs = new(docPath, FileMode.Open))
                {
                    configurations = JsonSerializer.Deserialize<BindingList<Configuration>>(fs);
                }
            }
            else
            {
                configurations = new();
            }
        }
    }
}