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

        public Storage SelectedStorage { get; set; }

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

        private void getStoragesBtn_Click(object sender, EventArgs e)
        {
            var storages = GetStoragesAsync($"Storage/GetStorages/").GetAwaiter().GetResult();

            storageListDgv.DataSource = null;
            storageListDgv.DataSource = storages;
            storageListDgv.Visible = true;
            this.storageListDgv.Columns[0].HeaderText = "Storage ID";
            this.storageListDgv.Columns[1].HeaderText = "Storage Name";
            this.storageListDgv.Columns[1].HeaderText = "Kind Of Storage";

            foreach (DataGridViewRow item in storageListDgv.Rows)
            {
                item.Cells["StorageId"].ReadOnly = false;
                item.Cells["StorageName"].ReadOnly = false;
                item.Cells["KindOfStorage"].ReadOnly = false;
            }

            storageListDgv.ClearSelection();
        }

        private void storageListDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (storageListDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow storageRow = storageListDgv.SelectedRows[0];
                var foundStorage = storageRow.DataBoundItem as Storage;
                SelectedStorage = foundStorage;

                storageCreateBtn.Enabled = false;
                storageUpdateBtn.Enabled = true;
                storageDeleteBtn.Enabled = true;
            }
            else
            {
                storageCreateBtn.Enabled = true;
                storageUpdateBtn.Enabled = false;
                storageDeleteBtn.Enabled = false;
            }
        }

        private void storageCreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputWindow = new CRUDStoragesForm();
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void storageUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SelectedStorage == null)
            {
                return;
            }

            try
            {
                var inputWindow = new CRUDStoragesForm(SelectedStorage.StorageId, SelectedStorage.StorageName, SelectedStorage.KindOfStorage);
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void storageDeleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedStorage == null)
            {
                return;
            }

            try
            {
                var inputWindow = new CRUDStoragesForm(SelectedStorage.StorageId, SelectedStorage.StorageName, SelectedStorage.KindOfStorage);
                inputWindow.Initialize(this.client);
                inputWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void storageClearSelectionstorageClearSelection_Click(object sender, EventArgs e)
        {
            storageListDgv.ClearSelection();
        }
    }
}
