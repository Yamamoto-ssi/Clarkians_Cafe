namespace Cafe_ccst
{
    partial class employee_dashboard
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
            btnMenu = new Button();
            btnPayments = new Button();
            btnTools = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(100, 94);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(249, 86);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.Location = new Point(393, 94);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(249, 86);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "PAYMENTS";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnTools
            // 
            btnTools.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTools.Location = new Point(235, 186);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(249, 86);
            btnTools.TabIndex = 6;
            btnTools.Text = "TOOLS";
            btnTools.UseVisualStyleBackColor = true;
            // 
            // employee_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTools);
            Controls.Add(btnPayments);
            Controls.Add(btnMenu);
            Name = "employee_dashboard";
            Text = "employee_dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnPayments;
        private Button btnTools;
    }
}