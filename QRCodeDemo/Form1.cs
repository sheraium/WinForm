using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QRCodeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrCoder = new QRCodeGenerator();
            var myData = qrCoder.CreateQrCode(txtQR.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(myData);
            pictureBox1.Image = code.GetGraphic(50);
        }
    }
}
