namespace HastaneOtomasyon
{
    partial class Depo
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
            this.gondericiL = new System.Windows.Forms.Label();
            this.aliciL = new System.Windows.Forms.Label();
            this.adetUD = new System.Windows.Forms.DomainUpDown();
            this.adetL = new System.Windows.Forms.Label();
            this.gondericiCBox = new System.Windows.Forms.ComboBox();
            this.aliciCBox = new System.Windows.Forms.ComboBox();
            this.gmiktarL = new System.Windows.Forms.Label();
            this.ilacCBox = new System.Windows.Forms.ComboBox();
            this.ilacL = new System.Windows.Forms.Label();
            this.amiktarL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.amiktarL);
            this.groupBox1.Controls.Add(this.ilacL);
            this.groupBox1.Controls.Add(this.ilacCBox);
            this.groupBox1.Controls.Add(this.gmiktarL);
            this.groupBox1.Controls.Add(this.aliciCBox);
            this.groupBox1.Controls.Add(this.gondericiCBox);
            this.groupBox1.Controls.Add(this.adetL);
            this.groupBox1.Controls.Add(this.adetUD);
            this.groupBox1.Controls.Add(this.aliciL);
            this.groupBox1.Controls.Add(this.gondericiL);
            this.groupBox1.Location = new System.Drawing.Point(36, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depolar Arası Transfer";
            // 
            // gondericiL
            // 
            this.gondericiL.AutoSize = true;
            this.gondericiL.Location = new System.Drawing.Point(6, 28);
            this.gondericiL.Name = "gondericiL";
            this.gondericiL.Size = new System.Drawing.Size(81, 13);
            this.gondericiL.TabIndex = 0;
            this.gondericiL.Text = "Gönderici Depo";
            // 
            // aliciL
            // 
            this.aliciL.AutoSize = true;
            this.aliciL.Location = new System.Drawing.Point(191, 28);
            this.aliciL.Name = "aliciL";
            this.aliciL.Size = new System.Drawing.Size(55, 13);
            this.aliciL.TabIndex = 1;
            this.aliciL.Text = "Alıcı Depo";
            // 
            // adetUD
            // 
            this.adetUD.Location = new System.Drawing.Point(11, 170);
            this.adetUD.Name = "adetUD";
            this.adetUD.Size = new System.Drawing.Size(120, 20);
            this.adetUD.TabIndex = 2;
            this.adetUD.Text = "domainUpDown1";
            // 
            // adetL
            // 
            this.adetL.AutoSize = true;
            this.adetL.Location = new System.Drawing.Point(7, 154);
            this.adetL.Name = "adetL";
            this.adetL.Size = new System.Drawing.Size(80, 13);
            this.adetL.TabIndex = 3;
            this.adetL.Text = "Transfer Miktarı";
            // 
            // gondericiCBox
            // 
            this.gondericiCBox.FormattingEnabled = true;
            this.gondericiCBox.Items.AddRange(new object[] {
            "Poliklinik",
            "Servis",
            "Teknik",
            "Vezne"});
            this.gondericiCBox.Location = new System.Drawing.Point(10, 45);
            this.gondericiCBox.Name = "gondericiCBox";
            this.gondericiCBox.Size = new System.Drawing.Size(121, 21);
            this.gondericiCBox.TabIndex = 4;
            this.gondericiCBox.SelectedIndexChanged += new System.EventHandler(this.gondericiCBox_SelectedIndexChanged);
            // 
            // aliciCBox
            // 
            this.aliciCBox.Enabled = false;
            this.aliciCBox.FormattingEnabled = true;
            this.aliciCBox.Items.AddRange(new object[] {
            "Poliklinik",
            "Servis",
            "Teknik",
            "Vezne"});
            this.aliciCBox.Location = new System.Drawing.Point(194, 45);
            this.aliciCBox.Name = "aliciCBox";
            this.aliciCBox.Size = new System.Drawing.Size(121, 21);
            this.aliciCBox.TabIndex = 5;
            this.aliciCBox.SelectedIndexChanged += new System.EventHandler(this.aliciCBox_SelectedIndexChanged);
            // 
            // gmiktarL
            // 
            this.gmiktarL.AutoSize = true;
            this.gmiktarL.Location = new System.Drawing.Point(6, 129);
            this.gmiktarL.Name = "gmiktarL";
            this.gmiktarL.Size = new System.Drawing.Size(145, 13);
            this.gmiktarL.TabIndex = 6;
            this.gmiktarL.Text = "Gönderici Depodaki Miktar = ";
            // 
            // ilacCBox
            // 
            this.ilacCBox.Enabled = false;
            this.ilacCBox.FormattingEnabled = true;
            this.ilacCBox.Location = new System.Drawing.Point(101, 90);
            this.ilacCBox.Name = "ilacCBox";
            this.ilacCBox.Size = new System.Drawing.Size(121, 21);
            this.ilacCBox.TabIndex = 7;
            this.ilacCBox.SelectedIndexChanged += new System.EventHandler(this.ilacCBox_SelectedIndexChanged);
            // 
            // ilacL
            // 
            this.ilacL.AutoSize = true;
            this.ilacL.Location = new System.Drawing.Point(112, 74);
            this.ilacL.Name = "ilacL";
            this.ilacL.Size = new System.Drawing.Size(93, 13);
            this.ilacL.TabIndex = 8;
            this.ilacL.Text = "Malzemeyi Seçiniz";
            // 
            // amiktarL
            // 
            this.amiktarL.AutoSize = true;
            this.amiktarL.Location = new System.Drawing.Point(191, 129);
            this.amiktarL.Name = "amiktarL";
            this.amiktarL.Size = new System.Drawing.Size(119, 13);
            this.amiktarL.TabIndex = 9;
            this.amiktarL.Text = "Alıcı Depodaki Miktar = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Transfer Et";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "Depo";
            this.Text = "Depo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aliciL;
        private System.Windows.Forms.Label gondericiL;
        private System.Windows.Forms.Label adetL;
        private System.Windows.Forms.DomainUpDown adetUD;
        private System.Windows.Forms.ComboBox aliciCBox;
        private System.Windows.Forms.ComboBox gondericiCBox;
        private System.Windows.Forms.Label amiktarL;
        private System.Windows.Forms.Label ilacL;
        private System.Windows.Forms.ComboBox ilacCBox;
        private System.Windows.Forms.Label gmiktarL;
        private System.Windows.Forms.Button button1;
    }
}