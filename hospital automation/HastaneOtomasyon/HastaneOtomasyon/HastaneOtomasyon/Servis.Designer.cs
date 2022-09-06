namespace HastaneOtomasyon
{
    partial class Servis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servisCBox = new System.Windows.Forms.ComboBox();
            this.veriTabaniDataSet2 = new HastaneOtomasyon.VeriTabaniDataSet();
            this.veriTabaniDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolulukL = new System.Windows.Forms.Label();
            this.oranL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oranL);
            this.groupBox1.Controls.Add(this.dolulukL);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servis Bilgiler";
            // 
            // servisCBox
            // 
            this.servisCBox.FormattingEnabled = true;
            this.servisCBox.Location = new System.Drawing.Point(12, 26);
            this.servisCBox.Name = "servisCBox";
            this.servisCBox.Size = new System.Drawing.Size(121, 21);
            this.servisCBox.TabIndex = 1;
            this.servisCBox.SelectedIndexChanged += new System.EventHandler(this.servisCBox_SelectedIndexChanged);
            // 
            // veriTabaniDataSet2
            // 
            this.veriTabaniDataSet2.DataSetName = "VeriTabaniDataSet";
            this.veriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veriTabaniDataSet2BindingSource
            // 
            this.veriTabaniDataSet2BindingSource.DataSource = this.veriTabaniDataSet2;
            this.veriTabaniDataSet2BindingSource.Position = 0;
            // 
            // dolulukL
            // 
            this.dolulukL.AutoSize = true;
            this.dolulukL.Location = new System.Drawing.Point(6, 208);
            this.dolulukL.Name = "dolulukL";
            this.dolulukL.Size = new System.Drawing.Size(71, 13);
            this.dolulukL.TabIndex = 0;
            this.dolulukL.Text = "Doluluk Oranı";
            // 
            // oranL
            // 
            this.oranL.AutoSize = true;
            this.oranL.Location = new System.Drawing.Point(6, 221);
            this.oranL.Name = "oranL";
            this.oranL.Size = new System.Drawing.Size(20, 13);
            this.oranL.TabIndex = 1;
            this.oranL.Text = "x%";
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 335);
            this.Controls.Add(this.servisCBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Servis";
            this.Text = "Servis";
            this.Load += new System.EventHandler(this.Servis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox servisCBox;
        private VeriTabaniDataSet veriTabaniDataSet;
        private VeriTabaniDataSet veriTabaniDataSet1;
        private VeriTabaniDataSetTableAdapters.PolikilinikTableAdapter polikilinikTableAdapter;
        private VeriTabaniDataSetTableAdapters.HastaTableAdapter hastaTableAdapter;
        private VeriTabaniDataSet veriTabaniDataSet2;
        private System.Windows.Forms.BindingSource veriTabaniDataSet2BindingSource;
        private System.Windows.Forms.Label oranL;
        private System.Windows.Forms.Label dolulukL;
    }
}