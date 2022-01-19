
namespace UITry
{
    partial class Kılıflar
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
            this.dgwCover = new System.Windows.Forms.DataGridView();
            this.btnDelCovers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelCoverID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCover)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCover
            // 
            this.dgwCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCover.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCover.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwCover.BackgroundColor = System.Drawing.Color.White;
            this.dgwCover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCover.Location = new System.Drawing.Point(12, 12);
            this.dgwCover.Name = "dgwCover";
            this.dgwCover.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwCover.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCover.RowTemplate.Height = 25;
            this.dgwCover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCover.Size = new System.Drawing.Size(1009, 602);
            this.dgwCover.TabIndex = 0;
            // 
            // btnDelCovers
            // 
            this.btnDelCovers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelCovers.AutoSize = true;
            this.btnDelCovers.BackColor = System.Drawing.Color.Crimson;
            this.btnDelCovers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelCovers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCovers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelCovers.ForeColor = System.Drawing.Color.White;
            this.btnDelCovers.Location = new System.Drawing.Point(354, 683);
            this.btnDelCovers.Name = "btnDelCovers";
            this.btnDelCovers.Size = new System.Drawing.Size(75, 42);
            this.btnDelCovers.TabIndex = 1;
            this.btnDelCovers.Text = "Sil";
            this.btnDelCovers.UseVisualStyleBackColor = false;
            this.btnDelCovers.Click += new System.EventHandler(this.btnDelCovers_Click);
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
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // tbxDelCoverID
            // 
            this.tbxDelCoverID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelCoverID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelCoverID.Location = new System.Drawing.Point(342, 634);
            this.tbxDelCoverID.Multiline = true;
            this.tbxDelCoverID.Name = "tbxDelCoverID";
            this.tbxDelCoverID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelCoverID.TabIndex = 5;
            this.tbxDelCoverID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kılıflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelCoverID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelCovers);
            this.Controls.Add(this.dgwCover);
            this.Name = "Kılıflar";
            this.Text = "Covers";
            this.Load += new System.EventHandler(this.Kılıflar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCover;
        private System.Windows.Forms.Button btnDelCovers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelCoverID;
    }
}