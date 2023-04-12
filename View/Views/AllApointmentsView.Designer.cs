
namespace VetClinic.View.Views
{
    partial class AllApointmentsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowApp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowApp)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowApp
            // 
            this.ShowApp.AllowUserToOrderColumns = true;
            this.ShowApp.AllowUserToAddRows = false;
            this.ShowApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowApp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ShowApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowApp.Location = new System.Drawing.Point(0, 0);
            this.ShowApp.Margin = new System.Windows.Forms.Padding(0);
            this.ShowApp.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.ShowApp.Name = "ShowApp";
            this.ShowApp.Size = new System.Drawing.Size(10, 10);
            this.ShowApp.TabIndex = 34;
            this.ShowApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowApp_CellContentClick);
            // 
            // AllApointmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.ShowApp);
            this.Name = "AllApointmentsView";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ShowApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowApp;
    }
}
