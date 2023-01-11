namespace ConverterGui;
public partial class frmMain : Form
{
    public frmMain() => InitializeComponent();

    private void BtnBrowseOutputClick(object sender, EventArgs e) => this.txtOutput.Text = this.fbBrowseOutput.ShowDialog() == DialogResult.OK ? this.fbBrowseOutput.SelectedPath : string.Empty;

    private void BtnBrowseInputClick(object sender, EventArgs e) => this.txtInput.Text = this.fbBrowseInput.ShowDialog() == DialogResult.OK ? this.fbBrowseInput.SelectedPath : string.Empty;

    private void TxtOutputTextChanged(object sender, EventArgs e)
    {
        this.fbBrowseOutput.SelectedPath = this.txtOutput.Text;
        EnableButtons();
    }

    private void TxtInputTextChanged(object sender, EventArgs e)
    {
        this.fbBrowseInput.SelectedPath = this.txtInput.Text;
        EnableButtons();
    }

    private void BtnSaveClick(object sender, EventArgs e)
    {
        var commands = GetCommands();

        if (sfdOutput.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllLines(sfdOutput.FileName, commands
                .Select(a => a.GetBatchLine()));
        }

        MessageBox.Show("Done!");
    }

    private void EnableButtons()
    {
        var enabled = !string.IsNullOrWhiteSpace(this.txtInput.Text)
            && !string.IsNullOrWhiteSpace(this.txtOutput.Text)
            && Directory.Exists(this.txtInput.Text);
        this.btnSave.Enabled = this.btnStart.Enabled = enabled;
    }

    private Command[] GetCommands()
    {
        var options = new
        {
            Input = this.txtInput.Text,
            Output = this.txtOutput.Text,
            Clean = this.rdClean.Checked,
            SaveLog = chkSaveLogs.Checked,
        };
        var commands = Directory
            .GetFiles(options.Input, "*.wav")
            .Select(inputFile => new Command(inputFile, Path.Combine(options.Output, Path.GetFileName(inputFile)), options.Clean, options.SaveLog))
            .ToArray();

        return commands;
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        var commands = GetCommands();
        foreach (var command in commands)
        {
            var proc = command.GetProcess();
            proc.Start();
            await proc.WaitForExitAsync().ConfigureAwait(false);
        }
        this.Enabled = true;
        MessageBox.Show("Done!");
    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }

    private void sfdOutput_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }
}
