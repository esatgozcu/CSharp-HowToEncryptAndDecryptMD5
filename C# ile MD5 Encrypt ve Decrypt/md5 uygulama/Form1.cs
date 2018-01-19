using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Şifreleme için kütüphaneleri ekleyelim
using System.Security.Cryptography;


namespace md5_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MD5 şifrelemesini yapacak sınıfı ekliyoruz
        public static string MD5Hash(string text)
        {           
            MD5 md5 = new MD5CryptoServiceProvider();

            //metnin boyutuna göre hash hesaplar
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //hesapladıktan sonra hashi alır
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //her baytı 2 hexadecimal hane olarak değiştirir
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = MD5Hash(textBox1.Text);
        }
    }
}
