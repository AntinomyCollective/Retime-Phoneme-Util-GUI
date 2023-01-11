namespace ConverterGui;

partial class frmMain
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.fbBrowseInput = new System.Windows.Forms.FolderBrowserDialog();
            this.fbBrowseOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdOutput = new System.Windows.Forms.SaveFileDialog();
            this.grpClean = new System.Windows.Forms.GroupBox();
            this.rdClean = new System.Windows.Forms.RadioButton();
            this.rdFixed = new System.Windows.Forms.RadioButton();
            this.chkSaveLogs = new System.Windows.Forms.CheckBox();
            this.grpClean.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(58, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 68);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(521, 31);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInputTextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 173);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(521, 31);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutputTextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 125);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(73, 25);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output:";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(555, 67);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(112, 34);
            this.btnBrowseInput.TabIndex = 4;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BtnBrowseInputClick);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(555, 171);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(112, 34);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.BtnBrowseOutputClick);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save batch";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(552, 373);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpClean
            // 
            this.grpClean.Controls.Add(this.rdClean);
            this.grpClean.Controls.Add(this.rdFixed);
            this.grpClean.Location = new System.Drawing.Point(12, 226);
            this.grpClean.Name = "grpClean";
            this.grpClean.Size = new System.Drawing.Size(320, 119);
            this.grpClean.TabIndex = 8;
            this.grpClean.TabStop = false;
            this.grpClean.Text = "Mode";
            // 
            // rdClean
            // 
            this.rdClean.AutoSize = true;
            this.rdClean.Location = new System.Drawing.Point(18, 75);
            this.rdClean.Name = "rdClean";
            this.rdClean.Size = new System.Drawing.Size(80, 29);
            this.rdClean.TabIndex = 1;
            this.rdClean.Text = "Clean";
            this.rdClean.UseVisualStyleBackColor = true;
            // 
            // rdFixed
            // 
            this.rdFixed.AutoSize = true;
            this.rdFixed.Checked = true;
            this.rdFixed.Location = new System.Drawing.Point(18, 30);
            this.rdFixed.Name = "rdFixed";
            this.rdFixed.Size = new System.Drawing.Size(143, 29);
            this.rdFixed.TabIndex = 0;
            this.rdFixed.TabStop = true;
            this.rdFixed.Text = "Fixed(default)";
            this.rdFixed.UseVisualStyleBackColor = true;
            // 
            // chkSaveLogs
            // 
            this.chkSaveLogs.AutoSize = true;
            this.chkSaveLogs.Checked = true;
            this.chkSaveLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLogs.Location = new System.Drawing.Point(375, 243);
            this.chkSaveLogs.Name = "chkSaveLogs";
            this.chkSaveLogs.Size = new System.Drawing.Size(114, 29);
            this.chkSaveLogs.TabIndex = 9;
            this.chkSaveLogs.Text = "Save logs";
            this.chkSaveLogs.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.chkSaveLogs);
            this.Controls.Add(this.grpClean);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "frmMain";
            this.Text = "Converter";
            this.grpClean.ResumeLayout(false);
            this.grpClean.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblInput;
    private TextBox txtInput;
    private TextBox txtOutput;
    private Label lblOutput;
    private Button btnBrowseInput;
    private Button btnBrowseOutput;
    private Button btnSave;
    private Button btnStart;
    private FolderBrowserDialog fbBrowseInput;
    private FolderBrowserDialog fbBrowseOutput;
    private SaveFileDialog sfdOutput;
    private GroupBox grpClean;
    private RadioButton rdClean;
    private RadioButton rdFixed;
    private CheckBox chkSaveLogs;
}
