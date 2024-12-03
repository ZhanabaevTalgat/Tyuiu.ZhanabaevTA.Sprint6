namespace Tyuiu.ZhanabaevTA.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_ЖТА = new GroupBox();
            pictureBoxTask_ЖТА = new PictureBox();
            groupBoxInput_ЖТА = new GroupBox();
            textBoxStop_ЖТА = new TextBox();
            labelStop_ЖТА = new Label();
            textBoxStart_ЖТА = new TextBox();
            labelStart_ЖТА = new Label();
            groupBoxOutput_ЖТА = new GroupBox();
            textBoxResult_ЖТА = new TextBox();
            chartFunction_ЖТА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonRun_ЖТА = new Button();
            buttonSave_ЖТА = new Button();
            buttonInfo_ЖТА = new Button();
            panelResult_ЖТА = new Panel();
            panelChart_ЖТА = new Panel();
            splitter1 = new Splitter();
            panelTask_ЖТА = new Panel();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).BeginInit();
            groupBoxInput_ЖТА.SuspendLayout();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ЖТА).BeginInit();
            panelResult_ЖТА.SuspendLayout();
            panelChart_ЖТА.SuspendLayout();
            panelTask_ЖТА.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_ЖТА.Controls.Add(pictureBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(3, 3);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(453, 181);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // pictureBoxTask_ЖТА
            // 
            pictureBoxTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxTask_ЖТА.Image = (Image)resources.GetObject("pictureBoxTask_ЖТА.Image");
            pictureBoxTask_ЖТА.Location = new Point(12, 26);
            pictureBoxTask_ЖТА.Name = "pictureBoxTask_ЖТА";
            pictureBoxTask_ЖТА.Size = new Size(435, 140);
            pictureBoxTask_ЖТА.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_ЖТА.TabIndex = 0;
            pictureBoxTask_ЖТА.TabStop = false;
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxInput_ЖТА.Controls.Add(textBoxStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStart_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStart_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(462, 3);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(259, 181);
            groupBoxInput_ЖТА.TabIndex = 1;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // textBoxStop_ЖТА
            // 
            textBoxStop_ЖТА.Location = new Point(6, 128);
            textBoxStop_ЖТА.Name = "textBoxStop_ЖТА";
            textBoxStop_ЖТА.Size = new Size(247, 27);
            textBoxStop_ЖТА.TabIndex = 3;
            textBoxStop_ЖТА.Text = "5";
            textBoxStop_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // labelStop_ЖТА
            // 
            labelStop_ЖТА.AutoSize = true;
            labelStop_ЖТА.Location = new Point(6, 105);
            labelStop_ЖТА.Name = "labelStop_ЖТА";
            labelStop_ЖТА.Size = new Size(94, 20);
            labelStop_ЖТА.TabIndex = 2;
            labelStop_ЖТА.Text = "Конец шага:";
            // 
            // textBoxStart_ЖТА
            // 
            textBoxStart_ЖТА.Location = new Point(6, 49);
            textBoxStart_ЖТА.Name = "textBoxStart_ЖТА";
            textBoxStart_ЖТА.Size = new Size(247, 27);
            textBoxStart_ЖТА.TabIndex = 1;
            textBoxStart_ЖТА.Text = "-5";
            textBoxStart_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // labelStart_ЖТА
            // 
            labelStart_ЖТА.AutoSize = true;
            labelStart_ЖТА.Location = new Point(6, 26);
            labelStart_ЖТА.Name = "labelStart_ЖТА";
            labelStart_ЖТА.Size = new Size(88, 20);
            labelStart_ЖТА.TabIndex = 0;
            labelStart_ЖТА.Text = "Старт шага:";
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_ЖТА.Controls.Add(textBoxResult_ЖТА);
            groupBoxOutput_ЖТА.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutput_ЖТА.Location = new Point(3, 7);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Padding = new Padding(5);
            groupBoxOutput_ЖТА.Size = new Size(297, 462);
            groupBoxOutput_ЖТА.TabIndex = 2;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод:";
            // 
            // textBoxResult_ЖТА
            // 
            textBoxResult_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_ЖТА.Location = new Point(6, 26);
            textBoxResult_ЖТА.Multiline = true;
            textBoxResult_ЖТА.Name = "textBoxResult_ЖТА";
            textBoxResult_ЖТА.ReadOnly = true;
            textBoxResult_ЖТА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ЖТА.Size = new Size(283, 430);
            textBoxResult_ЖТА.TabIndex = 7;
            // 
            // chartFunction_ЖТА
            // 
            chartFunction_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_ЖТА.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ЖТА.Legends.Add(legend1);
            chartFunction_ЖТА.Location = new Point(10, 8);
            chartFunction_ЖТА.Name = "chartFunction_ЖТА";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ЖТА.Series.Add(series1);
            chartFunction_ЖТА.Size = new Size(695, 455);
            chartFunction_ЖТА.TabIndex = 6;
            title1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_ЖТА.Titles.Add(title1);
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRun_ЖТА.BackColor = Color.ForestGreen;
            buttonRun_ЖТА.Location = new Point(727, 10);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(126, 72);
            buttonRun_ЖТА.TabIndex = 3;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = false;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            // 
            // buttonSave_ЖТА
            // 
            buttonSave_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave_ЖТА.BackColor = SystemColors.HotTrack;
            buttonSave_ЖТА.Location = new Point(727, 106);
            buttonSave_ЖТА.Name = "buttonSave_ЖТА";
            buttonSave_ЖТА.Size = new Size(126, 76);
            buttonSave_ЖТА.TabIndex = 4;
            buttonSave_ЖТА.Text = "Сохранить";
            buttonSave_ЖТА.UseVisualStyleBackColor = false;
            buttonSave_ЖТА.Click += buttonSave_ЖТА_Click;
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo_ЖТА.BackColor = SystemColors.MenuHighlight;
            buttonInfo_ЖТА.Location = new Point(871, 29);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(124, 140);
            buttonInfo_ЖТА.TabIndex = 5;
            buttonInfo_ЖТА.Text = "Справка";
            buttonInfo_ЖТА.UseVisualStyleBackColor = false;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // panelResult_ЖТА
            // 
            panelResult_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelResult_ЖТА.BackColor = Color.White;
            panelResult_ЖТА.Controls.Add(groupBoxOutput_ЖТА);
            panelResult_ЖТА.Location = new Point(0, 187);
            panelResult_ЖТА.Name = "panelResult_ЖТА";
            panelResult_ЖТА.Size = new Size(303, 472);
            panelResult_ЖТА.TabIndex = 8;
            // 
            // panelChart_ЖТА
            // 
            panelChart_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChart_ЖТА.BackColor = Color.White;
            panelChart_ЖТА.Controls.Add(splitter1);
            panelChart_ЖТА.Controls.Add(chartFunction_ЖТА);
            panelChart_ЖТА.Location = new Point(303, 187);
            panelChart_ЖТА.Name = "panelChart_ЖТА";
            panelChart_ЖТА.Size = new Size(719, 472);
            panelChart_ЖТА.TabIndex = 9;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 472);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // panelTask_ЖТА
            // 
            panelTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTask_ЖТА.BackColor = Color.White;
            panelTask_ЖТА.Controls.Add(groupBoxInput_ЖТА);
            panelTask_ЖТА.Controls.Add(groupBoxTask_ЖТА);
            panelTask_ЖТА.Controls.Add(buttonSave_ЖТА);
            panelTask_ЖТА.Controls.Add(buttonInfo_ЖТА);
            panelTask_ЖТА.Controls.Add(buttonRun_ЖТА);
            panelTask_ЖТА.Location = new Point(3, 2);
            panelTask_ЖТА.Name = "panelTask_ЖТА";
            panelTask_ЖТА.Size = new Size(1016, 187);
            panelTask_ЖТА.TabIndex = 10;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 661);
            Controls.Add(panelTask_ЖТА);
            Controls.Add(panelChart_ЖТА);
            Controls.Add(panelResult_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Жанабаев Т.А";
            groupBoxTask_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).EndInit();
            groupBoxInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.PerformLayout();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ЖТА).EndInit();
            panelResult_ЖТА.ResumeLayout(false);
            panelChart_ЖТА.ResumeLayout(false);
            panelTask_ЖТА.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ЖТА;
        private PictureBox pictureBoxTask_ЖТА;
        private GroupBox groupBoxInput_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ЖТА;
        private Button buttonRun_ЖТА;
        private Button buttonSave_ЖТА;
        private Button buttonInfo_ЖТА;
        private TextBox textBoxResult_ЖТА;
        private TextBox textBoxStop_ЖТА;
        private Label labelStop_ЖТА;
        private TextBox textBoxStart_ЖТА;
        private Label labelStart_ЖТА;
        private Panel panelResult_ЖТА;
        private Panel panelChart_ЖТА;
        private Splitter splitter1;
        private Panel panelTask_ЖТА;
    }
}
