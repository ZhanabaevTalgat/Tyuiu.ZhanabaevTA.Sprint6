using Tyuiu.ZhanabaevTA.Sprint6.Task0.V10.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxTask_���_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRun_���_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_���.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_���.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void buttonInfo_���_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 �������� ������ �����������", "���������");
        }

        private void textBoxVarA_���_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
    }
}

