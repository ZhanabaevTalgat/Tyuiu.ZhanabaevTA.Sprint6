namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_ЖТА = new Label();
            buttonOk_ЖТА = new Button();
            SuspendLayout();
            // 
            // labelInfo_ЖТА
            // 
            labelInfo_ЖТА.AutoSize = true;
            labelInfo_ЖТА.Location = new Point(12, 9);
            labelInfo_ЖТА.Name = "labelInfo_ЖТА";
            labelInfo_ЖТА.Size = new Size(387, 160);
            labelInfo_ЖТА.TabIndex = 1;
            labelInfo_ЖТА.Text = resources.GetString("labelInfo_ЖТА.Text");
            // 
            // buttonOk_ЖТА
            // 
            buttonOk_ЖТА.FlatStyle = FlatStyle.System;
            buttonOk_ЖТА.Location = new Point(366, 180);
            buttonOk_ЖТА.Name = "buttonOk_ЖТА";
            buttonOk_ЖТА.Size = new Size(94, 29);
            buttonOk_ЖТА.TabIndex = 2;
            buttonOk_ЖТА.Text = "Ок";
            buttonOk_ЖТА.UseVisualStyleBackColor = true;
            buttonOk_ЖТА.Click += buttonOk_ЖТА_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 221);
            Controls.Add(buttonOk_ЖТА);
            Controls.Add(labelInfo_ЖТА);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_ЖТА;
        private Button buttonOk_ЖТА;
    }
}