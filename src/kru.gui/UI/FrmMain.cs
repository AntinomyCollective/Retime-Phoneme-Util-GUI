namespace kru.gui.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowseInput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}