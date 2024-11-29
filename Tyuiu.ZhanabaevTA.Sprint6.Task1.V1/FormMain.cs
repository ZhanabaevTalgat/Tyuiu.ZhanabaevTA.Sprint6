using Tyuiu.ZhanabaevTA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxResult_∆“¿_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRun_∆“¿_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_∆“¿.Text);
                int stop = Convert.ToInt32(textBoxStop_∆“¿.Text);

                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                textBoxResult_∆“¿.Text = "";
                textBoxResult_∆“¿.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_∆“¿.AppendText("|    X    |  f(x)   |" + Environment.NewLine);
                textBoxResult_∆“¿.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    if (valueArray[i] <= -10)
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}  |", start, valueArray[i]);
                        textBoxResult_∆“¿.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                    else
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}   |", start, valueArray[i]);
                        textBoxResult_∆“¿.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                }

                textBoxResult_∆“¿.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬‚Â‰ÂÌ˚ ÌÂ‚ÂÌ˚Â ‰‡ÌÌ˚Â", "Œ¯Ë·Í‡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStart_∆“¿_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonInfo_∆“¿_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("“‡ÒÍ 1 ‚˚ÔÓÎÌËÎ ÒÚÛ‰ÂÌÚ „ÛÔÔ˚ –œœ¡-24-1 ∆‡Ì‡·‡Â‚ “‡Î„‡Ú ¿Ò˚Î·ÂÍÓ‚Ë˜", "—ÓÓ·˘ÂÌËÂ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxStart_∆“¿_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_∆“¿_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
