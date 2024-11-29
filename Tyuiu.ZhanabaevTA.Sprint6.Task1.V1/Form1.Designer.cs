namespace Tyuiu.ZhanabaevTA.Sprint6.Task1.V1
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
            groupBoxTask_ЖТА = new GroupBox();
            pictureBoxTask_ЖТА = new PictureBox();
            groupBoxOutput_ЖТА = new GroupBox();
            labelResult_ЖТА = new Label();
            textBoxResult_ЖТА = new TextBox();
            groupBoxInput_ЖТА = new GroupBox();
            textBoxStop_ЖТА = new TextBox();
            textBoxStart_ЖТА = new TextBox();
            labelStop_ЖТА = new Label();
            labelStart_ЖТА = new Label();
            buttonInfo_ЖТА = new Button();
            buttonRun_ЖТА = new Button();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).BeginInit();
            groupBoxOutput_ЖТА.SuspendLayout();
            groupBoxInput_ЖТА.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Controls.Add(pictureBoxTask_ЖТА);
            groupBoxTask_ЖТА.Location = new Point(12, 0);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(499, 353);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // pictureBoxTask_ЖТА
            // 
            pictureBoxTask_ЖТА.Image = (Image)resources.GetObject("pictureBoxTask_ЖТА.Image");
            pictureBoxTask_ЖТА.Location = new Point(12, 26);
            pictureBoxTask_ЖТА.Name = "pictureBoxTask_ЖТА";
            pictureBoxTask_ЖТА.Size = new Size(481, 191);
            pictureBoxTask_ЖТА.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_ЖТА.TabIndex = 0;
            pictureBoxTask_ЖТА.TabStop = false;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(labelResult_ЖТА);
            groupBoxOutput_ЖТА.Controls.Add(textBoxResult_ЖТА);
            groupBoxOutput_ЖТА.Location = new Point(517, 0);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(271, 438);
            groupBoxOutput_ЖТА.TabIndex = 1;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // labelResult_ЖТА
            // 
            labelResult_ЖТА.AutoSize = true;
            labelResult_ЖТА.Location = new Point(6, 26);
            labelResult_ЖТА.Name = "labelResult_ЖТА";
            labelResult_ЖТА.Size = new Size(78, 20);
            labelResult_ЖТА.TabIndex = 1;
            labelResult_ЖТА.Text = "Результат:";
            // 
            // textBoxResult_ЖТА
            // 
            textBoxResult_ЖТА.AccessibleName = "";
            textBoxResult_ЖТА.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ЖТА.Location = new Point(0, 49);
            textBoxResult_ЖТА.Multiline = true;
            textBoxResult_ЖТА.Name = "textBoxResult_ЖТА";
            textBoxResult_ЖТА.ReadOnly = true;
            textBoxResult_ЖТА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ЖТА.Size = new Size(259, 383);
            textBoxResult_ЖТА.TabIndex = 0;
            textBoxResult_ЖТА.TextChanged += textBoxResult_ЖТА_TextChanged;
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Controls.Add(textBoxStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxStart_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStop_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(labelStart_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(12, 359);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(275, 79);
            groupBoxInput_ЖТА.TabIndex = 2;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // textBoxStop_ЖТА
            // 
            textBoxStop_ЖТА.Location = new Point(137, 48);
            textBoxStop_ЖТА.Name = "textBoxStop_ЖТА";
            textBoxStop_ЖТА.Size = new Size(125, 27);
            textBoxStop_ЖТА.TabIndex = 1;
            textBoxStop_ЖТА.TextChanged += textBoxStop_ЖТА_TextChanged;
            textBoxStop_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // textBoxStart_ЖТА
            // 
            textBoxStart_ЖТА.Location = new Point(6, 46);
            textBoxStart_ЖТА.Name = "textBoxStart_ЖТА";
            textBoxStart_ЖТА.Size = new Size(125, 27);
            textBoxStart_ЖТА.TabIndex = 1;
            textBoxStart_ЖТА.TextChanged += textBoxStart_ЖТА_TextChanged;
            textBoxStart_ЖТА.KeyPress += textBoxStart_ЖТА_TextChanged;
            // 
            // labelStop_ЖТА
            // 
            labelStop_ЖТА.AutoSize = true;
            labelStop_ЖТА.Location = new Point(137, 23);
            labelStop_ЖТА.Name = "labelStop_ЖТА";
            labelStop_ЖТА.Size = new Size(94, 20);
            labelStop_ЖТА.TabIndex = 1;
            labelStop_ЖТА.Text = "Конец шага:";
            // 
            // labelStart_ЖТА
            // 
            labelStart_ЖТА.AutoSize = true;
            labelStart_ЖТА.Location = new Point(6, 23);
            labelStart_ЖТА.Name = "labelStart_ЖТА";
            labelStart_ЖТА.Size = new Size(88, 20);
            labelStart_ЖТА.TabIndex = 1;
            labelStart_ЖТА.Text = "Старт шага:";
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.BackColor = Color.DodgerBlue;
            buttonInfo_ЖТА.Location = new Point(293, 376);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(85, 58);
            buttonInfo_ЖТА.TabIndex = 3;
            buttonInfo_ЖТА.Text = "Справка";
            buttonInfo_ЖТА.UseVisualStyleBackColor = false;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click_1;
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.BackColor = Color.LimeGreen;
            buttonRun_ЖТА.Location = new Point(384, 376);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(127, 58);
            buttonRun_ЖТА.TabIndex = 4;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = false;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRun_ЖТА);
            Controls.Add(buttonInfo_ЖТА);
            Controls.Add(groupBoxInput_ЖТА);
            Controls.Add(groupBoxOutput_ЖТА);
            Controls.Add(groupBoxTask_ЖТА);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 1 | Жанабаев Т.А";
            groupBoxTask_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ЖТА).EndInit();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            groupBoxInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private GroupBox groupBoxInput_ЖТА;
        private Button buttonInfo_ЖТА;
        private Button buttonRun_ЖТА;
        private PictureBox pictureBoxTask_ЖТА;
        private TextBox textBoxResult_ЖТА;
        private Label labelResult_ЖТА;
        private TextBox textBoxStop_ЖТА;
        private TextBox textBoxStart_ЖТА;
        private Label labelStop_ЖТА;
        private Label labelStart_ЖТА;
    }
}
