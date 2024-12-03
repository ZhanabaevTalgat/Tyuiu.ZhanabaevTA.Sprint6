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

        private void buttonRun_���_Click(object sender, EventArgs e)
        {
            dataGridViewResult_���.ColumnCount = 2;
            dataGridViewResult_���.Columns[0].Width = 20;
            dataGridViewResult_���.Columns[1].Width = 50;

            this.chartDiag_���.ChartAreas[0].AxisX.Title = "��� X";
            this.chartDiag_���.ChartAreas[0].AxisY.Title = "��� Y";

            chartDiag_���.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_���.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_���.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_���_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_���_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 �������� ������ �����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
