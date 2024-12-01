namespace Tyuiu.ZhanabaevTA.Sprint6.Task3.V17
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
            dataGridViewTask_ЖТА = new DataGridView();
            textBoxTask_ЖТА = new TextBox();
            groupBoxOutput_ЖТА = new GroupBox();
            dataGridViewResult_ЖТА = new DataGridView();
            labelResult_ЖТА = new Label();
            buttonInfo_ЖТА = new Button();
            buttonRun_ЖТА = new Button();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_ЖТА).BeginInit();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ЖТА).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Controls.Add(dataGridViewTask_ЖТА);
            groupBoxTask_ЖТА.Controls.Add(textBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(12, 0);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(475, 438);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // dataGridViewTask_ЖТА
            // 
            dataGridViewTask_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_ЖТА.ColumnHeadersVisible = false;
            dataGridViewTask_ЖТА.Location = new Point(225, 91);
            dataGridViewTask_ЖТА.Name = "dataGridViewTask_ЖТА";
            dataGridViewTask_ЖТА.ReadOnly = true;
            dataGridViewTask_ЖТА.RowHeadersVisible = false;
            dataGridViewTask_ЖТА.RowHeadersWidth = 51;
            dataGridViewTask_ЖТА.Size = new Size(225, 169);
            dataGridViewTask_ЖТА.TabIndex = 1;
            // 
            // textBoxTask_ЖТА
            // 
            textBoxTask_ЖТА.Location = new Point(6, 26);
            textBoxTask_ЖТА.Multiline = true;
            textBoxTask_ЖТА.Name = "textBoxTask_ЖТА";
            textBoxTask_ЖТА.Size = new Size(464, 262);
            textBoxTask_ЖТА.TabIndex = 0;
            textBoxTask_ЖТА.Text = resources.GetString("textBoxTask_ЖТА.Text");
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(dataGridViewResult_ЖТА);
            groupBoxOutput_ЖТА.Controls.Add(labelResult_ЖТА);
            groupBoxOutput_ЖТА.Location = new Point(493, 0);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(460, 377);
            groupBoxOutput_ЖТА.TabIndex = 1;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // dataGridViewResult_ЖТА
            // 
            dataGridViewResult_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ЖТА.ColumnHeadersVisible = false;
            dataGridViewResult_ЖТА.Location = new Point(6, 56);
            dataGridViewResult_ЖТА.Name = "dataGridViewResult_ЖТА";
            dataGridViewResult_ЖТА.ReadOnly = true;
            dataGridViewResult_ЖТА.RowHeadersVisible = false;
            dataGridViewResult_ЖТА.RowHeadersWidth = 51;
            dataGridViewResult_ЖТА.Size = new Size(228, 188);
            dataGridViewResult_ЖТА.TabIndex = 1;
            // 
            // labelResult_ЖТА
            // 
            labelResult_ЖТА.AutoSize = true;
            labelResult_ЖТА.Location = new Point(6, 23);
            labelResult_ЖТА.Name = "labelResult_ЖТА";
            labelResult_ЖТА.Size = new Size(78, 20);
            labelResult_ЖТА.TabIndex = 0;
            labelResult_ЖТА.Text = "Результат:";
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.Location = new Point(717, 383);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(65, 55);
            buttonInfo_ЖТА.TabIndex = 2;
            buttonInfo_ЖТА.Text = "?";
            buttonInfo_ЖТА.UseVisualStyleBackColor = true;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.Location = new Point(788, 383);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(165, 55);
            buttonRun_ЖТА.TabIndex = 3;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = true;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(buttonRun_ЖТА);
            Controls.Add(buttonInfo_ЖТА);
            Controls.Add(groupBoxOutput_ЖТА);
            Controls.Add(groupBoxTask_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Жанабаев Т.А";
            Load += FormMain_Load;
            groupBoxTask_ЖТА.ResumeLayout(false);
            groupBoxTask_ЖТА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_ЖТА).EndInit();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ЖТА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ЖТА;
        private DataGridView dataGridViewTask_ЖТА;
        private TextBox textBoxTask_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private DataGridView dataGridViewResult_ЖТА;
        private Label labelResult_ЖТА;
        private Button buttonInfo_ЖТА;
        private Button buttonRun_ЖТА;
    }
}
