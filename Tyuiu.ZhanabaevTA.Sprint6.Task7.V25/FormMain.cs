using System.Drawing.Drawing2D;
using Tyuiu.ZhanabaevTA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_ЖТА.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ЖТА.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
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

        private void buttonOpenFile_ЖТА_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ЖТА.ShowDialog();
            openFilePath = openFileDialogTask_ЖТА.FileName;
            if (openFilePath == "")
            {
                MessageBox.Show("Файл не был выбран", "Ошибка");
            }
            else
            {
                MessageBox.Show($"Файл {openFilePath} открыт успешно", "Открытие");


                int[,] matrix = LoadFromFileData(openFilePath);
                dataGridViewIn_ЖТА.ColumnCount = matrix.GetLength(1);
                dataGridViewIn_ЖТА.RowCount = matrix.GetLength(0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        dataGridViewIn_ЖТА.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                buttonDone_ЖТА.Enabled = true;
            }
        }

        private void buttonDone_ЖТА_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            dataGridViewOut_ЖТА.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_ЖТА.RowCount = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOut_ЖТА.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            buttonSave_ЖТА.Enabled = true;
        }

        private void buttonSave_ЖТА_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ЖТА.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ЖТА.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ЖТА.ShowDialog();

            string path = saveFileDialogMatrix_ЖТА.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_ЖТА.RowCount;
            int columns = dataGridViewOut_ЖТА.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_ЖТА.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_ЖТА.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_ЖТА_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            dataGridViewIn_ЖТА.ColumnCount = 50;
            dataGridViewOut_ЖТА.ColumnCount = 50;

            dataGridViewIn_ЖТА.RowCount = 50;
            dataGridViewOut_ЖТА.RowCount = 50;

            panelInput_ЖТА.Width = this.Width / 2;

            for (int i = 0; i < 50;  i++)
            {
                dataGridViewIn_ЖТА.Columns[i].Width = 25;
                dataGridViewOut_ЖТА.Columns[i].Width = 25;
            }
        }
    }
}
