
namespace Sandwich_Shop
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
            this.sizeDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSizeButton = new System.Windows.Forms.Button();
            this.resetSizeButton = new System.Windows.Forms.Button();
            this.saveIngredientButton = new System.Windows.Forms.Button();
            this.resetIngredientButton = new System.Windows.Forms.Button();
            this.pizzaSizeTextBox = new System.Windows.Forms.TextBox();
            this.pizzaPriceTextBox = new System.Windows.Forms.TextBox();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            this.sizeGroupBox.SuspendLayout();
            this.ingredientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeDataGridView
            // 
            this.sizeDataGridView.AllowUserToAddRows = false;
            this.sizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sizeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeDataGridView.Location = new System.Drawing.Point(3, 20);
            this.sizeDataGridView.Name = "sizeDataGridView";
            this.sizeDataGridView.Size = new System.Drawing.Size(413, 232);
            this.sizeDataGridView.TabIndex = 0;
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientDataGridView.Location = new System.Drawing.Point(3, 20);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.Size = new System.Drawing.Size(443, 232);
            this.ingredientDataGridView.TabIndex = 1;
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.sizeDataGridView);
            this.sizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 47);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(419, 255);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // ingredientGroupBox
            // 
            this.ingredientGroupBox.Controls.Add(this.ingredientDataGridView);
            this.ingredientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientGroupBox.Location = new System.Drawing.Point(449, 47);
            this.ingredientGroupBox.Name = "ingredientGroupBox";
            this.ingredientGroupBox.Size = new System.Drawing.Size(449, 255);
            this.ingredientGroupBox.TabIndex = 3;
            this.ingredientGroupBox.TabStop = false;
            this.ingredientGroupBox.Text = "Ingredient";
            // 
            // saveSizeButton
            // 
            this.saveSizeButton.Location = new System.Drawing.Point(15, 356);
            this.saveSizeButton.Name = "saveSizeButton";
            this.saveSizeButton.Size = new System.Drawing.Size(75, 23);
            this.saveSizeButton.TabIndex = 4;
            this.saveSizeButton.Text = "Save";
            this.saveSizeButton.UseVisualStyleBackColor = true;
            this.saveSizeButton.Click += new System.EventHandler(this.saveSizeButton_Click);
            // 
            // resetSizeButton
            // 
            this.resetSizeButton.Location = new System.Drawing.Point(96, 356);
            this.resetSizeButton.Name = "resetSizeButton";
            this.resetSizeButton.Size = new System.Drawing.Size(75, 23);
            this.resetSizeButton.TabIndex = 5;
            this.resetSizeButton.Text = "Reset";
            this.resetSizeButton.UseVisualStyleBackColor = true;
            // 
            // saveIngredientButton
            // 
            this.saveIngredientButton.Location = new System.Drawing.Point(440, 356);
            this.saveIngredientButton.Name = "saveIngredientButton";
            this.saveIngredientButton.Size = new System.Drawing.Size(75, 23);
            this.saveIngredientButton.TabIndex = 6;
            this.saveIngredientButton.Text = "Save";
            this.saveIngredientButton.UseVisualStyleBackColor = true;
            this.saveIngredientButton.Click += new System.EventHandler(this.saveIngredientButton_Click);
            // 
            // resetIngredientButton
            // 
            this.resetIngredientButton.Location = new System.Drawing.Point(521, 356);
            this.resetIngredientButton.Name = "resetIngredientButton";
            this.resetIngredientButton.Size = new System.Drawing.Size(75, 23);
            this.resetIngredientButton.TabIndex = 7;
            this.resetIngredientButton.Text = "Reset";
            this.resetIngredientButton.UseVisualStyleBackColor = true;
            // 
            // pizzaSizeTextBox
            // 
            this.pizzaSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeTextBox.Location = new System.Drawing.Point(89, 319);
            this.pizzaSizeTextBox.Name = "pizzaSizeTextBox";
            this.pizzaSizeTextBox.Size = new System.Drawing.Size(127, 24);
            this.pizzaSizeTextBox.TabIndex = 8;
            // 
            // pizzaPriceTextBox
            // 
            this.pizzaPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaPriceTextBox.Location = new System.Drawing.Point(302, 318);
            this.pizzaPriceTextBox.Name = "pizzaPriceTextBox";
            this.pizzaPriceTextBox.Size = new System.Drawing.Size(126, 24);
            this.pizzaPriceTextBox.TabIndex = 9;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(562, 319);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(202, 24);
            this.ingredientNameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pizza Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pizza Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingredient Name:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(this.pizzaPriceTextBox);
            this.Controls.Add(this.pizzaSizeTextBox);
            this.Controls.Add(this.resetIngredientButton);
            this.Controls.Add(this.saveIngredientButton);
            this.Controls.Add(this.resetSizeButton);
            this.Controls.Add(this.saveSizeButton);
            this.Controls.Add(this.ingredientGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            this.sizeGroupBox.ResumeLayout(false);
            this.ingredientGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sizeDataGridView;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.GroupBox ingredientGroupBox;
        private System.Windows.Forms.Button saveSizeButton;
        private System.Windows.Forms.Button resetSizeButton;
        private System.Windows.Forms.Button saveIngredientButton;
        private System.Windows.Forms.Button resetIngredientButton;
        private System.Windows.Forms.TextBox pizzaSizeTextBox;
        private System.Windows.Forms.TextBox pizzaPriceTextBox;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}