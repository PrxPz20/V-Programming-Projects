
namespace PizzaApplication
{
    partial class MainForm
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
            this.orderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.pizzaSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.pizzaSizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.freeIngredientsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deliveryTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.testSizeLabel = new System.Windows.Forms.Label();
            this.testIngredientLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaSizeGroupBox.SuspendLayout();
            this.ingredientsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(549, 375);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(89, 37);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza App";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totalPriceLabel.Location = new System.Drawing.Point(107, 375);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(59, 25);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "price";
            this.totalPriceLabel.Visible = false;
            // 
            // pizzaSizeGroupBox
            // 
            this.pizzaSizeGroupBox.Controls.Add(this.pizzaSizeFlowLayoutPanel);
            this.pizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeGroupBox.Location = new System.Drawing.Point(18, 73);
            this.pizzaSizeGroupBox.Name = "pizzaSizeGroupBox";
            this.pizzaSizeGroupBox.Size = new System.Drawing.Size(259, 185);
            this.pizzaSizeGroupBox.TabIndex = 3;
            this.pizzaSizeGroupBox.TabStop = false;
            this.pizzaSizeGroupBox.Text = "Size";
            // 
            // pizzaSizeFlowLayoutPanel
            // 
            this.pizzaSizeFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzaSizeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pizzaSizeFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.pizzaSizeFlowLayoutPanel.Name = "pizzaSizeFlowLayoutPanel";
            this.pizzaSizeFlowLayoutPanel.Size = new System.Drawing.Size(253, 160);
            this.pizzaSizeFlowLayoutPanel.TabIndex = 0;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsFlowLayoutPanel);
            this.ingredientsGroupBox.Enabled = false;
            this.ingredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsGroupBox.Location = new System.Drawing.Point(332, 73);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(419, 185);
            this.ingredientsGroupBox.TabIndex = 4;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.Text = "Ingredients";
            // 
            // ingredientsFlowLayoutPanel
            // 
            this.ingredientsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ingredientsFlowLayoutPanel.Location = new System.Drawing.Point(3, 20);
            this.ingredientsFlowLayoutPanel.Name = "ingredientsFlowLayoutPanel";
            this.ingredientsFlowLayoutPanel.Size = new System.Drawing.Size(413, 162);
            this.ingredientsFlowLayoutPanel.TabIndex = 0;
            // 
            // freeIngredientsLabel
            // 
            this.freeIngredientsLabel.AutoSize = true;
            this.freeIngredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeIngredientsLabel.Location = new System.Drawing.Point(328, 261);
            this.freeIngredientsLabel.Name = "freeIngredientsLabel";
            this.freeIngredientsLabel.Size = new System.Drawing.Size(153, 24);
            this.freeIngredientsLabel.TabIndex = 5;
            this.freeIngredientsLabel.Text = "Free Ingredients:";
            this.freeIngredientsLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery Time:";
            // 
            // deliveryTimeMaskedTextBox
            // 
            this.deliveryTimeMaskedTextBox.Enabled = false;
            this.deliveryTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTimeMaskedTextBox.Location = new System.Drawing.Point(375, 375);
            this.deliveryTimeMaskedTextBox.Mask = "00:00";
            this.deliveryTimeMaskedTextBox.Name = "deliveryTimeMaskedTextBox";
            this.deliveryTimeMaskedTextBox.Size = new System.Drawing.Size(86, 31);
            this.deliveryTimeMaskedTextBox.TabIndex = 8;
            this.deliveryTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.deliveryTimeMaskedTextBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.deliveryTimeMaskedTextBox_TypeValidationCompleted);
            // 
            // testSizeLabel
            // 
            this.testSizeLabel.AutoSize = true;
            this.testSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testSizeLabel.Location = new System.Drawing.Point(570, 321);
            this.testSizeLabel.Name = "testSizeLabel";
            this.testSizeLabel.Size = new System.Drawing.Size(80, 20);
            this.testSizeLabel.TabIndex = 9;
            this.testSizeLabel.Text = "TESTSize";
            // 
            // testIngredientLabel
            // 
            this.testIngredientLabel.AutoSize = true;
            this.testIngredientLabel.Location = new System.Drawing.Point(197, 326);
            this.testIngredientLabel.Name = "testIngredientLabel";
            this.testIngredientLabel.Size = new System.Drawing.Size(50, 13);
            this.testIngredientLabel.TabIndex = 10;
            this.testIngredientLabel.Text = "TESTIng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.aboutStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsStripMenuItem
            // 
            this.settingsStripMenuItem.Name = "settingsStripMenuItem";
            this.settingsStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsStripMenuItem.Text = "Settings";
            this.settingsStripMenuItem.Click += new System.EventHandler(this.settingsStripMenuItem_Click);
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutStripMenuItem.Text = "About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testIngredientLabel);
            this.Controls.Add(this.testSizeLabel);
            this.Controls.Add(this.deliveryTimeMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.freeIngredientsLabel);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.pizzaSizeGroupBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PizzaApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pizzaSizeGroupBox.ResumeLayout(false);
            this.ingredientsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.GroupBox pizzaSizeGroupBox;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.Label freeIngredientsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox deliveryTimeMaskedTextBox;
        private System.Windows.Forms.Label testSizeLabel;
        private System.Windows.Forms.FlowLayoutPanel pizzaSizeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ingredientsFlowLayoutPanel;
        private System.Windows.Forms.Label testIngredientLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
    }
}

