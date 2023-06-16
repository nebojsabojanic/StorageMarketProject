using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageMarket
{
    public partial class ManageProducts : Form
    {
        private HttpClient client;

        public Product SelectedProduct { get; set; }

        public ManageProducts()
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

            /*using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage response = await client.GetAsync(new Uri("https://localhost:7038/Product/GetProducts/")).ConfigureAwait(false))
                    {
                        using (HttpContent content = response.Content)
                        {
                            // need these to return to Form for display
                            string result = await content.ReadAsStringAsync();
                            string reasonPhrase = response.ReasonPhrase;
                            HttpResponseHeaders headers = response.Headers;
                            HttpStatusCode code = response.StatusCode;
                        }
                    }
                }
                catch (Exception ex)
                {
                // need to return ex.message for display.
                }
                return null;
            }*/
        }

        private void getProductsBtn_Click(object sender, EventArgs e)
        {
            var products = GetProductsAsync($"Product/GetProducts/").GetAwaiter().GetResult();

            productListDgv.DataSource = null;
            productListDgv.DataSource = products;
            productListDgv.Visible = true;
            this.productListDgv.Columns[0].HeaderText = "Product ID";
            this.productListDgv.Columns[1].HeaderText = "Product Name";
            this.productListDgv.Columns[1].HeaderText = "Product Cost";

            foreach (DataGridViewRow item in productListDgv.Rows)
            {
                item.Cells["ProductId"].ReadOnly = false;
                item.Cells["ProductName"].ReadOnly = false;
                item.Cells["ProductCost"].ReadOnly = false;
            }

            productListDgv.ClearSelection();
        }

        private async Task<List<Product>> CreateProductsAsync(string path, Product product)
        {
            /*var stringContent2 = new StringContent(product.ToString());
            var response2 = await this.client.PostAsync("http://www.sample.com/write", stringContent2);*/

            var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response2 = await this.client.PostAsync("http://www.sample.com/write", stringContent);

            HttpResponseMessage response = await this.client.PostAsync(path, stringContent).ConfigureAwait(false);
            
            if (response.IsSuccessStatusCode)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(stringContent);
            }

            return products;
        }

        private void productListDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (productListDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow productRow = productListDgv.SelectedRows[0];
                var foundProduct = productRow.DataBoundItem as Product;
                SelectedProduct = foundProduct;

                productCreateBtn.Enabled = false;
                productUpdateBtn.Enabled = true;
                productDeleteBtn.Enabled = true;
            }
            else
            {
                productCreateBtn.Enabled = true;
                productUpdateBtn.Enabled = false;
                productDeleteBtn.Enabled = false;
            }
        }

        private void productCreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputWindow = new CRUDProductsForm();
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null)
            {
                return;
            }

            try
            {
                var inputWindow = new CRUDProductsForm(SelectedProduct.ProductId, SelectedProduct.ProductName, SelectedProduct.ProductCost);
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productDeleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null)
            {
                return;
            }

            try
            {
                var inputWindow = new CRUDProductsForm(SelectedProduct.ProductId, SelectedProduct.ProductName, SelectedProduct.ProductCost);
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productClearSelection_Click(object sender, EventArgs e)
        {
            productListDgv.ClearSelection();
        }
    }
}
