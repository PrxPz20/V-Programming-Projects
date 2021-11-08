
namespace week3_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.pizzaSizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.ingredientGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomCheckBox = new System.Windows.Forms.CheckBox();
            this.black_olivesCheckBox = new System.Windows.Forms.CheckBox();
            this.extra_cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.tomatoCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.fetaCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.free_top_upLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.priceLabel = new System.Windows.Forms.Label();
            this.deliveryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sizeGroupBox.SuspendLayout();
            this.pizzaSizeFlowLayoutPanel.SuspendLayout();
            this.ingredientGroupBox.SuspendLayout();
            this.ingredientsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderButton.Location = new System.Drawing.Point(249, 427);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(167, 47);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Pizza App";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.pizzaSizeFlowLayoutPanel);
            this.sizeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 85);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(266, 180);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // pizzaSizeFlowLayoutPanel
            // 
            this.pizzaSizeFlowLayoutPanel.Controls.Add(this.label2);
            this.pizzaSizeFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzaSizeFlowLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.pizzaSizeFlowLayoutPanel.Name = "pizzaSizeFlowLayoutPanel";
            this.pizzaSizeFlowLayoutPanel.Size = new System.Drawing.Size(260, 152);
            this.pizzaSizeFlowLayoutPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select pizza size";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(250, 282);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(105, 19);
            this.smallRadioButton.TabIndex = 5;
            this.smallRadioButton.Text = "Small       € 5.50";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.smallRadioButton.Click += new System.EventHandler(this.sizeClicked);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(250, 313);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(111, 19);
            this.LargeRadioButton.TabIndex = 7;
            this.LargeRadioButton.Text = "Large       € 15.00";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.LargeRadioButton.Click += new System.EventHandler(this.sizeClicked);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(250, 344);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(112, 19);
            this.mediumRadioButton.TabIndex = 6;
            this.mediumRadioButton.Text = "Medium  € 11.75";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.mediumRadioButton.Click += new System.EventHandler(this.sizeClicked);
            // 
            // ingredientGroupBox
            // 
            this.ingredientGroupBox.Controls.Add(this.ingredientsFlowLayoutPanel);
            this.ingredientGroupBox.Enabled = false;
            this.ingredientGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientGroupBox.Location = new System.Drawing.Point(396, 85);
            this.ingredientGroupBox.Name = "ingredientGroupBox";
            this.ingredientGroupBox.Size = new System.Drawing.Size(466, 177);
            this.ingredientGroupBox.TabIndex = 3;
            this.ingredientGroupBox.TabStop = false;
            this.ingredientGroupBox.Text = "Ingredients";
            // 
            // ingredientsFlowLayoutPanel
            // 
            this.ingredientsFlowLayoutPanel.Controls.Add(this.PepperoniCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.pineappleCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.mushroomCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.black_olivesCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.extra_cheeseCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.onionCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.tomatoCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.sausageCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.fetaCheckBox);
            this.ingredientsFlowLayoutPanel.Controls.Add(this.checkBox1);
            this.ingredientsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ingredientsFlowLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.ingredientsFlowLayoutPanel.Name = "ingredientsFlowLayoutPanel";
            this.ingredientsFlowLayoutPanel.Size = new System.Drawing.Size(460, 149);
            this.ingredientsFlowLayoutPanel.TabIndex = 0;
            // 
            // PepperoniCheckBox
            // 
            this.PepperoniCheckBox.AutoSize = true;
            this.PepperoniCheckBox.Location = new System.Drawing.Point(3, 3);
            this.PepperoniCheckBox.Name = "PepperoniCheckBox";
            this.PepperoniCheckBox.Size = new System.Drawing.Size(99, 25);
            this.PepperoniCheckBox.TabIndex = 0;
            this.PepperoniCheckBox.Text = "Pepperoni";
            this.PepperoniCheckBox.UseVisualStyleBackColor = true;
            this.PepperoniCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(3, 34);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(97, 25);
            this.pineappleCheckBox.TabIndex = 6;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            this.pineappleCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // mushroomCheckBox
            // 
            this.mushroomCheckBox.AutoSize = true;
            this.mushroomCheckBox.Location = new System.Drawing.Point(3, 65);
            this.mushroomCheckBox.Name = "mushroomCheckBox";
            this.mushroomCheckBox.Size = new System.Drawing.Size(106, 25);
            this.mushroomCheckBox.TabIndex = 5;
            this.mushroomCheckBox.Text = "Mushroom";
            this.mushroomCheckBox.UseVisualStyleBackColor = true;
            this.mushroomCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // black_olivesCheckBox
            // 
            this.black_olivesCheckBox.AutoSize = true;
            this.black_olivesCheckBox.Location = new System.Drawing.Point(3, 96);
            this.black_olivesCheckBox.Name = "black_olivesCheckBox";
            this.black_olivesCheckBox.Size = new System.Drawing.Size(112, 25);
            this.black_olivesCheckBox.TabIndex = 3;
            this.black_olivesCheckBox.Text = "Black Olives";
            this.black_olivesCheckBox.UseVisualStyleBackColor = true;
            this.black_olivesCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // extra_cheeseCheckBox
            // 
            this.extra_cheeseCheckBox.AutoSize = true;
            this.extra_cheeseCheckBox.Location = new System.Drawing.Point(121, 3);
            this.extra_cheeseCheckBox.Name = "extra_cheeseCheckBox";
            this.extra_cheeseCheckBox.Size = new System.Drawing.Size(117, 25);
            this.extra_cheeseCheckBox.TabIndex = 2;
            this.extra_cheeseCheckBox.Text = "Extra Cheese";
            this.extra_cheeseCheckBox.UseVisualStyleBackColor = true;
            this.extra_cheeseCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(121, 34);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(72, 25);
            this.onionCheckBox.TabIndex = 1;
            this.onionCheckBox.Text = "Onion";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // tomatoCheckBox
            // 
            this.tomatoCheckBox.AutoSize = true;
            this.tomatoCheckBox.Location = new System.Drawing.Point(121, 65);
            this.tomatoCheckBox.Name = "tomatoCheckBox";
            this.tomatoCheckBox.Size = new System.Drawing.Size(80, 25);
            this.tomatoCheckBox.TabIndex = 12;
            this.tomatoCheckBox.Text = "Tomato";
            this.tomatoCheckBox.UseVisualStyleBackColor = true;
            this.tomatoCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(121, 96);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(87, 25);
            this.sausageCheckBox.TabIndex = 13;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // fetaCheckBox
            // 
            this.fetaCheckBox.AutoSize = true;
            this.fetaCheckBox.Location = new System.Drawing.Point(244, 3);
            this.fetaCheckBox.Name = "fetaCheckBox";
            this.fetaCheckBox.Size = new System.Drawing.Size(58, 25);
            this.fetaCheckBox.TabIndex = 14;
            this.fetaCheckBox.Text = "Feta";
            this.fetaCheckBox.UseVisualStyleBackColor = true;
            this.fetaCheckBox.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(244, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 25);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Chopped basil";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Uncheck_state);
            // 
            // free_top_upLabel
            // 
            this.free_top_upLabel.AutoSize = true;
            this.free_top_upLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.free_top_upLabel.Location = new System.Drawing.Point(396, 265);
            this.free_top_upLabel.Name = "free_top_upLabel";
            this.free_top_upLabel.Size = new System.Drawing.Size(157, 25);
            this.free_top_upLabel.TabIndex = 4;
            this.free_top_upLabel.Text = "Free Ingredients: ";
            this.free_top_upLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select the ingredients\r\n      + € 0.75 extra ingredient\r\n";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(118, 363);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(66, 32);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "price";
            this.priceLabel.Visible = false;
            // 
            // deliveryMaskedTextBox
            // 
            this.deliveryMaskedTextBox.Enabled = false;
            this.deliveryMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryMaskedTextBox.Location = new System.Drawing.Point(417, 366);
            this.deliveryMaskedTextBox.Mask = "00:00";
            this.deliveryMaskedTextBox.Name = "deliveryMaskedTextBox";
            this.deliveryMaskedTextBox.Size = new System.Drawing.Size(65, 29);
            this.deliveryMaskedTextBox.TabIndex = 7;
            this.deliveryMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.deliveryMaskedTextBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.deliveryMaskedTextBox_TypeValidationCompleted);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(566, 334);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(26, 15);
            this.testLabel.TabIndex = 8;
            this.testLabel.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::week3_v2.Properties.Resources.Pizza_Image_logo;
            this.pictureBox1.Location = new System.Drawing.Point(316, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(250, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delivery Time:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::week3_v2.Properties.Resources.Delivery_icon;
            this.pictureBox2.Location = new System.Drawing.Point(210, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::week3_v2.Properties.Resources.Total_price_icon_euro;
            this.pictureBox3.Location = new System.Drawing.Point(12, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(875, 24);
            this.mainMenuStrip.TabIndex = 15;
            this.mainMenuStrip.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 497);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.smallRadioButton);
            this.Controls.Add(this.LargeRadioButton);
            this.Controls.Add(this.free_top_upLabel);
            this.Controls.Add(this.mediumRadioButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.deliveryMaskedTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ingredientGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Name = "Form1";
            this.Text = "PizzaApp";
            this.sizeGroupBox.ResumeLayout(false);
            this.pizzaSizeFlowLayoutPanel.ResumeLayout(false);
            this.pizzaSizeFlowLayoutPanel.PerformLayout();
            this.ingredientGroupBox.ResumeLayout(false);
            this.ingredientsFlowLayoutPanel.ResumeLayout(false);
            this.ingredientsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.GroupBox ingredientGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox black_olivesCheckBox;
        private System.Windows.Forms.CheckBox extra_cheeseCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox PepperoniCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
        private System.Windows.Forms.CheckBox mushroomCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label free_top_upLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MaskedTextBox deliveryMaskedTextBox;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel ingredientsFlowLayoutPanel;
        private System.Windows.Forms.CheckBox tomatoCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.CheckBox fetaCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pizzaSizeFlowLayoutPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

