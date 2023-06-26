
namespace Candy_Crush
{
    partial class LoseFrm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.loseLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(156, 277);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(154, 59);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(150, 190);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(113, 32);
            this.scoreLbl.TabIndex = 12;
            this.scoreLbl.Text = "Score :";
            // 
            // loseLbl
            // 
            this.loseLbl.AutoSize = true;
            this.loseLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLbl.Location = new System.Drawing.Point(148, 87);
            this.loseLbl.Name = "loseLbl";
            this.loseLbl.Size = new System.Drawing.Size(220, 46);
            this.loseLbl.TabIndex = 11;
            this.loseLbl.Text = "You Lose !";
            // 
            // LoseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.loseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoseFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.LoseFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label loseLbl;
    }
}