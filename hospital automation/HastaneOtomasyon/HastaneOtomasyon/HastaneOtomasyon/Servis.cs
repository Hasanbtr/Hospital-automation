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
    public partial class Servis : Form
    {
        int[] servis = new int[20];

        int[] kat = new int[20];

        public Servis()
        {
            InitializeComponent();
            servisVeri();
        }

        private void servisCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            oran();
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

        private void Servis_Load(object sender, EventArgs e)
        {
           

        }

        private void oran()
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

                    string x, k;
                    x = dr["Durum"].ToString();
                    k = dr["Kat"].ToString();

                    int dolu=0;

                    for (int j = 0; j < 10; j++)
                    {


                        if (x[j].Equals('1'))
                            dolu++;

                    }
                    int deger=(10*dolu);
                    oranL.Text = deger.ToString()+"%";
                }
            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }

        

    }
}
