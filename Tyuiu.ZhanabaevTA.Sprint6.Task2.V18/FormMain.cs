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

        private void buttonRun_���_Click(object sender, EventArgs e)
        {
            try
            {

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

        private void textBoxStart_���_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_���.BackColor = Color.Red;
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_���.BackColor = Color.Green;
        }

        private void buttonRun_MouseDown(object sender, EventArgs e)
        {
            buttonRun_���.BackColor = Color.Blue;
        }
    }
}
