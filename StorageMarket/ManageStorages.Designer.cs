namespace StorageMarket
{
    partial class ManageStorages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.storageListDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getStoragesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storageDeleteBtn = new System.Windows.Forms.Button();
            this.storageUpdateBtn = new System.Windows.Forms.Button();
            this.storageCreateBtn = new System.Windows.Forms.Button();
            this.storageClearSelectionstorageClearSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storageListDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageListDgv
            // 
            this.storageListDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storageListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageListDgv.Location = new System.Drawing.Point(6, 74);
            this.storageListDgv.Name = "storageListDgv";
            this.storageListDgv.Size = new System.Drawing.Size(544, 308);
            this.storageListDgv.TabIndex = 0;
            this.storageListDgv.SelectionChanged += new System.EventHandler(this.storageListDgv_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.storageClearSelectionstorageClearSelection);
            this.groupBox1.Controls.Add(this.getStoragesBtn);
            this.groupBox1.Controls.Add(this.storageListDgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Storages";
            // 
            // getStoragesBtn
            // 
            this.getStoragesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getStoragesBtn.Location = new System.Drawing.Point(450, 19);
            this.getStoragesBtn.Name = "getStoragesBtn";
            this.getStoragesBtn.Size = new System.Drawing.Size(100, 40);
            this.getStoragesBtn.TabIndex = 1;
            this.getStoragesBtn.Text = "List all storages";
            this.getStoragesBtn.UseVisualStyleBackColor = true;
            this.getStoragesBtn.Click += new System.EventHandler(this.getStoragesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.storageDeleteBtn);
            this.groupBox2.Controls.Add(this.storageUpdateBtn);
            this.groupBox2.Controls.Add(this.storageCreateBtn);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Storage Actions";
            // 
            // storageDeleteBtn
            // 
            this.storageDeleteBtn.Location = new System.Drawing.Point(6, 130);
            this.storageDeleteBtn.Name = "storageDeleteBtn";
            this.storageDeleteBtn.Size = new System.Drawing.Size(186, 40);
            this.storageDeleteBtn.TabIndex = 2;
            this.storageDeleteBtn.Text = "Delete";
            this.storageDeleteBtn.UseVisualStyleBackColor = true;
            this.storageDeleteBtn.Click += new System.EventHandler(this.storageDeleteBtn_Click);
            // 
            // storageUpdateBtn
            // 
            this.storageUpdateBtn.Location = new System.Drawing.Point(6, 74);
            this.storageUpdateBtn.Name = "storageUpdateBtn";
            this.storageUpdateBtn.Size = new System.Drawing.Size(186, 40);
            this.storageUpdateBtn.TabIndex = 1;
            this.storageUpdateBtn.Text = "Update";
            this.storageUpdateBtn.UseVisualStyleBackColor = true;
            this.storageUpdateBtn.Click += new System.EventHandler(this.storageUpdateBtn_Click);
            // 
            // storageCreateBtn
            // 
            this.storageCreateBtn.Location = new System.Drawing.Point(6, 19);
            this.storageCreateBtn.Name = "storageCreateBtn";
            this.storageCreateBtn.Size = new System.Drawing.Size(186, 40);
            this.storageCreateBtn.TabIndex = 0;
            this.storageCreateBtn.Text = "Create";
            this.storageCreateBtn.UseVisualStyleBackColor = true;
            this.storageCreateBtn.Click += new System.EventHandler(this.storageCreateBtn_Click);
            // 
            // storageClearSelectionstorageClearSelection
            // 
            this.storageClearSelectionstorageClearSelection.Location = new System.Drawing.Point(450, 388);
            this.storageClearSelectionstorageClearSelection.Name = "storageClearSelectionstorageClearSelection";
            this.storageClearSelectionstorageClearSelection.Size = new System.Drawing.Size(99, 23);
            this.storageClearSelectionstorageClearSelection.TabIndex = 2;
            this.storageClearSelectionstorageClearSelection.Text = "Clear Selection";
            this.storageClearSelectionstorageClearSelection.UseVisualStyleBackColor = true;
            this.storageClearSelectionstorageClearSelection.Click += new System.EventHandler(this.storageClearSelectionstorageClearSelection_Click);
            // 
            // ManageStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ManageStorages";
            this.Text = "ManageStorages";
            ((System.ComponentModel.ISupportInitialize)(this.storageListDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storageListDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button storageDeleteBtn;
        private System.Windows.Forms.Button storageUpdateBtn;
        private System.Windows.Forms.Button storageCreateBtn;
        private System.Windows.Forms.Button getStoragesBtn;
        private System.Windows.Forms.Button storageClearSelectionstorageClearSelection;
    }
}