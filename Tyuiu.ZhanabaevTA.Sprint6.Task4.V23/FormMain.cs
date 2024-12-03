using Tyuiu.ZhanabaevTA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_ЖТА_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_ЖТА.Text);
                int stop = Convert.ToInt32(textBoxStop_ЖТА.Text);

                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartFunction_ЖТА.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ЖТА.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ЖТА.Text = "";
                textBoxResult_ЖТА.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_ЖТА.AppendText("|    X    |  f(x)   |" + Environment.NewLine);
                textBoxResult_ЖТА.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_ЖТА.Series[0].Points.AddXY(start, valueArray[i]);

                    if (valueArray[i] <= -10)
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}  |", start, valueArray[i]);
                        textBoxResult_ЖТА.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                    else
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}   |", start, valueArray[i]);
                        textBoxResult_ЖТА.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                }

                textBoxResult_ЖТА.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_ЖТА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ-24-1 Жанабаев Талгат Асылбекович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_ЖТА_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_ЖТА_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string filePath = Path.Combine(tempPath, "OutPutFileTask4V23.txt");
                File.WriteAllText(filePath, textBoxResult_ЖТА.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + filePath + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = filePath;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_ЖТА_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
