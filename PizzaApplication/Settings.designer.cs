
namespace PizzaApplication
{
    partial class Settings
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
            this.pizzasizeGroupBox = new System.Windows.Forms.GroupBox();
            this.pizzaSizeDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSizeBuitton = new System.Windows.Forms.Button();
            this.resetSizebutton = new System.Windows.Forms.Button();
            this.saveIngredientsButton = new System.Windows.Forms.Button();
            this.resetIngredientsButton = new System.Windows.Forms.Button();
            this.pizzasizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.ingredientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzasizeGroupBox
            // 
            this.pizzasizeGroupBox.Controls.Add(this.pizzaSizeDataGridView);
            this.pizzasizeGroupBox.Location = new System.Drawing.Point(21, 26);
            this.pizzasizeGroupBox.Name = "pizzasizeGroupBox";
            this.pizzasizeGroupBox.Size = new System.Drawing.Size(416, 229);
            this.pizzasizeGroupBox.TabIndex = 0;
            this.pizzasizeGroupBox.TabStop = false;
            this.pizzasizeGroupBox.Text = "Size";
            // 
            // pizzaSizeDataGridView
            // 
            this.pizzaSizeDataGridView.AllowUserToOrderColumns = true;
            this.pizzaSizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaSizeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzaSizeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.pizzaSizeDataGridView.Name = "pizzaSizeDataGridView";
            this.pizzaSizeDataGridView.RowTemplate.Height = 25;
            this.pizzaSizeDataGridView.Size = new System.Drawing.Size(410, 210);
            this.pizzaSizeDataGridView.TabIndex = 0;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.RowTemplate.Height = 25;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(413, 210);
            this.ingredientsDataGridView.TabIndex = 1;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsDataGridView);
            this.ingredientsGroupBox.Location = new System.Drawing.Point(483, 26);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(419, 229);
            this.ingredientsGroupBox.TabIndex = 2;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.Text = "Ingredients";
            // 
            // saveSizeBuitton
            // 
            this.saveSizeBuitton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.saveSizeBuitton.Location = new System.Drawing.Point(23, 279);
            this.saveSizeBuitton.Name = "saveSizeBuitton";
            this.saveSizeBuitton.Size = new System.Drawing.Size(70, 30);
            this.saveSizeBuitton.TabIndex = 3;
            this.saveSizeBuitton.Text = "Save";
            this.saveSizeBuitton.UseVisualStyleBackColor = true;
            this.saveSizeBuitton.Click += new System.EventHandler(this.saveSizeBuitton_Click);
            // 
            // resetSizebutton
            // 
            this.resetSizebutton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.resetSizebutton.Location = new System.Drawing.Point(99, 279);
            this.resetSizebutton.Name = "resetSizebutton";
            this.resetSizebutton.Size = new System.Drawing.Size(79, 30);
            this.resetSizebutton.TabIndex = 4;
            this.resetSizebutton.Text = "Reset";
            this.resetSizebutton.UseVisualStyleBackColor = true;
            this.resetSizebutton.Click += new System.EventHandler(this.resetSizebutton_Click);
            // 
            // saveIngredientsButton
            // 
            this.saveIngredientsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.saveIngredientsButton.Location = new System.Drawing.Point(486, 279);
            this.saveIngredientsButton.Name = "saveIngredientsButton";
            this.saveIngredientsButton.Size = new System.Drawing.Size(69, 30);
            this.saveIngredientsButton.TabIndex = 5;
            this.saveIngredientsButton.Text = "Save";
            this.saveIngredientsButton.UseVisualStyleBackColor = true;
            this.saveIngredientsButton.Click += new System.EventHandler(this.saveIngredientsButton_Click);
            // 
            // resetIngredientsButton
            // 
            this.resetIngredientsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.resetIngredientsButton.Location = new System.Drawing.Point(559, 279);
            this.resetIngredientsButton.Name = "resetIngredientsButton";
            this.resetIngredientsButton.Size = new System.Drawing.Size(79, 30);
            this.resetIngredientsButton.TabIndex = 6;
            this.resetIngredientsButton.Text = "Reset";
            this.resetIngredientsButton.UseVisualStyleBackColor = true;
            this.resetIngredientsButton.Click += new System.EventHandler(this.resetIngredientsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 390);
            this.Controls.Add(this.resetIngredientsButton);
            this.Controls.Add(this.saveIngredientsButton);
            this.Controls.Add(this.resetSizebutton);
            this.Controls.Add(this.saveSizeBuitton);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.pizzasizeGroupBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Leave += new System.EventHandler(this.Settings_Leave);
            this.pizzasizeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.ingredientsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pizzasizeGroupBox;
        private System.Windows.Forms.DataGridView pizzaSizeDataGridView;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.Button saveSizeBuitton;
        private System.Windows.Forms.Button resetSizebutton;
        private System.Windows.Forms.Button saveIngredientsButton;
        private System.Windows.Forms.Button resetIngredientsButton;
    }
}