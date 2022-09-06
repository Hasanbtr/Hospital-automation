namespace HastaneOtomasyon
{
    partial class RandevuAl
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
            this.adTBox = new System.Windows.Forms.TextBox();
            this.soyadTBox = new System.Windows.Forms.TextBox();
            this.kayitB = new System.Windows.Forms.Button();
            this.adL = new System.Windows.Forms.Label();
            this.soyadL = new System.Windows.Forms.Label();
            this.bolumCBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sRBox = new System.Windows.Forms.RadioButton();
            this.pRBox = new System.Windows.Forms.RadioButton();
            this.gun2RBox = new System.Windows.Forms.RadioButton();
            this.gun1RBox = new System.Windows.Forms.RadioButton();
            this.bolumL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saat2CBox = new System.Windows.Forms.ComboBox();
            this.saat1CBox = new System.Windows.Forms.ComboBox();
            this.doktorCBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kurumCBox = new System.Windows.Forms.ComboBox();
            this.kurumL = new System.Windows.Forms.Label();
            this.servisCBox = new System.Windows.Forms.ComboBox();
            this.katL = new System.Windows.Forms.Label();
            this.odaCBox = new System.Windows.Forms.ComboBox();
            this.odaL = new System.Windows.Forms.Label();
            this.saat1L = new System.Windows.Forms.Label();
            this.saat2L = new System.Windows.Forms.Label();
            this.doktorL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // adTBox
            // 
            this.adTBox.Location = new System.Drawing.Point(9, 32);
            this.adTBox.Name = "adTBox";
            this.adTBox.Size = new System.Drawing.Size(121, 20);
            this.adTBox.TabIndex = 0;
            // 
            // soyadTBox
            // 
            this.soyadTBox.Location = new System.Drawing.Point(155, 32);
            this.soyadTBox.Name = "soyadTBox";
            this.soyadTBox.Size = new System.Drawing.Size(121, 20);
            this.soyadTBox.TabIndex = 1;
            // 
            // kayitB
            // 
            this.kayitB.Location = new System.Drawing.Point(363, 433);
            this.kayitB.Name = "kayitB";
            this.kayitB.Size = new System.Drawing.Size(75, 23);
            this.kayitB.TabIndex = 2;
            this.kayitB.Text = "Kayıt Et";
            this.kayitB.UseVisualStyleBackColor = true;
            // 
            // adL
            // 
            this.adL.AutoSize = true;
            this.adL.Location = new System.Drawing.Point(6, 16);
            this.adL.Name = "adL";
            this.adL.Size = new System.Drawing.Size(25, 13);
            this.adL.TabIndex = 3;
            this.adL.Text = "İsim";
            this.adL.Click += new System.EventHandler(this.adL_Click);
            // 
            // soyadL
            // 
            this.soyadL.AutoSize = true;
            this.soyadL.Location = new System.Drawing.Point(152, 16);
            this.soyadL.Name = "soyadL";
            this.soyadL.Size = new System.Drawing.Size(42, 13);
            this.soyadL.TabIndex = 4;
            this.soyadL.Text = "Soyisim";
            // 
            // bolumCBox
            // 
            this.bolumCBox.FormattingEnabled = true;
            this.bolumCBox.Location = new System.Drawing.Point(9, 47);
            this.bolumCBox.Name = "bolumCBox";
            this.bolumCBox.Size = new System.Drawing.Size(121, 21);
            this.bolumCBox.TabIndex = 5;
            this.bolumCBox.SelectedIndexChanged += new System.EventHandler(this.bolumCBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kurumL);
            this.groupBox1.Controls.Add(this.kurumCBox);
            this.groupBox1.Controls.Add(this.sRBox);
            this.groupBox1.Controls.Add(this.pRBox);
            this.groupBox1.Controls.Add(this.adL);
            this.groupBox1.Controls.Add(this.adTBox);
            this.groupBox1.Controls.Add(this.soyadL);
            this.groupBox1.Controls.Add(this.soyadTBox);
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // sRBox
            // 
            this.sRBox.AutoSize = true;
            this.sRBox.Location = new System.Drawing.Point(155, 100);
            this.sRBox.Name = "sRBox";
            this.sRBox.Size = new System.Drawing.Size(54, 17);
            this.sRBox.TabIndex = 6;
            this.sRBox.TabStop = true;
            this.sRBox.Text = "Servis";
            this.sRBox.UseVisualStyleBackColor = true;
            this.sRBox.CheckedChanged += new System.EventHandler(this.sRBox_CheckedChanged);
            // 
            // pRBox
            // 
            this.pRBox.AutoSize = true;
            this.pRBox.Location = new System.Drawing.Point(9, 100);
            this.pRBox.Name = "pRBox";
            this.pRBox.Size = new System.Drawing.Size(56, 17);
            this.pRBox.TabIndex = 5;
            this.pRBox.TabStop = true;
            this.pRBox.Text = "Polinik";
            this.pRBox.UseVisualStyleBackColor = true;
            this.pRBox.CheckedChanged += new System.EventHandler(this.pRBox_CheckedChanged);
            // 
            // gun2RBox
            // 
            this.gun2RBox.AutoSize = true;
            this.gun2RBox.Location = new System.Drawing.Point(155, 122);
            this.gun2RBox.Name = "gun2RBox";
            this.gun2RBox.Size = new System.Drawing.Size(49, 17);
            this.gun2RBox.TabIndex = 6;
            this.gun2RBox.Text = "Yarın";
            this.gun2RBox.UseVisualStyleBackColor = true;
            this.gun2RBox.CheckedChanged += new System.EventHandler(this.gun2RBox_CheckedChanged);
            // 
            // gun1RBox
            // 
            this.gun1RBox.AutoSize = true;
            this.gun1RBox.Checked = true;
            this.gun1RBox.Location = new System.Drawing.Point(9, 122);
            this.gun1RBox.Name = "gun1RBox";
            this.gun1RBox.Size = new System.Drawing.Size(56, 17);
            this.gun1RBox.TabIndex = 5;
            this.gun1RBox.TabStop = true;
            this.gun1RBox.Text = "Bugün";
            this.gun1RBox.UseVisualStyleBackColor = true;
            // 
            // bolumL
            // 
            this.bolumL.AutoSize = true;
            this.bolumL.Location = new System.Drawing.Point(6, 31);
            this.bolumL.Name = "bolumL";
            this.bolumL.Size = new System.Drawing.Size(47, 13);
            this.bolumL.TabIndex = 6;
            this.bolumL.Text = "Bölümler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doktorL);
            this.groupBox2.Controls.Add(this.saat2L);
            this.groupBox2.Controls.Add(this.saat1L);
            this.groupBox2.Controls.Add(this.gun2RBox);
            this.groupBox2.Controls.Add(this.saat2CBox);
            this.groupBox2.Controls.Add(this.gun1RBox);
            this.groupBox2.Controls.Add(this.saat1CBox);
            this.groupBox2.Controls.Add(this.doktorCBox);
            this.groupBox2.Controls.Add(this.bolumL);
            this.groupBox2.Controls.Add(this.bolumCBox);
            this.groupBox2.Location = new System.Drawing.Point(38, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 145);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polikinik";
            // 
            // saat2CBox
            // 
            this.saat2CBox.Enabled = false;
            this.saat2CBox.FormattingEnabled = true;
            this.saat2CBox.Location = new System.Drawing.Point(155, 87);
            this.saat2CBox.Name = "saat2CBox";
            this.saat2CBox.Size = new System.Drawing.Size(121, 21);
            this.saat2CBox.TabIndex = 9;
            // 
            // saat1CBox
            // 
            this.saat1CBox.Enabled = false;
            this.saat1CBox.FormattingEnabled = true;
            this.saat1CBox.Location = new System.Drawing.Point(9, 87);
            this.saat1CBox.Name = "saat1CBox";
            this.saat1CBox.Size = new System.Drawing.Size(121, 21);
            this.saat1CBox.TabIndex = 8;
            this.saat1CBox.SelectedIndexChanged += new System.EventHandler(this.saat1CBox_SelectedIndexChanged);
            // 
            // doktorCBox
            // 
            this.doktorCBox.Enabled = false;
            this.doktorCBox.FormattingEnabled = true;
            this.doktorCBox.Location = new System.Drawing.Point(155, 47);
            this.doktorCBox.Name = "doktorCBox";
            this.doktorCBox.Size = new System.Drawing.Size(121, 21);
            this.doktorCBox.TabIndex = 7;
            this.doktorCBox.SelectedIndexChanged += new System.EventHandler(this.doktorCBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.odaL);
            this.groupBox3.Controls.Add(this.odaCBox);
            this.groupBox3.Controls.Add(this.katL);
            this.groupBox3.Controls.Add(this.servisCBox);
            this.groupBox3.Location = new System.Drawing.Point(38, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 115);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servis";
            // 
            // kurumCBox
            // 
            this.kurumCBox.FormattingEnabled = true;
            this.kurumCBox.Items.AddRange(new object[] {
            "SSK",
            "Bağkur",
            "Emekli Sandığı"});
            this.kurumCBox.Location = new System.Drawing.Point(9, 73);
            this.kurumCBox.Name = "kurumCBox";
            this.kurumCBox.Size = new System.Drawing.Size(121, 21);
            this.kurumCBox.TabIndex = 7;
            // 
            // kurumL
            // 
            this.kurumL.AutoSize = true;
            this.kurumL.Location = new System.Drawing.Point(6, 57);
            this.kurumL.Name = "kurumL";
            this.kurumL.Size = new System.Drawing.Size(86, 13);
            this.kurumL.TabIndex = 8;
            this.kurumL.Text = "Anllaşmalı Kurum";
            // 
            // servisCBox
            // 
            this.servisCBox.FormattingEnabled = true;
            this.servisCBox.Location = new System.Drawing.Point(9, 19);
            this.servisCBox.Name = "servisCBox";
            this.servisCBox.Size = new System.Drawing.Size(121, 21);
            this.servisCBox.TabIndex = 0;
            this.servisCBox.SelectedIndexChanged += new System.EventHandler(this.servisCBox_SelectedIndexChanged);
            // 
            // katL
            // 
            this.katL.AutoSize = true;
            this.katL.Location = new System.Drawing.Point(152, 22);
            this.katL.Name = "katL";
            this.katL.Size = new System.Drawing.Size(32, 13);
            this.katL.TabIndex = 1;
            this.katL.Text = "Kat =";
            // 
            // odaCBox
            // 
            this.odaCBox.Enabled = false;
            this.odaCBox.FormattingEnabled = true;
            this.odaCBox.Location = new System.Drawing.Point(9, 68);
            this.odaCBox.Name = "odaCBox";
            this.odaCBox.Size = new System.Drawing.Size(121, 21);
            this.odaCBox.TabIndex = 2;
            this.odaCBox.SelectedIndexChanged += new System.EventHandler(this.odaCBox_SelectedIndexChanged);
            // 
            // odaL
            // 
            this.odaL.AutoSize = true;
            this.odaL.Location = new System.Drawing.Point(6, 52);
            this.odaL.Name = "odaL";
            this.odaL.Size = new System.Drawing.Size(74, 13);
            this.odaL.TabIndex = 3;
            this.odaL.Text = "Oda Numarası";
            // 
            // saat1L
            // 
            this.saat1L.AutoSize = true;
            this.saat1L.Location = new System.Drawing.Point(6, 71);
            this.saat1L.Name = "saat1L";
            this.saat1L.Size = new System.Drawing.Size(60, 13);
            this.saat1L.TabIndex = 10;
            this.saat1L.Text = "Saat Aralığı";
            // 
            // saat2L
            // 
            this.saat2L.AutoSize = true;
            this.saat2L.Location = new System.Drawing.Point(153, 71);
            this.saat2L.Name = "saat2L";
            this.saat2L.Size = new System.Drawing.Size(41, 13);
            this.saat2L.TabIndex = 11;
            this.saat2L.Text = "Dakika";
            // 
            // doktorL
            // 
            this.doktorL.AutoSize = true;
            this.doktorL.Location = new System.Drawing.Point(155, 30);
            this.doktorL.Name = "doktorL";
            this.doktorL.Size = new System.Drawing.Size(39, 13);
            this.doktorL.TabIndex = 12;
            this.doktorL.Text = "Doktor";
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kayitB);
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adTBox;
        private System.Windows.Forms.TextBox soyadTBox;
        private System.Windows.Forms.Button kayitB;
        private System.Windows.Forms.Label adL;
        private System.Windows.Forms.Label soyadL;
        private System.Windows.Forms.ComboBox bolumCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bolumL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox saat2CBox;
        private System.Windows.Forms.ComboBox saat1CBox;
        private System.Windows.Forms.ComboBox doktorCBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton gun2RBox;
        private System.Windows.Forms.RadioButton gun1RBox;
        private System.Windows.Forms.RadioButton sRBox;
        private System.Windows.Forms.RadioButton pRBox;
        private System.Windows.Forms.Label kurumL;
        private System.Windows.Forms.ComboBox kurumCBox;
        private System.Windows.Forms.ComboBox servisCBox;
        private System.Windows.Forms.Label katL;
        private System.Windows.Forms.ComboBox odaCBox;
        private System.Windows.Forms.Label odaL;
        private System.Windows.Forms.Label saat1L;
        private System.Windows.Forms.Label saat2L;
        private System.Windows.Forms.Label doktorL;
    }
}