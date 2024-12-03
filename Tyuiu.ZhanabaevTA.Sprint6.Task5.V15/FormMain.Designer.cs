namespace Tyuiu.ZhanabaevTA.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelDiag_ЖТА = new Panel();
            chartDiag_ЖТА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTask_ЖТА = new Panel();
            buttonOpen_ЖТА = new Button();
            buttonInfo_ЖТА = new Button();
            buttonRun_ЖТА = new Button();
            groupBoxTask_ЖТА = new GroupBox();
            textBoxTask_ЖТА = new TextBox();
            panelResult_ЖТА = new Panel();
            groupBoxOutput_ЖТА = new GroupBox();
            dataGridViewResult_ЖТА = new DataGridView();
            panelDiag_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_ЖТА).BeginInit();
            panelTask_ЖТА.SuspendLayout();
            groupBoxTask_ЖТА.SuspendLayout();
            panelResult_ЖТА.SuspendLayout();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ЖТА).BeginInit();
            SuspendLayout();
            // 
            // panelDiag_ЖТА
            // 
            panelDiag_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDiag_ЖТА.BackColor = Color.RosyBrown;
            panelDiag_ЖТА.Controls.Add(chartDiag_ЖТА);
            panelDiag_ЖТА.Controls.Add(splitter1);
            panelDiag_ЖТА.Location = new Point(319, 121);
            panelDiag_ЖТА.Name = "panelDiag_ЖТА";
            panelDiag_ЖТА.Size = new Size(635, 459);
            panelDiag_ЖТА.TabIndex = 0;
            // 
            // chartDiag_ЖТА
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_ЖТА.ChartAreas.Add(chartArea1);
            chartDiag_ЖТА.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_ЖТА.Legends.Add(legend1);
            chartDiag_ЖТА.Location = new Point(4, 0);
            chartDiag_ЖТА.Name = "chartDiag_ЖТА";
            chartDiag_ЖТА.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_ЖТА.Series.Add(series1);
            chartDiag_ЖТА.Size = new Size(631, 459);
            chartDiag_ЖТА.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.White;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 459);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelTask_ЖТА
            // 
            panelTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTask_ЖТА.BackColor = Color.White;
            panelTask_ЖТА.Controls.Add(buttonOpen_ЖТА);
            panelTask_ЖТА.Controls.Add(buttonInfo_ЖТА);
            panelTask_ЖТА.Controls.Add(buttonRun_ЖТА);
            panelTask_ЖТА.Controls.Add(groupBoxTask_ЖТА);
            panelTask_ЖТА.Location = new Point(1, 1);
            panelTask_ЖТА.Name = "panelTask_ЖТА";
            panelTask_ЖТА.Size = new Size(953, 123);
            panelTask_ЖТА.TabIndex = 0;
            // 
            // buttonOpen_ЖТА
            // 
            buttonOpen_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_ЖТА.BackColor = Color.RoyalBlue;
            buttonOpen_ЖТА.Location = new Point(722, 27);
            buttonOpen_ЖТА.Name = "buttonOpen_ЖТА";
            buttonOpen_ЖТА.Size = new Size(120, 81);
            buttonOpen_ЖТА.TabIndex = 2;
            buttonOpen_ЖТА.Text = "Открыть файл";
            buttonOpen_ЖТА.UseVisualStyleBackColor = false;
            buttonOpen_ЖТА.Click += buttonOpen_ЖТА_Click;
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_ЖТА.BackColor = SystemColors.MenuHighlight;
            buttonInfo_ЖТА.Location = new Point(848, 27);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(94, 81);
            buttonInfo_ЖТА.TabIndex = 2;
            buttonInfo_ЖТА.Text = "Справка";
            buttonInfo_ЖТА.UseVisualStyleBackColor = false;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRun_ЖТА.BackColor = Color.ForestGreen;
            buttonRun_ЖТА.Location = new Point(576, 27);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(140, 81);
            buttonRun_ЖТА.TabIndex = 2;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = false;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_ЖТА.Controls.Add(textBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(3, 3);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(561, 117);
            groupBoxTask_ЖТА.TabIndex = 1;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // textBoxTask_ЖТА
            // 
            textBoxTask_ЖТА.BorderStyle = BorderStyle.None;
            textBoxTask_ЖТА.Dock = DockStyle.Fill;
            textBoxTask_ЖТА.Enabled = false;
            textBoxTask_ЖТА.Location = new Point(3, 23);
            textBoxTask_ЖТА.Multiline = true;
            textBoxTask_ЖТА.Name = "textBoxTask_ЖТА";
            textBoxTask_ЖТА.ReadOnly = true;
            textBoxTask_ЖТА.Size = new Size(555, 91);
            textBoxTask_ЖТА.TabIndex = 0;
            textBoxTask_ЖТА.Text = resources.GetString("textBoxTask_ЖТА.Text");
            // 
            // panelResult_ЖТА
            // 
            panelResult_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelResult_ЖТА.BackColor = Color.White;
            panelResult_ЖТА.Controls.Add(groupBoxOutput_ЖТА);
            panelResult_ЖТА.Location = new Point(1, 121);
            panelResult_ЖТА.Name = "panelResult_ЖТА";
            panelResult_ЖТА.Size = new Size(318, 459);
            panelResult_ЖТА.TabIndex = 0;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_ЖТА.Controls.Add(dataGridViewResult_ЖТА);
            groupBoxOutput_ЖТА.Location = new Point(3, 3);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(312, 453);
            groupBoxOutput_ЖТА.TabIndex = 1;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных:";
            // 
            // dataGridViewResult_ЖТА
            // 
            dataGridViewResult_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ЖТА.ColumnHeadersVisible = false;
            dataGridViewResult_ЖТА.Dock = DockStyle.Fill;
            dataGridViewResult_ЖТА.Location = new Point(3, 23);
            dataGridViewResult_ЖТА.Name = "dataGridViewResult_ЖТА";
            dataGridViewResult_ЖТА.RowHeadersVisible = false;
            dataGridViewResult_ЖТА.RowHeadersWidth = 51;
            dataGridViewResult_ЖТА.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_ЖТА.Size = new Size(306, 427);
            dataGridViewResult_ЖТА.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 583);
            Controls.Add(panelResult_ЖТА);
            Controls.Add(panelTask_ЖТА);
            Controls.Add(panelDiag_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Жанабаев Т.А";
            panelDiag_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_ЖТА).EndInit();
            panelTask_ЖТА.ResumeLayout(false);
            groupBoxTask_ЖТА.ResumeLayout(false);
            groupBoxTask_ЖТА.PerformLayout();
            panelResult_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ЖТА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDiag_ЖТА;
        private Splitter splitter1;
        private Panel panelTask_ЖТА;
        private Panel panelResult_ЖТА;
        private Button buttonOpen_ЖТА;
        private Button buttonInfo_ЖТА;
        private Button buttonRun_ЖТА;
        private GroupBox groupBoxTask_ЖТА;
        private TextBox textBoxTask_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_ЖТА;
        private DataGridView dataGridViewResult_ЖТА;
    }
}
