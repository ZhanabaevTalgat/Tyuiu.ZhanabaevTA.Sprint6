using Tyuiu.ZhanabaevTA.Sprint6.Task6.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task6.V5;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    string openFilePath;
    DataService ds = new DataService();

    private void buttonOpenFile_∆“¿_Click(object sender, EventArgs e)
    {
        openFileDialogTask.ShowDialog();
        openFilePath = openFileDialogTask.FileName;
        textBoxInput_∆“¿.Text = File.ReadAllText(openFilePath);
        groupBoxOutput_∆“¿.Text = groupBoxOutput_∆“¿.Text + " " + openFileDialogTask.FileName;
        buttonDone_∆“¿.Enabled = true; 
    }

    private void buttonDone_∆“¿_Click(object sender, EventArgs e)
    {
        string str = "l";
        textBoxOutput_∆“¿.Text = ds.CollectTextFromFile(openFilePath);
    }

    private void buttonHelp_∆“¿_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new FormAbout();
        formAbout.ShowDialog();
    }
}
