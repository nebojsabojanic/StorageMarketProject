using Newtonsoft.Json;
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

namespace StorageMarket
{
    public partial class ManageStorages : Form
    {
        private HttpClient client;

        public ManageStorages()
        {
            InitializeComponent();
        }

        public void Initialize(HttpClient client)
        {
            this.client = client;
        }

        private async Task<List<Storage>> GetStoragesAsync(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path).ConfigureAwait(false);
            List<Storage> storages = new List<Storage>();
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                storages = JsonConvert.DeserializeObject<List<Storage>>(stringContent);
            }
            return storages;
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        { }

        private void getStoragesBtn_Click(object sender, EventArgs e)
        {
            var storages = GetStoragesAsync($"Storage/GetStorages/").GetAwaiter().GetResult();
        }
    }
}
