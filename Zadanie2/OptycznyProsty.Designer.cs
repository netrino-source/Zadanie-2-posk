namespace Zadanie2
{
    partial class Optycznyprosty
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
            this.lblinfotext = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinfotext
            // 
            this.lblinfotext.AutoSize = true;
            this.lblinfotext.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfotext.Location = new System.Drawing.Point(252, 132);
            this.lblinfotext.Name = "lblinfotext";
            this.lblinfotext.Size = new System.Drawing.Size(307, 21);
            this.lblinfotext.TabIndex = 0;
            this.lblinfotext.Text = "Kliknij start aby rozpocząć";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(292, 242);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(237, 98);
            this.btnstart.TabIndex = 1;
            this.btnstart.Tag = "";
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Optycznyprosty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblinfotext);
            this.Name = "Optycznyprosty";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbltext_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfotext;
        public System.Windows.Forms.Button btnstart;
    }
}