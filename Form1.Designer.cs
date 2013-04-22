namespace TravelingSalesman
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.atlantaLabel = new System.Windows.Forms.Label();
            this.austinLabel = new System.Windows.Forms.Label();
            this.bostonLabel = new System.Windows.Forms.Label();
            this.sanFranLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.defaultSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chicagoLabel = new System.Windows.Forms.Label();
            this.addCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.honoluluLabel = new System.Windows.Forms.Label();
            this.miamiLabel = new System.Windows.Forms.Label();
            this.newOrleansLabel = new System.Windows.Forms.Label();
            this.portlandLabel = new System.Windows.Forms.Label();
            this.denverLabel = new System.Windows.Forms.Label();
            this.bestDistanceLabel = new System.Windows.Forms.Label();
            this.bismarkLabel = new System.Windows.Forms.Label();
            this.vegasLabel = new System.Windows.Forms.Label();
            this.newyorkLabel = new System.Windows.Forms.Label();
            this.stlouisLabel = new System.Windows.Forms.Label();
            this.columbusLabel = new System.Windows.Forms.Label();
            this.santefeLabel = new System.Windows.Forms.Label();
            this.boiseLabel = new System.Windows.Forms.Label();
            this.oklahomaLabel = new System.Windows.Forms.Label();
            this.dcLabel = new System.Windows.Forms.Label();
            this.helenaLabel = new System.Windows.Forms.Label();
            this.tallahasseeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atlantaLabel
            // 
            this.atlantaLabel.AutoSize = true;
            this.atlantaLabel.Location = new System.Drawing.Point(430, 231);
            this.atlantaLabel.Name = "atlantaLabel";
            this.atlantaLabel.Size = new System.Drawing.Size(40, 13);
            this.atlantaLabel.TabIndex = 0;
            this.atlantaLabel.Text = "Atlanta";
            this.atlantaLabel.Visible = false;
            // 
            // austinLabel
            // 
            this.austinLabel.AutoSize = true;
            this.austinLabel.Location = new System.Drawing.Point(263, 265);
            this.austinLabel.Name = "austinLabel";
            this.austinLabel.Size = new System.Drawing.Size(36, 13);
            this.austinLabel.TabIndex = 1;
            this.austinLabel.Text = "Austin";
            this.austinLabel.Visible = false;
            // 
            // bostonLabel
            // 
            this.bostonLabel.AutoSize = true;
            this.bostonLabel.Location = new System.Drawing.Point(544, 80);
            this.bostonLabel.Name = "bostonLabel";
            this.bostonLabel.Size = new System.Drawing.Size(40, 13);
            this.bostonLabel.TabIndex = 2;
            this.bostonLabel.Text = "Boston";
            this.bostonLabel.Visible = false;
            // 
            // sanFranLabel
            // 
            this.sanFranLabel.AutoSize = true;
            this.sanFranLabel.Location = new System.Drawing.Point(17, 160);
            this.sanFranLabel.Name = "sanFranLabel";
            this.sanFranLabel.Size = new System.Drawing.Size(69, 13);
            this.sanFranLabel.TabIndex = 3;
            this.sanFranLabel.Text = "San Franciso";
            this.sanFranLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultSetupToolStripMenuItem,
            this.runAlgorithmToolStripMenuItem,
            this.clearMapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // defaultSetupToolStripMenuItem
            // 
            this.defaultSetupToolStripMenuItem.Name = "defaultSetupToolStripMenuItem";
            this.defaultSetupToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.defaultSetupToolStripMenuItem.Text = "Default Setup";
            this.defaultSetupToolStripMenuItem.Click += new System.EventHandler(this.defaultSetupToolStripMenuItem_Click);
            // 
            // runAlgorithmToolStripMenuItem
            // 
            this.runAlgorithmToolStripMenuItem.Name = "runAlgorithmToolStripMenuItem";
            this.runAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.runAlgorithmToolStripMenuItem.Text = "Run Algorithm";
            this.runAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.runAlgorithmToolStripMenuItem_Click);
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clearMapToolStripMenuItem.Text = "Clear Map";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // chicagoLabel
            // 
            this.chicagoLabel.AutoSize = true;
            this.chicagoLabel.Location = new System.Drawing.Point(378, 123);
            this.chicagoLabel.Name = "chicagoLabel";
            this.chicagoLabel.Size = new System.Drawing.Size(46, 13);
            this.chicagoLabel.TabIndex = 6;
            this.chicagoLabel.Text = "Chicago";
            this.chicagoLabel.Visible = false;
            // 
            // addCityToolStripMenuItem
            // 
            this.addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            this.addCityToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addCityToolStripMenuItem.Text = "Add City";
            this.addCityToolStripMenuItem.Click += new System.EventHandler(this.addCityToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCityToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // honoluluLabel
            // 
            this.honoluluLabel.AutoSize = true;
            this.honoluluLabel.Location = new System.Drawing.Point(12, 320);
            this.honoluluLabel.Name = "honoluluLabel";
            this.honoluluLabel.Size = new System.Drawing.Size(49, 13);
            this.honoluluLabel.TabIndex = 7;
            this.honoluluLabel.Text = "Honolulu";
            this.honoluluLabel.Visible = false;
            // 
            // miamiLabel
            // 
            this.miamiLabel.AutoSize = true;
            this.miamiLabel.Location = new System.Drawing.Point(489, 331);
            this.miamiLabel.Name = "miamiLabel";
            this.miamiLabel.Size = new System.Drawing.Size(34, 13);
            this.miamiLabel.TabIndex = 8;
            this.miamiLabel.Text = "Miami";
            this.miamiLabel.Visible = false;
            // 
            // newOrleansLabel
            // 
            this.newOrleansLabel.AutoSize = true;
            this.newOrleansLabel.Location = new System.Drawing.Point(371, 290);
            this.newOrleansLabel.Name = "newOrleansLabel";
            this.newOrleansLabel.Size = new System.Drawing.Size(68, 13);
            this.newOrleansLabel.TabIndex = 9;
            this.newOrleansLabel.Text = "New Orleans";
            this.newOrleansLabel.Visible = false;
            // 
            // portlandLabel
            // 
            this.portlandLabel.AutoSize = true;
            this.portlandLabel.Location = new System.Drawing.Point(41, 43);
            this.portlandLabel.Name = "portlandLabel";
            this.portlandLabel.Size = new System.Drawing.Size(46, 13);
            this.portlandLabel.TabIndex = 10;
            this.portlandLabel.Text = "Portland";
            this.portlandLabel.Visible = false;
            // 
            // denverLabel
            // 
            this.denverLabel.AutoSize = true;
            this.denverLabel.Location = new System.Drawing.Point(194, 160);
            this.denverLabel.Name = "denverLabel";
            this.denverLabel.Size = new System.Drawing.Size(42, 13);
            this.denverLabel.TabIndex = 11;
            this.denverLabel.Text = "Denver";
            this.denverLabel.Visible = false;
            // 
            // bestDistanceLabel
            // 
            this.bestDistanceLabel.AutoSize = true;
            this.bestDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestDistanceLabel.Location = new System.Drawing.Point(459, 375);
            this.bestDistanceLabel.Name = "bestDistanceLabel";
            this.bestDistanceLabel.Size = new System.Drawing.Size(41, 13);
            this.bestDistanceLabel.TabIndex = 12;
            this.bestDistanceLabel.Text = "label1";
            this.bestDistanceLabel.Visible = false;
            // 
            // bismarkLabel
            // 
            this.bismarkLabel.AutoSize = true;
            this.bismarkLabel.Location = new System.Drawing.Point(246, 58);
            this.bismarkLabel.Name = "bismarkLabel";
            this.bismarkLabel.Size = new System.Drawing.Size(44, 13);
            this.bismarkLabel.TabIndex = 13;
            this.bismarkLabel.Text = "Bismark";
            this.bismarkLabel.Visible = false;
            // 
            // vegasLabel
            // 
            this.vegasLabel.AutoSize = true;
            this.vegasLabel.Location = new System.Drawing.Point(80, 182);
            this.vegasLabel.Name = "vegasLabel";
            this.vegasLabel.Size = new System.Drawing.Size(57, 13);
            this.vegasLabel.TabIndex = 14;
            this.vegasLabel.Text = "Las Vegas";
            this.vegasLabel.Visible = false;
            // 
            // newyorkLabel
            // 
            this.newyorkLabel.AutoSize = true;
            this.newyorkLabel.Location = new System.Drawing.Point(515, 104);
            this.newyorkLabel.Name = "newyorkLabel";
            this.newyorkLabel.Size = new System.Drawing.Size(54, 13);
            this.newyorkLabel.TabIndex = 15;
            this.newyorkLabel.Text = "New York";
            this.newyorkLabel.Visible = false;
            // 
            // stlouisLabel
            // 
            this.stlouisLabel.AutoSize = true;
            this.stlouisLabel.Location = new System.Drawing.Point(349, 171);
            this.stlouisLabel.Name = "stlouisLabel";
            this.stlouisLabel.Size = new System.Drawing.Size(48, 13);
            this.stlouisLabel.TabIndex = 16;
            this.stlouisLabel.Text = "St. Louis";
            this.stlouisLabel.Visible = false;
            // 
            // columbusLabel
            // 
            this.columbusLabel.AutoSize = true;
            this.columbusLabel.Location = new System.Drawing.Point(424, 151);
            this.columbusLabel.Name = "columbusLabel";
            this.columbusLabel.Size = new System.Drawing.Size(53, 13);
            this.columbusLabel.TabIndex = 17;
            this.columbusLabel.Text = "Columbus";
            this.columbusLabel.Visible = false;
            // 
            // santefeLabel
            // 
            this.santefeLabel.AutoSize = true;
            this.santefeLabel.Location = new System.Drawing.Point(176, 212);
            this.santefeLabel.Name = "santefeLabel";
            this.santefeLabel.Size = new System.Drawing.Size(50, 13);
            this.santefeLabel.TabIndex = 18;
            this.santefeLabel.Text = "Sante Fe";
            this.santefeLabel.Visible = false;
            // 
            // boiseLabel
            // 
            this.boiseLabel.AutoSize = true;
            this.boiseLabel.Location = new System.Drawing.Point(101, 80);
            this.boiseLabel.Name = "boiseLabel";
            this.boiseLabel.Size = new System.Drawing.Size(33, 13);
            this.boiseLabel.TabIndex = 19;
            this.boiseLabel.Text = "Boise";
            this.boiseLabel.Visible = false;
            // 
            // oklahomaLabel
            // 
            this.oklahomaLabel.AutoSize = true;
            this.oklahomaLabel.Location = new System.Drawing.Point(273, 222);
            this.oklahomaLabel.Name = "oklahomaLabel";
            this.oklahomaLabel.Size = new System.Drawing.Size(75, 13);
            this.oklahomaLabel.TabIndex = 20;
            this.oklahomaLabel.Text = "Oklahoma City";
            this.oklahomaLabel.Visible = false;
            // 
            // dcLabel
            // 
            this.dcLabel.AutoSize = true;
            this.dcLabel.Location = new System.Drawing.Point(489, 160);
            this.dcLabel.Name = "dcLabel";
            this.dcLabel.Size = new System.Drawing.Size(82, 13);
            this.dcLabel.TabIndex = 21;
            this.dcLabel.Text = "Washington DC";
            this.dcLabel.Visible = false;
            // 
            // helenaLabel
            // 
            this.helenaLabel.AutoSize = true;
            this.helenaLabel.Location = new System.Drawing.Point(176, 43);
            this.helenaLabel.Name = "helenaLabel";
            this.helenaLabel.Size = new System.Drawing.Size(41, 13);
            this.helenaLabel.TabIndex = 22;
            this.helenaLabel.Text = "Helena";
            this.helenaLabel.Visible = false;
            // 
            // tallahasseeLabel
            // 
            this.tallahasseeLabel.AutoSize = true;
            this.tallahasseeLabel.Location = new System.Drawing.Point(452, 277);
            this.tallahasseeLabel.Name = "tallahasseeLabel";
            this.tallahasseeLabel.Size = new System.Drawing.Size(64, 13);
            this.tallahasseeLabel.TabIndex = 23;
            this.tallahasseeLabel.Text = "Tallahassee";
            this.tallahasseeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::TravelingSalesman.Properties.Resources.US_Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(614, 397);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tallahasseeLabel);
            this.Controls.Add(this.helenaLabel);
            this.Controls.Add(this.dcLabel);
            this.Controls.Add(this.oklahomaLabel);
            this.Controls.Add(this.boiseLabel);
            this.Controls.Add(this.santefeLabel);
            this.Controls.Add(this.columbusLabel);
            this.Controls.Add(this.stlouisLabel);
            this.Controls.Add(this.newyorkLabel);
            this.Controls.Add(this.vegasLabel);
            this.Controls.Add(this.bestDistanceLabel);
            this.Controls.Add(this.bismarkLabel);
            this.Controls.Add(this.denverLabel);
            this.Controls.Add(this.portlandLabel);
            this.Controls.Add(this.newOrleansLabel);
            this.Controls.Add(this.miamiLabel);
            this.Controls.Add(this.honoluluLabel);
            this.Controls.Add(this.chicagoLabel);
            this.Controls.Add(this.sanFranLabel);
            this.Controls.Add(this.bostonLabel);
            this.Controls.Add(this.austinLabel);
            this.Controls.Add(this.atlantaLabel);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::TravelingSalesman.Properties.Settings.Default, "Salesman", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = global::TravelingSalesman.Properties.Settings.Default.Salesman;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveling Salesman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label atlantaLabel;
        private System.Windows.Forms.Label austinLabel;
        private System.Windows.Forms.Label bostonLabel;
        private System.Windows.Forms.Label sanFranLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem defaultSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAlgorithmToolStripMenuItem;
        private System.Windows.Forms.Label chicagoLabel;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label honoluluLabel;
        private System.Windows.Forms.Label miamiLabel;
        private System.Windows.Forms.Label newOrleansLabel;
        private System.Windows.Forms.Label portlandLabel;
        private System.Windows.Forms.Label denverLabel;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.Label bestDistanceLabel;
        private System.Windows.Forms.Label bismarkLabel;
        private System.Windows.Forms.Label vegasLabel;
        private System.Windows.Forms.Label newyorkLabel;
        private System.Windows.Forms.Label stlouisLabel;
        private System.Windows.Forms.Label columbusLabel;
        private System.Windows.Forms.Label santefeLabel;
        private System.Windows.Forms.Label boiseLabel;
        private System.Windows.Forms.Label oklahomaLabel;
        private System.Windows.Forms.Label dcLabel;
        private System.Windows.Forms.Label helenaLabel;
        private System.Windows.Forms.Label tallahasseeLabel;
    }
}

