namespace Milestone_Project
{
    partial class BookStore
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultsLst = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.outOfStockChk = new System.Windows.Forms.CheckBox();
            this.restockBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(119, 87);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(121, 22);
            this.searchTxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search by";
            // 
            // searchBy
            // 
            this.searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy.Items.AddRange(new object[] {
            "Genre",
            "Title"});
            this.searchBy.Location = new System.Drawing.Point(119, 40);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(121, 24);
            this.searchBy.TabIndex = 7;
            this.searchBy.SelectedIndexChanged += new System.EventHandler(this.searchBy_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(354, 73);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 53);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(448, 74);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(88, 53);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(542, 74);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(88, 53);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Biography",
            "Comedy",
            "Fiction",
            "Mystery",
            "Romance"});
            this.searchCombo.Location = new System.Drawing.Point(119, 89);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 24);
            this.searchCombo.TabIndex = 26;
            this.searchCombo.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(260, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 53);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultsLst
            // 
            this.resultsLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Genre,
            this.Quantity,
            this.Price,
            this.pageCount,
            this.productID});
            this.resultsLst.FullRowSelect = true;
            this.resultsLst.GridLines = true;
            this.resultsLst.HideSelection = false;
            this.resultsLst.Location = new System.Drawing.Point(17, 146);
            this.resultsLst.MultiSelect = false;
            this.resultsLst.Name = "resultsLst";
            this.resultsLst.RightToLeftLayout = true;
            this.resultsLst.Size = new System.Drawing.Size(730, 292);
            this.resultsLst.TabIndex = 33;
            this.resultsLst.UseCompatibleStateImageBehavior = false;
            this.resultsLst.View = System.Windows.Forms.View.Details;
            this.resultsLst.SelectedIndexChanged += new System.EventHandler(this.resultsLst_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 120;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // pageCount
            // 
            this.pageCount.Text = "Page Count";
            this.pageCount.Width = 90;
            // 
            // productID
            // 
            this.productID.Text = "Product ID";
            this.productID.Width = 90;
            // 
            // outOfStockChk
            // 
            this.outOfStockChk.AutoSize = true;
            this.outOfStockChk.Location = new System.Drawing.Point(260, 45);
            this.outOfStockChk.Name = "outOfStockChk";
            this.outOfStockChk.Size = new System.Drawing.Size(170, 20);
            this.outOfStockChk.TabIndex = 39;
            this.outOfStockChk.Text = "Show only instock items";
            this.outOfStockChk.UseVisualStyleBackColor = true;
            // 
            // restockBtn
            // 
            this.restockBtn.Enabled = false;
            this.restockBtn.Location = new System.Drawing.Point(636, 72);
            this.restockBtn.Name = "restockBtn";
            this.restockBtn.Size = new System.Drawing.Size(88, 53);
            this.restockBtn.TabIndex = 41;
            this.restockBtn.Text = "Restock";
            this.restockBtn.UseVisualStyleBackColor = true;
            this.restockBtn.Click += new System.EventHandler(this.restockBtn_Click);
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.restockBtn);
            this.Controls.Add(this.outOfStockChk);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultsLst);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.searchTxt);
            this.Name = "BookStore";
            this.Text = "Book Store Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button searchBtn;
        public System.Windows.Forms.ListView resultsLst;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader pageCount;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.CheckBox outOfStockChk;
        private System.Windows.Forms.Button restockBtn;
    }
}

