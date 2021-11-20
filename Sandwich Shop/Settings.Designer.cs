
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
            this.breadDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.breadGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientGroupBox = new System.Windows.Forms.GroupBox();
            this.saveBreadButton = new System.Windows.Forms.Button();
            this.resetBreadButton = new System.Windows.Forms.Button();
            this.saveIngredientButton = new System.Windows.Forms.Button();
            this.resetIngredientButton = new System.Windows.Forms.Button();
            this.breadTypeTextBox = new System.Windows.Forms.TextBox();
            this.breadPriceTextBox = new System.Windows.Forms.TextBox();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.breadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            this.breadGroupBox.SuspendLayout();
            this.ingredientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // breadDataGridView
            // 
            this.breadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breadDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadDataGridView.Location = new System.Drawing.Point(3, 20);
            this.breadDataGridView.Name = "breadDataGridView";
            this.breadDataGridView.Size = new System.Drawing.Size(385, 232);
            this.breadDataGridView.TabIndex = 0;
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
            // breadGroupBox
            // 
            this.breadGroupBox.Controls.Add(this.breadDataGridView);
            this.breadGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadGroupBox.Location = new System.Drawing.Point(12, 25);
            this.breadGroupBox.Name = "breadGroupBox";
            this.breadGroupBox.Size = new System.Drawing.Size(391, 255);
            this.breadGroupBox.TabIndex = 2;
            this.breadGroupBox.TabStop = false;
            this.breadGroupBox.Text = "Bread";
            // 
            // ingredientGroupBox
            // 
            this.ingredientGroupBox.Controls.Add(this.ingredientDataGridView);
            this.ingredientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientGroupBox.Location = new System.Drawing.Point(440, 25);
            this.ingredientGroupBox.Name = "ingredientGroupBox";
            this.ingredientGroupBox.Size = new System.Drawing.Size(449, 255);
            this.ingredientGroupBox.TabIndex = 3;
            this.ingredientGroupBox.TabStop = false;
            this.ingredientGroupBox.Text = "Ingredient";
            // 
            // saveBreadButton
            // 
            this.saveBreadButton.Location = new System.Drawing.Point(15, 356);
            this.saveBreadButton.Name = "saveBreadButton";
            this.saveBreadButton.Size = new System.Drawing.Size(75, 23);
            this.saveBreadButton.TabIndex = 4;
            this.saveBreadButton.Text = "Save";
            this.saveBreadButton.UseVisualStyleBackColor = true;
            this.saveBreadButton.Click += new System.EventHandler(this.saveBreadButton_Click);
            // 
            // resetBreadButton
            // 
            this.resetBreadButton.Location = new System.Drawing.Point(96, 356);
            this.resetBreadButton.Name = "resetBreadButton";
            this.resetBreadButton.Size = new System.Drawing.Size(75, 23);
            this.resetBreadButton.TabIndex = 5;
            this.resetBreadButton.Text = "Reset";
            this.resetBreadButton.UseVisualStyleBackColor = true;
            this.resetBreadButton.Click += new System.EventHandler(this.resetBreadButton_Click);
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
            this.resetIngredientButton.Click += new System.EventHandler(this.resetIngredientButton_Click);
            // 
            // breadTypeTextBox
            // 
            this.breadTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadTypeTextBox.Location = new System.Drawing.Point(120, 290);
            this.breadTypeTextBox.Name = "breadTypeTextBox";
            this.breadTypeTextBox.Size = new System.Drawing.Size(127, 24);
            this.breadTypeTextBox.TabIndex = 8;
            // 
            // breadPriceTextBox
            // 
            this.breadPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadPriceTextBox.Location = new System.Drawing.Point(121, 320);
            this.breadPriceTextBox.Name = "breadPriceTextBox";
            this.breadPriceTextBox.Size = new System.Drawing.Size(126, 24);
            this.breadPriceTextBox.TabIndex = 9;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(556, 296);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(202, 24);
            this.ingredientNameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bread Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sandwich Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingredient Name:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(this.breadPriceTextBox);
            this.Controls.Add(this.breadTypeTextBox);
            this.Controls.Add(this.resetIngredientButton);
            this.Controls.Add(this.saveIngredientButton);
            this.Controls.Add(this.resetBreadButton);
            this.Controls.Add(this.saveBreadButton);
            this.Controls.Add(this.ingredientGroupBox);
            this.Controls.Add(this.breadGroupBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Leave += new System.EventHandler(this.Settings_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.breadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            this.breadGroupBox.ResumeLayout(false);
            this.ingredientGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breadDataGridView;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.GroupBox breadGroupBox;
        private System.Windows.Forms.GroupBox ingredientGroupBox;
        private System.Windows.Forms.Button saveBreadButton;
        private System.Windows.Forms.Button resetBreadButton;
        private System.Windows.Forms.Button saveIngredientButton;
        private System.Windows.Forms.Button resetIngredientButton;
        private System.Windows.Forms.TextBox breadTypeTextBox;
        private System.Windows.Forms.TextBox breadPriceTextBox;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}