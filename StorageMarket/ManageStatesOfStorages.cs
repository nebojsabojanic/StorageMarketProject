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
    public partial class ManageStatesOfStorages : Form
    {
        private HttpClient client;

        public ManageStatesOfStorages()
        {
            InitializeComponent();
        }

        public void Initialize(HttpClient client)
        {
            this.client = client;
        }

        private async Task<List<StateOfStorage>> GetStatesOfStoragesAsync(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path).ConfigureAwait(false);
            List<StateOfStorage> stateOfStorages = new List<StateOfStorage>();
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                stateOfStorages = JsonConvert.DeserializeObject<List<StateOfStorage>>(stringContent);
            }
            return stateOfStorages;
        }

        private void getStatesOfStoragesBtn_Click(object sender, EventArgs e)
        {
            var statesOfStorages = GetStatesOfStoragesAsync($"StateOfStorage/GetStateOfStorages/").GetAwaiter().GetResult();
        }
    }
}
