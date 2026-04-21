namespace Cafe_ccst
{
    partial class manager_dashboard
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
            btnInventory = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // btnInventory
            // 
            btnInventory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.Location = new Point(156, 71);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(249, 86);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(499, 71);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(249, 86);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(175, 212);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(249, 86);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(499, 212);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(249, 86);
            btnReports.TabIndex = 4;
            btnReports.Text = "REPORTS";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // manager_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 508);
            Controls.Add(btnReports);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(btnInventory);
            Name = "manager_dashboard";
            Text = "manager_dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventory;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnReports;
    }
}