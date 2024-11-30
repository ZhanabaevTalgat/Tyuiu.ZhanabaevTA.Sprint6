namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_ЖТА = new GroupBox();
            pictureBoxTask_ЖТА = new PictureBox();
            groupBoxOutput_ЖТА = new GroupBox();
            chartFunction_ЖТА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult_ЖТА = new Label();
            dataGridViewFunction_ЖТА = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            groupBoxInput_ЖТА = new GroupBox();
            labelStop_ЖТА = new Label();
            textBoxStop_ЖТА = new TextBox();
            textBoxStart_ЖТА = new TextBox();
            labelStart_ЖТА = new Label();
            buttonRun_ЖТА = new Button();
            buttonInfo_ЖТА = new Button();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).BeginInit();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ЖТА).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ЖТА).BeginInit();
            groupBoxInput_ЖТА.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Controls.Add(pictureBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(12, 12);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(543, 393);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // pictureBoxTask_ЖТА
            // 
            pictureBoxTask_ЖТА.BackgroundImage = (Image)resources.GetObject("pictureBoxTask_ЖТА.BackgroundImage");
            pictureBoxTask_ЖТА.Image = (Image)resources.GetObject("pictureBoxTask_ЖТА.Image");
            pictureBoxTask_ЖТА.Location = new Point(6, 26);
            pictureBoxTask_ЖТА.Name = "pictureBoxTask_ЖТА";
            pictureBoxTask_ЖТА.Size = new Size(531, 238);
            pictureBoxTask_ЖТА.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_ЖТА.TabIndex = 0;
            pictureBoxTask_ЖТА.TabStop = false;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(chartFunction_ЖТА);
            groupBoxOutput_ЖТА.Controls.Add(labelResult_ЖТА);
            groupBoxOutput_ЖТА.Controls.Add(dataGridViewFunction_ЖТА);
            groupBoxOutput_ЖТА.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutput_ЖТА.Location = new Point(561, 12);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(731, 492);
            groupBoxOutput_ЖТА.TabIndex = 1;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // chartFunction_ЖТА
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ЖТА.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ЖТА.Legends.Add(legend1);
            chartFunction_ЖТА.Location = new Point(218, 60);
            chartFunction_ЖТА.Name = "chartFunction_ЖТА";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ЖТА.Series.Add(series1);
            chartFunction_ЖТА.Size = new Size(470, 412);
            chartFunction_ЖТА.TabIndex = 2;
            chartFunction_ЖТА.Text = "chart1";
            // 
            // labelResult_ЖТА
            // 
            labelResult_ЖТА.AutoSize = true;
            labelResult_ЖТА.Location = new Point(6, 26);
            labelResult_ЖТА.Name = "labelResult_ЖТА";
            labelResult_ЖТА.Size = new Size(99, 20);
            labelResult_ЖТА.TabIndex = 1;
            labelResult_ЖТА.Text = "Результат:";
            // 
            // dataGridViewFunction_ЖТА
            // 
            dataGridViewFunction_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_ЖТА.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridViewFunction_ЖТА.Location = new Point(6, 49);
            dataGridViewFunction_ЖТА.Name = "dataGridViewFunction_ЖТА";
            dataGridViewFunction_ЖТА.ReadOnly = true;
            dataGridViewFunction_ЖТА.RowHeadersVisible = false;
            dataGridViewFunction_ЖТА.RowHeadersWidth = 51;
            dataGridViewFunction_ЖТА.Size = new Size(180, 437);
            dataGridViewFunction_ЖТА.TabIndex = 0;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            ColumnX.Width = 90;
            // 
            // ColumnFx
            // 
            ColumnFx.HeaderText = "F(X)";
            ColumnFx.MinimumWidth = 6;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.ReadOnly = true;
            ColumnFx.Width = 90;
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Controls.Add(labelStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStart_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStart_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(12, 411);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(287, 93);
            groupBoxInput_ЖТА.TabIndex = 2;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // labelStop_ЖТА
            // 
            labelStop_ЖТА.AutoSize = true;
            labelStop_ЖТА.Location = new Point(147, 23);
            labelStop_ЖТА.Name = "labelStop_ЖТА";
            labelStop_ЖТА.Size = new Size(94, 20);
            labelStop_ЖТА.TabIndex = 1;
            labelStop_ЖТА.Text = "Конец шага:";
            // 
            // textBoxStop_ЖТА
            // 
            textBoxStop_ЖТА.Location = new Point(147, 46);
            textBoxStop_ЖТА.Name = "textBoxStop_ЖТА";
            textBoxStop_ЖТА.Size = new Size(134, 27);
            textBoxStop_ЖТА.TabIndex = 2;
            textBoxStop_ЖТА.Text = "5";
            // 
            // textBoxStart_ЖТА
            // 
            textBoxStart_ЖТА.Location = new Point(6, 46);
            textBoxStart_ЖТА.Name = "textBoxStart_ЖТА";
            textBoxStart_ЖТА.Size = new Size(135, 27);
            textBoxStart_ЖТА.TabIndex = 3;
            textBoxStart_ЖТА.Text = "-5";
            textBoxStart_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // labelStart_ЖТА
            // 
            labelStart_ЖТА.AutoSize = true;
            labelStart_ЖТА.Location = new Point(6, 23);
            labelStart_ЖТА.Name = "labelStart_ЖТА";
            labelStart_ЖТА.Size = new Size(88, 20);
            labelStart_ЖТА.TabIndex = 0;
            labelStart_ЖТА.Text = "Старт шага:";
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.BackColor = Color.Green;
            buttonRun_ЖТА.Location = new Point(405, 426);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(150, 78);
            buttonRun_ЖТА.TabIndex = 3;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = false;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            buttonRun_ЖТА.MouseDown += buttonRun_MouseDown;
            buttonRun_ЖТА.MouseEnter += buttonRun_MouseEnter;
            buttonRun_ЖТА.MouseLeave += buttonRun_MouseLeave;
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.BackColor = Color.Blue;
            buttonInfo_ЖТА.Location = new Point(305, 426);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(94, 78);
            buttonInfo_ЖТА.TabIndex = 4;
            buttonInfo_ЖТА.Text = "Справка";
            buttonInfo_ЖТА.UseVisualStyleBackColor = false;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 516);
            Controls.Add(buttonInfo_ЖТА);
            Controls.Add(buttonRun_ЖТА);
            Controls.Add(groupBoxInput_ЖТА);
            Controls.Add(groupBoxOutput_ЖТА);
            Controls.Add(groupBoxTask_ЖТА);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Жанабаев Т.А";
            groupBoxTask_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).EndInit();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ЖТА).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ЖТА).EndInit();
            groupBoxInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ЖТА;
        private PictureBox pictureBoxTask_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private GroupBox groupBoxInput_ЖТА;
        private Button buttonRun_ЖТА;
        private Button buttonInfo_ЖТА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ЖТА;
        private Label labelResult_ЖТА;
        private DataGridView dataGridViewFunction_ЖТА;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;
        private Label labelStop_ЖТА;
        private TextBox textBoxStop_ЖТА;
        private TextBox textBoxStart_ЖТА;
        private Label labelStart_ЖТА;
    }
}
