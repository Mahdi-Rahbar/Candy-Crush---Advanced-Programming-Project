
namespace Candy_Crush
{
    partial class PlayerMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenuFrm));
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.matchBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.Location = new System.Drawing.Point(420, 202);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(180, 74);
            this.playBtn.TabIndex = 2;
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.playBtn_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.playBtn_MouseLeave);
            // 
            // matchBtn
            // 
            this.matchBtn.BackColor = System.Drawing.Color.Transparent;
            this.matchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("matchBtn.BackgroundImage")));
            this.matchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.matchBtn.Location = new System.Drawing.Point(420, 321);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(180, 74);
            this.matchBtn.TabIndex = 3;
            this.matchBtn.TabStop = false;
            this.matchBtn.MouseEnter += new System.EventHandler(this.matchBtn_MouseEnter);
            this.matchBtn.MouseLeave += new System.EventHandler(this.matchBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.Location = new System.Drawing.Point(420, 440);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(180, 74);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playerNameLbl.Location = new System.Drawing.Point(70, 44);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(160, 34);
            this.playerNameLbl.TabIndex = 5;
            this.playerNameLbl.Text = "Hi Mahdi !";
            // 
            // PlayerMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.playerNameLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.matchBtn);
            this.Controls.Add(this.playBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerMenuFrm";
            this.ShowInTaskbar = false;
            this.Text = "Candy Crush";
            this.Load += new System.EventHandler(this.PlayerMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.PictureBox matchBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label playerNameLbl;
    }
}