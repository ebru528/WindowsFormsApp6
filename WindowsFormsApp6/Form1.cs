using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbotobüs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbotobüs.Text)
            {
                case "Travego": koltukdoldur ( 8, false );
                    break;
                case "Setra": koltukdoldur (12,true );
                    break;
                case "Neoplan": koltukdoldur( 10,false);
                    break;
            }
            void koltukdoldur(int sıra,bool arkabeslimi)
            {
                yavaslat:
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is Button)
                    {
                        Button  btn=ctrl as Button;
                        if(btn.Text=="kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }

                    }
                }
                int koltukno = 1;
                for (int i = 0; i < sıra; i++)
                {
                    for(int j=0;j<5;j++)
                    {
                        if(arkabeslimi==true)
                        {
                            if(i !=sıra-1 && j==2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                                continue;
                        }
                        
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukno.ToString();
                        koltukno++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);  
                       
                    }
                }

            }
        }
        Button tıklanan;

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tıklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cmbotobüs.SelectedIndex==-1 || cmbnerede.SelectedIndex==-1||cmbnereye.SelectedIndex==-1)
            {
                MessageBox.Show("lütfen gerekli alanı doldurunuz");
                    return;
            }
            kayıtformu kf = new kayıtformu();
            DialogResult sonuc=kf.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0}{1}", kf.txtisim.Text, kf.txtsoyisim.Text);
                lvi.SubItems.Add(kf.masketelefon.Text);
                if(kf.rdbbay.Checked)
                {
                    lvi.SubItems.Add("bay");
                    tıklanan.BackColor = Color.Blue;
                }
                if(kf.rdbbayan.Checked)
                {
                    lvi.SubItems.Add("bayan");
                    tıklanan.BackColor = Color.Red;
                }
                lvi.SubItems.Add(cmbnerede.Text);
                lvi.SubItems.Add(cmbnereye.Text);
                lvi.SubItems.Add(tıklanan.Text);
                lvi.SubItems.Add(dtptarih.Text);
                lvi.SubItems.Add(nudfiyat.Value.ToString());
                listView1.Items.Add(lvi);
                
            }

        }
    }
}
