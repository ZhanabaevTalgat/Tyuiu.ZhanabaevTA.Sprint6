namespace Tyuiu.ZhanabaevTA.Sprint6.Task0.V10
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
            groupBoxInput_ЖТА = new GroupBox();
            labelVarX_ЖТА = new Label();
            textBoxVarX_ЖТА = new TextBox();
            groupBoxOutput_ЖТА = new GroupBox();
            labelResult_ЖТА = new Label();
            textBoxResult_ЖТА = new TextBox();
            buttonRun_ЖТА = new Button();
            buttonInfo_ЖТА = new Button();
            groupBoxTask_ЖТА = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxInput_ЖТА.SuspendLayout();
            groupBoxOutput_ЖТА.SuspendLayout();
            groupBoxTask_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Controls.Add(labelVarX_ЖТА);
            groupBoxInput_ЖТА.Controls.Add(textBoxVarX_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(12, 286);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(484, 97);
            groupBoxInput_ЖТА.TabIndex = 1;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // labelVarX_ЖТА
            // 
            labelVarX_ЖТА.AutoSize = true;
            labelVarX_ЖТА.Location = new Point(6, 41);
            labelVarX_ЖТА.Name = "labelVarX_ЖТА";
            labelVarX_ЖТА.Size = new Size(111, 20);
            labelVarX_ЖТА.TabIndex = 1;
            labelVarX_ЖТА.Text = "Переменная X";
            // 
            // textBoxVarX_ЖТА
            // 
            textBoxVarX_ЖТА.AccessibleDescription = "";
            textBoxVarX_ЖТА.AccessibleName = "";
            textBoxVarX_ЖТА.Location = new Point(6, 64);
            textBoxVarX_ЖТА.Name = "textBoxVarX_ЖТА";
            textBoxVarX_ЖТА.Size = new Size(125, 27);
            textBoxVarX_ЖТА.TabIndex = 0;
            textBoxVarX_ЖТА.Text = "2";
            textBoxVarX_ЖТА.TextChanged += textBoxVarX_ЖТА_TextChanged;
            textBoxVarX_ЖТА.KeyPress += textBoxVarA_ЖТА_KeyPress;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(labelResult_ЖТА);
            groupBoxOutput_ЖТА.Controls.Add(textBoxResult_ЖТА);
            groupBoxOutput_ЖТА.Location = new Point(502, 286);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(271, 97);
            groupBoxOutput_ЖТА.TabIndex = 2;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // labelResult_ЖТА
            // 
            labelResult_ЖТА.AutoSize = true;
            labelResult_ЖТА.Location = new Point(6, 41);
            labelResult_ЖТА.Name = "labelResult_ЖТА";
            labelResult_ЖТА.Size = new Size(75, 20);
            labelResult_ЖТА.TabIndex = 1;
            labelResult_ЖТА.Text = "Результат";
            // 
            // textBoxResult_ЖТА
            // 
            textBoxResult_ЖТА.Location = new Point(6, 64);
            textBoxResult_ЖТА.Name = "textBoxResult_ЖТА";
            textBoxResult_ЖТА.ReadOnly = true;
            textBoxResult_ЖТА.Size = new Size(125, 27);
            textBoxResult_ЖТА.TabIndex = 0;
            // 
            // buttonRun_ЖТА
            // 
            buttonRun_ЖТА.Location = new Point(571, 389);
            buttonRun_ЖТА.Name = "buttonRun_ЖТА";
            buttonRun_ЖТА.Size = new Size(202, 49);
            buttonRun_ЖТА.TabIndex = 3;
            buttonRun_ЖТА.Text = "Выполнить";
            buttonRun_ЖТА.UseVisualStyleBackColor = true;
            buttonRun_ЖТА.Click += buttonRun_ЖТА_Click;
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.Location = new Point(502, 389);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(63, 49);
            buttonInfo_ЖТА.TabIndex = 4;
            buttonInfo_ЖТА.Text = "?";
            buttonInfo_ЖТА.UseVisualStyleBackColor = true;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.Controls.Add(pictureBox1);
            groupBoxTask_ЖТА.Location = new Point(12, 12);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(761, 268);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            groupBoxTask_ЖТА.Enter += groupBoxTask_ЖТА_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(buttonInfo_ЖТА);
            Controls.Add(buttonRun_ЖТА);
            Controls.Add(groupBoxOutput_ЖТА);
            Controls.Add(groupBoxInput_ЖТА);
            Controls.Add(groupBoxTask_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 10 | Жанабаев Т.А";
            groupBoxInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.PerformLayout();
            groupBoxOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.PerformLayout();
            groupBoxTask_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxInput_ЖТА;
        private TextBox textBoxVarX_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private TextBox textBoxResult_ЖТА;
        private Button buttonRun_ЖТА;
        private Button buttonInfo_ЖТА;
        private GroupBox groupBoxTask_ЖТА;
        private Label labelVarX_ЖТА;
        private Label labelResult_ЖТА;
        private PictureBox pictureBox1;
    }
}
