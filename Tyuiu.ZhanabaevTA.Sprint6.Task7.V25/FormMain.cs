using System.Drawing.Drawing2D;
using Tyuiu.ZhanabaevTA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_���.Filter = "��������, ����������� �������� (*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogMatrix_���.Filter = "��������, ����������� �������� (*.csv)|*.csv|��� �����(*.*)|*.*";
        }

        int rows;
        int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonOpenFile_���_Click(object sender, EventArgs e)
        {
            openFileDialogTask_���.ShowDialog();
            openFilePath = openFileDialogTask_���.FileName;
            if (openFilePath == "")
            {
                MessageBox.Show("���� �� ��� ������", "������");
            }
            else
            {
                MessageBox.Show($"���� {openFilePath} ������ �������", "��������");


                int[,] matrix = LoadFromFileData(openFilePath);
                dataGridViewIn_���.ColumnCount = matrix.GetLength(1);
                dataGridViewIn_���.RowCount = matrix.GetLength(0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        dataGridViewIn_���.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                buttonDone_���.Enabled = true;
            }
        }

        private void buttonDone_���_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            dataGridViewOut_���.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_���.RowCount = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOut_���.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            buttonSave_���.Enabled = true;
        }

        private void buttonSave_���_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_���.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_���.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_���.ShowDialog();

            string path = saveFileDialogMatrix_���.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_���.RowCount;
            int columns = dataGridViewOut_���.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_���.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_���.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_���_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            dataGridViewIn_���.ColumnCount = 50;
            dataGridViewOut_���.ColumnCount = 50;

            dataGridViewIn_���.RowCount = 50;
            dataGridViewOut_���.RowCount = 50;

            panelInput_���.Width = this.Width / 2;

            for (int i = 0; i < 50;  i++)
            {
                dataGridViewIn_���.Columns[i].Width = 25;
                dataGridViewOut_���.Columns[i].Width = 25;
            }
        }
    }
}
