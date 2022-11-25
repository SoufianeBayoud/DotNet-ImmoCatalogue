namespace ImmoWEBProject
{
    partial class ImmoCatalogus
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Immo_Search_Btn = new System.Windows.Forms.Button();
            this.Search_TBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search_TBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AantalWoningen_Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWoningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenCtrlfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AantalKlanten_Btn = new System.Windows.Forms.Button();
            this.LinqOrderBy = new System.Windows.Forms.Button();
            this.LingOrderAscending = new System.Windows.Forms.Button();
            this.OrderByBouwjaarRecent_Btn = new System.Windows.Forms.Button();
            this.OrderByType_Btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 381);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Immo_Search_Btn);
            this.tabPage1.Controls.Add(this.Search_TBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Woningen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Immo_Search_Btn
            // 
            this.Immo_Search_Btn.Location = new System.Drawing.Point(213, 22);
            this.Immo_Search_Btn.Name = "Immo_Search_Btn";
            this.Immo_Search_Btn.Size = new System.Drawing.Size(113, 23);
            this.Immo_Search_Btn.TabIndex = 6;
            this.Immo_Search_Btn.Text = "Search Immo";
            this.Immo_Search_Btn.UseVisualStyleBackColor = true;
            this.Immo_Search_Btn.Click += new System.EventHandler(this.Immo_Search_Btn_Click);
            // 
            // Search_TBox1
            // 
            this.Search_TBox1.Location = new System.Drawing.Point(18, 22);
            this.Search_TBox1.Name = "Search_TBox1";
            this.Search_TBox1.Size = new System.Drawing.Size(189, 23);
            this.Search_TBox1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(566, 244);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Search_TBox);
            this.tabPage2.Controls.Add(this.searchButton);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klanten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Search_TBox
            // 
            this.Search_TBox.Location = new System.Drawing.Point(17, 24);
            this.Search_TBox.Name = "Search_TBox";
            this.Search_TBox.Size = new System.Drawing.Size(189, 23);
            this.Search_TBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(231, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search Klant";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(566, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AantalWoningen_Btn
            // 
            this.AantalWoningen_Btn.Location = new System.Drawing.Point(650, 76);
            this.AantalWoningen_Btn.Name = "AantalWoningen_Btn";
            this.AantalWoningen_Btn.Size = new System.Drawing.Size(142, 43);
            this.AantalWoningen_Btn.TabIndex = 1;
            this.AantalWoningen_Btn.Text = "Show aantal woningen";
            this.AantalWoningen_Btn.UseVisualStyleBackColor = true;
            this.AantalWoningen_Btn.Click += new System.EventHandler(this.AantalWoningen_Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beheerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKlantToolStripMenuItem,
            this.addWoningToolStripMenuItem,
            this.afsluitenCtrlfToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.beheerToolStripMenuItem.Text = "Beheer";
            // 
            // addKlantToolStripMenuItem
            // 
            this.addKlantToolStripMenuItem.Name = "addKlantToolStripMenuItem";
            this.addKlantToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addKlantToolStripMenuItem.Text = "Add Klant";
            this.addKlantToolStripMenuItem.Click += new System.EventHandler(this.addKlantToolStripMenuItem_Click);
            // 
            // addWoningToolStripMenuItem
            // 
            this.addWoningToolStripMenuItem.Name = "addWoningToolStripMenuItem";
            this.addWoningToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addWoningToolStripMenuItem.Text = "Add Woning";
            this.addWoningToolStripMenuItem.Click += new System.EventHandler(this.addWoningToolStripMenuItem_Click);
            // 
            // afsluitenCtrlfToolStripMenuItem
            // 
            this.afsluitenCtrlfToolStripMenuItem.Name = "afsluitenCtrlfToolStripMenuItem";
            this.afsluitenCtrlfToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.afsluitenCtrlfToolStripMenuItem.Text = "Afsluiten ctrl+f4";
            this.afsluitenCtrlfToolStripMenuItem.Click += new System.EventHandler(this.afsluitenCtrlfToolStripMenuItem_Click);
            // 
            // AantalKlanten_Btn
            // 
            this.AantalKlanten_Btn.Location = new System.Drawing.Point(650, 125);
            this.AantalKlanten_Btn.Name = "AantalKlanten_Btn";
            this.AantalKlanten_Btn.Size = new System.Drawing.Size(142, 43);
            this.AantalKlanten_Btn.TabIndex = 4;
            this.AantalKlanten_Btn.Text = "Show aantal Klanten";
            this.AantalKlanten_Btn.UseVisualStyleBackColor = true;
            this.AantalKlanten_Btn.Click += new System.EventHandler(this.AantalKlanten_Btn_Click);
            // 
            // LinqOrderBy
            // 
            this.LinqOrderBy.Location = new System.Drawing.Point(650, 174);
            this.LinqOrderBy.Name = "LinqOrderBy";
            this.LinqOrderBy.Size = new System.Drawing.Size(142, 43);
            this.LinqOrderBy.TabIndex = 5;
            this.LinqOrderBy.Text = "Order By Price Descending";
            this.LinqOrderBy.UseVisualStyleBackColor = true;
            this.LinqOrderBy.Click += new System.EventHandler(this.LinqOrderBy_Click_1);
            // 
            // LingOrderAscending
            // 
            this.LingOrderAscending.Location = new System.Drawing.Point(650, 223);
            this.LingOrderAscending.Name = "LingOrderAscending";
            this.LingOrderAscending.Size = new System.Drawing.Size(142, 43);
            this.LingOrderAscending.TabIndex = 6;
            this.LingOrderAscending.Text = "Order By Price Ascending";
            this.LingOrderAscending.UseVisualStyleBackColor = true;
            this.LingOrderAscending.Click += new System.EventHandler(this.LingOrderAscending_Click);
            // 
            // OrderByBouwjaarRecent_Btn
            // 
            this.OrderByBouwjaarRecent_Btn.Location = new System.Drawing.Point(650, 272);
            this.OrderByBouwjaarRecent_Btn.Name = "OrderByBouwjaarRecent_Btn";
            this.OrderByBouwjaarRecent_Btn.Size = new System.Drawing.Size(142, 46);
            this.OrderByBouwjaarRecent_Btn.TabIndex = 7;
            this.OrderByBouwjaarRecent_Btn.Text = "Order By Meest Recent Bouwjaar";
            this.OrderByBouwjaarRecent_Btn.UseVisualStyleBackColor = true;
            this.OrderByBouwjaarRecent_Btn.Click += new System.EventHandler(this.OrderByBouwjaarRecent_Btn_Click);
            // 
            // OrderByType_Btn
            // 
            this.OrderByType_Btn.Location = new System.Drawing.Point(650, 324);
            this.OrderByType_Btn.Name = "OrderByType_Btn";
            this.OrderByType_Btn.Size = new System.Drawing.Size(142, 46);
            this.OrderByType_Btn.TabIndex = 8;
            this.OrderByType_Btn.Text = "Order By Type";
            this.OrderByType_Btn.UseVisualStyleBackColor = true;
            this.OrderByType_Btn.Click += new System.EventHandler(this.OrderByType_Btn_Click);
            // 
            // ImmoCatalogus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderByType_Btn);
            this.Controls.Add(this.OrderByBouwjaarRecent_Btn);
            this.Controls.Add(this.LingOrderAscending);
            this.Controls.Add(this.LinqOrderBy);
            this.Controls.Add(this.AantalKlanten_Btn);
            this.Controls.Add(this.AantalWoningen_Btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImmoCatalogus";
            this.Text = "ImmoWeb";
            this.Load += new System.EventHandler(this.ImmoCatalogus_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem beheerToolStripMenuItem;
        private ToolStripMenuItem afsluitenCtrlfToolStripMenuItem;
        private ToolStripMenuItem addKlantToolStripMenuItem;
        private ToolStripMenuItem addWoningToolStripMenuItem;
        public DataGridView dataGridView1;
        public TabControl tabControl1;
        public TabPage tabPage1;
        public DataGridView dataGridView2;
        private Button searchButton;
        private TextBox Search_TBox;
        private Button AantalWoningen_Btn;
        private Button AantalKlanten_Btn;
        private Button LinqOrderBy;
        private Button LingOrderAscending;
        private Button OrderByBouwjaarRecent_Btn;
        private Button OrderByType_Btn;
        private Button Immo_Search_Btn;
        private TextBox Search_TBox1;
    }
}