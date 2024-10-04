namespace WindowsFormsApp1
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
            this.btn_giai_ma = new System.Windows.Forms.Button();
            this.btn_thong_ke = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGr1 = new System.Windows.Forms.DataGridView();
            this.dataGr2 = new System.Windows.Forms.DataGridView();
            this.dataGr3 = new System.Windows.Forms.DataGridView();
            this.ban_ro = new System.Windows.Forms.TextBox();
            this.Chữ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tan_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tan_so_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tan_so_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGr3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_giai_ma
            // 
            this.btn_giai_ma.Location = new System.Drawing.Point(46, 247);
            this.btn_giai_ma.Name = "btn_giai_ma";
            this.btn_giai_ma.Size = new System.Drawing.Size(173, 41);
            this.btn_giai_ma.TabIndex = 0;
            this.btn_giai_ma.Text = "Giải Mã";
            this.btn_giai_ma.UseVisualStyleBackColor = true;
            this.btn_giai_ma.Click += new System.EventHandler(this.btn_giai_ma_Click);
            // 
            // btn_thong_ke
            // 
            this.btn_thong_ke.Location = new System.Drawing.Point(391, 247);
            this.btn_thong_ke.Name = "btn_thong_ke";
            this.btn_thong_ke.Size = new System.Drawing.Size(187, 40);
            this.btn_thong_ke.TabIndex = 1;
            this.btn_thong_ke.Text = "Thống Kê";
            this.btn_thong_ke.UseVisualStyleBackColor = true;
            this.btn_thong_ke.Click += new System.EventHandler(this.btn_thong_ke_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 213);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGr1
            // 
            this.dataGr1.AllowUserToAddRows = false;
            this.dataGr1.AllowUserToResizeColumns = false;
            this.dataGr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGr1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chữ,
            this.tan_so,
            this.thay});
            this.dataGr1.Location = new System.Drawing.Point(617, 12);
            this.dataGr1.Name = "dataGr1";
            this.dataGr1.RowHeadersVisible = false;
            this.dataGr1.RowHeadersWidth = 51;
            this.dataGr1.RowTemplate.Height = 24;
            this.dataGr1.Size = new System.Drawing.Size(256, 509);
            this.dataGr1.TabIndex = 3;
            this.dataGr1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGr1_CellContentClick);
            // 
            // dataGr2
            // 
            this.dataGr2.AllowUserToAddRows = false;
            this.dataGr2.AllowUserToResizeColumns = false;
            this.dataGr2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGr2.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGr2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagram,
            this.tan_so_2});
            this.dataGr2.Location = new System.Drawing.Point(908, 12);
            this.dataGr2.Name = "dataGr2";
            this.dataGr2.RowHeadersVisible = false;
            this.dataGr2.RowHeadersWidth = 51;
            this.dataGr2.RowTemplate.Height = 24;
            this.dataGr2.Size = new System.Drawing.Size(192, 508);
            this.dataGr2.TabIndex = 4;
            // 
            // dataGr3
            // 
            this.dataGr3.AllowUserToAddRows = false;
            this.dataGr3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGr3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGr3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.triagram,
            this.tan_so_3});
            this.dataGr3.Location = new System.Drawing.Point(1133, 13);
            this.dataGr3.Name = "dataGr3";
            this.dataGr3.RowHeadersVisible = false;
            this.dataGr3.RowHeadersWidth = 51;
            this.dataGr3.RowTemplate.Height = 24;
            this.dataGr3.Size = new System.Drawing.Size(210, 508);
            this.dataGr3.TabIndex = 13;
            // 
            // ban_ro
            // 
            this.ban_ro.Location = new System.Drawing.Point(12, 302);
            this.ban_ro.Multiline = true;
            this.ban_ro.Name = "ban_ro";
            this.ban_ro.Size = new System.Drawing.Size(586, 235);
            this.ban_ro.TabIndex = 14;
            this.ban_ro.TextChanged += new System.EventHandler(this.ban_ro_TextChanged);
            // 
            // Chữ
            // 
            this.Chữ.HeaderText = "Chữ";
            this.Chữ.MinimumWidth = 6;
            this.Chữ.Name = "Chữ";
            this.Chữ.ReadOnly = true;
            // 
            // tan_so
            // 
            this.tan_so.HeaderText = "Tần số";
            this.tan_so.MinimumWidth = 6;
            this.tan_so.Name = "tan_so";
            // 
            // thay
            // 
            this.thay.HeaderText = "Thay";
            this.thay.MinimumWidth = 6;
            this.thay.Name = "thay";
            // 
            // diagram
            // 
            this.diagram.HeaderText = "Digram";
            this.diagram.MinimumWidth = 6;
            this.diagram.Name = "diagram";
            // 
            // tan_so_2
            // 
            this.tan_so_2.HeaderText = "Tần Số";
            this.tan_so_2.MinimumWidth = 6;
            this.tan_so_2.Name = "tan_so_2";
            // 
            // triagram
            // 
            this.triagram.HeaderText = "Trigram";
            this.triagram.MinimumWidth = 6;
            this.triagram.Name = "triagram";
            // 
            // tan_so_3
            // 
            this.tan_so_3.HeaderText = "Tần Số";
            this.tan_so_3.MinimumWidth = 6;
            this.tan_so_3.Name = "tan_so_3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 552);
            this.Controls.Add(this.ban_ro);
            this.Controls.Add(this.dataGr3);
            this.Controls.Add(this.dataGr2);
            this.Controls.Add(this.dataGr1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_thong_ke);
            this.Controls.Add(this.btn_giai_ma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giai_ma;
        private System.Windows.Forms.Button btn_thong_ke;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGr1;
        private System.Windows.Forms.DataGridView dataGr2;
        private System.Windows.Forms.DataGridView dataGr3;
        private System.Windows.Forms.TextBox ban_ro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chữ;
        private System.Windows.Forms.DataGridViewTextBoxColumn tan_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn thay;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn tan_so_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn triagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn tan_so_3;
    }
}

