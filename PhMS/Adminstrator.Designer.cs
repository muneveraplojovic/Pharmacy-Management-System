namespace PhMS
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUserBtn = new System.Windows.Forms.Label();
            this.viewUserBtn = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.viewUserBtn);
            this.panel1.Controls.Add(this.addUserBtn);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 42);
            this.panel1.TabIndex = 0;
            // 
            // addUserBtn
            // 
            this.addUserBtn.AutoSize = true;
            this.addUserBtn.Location = new System.Drawing.Point(353, 15);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(49, 13);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Add user";
            // 
            // viewUserBtn
            // 
            this.viewUserBtn.AutoSize = true;
            this.viewUserBtn.Location = new System.Drawing.Point(408, 15);
            this.viewUserBtn.Name = "viewUserBtn";
            this.viewUserBtn.Size = new System.Drawing.Size(53, 13);
            this.viewUserBtn.TabIndex = 1;
            this.viewUserBtn.Text = "View user";
            this.viewUserBtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.AutoSize = true;
            this.profileBtn.Location = new System.Drawing.Point(467, 15);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(36, 13);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            // 
            // logOutBtn
            // 
            this.logOutBtn.AutoSize = true;
            this.logOutBtn.ForeColor = System.Drawing.Color.Red;
            this.logOutBtn.Location = new System.Drawing.Point(715, 15);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(43, 13);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.Click += new System.EventHandler(this.label4_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.AutoSize = true;
            this.dashboardBtn.Location = new System.Drawing.Point(288, 15);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(59, 13);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(18, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 34);
            this.panel2.TabIndex = 1;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Adminstrator";
            this.Text = "Adminstrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutBtn;
        private System.Windows.Forms.Label profileBtn;
        private System.Windows.Forms.Label viewUserBtn;
        private System.Windows.Forms.Label addUserBtn;
        private System.Windows.Forms.Label dashboardBtn;
        private System.Windows.Forms.Panel panel2;
    }
}