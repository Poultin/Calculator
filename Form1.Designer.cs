namespace my_First_Projectt
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
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.rakam3Button = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.esıttırButton = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.TemızleButton = new System.Windows.Forms.Button();
            this.boluButton = new System.Windows.Forms.Button();
            this.carpıButton = new System.Windows.Forms.Button();
            this.eksıButton = new System.Windows.Forms.Button();
            this.artıButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(12, 20);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 77);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1Button
            // 
            this.rakam1Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(12, 109);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(75, 75);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = false;
            this.rakam1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(93, 109);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(75, 75);
            this.rakam2Button.TabIndex = 2;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = false;
            this.rakam2Button.Click += new System.EventHandler(this.rakam2Button_Click);
            // 
            // rakam3Button
            // 
            this.rakam3Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3Button.Location = new System.Drawing.Point(174, 109);
            this.rakam3Button.Name = "rakam3Button";
            this.rakam3Button.Size = new System.Drawing.Size(75, 75);
            this.rakam3Button.TabIndex = 3;
            this.rakam3Button.Text = "3";
            this.rakam3Button.UseVisualStyleBackColor = false;
            this.rakam3Button.Click += new System.EventHandler(this.rakam3Button_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(174, 199);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(75, 75);
            this.rakam6Button.TabIndex = 6;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = false;
            this.rakam6Button.Click += new System.EventHandler(this.rakam6Button_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(93, 199);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(75, 75);
            this.rakam5Button.TabIndex = 5;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = false;
            this.rakam5Button.Click += new System.EventHandler(this.rakam5Button_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(12, 199);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(75, 75);
            this.rakam4Button.TabIndex = 4;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = false;
            this.rakam4Button.Click += new System.EventHandler(this.rakam4Button_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(174, 280);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(75, 75);
            this.rakam9Button.TabIndex = 9;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = false;
            this.rakam9Button.Click += new System.EventHandler(this.rakam9Button_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(93, 280);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(75, 75);
            this.rakam8Button.TabIndex = 8;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = false;
            this.rakam8Button.Click += new System.EventHandler(this.rakam8Button_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(12, 280);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(75, 75);
            this.rakam7Button.TabIndex = 7;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = false;
            this.rakam7Button.Click += new System.EventHandler(this.rakam7Button_Click);
            // 
            // esıttırButton
            // 
            this.esıttırButton.BackColor = System.Drawing.Color.Yellow;
            this.esıttırButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esıttırButton.Location = new System.Drawing.Point(174, 361);
            this.esıttırButton.Name = "esıttırButton";
            this.esıttırButton.Size = new System.Drawing.Size(75, 75);
            this.esıttırButton.TabIndex = 12;
            this.esıttırButton.Text = "=";
            this.esıttırButton.UseVisualStyleBackColor = false;
            this.esıttırButton.Click += new System.EventHandler(this.esıttırButton_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(93, 361);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(75, 75);
            this.rakam0Button.TabIndex = 11;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = false;
            this.rakam0Button.Click += new System.EventHandler(this.rakam0Button_Click);
            // 
            // TemızleButton
            // 
            this.TemızleButton.BackColor = System.Drawing.Color.Red;
            this.TemızleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemızleButton.ForeColor = System.Drawing.Color.White;
            this.TemızleButton.Location = new System.Drawing.Point(12, 361);
            this.TemızleButton.Name = "TemızleButton";
            this.TemızleButton.Size = new System.Drawing.Size(75, 75);
            this.TemızleButton.TabIndex = 10;
            this.TemızleButton.Text = "C";
            this.TemızleButton.UseVisualStyleBackColor = false;
            this.TemızleButton.Click += new System.EventHandler(this.TemızleButton_Click);
            // 
            // boluButton
            // 
            this.boluButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.boluButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boluButton.Location = new System.Drawing.Point(255, 361);
            this.boluButton.Name = "boluButton";
            this.boluButton.Size = new System.Drawing.Size(75, 75);
            this.boluButton.TabIndex = 16;
            this.boluButton.Text = "/";
            this.boluButton.UseVisualStyleBackColor = false;
            this.boluButton.Click += new System.EventHandler(this.boluButton_Click);
            // 
            // carpıButton
            // 
            this.carpıButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.carpıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpıButton.Location = new System.Drawing.Point(255, 280);
            this.carpıButton.Name = "carpıButton";
            this.carpıButton.Size = new System.Drawing.Size(75, 75);
            this.carpıButton.TabIndex = 15;
            this.carpıButton.Text = "X";
            this.carpıButton.UseVisualStyleBackColor = false;
            this.carpıButton.Click += new System.EventHandler(this.carpıButton_Click);
            // 
            // eksıButton
            // 
            this.eksıButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.eksıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksıButton.Location = new System.Drawing.Point(255, 199);
            this.eksıButton.Name = "eksıButton";
            this.eksıButton.Size = new System.Drawing.Size(75, 75);
            this.eksıButton.TabIndex = 14;
            this.eksıButton.Text = "-";
            this.eksıButton.UseVisualStyleBackColor = false;
            this.eksıButton.Click += new System.EventHandler(this.eksıButton_Click);
            // 
            // artıButton
            // 
            this.artıButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.artıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artıButton.Location = new System.Drawing.Point(255, 109);
            this.artıButton.Name = "artıButton";
            this.artıButton.Size = new System.Drawing.Size(75, 75);
            this.artıButton.TabIndex = 13;
            this.artıButton.Text = "+";
            this.artıButton.UseVisualStyleBackColor = false;
            this.artıButton.Click += new System.EventHandler(this.artıButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 445);
            this.Controls.Add(this.boluButton);
            this.Controls.Add(this.carpıButton);
            this.Controls.Add(this.eksıButton);
            this.Controls.Add(this.artıButton);
            this.Controls.Add(this.esıttırButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.TemızleButton);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.rakam3Button);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button rakam3Button;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button esıttırButton;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button TemızleButton;
        private System.Windows.Forms.Button boluButton;
        private System.Windows.Forms.Button carpıButton;
        private System.Windows.Forms.Button eksıButton;
        private System.Windows.Forms.Button artıButton;
    }
}

