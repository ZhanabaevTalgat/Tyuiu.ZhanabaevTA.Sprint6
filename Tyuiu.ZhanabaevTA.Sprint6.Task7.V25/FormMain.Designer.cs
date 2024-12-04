namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ЖТА = new Panel();
            buttonInfo_ЖТА = new Button();
            buttonSave_ЖТА = new Button();
            buttonDone_ЖТА = new Button();
            buttonOpenFile_ЖТА = new Button();
            panelTask_ЖТА = new Panel();
            groupBoxTask_ЖТА = new GroupBox();
            textBoxTask_ЖТА = new TextBox();
            panelInput_ЖТА = new Panel();
            groupBoxInput_ЖТА = new GroupBox();
            dataGridViewIn_ЖТА = new DataGridView();
            panelOutput_ЖТА = new Panel();
            splitter1 = new Splitter();
            groupBoxOutput_ЖТА = new GroupBox();
            dataGridViewOut_ЖТА = new DataGridView();
            openFileDialogTask_ЖТА = new OpenFileDialog();
            saveFileDialogMatrix_ЖТА = new SaveFileDialog();
            toolTip = new ToolTip(components);
            panelButtons_ЖТА.SuspendLayout();
            panelTask_ЖТА.SuspendLayout();
            groupBoxTask_ЖТА.SuspendLayout();
            panelInput_ЖТА.SuspendLayout();
            groupBoxInput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ЖТА).BeginInit();
            panelOutput_ЖТА.SuspendLayout();
            groupBoxOutput_ЖТА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ЖТА).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_ЖТА
            // 
            panelButtons_ЖТА.BackColor = Color.White;
            panelButtons_ЖТА.Controls.Add(buttonInfo_ЖТА);
            panelButtons_ЖТА.Controls.Add(buttonSave_ЖТА);
            panelButtons_ЖТА.Controls.Add(buttonDone_ЖТА);
            panelButtons_ЖТА.Controls.Add(buttonOpenFile_ЖТА);
            panelButtons_ЖТА.Dock = DockStyle.Top;
            panelButtons_ЖТА.Location = new Point(0, 0);
            panelButtons_ЖТА.Name = "panelButtons_ЖТА";
            panelButtons_ЖТА.Size = new Size(800, 86);
            panelButtons_ЖТА.TabIndex = 0;
            // 
            // buttonInfo_ЖТА
            // 
            buttonInfo_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_ЖТА.Image = (Image)resources.GetObject("buttonInfo_ЖТА.Image");
            buttonInfo_ЖТА.Location = new Point(710, 9);
            buttonInfo_ЖТА.Name = "buttonInfo_ЖТА";
            buttonInfo_ЖТА.Size = new Size(76, 70);
            buttonInfo_ЖТА.TabIndex = 0;
            toolTip.SetToolTip(buttonInfo_ЖТА, "О программе");
            buttonInfo_ЖТА.UseVisualStyleBackColor = true;
            buttonInfo_ЖТА.Click += buttonInfo_ЖТА_Click;
            // 
            // buttonSave_ЖТА
            // 
            buttonSave_ЖТА.Image = (Image)resources.GetObject("buttonSave_ЖТА.Image");
            buttonSave_ЖТА.Location = new Point(182, 12);
            buttonSave_ЖТА.Name = "buttonSave_ЖТА";
            buttonSave_ЖТА.Size = new Size(71, 67);
            buttonSave_ЖТА.TabIndex = 0;
            toolTip.SetToolTip(buttonSave_ЖТА, "Сохранить");
            buttonSave_ЖТА.UseVisualStyleBackColor = true;
            buttonSave_ЖТА.Click += buttonSave_ЖТА_Click;
            // 
            // buttonDone_ЖТА
            // 
            buttonDone_ЖТА.Image = (Image)resources.GetObject("buttonDone_ЖТА.Image");
            buttonDone_ЖТА.Location = new Point(98, 12);
            buttonDone_ЖТА.Name = "buttonDone_ЖТА";
            buttonDone_ЖТА.Size = new Size(78, 68);
            buttonDone_ЖТА.TabIndex = 0;
            toolTip.SetToolTip(buttonDone_ЖТА, "Выполнить");
            buttonDone_ЖТА.UseVisualStyleBackColor = true;
            buttonDone_ЖТА.Click += buttonDone_ЖТА_Click;
            // 
            // buttonOpenFile_ЖТА
            // 
            buttonOpenFile_ЖТА.Image = (Image)resources.GetObject("buttonOpenFile_ЖТА.Image");
            buttonOpenFile_ЖТА.Location = new Point(12, 12);
            buttonOpenFile_ЖТА.Name = "buttonOpenFile_ЖТА";
            buttonOpenFile_ЖТА.Size = new Size(80, 68);
            buttonOpenFile_ЖТА.TabIndex = 0;
            toolTip.SetToolTip(buttonOpenFile_ЖТА, "Открыть файл");
            buttonOpenFile_ЖТА.UseVisualStyleBackColor = true;
            buttonOpenFile_ЖТА.Click += buttonOpenFile_ЖТА_Click;
            // 
            // panelTask_ЖТА
            // 
            panelTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTask_ЖТА.BackColor = Color.White;
            panelTask_ЖТА.Controls.Add(groupBoxTask_ЖТА);
            panelTask_ЖТА.Location = new Point(0, 82);
            panelTask_ЖТА.Name = "panelTask_ЖТА";
            panelTask_ЖТА.Size = new Size(800, 103);
            panelTask_ЖТА.TabIndex = 1;
            // 
            // groupBoxTask_ЖТА
            // 
            groupBoxTask_ЖТА.BackColor = Color.White;
            groupBoxTask_ЖТА.Controls.Add(textBoxTask_ЖТА);
            groupBoxTask_ЖТА.Dock = DockStyle.Fill;
            groupBoxTask_ЖТА.Location = new Point(0, 0);
            groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
            groupBoxTask_ЖТА.Size = new Size(800, 103);
            groupBoxTask_ЖТА.TabIndex = 0;
            groupBoxTask_ЖТА.TabStop = false;
            groupBoxTask_ЖТА.Text = "Условие";
            // 
            // textBoxTask_ЖТА
            // 
            textBoxTask_ЖТА.BackColor = Color.White;
            textBoxTask_ЖТА.BorderStyle = BorderStyle.None;
            textBoxTask_ЖТА.Dock = DockStyle.Fill;
            textBoxTask_ЖТА.Enabled = false;
            textBoxTask_ЖТА.Location = new Point(3, 23);
            textBoxTask_ЖТА.Multiline = true;
            textBoxTask_ЖТА.Name = "textBoxTask_ЖТА";
            textBoxTask_ЖТА.ReadOnly = true;
            textBoxTask_ЖТА.Size = new Size(794, 77);
            textBoxTask_ЖТА.TabIndex = 0;
            textBoxTask_ЖТА.Text = resources.GetString("textBoxTask_ЖТА.Text");
            // 
            // panelInput_ЖТА
            // 
            panelInput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelInput_ЖТА.BackColor = Color.White;
            panelInput_ЖТА.Controls.Add(groupBoxInput_ЖТА);
            panelInput_ЖТА.Location = new Point(0, 183);
            panelInput_ЖТА.Name = "panelInput_ЖТА";
            panelInput_ЖТА.Size = new Size(400, 267);
            panelInput_ЖТА.TabIndex = 2;
            // 
            // groupBoxInput_ЖТА
            // 
            groupBoxInput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_ЖТА.Controls.Add(dataGridViewIn_ЖТА);
            groupBoxInput_ЖТА.Location = new Point(0, 0);
            groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
            groupBoxInput_ЖТА.Size = new Size(404, 267);
            groupBoxInput_ЖТА.TabIndex = 0;
            groupBoxInput_ЖТА.TabStop = false;
            groupBoxInput_ЖТА.Text = "Ввод данных";
            // 
            // dataGridViewIn_ЖТА
            // 
            dataGridViewIn_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIn_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_ЖТА.ColumnHeadersVisible = false;
            dataGridViewIn_ЖТА.Location = new Point(12, 28);
            dataGridViewIn_ЖТА.Name = "dataGridViewIn_ЖТА";
            dataGridViewIn_ЖТА.ReadOnly = true;
            dataGridViewIn_ЖТА.RowHeadersVisible = false;
            dataGridViewIn_ЖТА.RowHeadersWidth = 51;
            dataGridViewIn_ЖТА.Size = new Size(382, 225);
            dataGridViewIn_ЖТА.TabIndex = 0;
            // 
            // panelOutput_ЖТА
            // 
            panelOutput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOutput_ЖТА.BackColor = Color.White;
            panelOutput_ЖТА.Controls.Add(splitter1);
            panelOutput_ЖТА.Controls.Add(groupBoxOutput_ЖТА);
            panelOutput_ЖТА.Location = new Point(400, 183);
            panelOutput_ЖТА.Name = "panelOutput_ЖТА";
            panelOutput_ЖТА.Size = new Size(400, 267);
            panelOutput_ЖТА.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 267);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // groupBoxOutput_ЖТА
            // 
            groupBoxOutput_ЖТА.Controls.Add(dataGridViewOut_ЖТА);
            groupBoxOutput_ЖТА.Dock = DockStyle.Fill;
            groupBoxOutput_ЖТА.Location = new Point(0, 0);
            groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
            groupBoxOutput_ЖТА.Size = new Size(400, 267);
            groupBoxOutput_ЖТА.TabIndex = 1;
            groupBoxOutput_ЖТА.TabStop = false;
            groupBoxOutput_ЖТА.Text = "Вывод данных";
            // 
            // dataGridViewOut_ЖТА
            // 
            dataGridViewOut_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOut_ЖТА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_ЖТА.ColumnHeadersVisible = false;
            dataGridViewOut_ЖТА.Location = new Point(18, 28);
            dataGridViewOut_ЖТА.Margin = new Padding(5);
            dataGridViewOut_ЖТА.Name = "dataGridViewOut_ЖТА";
            dataGridViewOut_ЖТА.ReadOnly = true;
            dataGridViewOut_ЖТА.RowHeadersVisible = false;
            dataGridViewOut_ЖТА.RowHeadersWidth = 51;
            dataGridViewOut_ЖТА.Size = new Size(368, 225);
            dataGridViewOut_ЖТА.TabIndex = 0;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelOutput_ЖТА);
            Controls.Add(panelInput_ЖТА);
            Controls.Add(panelTask_ЖТА);
            Controls.Add(panelButtons_ЖТА);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Жанабаев Т.А";
            Load += FormMainLoad;
            panelButtons_ЖТА.ResumeLayout(false);
            panelTask_ЖТА.ResumeLayout(false);
            groupBoxTask_ЖТА.ResumeLayout(false);
            groupBoxTask_ЖТА.PerformLayout();
            panelInput_ЖТА.ResumeLayout(false);
            groupBoxInput_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ЖТА).EndInit();
            panelOutput_ЖТА.ResumeLayout(false);
            groupBoxOutput_ЖТА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ЖТА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_ЖТА;
        private Panel panelTask_ЖТА;
        private Panel panelInput_ЖТА;
        private Panel panelOutput_ЖТА;
        private GroupBox groupBoxTask_ЖТА;
        private TextBox textBoxTask_ЖТА;
        private GroupBox groupBoxInput_ЖТА;
        private GroupBox groupBoxOutput_ЖТА;
        private DataGridView dataGridViewIn_ЖТА;
        private DataGridView dataGridViewOut_ЖТА;
        private Button buttonInfo_ЖТА;
        private Button buttonSave_ЖТА;
        private Button buttonDone_ЖТА;
        private Button buttonOpenFile_ЖТА;
        private Splitter splitter1;
        private OpenFileDialog openFileDialogTask_ЖТА;
        private SaveFileDialog saveFileDialogMatrix_ЖТА;
        private ToolTip toolTip;
    }
}
