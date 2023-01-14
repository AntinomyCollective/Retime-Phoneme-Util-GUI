using System.Reflection;
using kru.gui;

namespace ConverterGui;
public partial class frmMain : Form
{
    public frmMain() => InitializeComponent();
    public string archbitness = "x86";
    public void bitness()
    {
        if (Environment.Is64BitProcess == true && Environment.Is64BitOperatingSystem == true)
        {
            archbitness = "x64";
        }
        else
        {
            archbitness = "x86";
        }
    }

    private void BtnBrowseOutputClick(object sender, EventArgs e) => this.txtOutput.Text = this.fbBrowseOutput.ShowDialog() == DialogResult.OK ? this.fbBrowseOutput.SelectedPath : string.Empty;

    private void BtnBrowseOutputCleanClick(object sender, EventArgs e) => this.txtOutputClean.Text = this.fbBrowseOutput.ShowDialog() == DialogResult.OK ? this.fbBrowseOutput.SelectedPath : string.Empty;

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

        MessageBox.Show(@"Done!",@"Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

    private void EnableButtons()
    {
        var enabled = !string.IsNullOrWhiteSpace(this.txtInput.Text)
            && !string.IsNullOrWhiteSpace(this.txtOutput.Text)
            //&& !string.IsNullOrWhiteSpace(this.txtOutputClean.Text)
            && Directory.Exists(this.txtInput.Text)
            //&& Directory.Exists(this.txtOutputClean.Text)
            && Directory.Exists(this.txtOutput.Text);
        this.btnSave.Enabled = this.btnStart.Enabled = enabled;
    }

    private Command[] GetCommands()
    {
        var options = new
        {
            Input = this.txtInput.Text,
            Output = this.txtOutput.Text,
            OutputClean = this.txtOutputClean.Text,
            Clean = this.chkClean.Checked,
            SaveLog = chkSaveLogs.Checked,
            Bitness = archbitness
        };
        var commands = Directory
            .GetFiles(options.Input, "*.wav")
            .Select(inputFile => new Command(inputFile, Path.Combine(options.Output, Path.GetFileName(inputFile)), Path.Combine(options.OutputClean, Path.GetFileName(inputFile)), options.Clean, options.SaveLog,options.Bitness))
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
        MessageBox.Show(@"Done!", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
     bitness();
     var appVer = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
     var appName = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyProductAttribute>()!.Product;
     this.Text = $@"{appName} {appVer} ({archbitness})";
    }

    private void sfdOutput_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    private void chkClean_CheckedChanged(object sender, EventArgs e)
    {
        txtOutputClean.Enabled = btnBrowseOutputClean.Enabled = chkClean.Checked;
    }

    private void buttonAbout_Click(object sender, EventArgs e)
    {
        var frmabout = new frmAbout();
        frmabout.ShowDialog();
    }
}
