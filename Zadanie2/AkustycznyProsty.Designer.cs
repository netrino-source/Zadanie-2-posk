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
            this.lbltext = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoEllipsis = true;
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltext.Location = new System.Drawing.Point(231, 146);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(318, 21);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Kliknij START, aby rozpocząć";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(281, 270);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(234, 86);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = " START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // AkustycznyProsty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbltext);
            this.Name = "AkustycznyProsty";
            this.Text = "AkustycznyProsty";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AkustycznyProsty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button btnstart;
    }
}