namespace Online_rezervacija_hotela_MAIN
{
    partial class RezervacijaForm
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
            this.SobaButton = new System.Windows.Forms.Button();
            this.ListBoxRezervacija = new System.Windows.Forms.ListBox();
            this.SobeIGostUSobiButton = new System.Windows.Forms.Button();
            this.IzlazButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.GostUSobiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SobaButton
            // 
            this.SobaButton.Location = new System.Drawing.Point(103, 52);
            this.SobaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SobaButton.Name = "SobaButton";
            this.SobaButton.Size = new System.Drawing.Size(136, 41);
            this.SobaButton.TabIndex = 0;
            this.SobaButton.Text = "Soba";
            this.SobaButton.UseVisualStyleBackColor = true;
            this.SobaButton.Click += new System.EventHandler(this.SobaButton_Click);
            // 
            // ListBoxRezervacija
            // 
            this.ListBoxRezervacija.FormattingEnabled = true;
            this.ListBoxRezervacija.ItemHeight = 16;
            this.ListBoxRezervacija.Location = new System.Drawing.Point(116, 124);
            this.ListBoxRezervacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxRezervacija.Name = "ListBoxRezervacija";
            this.ListBoxRezervacija.Size = new System.Drawing.Size(328, 356);
            this.ListBoxRezervacija.TabIndex = 2;
            // 
            // SobeIGostUSobiButton
            // 
            this.SobeIGostUSobiButton.Location = new System.Drawing.Point(593, 175);
            this.SobeIGostUSobiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SobeIGostUSobiButton.Name = "SobeIGostUSobiButton";
            this.SobeIGostUSobiButton.Size = new System.Drawing.Size(189, 50);
            this.SobeIGostUSobiButton.TabIndex = 3;
            this.SobeIGostUSobiButton.Text = "Sobe i gost u sobi";
            this.SobeIGostUSobiButton.UseVisualStyleBackColor = true;
            this.SobeIGostUSobiButton.Click += new System.EventHandler(this.SobeIGostUSobiButton_Click);
            // 
            // IzlazButton
            // 
            this.IzlazButton.Location = new System.Drawing.Point(593, 373);
            this.IzlazButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzlazButton.Name = "IzlazButton";
            this.IzlazButton.Size = new System.Drawing.Size(189, 50);
            this.IzlazButton.TabIndex = 5;
            this.IzlazButton.Text = "Izlaz";
            this.IzlazButton.UseVisualStyleBackColor = true;
            this.IzlazButton.Click += new System.EventHandler(this.IzlazButton_Click);
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(593, 271);
            this.DodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(189, 50);
            this.DodajButton.TabIndex = 6;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // GostUSobiButton
            // 
            this.GostUSobiButton.Location = new System.Drawing.Point(309, 52);
            this.GostUSobiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GostUSobiButton.Name = "GostUSobiButton";
            this.GostUSobiButton.Size = new System.Drawing.Size(136, 41);
            this.GostUSobiButton.TabIndex = 7;
            this.GostUSobiButton.Text = "Gost u sobi";
            this.GostUSobiButton.UseVisualStyleBackColor = true;
            this.GostUSobiButton.Click += new System.EventHandler(this.GostUSobiButton_Click);
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GostUSobiButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.IzlazButton);
            this.Controls.Add(this.SobeIGostUSobiButton);
            this.Controls.Add(this.ListBoxRezervacija);
            this.Controls.Add(this.SobaButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RezervacijaForm";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.RezervacijaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SobaButton;
        private System.Windows.Forms.ListBox ListBoxRezervacija;
        private System.Windows.Forms.Button SobeIGostUSobiButton;

        private System.Windows.Forms.Button IzlazButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button GostUSobiButton;
    }
}

