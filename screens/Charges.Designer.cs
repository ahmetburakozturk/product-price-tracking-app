
namespace UITry
{
    partial class Şarjlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwCharge = new System.Windows.Forms.DataGridView();
            this.btnDeleteCharges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelChargeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCharge
            // 
            this.dgwCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCharge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCharge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwCharge.BackgroundColor = System.Drawing.Color.White;
            this.dgwCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCharge.Location = new System.Drawing.Point(12, 12);
            this.dgwCharge.Name = "dgwCharge";
            this.dgwCharge.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwCharge.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCharge.RowTemplate.Height = 25;
            this.dgwCharge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCharge.Size = new System.Drawing.Size(1009, 602);
            this.dgwCharge.TabIndex = 0;
            // 
            // btnDeleteCharges
            // 
            this.btnDeleteCharges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteCharges.AutoSize = true;
            this.btnDeleteCharges.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCharges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCharges.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCharges.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCharges.Location = new System.Drawing.Point(354, 683);
            this.btnDeleteCharges.Name = "btnDeleteCharges";
            this.btnDeleteCharges.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteCharges.TabIndex = 1;
            this.btnDeleteCharges.Text = "Sil";
            this.btnDeleteCharges.UseVisualStyleBackColor = false;
            this.btnDeleteCharges.Click += new System.EventHandler(this.btnDeleteCharges_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Silmek İstediğiniz ürünün ID\'sini girin ve SİL butonuna tıklayın.";
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
            // tbxDelChargeID
            // 
            this.tbxDelChargeID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelChargeID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelChargeID.Location = new System.Drawing.Point(342, 634);
            this.tbxDelChargeID.Multiline = true;
            this.tbxDelChargeID.Name = "tbxDelChargeID";
            this.tbxDelChargeID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelChargeID.TabIndex = 9;
            this.tbxDelChargeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Şarjlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelChargeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCharges);
            this.Controls.Add(this.dgwCharge);
            this.Name = "Şarjlar";
            this.Text = "Charges";
            this.Load += new System.EventHandler(this.Şarjlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCharge;
        private System.Windows.Forms.Button btnDeleteCharges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelChargeID;
    }
}