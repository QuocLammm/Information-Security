namespace DEV
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFilestart = new System.Windows.Forms.Button();
            this.btnFileend = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaMa = new System.Windows.Forms.Button();
            this.txtFilestart = new System.Windows.Forms.TextBox();
            this.txtFileend = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thuật toán mã hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "256 bít";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thông tin block:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(902, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "128 bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khóa (dạng hexa)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "IV (dạng hexa)";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(245, 130);
            this.txtkey.Multiline = true;
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(702, 33);
            this.txtkey.TabIndex = 10;
            this.txtkey.TextChanged += new System.EventHandler(this.txtkey_TextChanged);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(245, 179);
            this.txtIV.Multiline = true;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(702, 30);
            this.txtIV.TabIndex = 8;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(337, 233);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(196, 50);
            this.btncreate.TabIndex = 9;
            this.btncreate.Text = "Nạp Khóa và IV";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(562, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lưu Khóa và IV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnRandom.Location = new System.Drawing.Point(768, 233);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(179, 49);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Sinh Khóa và IV";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "File ban đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "File mã hóa";
            // 
            // btnFilestart
            // 
            this.btnFilestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilestart.Location = new System.Drawing.Point(854, 357);
            this.btnFilestart.Name = "btnFilestart";
            this.btnFilestart.Size = new System.Drawing.Size(137, 37);
            this.btnFilestart.TabIndex = 14;
            this.btnFilestart.Text = "Chọn file...";
            this.btnFilestart.UseVisualStyleBackColor = true;
            this.btnFilestart.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFileend
            // 
            this.btnFileend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileend.Location = new System.Drawing.Point(854, 407);
            this.btnFileend.Name = "btnFileend";
            this.btnFileend.Size = new System.Drawing.Size(137, 33);
            this.btnFileend.TabIndex = 15;
            this.btnFileend.Text = "Chọn file...";
            this.btnFileend.UseVisualStyleBackColor = true;
            this.btnFileend.Click += new System.EventHandler(this.btnFileend_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Location = new System.Drawing.Point(245, 514);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(235, 71);
            this.btnMaHoa.TabIndex = 16;
            this.btnMaHoa.Text = "Mã Hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaMa
            // 
            this.btnGiaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaMa.Location = new System.Drawing.Point(562, 514);
            this.btnGiaMa.Name = "btnGiaMa";
            this.btnGiaMa.Size = new System.Drawing.Size(219, 71);
            this.btnGiaMa.TabIndex = 17;
            this.btnGiaMa.Text = "Giải Mã";
            this.btnGiaMa.UseVisualStyleBackColor = true;
            this.btnGiaMa.Click += new System.EventHandler(this.btnGiaMa_Click);
            // 
            // txtFilestart
            // 
            this.txtFilestart.Location = new System.Drawing.Point(213, 357);
            this.txtFilestart.Multiline = true;
            this.txtFilestart.Name = "txtFilestart";
            this.txtFilestart.Size = new System.Drawing.Size(619, 29);
            this.txtFilestart.TabIndex = 18;
            this.txtFilestart.TextChanged += new System.EventHandler(this.txtFilestart_TextChanged);
            // 
            // txtFileend
            // 
            this.txtFileend.Location = new System.Drawing.Point(213, 415);
            this.txtFileend.Multiline = true;
            this.txtFileend.Name = "txtFileend";
            this.txtFileend.Size = new System.Drawing.Size(619, 25);
            this.txtFileend.TabIndex = 19;
            this.txtFileend.TextChanged += new System.EventHandler(this.txtFileend_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AES",
            "DES",
            "TriplrDES",
            "Rịndael"});
            this.comboBox1.Location = new System.Drawing.Point(287, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 637);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtFileend);
            this.Controls.Add(this.txtFilestart);
            this.Controls.Add(this.btnGiaMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.btnFileend);
            this.Controls.Add(this.btnFilestart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFilestart;
        private System.Windows.Forms.Button btnFileend;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaMa;
        private System.Windows.Forms.TextBox txtFilestart;
        private System.Windows.Forms.TextBox txtFileend;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

