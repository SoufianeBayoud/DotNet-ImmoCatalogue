namespace ImmoWEBProject
{
    partial class AddKlant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Naam_tb = new System.Windows.Forms.TextBox();
            this.Straat_tb = new System.Windows.Forms.TextBox();
            this.Nummer_tb = new System.Windows.Forms.TextBox();
            this.AddKlant_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Straat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nummer:";
            // 
            // Naam_tb
            // 
            this.Naam_tb.Location = new System.Drawing.Point(96, 36);
            this.Naam_tb.Name = "Naam_tb";
            this.Naam_tb.Size = new System.Drawing.Size(692, 23);
            this.Naam_tb.TabIndex = 6;
            // 
            // Straat_tb
            // 
            this.Straat_tb.Location = new System.Drawing.Point(160, 101);
            this.Straat_tb.Name = "Straat_tb";
            this.Straat_tb.Size = new System.Drawing.Size(628, 23);
            this.Straat_tb.TabIndex = 7;
            // 
            // Nummer_tb
            // 
            this.Nummer_tb.Location = new System.Drawing.Point(160, 142);
            this.Nummer_tb.Name = "Nummer_tb";
            this.Nummer_tb.Size = new System.Drawing.Size(628, 23);
            this.Nummer_tb.TabIndex = 8;
            this.Nummer_tb.TextChanged += new System.EventHandler(this.Nummer_tb_TextChanged);
            this.Nummer_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nummer_tb_KeyPress);
            // 
            // AddKlant_btn
            // 
            this.AddKlant_btn.Location = new System.Drawing.Point(352, 280);
            this.AddKlant_btn.Name = "AddKlant_btn";
            this.AddKlant_btn.Size = new System.Drawing.Size(110, 32);
            this.AddKlant_btn.TabIndex = 10;
            this.AddKlant_btn.Text = "Toevoegen";
            this.AddKlant_btn.UseVisualStyleBackColor = true;
            this.AddKlant_btn.Click += new System.EventHandler(this.AddKlant_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(96, 71);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(692, 23);
            this.Email_TB.TabIndex = 13;
            // 
            // AddKlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddKlant_btn);
            this.Controls.Add(this.Nummer_tb);
            this.Controls.Add(this.Straat_tb);
            this.Controls.Add(this.Naam_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddKlant";
            this.Text = "AddKlant";
            this.Load += new System.EventHandler(this.AddKlant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddKlant_btn;
        public TextBox Naam_tb;
        public TextBox Straat_tb;
        public TextBox Nummer_tb;
        private Label label7;
        private TextBox Email_TB;
    }
}