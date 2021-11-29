
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
            this.pizzaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.pizzaSizeGroupBox.SuspendLayout();
            this.ingredientsGroupBox.SuspendLayout();
            this.pizzaMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(662, 371);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(109, 39);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Pizza App";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totalPriceLabel.Location = new System.Drawing.Point(124, 376);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(73, 31);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "price";
            this.totalPriceLabel.Visible = false;
            // 
            // pizzaSizeGroupBox
            // 
            this.pizzaSizeGroupBox.Controls.Add(this.pizzaSizeFlowLayoutPanel);
            this.pizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeGroupBox.Location = new System.Drawing.Point(22, 120);
            this.pizzaSizeGroupBox.Name = "pizzaSizeGroupBox";
            this.pizzaSizeGroupBox.Size = new System.Drawing.Size(278, 185);
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
            this.pizzaSizeFlowLayoutPanel.Size = new System.Drawing.Size(272, 160);
            this.pizzaSizeFlowLayoutPanel.TabIndex = 0;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsFlowLayoutPanel);
            this.ingredientsGroupBox.Enabled = false;
            this.ingredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsGroupBox.Location = new System.Drawing.Point(336, 120);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(438, 185);
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
            this.ingredientsFlowLayoutPanel.Size = new System.Drawing.Size(432, 162);
            this.ingredientsFlowLayoutPanel.TabIndex = 0;
            // 
            // freeIngredientsLabel
            // 
            this.freeIngredientsLabel.AutoSize = true;
            this.freeIngredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeIngredientsLabel.Location = new System.Drawing.Point(332, 308);
            this.freeIngredientsLabel.Name = "freeIngredientsLabel";
            this.freeIngredientsLabel.Size = new System.Drawing.Size(153, 24);
            this.freeIngredientsLabel.TabIndex = 5;
            this.freeIngredientsLabel.Text = "Free Ingredients:";
            this.freeIngredientsLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery Time:";
            // 
            // deliveryTimeMaskedTextBox
            // 
            this.deliveryTimeMaskedTextBox.Enabled = false;
            this.deliveryTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTimeMaskedTextBox.Location = new System.Drawing.Point(435, 372);
            this.deliveryTimeMaskedTextBox.Mask = "00:00";
            this.deliveryTimeMaskedTextBox.Name = "deliveryTimeMaskedTextBox";
            this.deliveryTimeMaskedTextBox.Size = new System.Drawing.Size(106, 38);
            this.deliveryTimeMaskedTextBox.TabIndex = 8;
            this.deliveryTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.deliveryTimeMaskedTextBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.deliveryTimeMaskedTextBox_TypeValidationCompleted);
            // 
            // pizzaMenuStrip
            // 
            this.pizzaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.aboutStripMenuItem});
            this.pizzaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.pizzaMenuStrip.Name = "pizzaMenuStrip";
            this.pizzaMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.pizzaMenuStrip.TabIndex = 11;
            this.pizzaMenuStrip.Text = "menuStrip1";
            // 
            // settingsStripMenuItem
            // 
            this.settingsStripMenuItem.Name = "settingsStripMenuItem";
            this.settingsStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsStripMenuItem.Text = "Settings";
            this.settingsStripMenuItem.Visible = false;
            this.settingsStripMenuItem.Click += new System.EventHandler(this.settingsStripMenuItem_Click);
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutStripMenuItem.Text = "About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
            // 
            // pizzaLogoPictureBox
            // 
            this.pizzaLogoPictureBox.Image = global::PizzaApplication.Properties.Resources.Pizza_Logo;
            this.pizzaLogoPictureBox.Location = new System.Drawing.Point(375, 27);
            this.pizzaLogoPictureBox.Name = "pizzaLogoPictureBox";
            this.pizzaLogoPictureBox.Size = new System.Drawing.Size(98, 72);
            this.pizzaLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pizzaLogoPictureBox.TabIndex = 12;
            this.pizzaLogoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pizzaLogoPictureBox);
            this.Controls.Add(this.deliveryTimeMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.freeIngredientsLabel);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.pizzaSizeGroupBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.pizzaMenuStrip);
            this.MainMenuStrip = this.pizzaMenuStrip;
            this.Name = "MainForm";
            this.Text = "PizzaApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pizzaSizeGroupBox.ResumeLayout(false);
            this.ingredientsGroupBox.ResumeLayout(false);
            this.pizzaMenuStrip.ResumeLayout(false);
            this.pizzaMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaLogoPictureBox)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel pizzaSizeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ingredientsFlowLayoutPanel;
        private System.Windows.Forms.MenuStrip pizzaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.PictureBox pizzaLogoPictureBox;
    }
}

