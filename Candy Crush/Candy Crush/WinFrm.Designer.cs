
namespace Candy_Crush
{
    partial class WinFrm
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
            this.winLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.Location = new System.Drawing.Point(147, 100);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(199, 46);
            this.winLbl.TabIndex = 0;
            this.winLbl.Text = "You Win !";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(149, 203);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(113, 32);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Score :";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(155, 290);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(154, 59);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // WinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.winLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.WinFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}