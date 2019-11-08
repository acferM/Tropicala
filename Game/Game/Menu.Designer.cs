namespace Game
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(517, 311);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(184, 53);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditos.BackgroundImage")));
            this.btnCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreditos.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCreditos.FlatAppearance.BorderSize = 0;
            this.btnCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreditos.Location = new System.Drawing.Point(491, 391);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(250, 63);
            this.btnCreditos.TabIndex = 1;
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 601);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCreditos;
    }
}

