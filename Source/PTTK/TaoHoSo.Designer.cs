using System.Windows.Forms;

namespace PTTK
{
    partial class TaoHoSo
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
            this.THS_label1 = new System.Windows.Forms.Label();
            this.THS_label2 = new System.Windows.Forms.Label();
            this.THS_label3 = new System.Windows.Forms.Label();
            this.THS_label4 = new System.Windows.Forms.Label();
            this.THS_label5 = new System.Windows.Forms.Label();
            this.THS_label6 = new System.Windows.Forms.Label();
            this.THS_textBox1 = new System.Windows.Forms.TextBox();
            this.THS_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.THS_button1 = new System.Windows.Forms.Button();
            this.THS_label7 = new System.Windows.Forms.Label();
            this.THS_label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.THS_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // THS_label1
            // 
            this.THS_label1.AutoSize = true;
            this.THS_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label1.Location = new System.Drawing.Point(30, 30);
            this.THS_label1.Name = "THS_label1";
            this.THS_label1.Size = new System.Drawing.Size(129, 31);
            this.THS_label1.TabIndex = 0;
            this.THS_label1.Text = "Ứng viên";
            // 
            // THS_label2
            // 
            this.THS_label2.AutoSize = true;
            this.THS_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label2.Location = new System.Drawing.Point(165, 30);
            this.THS_label2.Name = "THS_label2";
            this.THS_label2.Size = new System.Drawing.Size(31, 31);
            this.THS_label2.TabIndex = 1;
            this.THS_label2.Text = ">";
            // 
            // THS_label3
            // 
            this.THS_label3.AutoSize = true;
            this.THS_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label3.Location = new System.Drawing.Point(202, 30);
            this.THS_label3.Name = "THS_label3";
            this.THS_label3.Size = new System.Drawing.Size(102, 31);
            this.THS_label3.TabIndex = 2;
            this.THS_label3.Text = "UV001";
            // 
            // THS_label4
            // 
            this.THS_label4.AutoSize = true;
            this.THS_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label4.Location = new System.Drawing.Point(310, 30);
            this.THS_label4.Name = "THS_label4";
            this.THS_label4.Size = new System.Drawing.Size(31, 31);
            this.THS_label4.TabIndex = 3;
            this.THS_label4.Text = ">";
            // 
            // THS_label5
            // 
            this.THS_label5.AutoSize = true;
            this.THS_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label5.Location = new System.Drawing.Point(347, 30);
            this.THS_label5.Name = "THS_label5";
            this.THS_label5.Size = new System.Drawing.Size(226, 31);
            this.THS_label5.TabIndex = 4;
            this.THS_label5.Text = "Hồ sơ ứng tuyển";
            // 
            // THS_label6
            // 
            this.THS_label6.AutoSize = true;
            this.THS_label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label6.Location = new System.Drawing.Point(60, 90);
            this.THS_label6.Name = "THS_label6";
            this.THS_label6.Size = new System.Drawing.Size(100, 25);
            this.THS_label6.TabIndex = 5;
            this.THS_label6.Text = "Ứng viên: ";
            // 
            // THS_textBox1
            // 
            this.THS_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_textBox1.Location = new System.Drawing.Point(238, 127);
            this.THS_textBox1.Name = "THS_textBox1";
            this.THS_textBox1.Size = new System.Drawing.Size(700, 30);
            this.THS_textBox1.TabIndex = 6;
            this.THS_textBox1.TextChanged += new System.EventHandler(this.THS_textBox1_TextChanged);
            // 
            // THS_dataGridView1
            // 
            this.THS_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.THS_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.THS_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.THS_dataGridView1.Location = new System.Drawing.Point(100, 180);
            this.THS_dataGridView1.Name = "THS_dataGridView1";
            this.THS_dataGridView1.RowHeadersWidth = 51;
            this.THS_dataGridView1.RowTemplate.Height = 24;
            this.THS_dataGridView1.Size = new System.Drawing.Size(800, 250);
            this.THS_dataGridView1.TabIndex = 7;
            // 
            // THS_button1
            // 
            this.THS_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(203)))));
            this.THS_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.THS_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_button1.Location = new System.Drawing.Point(65, 532);
            this.THS_button1.Name = "THS_button1";
            this.THS_button1.Size = new System.Drawing.Size(150, 40);
            this.THS_button1.TabIndex = 8;
            this.THS_button1.Text = "Lập hồ sơ";
            this.THS_button1.UseVisualStyleBackColor = false;
            this.THS_button1.Click += new System.EventHandler(this.THS_button1_Click);
            // 
            // THS_label7
            // 
            this.THS_label7.AutoSize = true;
            this.THS_label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label7.Location = new System.Drawing.Point(166, 90);
            this.THS_label7.Name = "THS_label7";
            this.THS_label7.Size = new System.Drawing.Size(126, 25);
            this.THS_label7.TabIndex = 9;
            this.THS_label7.Text = "Tên ứng viên";
            // 
            // THS_label8
            // 
            this.THS_label8.AutoSize = true;
            this.THS_label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THS_label8.Location = new System.Drawing.Point(60, 130);
            this.THS_label8.Name = "THS_label8";
            this.THS_label8.Size = new System.Drawing.Size(158, 25);
            this.THS_label8.TabIndex = 10;
            this.THS_label8.Text = "Vị trí đang tuyển:";
            // 
            // TaoHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 589);
            this.Controls.Add(this.THS_label8);
            this.Controls.Add(this.THS_label7);
            this.Controls.Add(this.THS_button1);
            this.Controls.Add(this.THS_dataGridView1);
            this.Controls.Add(this.THS_textBox1);
            this.Controls.Add(this.THS_label6);
            this.Controls.Add(this.THS_label5);
            this.Controls.Add(this.THS_label4);
            this.Controls.Add(this.THS_label3);
            this.Controls.Add(this.THS_label2);
            this.Controls.Add(this.THS_label1);
            this.Name = "TaoHoSo";
            this.Text = "TaoHoSo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaoHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.THS_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label THS_label1;
        private System.Windows.Forms.Label THS_label2;
        private System.Windows.Forms.Label THS_label3;
        private System.Windows.Forms.Label THS_label4;
        private System.Windows.Forms.Label THS_label5;
        private System.Windows.Forms.Label THS_label6;
        private System.Windows.Forms.TextBox THS_textBox1;
        private System.Windows.Forms.DataGridView THS_dataGridView1;
        private System.Windows.Forms.Button THS_button1;
        private System.Windows.Forms.Label THS_label7;
        private System.Windows.Forms.Label THS_label8;
    }
}