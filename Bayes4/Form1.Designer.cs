
namespace Bayes4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formsPlot4 = new ScottPlot.FormsPlot();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPriorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLikelihoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTimeSeriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToGPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDynasimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToTCPIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPriorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.likelihoodTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(39, 38);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(467, 187);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Tempo);
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(514, 38);
            this.formsPlot2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(229, 187);
            this.formsPlot2.TabIndex = 2;
            this.formsPlot2.Load += new System.EventHandler(this.formsPlot2_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPSO Heading (deg)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "X (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y (m)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "FPSO OFFSET (m)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time (sec)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Heading (deg)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // formsPlot3
            // 
            this.formsPlot3.Location = new System.Drawing.Point(39, 231);
            this.formsPlot3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(265, 183);
            this.formsPlot3.TabIndex = 10;
            this.formsPlot3.Load += new System.EventHandler(this.formsPlot3_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 412);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // formsPlot4
            // 
            this.formsPlot4.Location = new System.Drawing.Point(301, 231);
            this.formsPlot4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot4.Name = "formsPlot4";
            this.formsPlot4.Size = new System.Drawing.Size(442, 183);
            this.formsPlot4.TabIndex = 12;
            this.formsPlot4.Load += new System.EventHandler(this.formsPlot4_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time (sec)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Probabilities";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Arquivos csv|*.csv";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.priorsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPriorsToolStripMenuItem,
            this.loadLikelihoodsToolStripMenuItem,
            this.loadTimeSeriesToolStripMenuItem1,
            this.saveSectionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadPriorsToolStripMenuItem
            // 
            this.loadPriorsToolStripMenuItem.Name = "loadPriorsToolStripMenuItem";
            this.loadPriorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadPriorsToolStripMenuItem.Text = "Load Priors";
            this.loadPriorsToolStripMenuItem.Click += new System.EventHandler(this.loadPriorsToolStripMenuItem_Click);
            // 
            // loadLikelihoodsToolStripMenuItem
            // 
            this.loadLikelihoodsToolStripMenuItem.Name = "loadLikelihoodsToolStripMenuItem";
            this.loadLikelihoodsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadLikelihoodsToolStripMenuItem.Text = "Load Likelihoods";
            this.loadLikelihoodsToolStripMenuItem.Click += new System.EventHandler(this.loadLikelihoodsToolStripMenuItem_Click);
            // 
            // loadTimeSeriesToolStripMenuItem1
            // 
            this.loadTimeSeriesToolStripMenuItem1.Name = "loadTimeSeriesToolStripMenuItem1";
            this.loadTimeSeriesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadTimeSeriesToolStripMenuItem1.Text = "Load Time Series";
            this.loadTimeSeriesToolStripMenuItem1.Click += new System.EventHandler(this.loadTimeSeriesToolStripMenuItem_Click);
            // 
            // saveSectionToolStripMenuItem
            // 
            this.saveSectionToolStripMenuItem.Name = "saveSectionToolStripMenuItem";
            this.saveSectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveSectionToolStripMenuItem.Text = "Save Section";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToGPSToolStripMenuItem,
            this.connectToDynasimToolStripMenuItem,
            this.connectToTCPIPToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // connectToGPSToolStripMenuItem
            // 
            this.connectToGPSToolStripMenuItem.Name = "connectToGPSToolStripMenuItem";
            this.connectToGPSToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToGPSToolStripMenuItem.Text = "Connect to GPS";
            this.connectToGPSToolStripMenuItem.Click += new System.EventHandler(this.connectToGPSToolStripMenuItem_Click);
            // 
            // connectToDynasimToolStripMenuItem
            // 
            this.connectToDynasimToolStripMenuItem.Name = "connectToDynasimToolStripMenuItem";
            this.connectToDynasimToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToDynasimToolStripMenuItem.Text = "Connect to Database";
            // 
            // connectToTCPIPToolStripMenuItem
            // 
            this.connectToTCPIPToolStripMenuItem.Name = "connectToTCPIPToolStripMenuItem";
            this.connectToTCPIPToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToTCPIPToolStripMenuItem.Text = "Connect to TCP/IP";
            // 
            // priorsToolStripMenuItem
            // 
            this.priorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPriorsToolStripMenuItem,
            this.likelihoodTablesToolStripMenuItem});
            this.priorsToolStripMenuItem.Name = "priorsToolStripMenuItem";
            this.priorsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.priorsToolStripMenuItem.Text = "Bayes Network";
            this.priorsToolStripMenuItem.Click += new System.EventHandler(this.priorsToolStripMenuItem_Click);
            // 
            // showPriorsToolStripMenuItem
            // 
            this.showPriorsToolStripMenuItem.Name = "showPriorsToolStripMenuItem";
            this.showPriorsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showPriorsToolStripMenuItem.Text = "Priors";
            this.showPriorsToolStripMenuItem.Click += new System.EventHandler(this.showPriorsToolStripMenuItem_Click);
            // 
            // likelihoodTablesToolStripMenuItem
            // 
            this.likelihoodTablesToolStripMenuItem.Name = "likelihoodTablesToolStripMenuItem";
            this.likelihoodTablesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.likelihoodTablesToolStripMenuItem.Text = "Likelihood Tables";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aboutToolStripMenuItem.Text = "Reporting";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.versionToolStripMenuItem.Text = "Graphs";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.helpToolStripMenuItem.Text = "Tables";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem1,
            this.supportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.versionToolStripMenuItem1.Text = "Version";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 412);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 23);
            this.comboBox2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Priors";
            // 
            // bindingSource1
            // 
            this.bindingSource1.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingSource1_AddingNew);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 18;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.tempo2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formsPlot4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.formsPlot3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SISTEMA LINES-BAYES - LOC/COPPE/UFRJ - CENPES/PETROBRAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private ScottPlot.FormsPlot formsPlot3;
        private ScottPlot.FormsPlot formsPlot4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPriorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLikelihoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPriorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToGPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDynasimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem likelihoodTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTimeSeriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToTCPIPToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

