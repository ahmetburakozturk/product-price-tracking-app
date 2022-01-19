
namespace UITry
{
    partial class Ayarlar
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
            System.Windows.Forms.Button button2;
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCurrentUser = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.Enabled = false;
            button2.ForeColor = System.Drawing.Color.Transparent;
            button2.Image = global::UITry.Properties.Resources._132244_unknown_person_icon;
            button2.Location = new System.Drawing.Point(685, 26);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(63, 62);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxOldPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxOldPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxOldPassword.Location = new System.Drawing.Point(418, 306);
            this.tbxOldPassword.Multiline = true;
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.Size = new System.Drawing.Size(250, 40);
            this.tbxOldPassword.TabIndex = 0;
            this.tbxOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNewPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxNewPassword.Location = new System.Drawing.Point(418, 365);
            this.tbxNewPassword.Multiline = true;
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(250, 40);
            this.tbxNewPassword.TabIndex = 1;
            this.tbxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNewPassword2
            // 
            this.tbxNewPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNewPassword2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNewPassword2.ForeColor = System.Drawing.Color.Black;
            this.tbxNewPassword2.Location = new System.Drawing.Point(418, 423);
            this.tbxNewPassword2.Multiline = true;
            this.tbxNewPassword2.Name = "tbxNewPassword2";
            this.tbxNewPassword2.Size = new System.Drawing.Size(250, 40);
            this.tbxNewPassword2.TabIndex = 2;
            this.tbxNewPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.BackColor = System.Drawing.Color.Tan;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.Location = new System.Drawing.Point(490, 493);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(104, 47);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Değiştir";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(420, 199);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(248, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre Değiştirme";
            // 
            // btnCurrentUser
            // 
            this.btnCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCurrentUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCurrentUser.FlatAppearance.BorderSize = 0;
            this.btnCurrentUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCurrentUser.ForeColor = System.Drawing.Color.Yellow;
            this.btnCurrentUser.Location = new System.Drawing.Point(766, 33);
            this.btnCurrentUser.Name = "btnCurrentUser";
            this.btnCurrentUser.Size = new System.Drawing.Size(241, 47);
            this.btnCurrentUser.TabIndex = 11;
            this.btnCurrentUser.Text = "deneme";
            this.btnCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentUser.UseVisualStyleBackColor = false;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.btnCurrentUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbxNewPassword2);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.tbxOldPassword);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCurrentUser;
    }
}