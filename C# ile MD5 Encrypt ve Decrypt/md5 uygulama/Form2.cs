using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md5_uygulama
{
    public partial class Form2 : Form
    {
        //İlk önce basit bir wordlist oluşturuyoruz
        string[] şifreli_mesaj = {

            "21232f297a57a5a743894a0e4a801fc3",
            "827ccb0eea8a706c4c34a16891f84e7b",
            "d8578edf8458ce06fbc5bb76a58c5ca4",
            "0192023a7bbd73250516f069df18b500",
            "5f4dcc3b5aa765d61d8327deb882cf99"

        };
        string[] mesajlar =
        {
            "admin",
            "12345",
            "qwerty",
            "admin123",
            "password"
        };

        public Form2()
        {
            InitializeComponent();           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Burdaki amaç daha önce şifrelenmiş mesajlarla bir eşleşme yakalamaya çalışıyoruz
            //Eğer yakalarsak şifreli metini çözmüş oluyoruz

            string mesaj = textBox1.Text;        
            for (int i=0;i<5;i++)
            {
                if(mesaj==şifreli_mesaj[i])
                {
                    textBox2.Text = mesajlar[i];
                    break;
                }                         
            }

            //Eğer şifre çözülmedi ise bu blok çalışıyor
            if(textBox2.Text=="")
            {
                MessageBox.Show("Şifre Çözülemedi");
            }
        }      
    }
}
