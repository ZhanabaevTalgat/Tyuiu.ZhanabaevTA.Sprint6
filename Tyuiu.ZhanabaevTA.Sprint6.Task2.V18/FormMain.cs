using Tyuiu.ZhanabaevTA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18
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

        private void textBoxStart_ЖТА_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Red;
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Green;
        }

        private void buttonRun_MouseDown(object sender, EventArgs e)
        {
            buttonRun_ЖТА.BackColor = Color.Blue;
        }
    }
}
