
using ScottPlot;
using System.IO;

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
            components = new System.ComponentModel.Container();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            formsPlot1 = new ScottPlot.FormsPlot();
            timer1 = new System.Windows.Forms.Timer(components);
            formsPlot2 = new ScottPlot.FormsPlot();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            formsPlot3 = new ScottPlot.FormsPlot();
            comboBox1 = new System.Windows.Forms.ComboBox();
            formsPlot4 = new ScottPlot.FormsPlot();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadPriorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadLikelihoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadTimeSeriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectToGPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectToDynasimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectToTCPIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            priorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showPriorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            likelihoodTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            textBox1 = new System.Windows.Forms.TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new System.Drawing.Point(39, 38);
            formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new System.Drawing.Size(467, 187);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load_1;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += Tempo;
            // 
            // formsPlot2
            // 
            formsPlot2.Location = new System.Drawing.Point(514, 38);
            formsPlot2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new System.Drawing.Size(229, 187);
            formsPlot2.TabIndex = 2;
            formsPlot2.Load += formsPlot2_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(98, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 15);
            label1.TabIndex = 3;
            label1.Text = "FPSO Heading (deg)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(627, 210);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "X (m)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(514, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Y (m)";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(618, 47);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 15);
            label5.TabIndex = 7;
            label5.Text = "FPSO OFFSET (m)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(430, 210);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 15);
            label6.TabIndex = 8;
            label6.Text = "Time (sec)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 89);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 15);
            label7.TabIndex = 9;
            label7.Text = "Heading (deg)";
            label7.Click += label7_Click;
            // 
            // formsPlot3
            // 
            formsPlot3.Location = new System.Drawing.Point(39, 231);
            formsPlot3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new System.Drawing.Size(265, 183);
            formsPlot3.TabIndex = 10;
            formsPlot3.Load += formsPlot3_Load;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(89, 412);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(63, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // formsPlot4
            // 
            formsPlot4.Location = new System.Drawing.Point(301, 231);
            formsPlot4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new System.Drawing.Size(442, 183);
            formsPlot4.TabIndex = 12;
            formsPlot4.Load += formsPlot4_Load;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(667, 399);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 15);
            label4.TabIndex = 13;
            label4.Text = "Time (sec)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(358, 240);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(72, 15);
            label8.TabIndex = 14;
            label8.Text = "Probabilities";
            label8.Click += label8_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Arquivos csv|*.csv";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, connectionToolStripMenuItem, priorsToolStripMenuItem, aboutToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(826, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { loadPriorsToolStripMenuItem, loadLikelihoodsToolStripMenuItem, loadTimeSeriesToolStripMenuItem1, saveSectionToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // loadPriorsToolStripMenuItem
            // 
            loadPriorsToolStripMenuItem.Name = "loadPriorsToolStripMenuItem";
            loadPriorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            loadPriorsToolStripMenuItem.Text = "Load Priors";
            loadPriorsToolStripMenuItem.Click += loadPriorsToolStripMenuItem_Click;
            // 
            // loadLikelihoodsToolStripMenuItem
            // 
            loadLikelihoodsToolStripMenuItem.Name = "loadLikelihoodsToolStripMenuItem";
            loadLikelihoodsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            loadLikelihoodsToolStripMenuItem.Text = "Load Likelihoods";
            loadLikelihoodsToolStripMenuItem.Click += loadLikelihoodsToolStripMenuItem_Click;
            // 
            // loadTimeSeriesToolStripMenuItem1
            // 
            loadTimeSeriesToolStripMenuItem1.Name = "loadTimeSeriesToolStripMenuItem1";
            loadTimeSeriesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            loadTimeSeriesToolStripMenuItem1.Text = "Load Time Series";
            loadTimeSeriesToolStripMenuItem1.Click += loadTimeSeriesToolStripMenuItem_Click;
            // 
            // saveSectionToolStripMenuItem
            // 
            saveSectionToolStripMenuItem.Name = "saveSectionToolStripMenuItem";
            saveSectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            saveSectionToolStripMenuItem.Text = "Save Section";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { connectToGPSToolStripMenuItem, connectToDynasimToolStripMenuItem, connectToTCPIPToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            connectionToolStripMenuItem.Click += connectionToolStripMenuItem_Click;
            // 
            // connectToGPSToolStripMenuItem
            // 
            connectToGPSToolStripMenuItem.Name = "connectToGPSToolStripMenuItem";
            connectToGPSToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            connectToGPSToolStripMenuItem.Text = "Connect to GPS";
            connectToGPSToolStripMenuItem.Click += connectToGPSToolStripMenuItem_Click;
            // 
            // connectToDynasimToolStripMenuItem
            // 
            connectToDynasimToolStripMenuItem.Name = "connectToDynasimToolStripMenuItem";
            connectToDynasimToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            connectToDynasimToolStripMenuItem.Text = "Connect to Database";
            // 
            // connectToTCPIPToolStripMenuItem
            // 
            connectToTCPIPToolStripMenuItem.Name = "connectToTCPIPToolStripMenuItem";
            connectToTCPIPToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            connectToTCPIPToolStripMenuItem.Text = "Connect to TCP/IP";
            // 
            // priorsToolStripMenuItem
            // 
            priorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showPriorsToolStripMenuItem, likelihoodTablesToolStripMenuItem });
            priorsToolStripMenuItem.Name = "priorsToolStripMenuItem";
            priorsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            priorsToolStripMenuItem.Text = "Bayes Network";
            priorsToolStripMenuItem.Click += priorsToolStripMenuItem_Click;
            // 
            // showPriorsToolStripMenuItem
            // 
            showPriorsToolStripMenuItem.Name = "showPriorsToolStripMenuItem";
            showPriorsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            showPriorsToolStripMenuItem.Text = "Priors";
            showPriorsToolStripMenuItem.Click += showPriorsToolStripMenuItem_Click;
            // 
            // likelihoodTablesToolStripMenuItem
            // 
            likelihoodTablesToolStripMenuItem.Name = "likelihoodTablesToolStripMenuItem";
            likelihoodTablesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            likelihoodTablesToolStripMenuItem.Text = "Likelihood Tables";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { versionToolStripMenuItem, helpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            aboutToolStripMenuItem.Text = "Reporting";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            versionToolStripMenuItem.Text = "Graphs";
            versionToolStripMenuItem.Click += versionToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            helpToolStripMenuItem.Text = "Tables";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { versionToolStripMenuItem1, supportToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            reportToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem1
            // 
            versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            versionToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            versionToolStripMenuItem1.Text = "Version";
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            supportToolStripMenuItem.Text = "Support";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(348, 412);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(63, 23);
            comboBox2.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(89, 240);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(37, 15);
            label9.TabIndex = 17;
            label9.Text = "Priors";
            // 
            // bindingSource1
            // 
            bindingSource1.AddingNew += bindingSource1_AddingNew;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(474, 434);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(170, 23);
            textBox1.TabIndex = 18;
            // 
            // timer2
            // 
            timer2.Tick += tempo2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(826, 469);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(formsPlot4);
            Controls.Add(comboBox1);
            Controls.Add(formsPlot3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SISTEMA LINES-BAYES - LOC/COPPE/UFRJ - CENPES/PETROBRAS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

