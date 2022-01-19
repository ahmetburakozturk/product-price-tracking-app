
namespace UITry
{
    partial class Aksesuarlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwAccessories = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelAccessoriesID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelAccessories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAccessories
            // 
            this.dgwAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwAccessories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAccessories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwAccessories.BackgroundColor = System.Drawing.Color.White;
            this.dgwAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccessories.Location = new System.Drawing.Point(12, 12);
            this.dgwAccessories.Name = "dgwAccessories";
            this.dgwAccessories.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwAccessories.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAccessories.RowTemplate.Height = 25;
            this.dgwAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAccessories.Size = new System.Drawing.Size(1009, 602);
            this.dgwAccessories.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(311, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // tbxDelAccessoriesID
            // 
            this.tbxDelAccessoriesID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelAccessoriesID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelAccessoriesID.Location = new System.Drawing.Point(342, 634);
            this.tbxDelAccessoriesID.Multiline = true;
            this.tbxDelAccessoriesID.Name = "tbxDelAccessoriesID";
            this.tbxDelAccessoriesID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelAccessoriesID.TabIndex = 9;
            this.tbxDelAccessoriesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "* Silmek İstediğiniz ürünün ID\'sini girin ve SİL butonuna tıklayın.";
            // 
            // btnDelAccessories
            // 
            this.btnDelAccessories.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelAccessories.AutoSize = true;
            this.btnDelAccessories.BackColor = System.Drawing.Color.Crimson;
            this.btnDelAccessories.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAccessories.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelAccessories.ForeColor = System.Drawing.Color.White;
            this.btnDelAccessories.Location = new System.Drawing.Point(354, 683);
            this.btnDelAccessories.Name = "btnDelAccessories";
            this.btnDelAccessories.Size = new System.Drawing.Size(75, 42);
            this.btnDelAccessories.TabIndex = 7;
            this.btnDelAccessories.Text = "Sil";
            this.btnDelAccessories.UseVisualStyleBackColor = false;
            this.btnDelAccessories.Click += new System.EventHandler(this.btnDelAccessories_Click);
            // 
            // Aksesuarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelAccessoriesID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelAccessories);
            this.Controls.Add(this.dgwAccessories);
            this.Name = "Aksesuarlar";
            this.Text = "Aksesuarlar";
            this.Load += new System.EventHandler(this.Aksesuarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccessories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAccessories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelAccessoriesID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelAccessories;
    }
}