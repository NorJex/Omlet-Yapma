namespace Omlet_Yapma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_Async = new System.Windows.Forms.Button();
            this.btn_Kır = new System.Windows.Forms.Button();
            this.btn_Cirp = new System.Windows.Forms.Button();
            this.btn_Tuz = new System.Windows.Forms.Button();
            this.btn_Ocakac = new System.Windows.Forms.Button();
            this.btn_Tencere = new System.Windows.Forms.Button();
            this.btn_Yag = new System.Windows.Forms.Button();
            this.btn_Yumurta = new System.Windows.Forms.Button();
            this.btn_Tabak = new System.Windows.Forms.Button();
            this.btn_Ocakkapat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ocakkapat);
            this.groupBox1.Controls.Add(this.btn_Tabak);
            this.groupBox1.Controls.Add(this.btn_Yumurta);
            this.groupBox1.Controls.Add(this.btn_Yag);
            this.groupBox1.Controls.Add(this.btn_Tencere);
            this.groupBox1.Controls.Add(this.btn_Ocakac);
            this.groupBox1.Controls.Add(this.btn_Tuz);
            this.groupBox1.Controls.Add(this.btn_Cirp);
            this.groupBox1.Controls.Add(this.btn_Kır);
            this.groupBox1.Location = new System.Drawing.Point(772, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(302, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aşamalar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Async);
            this.groupBox2.Controls.Add(this.btn_Sync);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(751, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Komut";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 234);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(750, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(104, 70);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(215, 82);
            this.btn_Sync.TabIndex = 0;
            this.btn_Sync.Text = "Senkron Yumurta Yapımı";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_Async
            // 
            this.btn_Async.Location = new System.Drawing.Point(434, 70);
            this.btn_Async.Name = "btn_Async";
            this.btn_Async.Size = new System.Drawing.Size(215, 82);
            this.btn_Async.TabIndex = 1;
            this.btn_Async.Text = "Asenkron Yumurta Yapımı";
            this.btn_Async.UseVisualStyleBackColor = true;
            this.btn_Async.Click += new System.EventHandler(this.btn_Async_Click);
            // 
            // btn_Kır
            // 
            this.btn_Kır.Location = new System.Drawing.Point(30, 40);
            this.btn_Kır.Name = "btn_Kır";
            this.btn_Kır.Size = new System.Drawing.Size(265, 39);
            this.btn_Kır.TabIndex = 0;
            this.btn_Kır.Text = "Yumurtayı Kır";
            this.btn_Kır.UseVisualStyleBackColor = true;
            // 
            // btn_Cirp
            // 
            this.btn_Cirp.Location = new System.Drawing.Point(30, 85);
            this.btn_Cirp.Name = "btn_Cirp";
            this.btn_Cirp.Size = new System.Drawing.Size(265, 39);
            this.btn_Cirp.TabIndex = 1;
            this.btn_Cirp.Text = "Yumurtayı Çırp";
            this.btn_Cirp.UseVisualStyleBackColor = true;
            // 
            // btn_Tuz
            // 
            this.btn_Tuz.Location = new System.Drawing.Point(30, 130);
            this.btn_Tuz.Name = "btn_Tuz";
            this.btn_Tuz.Size = new System.Drawing.Size(265, 39);
            this.btn_Tuz.TabIndex = 2;
            this.btn_Tuz.Text = "Yumurtaya Tuz Ekle";
            this.btn_Tuz.UseVisualStyleBackColor = true;
            // 
            // btn_Ocakac
            // 
            this.btn_Ocakac.Location = new System.Drawing.Point(30, 175);
            this.btn_Ocakac.Name = "btn_Ocakac";
            this.btn_Ocakac.Size = new System.Drawing.Size(265, 39);
            this.btn_Ocakac.TabIndex = 3;
            this.btn_Ocakac.Text = "Ocağın Altını Yak";
            this.btn_Ocakac.UseVisualStyleBackColor = true;
            // 
            // btn_Tencere
            // 
            this.btn_Tencere.Location = new System.Drawing.Point(30, 220);
            this.btn_Tencere.Name = "btn_Tencere";
            this.btn_Tencere.Size = new System.Drawing.Size(265, 39);
            this.btn_Tencere.TabIndex = 4;
            this.btn_Tencere.Text = "Tencereyı Ocakta Isıt";
            this.btn_Tencere.UseVisualStyleBackColor = true;
            // 
            // btn_Yag
            // 
            this.btn_Yag.Location = new System.Drawing.Point(30, 265);
            this.btn_Yag.Name = "btn_Yag";
            this.btn_Yag.Size = new System.Drawing.Size(265, 39);
            this.btn_Yag.TabIndex = 4;
            this.btn_Yag.Text = "Tencereye Yağ Ekle";
            this.btn_Yag.UseVisualStyleBackColor = true;
            // 
            // btn_Yumurta
            // 
            this.btn_Yumurta.Location = new System.Drawing.Point(30, 310);
            this.btn_Yumurta.Name = "btn_Yumurta";
            this.btn_Yumurta.Size = new System.Drawing.Size(265, 39);
            this.btn_Yumurta.TabIndex = 5;
            this.btn_Yumurta.Text = "Yumurtayı Tencereye Koy";
            this.btn_Yumurta.UseVisualStyleBackColor = true;
            // 
            // btn_Tabak
            // 
            this.btn_Tabak.Location = new System.Drawing.Point(30, 400);
            this.btn_Tabak.Name = "btn_Tabak";
            this.btn_Tabak.Size = new System.Drawing.Size(265, 39);
            this.btn_Tabak.TabIndex = 6;
            this.btn_Tabak.Text = "Pişen Yumurtayı Tabağa Al";
            this.btn_Tabak.UseVisualStyleBackColor = true;
            // 
            // btn_Ocakkapat
            // 
            this.btn_Ocakkapat.Location = new System.Drawing.Point(30, 355);
            this.btn_Ocakkapat.Name = "btn_Ocakkapat";
            this.btn_Ocakkapat.Size = new System.Drawing.Size(265, 39);
            this.btn_Ocakkapat.TabIndex = 7;
            this.btn_Ocakkapat.Text = "Ocağı Kapat";
            this.btn_Ocakkapat.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(7, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(736, 229);
            this.listBox1.TabIndex = 0;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Location = new System.Drawing.Point(906, 488);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(62, 25);
            this.lbl_Timer.TabIndex = 3;
            this.lbl_Timer.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 527);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ocakkapat;
        private System.Windows.Forms.Button btn_Tabak;
        private System.Windows.Forms.Button btn_Yumurta;
        private System.Windows.Forms.Button btn_Yag;
        private System.Windows.Forms.Button btn_Tencere;
        private System.Windows.Forms.Button btn_Ocakac;
        private System.Windows.Forms.Button btn_Tuz;
        private System.Windows.Forms.Button btn_Cirp;
        private System.Windows.Forms.Button btn_Kır;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Async;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_Timer;
    }
}

