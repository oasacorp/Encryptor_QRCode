using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor_QRCode
{
    public partial class Form1 : Form
    {
        public string tit, addr;
        public int ic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            tit = titleText.Text;
            addr = addrText.Text;
            ic = Convert.ToInt32(iconText.Text);
            string enc_text= DeSplit(tit, addr, ic);
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(enc_text,50);
            encText.Text = enc_text;
            Clipboard.SetText (enc_text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static string DeSplit(string title, string addr, int _icon)
        {
            string icon = _icon.ToString();
            string combinedText = title + "!" + addr + "!" + icon;
            string encryptString = Crypto.Encrypt(combinedText);
            return encryptString;
        }
    }
}
