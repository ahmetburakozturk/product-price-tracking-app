
namespace UITry
{
    partial class Koruyucular
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
            this.dgwProtector = new System.Windows.Forms.DataGridView();
            this.btnDelProtector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelProtectorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProtector)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProtector
            // 
            this.dgwProtector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProtector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProtector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwProtector.BackgroundColor = System.Drawing.Color.White;
            this.dgwProtector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProtector.Location = new System.Drawing.Point(12, 12);
            this.dgwProtector.Name = "dgwProtector";
            this.dgwProtector.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwProtector.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwProtector.RowTemplate.Height = 25;
            this.dgwProtector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProtector.Size = new System.Drawing.Size(1009, 602);
            this.dgwProtector.TabIndex = 0;
            // 
            // btnDelProtector
            // 
            this.btnDelProtector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelProtector.AutoSize = true;
            this.btnDelProtector.BackColor = System.Drawing.Color.Crimson;
            this.btnDelProtector.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelProtector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProtector.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelProtector.ForeColor = System.Drawing.Color.White;
            this.btnDelProtector.Location = new System.Drawing.Point(354, 683);
            this.btnDelProtector.Name = "btnDelProtector";
            this.btnDelProtector.Size = new System.Drawing.Size(75, 42);
            this.btnDelProtector.TabIndex = 1;
            this.btnDelProtector.Text = "Sil";
            this.btnDelProtector.UseVisualStyleBackColor = false;
            this.btnDelProtector.Click += new System.EventHandler(this.btnDelProtector_Click);
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
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // tbxDelProtectorID
            // 
            this.tbxDelProtectorID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelProtectorID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelProtectorID.Location = new System.Drawing.Point(342, 634);
            this.tbxDelProtectorID.Multiline = true;
            this.tbxDelProtectorID.Name = "tbxDelProtectorID";
            this.tbxDelProtectorID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelProtectorID.TabIndex = 5;
            this.tbxDelProtectorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Koruyucular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelProtectorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelProtector);
            this.Controls.Add(this.dgwProtector);
            this.Name = "Koruyucular";
            this.Text = "Koruyucular";
            this.Load += new System.EventHandler(this.Koruyucular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProtector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProtector;
        private System.Windows.Forms.Button btnDelProtector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelProtectorID;
    }
}