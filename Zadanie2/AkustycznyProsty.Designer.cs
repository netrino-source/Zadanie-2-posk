namespace Zadanie2
{
    partial class AkustycznyProsty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkustycznyProsty));
            this.buttonRozpocznij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InstrukcjaAkustycznyProsty = new System.Windows.Forms.Label();
            this.Polecenie123 = new System.Windows.Forms.Label();
            this.buttonDzwiek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRozpocznij
            // 
            this.buttonRozpocznij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.buttonRozpocznij.FlatAppearance.BorderSize = 0;
            this.buttonRozpocznij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRozpocznij.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRozpocznij.ForeColor = System.Drawing.Color.White;
            this.buttonRozpocznij.Location = new System.Drawing.Point(251, 324);
            this.buttonRozpocznij.Name = "buttonRozpocznij";
            this.buttonRozpocznij.Size = new System.Drawing.Size(300, 60);
            this.buttonRozpocznij.TabIndex = 0;
            this.buttonRozpocznij.Text = "ROZPOCZNIJ TEST";
            this.buttonRozpocznij.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // InstrukcjaAkustycznyProsty
            // 
            this.InstrukcjaAkustycznyProsty.BackColor = System.Drawing.Color.Azure;
            this.InstrukcjaAkustycznyProsty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstrukcjaAkustycznyProsty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstrukcjaAkustycznyProsty.ForeColor = System.Drawing.Color.Black;
            this.InstrukcjaAkustycznyProsty.Location = new System.Drawing.Point(144, 46);
            this.InstrukcjaAkustycznyProsty.MaximumSize = new System.Drawing.Size(500, 400);
            this.InstrukcjaAkustycznyProsty.Name = "InstrukcjaAkustycznyProsty";
            this.InstrukcjaAkustycznyProsty.Size = new System.Drawing.Size(500, 169);
            this.InstrukcjaAkustycznyProsty.TabIndex = 2;
            this.InstrukcjaAkustycznyProsty.Text = resources.GetString("InstrukcjaAkustycznyProsty.Text");
            // 
            // Polecenie123
            // 
            this.Polecenie123.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Polecenie123.ForeColor = System.Drawing.Color.DarkRed;
            this.Polecenie123.Location = new System.Drawing.Point(56, 9);
            this.Polecenie123.MaximumSize = new System.Drawing.Size(700, 100);
            this.Polecenie123.Name = "Polecenie123";
            this.Polecenie123.Size = new System.Drawing.Size(700, 94);
            this.Polecenie123.TabIndex = 3;
            this.Polecenie123.Text = "W tym zadaniu usłyszysz ton niski, wysoki lub szum. Po usłyszeniu dźwięku naciśni" +
    "j spację lub przycisk \"DŹWIĘK\".\r\n";
            this.Polecenie123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDzwiek
            // 
            this.buttonDzwiek.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDzwiek.FlatAppearance.BorderSize = 0;
            this.buttonDzwiek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDzwiek.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDzwiek.ForeColor = System.Drawing.Color.White;
            this.buttonDzwiek.Location = new System.Drawing.Point(300, 250);
            this.buttonDzwiek.Name = "buttonDzwiek";
            this.buttonDzwiek.Size = new System.Drawing.Size(200, 50);
            this.buttonDzwiek.TabIndex = 4;
            this.buttonDzwiek.Text = "DŻWIĘK";
            this.buttonDzwiek.UseVisualStyleBackColor = false;
            // 
            // AkustycznyProsty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDzwiek);
            this.Controls.Add(this.Polecenie123);
            this.Controls.Add(this.InstrukcjaAkustycznyProsty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRozpocznij);
            this.Name = "AkustycznyProsty";
            this.Text = "AkustycznyProsty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRozpocznij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InstrukcjaAkustycznyProsty;
        private System.Windows.Forms.Label Polecenie123;
        private System.Windows.Forms.Button buttonDzwiek;
    }
}