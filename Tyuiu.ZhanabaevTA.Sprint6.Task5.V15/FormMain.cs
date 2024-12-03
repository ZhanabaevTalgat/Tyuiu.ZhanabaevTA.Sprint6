using Tyuiu.ZhanabaevTA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V15.txt";

        private void buttonRun_ЖТА_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ЖТА.ColumnCount = 2;
            dataGridViewResult_ЖТА.Columns[0].Width = 20;
            dataGridViewResult_ЖТА.Columns[1].Width = 50;

            this.chartDiag_ЖТА.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ЖТА.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_ЖТА.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ЖТА.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_ЖТА.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_ЖТА_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_ЖТА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ-24-1 Жанабаев Талгат Асылбекович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
