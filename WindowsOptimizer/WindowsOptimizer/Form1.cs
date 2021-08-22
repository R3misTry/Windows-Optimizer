using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool turkish;
        bool english;

        void OptimizeKontrol()
        {
            if (checkBoxTemp.Checked == true && english == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Ready To Optimize..."; }
            else if (checkBoxTemp.Checked == true && turkish == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Optimize İçin Hazır..."; }
            else if (checkBoxPrefetch.Checked == true && english == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Ready To Optimize..."; }
            else if (checkBoxPrefetch.Checked == true && turkish == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Optimize İçin Hazır..."; }
            else if (checkBoxTemp2.Checked == true && english == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Ready To Optimize..."; }
            else if (checkBoxTemp2.Checked == true && turkish == true) { buttonOptimize.Enabled = true; labelOptimize.Text = "Optimize İçin Hazır..."; }
            else
            {
                if (english == true)
                {
                    buttonOptimize.Enabled = false;
                    labelOptimize.Text = "Not Ready To Optimize";
                }
                else if (turkish == true)
                {
                    buttonOptimize.Enabled = false;
                    labelOptimize.Text = "Optimize İçin Hazır Değil";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void görünümToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void başlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arkaPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var os = Environment.OSVersion;
            labelWindows.Text = os.Platform.ToString();
            labelBit.Text = os.VersionString.ToString();
            buttonOptimize.Enabled = false;
            english = true;
            turkish = false;
        }

        private void checkBoxTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemp.Checked == true && english == true)
            {
                labelTemp.Text = "Temp = Selected";
            }
            else if (checkBoxTemp.Checked == true && turkish == true)
            {
                labelTemp.Text = "Temp = Seçildi";
            }
            else { if (english == true) { labelTemp.Text = "Temp = Non Selected"; } if (turkish == true) { labelTemp.Text = "Temp = Seçilmedi"; } }

            OptimizeKontrol();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxPrefetch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrefetch.Checked == true && english == true)
            {
                labelPrefetch.Text = "Prefetch = Selected";
            }
            else if (checkBoxPrefetch.Checked == true && turkish == true)
            {
                labelPrefetch.Text = "Prefetch = Seçildi";
            }
            else { if (english == true) { labelPrefetch.Text = "Prefetch = Non Selected"; } if (turkish == true) { labelPrefetch.Text = "Prefetch = Seçilmedi"; } }

            OptimizeKontrol();
        }

        private void checkBoxRecent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemp2.Checked == true && english == true)
            {
                labelRecent.Text = "%Temp% = Selected";
            }
            else if (checkBoxTemp2.Checked == true && turkish == true)
            {
                labelRecent.Text = "%Temp% = Seçildi";
            }
            else { if (english == true) { labelRecent.Text = "%Temp% = Non Selected"; } if (turkish == true) { labelRecent.Text = "%Temp% = Seçilmedi"; } }

            OptimizeKontrol();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool dosya2 = false;

        private void EmptyFolderContents(string folderName)
        {
            foreach (var folder in Directory.GetDirectories(folderName))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                    dosya2 = true;
                }
            }
            foreach (var file in Directory.GetFiles(folderName))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                    dosya2 = true;
                }
            }
        }

        private void buttonOptimize_Click(object sender, EventArgs e)
        {
            checkBoxTemp.Enabled = false;
            checkBoxPrefetch.Enabled = false;
            checkBoxTemp2.Enabled = false;
            timer1.Start();
            languangeToolStripMenuItem.Enabled = false;
            buttonOptimize.Enabled = false;
            timer2.Start();

            String tempFolder = Environment.ExpandEnvironmentVariables("C:\\Windows\\Temp");
            String temp2 = Environment.ExpandEnvironmentVariables("%TEMP%");
            String prefetch = Environment.ExpandEnvironmentVariables("C:\\Windows\\Prefetch");

            if (checkBoxTemp.Checked == true)
            {
                EmptyFolderContents(tempFolder);
            }
            if(checkBoxPrefetch.Checked == true)
            {
                EmptyFolderContents(prefetch);
            }
            if(checkBoxTemp2.Checked == true)
            {
                EmptyFolderContents(temp2);
            }
        }
        int eren = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            eren++;
            if (eren == 2 && english == true) { labelOptimize.Text = "Optimizing."; }
            else if (eren == 2 && turkish == true) { labelOptimize.Text = "Optimize Ediliyor."; }
            else if (eren == 4 && english == true) { labelOptimize.Text = "Optimizing.."; }
            else if (eren == 4 && turkish == true) { labelOptimize.Text = "Optimize Ediliyor.."; }
            else if (eren == 6 && english == true) { labelOptimize.Text = "Optimizing..."; }
            else if (eren == 6 && turkish == true) { labelOptimize.Text = "Optimize Ediliyor..."; }
            else if (eren == 8) { eren = 0; }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english = true;
            turkish = false;
            label1.Text = "Windows Optimizer";
            label2.Text = "Easy way to clean junk files";
            languangeToolStripMenuItem.Text = "Languange";
            englishToolStripMenuItem.Text = "English";
            turkishToolStripMenuItem.Text = "Turkish";
            labelVersion.Text = "Optimizer Version: 0.1 | Beta";
            groupBox1.Text = "File Selector";
            groupBox2.Text = "Optimize";
            buttonOptimize.Text = "Optimize";
            labelOptimize.Text = "Not Ready To Optimize";
            featuresPlanningToAddOnV2ToolStripMenuItem.Text = "Features Planning To Add On V0.2";
            labelStatistics.Text = "Statistics:";
        }

        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turkish = true;
            english = false;
            label1.Text = "Windows Optimizer";
            label2.Text = "Gereksiz dosyaları kolayca silin";
            languangeToolStripMenuItem.Text = "Diller";
            englishToolStripMenuItem.Text = "İngilizce";
            turkishToolStripMenuItem.Text = "Türkçe";
            labelVersion.Text = "Optimizer Versiyon: 0.1 | Beta";
            groupBox1.Text = "Dosya Seçici";
            groupBox2.Text = "Optimize";
            buttonOptimize.Text = "Optimize Et";
            labelOptimize.Text = "Optimize İçin Hazır Değil";
            featuresPlanningToAddOnV2ToolStripMenuItem.Text = "V0.2'de Gelmesi Planlanan Özellikler";
            labelStatistics.Text = "İstatistikler:";

            labelTemp.Text = "Temp = Seçilmedi";
            labelPrefetch.Text = "Prefetch = Seçilmedi";
            labelRecent.Text = "%Temp% = Seçilmedi";
        }

        int ahmet = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ahmet++;
            progressBar1.Value = ahmet;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Stop();

                DateTime zaman = DateTime.Now;
                var şusaniye = zaman.ToString("ss.fff");
                var öncekisaniye = zaman.ToString("ss.fff");
                var toplamsaniye = Convert.ToDecimal(şusaniye) - Convert.ToDecimal(öncekisaniye);

                if (english == true)
                {
                    MessageBox.Show("Successfully Optimized!","Windows Optimizer",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    labelOptimize.Text = "Successfully Optimized!";
                    labelSilinmeSaniyesi.Text = "Optimized In " + toplamsaniye + " Seconds!";
                    if (dosya2 == true)
                    {
                        labelBazıDosyalarSilinemedi.Text = "Some Files Not Deleted!";
                    }
                    else if (dosya2 == false)
                    {
                        labelBazıDosyalarSilinemedi.Text = "All Files Deleted!";
                    }
                }
                else if (turkish == true)
                {
                    MessageBox.Show("Başarıyla Optimize Edildi", "Windows Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    labelOptimize.Text = "Başarıyla Optimize Edildi!";
                    labelSilinmeSaniyesi.Text = toplamsaniye + " Saniye İçinde Optimize Edildi!";
                    if (dosya2 == true)
                    {
                        labelBazıDosyalarSilinemedi.Text = "Bazı Dosyalar Silinemedi!";
                    }
                    else if (dosya2 == false)
                    {
                        labelBazıDosyalarSilinemedi.Text = "Bütün Dosyalar Silindi!";
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void featuresPlanningToComeV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(english == true)
            {
                MessageBox.Show("Recent File Deletion Method Will Be Added\n The Appearance Will Change\n Time Calculator Will Be Fix\n Languange Bug Will Be Fix", "Planning To Add On V0.2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(turkish == true)
            {
                MessageBox.Show("Recent Dosya Silme Yöntemi EKlenecek\n Görünüm Değişecek\n Zaman Hesaplayıcı Düzelecek\n Dil Hatası Düzeltilecek", "V0.2'de Eklenmesi Düşünülenler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
