namespace Xml_HavaDurumu
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
            this.btnHavaDurumuBilgiAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHavaDurumuBilgiAl
            // 
            this.btnHavaDurumuBilgiAl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavaDurumuBilgiAl.Location = new System.Drawing.Point(12, 27);
            this.btnHavaDurumuBilgiAl.Name = "btnHavaDurumuBilgiAl";
            this.btnHavaDurumuBilgiAl.Size = new System.Drawing.Size(369, 38);
            this.btnHavaDurumuBilgiAl.TabIndex = 0;
            this.btnHavaDurumuBilgiAl.Text = "Hava Durumu Bilgileri Al";
            this.btnHavaDurumuBilgiAl.UseVisualStyleBackColor = true;
            this.btnHavaDurumuBilgiAl.Click += new System.EventHandler(this.btnHavaDurumuBilgiAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İli,
            this.Durum,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // İli
            // 
            this.İli.HeaderText = "İli";
            this.İli.Name = "İli";
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Maksimum Sıcaklık";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(393, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHavaDurumuBilgiAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHavaDurumuBilgiAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

