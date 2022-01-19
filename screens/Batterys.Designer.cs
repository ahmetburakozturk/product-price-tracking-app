
namespace UITry
{
    partial class Bataryalar
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
            this.dgwBatterys = new System.Windows.Forms.DataGridView();
            this.btnDeleteBatterys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelBatteryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBatterys)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBatterys
            // 
            this.dgwBatterys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBatterys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBatterys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwBatterys.BackgroundColor = System.Drawing.Color.White;
            this.dgwBatterys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBatterys.Location = new System.Drawing.Point(12, 12);
            this.dgwBatterys.Name = "dgwBatterys";
            this.dgwBatterys.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwBatterys.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBatterys.RowTemplate.Height = 25;
            this.dgwBatterys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBatterys.Size = new System.Drawing.Size(1009, 602);
            this.dgwBatterys.TabIndex = 0;
            // 
            // btnDeleteBatterys
            // 
            this.btnDeleteBatterys.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteBatterys.AutoSize = true;
            this.btnDeleteBatterys.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteBatterys.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteBatterys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBatterys.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBatterys.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBatterys.Location = new System.Drawing.Point(354, 683);
            this.btnDeleteBatterys.Name = "btnDeleteBatterys";
            this.btnDeleteBatterys.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteBatterys.TabIndex = 1;
            this.btnDeleteBatterys.Text = "Sil";
            this.btnDeleteBatterys.UseVisualStyleBackColor = false;
            this.btnDeleteBatterys.Click += new System.EventHandler(this.btnDeleteBatterys_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Silmek İstediğiniz ürünün ID\'sini girin ve SİL butonuna tıklayın.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // tbxDelBatteryID
            // 
            this.tbxDelBatteryID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelBatteryID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelBatteryID.Location = new System.Drawing.Point(342, 634);
            this.tbxDelBatteryID.Multiline = true;
            this.tbxDelBatteryID.Name = "tbxDelBatteryID";
            this.tbxDelBatteryID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelBatteryID.TabIndex = 7;
            this.tbxDelBatteryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bataryalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelBatteryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBatterys);
            this.Controls.Add(this.dgwBatterys);
            this.Name = "Bataryalar";
            this.Text = "Batterys";
            this.Load += new System.EventHandler(this.Bataryalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBatterys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBatterys;
        private System.Windows.Forms.Button btnDeleteBatterys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelBatteryID;
    }
}