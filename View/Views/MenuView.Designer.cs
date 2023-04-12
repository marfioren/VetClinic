
using System;

namespace VetClinic.View.Views
{
    partial class MenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.AppointmentsSubmenu = new System.Windows.Forms.Panel();
            this.ShowAllApp = new System.Windows.Forms.Button();
            this.AddApp = new System.Windows.Forms.Button();
            this.AllApp = new System.Windows.Forms.Button();
            this.OwnersSubmenu = new System.Windows.Forms.Panel();
            this.NewOwner = new System.Windows.Forms.Button();
            this.ShowOwners = new System.Windows.Forms.Button();
            this.OwnersAction = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.AppointmentsSubmenu.SuspendLayout();
            this.OwnersSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.panelMenu.Controls.Add(this.AppointmentsSubmenu);
            this.panelMenu.Controls.Add(this.AllApp);
            this.panelMenu.Controls.Add(this.OwnersSubmenu);
            this.panelMenu.Controls.Add(this.OwnersAction);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelMenu.Location = new System.Drawing.Point(1299, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(316, 849);
            this.panelMenu.TabIndex = 40;
            // 
            // AppointmentsSubmenu
            // 
            this.AppointmentsSubmenu.Controls.Add(this.ShowAllApp);
            this.AppointmentsSubmenu.Controls.Add(this.AddApp);
            this.AppointmentsSubmenu.Location = new System.Drawing.Point(0, 351);
            this.AppointmentsSubmenu.Name = "AppointmentsSubmenu";
            this.AppointmentsSubmenu.Size = new System.Drawing.Size(316, 103);
            this.AppointmentsSubmenu.TabIndex = 2;
            // 
            // ShowAllApp
            // 
            this.ShowAllApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.ShowAllApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowAllApp.FlatAppearance.BorderSize = 0;
            this.ShowAllApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllApp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllApp.ForeColor = System.Drawing.Color.Teal;
            this.ShowAllApp.Location = new System.Drawing.Point(0, 46);
            this.ShowAllApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowAllApp.Name = "ShowAllApp";
            this.ShowAllApp.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.ShowAllApp.Size = new System.Drawing.Size(316, 46);
            this.ShowAllApp.TabIndex = 1;
            this.ShowAllApp.Text = "- Show all apointments";
            this.ShowAllApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAllApp.UseVisualStyleBackColor = false;
            // 
            // AddApp
            // 
            this.AddApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.AddApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddApp.FlatAppearance.BorderSize = 0;
            this.AddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddApp.ForeColor = System.Drawing.Color.Teal;
            this.AddApp.Location = new System.Drawing.Point(0, 0);
            this.AddApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddApp.Name = "AddApp";
            this.AddApp.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.AddApp.Size = new System.Drawing.Size(316, 46);
            this.AddApp.TabIndex = 1;
            this.AddApp.Text = "- Add new appointment";
            this.AddApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddApp.UseVisualStyleBackColor = false;
            // 
            // AllApp
            // 
            this.AllApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllApp.FlatAppearance.BorderSize = 0;
            this.AllApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllApp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.AllApp.Location = new System.Drawing.Point(0, 383);
            this.AllApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllApp.Name = "AllApp";
            this.AllApp.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.AllApp.Size = new System.Drawing.Size(316, 69);
            this.AllApp.TabIndex = 3;
            this.AllApp.Text = "- Appointments";
            this.AllApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllApp.UseVisualStyleBackColor = true;
            this.AllApp.Click += new System.EventHandler(this.AddApp_Click);
            // 
            // OwnersSubmenu
            // 
            this.OwnersSubmenu.Controls.Add(this.NewOwner);
            this.OwnersSubmenu.Controls.Add(this.ShowOwners);
            this.OwnersSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.OwnersSubmenu.Location = new System.Drawing.Point(0, 287);
            this.OwnersSubmenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OwnersSubmenu.Name = "OwnersSubmenu";
            this.OwnersSubmenu.Size = new System.Drawing.Size(316, 96);
            this.OwnersSubmenu.TabIndex = 2;
            // 
            // NewOwner
            // 
            this.NewOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.NewOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewOwner.FlatAppearance.BorderSize = 0;
            this.NewOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOwner.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOwner.ForeColor = System.Drawing.Color.Teal;
            this.NewOwner.Location = new System.Drawing.Point(0, 46);
            this.NewOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewOwner.Name = "NewOwner";
            this.NewOwner.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.NewOwner.Size = new System.Drawing.Size(316, 46);
            this.NewOwner.TabIndex = 1;
            this.NewOwner.Text = "- Add new owner";
            this.NewOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewOwner.UseVisualStyleBackColor = false;
            // 
            // ShowOwners
            // 
            this.ShowOwners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.ShowOwners.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowOwners.FlatAppearance.BorderSize = 0;
            this.ShowOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowOwners.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOwners.ForeColor = System.Drawing.Color.Teal;
            this.ShowOwners.Location = new System.Drawing.Point(0, 0);
            this.ShowOwners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowOwners.Name = "ShowOwners";
            this.ShowOwners.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
            this.ShowOwners.Size = new System.Drawing.Size(316, 46);
            this.ShowOwners.TabIndex = 0;
            this.ShowOwners.Text = "- All owners";
            this.ShowOwners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowOwners.UseVisualStyleBackColor = false;
            // 
            // OwnersAction
            // 
            this.OwnersAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.OwnersAction.FlatAppearance.BorderSize = 0;
            this.OwnersAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnersAction.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnersAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.OwnersAction.Location = new System.Drawing.Point(0, 218);
            this.OwnersAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OwnersAction.Name = "OwnersAction";
            this.OwnersAction.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.OwnersAction.Size = new System.Drawing.Size(316, 69);
            this.OwnersAction.TabIndex = 1;
            this.OwnersAction.Text = "- Owners";
            this.OwnersAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OwnersAction.UseVisualStyleBackColor = true;
            this.OwnersAction.Click += new System.EventHandler(this.OwnersAction_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(316, 218);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 280);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.MainPanel.Location = new System.Drawing.Point(-1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(0, 0);
            this.MainPanel.TabIndex = 41;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1615, 849);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.AppointmentsSubmenu.ResumeLayout(false);
            this.OwnersSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button AllApp;
        private System.Windows.Forms.Panel OwnersSubmenu;
        private System.Windows.Forms.Button NewOwner;
        private System.Windows.Forms.Button ShowOwners;
        private System.Windows.Forms.Button OwnersAction;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel AppointmentsSubmenu;
        private System.Windows.Forms.Button ShowAllApp;
        private System.Windows.Forms.Button AddApp;
    }
}