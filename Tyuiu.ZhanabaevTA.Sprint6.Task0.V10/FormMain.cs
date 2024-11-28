using Tyuiu.ZhanabaevTA.Sprint6.Task0.V10.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxTask_ЖТА_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRun_ЖТА_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_ЖТА.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_ЖТА.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void buttonInfo_ЖТА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППБ-24-1 Жанабаев Талгат Асылбекович", "Сообщение");
        }

        private void textBoxVarA_ЖТА_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
    }
}

