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
    public partial class Depo : Form
    {
        public Depo()
        {
            InitializeComponent();
            
        }

       

        private void gondericiCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aliciCBox.Enabled = true;
            
        }

        private void aliciCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilacCBox.Enabled = true;
            malzemeVeri();
        }

        private void ilacCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void malzemeVeri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT ID,Urun FROM Depo WHERE Yer="+gondericiCBox.SelectedIndex+" ", baglanti);

            OleDbDataReader dr;

            dr = komut.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {

                ilacCBox.Items.Add(dr["Urun"]);
               

            }

            baglanti.Close();

            dr.Dispose();

            dr.Close();
        }
    }
}
