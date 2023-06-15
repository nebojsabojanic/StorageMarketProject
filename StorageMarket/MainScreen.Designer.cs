namespace StorageMarket
{
    partial class MainScreen
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
            this.mngPrdctsBtn = new System.Windows.Forms.Button();
            this.mngStrgBtn = new System.Windows.Forms.Button();
            this.mngStOfStrgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mngPrdctsBtn
            // 
            this.mngPrdctsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mngPrdctsBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mngPrdctsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mngPrdctsBtn.FlatAppearance.BorderSize = 2;
            this.mngPrdctsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mngPrdctsBtn.Location = new System.Drawing.Point(37, 66);
            this.mngPrdctsBtn.Name = "mngPrdctsBtn";
            this.mngPrdctsBtn.Size = new System.Drawing.Size(115, 44);
            this.mngPrdctsBtn.TabIndex = 0;
            this.mngPrdctsBtn.Text = "Manage Products";
            this.mngPrdctsBtn.UseVisualStyleBackColor = false;
            this.mngPrdctsBtn.Click += new System.EventHandler(this.mngPrdctsBtn_Click);
            // 
            // mngStrgBtn
            // 
            this.mngStrgBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mngStrgBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mngStrgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mngStrgBtn.FlatAppearance.BorderSize = 2;
            this.mngStrgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mngStrgBtn.Location = new System.Drawing.Point(285, 66);
            this.mngStrgBtn.Name = "mngStrgBtn";
            this.mngStrgBtn.Size = new System.Drawing.Size(115, 44);
            this.mngStrgBtn.TabIndex = 1;
            this.mngStrgBtn.Text = "Manage Storages";
            this.mngStrgBtn.UseVisualStyleBackColor = false;
            this.mngStrgBtn.Click += new System.EventHandler(this.mngStrgBtn_Click);
            // 
            // mngStOfStrgBtn
            // 
            this.mngStOfStrgBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mngStOfStrgBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mngStOfStrgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mngStOfStrgBtn.FlatAppearance.BorderSize = 2;
            this.mngStOfStrgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mngStOfStrgBtn.Location = new System.Drawing.Point(538, 66);
            this.mngStOfStrgBtn.Name = "mngStOfStrgBtn";
            this.mngStOfStrgBtn.Size = new System.Drawing.Size(115, 44);
            this.mngStOfStrgBtn.TabIndex = 2;
            this.mngStOfStrgBtn.Text = "Manage States of Storages";
            this.mngStOfStrgBtn.UseVisualStyleBackColor = false;
            this.mngStOfStrgBtn.Click += new System.EventHandler(this.mngStOfStrgBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(279, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(191, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 78);
            this.label2.TabIndex = 4;
            this.label2.Text = "Storage Market";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mngPrdctsBtn);
            this.groupBox2.Controls.Add(this.mngStrgBtn);
            this.groupBox2.Controls.Add(this.mngStOfStrgBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 175);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(714, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mngPrdctsBtn;
        private System.Windows.Forms.Button mngStrgBtn;
        private System.Windows.Forms.Button mngStOfStrgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}