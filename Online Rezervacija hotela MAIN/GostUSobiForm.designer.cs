namespace Online_rezervacija_hotela_MAIN
{
    partial class GostUSobiForm
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
            this.ListBoxGostUSobi = new System.Windows.Forms.ListBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxGostUSobi
            // 
            this.ListBoxGostUSobi.FormattingEnabled = true;
            this.ListBoxGostUSobi.ItemHeight = 16;
            this.ListBoxGostUSobi.Location = new System.Drawing.Point(101, 74);
            this.ListBoxGostUSobi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxGostUSobi.Name = "ListBoxGostUSobi";
            this.ListBoxGostUSobi.Size = new System.Drawing.Size(291, 372);
            this.ListBoxGostUSobi.TabIndex = 1;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(525, 117);
            this.DodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(152, 53);
            this.DodajButton.TabIndex = 2;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(525, 239);
            this.UrediButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(152, 47);
            this.UrediButton.TabIndex = 3;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.UrediButton_Click);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(525, 359);
            this.ObrisiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(152, 50);
            this.ObrisiButton.TabIndex = 4;
            this.ObrisiButton.Text = "Obrisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // GostUSobiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ListBoxGostUSobi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GostUSobiForm";
            this.Text = "GostUSobi";
            this.Load += new System.EventHandler(this.GostUSobiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGostUSobi;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button ObrisiButton;
    }
}