namespace StorageMarket
{
    partial class ManageStatesOfStorages
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
            this.statesOfStoragesListDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStateOfStoragesId = new System.Windows.Forms.TextBox();
            this.getSingleSOSBtn = new System.Windows.Forms.Button();
            this.getStatesOfStoragesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sosDeleteBtn = new System.Windows.Forms.Button();
            this.sosUpdateBtn = new System.Windows.Forms.Button();
            this.sosCreateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statesOfStoragesListDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statesOfStoragesListDgv
            // 
            this.statesOfStoragesListDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statesOfStoragesListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesOfStoragesListDgv.Location = new System.Drawing.Point(6, 74);
            this.statesOfStoragesListDgv.Name = "statesOfStoragesListDgv";
            this.statesOfStoragesListDgv.Size = new System.Drawing.Size(544, 337);
            this.statesOfStoragesListDgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtStateOfStoragesId);
            this.groupBox1.Controls.Add(this.getSingleSOSBtn);
            this.groupBox1.Controls.Add(this.getStatesOfStoragesBtn);
            this.groupBox1.Controls.Add(this.statesOfStoragesListDgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "States Of Storages";
            // 
            // txtStateOfStoragesId
            // 
            this.txtStateOfStoragesId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStateOfStoragesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateOfStoragesId.Location = new System.Drawing.Point(217, 19);
            this.txtStateOfStoragesId.Name = "txtStateOfStoragesId";
            this.txtStateOfStoragesId.Size = new System.Drawing.Size(100, 40);
            this.txtStateOfStoragesId.TabIndex = 3;
            // 
            // getSingleSOSBtn
            // 
            this.getSingleSOSBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getSingleSOSBtn.Location = new System.Drawing.Point(333, 19);
            this.getSingleSOSBtn.Name = "getSingleSOSBtn";
            this.getSingleSOSBtn.Size = new System.Drawing.Size(100, 40);
            this.getSingleSOSBtn.TabIndex = 2;
            this.getSingleSOSBtn.Text = "Find state of storage";
            this.getSingleSOSBtn.UseVisualStyleBackColor = true;
            // 
            // getStatesOfStoragesBtn
            // 
            this.getStatesOfStoragesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getStatesOfStoragesBtn.Location = new System.Drawing.Point(450, 19);
            this.getStatesOfStoragesBtn.Name = "getStatesOfStoragesBtn";
            this.getStatesOfStoragesBtn.Size = new System.Drawing.Size(100, 40);
            this.getStatesOfStoragesBtn.TabIndex = 1;
            this.getStatesOfStoragesBtn.Text = "List all states of storages";
            this.getStatesOfStoragesBtn.UseVisualStyleBackColor = true;
            this.getStatesOfStoragesBtn.Click += new System.EventHandler(this.getStatesOfStoragesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sosDeleteBtn);
            this.groupBox2.Controls.Add(this.sosUpdateBtn);
            this.groupBox2.Controls.Add(this.sosCreateBtn);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State Of Storages Actions";
            // 
            // sosDeleteBtn
            // 
            this.sosDeleteBtn.Location = new System.Drawing.Point(6, 130);
            this.sosDeleteBtn.Name = "sosDeleteBtn";
            this.sosDeleteBtn.Size = new System.Drawing.Size(186, 40);
            this.sosDeleteBtn.TabIndex = 2;
            this.sosDeleteBtn.Text = "Delete";
            this.sosDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // sosUpdateBtn
            // 
            this.sosUpdateBtn.Location = new System.Drawing.Point(6, 74);
            this.sosUpdateBtn.Name = "sosUpdateBtn";
            this.sosUpdateBtn.Size = new System.Drawing.Size(186, 40);
            this.sosUpdateBtn.TabIndex = 1;
            this.sosUpdateBtn.Text = "Update";
            this.sosUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // sosCreateBtn
            // 
            this.sosCreateBtn.Location = new System.Drawing.Point(6, 19);
            this.sosCreateBtn.Name = "sosCreateBtn";
            this.sosCreateBtn.Size = new System.Drawing.Size(186, 40);
            this.sosCreateBtn.TabIndex = 0;
            this.sosCreateBtn.Text = "Create";
            this.sosCreateBtn.UseVisualStyleBackColor = true;
            // 
            // ManageStatesOfStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ManageStatesOfStorages";
            this.Text = "ManageStatesOfStorages";
            ((System.ComponentModel.ISupportInitialize)(this.statesOfStoragesListDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statesOfStoragesListDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sosDeleteBtn;
        private System.Windows.Forms.Button sosUpdateBtn;
        private System.Windows.Forms.Button sosCreateBtn;
        private System.Windows.Forms.TextBox txtStateOfStoragesId;
        private System.Windows.Forms.Button getSingleSOSBtn;
        private System.Windows.Forms.Button getStatesOfStoragesBtn;
    }
}