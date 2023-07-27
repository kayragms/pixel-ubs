namespace piXel_UBS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonkayıt = new System.Windows.Forms.Button();
            this.buttongoruntule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonkayıt
            // 
            this.buttonkayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkayıt.Location = new System.Drawing.Point(295, 354);
            this.buttonkayıt.Name = "buttonkayıt";
            this.buttonkayıt.Size = new System.Drawing.Size(117, 56);
            this.buttonkayıt.TabIndex = 2;
            this.buttonkayıt.Text = "ÜYE \r\nKAYIT";
            this.buttonkayıt.UseVisualStyleBackColor = true;
            this.buttonkayıt.Click += new System.EventHandler(this.buttonkayıt_Click);
            // 
            // buttongoruntule
            // 
            this.buttongoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongoruntule.Location = new System.Drawing.Point(119, 354);
            this.buttongoruntule.Name = "buttongoruntule";
            this.buttongoruntule.Size = new System.Drawing.Size(117, 56);
            this.buttongoruntule.TabIndex = 3;
            this.buttongoruntule.Text = "ÜYE GÖRÜNTÜLE";
            this.buttongoruntule.UseVisualStyleBackColor = true;
            this.buttongoruntule.Click += new System.EventHandler(this.buttongoruntule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 490);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 493);
            this.Controls.Add(this.buttongoruntule);
            this.Controls.Add(this.buttonkayıt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonkayıt;
        private System.Windows.Forms.Button buttongoruntule;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

