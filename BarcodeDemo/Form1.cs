using System;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var barCode = textBox1.Text;
            try
            {
                var brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barCode, 60);
            }
            catch (Exception)
            {
            }
        }
    }
}