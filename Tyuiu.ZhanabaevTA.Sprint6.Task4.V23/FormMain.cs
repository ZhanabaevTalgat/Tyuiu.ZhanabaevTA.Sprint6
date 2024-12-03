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

        private void buttonRun_���_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_���.Text);
                int stop = Convert.ToInt32(textBoxStop_���.Text);

                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartFunction_���.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_���.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_���.Text = "";
                textBoxResult_���.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_���.AppendText("|    X    |  f(x)   |" + Environment.NewLine);
                textBoxResult_���.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_���.Series[0].Points.AddXY(start, valueArray[i]);

                    if (valueArray[i] <= -10)
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}  |", start, valueArray[i]);
                        textBoxResult_���.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                    else
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}   |", start, valueArray[i]);
                        textBoxResult_���.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                }

                textBoxResult_���.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_���_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 �������� ������ �����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_���_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_���_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string filePath = Path.Combine(tempPath, "OutPutFileTask4V23.txt");
                File.WriteAllText(filePath, textBoxResult_���.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + filePath + " �������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_���_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
