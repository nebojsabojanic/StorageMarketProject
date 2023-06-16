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
    public partial class CRUDStoragesForm : Form
    {
        private HttpClient client;
        private int storageId;
        private string storageName;
        private string kindOfStorage;

        public CRUDStoragesForm()
        {
            InitializeComponent();
        }

        public CRUDStoragesForm(int storageId, string storageName, string kindOfStorage)
        {
            InitializeComponent();

            txtStorageId.Text = storageId.ToString();
            txtStorageName.Text = storageName.Trim();
            txtKindOfStorage.Text = kindOfStorage;
        }

        public void Initialize(HttpClient client)
        {
            this.client = client;
        }

        /*private async Task<List<Storage>> GetStoragesAsync(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path).ConfigureAwait(false);
            List<Storage> storages = new List<Storage>();
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                storages = JsonConvert.DeserializeObject<List<Storage>>(stringContent);
            }
            return storages;
        }*/

        private void closeStoragesCRUD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
