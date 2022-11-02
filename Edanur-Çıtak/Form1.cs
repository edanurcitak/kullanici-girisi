using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Edanur_Çıtak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text == "edanur" && TxtSifre.Text == "1234")
            {
               
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
