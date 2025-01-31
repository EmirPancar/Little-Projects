namespace Form02
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
            this.Zar1 = new System.Windows.Forms.TextBox();
            this.Zar2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // Zar1
            // 
            this.Zar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Zar1.Location = new System.Drawing.Point(82, 86);
            this.Zar1.Multiline = true;
            this.Zar1.Name = "Zar1";
            this.Zar1.Size = new System.Drawing.Size(124, 50);
            this.Zar1.TabIndex = 0;
            // 
            // Zar2
            // 
            this.Zar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Zar2.Location = new System.Drawing.Point(350, 86);
            this.Zar2.Multiline = true;
            this.Zar2.Name = "Zar2";
            this.Zar2.Size = new System.Drawing.Size(124, 50);
            this.Zar2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(172, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "AT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.Location = new System.Drawing.Point(172, 166);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(190, 69);
            this.a.TabIndex = 3;
            this.a.Text = "label1";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(112, 289);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(120, 150);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 4;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(319, 289);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(120, 150);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 5;
            this.p2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 567);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zar2);
            this.Controls.Add(this.Zar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Zar1;
        private System.Windows.Forms.TextBox Zar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
    }
}

