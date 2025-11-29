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
            this.button_wyjscie = new System.Windows.Forms.Button();
            this.comboBoxWybierzTest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_wyjscie.FlatAppearance.BorderSize = 0;
            this.button_wyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wyjscie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyjscie.ForeColor = System.Drawing.Color.White;
            this.button_wyjscie.Location = new System.Drawing.Point(654, 365);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(120, 60);
            this.button_wyjscie.TabIndex = 0;
            this.button_wyjscie.Text = "WYJŚCIE";
            this.button_wyjscie.UseVisualStyleBackColor = false;
            this.button_wyjscie.Click += new System.EventHandler(this.button_wyjscie_Click);
            // 
            // comboBoxWybierzTest
            // 
            this.comboBoxWybierzTest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxWybierzTest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxWybierzTest.ForeColor = System.Drawing.Color.Black;
            this.comboBoxWybierzTest.FormattingEnabled = true;
            this.comboBoxWybierzTest.Items.AddRange(new object[] {
            "Bodźce złożone akustyczne",
            "Bodźce złożone optyczne",
            "Bodźce proste akustyczne",
            "Bodźce proste optyczne"});
            this.comboBoxWybierzTest.Location = new System.Drawing.Point(206, 161);
            this.comboBoxWybierzTest.Name = "comboBoxWybierzTest";
            this.comboBoxWybierzTest.Size = new System.Drawing.Size(420, 31);
            this.comboBoxWybierzTest.TabIndex = 1;
            this.comboBoxWybierzTest.Text = "Wybierz rodzaj testu:";
            this.comboBoxWybierzTest.SelectedIndexChanged += new System.EventHandler(this.comboBoxWybierzTest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TESTY SZYBKOŚCI REAKCJI NA BODŹCE ZŁOŻONE I PROSTE DLA KIEROWCÓW";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Zadanie2.Properties.Resources.pexels_pixabay_56832jasny;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWybierzTest);
            this.Controls.Add(this.button_wyjscie);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_wyjscie;
        private System.Windows.Forms.ComboBox comboBoxWybierzTest;
        private System.Windows.Forms.Label label1;
    }
}