﻿namespace EmaililePazarlamaUygulaması
{
    partial class MainPanel
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailServisiniDeğştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailListeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailŞablonlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(708, 103);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(560, 540);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(1350, 311);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(489, 581);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(35, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1233, 176);
            this.button1.TabIndex = 3;
            this.button1.Text = "YENİ ETKİLEŞİM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMAIL LİSTELERİ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1351, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(489, 135);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1346, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "GEÇMİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1353, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "SERVİS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(703, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMAIL ŞABLONLARI";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1876, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailServisiniDeğştirToolStripMenuItem,
            this.emailListeleriToolStripMenuItem,
            this.emailŞablonlarıToolStripMenuItem,
            this.geçmişToolStripMenuItem});
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(111, 48);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // emailServisiniDeğştirToolStripMenuItem
            // 
            this.emailServisiniDeğştirToolStripMenuItem.Name = "emailServisiniDeğştirToolStripMenuItem";
            this.emailServisiniDeğştirToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.emailServisiniDeğştirToolStripMenuItem.Text = "Email Servisini Değiştir";
            // 
            // emailListeleriToolStripMenuItem
            // 
            this.emailListeleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.çıkarToolStripMenuItem,
            this.düzeltToolStripMenuItem});
            this.emailListeleriToolStripMenuItem.Name = "emailListeleriToolStripMenuItem";
            this.emailListeleriToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.emailListeleriToolStripMenuItem.Text = "Email Listeleri";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ekleToolStripMenuItem.Text = "Liste Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // çıkarToolStripMenuItem
            // 
            this.çıkarToolStripMenuItem.Name = "çıkarToolStripMenuItem";
            this.çıkarToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.çıkarToolStripMenuItem.Text = "Çıkar";
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            // 
            // emailŞablonlarıToolStripMenuItem
            // 
            this.emailŞablonlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.çıkarToolStripMenuItem1,
            this.düzeltToolStripMenuItem1});
            this.emailŞablonlarıToolStripMenuItem.Name = "emailŞablonlarıToolStripMenuItem";
            this.emailŞablonlarıToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.emailŞablonlarıToolStripMenuItem.Text = "Email Şablonları";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            // 
            // çıkarToolStripMenuItem1
            // 
            this.çıkarToolStripMenuItem1.Name = "çıkarToolStripMenuItem1";
            this.çıkarToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.çıkarToolStripMenuItem1.Text = "Çıkar";
            // 
            // düzeltToolStripMenuItem1
            // 
            this.düzeltToolStripMenuItem1.Name = "düzeltToolStripMenuItem1";
            this.düzeltToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.düzeltToolStripMenuItem1.Text = "Düzelt";
            // 
            // geçmişToolStripMenuItem
            // 
            this.geçmişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem});
            this.geçmişToolStripMenuItem.Name = "geçmişToolStripMenuItem";
            this.geçmişToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.geçmişToolStripMenuItem.Text = "Geçmiş";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.temizleToolStripMenuItem.Text = "Temizle";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(35, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(548, 526);
            this.listBox1.TabIndex = 10;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 920);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1898, 976);
            this.MinimumSize = new System.Drawing.Size(1898, 976);
            this.Name = "MainPanel";
            this.ShowIcon = false;
            this.Text = "EMAIL PAZARLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailServisiniDeğştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailListeleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailŞablonlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem geçmişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

