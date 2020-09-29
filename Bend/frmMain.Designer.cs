namespace Bend
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClenovi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCLenoviNaBend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzlez = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBend,
            this.mnuClenovi,
            this.mnuCLenoviNaBend,
            this.mnuIzlez});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBend
            // 
            this.mnuBend.Name = "mnuBend";
            this.mnuBend.Size = new System.Drawing.Size(46, 20);
            this.mnuBend.Text = "Bend";
            this.mnuBend.Click += new System.EventHandler(this.mnuBend_Click);
            // 
            // mnuClenovi
            // 
            this.mnuClenovi.Name = "mnuClenovi";
            this.mnuClenovi.Size = new System.Drawing.Size(59, 20);
            this.mnuClenovi.Text = "Clenovi";
            this.mnuClenovi.Click += new System.EventHandler(this.mnuClenovi_Click);
            // 
            // mnuCLenoviNaBend
            // 
            this.mnuCLenoviNaBend.Name = "mnuCLenoviNaBend";
            this.mnuCLenoviNaBend.Size = new System.Drawing.Size(105, 20);
            this.mnuCLenoviNaBend.Text = "Clenovi na bend";
            this.mnuCLenoviNaBend.Click += new System.EventHandler(this.mnuCLenoviNaBend_Click);
            // 
            // mnuIzlez
            // 
            this.mnuIzlez.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuIzlez.Name = "mnuIzlez";
            this.mnuIzlez.Size = new System.Drawing.Size(41, 20);
            this.mnuIzlez.Text = "Izlez";
            this.mnuIzlez.Click += new System.EventHandler(this.mnuIzlez_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Bend.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(578, 206);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(69, 64);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bend.Properties.Resources.bands;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 294);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Bendovi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBend;
        private System.Windows.Forms.ToolStripMenuItem mnuClenovi;
        private System.Windows.Forms.ToolStripMenuItem mnuCLenoviNaBend;
        private System.Windows.Forms.ToolStripMenuItem mnuIzlez;
        private System.Windows.Forms.Button btnPlay;
    }
}

