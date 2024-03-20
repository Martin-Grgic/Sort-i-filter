namespace Online_rezervacija_hotela_MAIN
{
    partial class SobaForm
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
            this.ListBoxSoba = new System.Windows.Forms.ListBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SearchSoba = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SortSoba = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListBoxSoba
            // 
            this.ListBoxSoba.FormattingEnabled = true;
            this.ListBoxSoba.ItemHeight = 16;
            this.ListBoxSoba.Location = new System.Drawing.Point(113, 76);
            this.ListBoxSoba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxSoba.Name = "ListBoxSoba";
            this.ListBoxSoba.Size = new System.Drawing.Size(291, 372);
            this.ListBoxSoba.TabIndex = 0;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(718, 131);
            this.DodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(152, 53);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(718, 225);
            this.UrediButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(152, 47);
            this.UrediButton.TabIndex = 2;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.UrediButton_Click);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(718, 322);
            this.ObrisiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(152, 50);
            this.ObrisiButton.TabIndex = 3;
            this.ObrisiButton.Text = "Obrisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(931, 225);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 48);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SearchSoba
            // 
            this.SearchSoba.Location = new System.Drawing.Point(477, 65);
            this.SearchSoba.Name = "SearchSoba";
            this.SearchSoba.Size = new System.Drawing.Size(167, 22);
            this.SearchSoba.TabIndex = 5;
            this.SearchSoba.TextChanged += new System.EventHandler(this.SearchSoba_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(474, 46);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 16);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            // 
            // SortSoba
            // 
            this.SortSoba.FormattingEnabled = true;
            this.SortSoba.Items.AddRange(new object[] {
            "cijenaNoci",
            "velicinaSobe"});
            this.SortSoba.Location = new System.Drawing.Point(477, 160);
            this.SortSoba.Name = "SortSoba";
            this.SortSoba.Size = new System.Drawing.Size(167, 24);
            this.SortSoba.TabIndex = 7;
            this.SortSoba.SelectedIndexChanged += new System.EventHandler(this.FilterSoba_SelectedIndexChanged);
            // 
            // SobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SortSoba);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchSoba);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ListBoxSoba);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SobaForm";
            this.Text = "Soba";
            this.Load += new System.EventHandler(this.Soba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxSoba;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button ObrisiButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox SearchSoba;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox SortSoba;
    }
}