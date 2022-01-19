
namespace UITry
{
    partial class Ekleme
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
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.tbxPrıceOut = new System.Windows.Forms.TextBox();
            this.tbxPrıceIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxItemName
            // 
            this.tbxItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxItemName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxItemName.Location = new System.Drawing.Point(434, 205);
            this.tbxItemName.Multiline = true;
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(275, 34);
            this.tbxItemName.TabIndex = 0;
            this.tbxItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPrıceOut
            // 
            this.tbxPrıceOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPrıceOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrıceOut.Location = new System.Drawing.Point(434, 324);
            this.tbxPrıceOut.Multiline = true;
            this.tbxPrıceOut.Name = "tbxPrıceOut";
            this.tbxPrıceOut.Size = new System.Drawing.Size(275, 34);
            this.tbxPrıceOut.TabIndex = 1;
            this.tbxPrıceOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPrıceIn
            // 
            this.tbxPrıceIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPrıceIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrıceIn.Location = new System.Drawing.Point(434, 263);
            this.tbxPrıceIn.Multiline = true;
            this.tbxPrıceIn.Name = "tbxPrıceIn";
            this.tbxPrıceIn.Size = new System.Drawing.Size(275, 34);
            this.tbxPrıceIn.TabIndex = 2;
            this.tbxPrıceIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alış Fiyatı";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(530, 509);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(81, 49);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Ekle";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCategory.ForeColor = System.Drawing.Color.Black;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Şar Aleti",
            "Batarya",
            "Kılıf",
            "Kırılmaz Cam",
            "Kulaklık",
            "Aksesuar"});
            this.cbxCategory.Location = new System.Drawing.Point(434, 442);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(275, 33);
            this.cbxCategory.TabIndex = 7;
            this.cbxCategory.Text = "Kategori Seçiniz...";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxBrand
            // 
            this.tbxBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxBrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBrand.Location = new System.Drawing.Point(434, 383);
            this.tbxBrand.Multiline = true;
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(275, 34);
            this.tbxBrand.TabIndex = 8;
            this.tbxBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(340, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marka";
            // 
            // Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrıceIn);
            this.Controls.Add(this.tbxPrıceOut);
            this.Controls.Add(this.tbxItemName);
            this.Name = "Ekleme";
            this.Text = "Urun Ekle";
            this.Load += new System.EventHandler(this.Ekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.TextBox tbxPrıceOut;
        private System.Windows.Forms.TextBox tbxPrıceIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label label4;
    }
}