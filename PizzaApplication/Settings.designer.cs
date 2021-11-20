
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
            this.pizzasizeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSizeBuitton = new System.Windows.Forms.Button();
            this.resetSizebutton = new System.Windows.Forms.Button();
            this.saveIngredientsButton = new System.Windows.Forms.Button();
            this.resetIngredientsButton = new System.Windows.Forms.Button();
            this.pizzasizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasizeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ingredientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzasizeGroupBox
            // 
            this.pizzasizeGroupBox.Controls.Add(this.pizzasizeDataGridView);
            this.pizzasizeGroupBox.Location = new System.Drawing.Point(21, 26);
            this.pizzasizeGroupBox.Name = "pizzasizeGroupBox";
            this.pizzasizeGroupBox.Size = new System.Drawing.Size(305, 229);
            this.pizzasizeGroupBox.TabIndex = 0;
            this.pizzasizeGroupBox.TabStop = false;
            this.pizzasizeGroupBox.Text = "Size";
            // 
            // pizzasizeDataGridView
            // 
            this.pizzasizeDataGridView.AllowUserToOrderColumns = true;
            this.pizzasizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzasizeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzasizeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.pizzasizeDataGridView.Name = "pizzasizeDataGridView";
            this.pizzasizeDataGridView.RowTemplate.Height = 25;
            this.pizzasizeDataGridView.Size = new System.Drawing.Size(299, 210);
            this.pizzasizeDataGridView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(310, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.dataGridView1);
            this.ingredientsGroupBox.Location = new System.Drawing.Point(359, 26);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(316, 229);
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
            // 
            // saveIngredientsButton
            // 
            this.saveIngredientsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.saveIngredientsButton.Location = new System.Drawing.Point(362, 279);
            this.saveIngredientsButton.Name = "saveIngredientsButton";
            this.saveIngredientsButton.Size = new System.Drawing.Size(69, 30);
            this.saveIngredientsButton.TabIndex = 5;
            this.saveIngredientsButton.Text = "Save";
            this.saveIngredientsButton.UseVisualStyleBackColor = true;
            // 
            // resetIngredientsButton
            // 
            this.resetIngredientsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.resetIngredientsButton.Location = new System.Drawing.Point(435, 279);
            this.resetIngredientsButton.Name = "resetIngredientsButton";
            this.resetIngredientsButton.Size = new System.Drawing.Size(79, 30);
            this.resetIngredientsButton.TabIndex = 6;
            this.resetIngredientsButton.Text = "Reset";
            this.resetIngredientsButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.resetIngredientsButton);
            this.Controls.Add(this.saveIngredientsButton);
            this.Controls.Add(this.resetSizebutton);
            this.Controls.Add(this.saveSizeBuitton);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.pizzasizeGroupBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pizzasizeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzasizeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ingredientsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pizzasizeGroupBox;
        private System.Windows.Forms.DataGridView pizzasizeDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.Button saveSizeBuitton;
        private System.Windows.Forms.Button resetSizebutton;
        private System.Windows.Forms.Button saveIngredientsButton;
        private System.Windows.Forms.Button resetIngredientsButton;
    }
}