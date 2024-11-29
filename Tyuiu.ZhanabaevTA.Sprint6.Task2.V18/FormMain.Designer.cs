namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_ЖТА = new GroupBox();
            pictureBoxTask_ЖТА = new PictureBox();
            groupBoxInput_ЖТА = new GroupBox();
            labelStart_ЖТА = new Label();
            labelStop_ЖТА = new Label();
            textBoxStop_ЖТА = new TextBox();
            textBoxStart_ЖТА = new TextBox();
            groupBoxOutput_ЖТА = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            labelResult_ЖТА = new Label();
            buttonInfo_ЖТА = new Button();
            buttonRun_ЖТА = new Button();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).BeginInit();
            groupBoxInput_ЖТА.SuspendLayout();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Controls.Add(pictureBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(12, 12);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(540, 336);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // pictureBoxTask_ЖТА
            // 
            pictureBoxTask_ЖТА.Image = (Image)resources.GetObject("pictureBoxTask_ЖТА.Image");
            pictureBoxTask_ЖТА.Location = new Point(6, 26);
            pictureBoxTask_ЖТА.Name = "pictureBoxTask_ЖТА";
            pictureBoxTask_ЖТА.Size = new Size(528, 162);
            pictureBoxTask_ЖТА.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_ЖТА.TabIndex = 0;
            pictureBoxTask_ЖТА.TabStop = false;
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Controls.Add(labelStart_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStart_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(12, 354);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(304, 84);
            groupBoxInput_ЖТА.TabIndex = 1;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // labelStart_ЖТА
            // 
            labelStart_ЖТА.AutoSize = true;
            labelStart_ЖТА.Location = new Point(6, 28);
            labelStart_ЖТА.Name = "labelStart_ЖТА";
            labelStart_ЖТА.Size = new Size(88, 20);
            labelStart_ЖТА.TabIndex = 0;
            labelStart_ЖТА.Text = "Старт шага:";
            // 
            // labelStop_ЖТА
            // 
            labelStop_ЖТА.AutoSize = true;
            labelStop_ЖТА.Location = new Point(159, 28);
            labelStop_ЖТА.Name = "labelStop_ЖТА";
            labelStop_ЖТА.Size = new Size(94, 20);
            labelStop_ЖТА.TabIndex = 1;
            labelStop_ЖТА.Text = "Конец шага:";
            // 
            // textBoxStop_ЖТА
            // 
            textBoxStop_ЖТА.Location = new Point(159, 51);
            textBoxStop_ЖТА.Name = "textBoxStop_ЖТА";
            textBoxStop_ЖТА.Size = new Size(139, 27);
            textBoxStop_ЖТА.TabIndex = 0;
            textBoxStop_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // textBoxStart_ЖТА
            // 
            textBoxStart_ЖТА.Location = new Point(6, 51);
            textBoxStart_ЖТА.Name = "textBoxStart_ЖТА";
            textBoxStart_ЖТА.Size = new Size(147, 27);
            textBoxStart_ЖТА.TabIndex = 1;
            textBoxStart_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(dataGridView1);
            groupBoxOutput_ЖТА.Controls.Add(labelResult_ЖТА);
            groupBoxOutput_ЖТА.Location = new Point(558, 12);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(604, 426);
            groupBoxOutput_ЖТА.TabIndex = 2;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridView1.Location = new Point(6, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(180, 374);
            dataGridView1.TabIndex = 1;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "x";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            ColumnX.Width = 90;
            // 
            // ColumnFx
            // 
            ColumnFx.HeaderText = "F(x)";
            ColumnFx.MinimumWidth = 6;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.ReadOnly = true;
            ColumnFx.Width = 90;
            // 
            // labelResult_ЖТА
            // 
            labelResult_ЖТА.AutoSize = true;
            labelResult_ЖТА.Location = new Point(3, 23);
            labelResult_ЖТА.Name = "labelResult_ЖТА";
            labelResult_ЖТА.Size = new Size(78, 20);
            labelResult_ЖТА.TabIndex = 0;
            labelResult_ЖТА.Text = "Результат:";
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.BackColor = Color.DodgerBlue;
            buttonInfo_ЖТА.Location = new Point(322, 363);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(81, 75);
            buttonInfo_ЖТА.TabIndex = 3;
            buttonInfo_ЖТА.Text = "Справка";
            buttonInfo_ЖТА.UseVisualStyleBackColor = false;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.BackColor = Color.Green;
            buttonRun_ЖТА.Location = new Point(409, 363);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(143, 75);
            buttonRun_ЖТА.TabIndex = 4;
            buttonRun_ЖТА.Text = "Запустить";
            buttonRun_ЖТА.UseVisualStyleBackColor = false;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            buttonRun_ЖТА.MouseDown += buttonRun_MouseDown;
            buttonRun_ЖТА.MouseEnter += buttonRun_MouseEnter;
            buttonRun_ЖТА.MouseLeave += buttonRun_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(buttonRun_ЖТА);
            Controls.Add(buttonInfo_ЖТА);
            Controls.Add(groupBoxOutput_ЖТА);
            Controls.Add(groupBoxInput_ЖТА);
            Controls.Add(groupBoxTask_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 2 | Жанабаев Т.А";
            groupBoxTask_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).EndInit();
            groupBoxInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.PerformLayout();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ЖТА;
        private PictureBox pictureBoxTask_ЖТА;
        private GroupBox groupBoxInput_ЖТА;
        private Label labelStart_ЖТА;
        private Label labelStop_ЖТА;
        private TextBox textBoxStop_ЖТА;
        private TextBox textBoxStart_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private Button buttonInfo_ЖТА;
        private Button buttonRun_ЖТА;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;
        private Label labelResult_ЖТА;
    }
}
