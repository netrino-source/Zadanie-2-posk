namespace Zadanie2
{
    partial class Menu
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
            this.lbltxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxwybierztest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.Location = new System.Drawing.Point(249, 137);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(241, 21);
            this.lbltxt.TabIndex = 0;
            this.lbltxt.Text = "Wybierz rodzaj testu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxwybierztest
            // 
            this.comboBoxwybierztest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxwybierztest.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxwybierztest.FormattingEnabled = true;
            this.comboBoxwybierztest.Items.AddRange(new object[] {
            "Bodźce proste optyczne",
            "Bodźce proste akustyczne",
            "Bodźce złożone optyczne",
            "Bodźce złożone akustyczne"});
            this.comboBoxwybierztest.Location = new System.Drawing.Point(555, 230);
            this.comboBoxwybierztest.Name = "comboBoxwybierztest";
            this.comboBoxwybierztest.Size = new System.Drawing.Size(121, 27);
            this.comboBoxwybierztest.TabIndex = 2;
            this.comboBoxwybierztest.SelectedIndexChanged += new System.EventHandler(this.comboBoxwybierztest_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxwybierztest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu główne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxwybierztest;
    }
}