namespace Currency_Converter
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
            this.rupiah_inp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matauang_cmb = new System.Windows.Forms.ComboBox();
            this.hasil_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Nilai Mata Uang Rupiah";
            // 
            // rupiah_inp
            // 
            this.rupiah_inp.Location = new System.Drawing.Point(28, 65);
            this.rupiah_inp.Name = "rupiah_inp";
            this.rupiah_inp.Size = new System.Drawing.Size(120, 20);
            this.rupiah_inp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai Rupiah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mata Uang";
            // 
            // matauang_cmb
            // 
            this.matauang_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matauang_cmb.FormattingEnabled = true;
            this.matauang_cmb.Items.AddRange(new object[] {
            "USD",
            "MYR",
            "CNY",
            "SGD",
            "JPY"});
            this.matauang_cmb.Location = new System.Drawing.Point(177, 64);
            this.matauang_cmb.Name = "matauang_cmb";
            this.matauang_cmb.Size = new System.Drawing.Size(118, 21);
            this.matauang_cmb.TabIndex = 4;
            // 
            // hasil_txt
            // 
            this.hasil_txt.AutoSize = true;
            this.hasil_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hasil_txt.Font = new System.Drawing.Font("Poppins ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil_txt.ForeColor = System.Drawing.Color.Goldenrod;
            this.hasil_txt.Location = new System.Drawing.Point(19, 158);
            this.hasil_txt.Name = "hasil_txt";
            this.hasil_txt.Size = new System.Drawing.Size(96, 51);
            this.hasil_txt.TabIndex = 5;
            this.hasil_txt.Text = "hasil";
            this.hasil_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Konversi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(324, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hasil_txt);
            this.Controls.Add(this.matauang_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rupiah_inp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rupiah_inp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox matauang_cmb;
        private System.Windows.Forms.Label hasil_txt;
        private System.Windows.Forms.Button button1;
    }
}

