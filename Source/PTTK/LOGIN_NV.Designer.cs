namespace PTTK
{
    partial class LOGIN_NV
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
            this.login_nv_button1 = new System.Windows.Forms.Button();
            this.login_nv_label1 = new System.Windows.Forms.Label();
            this.login_nv_label2 = new System.Windows.Forms.Label();
            this.login_nv_textBox_username = new System.Windows.Forms.TextBox();
            this.login_nv_textBox_password = new System.Windows.Forms.TextBox();
            this.login_nv_label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_nv_button1
            // 
            this.login_nv_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_nv_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_button1.Location = new System.Drawing.Point(116, 344);
            this.login_nv_button1.Name = "login_nv_button1";
            this.login_nv_button1.Size = new System.Drawing.Size(200, 45);
            this.login_nv_button1.TabIndex = 0;
            this.login_nv_button1.Text = "Đăng nhập";
            this.login_nv_button1.UseVisualStyleBackColor = true;
            this.login_nv_button1.Click += new System.EventHandler(this.login_nv_button1_Click);
            // 
            // login_nv_label1
            // 
            this.login_nv_label1.AutoSize = true;
            this.login_nv_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_label1.Location = new System.Drawing.Point(71, 131);
            this.login_nv_label1.Name = "login_nv_label1";
            this.login_nv_label1.Size = new System.Drawing.Size(175, 29);
            this.login_nv_label1.TabIndex = 1;
            this.login_nv_label1.Text = "Tên đăng nhập";
            // 
            // login_nv_label2
            // 
            this.login_nv_label2.AutoSize = true;
            this.login_nv_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_label2.Location = new System.Drawing.Point(71, 221);
            this.login_nv_label2.Name = "login_nv_label2";
            this.login_nv_label2.Size = new System.Drawing.Size(109, 29);
            this.login_nv_label2.TabIndex = 2;
            this.login_nv_label2.Text = "Mật khẩu";
            // 
            // login_nv_textBox_username
            // 
            this.login_nv_textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_textBox_username.Location = new System.Drawing.Point(76, 163);
            this.login_nv_textBox_username.Name = "login_nv_textBox_username";
            this.login_nv_textBox_username.Size = new System.Drawing.Size(300, 34);
            this.login_nv_textBox_username.TabIndex = 3;
            // 
            // login_nv_textBox_password
            // 
            this.login_nv_textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_textBox_password.Location = new System.Drawing.Point(76, 262);
            this.login_nv_textBox_password.Name = "login_nv_textBox_password";
            this.login_nv_textBox_password.PasswordChar = '*';
            this.login_nv_textBox_password.Size = new System.Drawing.Size(300, 34);
            this.login_nv_textBox_password.TabIndex = 4;
            this.login_nv_textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_nv_textBox_password_KeyDown);
            // 
            // login_nv_label3
            // 
            this.login_nv_label3.AutoSize = true;
            this.login_nv_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nv_label3.Location = new System.Drawing.Point(135, 53);
            this.login_nv_label3.Name = "login_nv_label3";
            this.login_nv_label3.Size = new System.Drawing.Size(162, 29);
            this.login_nv_label3.TabIndex = 5;
            this.login_nv_label3.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PTTK.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(450, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_nv_label3);
            this.Controls.Add(this.login_nv_textBox_password);
            this.Controls.Add(this.login_nv_textBox_username);
            this.Controls.Add(this.login_nv_label2);
            this.Controls.Add(this.login_nv_label1);
            this.Controls.Add(this.login_nv_button1);
            this.Name = "LOGIN_NV";
            this.Text = "LOGIN_NV";
            this.Load += new System.EventHandler(this.LOGIN_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_nv_button1;
        private System.Windows.Forms.Label login_nv_label1;
        private System.Windows.Forms.Label login_nv_label2;
        private System.Windows.Forms.TextBox login_nv_textBox_username;
        private System.Windows.Forms.TextBox login_nv_textBox_password;
        private System.Windows.Forms.Label login_nv_label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}