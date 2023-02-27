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
            this.titleLbl = new System.Windows.Forms.Label();
            this.pageCountlbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.genereLbl = new System.Windows.Forms.Label();
            this.addTitle = new System.Windows.Forms.TextBox();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.addPrice = new System.Windows.Forms.TextBox();
            this.addPageCount = new System.Windows.Forms.TextBox();
            this.addReleaseDate = new System.Windows.Forms.TextBox();
            this.releaseDateLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.addGenere = new System.Windows.Forms.ComboBox();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.resultsLst = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            "Genere",
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
            this.addBtn.Location = new System.Drawing.Point(400, 72);
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
            this.removeBtn.Location = new System.Drawing.Point(508, 72);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(88, 53);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(615, 72);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(88, 53);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(65, 176);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(33, 16);
            this.titleLbl.TabIndex = 12;
            this.titleLbl.Text = "Title";
            this.titleLbl.Visible = false;
            // 
            // pageCountlbl
            // 
            this.pageCountlbl.AutoSize = true;
            this.pageCountlbl.Location = new System.Drawing.Point(341, 179);
            this.pageCountlbl.Name = "pageCountlbl";
            this.pageCountlbl.Size = new System.Drawing.Size(77, 16);
            this.pageCountlbl.TabIndex = 13;
            this.pageCountlbl.Text = "Page Count";
            this.pageCountlbl.Visible = false;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(198, 234);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(55, 16);
            this.quantityLbl.TabIndex = 14;
            this.quantityLbl.Text = "Quantity";
            this.quantityLbl.Visible = false;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(65, 234);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(38, 16);
            this.priceLbl.TabIndex = 15;
            this.priceLbl.Text = "Price";
            this.priceLbl.Visible = false;
            // 
            // genereLbl
            // 
            this.genereLbl.AutoSize = true;
            this.genereLbl.Location = new System.Drawing.Point(198, 176);
            this.genereLbl.Name = "genereLbl";
            this.genereLbl.Size = new System.Drawing.Size(44, 16);
            this.genereLbl.TabIndex = 16;
            this.genereLbl.Text = "Genre";
            this.genereLbl.Visible = false;
            // 
            // addTitle
            // 
            this.addTitle.Location = new System.Drawing.Point(68, 195);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(100, 22);
            this.addTitle.TabIndex = 17;
            this.addTitle.Visible = false;
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(201, 253);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(100, 22);
            this.addQuantity.TabIndex = 19;
            this.addQuantity.Visible = false;
            // 
            // addPrice
            // 
            this.addPrice.Location = new System.Drawing.Point(68, 253);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(100, 22);
            this.addPrice.TabIndex = 20;
            this.addPrice.Visible = false;
            // 
            // addPageCount
            // 
            this.addPageCount.Location = new System.Drawing.Point(344, 198);
            this.addPageCount.Name = "addPageCount";
            this.addPageCount.Size = new System.Drawing.Size(100, 22);
            this.addPageCount.TabIndex = 21;
            this.addPageCount.Visible = false;
            // 
            // addReleaseDate
            // 
            this.addReleaseDate.Location = new System.Drawing.Point(344, 253);
            this.addReleaseDate.Name = "addReleaseDate";
            this.addReleaseDate.Size = new System.Drawing.Size(100, 22);
            this.addReleaseDate.TabIndex = 23;
            this.addReleaseDate.Visible = false;
            // 
            // releaseDateLbl
            // 
            this.releaseDateLbl.AutoSize = true;
            this.releaseDateLbl.Location = new System.Drawing.Point(341, 234);
            this.releaseDateLbl.Name = "releaseDateLbl";
            this.releaseDateLbl.Size = new System.Drawing.Size(91, 16);
            this.releaseDateLbl.TabIndex = 22;
            this.releaseDateLbl.Text = "Release Date";
            this.releaseDateLbl.Visible = false;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Enabled = false;
            this.addItemBtn.Location = new System.Drawing.Point(471, 179);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(100, 46);
            this.addItemBtn.TabIndex = 24;
            this.addItemBtn.Text = "Book";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Visible = false;
            // 
            // addGenere
            // 
            this.addGenere.FormattingEnabled = true;
            this.addGenere.Location = new System.Drawing.Point(201, 196);
            this.addGenere.Name = "addGenere";
            this.addGenere.Size = new System.Drawing.Size(100, 24);
            this.addGenere.TabIndex = 25;
            this.addGenere.Visible = false;
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
            this.searchBtn.Location = new System.Drawing.Point(289, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 53);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(471, 231);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 46);
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // resultsLst
            // 
            this.resultsLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Genere,
            this.Quantity,
            this.Price,
            this.pageCount,
            this.productID});
            this.resultsLst.FullRowSelect = true;
            this.resultsLst.GridLines = true;
            this.resultsLst.Location = new System.Drawing.Point(12, 146);
            this.resultsLst.MultiSelect = false;
            this.resultsLst.Name = "resultsLst";
            this.resultsLst.RightToLeftLayout = true;
            this.resultsLst.Size = new System.Drawing.Size(730, 292);
            this.resultsLst.TabIndex = 33;
            this.resultsLst.UseCompatibleStateImageBehavior = false;
            this.resultsLst.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 120;
            // 
            // Genere
            // 
            this.Genere.Text = "Genere";
            this.Genere.Width = 120;
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
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addGenere);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.addReleaseDate);
            this.Controls.Add(this.releaseDateLbl);
            this.Controls.Add(this.addPageCount);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.addQuantity);
            this.Controls.Add(this.addTitle);
            this.Controls.Add(this.genereLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.pageCountlbl);
            this.Controls.Add(this.titleLbl);
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
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label pageCountlbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label genereLbl;
        private System.Windows.Forms.TextBox addTitle;
        private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox addPrice;
        private System.Windows.Forms.TextBox addPageCount;
        private System.Windows.Forms.TextBox addReleaseDate;
        private System.Windows.Forms.Label releaseDateLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.ComboBox addGenere;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListView resultsLst;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Genere;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader pageCount;
        private System.Windows.Forms.ColumnHeader productID;
    }
}

