
namespace Sandwich_Shop
{
    partial class mainShopForm
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
            this.shopNameLabel = new System.Windows.Forms.Label();
            this.breadGroupBox = new System.Windows.Forms.GroupBox();
            this.breadFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.priceTextLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadGroupBox.SuspendLayout();
            this.ingredientsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLabel.Location = new System.Drawing.Point(12, 41);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(202, 31);
            this.shopNameLabel.TabIndex = 0;
            this.shopNameLabel.Text = "Sandwich Shop";
            // 
            // breadGroupBox
            // 
            this.breadGroupBox.Controls.Add(this.breadFlowLayoutPanel1);
            this.breadGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadGroupBox.Location = new System.Drawing.Point(18, 123);
            this.breadGroupBox.Name = "breadGroupBox";
            this.breadGroupBox.Size = new System.Drawing.Size(328, 205);
            this.breadGroupBox.TabIndex = 1;
            this.breadGroupBox.TabStop = false;
            this.breadGroupBox.Text = "Choice you bread type";
            // 
            // breadFlowLayoutPanel1
            // 
            this.breadFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.breadFlowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.breadFlowLayoutPanel1.Name = "breadFlowLayoutPanel1";
            this.breadFlowLayoutPanel1.Size = new System.Drawing.Size(322, 180);
            this.breadFlowLayoutPanel1.TabIndex = 0;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsFlowLayoutPanel);
            this.ingredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsGroupBox.Location = new System.Drawing.Point(376, 123);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(387, 205);
            this.ingredientsGroupBox.TabIndex = 2;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.Text = "Choice your ingredients";
            // 
            // ingredientsFlowLayoutPanel
            // 
            this.ingredientsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.ingredientsFlowLayoutPanel.Name = "ingredientsFlowLayoutPanel";
            this.ingredientsFlowLayoutPanel.Size = new System.Drawing.Size(381, 180);
            this.ingredientsFlowLayoutPanel.TabIndex = 0;
            // 
            // priceTextLabel
            // 
            this.priceTextLabel.AutoSize = true;
            this.priceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextLabel.Location = new System.Drawing.Point(31, 447);
            this.priceTextLabel.Name = "priceTextLabel";
            this.priceTextLabel.Size = new System.Drawing.Size(66, 25);
            this.priceTextLabel.TabIndex = 3;
            this.priceTextLabel.Text = "Total:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(103, 447);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(107, 25);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "Totalprice";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsStripMenuItem
            // 
            this.settingsStripMenuItem.Name = "settingsStripMenuItem";
            this.settingsStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsStripMenuItem.Text = "Settings";
            this.settingsStripMenuItem.Click += new System.EventHandler(this.settingsStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.priceTextLabel);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.breadGroupBox);
            this.Controls.Add(this.shopNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainShopForm";
            this.Text = "Sandwich Shop";
            this.breadGroupBox.ResumeLayout(false);
            this.ingredientsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopNameLabel;
        private System.Windows.Forms.GroupBox breadGroupBox;
        private System.Windows.Forms.FlowLayoutPanel breadFlowLayoutPanel1;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ingredientsFlowLayoutPanel;
        private System.Windows.Forms.Label priceTextLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

