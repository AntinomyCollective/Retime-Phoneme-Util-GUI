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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.grpClean.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(5, 21);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(235, 23);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInputTextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(5, 21);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(234, 23);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutputTextChanged);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(244, 21);
            this.btnBrowseInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 4;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BtnBrowseInputClick);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(243, 21);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.BtnBrowseOutputClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(11, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save batch";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(261, 210);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // sfdOutput
            // 
            this.sfdOutput.Filter = "\"Batch File|*.bat|All files|*.*\"";
            this.sfdOutput.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdOutput_FileOk);
            // 
            // grpClean
            // 
            this.grpClean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpClean.Controls.Add(this.rdClean);
            this.grpClean.Controls.Add(this.rdFixed);
            this.grpClean.Location = new System.Drawing.Point(5, 48);
            this.grpClean.Margin = new System.Windows.Forms.Padding(2);
            this.grpClean.Name = "grpClean";
            this.grpClean.Padding = new System.Windows.Forms.Padding(2);
            this.grpClean.Size = new System.Drawing.Size(224, 69);
            this.grpClean.TabIndex = 8;
            this.grpClean.TabStop = false;
            this.grpClean.Text = "Mode:";
            // 
            // rdClean
            // 
            this.rdClean.AutoSize = true;
            this.rdClean.Location = new System.Drawing.Point(4, 43);
            this.rdClean.Margin = new System.Windows.Forms.Padding(2);
            this.rdClean.Name = "rdClean";
            this.rdClean.Size = new System.Drawing.Size(55, 19);
            this.rdClean.TabIndex = 1;
            this.rdClean.Text = "Clean";
            this.rdClean.UseVisualStyleBackColor = true;
            // 
            // rdFixed
            // 
            this.rdFixed.AutoSize = true;
            this.rdFixed.Checked = true;
            this.rdFixed.Location = new System.Drawing.Point(4, 20);
            this.rdFixed.Margin = new System.Windows.Forms.Padding(2);
            this.rdFixed.Name = "rdFixed";
            this.rdFixed.Size = new System.Drawing.Size(98, 19);
            this.rdFixed.TabIndex = 0;
            this.rdFixed.TabStop = true;
            this.rdFixed.Text = "Fixed(default)";
            this.rdFixed.UseVisualStyleBackColor = true;
            // 
            // chkSaveLogs
            // 
            this.chkSaveLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveLogs.AutoSize = true;
            this.chkSaveLogs.Checked = true;
            this.chkSaveLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLogs.Location = new System.Drawing.Point(243, 98);
            this.chkSaveLogs.Margin = new System.Windows.Forms.Padding(2);
            this.chkSaveLogs.Name = "chkSaveLogs";
            this.chkSaveLogs.Size = new System.Drawing.Size(75, 19);
            this.chkSaveLogs.TabIndex = 9;
            this.chkSaveLogs.Text = "Save logs";
            this.chkSaveLogs.UseVisualStyleBackColor = true;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.txtInput);
            this.groupBoxInput.Controls.Add(this.btnBrowseInput);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(324, 63);
            this.groupBoxInput.TabIndex = 10;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input folder:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.txtOutput);
            this.groupBoxOutput.Controls.Add(this.btnBrowseOutput);
            this.groupBoxOutput.Controls.Add(this.chkSaveLogs);
            this.groupBoxOutput.Controls.Add(this.grpClean);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 81);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(323, 122);
            this.groupBoxOutput.TabIndex = 11;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output folder:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(363, 283);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retime Phoneme Util GUI 1.0.0.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpClean.ResumeLayout(false);
            this.grpClean.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private TextBox txtInput;
    private TextBox txtOutput;
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
    private GroupBox groupBoxInput;
    private GroupBox groupBoxOutput;
}
