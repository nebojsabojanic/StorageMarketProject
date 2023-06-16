namespace StorageMarket
{
    partial class CRUDStoragesForm
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
            this.closeStoragesCRUD = new System.Windows.Forms.Button();
            this.submitStoragesCRUD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStorageId = new System.Windows.Forms.TextBox();
            this.txtStorageName = new System.Windows.Forms.TextBox();
            this.txtKindOfStorage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeStoragesCRUD
            // 
            this.closeStoragesCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeStoragesCRUD.Location = new System.Drawing.Point(186, 259);
            this.closeStoragesCRUD.Name = "closeStoragesCRUD";
            this.closeStoragesCRUD.Size = new System.Drawing.Size(75, 23);
            this.closeStoragesCRUD.TabIndex = 0;
            this.closeStoragesCRUD.Text = "Close";
            this.closeStoragesCRUD.UseVisualStyleBackColor = true;
            this.closeStoragesCRUD.Click += new System.EventHandler(this.closeStoragesCRUD_Click);
            // 
            // submitStoragesCRUD
            // 
            this.submitStoragesCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitStoragesCRUD.Location = new System.Drawing.Point(13, 258);
            this.submitStoragesCRUD.Name = "submitStoragesCRUD";
            this.submitStoragesCRUD.Size = new System.Drawing.Size(75, 23);
            this.submitStoragesCRUD.TabIndex = 1;
            this.submitStoragesCRUD.Text = "Finish";
            this.submitStoragesCRUD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Storage ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Storage Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kind Of Storage";
            // 
            // txtStorageId
            // 
            this.txtStorageId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStorageId.Location = new System.Drawing.Point(161, 26);
            this.txtStorageId.Name = "txtStorageId";
            this.txtStorageId.Size = new System.Drawing.Size(100, 20);
            this.txtStorageId.TabIndex = 5;
            // 
            // txtStorageName
            // 
            this.txtStorageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStorageName.Location = new System.Drawing.Point(161, 68);
            this.txtStorageName.Name = "txtStorageName";
            this.txtStorageName.Size = new System.Drawing.Size(100, 20);
            this.txtStorageName.TabIndex = 6;
            // 
            // txtKindOfStorage
            // 
            this.txtKindOfStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKindOfStorage.Location = new System.Drawing.Point(161, 111);
            this.txtKindOfStorage.Name = "txtKindOfStorage";
            this.txtKindOfStorage.Size = new System.Drawing.Size(100, 20);
            this.txtKindOfStorage.TabIndex = 7;
            // 
            // CRUDStoragesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 294);
            this.Controls.Add(this.txtKindOfStorage);
            this.Controls.Add(this.txtStorageName);
            this.Controls.Add(this.txtStorageId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitStoragesCRUD);
            this.Controls.Add(this.closeStoragesCRUD);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(250, 320);
            this.Name = "CRUDStoragesForm";
            this.Text = "CRUDStoragesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeStoragesCRUD;
        private System.Windows.Forms.Button submitStoragesCRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStorageId;
        private System.Windows.Forms.TextBox txtStorageName;
        private System.Windows.Forms.TextBox txtKindOfStorage;
    }
}