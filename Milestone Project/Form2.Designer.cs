namespace Milestone_Project
{
    partial class UpdateInventory
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
            this.genreBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.addPageCount = new System.Windows.Forms.TextBox();
            this.addPrice = new System.Windows.Forms.TextBox();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.addTitle = new System.Windows.Forms.TextBox();
            this.genereLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.pageCountlbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.ItemHeight = 16;
            this.genreBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Biography",
            "Comedy",
            "Fiction",
            "Mystery",
            "Romance"});
            this.genreBox.Location = new System.Drawing.Point(289, 114);
            this.genreBox.Name = "genreBox";
            this.genreBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.genreBox.Size = new System.Drawing.Size(120, 84);
            this.genreBox.TabIndex = 52;
            this.genreBox.SelectedIndexChanged += new System.EventHandler(this.addEditChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(432, 153);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 46);
            this.cancelBtn.TabIndex = 51;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Location = new System.Drawing.Point(432, 101);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 46);
            this.confirmBtn.TabIndex = 50;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // addPageCount
            // 
            this.addPageCount.Location = new System.Drawing.Point(162, 114);
            this.addPageCount.Name = "addPageCount";
            this.addPageCount.Size = new System.Drawing.Size(100, 22);
            this.addPageCount.TabIndex = 49;
            this.addPageCount.TextChanged += new System.EventHandler(this.addEditChanged);
            // 
            // addPrice
            // 
            this.addPrice.Location = new System.Drawing.Point(29, 172);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(100, 22);
            this.addPrice.TabIndex = 48;
            this.addPrice.TextChanged += new System.EventHandler(this.addEditChanged);
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(162, 172);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(100, 22);
            this.addQuantity.TabIndex = 47;
            this.addQuantity.TextChanged += new System.EventHandler(this.addEditChanged);
            // 
            // addTitle
            // 
            this.addTitle.Location = new System.Drawing.Point(29, 114);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(100, 22);
            this.addTitle.TabIndex = 46;
            this.addTitle.TextChanged += new System.EventHandler(this.addEditChanged);
            // 
            // genereLbl
            // 
            this.genereLbl.AutoSize = true;
            this.genereLbl.Location = new System.Drawing.Point(286, 95);
            this.genereLbl.Name = "genereLbl";
            this.genereLbl.Size = new System.Drawing.Size(44, 16);
            this.genereLbl.TabIndex = 45;
            this.genereLbl.Text = "Genre";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(26, 153);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(38, 16);
            this.priceLbl.TabIndex = 44;
            this.priceLbl.Text = "Price";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(159, 153);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(55, 16);
            this.quantityLbl.TabIndex = 43;
            this.quantityLbl.Text = "Quantity";
            // 
            // pageCountlbl
            // 
            this.pageCountlbl.AutoSize = true;
            this.pageCountlbl.Location = new System.Drawing.Point(159, 95);
            this.pageCountlbl.Name = "pageCountlbl";
            this.pageCountlbl.Size = new System.Drawing.Size(77, 16);
            this.pageCountlbl.TabIndex = 42;
            this.pageCountlbl.Text = "Page Count";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(26, 95);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(33, 16);
            this.titleLbl.TabIndex = 41;
            this.titleLbl.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 51);
            this.label1.TabIndex = 53;
            this.label1.Text = "Update Inventory";
            // 
            // UpdateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.addPageCount);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.addQuantity);
            this.Controls.Add(this.addTitle);
            this.Controls.Add(this.genereLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.pageCountlbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "UpdateInventory";
            this.Text = "Update Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox genreBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox addPageCount;
        private System.Windows.Forms.TextBox addPrice;
        private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox addTitle;
        private System.Windows.Forms.Label genereLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label pageCountlbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label1;
    }
}