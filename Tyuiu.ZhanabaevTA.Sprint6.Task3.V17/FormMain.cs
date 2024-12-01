using Tyuiu.ZhanabaevTA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] {
            {22, 32, -16, 24, 27},
            {3, -20, 24, -20, 25},
            {21, 17, -8, -19, 17},
            {8, 22, 28, 27, 19},
            {11, 20, 12, 7, 29},
        };

        private void buttonRun_∆“¿_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewResult_∆“¿.ColumnCount = columns;
            dataGridViewResult_∆“¿.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_∆“¿.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_∆“¿.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_∆“¿_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“‡ÒÍ 3 ‚˚ÔÓÎÌËÎ ÒÚÛ‰ÂÌÚ „ÛÔÔ˚ –œœ¡-24-1 ∆‡Ì‡·‡Â‚ “‡Î„‡Ú ¿Ò˚Î·ÂÍÓ‚Ë˜", "—ÓÓ·˘ÂÌËÂ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTask_∆“¿.ColumnCount = columns;
            dataGridViewTask_∆“¿.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_∆“¿.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_∆“¿.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
