namespace StorageMarket
{
    partial class ManageProducts
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
            this.productListDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.getSingleProductBtn = new System.Windows.Forms.Button();
            this.getProductsBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.productUpdateBtn = new System.Windows.Forms.Button();
            this.productCreateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productListDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productListDgv
            // 
            this.productListDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDgv.Location = new System.Drawing.Point(6, 74);
            this.productListDgv.Name = "productListDgv";
            this.productListDgv.Size = new System.Drawing.Size(544, 337);
            this.productListDgv.TabIndex = 0;
            this.productListDgv.SelectionChanged += new System.EventHandler(this.productListDgv_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.getSingleProductBtn);
            this.groupBox1.Controls.Add(this.getProductsBtn);
            this.groupBox1.Controls.Add(this.productListDgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(217, 19);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 40);
            this.txtProductId.TabIndex = 3;
            // 
            // getSingleProductBtn
            // 
            this.getSingleProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getSingleProductBtn.Location = new System.Drawing.Point(333, 19);
            this.getSingleProductBtn.Name = "getSingleProductBtn";
            this.getSingleProductBtn.Size = new System.Drawing.Size(100, 40);
            this.getSingleProductBtn.TabIndex = 2;
            this.getSingleProductBtn.Text = "Find product";
            this.getSingleProductBtn.UseVisualStyleBackColor = true;
            // 
            // getProductsBtn
            // 
            this.getProductsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getProductsBtn.Location = new System.Drawing.Point(450, 19);
            this.getProductsBtn.Name = "getProductsBtn";
            this.getProductsBtn.Size = new System.Drawing.Size(100, 40);
            this.getProductsBtn.TabIndex = 1;
            this.getProductsBtn.Text = "List all products";
            this.getProductsBtn.UseVisualStyleBackColor = true;
            this.getProductsBtn.Click += new System.EventHandler(this.getProductsBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.productDeleteBtn);
            this.groupBox2.Controls.Add(this.productUpdateBtn);
            this.groupBox2.Controls.Add(this.productCreateBtn);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Actions";
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.Location = new System.Drawing.Point(6, 130);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(186, 40);
            this.productDeleteBtn.TabIndex = 2;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // productUpdateBtn
            // 
            this.productUpdateBtn.Location = new System.Drawing.Point(6, 74);
            this.productUpdateBtn.Name = "productUpdateBtn";
            this.productUpdateBtn.Size = new System.Drawing.Size(186, 40);
            this.productUpdateBtn.TabIndex = 1;
            this.productUpdateBtn.Text = "Update";
            this.productUpdateBtn.UseVisualStyleBackColor = true;
            this.productUpdateBtn.Click += new System.EventHandler(this.productUpdateBtn_Click);
            // 
            // productCreateBtn
            // 
            this.productCreateBtn.Location = new System.Drawing.Point(6, 19);
            this.productCreateBtn.Name = "productCreateBtn";
            this.productCreateBtn.Size = new System.Drawing.Size(186, 40);
            this.productCreateBtn.TabIndex = 0;
            this.productCreateBtn.Text = "Create";
            this.productCreateBtn.UseVisualStyleBackColor = true;
            this.productCreateBtn.Click += new System.EventHandler(this.productCreateBtn_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            ((System.ComponentModel.ISupportInitialize)(this.productListDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productListDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button productDeleteBtn;
        private System.Windows.Forms.Button productUpdateBtn;
        private System.Windows.Forms.Button productCreateBtn;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button getSingleProductBtn;
        private System.Windows.Forms.Button getProductsBtn;
    }
}