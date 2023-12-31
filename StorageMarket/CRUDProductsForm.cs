﻿using Newtonsoft.Json;
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
        private int productId;
        private string productName;
        private decimal? productCost;

        public CRUDProductsForm()
        {
            InitializeComponent();
        }

        public CRUDProductsForm(int productId, string productName, decimal? productCost)
        {
            InitializeComponent();

            txtProductId.Text = productId.ToString();
            txtProductName.Text = productName.Trim();
            txtProductCost.Text = productCost.ToString();
        }

        public void Initialize(HttpClient client)
        {
            this.client = client;
        }

        /*private async Task<List<Product>> GetProductsAsync(string path)
        {
            HttpResponseMessage response = await this.client.GetAsync(path).ConfigureAwait(false);
            List<Product> products = new List<Product>();
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(stringContent);
            }
            return products;
        }*/

        private void cancelFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitFormBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
