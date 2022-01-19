
namespace UITry
{
    partial class Kulaklıklar
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
            this.dgwHeadphone = new System.Windows.Forms.DataGridView();
            this.btnDelHeadphones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDelHeadphoneID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHeadphone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHeadphone
            // 
            this.dgwHeadphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwHeadphone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHeadphone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwHeadphone.BackgroundColor = System.Drawing.Color.White;
            this.dgwHeadphone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHeadphone.Location = new System.Drawing.Point(12, 12);
            this.dgwHeadphone.Name = "dgwHeadphone";
            this.dgwHeadphone.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwHeadphone.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwHeadphone.RowTemplate.Height = 25;
            this.dgwHeadphone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHeadphone.Size = new System.Drawing.Size(1009, 602);
            this.dgwHeadphone.TabIndex = 0;
            // 
            // btnDelHeadphones
            // 
            this.btnDelHeadphones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelHeadphones.AutoSize = true;
            this.btnDelHeadphones.BackColor = System.Drawing.Color.Crimson;
            this.btnDelHeadphones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelHeadphones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelHeadphones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelHeadphones.ForeColor = System.Drawing.Color.White;
            this.btnDelHeadphones.Location = new System.Drawing.Point(354, 683);
            this.btnDelHeadphones.Name = "btnDelHeadphones";
            this.btnDelHeadphones.Size = new System.Drawing.Size(75, 42);
            this.btnDelHeadphones.TabIndex = 1;
            this.btnDelHeadphones.Text = "Sil";
            this.btnDelHeadphones.UseVisualStyleBackColor = false;
            this.btnDelHeadphones.Click += new System.EventHandler(this.btnDelHeadphones_Click);
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
            // tbxDelHeadphoneID
            // 
            this.tbxDelHeadphoneID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxDelHeadphoneID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDelHeadphoneID.Location = new System.Drawing.Point(341, 634);
            this.tbxDelHeadphoneID.Multiline = true;
            this.tbxDelHeadphoneID.Name = "tbxDelHeadphoneID";
            this.tbxDelHeadphoneID.Size = new System.Drawing.Size(100, 43);
            this.tbxDelHeadphoneID.TabIndex = 3;
            this.tbxDelHeadphoneID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // Kulaklıklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDelHeadphoneID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelHeadphones);
            this.Controls.Add(this.dgwHeadphone);
            this.Name = "Kulaklıklar";
            this.Text = "Headphones";
            this.Load += new System.EventHandler(this.Kulaklıklar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHeadphone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHeadphone;
        private System.Windows.Forms.Button btnDelHeadphones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDelHeadphoneID;
        private System.Windows.Forms.Label label2;
    }
}