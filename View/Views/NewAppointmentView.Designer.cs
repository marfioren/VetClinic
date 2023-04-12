
namespace VetClinic.View.Views
{
    partial class NewAppointmentView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.SaveApp = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChoosenDate = new System.Windows.Forms.DateTimePicker();
            this.LogSurname = new System.Windows.Forms.Label();
            this.UsedProcedures = new System.Windows.Forms.DataGridView();
            this.Procedures = new System.Windows.Forms.ComboBox();
            this.AddProcedure = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.quantityRem = new System.Windows.Forms.Button();
            this.quantityAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AllProducts = new System.Windows.Forms.ComboBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.UsedProducts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PetDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PetSpec = new System.Windows.Forms.Label();
            this.PetGender = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Pets = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Owners = new System.Windows.Forms.ComboBox();
            this.OwnerOIB = new System.Windows.Forms.Label();
            this.OwnerAdress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.LogName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsedProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.Comment);
            this.panel1.Location = new System.Drawing.Point(17, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 184);
            this.panel1.TabIndex = 74;
            // 
            // Comment
            // 
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Comment.Location = new System.Drawing.Point(1, 1);
            this.Comment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(366, 182);
            this.Comment.TabIndex = 37;
            this.Comment.Text = "";
            // 
            // SaveApp
            // 
            this.SaveApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.SaveApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.SaveApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.SaveApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveApp.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.SaveApp.Location = new System.Drawing.Point(784, 606);
            this.SaveApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveApp.Name = "SaveApp";
            this.SaveApp.Size = new System.Drawing.Size(209, 55);
            this.SaveApp.TabIndex = 73;
            this.SaveApp.Text = "Save appointment";
            this.SaveApp.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label14.Location = new System.Drawing.Point(13, 512);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Additional Comments:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label12.Location = new System.Drawing.Point(35, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Date:";
            // 
            // ChoosenDate
            // 
            this.ChoosenDate.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ChoosenDate.Location = new System.Drawing.Point(98, 71);
            this.ChoosenDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChoosenDate.Name = "ChoosenDate";
            this.ChoosenDate.Size = new System.Drawing.Size(160, 25);
            this.ChoosenDate.TabIndex = 70;
            // 
            // LogSurname
            // 
            this.LogSurname.AutoSize = true;
            this.LogSurname.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.LogSurname.Location = new System.Drawing.Point(178, -3);
            this.LogSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogSurname.Name = "LogSurname";
            this.LogSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogSurname.Size = new System.Drawing.Size(58, 20);
            this.LogSurname.TabIndex = 69;
            this.LogSurname.Text = "label12";
            // 
            // UsedProcedures
            // 
            this.UsedProcedures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.UsedProcedures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsedProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsedProcedures.Location = new System.Drawing.Point(523, 122);
            this.UsedProcedures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsedProcedures.Name = "UsedProcedures";
            this.UsedProcedures.ReadOnly = true;
            this.UsedProcedures.Size = new System.Drawing.Size(386, 123);
            this.UsedProcedures.TabIndex = 68;
            // 
            // Procedures
            // 
            this.Procedures.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procedures.FormattingEnabled = true;
            this.Procedures.Location = new System.Drawing.Point(523, 67);
            this.Procedures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Procedures.Name = "Procedures";
            this.Procedures.Size = new System.Drawing.Size(196, 25);
            this.Procedures.TabIndex = 67;
            // 
            // AddProcedure
            // 
            this.AddProcedure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.AddProcedure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.AddProcedure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.AddProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProcedure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.AddProcedure.Location = new System.Drawing.Point(885, 57);
            this.AddProcedure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProcedure.Name = "AddProcedure";
            this.AddProcedure.Size = new System.Drawing.Size(105, 35);
            this.AddProcedure.TabIndex = 66;
            this.AddProcedure.Text = "Add to list";
            this.AddProcedure.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label13.Location = new System.Drawing.Point(407, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "Procedures:";
            // 
            // quantityRem
            // 
            this.quantityRem.Location = new System.Drawing.Point(839, 362);
            this.quantityRem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityRem.Name = "quantityRem";
            this.quantityRem.Size = new System.Drawing.Size(31, 31);
            this.quantityRem.TabIndex = 64;
            this.quantityRem.Text = "-";
            this.quantityRem.UseVisualStyleBackColor = true;
            // 
            // quantityAdd
            // 
            this.quantityAdd.Location = new System.Drawing.Point(839, 327);
            this.quantityAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityAdd.Name = "quantityAdd";
            this.quantityAdd.Size = new System.Drawing.Size(31, 31);
            this.quantityAdd.TabIndex = 63;
            this.quantityAdd.Text = "+";
            this.quantityAdd.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label11.Location = new System.Drawing.Point(736, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Quantity: ";
            // 
            // AllProducts
            // 
            this.AllProducts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProducts.FormattingEnabled = true;
            this.AllProducts.Location = new System.Drawing.Point(523, 358);
            this.AllProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(196, 25);
            this.AllProducts.TabIndex = 60;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.AddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(199)))), ((int)(((byte)(205)))));
            this.AddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(203)))));
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(104)))));
            this.AddProduct.Location = new System.Drawing.Point(888, 351);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(105, 35);
            this.AddProduct.TabIndex = 59;
            this.AddProduct.Text = "Add to list";
            this.AddProduct.UseVisualStyleBackColor = false;
            // 
            // UsedProducts
            // 
            this.UsedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.UsedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsedProducts.Location = new System.Drawing.Point(523, 410);
            this.UsedProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsedProducts.Name = "UsedProducts";
            this.UsedProducts.ReadOnly = true;
            this.UsedProducts.Size = new System.Drawing.Size(470, 120);
            this.UsedProducts.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(423, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Products:";
            // 
            // PetDate
            // 
            this.PetDate.AutoSize = true;
            this.PetDate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.PetDate.Location = new System.Drawing.Point(95, 435);
            this.PetDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PetDate.Name = "PetDate";
            this.PetDate.Size = new System.Drawing.Size(61, 20);
            this.PetDate.TabIndex = 56;
            this.PetDate.Text = "PetDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label8.Location = new System.Drawing.Point(10, 435);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Birth date:";
            // 
            // PetSpec
            // 
            this.PetSpec.AutoSize = true;
            this.PetSpec.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.PetSpec.Location = new System.Drawing.Point(94, 397);
            this.PetSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PetSpec.Name = "PetSpec";
            this.PetSpec.Size = new System.Drawing.Size(61, 20);
            this.PetSpec.TabIndex = 54;
            this.PetSpec.Text = "PetSpec";
            // 
            // PetGender
            // 
            this.PetGender.AutoSize = true;
            this.PetGender.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.PetGender.Location = new System.Drawing.Point(94, 358);
            this.PetGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PetGender.Name = "PetGender";
            this.PetGender.Size = new System.Drawing.Size(50, 20);
            this.PetGender.TabIndex = 53;
            this.PetGender.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label9.Location = new System.Drawing.Point(28, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label10.Location = new System.Drawing.Point(27, 397);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Species: ";
            // 
            // Pets
            // 
            this.Pets.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.Pets.FormattingEnabled = true;
            this.Pets.Location = new System.Drawing.Point(99, 303);
            this.Pets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pets.Name = "Pets";
            this.Pets.Size = new System.Drawing.Size(160, 25);
            this.Pets.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(48, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Pet:";
            // 
            // Owners
            // 
            this.Owners.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.Owners.FormattingEnabled = true;
            this.Owners.Location = new System.Drawing.Point(99, 136);
            this.Owners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Owners.Name = "Owners";
            this.Owners.Size = new System.Drawing.Size(160, 25);
            this.Owners.TabIndex = 48;
            // 
            // OwnerOIB
            // 
            this.OwnerOIB.AutoSize = true;
            this.OwnerOIB.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerOIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.OwnerOIB.Location = new System.Drawing.Point(94, 225);
            this.OwnerOIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerOIB.Name = "OwnerOIB";
            this.OwnerOIB.Size = new System.Drawing.Size(61, 20);
            this.OwnerOIB.TabIndex = 47;
            this.OwnerOIB.Text = "PetSpec";
            // 
            // OwnerAdress
            // 
            this.OwnerAdress.AutoSize = true;
            this.OwnerAdress.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.OwnerAdress.Location = new System.Drawing.Point(94, 186);
            this.OwnerAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerAdress.Name = "OwnerAdress";
            this.OwnerAdress.Size = new System.Drawing.Size(50, 20);
            this.OwnerAdress.TabIndex = 46;
            this.OwnerAdress.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Adress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(48, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "OIB: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Owner:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.quantity.Location = new System.Drawing.Point(812, 358);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(17, 20);
            this.quantity.TabIndex = 62;
            this.quantity.Text = "1";
            // 
            // LogName
            // 
            this.LogName.AutoSize = true;
            this.LogName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.LogName.Location = new System.Drawing.Point(107, -3);
            this.LogName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogName.Name = "LogName";
            this.LogName.Size = new System.Drawing.Size(48, 20);
            this.LogName.TabIndex = 42;
            this.LogName.Text = "marta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(38, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "User: ";
            // 
            // NewAppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveApp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChoosenDate);
            this.Controls.Add(this.LogSurname);
            this.Controls.Add(this.UsedProcedures);
            this.Controls.Add(this.Procedures);
            this.Controls.Add(this.AddProcedure);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.quantityRem);
            this.Controls.Add(this.quantityAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.UsedProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PetDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PetSpec);
            this.Controls.Add(this.PetGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Pets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Owners);
            this.Controls.Add(this.OwnerOIB);
            this.Controls.Add(this.OwnerAdress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.LogName);
            this.Controls.Add(this.label1);
            this.Name = "NewAppointmentView";
            this.Size = new System.Drawing.Size(1012, 751);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsedProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.Button SaveApp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ChoosenDate;
        private System.Windows.Forms.Label LogSurname;
        private System.Windows.Forms.DataGridView UsedProcedures;
        private System.Windows.Forms.ComboBox Procedures;
        private System.Windows.Forms.Button AddProcedure;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button quantityRem;
        private System.Windows.Forms.Button quantityAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox AllProducts;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView UsedProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PetDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PetSpec;
        private System.Windows.Forms.Label PetGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Pets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Owners;
        private System.Windows.Forms.Label OwnerOIB;
        private System.Windows.Forms.Label OwnerAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label LogName;
        private System.Windows.Forms.Label label1;
    }
}
