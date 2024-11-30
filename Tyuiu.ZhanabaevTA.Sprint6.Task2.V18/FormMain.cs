using Tyuiu.ZhanabaevTA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_���_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_���.Text);
                int stopStep = Convert.ToInt32(textBoxStop_���.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_���.Titles.Add("������ ������� ");

                this.chartFunction_���.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_���.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_���.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_���.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }  
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_���_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ ����-24-1 �������� ������ �����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_���.BackColor = Color.Red;
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_���.BackColor = Color.Green;
        }

        private void textBoxStart_���_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonRun_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRun_���.BackColor = Color.Blue;
        }
    }
}
