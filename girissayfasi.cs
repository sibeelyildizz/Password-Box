using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;//mail gönderme için eklendi

namespace Password_Box
{
    public partial class girissayfasi : Form
    {
        public girissayfasi()
        {
            InitializeComponent();
        }
        int sayi = 10;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = false;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi >= 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                int sayac = sayi--;
                label5.Text = sayac.ToString();
            }
            if (sayi < 0)
            {
                // MessageBox.Show("Error");
                // button1.Enabled = false;
            }
        }

        private void KodUret_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();   //e posta gonderme protokolu
            istemci.Credentials = new System.Net.NetworkCredential("faciyya61@hotmail.com", "yazilim61");    //kimlik belirleme  credential ile
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";  //sunucu ağı
            istemci.EnableSsl = true;
            mesajım.To.Add(textBox3.Text);
            mesajım.From = new MailAddress("faciyya61@hotmail.com");
            Random rnd = new Random();
            textBox4.Text = rnd.Next(100000, 999999) + "";
            mesajım.Body = textBox4.Text;
            istemci.Send(mesajım);
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 10000;
           

        }

        private void Giris_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == textBox2.Text)
            {
                if (sayi >= 0)
                {
                    hesapsecme form2 = new hesapsecme();
                    this.Hide();
                    form2.Show();
                }
            }
            if (textBox4.Text != textBox2.Text)
            {
                MessageBox.Show("hatalı kod");
            }
            if (sayi < 0)
            {
                MessageBox.Show("zaman aşımı");

            }


        }

        private void Kayıtol_Click(object sender, EventArgs e)
        {

            Form3 yeni = new Form3();
            this.Hide();
            yeni.Show();
        }
    }
}
