using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omlet_Yapma
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                lbl_Timer.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timer.Interval = 1000;
            timer.Start();
        }
        private void btn_Sync_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();

            YumurtalariKir();
            YumurtaCirp();
            TuzEkle();
            OcakYak();
            TencereIsit();
            YagEkle();
            YumurtaPisir();
            OcagiKapat();
            YumurtaTabakla();

            sw.Stop();
            AddLog();
        }
        private void YumurtalariKir()
        {
            Task.Delay(1000).Wait();
            AddLog("Yumurtalar Kırıldı.");
            AdjustButtons(1);
        }
        private void YumurtaCirp()
        {
            Task.Delay(1000).Wait();
            AddLog("Yumurtalar Çırpıldı.");
            AdjustButtons(2);
        }
        private void TuzEkle()
        {
            Task.Delay(1000).Wait();
            AddLog("Yumurtaya tuz eklendi.");
            AdjustButtons(3);
        }
        private void OcakYak()
        {
            Task.Delay(1000).Wait();
            AddLog("Ocağın altı yakıldı.");
            AdjustButtons(4);
        }
        private void TencereIsit()
        {
            Task.Delay(1000).Wait();
            AddLog("Tencere ocakta ısındı.");
            AdjustButtons(5);
        }
        private void YagEkle()
        {
            Task.Delay(1000).Wait();
            AddLog("Tencereye yağ eklendi.");
            AdjustButtons(6);
        }
        private void YumurtaPisir()
        {
            Task.Delay(1000).Wait();
            AddLog("Yumurta ocakta pişti.");
            AdjustButtons(7);
        }
        private void OcagiKapat()
        {
            Task.Delay(1000).Wait();
            AddLog("Ocağın altı kapandı.");
            AdjustButtons(9);
        }
        private void YumurtaTabakla()
        {
            Task.Delay(1000).Wait();
            AddLog("Yumurta tabağa alındı.");
            AdjustButtons(8);
        }

        private async void btn_Async_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();

            await YumurtalariKirAsync();
            await OcakYakAsync();
            await TencereIsitAsync();
            await YumurtaCirpAsync();
            await TuzEkleAsync();
            await YagEkleAsync();
            await YumurtaPisirAsync();
            await OcagiKapatAsync();
            await YumurtaTabaklaAsync();

            sw.Stop();
            AddLog();
        }

        private async Task YumurtalariKirAsync()
        {
            await Task.Delay(1000);
            AddLog("Yumurtalar kırıldı.");
            AdjustButtons(1);
        }
        private async Task YumurtaCirpAsync()
        {
            await Task.Delay(1000);
            AddLog("Yumurtalar Çırpıldı.");
            AdjustButtons(2);
        }
        private async Task TuzEkleAsync()
        {
            await Task.Delay(1000);
            AddLog("Yumurtaya tuz eklendi.");
            AdjustButtons(3);
        }
        private async Task OcakYakAsync()
        {
            await Task.Delay(1000);
            AddLog("Ocağın altı yakıldı.");
            AdjustButtons(4);
        }
        private async Task TencereIsitAsync()
        {
            await Task.Delay(1000);
            AddLog("Tencere ocakta ısındı.");
            AdjustButtons(5);
        }
        private async Task YagEkleAsync()
        {
            await Task.Delay(1000);
            AddLog("Tencereye yağ eklendi.");
            AdjustButtons(6);
        }
        private async Task YumurtaPisirAsync()
        {
            await Task.Delay(1000);
            AddLog("Yumurta ocakta pişti.");
            AdjustButtons(7);
        }
        private async Task OcagiKapatAsync()
        {
            await Task.Delay(1000);
            AddLog("Ocağın altı kapandı.");
            AdjustButtons(9);
        }
        private async Task YumurtaTabaklaAsync()
        {
            await Task.Delay(1000);
            AddLog("Yumurta tabağa alındı.");
            AdjustButtons(8);
        }

        private void AddLog(string logStr = "")
        {
            if (!string.IsNullOrEmpty(logStr))
                logStr = $"[{DateTime.Now:dd:MM:yyyy HH:mm:ss}] - {logStr}";
            listBox1.Items.Add(logStr);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }
        private void AdjustButtons(int step)
        {
            switch (step)
            {
                case 1:
                    btn_Kır.Enabled = false;
                    btn_Kır.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    btn_Cirp.Enabled = false;
                    btn_Cirp.BackColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    btn_Tuz.Enabled = false;
                    btn_Tuz.BackColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    btn_Ocakac.Enabled = false;
                    btn_Ocakac.BackColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    btn_Tencere.Enabled = false;
                    btn_Tencere.BackColor = System.Drawing.Color.Green;
                    break;
                case 6:
                    btn_Yag.Enabled = false;
                    btn_Yag.BackColor = System.Drawing.Color.Green;
                    break;
                case 7:
                    btn_Yumurta.Enabled = false;
                    btn_Yumurta.BackColor = System.Drawing.Color.Green;
                    break;
                case 8:
                    btn_Tabak.Enabled = false;
                    btn_Tabak.BackColor = System.Drawing.Color.Green;
                    break;
                case 9:
                    btn_Ocakkapat.Enabled = false;
                    btn_Ocakkapat.BackColor = System.Drawing.Color.Green;
                    break;
            }
        }
    }
}
