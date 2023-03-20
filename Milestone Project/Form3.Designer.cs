namespace Milestone_Project
{
    partial class Restock
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
            this.restockTxt = new System.Windows.Forms.TextBox();
            this.restockBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restockTxt
            // 
            this.restockTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockTxt.Location = new System.Drawing.Point(15, 64);
            this.restockTxt.Name = "restockTxt";
            this.restockTxt.Size = new System.Drawing.Size(129, 38);
            this.restockTxt.TabIndex = 4;
            // 
            // restockBtn
            // 
            this.restockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockBtn.Location = new System.Drawing.Point(170, 64);
            this.restockBtn.Name = "restockBtn";
            this.restockBtn.Size = new System.Drawing.Size(130, 38);
            this.restockBtn.TabIndex = 5;
            this.restockBtn.Text = "Restock";
            this.restockBtn.UseVisualStyleBackColor = true;
            this.restockBtn.Click += new System.EventHandler(this.restockBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.MaximumSize = new System.Drawing.Size(289, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of items that will be added to the existing inventory.";
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 184);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.restockBtn);
            this.Controls.Add(this.restockTxt);
            this.Name = "Restock";
            this.Text = "Restock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox restockTxt;
        private System.Windows.Forms.Button restockBtn;
        private System.Windows.Forms.Label label5;
    }
}