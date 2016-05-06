namespace lab3
{
    partial class MainFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gammaLB = new System.Windows.Forms.Label();
            this.gammaTB = new System.Windows.Forms.TextBox();
            this.decTB = new System.Windows.Forms.TextBox();
            this.decLB = new System.Windows.Forms.Label();
            this.encTB = new System.Windows.Forms.TextBox();
            this.encLB = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.encBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gammaLB
            // 
            this.gammaLB.AutoSize = true;
            this.gammaLB.Location = new System.Drawing.Point(12, 85);
            this.gammaLB.Name = "gammaLB";
            this.gammaLB.Size = new System.Drawing.Size(97, 17);
            this.gammaLB.TabIndex = 0;
            this.gammaLB.Text = "Gamma (hex):";
            // 
            // gammaTB
            // 
            this.gammaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gammaTB.Location = new System.Drawing.Point(12, 105);
            this.gammaTB.Multiline = true;
            this.gammaTB.Name = "gammaTB";
            this.gammaTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gammaTB.Size = new System.Drawing.Size(298, 48);
            this.gammaTB.TabIndex = 1;
            // 
            // decTB
            // 
            this.decTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decTB.Location = new System.Drawing.Point(12, 29);
            this.decTB.Multiline = true;
            this.decTB.Name = "decTB";
            this.decTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decTB.Size = new System.Drawing.Size(298, 48);
            this.decTB.TabIndex = 3;
            // 
            // decLB
            // 
            this.decLB.AutoSize = true;
            this.decLB.Location = new System.Drawing.Point(12, 9);
            this.decLB.Name = "decLB";
            this.decLB.Size = new System.Drawing.Size(77, 17);
            this.decLB.TabIndex = 2;
            this.decLB.Text = "Decrypted:";
            // 
            // encTB
            // 
            this.encTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encTB.Location = new System.Drawing.Point(12, 181);
            this.encTB.Multiline = true;
            this.encTB.Name = "encTB";
            this.encTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encTB.Size = new System.Drawing.Size(298, 48);
            this.encTB.TabIndex = 5;
            // 
            // encLB
            // 
            this.encLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.encLB.AutoSize = true;
            this.encLB.Location = new System.Drawing.Point(12, 161);
            this.encLB.Name = "encLB";
            this.encLB.Size = new System.Drawing.Size(112, 17);
            this.encLB.TabIndex = 4;
            this.encLB.Text = "Encrypted (hex):";
            // 
            // genBtn
            // 
            this.genBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genBtn.Location = new System.Drawing.Point(12, 238);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(298, 32);
            this.genBtn.TabIndex = 6;
            this.genBtn.Text = "Generate gamma";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // encBtn
            // 
            this.encBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.encBtn.Location = new System.Drawing.Point(12, 276);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(120, 32);
            this.encBtn.TabIndex = 7;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decBtn.Location = new System.Drawing.Point(190, 276);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(120, 32);
            this.decBtn.TabIndex = 8;
            this.decBtn.Text = "Decrypt";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 321);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.encBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.encTB);
            this.Controls.Add(this.encLB);
            this.Controls.Add(this.decTB);
            this.Controls.Add(this.decLB);
            this.Controls.Add(this.gammaTB);
            this.Controls.Add(this.gammaLB);
            this.MinimumSize = new System.Drawing.Size(280, 366);
            this.Name = "MainFrm";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gammaLB;
        private System.Windows.Forms.TextBox gammaTB;
        private System.Windows.Forms.TextBox decTB;
        private System.Windows.Forms.Label decLB;
        private System.Windows.Forms.TextBox encTB;
        private System.Windows.Forms.Label encLB;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.Button decBtn;
    }
}

