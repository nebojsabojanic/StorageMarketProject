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
    public partial class CRUDProductsForm : Form
    {
        private HttpClient client;

        public CRUDProductsForm()
        {
            InitializeComponent();
        }

        public void Initialize(HttpClient client)
        {
            this.client = client;
        }

        private async Task<List<Product>> GetProductsAsync(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path).ConfigureAwait(false);
            List<Product> products = new List<Product>();
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(stringContent);
            }
            return products;
        }
    }
}
