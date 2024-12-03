namespace Tyuiu.ZhanabaevTA.Sprint6.Task6.V5;

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
        panelInfo_ЖТА = new Panel();
        buttonOpenFile_ЖТА = new Button();
        buttonHelp_ЖТА = new Button();
        buttonDone_ЖТА = new Button();
        panelTask_ЖТА = new Panel();
        groupBoxTask_ЖТА = new GroupBox();
        textBoxTask_ЖТА = new TextBox();
        panelInput_ЖТА = new Panel();
        groupBoxInput_ЖТА = new GroupBox();
        textBoxInput_ЖТА = new TextBox();
        groupBoxOutput_ЖТА = new GroupBox();
        textBoxOutput_ЖТА = new TextBox();
        panelOutput_ЖТА = new Panel();
        splitter1 = new Splitter();
        toolTip = new ToolTip(components);
        openFileDialogTask = new OpenFileDialog();
        panelInfo_ЖТА.SuspendLayout();
        panelTask_ЖТА.SuspendLayout();
        groupBoxTask_ЖТА.SuspendLayout();
        panelInput_ЖТА.SuspendLayout();
        groupBoxInput_ЖТА.SuspendLayout();
        groupBoxOutput_ЖТА.SuspendLayout();
        panelOutput_ЖТА.SuspendLayout();
        SuspendLayout();
        // 
        // panelInfo_ЖТА
        // 
        panelInfo_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelInfo_ЖТА.BackColor = Color.White;
        panelInfo_ЖТА.Controls.Add(buttonOpenFile_ЖТА);
        panelInfo_ЖТА.Controls.Add(buttonHelp_ЖТА);
        panelInfo_ЖТА.Controls.Add(buttonDone_ЖТА);
        panelInfo_ЖТА.Location = new Point(0, 0);
        panelInfo_ЖТА.Name = "panelInfo_ЖТА";
        panelInfo_ЖТА.Size = new Size(856, 88);
        panelInfo_ЖТА.TabIndex = 0;
        // 
        // buttonOpenFile_ЖТА
        // 
        buttonOpenFile_ЖТА.Image = (Image)resources.GetObject("buttonOpenFile_ЖТА.Image");
        buttonOpenFile_ЖТА.Location = new Point(8, 5);
        buttonOpenFile_ЖТА.Name = "buttonOpenFile_ЖТА";
        buttonOpenFile_ЖТА.Size = new Size(91, 76);
        buttonOpenFile_ЖТА.TabIndex = 0;
        toolTip.SetToolTip(buttonOpenFile_ЖТА, "Открыть файл.\r\nВыберите нужный файл для обработки");
        buttonOpenFile_ЖТА.UseVisualStyleBackColor = true;
        buttonOpenFile_ЖТА.Click += buttonOpenFile_ЖТА_Click;
        // 
        // buttonHelp_ЖТА
        // 
        buttonHelp_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonHelp_ЖТА.Image = (Image)resources.GetObject("buttonHelp_ЖТА.Image");
        buttonHelp_ЖТА.Location = new Point(764, 3);
        buttonHelp_ЖТА.Name = "buttonHelp_ЖТА";
        buttonHelp_ЖТА.Size = new Size(86, 81);
        buttonHelp_ЖТА.TabIndex = 0;
        toolTip.SetToolTip(buttonHelp_ЖТА, "О программе");
        buttonHelp_ЖТА.UseVisualStyleBackColor = true;
        buttonHelp_ЖТА.Click += buttonHelp_ЖТА_Click;
        // 
        // buttonDone_ЖТА
        // 
        buttonDone_ЖТА.Image = (Image)resources.GetObject("buttonDone_ЖТА.Image");
        buttonDone_ЖТА.Location = new Point(114, 5);
        buttonDone_ЖТА.Name = "buttonDone_ЖТА";
        buttonDone_ЖТА.Size = new Size(84, 76);
        buttonDone_ЖТА.TabIndex = 0;
        toolTip.SetToolTip(buttonDone_ЖТА, "Производит поиск в файле символов \"l\" и выводит слова в которых есть\r\nданный символ\r\n");
        buttonDone_ЖТА.UseVisualStyleBackColor = true;
        buttonDone_ЖТА.Click += buttonDone_ЖТА_Click;
        // 
        // panelTask_ЖТА
        // 
        panelTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelTask_ЖТА.BackColor = Color.White;
        panelTask_ЖТА.Controls.Add(groupBoxTask_ЖТА);
        panelTask_ЖТА.Location = new Point(0, 85);
        panelTask_ЖТА.Name = "panelTask_ЖТА";
        panelTask_ЖТА.Size = new Size(856, 133);
        panelTask_ЖТА.TabIndex = 1;
        // 
        // groupBoxTask_ЖТА
        // 
        groupBoxTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBoxTask_ЖТА.Controls.Add(textBoxTask_ЖТА);
        groupBoxTask_ЖТА.Location = new Point(3, 5);
        groupBoxTask_ЖТА.Name = "groupBoxTask_ЖТА";
        groupBoxTask_ЖТА.Size = new Size(850, 125);
        groupBoxTask_ЖТА.TabIndex = 0;
        groupBoxTask_ЖТА.TabStop = false;
        groupBoxTask_ЖТА.Text = " Условие";
        // 
        // textBoxTask_ЖТА
        // 
        textBoxTask_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textBoxTask_ЖТА.BorderStyle = BorderStyle.None;
        textBoxTask_ЖТА.Enabled = false;
        textBoxTask_ЖТА.Location = new Point(3, 20);
        textBoxTask_ЖТА.Multiline = true;
        textBoxTask_ЖТА.Name = "textBoxTask_ЖТА";
        textBoxTask_ЖТА.ReadOnly = true;
        textBoxTask_ЖТА.Size = new Size(844, 99);
        textBoxTask_ЖТА.TabIndex = 0;
        textBoxTask_ЖТА.Text = resources.GetString("textBoxTask_ЖТА.Text");
        // 
        // panelInput_ЖТА
        // 
        panelInput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        panelInput_ЖТА.BackColor = Color.White;
        panelInput_ЖТА.Controls.Add(groupBoxInput_ЖТА);
        panelInput_ЖТА.Location = new Point(3, 224);
        panelInput_ЖТА.Name = "panelInput_ЖТА";
        panelInput_ЖТА.Size = new Size(437, 264);
        panelInput_ЖТА.TabIndex = 2;
        // 
        // groupBoxInput_ЖТА
        // 
        groupBoxInput_ЖТА.Controls.Add(textBoxInput_ЖТА);
        groupBoxInput_ЖТА.Dock = DockStyle.Fill;
        groupBoxInput_ЖТА.Location = new Point(0, 0);
        groupBoxInput_ЖТА.Name = "groupBoxInput_ЖТА";
        groupBoxInput_ЖТА.Padding = new Padding(5);
        groupBoxInput_ЖТА.Size = new Size(437, 264);
        groupBoxInput_ЖТА.TabIndex = 0;
        groupBoxInput_ЖТА.TabStop = false;
        groupBoxInput_ЖТА.Text = "Ввод данных";
        // 
        // textBoxInput_ЖТА
        // 
        textBoxInput_ЖТА.Dock = DockStyle.Fill;
        textBoxInput_ЖТА.Location = new Point(5, 25);
        textBoxInput_ЖТА.Multiline = true;
        textBoxInput_ЖТА.Name = "textBoxInput_ЖТА";
        textBoxInput_ЖТА.ScrollBars = ScrollBars.Vertical;
        textBoxInput_ЖТА.Size = new Size(427, 234);
        textBoxInput_ЖТА.TabIndex = 0;
        // 
        // groupBoxOutput_ЖТА
        // 
        groupBoxOutput_ЖТА.BackColor = Color.White;
        groupBoxOutput_ЖТА.Controls.Add(textBoxOutput_ЖТА);
        groupBoxOutput_ЖТА.Dock = DockStyle.Fill;
        groupBoxOutput_ЖТА.Location = new Point(0, 0);
        groupBoxOutput_ЖТА.Name = "groupBoxOutput_ЖТА";
        groupBoxOutput_ЖТА.Padding = new Padding(5);
        groupBoxOutput_ЖТА.Size = new Size(415, 264);
        groupBoxOutput_ЖТА.TabIndex = 1;
        groupBoxOutput_ЖТА.TabStop = false;
        groupBoxOutput_ЖТА.Text = "Вывод данных";
        // 
        // textBoxOutput_ЖТА
        // 
        textBoxOutput_ЖТА.Dock = DockStyle.Fill;
        textBoxOutput_ЖТА.Location = new Point(5, 25);
        textBoxOutput_ЖТА.Multiline = true;
        textBoxOutput_ЖТА.Name = "textBoxOutput_ЖТА";
        textBoxOutput_ЖТА.ReadOnly = true;
        textBoxOutput_ЖТА.ScrollBars = ScrollBars.Vertical;
        textBoxOutput_ЖТА.Size = new Size(405, 234);
        textBoxOutput_ЖТА.TabIndex = 0;
        // 
        // panelOutput_ЖТА
        // 
        panelOutput_ЖТА.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelOutput_ЖТА.Controls.Add(splitter1);
        panelOutput_ЖТА.Controls.Add(groupBoxOutput_ЖТА);
        panelOutput_ЖТА.Location = new Point(441, 224);
        panelOutput_ЖТА.Name = "panelOutput_ЖТА";
        panelOutput_ЖТА.Size = new Size(415, 264);
        panelOutput_ЖТА.TabIndex = 3;
        // 
        // splitter1
        // 
        splitter1.Location = new Point(0, 0);
        splitter1.Name = "splitter1";
        splitter1.Size = new Size(4, 264);
        splitter1.TabIndex = 2;
        splitter1.TabStop = false;
        // 
        // toolTip
        // 
        toolTip.ToolTipTitle = "Подсказка";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(856, 500);
        Controls.Add(panelOutput_ЖТА);
        Controls.Add(panelInput_ЖТА);
        Controls.Add(panelTask_ЖТА);
        Controls.Add(panelInfo_ЖТА);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 6 | Вариант 5 | Жанабаев Т.А";
        panelInfo_ЖТА.ResumeLayout(false);
        panelTask_ЖТА.ResumeLayout(false);
        groupBoxTask_ЖТА.ResumeLayout(false);
        groupBoxTask_ЖТА.PerformLayout();
        panelInput_ЖТА.ResumeLayout(false);
        groupBoxInput_ЖТА.ResumeLayout(false);
        groupBoxInput_ЖТА.PerformLayout();
        groupBoxOutput_ЖТА.ResumeLayout(false);
        groupBoxOutput_ЖТА.PerformLayout();
        panelOutput_ЖТА.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelInfo_ЖТА;
    private Panel panelTask_ЖТА;
    private GroupBox groupBoxTask_ЖТА;
    private TextBox textBoxTask_ЖТА;
    private Panel panelInput_ЖТА;
    private GroupBox groupBoxInput_ЖТА;
    private TextBox textBoxInput_ЖТА;
    private GroupBox groupBoxOutput_ЖТА;
    private TextBox textBoxOutput_ЖТА;
    private Panel panelOutput_ЖТА;
    private Splitter splitter1;
    private Button buttonOpenFile_ЖТА;
    private Button buttonHelp_ЖТА;
    private Button buttonDone_ЖТА;
    private ToolTip toolTip;
    private OpenFileDialog openFileDialogTask;
}
