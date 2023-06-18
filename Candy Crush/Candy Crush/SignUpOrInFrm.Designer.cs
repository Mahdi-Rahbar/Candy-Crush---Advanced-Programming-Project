
namespace Candy_Crush
{
    partial class SignUPOrInFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUPOrInFrm));
            this.signUpOrInFrame = new System.Windows.Forms.PictureBox();
            this.signUPBtn = new System.Windows.Forms.PictureBox();
            this.signInBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signUpOrInFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUPBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpOrInFrame
            // 
            this.signUpOrInFrame.BackColor = System.Drawing.Color.Transparent;
            this.signUpOrInFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpOrInFrame.BackgroundImage")));
            this.signUpOrInFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signUpOrInFrame.Location = new System.Drawing.Point(269, 228);
            this.signUpOrInFrame.Name = "signUpOrInFrame";
            this.signUpOrInFrame.Size = new System.Drawing.Size(430, 389);
            this.signUpOrInFrame.TabIndex = 0;
            this.signUpOrInFrame.TabStop = false;
            // 
            // signUPBtn
            // 
            this.signUPBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUPBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUPBtn.BackgroundImage")));
            this.signUPBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signUPBtn.Location = new System.Drawing.Point(385, 357);
            this.signUPBtn.Name = "signUPBtn";
            this.signUPBtn.Size = new System.Drawing.Size(194, 95);
            this.signUPBtn.TabIndex = 1;
            this.signUPBtn.TabStop = false;
            this.signUPBtn.Click += new System.EventHandler(this.signUPBtn_Click);
            this.signUPBtn.MouseEnter += new System.EventHandler(this.signUPBtn_MouseEnter);
            this.signUPBtn.MouseLeave += new System.EventHandler(this.signUPBtn_MouseLeave);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInBtn.BackgroundImage")));
            this.signInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signInBtn.Location = new System.Drawing.Point(385, 458);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(194, 95);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.TabStop = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            this.signInBtn.MouseEnter += new System.EventHandler(this.signInBtn_MouseEnter);
            this.signInBtn.MouseLeave += new System.EventHandler(this.signInBtn_MouseLeave);
            // 
            // SignUPOrInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUPBtn);
            this.Controls.Add(this.signUpOrInFrame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUPOrInFrm";
            this.Text = "Candy Crush";
            this.Load += new System.EventHandler(this.SignUPOrInFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signUpOrInFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUPBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox signUpOrInFrame;
        private System.Windows.Forms.PictureBox signUPBtn;
        private System.Windows.Forms.PictureBox signInBtn;
    }
}

