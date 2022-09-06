using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HastaneOtomasyon
{
    public partial class RandevuAl : Form
    {
        int[] bolum = new int[20];

        int[] saat1 = new int[20];
        
        int[] doktor = new int[20];

        int[] servis = new int[20];

        int[] kat = new int[20];

        public RandevuAl()
        {
            InitializeComponent();
            veriCek();
            servisVeri();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void veriCek()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,Bolum FROM Polikilinik ", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();
            int i=0;
            while (dr.Read())
            {

                bolumCBox.Items.Add(dr["Bolum"]);
               bolum[i] = Convert.ToInt32(dr["ID"]);
               i++;

            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private void adL_Click(object sender, EventArgs e)
        {

        }

        private void bolumCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCBox.Items.Clear();
            doktorCBox.ResetText();
            doktorCBox.Enabled = true;
            doktorVeri();
            saat1CBox.Enabled = false;
            saat2CBox.Enabled = false;
            saat1CBox.Items.Clear();
            saat1CBox.ResetText();
            saat2CBox.Items.Clear();
            saat2CBox.ResetText();
        }

        private void doktorCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saat1CBox.Items.Clear();
            saat1CBox.ResetText();
            saat1CBox.Enabled = true;
            saat1Veri();
            saat2CBox.Enabled = false;
        }

        private void saat1Veri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,a9,a10,a11,a13,a14,a15,a16 FROM Doktorlar", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();
          
            while (dr.Read())
            {
                if (doktor[doktorCBox.SelectedIndex] == Convert.ToInt32(dr["ID"]))
                {
                   
                    int y = 9;
                    string x;
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == 3)
                            y++;
                        x=dr["a"+(y+i)].ToString();


                        if (kontrol(x))
                        {
                            saat1CBox.Items.Add(i + y);
                            
                        }
                    }
                }
            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private Boolean kontrol(string a)
        {
            int i=0;
            if (gun1RBox.Checked)
                i = 0;
            else if (gun2RBox.Checked)
                i = 6;
            
            bool dondur=false;
            for (int j = i; j < i + 6; j++)
            {
               if (a[j].Equals('0'))
                    dondur = true;
              

            }
            return dondur;
        }

        private void saat2Veri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,a9,a10,a11,a13,a14,a15,a16 FROM Doktorlar", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                if (doktor[doktorCBox.SelectedIndex] == Convert.ToInt32(dr["ID"]))
                {
                    string b=saat1CBox.SelectedItem.ToString();
                    
                    string x;
                    x = dr["a" + b].ToString();

                    int i=0;

                    if (gun1RBox.Checked)
                        i = 0;
                    else if (gun2RBox.Checked)
                        i = 6;

                    int dk = 0;

                    for (int j = i; j < i+ 6; j++)
                    {
                       

                       if (x[j].Equals('0'))
                            if(j!=0)
                            saat2CBox.Items.Add(dk);
                      else
                                saat2CBox.Items.Add("00");

                        dk += 10;
                    }
                }
            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private void doktorVeri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,İsim,Bölüm FROM Doktorlar ", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();
            int i=0;
            while (dr.Read())
            {
                if (bolum[bolumCBox.SelectedIndex] == Convert.ToInt32(dr["Bölüm"]))
                {
                    doktorCBox.Items.Add(dr["İsim"]);
                    doktor[i] = Convert.ToInt32(dr["ID"]);
                    i++;
                }
            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private void saat1CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saat2CBox.Items.Clear();
            saat2CBox.ResetText();
            saat2CBox.Enabled = true;
            saat2Veri();

        }

        private void gun2RBox_CheckedChanged(object sender, EventArgs e)
        {
            bolumCBox.ResetText();
            doktorCBox.Items.Clear();
            doktorCBox.ResetText();
            doktorCBox.Enabled = false;
            saat1CBox.Enabled = false;
            saat2CBox.Enabled = false;
            saat1CBox.Items.Clear();
            saat1CBox.ResetText();
            saat2CBox.Items.Clear();
            saat2CBox.ResetText();
        }

        

        private void sRBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sRBox.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
            else if (pRBox.Checked)
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = true; 
            }
        }

        private void pRBox_CheckedChanged(object sender, EventArgs e)
        {
            sRBox_CheckedChanged(sender, e);
        }

        private void servisCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            odaCBox.ResetText();
            odaCBox.Items.Clear();
            katL.Text = "Kat= " + kat[servisCBox.SelectedIndex];
            odaCBox.Enabled = true;
            odaVeri();
        }

        private void odaVeri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,Durum,Kat FROM Servis", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                if (servis[servisCBox.SelectedIndex] == Convert.ToInt32(dr["ID"]))
                {
                   
                    string x,k;
                    x = dr["Durum"].ToString();
                    k = dr["Kat"].ToString();
                  


                    for (int j = 0; j < 10; j++)
                    {


                        if (x[j].Equals('0'))
                            if(j!=9)
                           odaCBox.Items.Add(k+"0"+(j+1));
                            else
                            odaCBox.Items.Add(k + (j+1));

                    }
                }
            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private void servisVeri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,Servis,Kat FROM Servis ", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {

                servisCBox.Items.Add(dr["Servis"]);
                servis[i] = Convert.ToInt32(dr["ID"]);
                kat[i] = Convert.ToInt32(dr["Kat"]);
                i++;

            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        private void odaCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

      
    }
}
