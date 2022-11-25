namespace ImmoWEBProject
{
    partial class EmailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.Subject_tb = new System.Windows.Forms.TextBox();
            this.Body_tb = new System.Windows.Forms.TextBox();
            this.Email_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact the owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body:";
            // 
            // Email_tb
            // 
            this.Email_tb.Location = new System.Drawing.Point(109, 80);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(329, 23);
            this.Email_tb.TabIndex = 4;
            // 
            // Subject_tb
            // 
            this.Subject_tb.Location = new System.Drawing.Point(109, 123);
            this.Subject_tb.Name = "Subject_tb";
            this.Subject_tb.Size = new System.Drawing.Size(329, 23);
            this.Subject_tb.TabIndex = 5;
            // 
            // Body_tb
            // 
            this.Body_tb.Location = new System.Drawing.Point(109, 168);
            this.Body_tb.Multiline = true;
            this.Body_tb.Name = "Body_tb";
            this.Body_tb.Size = new System.Drawing.Size(329, 215);
            this.Body_tb.TabIndex = 6;
            // 
            // Email_button
            // 
            this.Email_button.Location = new System.Drawing.Point(195, 421);
            this.Email_button.Name = "Email_button";
            this.Email_button.Size = new System.Drawing.Size(151, 42);
            this.Email_button.TabIndex = 7;
            this.Email_button.Text = "Send Email";
            this.Email_button.UseVisualStyleBackColor = true;
            this.Email_button.Click += new System.EventHandler(this.Email_button_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 499);
            this.Controls.Add(this.Email_button);
            this.Controls.Add(this.Body_tb);
            this.Controls.Add(this.Subject_tb);
            this.Controls.Add(this.Email_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmailForm";
            this.Text = "Hello ";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Email_tb;
        private TextBox Subject_tb;
        private TextBox Body_tb;
        private Button Email_button;
    }
}