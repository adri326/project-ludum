namespace unoM.Views
{
    partial class VRemindPassword
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRemindPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnFrench = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(215)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(960, 529);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(215)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(850, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnglish.BackgroundImage")));
            this.btnEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnglish.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnglish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.Location = new System.Drawing.Point(1665, 109);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(106, 69);
            this.btnEnglish.TabIndex = 12;
            this.btnEnglish.UseVisualStyleBackColor = false;
            // 
            // btnFrench
            // 
            this.btnFrench.BackColor = System.Drawing.Color.Transparent;
            this.btnFrench.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrench.BackgroundImage")));
            this.btnFrench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrench.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrench.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFrench.FlatAppearance.BorderSize = 0;
            this.btnFrench.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFrench.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFrench.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrench.ForeColor = System.Drawing.Color.White;
            this.btnFrench.Location = new System.Drawing.Point(1665, 20);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(106, 72);
            this.btnFrench.TabIndex = 11;
            this.btnFrench.UseVisualStyleBackColor = false;
            // 
            // VRemindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "VRemindPassword";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.VRemindPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnFrench;
    }
}
