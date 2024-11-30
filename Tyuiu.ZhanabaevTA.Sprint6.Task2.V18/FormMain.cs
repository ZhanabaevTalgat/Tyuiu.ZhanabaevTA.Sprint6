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

        private void buttonRun_ЖТА_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ЖТА.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ЖТА.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_ЖТА.Titles.Add("График функции ");

                this.chartFunction_ЖТА.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ЖТА.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_ЖТА.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_ЖТА.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }  
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_ЖТА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППБ-24-1 Жанабаев Талгат Асылбекович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Red;
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Green;
        }

        private void textBoxStart_ЖТА_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonRun_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Blue;
        }
    }
}
