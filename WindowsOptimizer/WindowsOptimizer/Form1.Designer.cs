
namespace WindowsOptimizer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxPrefetch = new System.Windows.Forms.CheckBox();
            this.checkBoxTemp2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelRecent = new System.Windows.Forms.Label();
            this.labelPrefetch = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBit = new System.Windows.Forms.Label();
            this.labelWindows = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOptimize = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonOptimize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresPlanningToAddOnV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelStatistics = new System.Windows.Forms.Label();
            this.labelBazıDosyalarSilinemedi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSilinmeSaniyesi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(233, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windows Optimizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(298, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Easy way to clean junk files";
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxTemp.ForeColor = System.Drawing.Color.White;
            this.checkBoxTemp.Location = new System.Drawing.Point(7, 41);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(70, 24);
            this.checkBoxTemp.TabIndex = 4;
            this.checkBoxTemp.Text = "Temp";
            this.checkBoxTemp.UseVisualStyleBackColor = false;
            this.checkBoxTemp.CheckedChanged += new System.EventHandler(this.checkBoxTemp_CheckedChanged);
            // 
            // checkBoxPrefetch
            // 
            this.checkBoxPrefetch.AutoSize = true;
            this.checkBoxPrefetch.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPrefetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxPrefetch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxPrefetch.Location = new System.Drawing.Point(7, 86);
            this.checkBoxPrefetch.Name = "checkBoxPrefetch";
            this.checkBoxPrefetch.Size = new System.Drawing.Size(91, 24);
            this.checkBoxPrefetch.TabIndex = 5;
            this.checkBoxPrefetch.Text = "Prefetch";
            this.checkBoxPrefetch.UseVisualStyleBackColor = false;
            this.checkBoxPrefetch.CheckedChanged += new System.EventHandler(this.checkBoxPrefetch_CheckedChanged);
            // 
            // checkBoxTemp2
            // 
            this.checkBoxTemp2.AutoSize = true;
            this.checkBoxTemp2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxTemp2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxTemp2.Location = new System.Drawing.Point(7, 128);
            this.checkBoxTemp2.Name = "checkBoxTemp2";
            this.checkBoxTemp2.Size = new System.Drawing.Size(100, 24);
            this.checkBoxTemp2.TabIndex = 6;
            this.checkBoxTemp2.Text = "%Temp%";
            this.checkBoxTemp2.UseVisualStyleBackColor = false;
            this.checkBoxTemp2.CheckedChanged += new System.EventHandler(this.checkBoxRecent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.labelRecent);
            this.groupBox1.Controls.Add(this.labelPrefetch);
            this.groupBox1.Controls.Add(this.labelTemp);
            this.groupBox1.Controls.Add(this.checkBoxTemp);
            this.groupBox1.Controls.Add(this.checkBoxTemp2);
            this.groupBox1.Controls.Add(this.checkBoxPrefetch);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(32, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Selector";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(146, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // labelRecent
            // 
            this.labelRecent.AutoSize = true;
            this.labelRecent.BackColor = System.Drawing.Color.Transparent;
            this.labelRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRecent.Location = new System.Drawing.Point(6, 234);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(190, 20);
            this.labelRecent.TabIndex = 11;
            this.labelRecent.Text = "%Temp% = Non Selected";
            // 
            // labelPrefetch
            // 
            this.labelPrefetch.AutoSize = true;
            this.labelPrefetch.BackColor = System.Drawing.Color.Transparent;
            this.labelPrefetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrefetch.Location = new System.Drawing.Point(6, 205);
            this.labelPrefetch.Name = "labelPrefetch";
            this.labelPrefetch.Size = new System.Drawing.Size(182, 20);
            this.labelPrefetch.TabIndex = 10;
            this.labelPrefetch.Text = "Prefetch = Non Selected";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTemp.Location = new System.Drawing.Point(6, 175);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(162, 20);
            this.labelTemp.TabIndex = 9;
            this.labelTemp.Text = "Temp = Non Selected";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelBit);
            this.panel1.Controls.Add(this.labelWindows);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelBit
            // 
            this.labelBit.AutoSize = true;
            this.labelBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBit.Location = new System.Drawing.Point(12, 37);
            this.labelBit.Name = "labelBit";
            this.labelBit.Size = new System.Drawing.Size(96, 18);
            this.labelBit.TabIndex = 14;
            this.labelBit.Text = "VersionString";
            // 
            // labelWindows
            // 
            this.labelWindows.AutoSize = true;
            this.labelWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWindows.Location = new System.Drawing.Point(12, 12);
            this.labelWindows.Name = "labelWindows";
            this.labelWindows.Size = new System.Drawing.Size(64, 18);
            this.labelWindows.TabIndex = 13;
            this.labelWindows.Text = "Platform";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVersion.Location = new System.Drawing.Point(12, 62);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(197, 18);
            this.labelVersion.TabIndex = 12;
            this.labelVersion.Text = "Optimizer Version: 0.1 | Beta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.labelOptimize);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.buttonOptimize);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(465, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 266);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optimize";
            // 
            // labelOptimize
            // 
            this.labelOptimize.AutoSize = true;
            this.labelOptimize.BackColor = System.Drawing.Color.Transparent;
            this.labelOptimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelOptimize.Location = new System.Drawing.Point(70, 191);
            this.labelOptimize.Name = "labelOptimize";
            this.labelOptimize.Size = new System.Drawing.Size(196, 22);
            this.labelOptimize.TabIndex = 2;
            this.labelOptimize.Text = "Not Ready To Optimize";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar1.Location = new System.Drawing.Point(6, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(289, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonOptimize
            // 
            this.buttonOptimize.BackColor = System.Drawing.Color.Teal;
            this.buttonOptimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.buttonOptimize.Location = new System.Drawing.Point(74, 101);
            this.buttonOptimize.Name = "buttonOptimize";
            this.buttonOptimize.Size = new System.Drawing.Size(156, 51);
            this.buttonOptimize.TabIndex = 0;
            this.buttonOptimize.Text = "Optimize";
            this.buttonOptimize.UseVisualStyleBackColor = false;
            this.buttonOptimize.Click += new System.EventHandler(this.buttonOptimize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languangeToolStripMenuItem,
            this.featuresPlanningToAddOnV2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languangeToolStripMenuItem
            // 
            this.languangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.turkishToolStripMenuItem});
            this.languangeToolStripMenuItem.Name = "languangeToolStripMenuItem";
            this.languangeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.languangeToolStripMenuItem.Text = "Languange";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turkishToolStripMenuItem.Text = "Turkish";
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // featuresPlanningToAddOnV2ToolStripMenuItem
            // 
            this.featuresPlanningToAddOnV2ToolStripMenuItem.Name = "featuresPlanningToAddOnV2ToolStripMenuItem";
            this.featuresPlanningToAddOnV2ToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.featuresPlanningToAddOnV2ToolStripMenuItem.Text = "Features Planning To Add On V0.2";
            this.featuresPlanningToAddOnV2ToolStripMenuItem.Click += new System.EventHandler(this.featuresPlanningToComeV2ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelStatistics.Location = new System.Drawing.Point(90, 0);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(84, 20);
            this.labelStatistics.TabIndex = 3;
            this.labelStatistics.Text = "Statistics:";
            // 
            // labelBazıDosyalarSilinemedi
            // 
            this.labelBazıDosyalarSilinemedi.AutoSize = true;
            this.labelBazıDosyalarSilinemedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelBazıDosyalarSilinemedi.Location = new System.Drawing.Point(3, 55);
            this.labelBazıDosyalarSilinemedi.Name = "labelBazıDosyalarSilinemedi";
            this.labelBazıDosyalarSilinemedi.Size = new System.Drawing.Size(0, 17);
            this.labelBazıDosyalarSilinemedi.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSilinmeSaniyesi);
            this.panel2.Controls.Add(this.labelStatistics);
            this.panel2.Controls.Add(this.labelBazıDosyalarSilinemedi);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 79);
            this.panel2.TabIndex = 6;
            // 
            // labelSilinmeSaniyesi
            // 
            this.labelSilinmeSaniyesi.AutoSize = true;
            this.labelSilinmeSaniyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSilinmeSaniyesi.Location = new System.Drawing.Point(3, 25);
            this.labelSilinmeSaniyesi.Name = "labelSilinmeSaniyesi";
            this.labelSilinmeSaniyesi.Size = new System.Drawing.Size(0, 17);
            this.labelSilinmeSaniyesi.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Windows Optimizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox checkBoxPrefetch;
        private System.Windows.Forms.CheckBox checkBoxTemp2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelOptimize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonOptimize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelBit;
        private System.Windows.Forms.Label labelWindows;
        private System.Windows.Forms.Label labelRecent;
        private System.Windows.Forms.Label labelPrefetch;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem featuresPlanningToAddOnV2ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Label labelBazıDosyalarSilinemedi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSilinmeSaniyesi;
    }
}

