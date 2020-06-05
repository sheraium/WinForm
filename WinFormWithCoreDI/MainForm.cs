using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWithCoreDI
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly HttpClient _httpClient;

        public MainForm(IServiceProvider serviceProvider, IHttpClientFactory httpClientFactory)
        {
            _serviceProvider = serviceProvider;
            _httpClient = httpClientFactory.CreateClient();
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var result = await _httpClient.GetStringAsync("https://www.google.com");
            await Task.Delay(3000);
            textBox1.Text = result;
        }
    }
}