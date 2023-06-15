using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageMarket
{
    public partial class MainScreen : Form
    {
        private HttpClient client = new HttpClient();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:7038/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void mngPrdctsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputWindow = new ManageProducts();
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mngStrgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputWindow = new ManageStorages();
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mngStOfStrgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputWindow = new ManageStatesOfStorages();
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
