
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
            this.label2 = new System.Windows.Forms.Label();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.ingredientGroupBox = new System.Windows.Forms.GroupBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.black_olivesCheckBox = new System.Windows.Forms.CheckBox();
            this.extra_cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.PepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.free_top_upLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deliveryTextBox = new System.Windows.Forms.MaskedTextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.sizeGroupBox.SuspendLayout();
            this.ingredientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderButton.Location = new System.Drawing.Point(67, 504);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(167, 47);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Pizza App";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.label2);
            this.sizeGroupBox.Controls.Add(this.LargeRadioButton);
            this.sizeGroupBox.Controls.Add(this.smallRadioButton);
            this.sizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.sizeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 68);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(266, 159);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select pizza size";
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(6, 120);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(143, 25);
            this.LargeRadioButton.TabIndex = 7;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large       $15.00";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.LargeRadioButton.Click += new System.EventHandler(this.sizeClicked);
            this.LargeRadioButton.MouseHover += new System.EventHandler(this.LargeRadioButton_MouseHover);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(6, 58);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(134, 25);
            this.smallRadioButton.TabIndex = 5;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small       $5.50";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.smallRadioButton.Click += new System.EventHandler(this.sizeClicked);
            this.smallRadioButton.MouseHover += new System.EventHandler(this.smallRadioButton_MouseHover);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(6, 89);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(142, 25);
            this.mediumRadioButton.TabIndex = 6;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium  $11.75";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.sizeRadioButton_CheckedChanged);
            this.mediumRadioButton.Click += new System.EventHandler(this.sizeClicked);
            this.mediumRadioButton.MouseHover += new System.EventHandler(this.mediumRadioButton_MouseHover);
            // 
            // ingredientGroupBox
            // 
            this.ingredientGroupBox.Controls.Add(this.pineappleCheckBox);
            this.ingredientGroupBox.Controls.Add(this.mushroomCheckBox);
            this.ingredientGroupBox.Controls.Add(this.label3);
            this.ingredientGroupBox.Controls.Add(this.black_olivesCheckBox);
            this.ingredientGroupBox.Controls.Add(this.extra_cheeseCheckBox);
            this.ingredientGroupBox.Controls.Add(this.onionCheckBox);
            this.ingredientGroupBox.Controls.Add(this.PepperoniCheckBox);
            this.ingredientGroupBox.Enabled = false;
            this.ingredientGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientGroupBox.Location = new System.Drawing.Point(12, 255);
            this.ingredientGroupBox.Name = "ingredientGroupBox";
            this.ingredientGroupBox.Size = new System.Drawing.Size(266, 193);
            this.ingredientGroupBox.TabIndex = 3;
            this.ingredientGroupBox.TabStop = false;
            this.ingredientGroupBox.Text = "Ingredients";
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(141, 92);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(97, 25);
            this.pineappleCheckBox.TabIndex = 6;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            this.pineappleCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // mushroomCheckBox
            // 
            this.mushroomCheckBox.AutoSize = true;
            this.mushroomCheckBox.Location = new System.Drawing.Point(141, 61);
            this.mushroomCheckBox.Name = "mushroomCheckBox";
            this.mushroomCheckBox.Size = new System.Drawing.Size(106, 25);
            this.mushroomCheckBox.TabIndex = 5;
            this.mushroomCheckBox.Text = "Mushroom";
            this.mushroomCheckBox.UseVisualStyleBackColor = true;
            this.mushroomCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select the ingredients";
            // 
            // black_olivesCheckBox
            // 
            this.black_olivesCheckBox.AutoSize = true;
            this.black_olivesCheckBox.Location = new System.Drawing.Point(6, 123);
            this.black_olivesCheckBox.Name = "black_olivesCheckBox";
            this.black_olivesCheckBox.Size = new System.Drawing.Size(112, 25);
            this.black_olivesCheckBox.TabIndex = 3;
            this.black_olivesCheckBox.Text = "Black Olives";
            this.black_olivesCheckBox.UseVisualStyleBackColor = true;
            this.black_olivesCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // extra_cheeseCheckBox
            // 
            this.extra_cheeseCheckBox.AutoSize = true;
            this.extra_cheeseCheckBox.Location = new System.Drawing.Point(141, 123);
            this.extra_cheeseCheckBox.Name = "extra_cheeseCheckBox";
            this.extra_cheeseCheckBox.Size = new System.Drawing.Size(117, 25);
            this.extra_cheeseCheckBox.TabIndex = 2;
            this.extra_cheeseCheckBox.Text = "Extra Cheese";
            this.extra_cheeseCheckBox.UseVisualStyleBackColor = true;
            this.extra_cheeseCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(6, 92);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(72, 25);
            this.onionCheckBox.TabIndex = 1;
            this.onionCheckBox.Text = "Onion";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // PepperoniCheckBox
            // 
            this.PepperoniCheckBox.AutoSize = true;
            this.PepperoniCheckBox.Location = new System.Drawing.Point(6, 61);
            this.PepperoniCheckBox.Name = "PepperoniCheckBox";
            this.PepperoniCheckBox.Size = new System.Drawing.Size(99, 25);
            this.PepperoniCheckBox.TabIndex = 0;
            this.PepperoniCheckBox.Text = "Pepperoni";
            this.PepperoniCheckBox.UseVisualStyleBackColor = true;
            this.PepperoniCheckBox.Click += new System.EventHandler(this.ingredientChecked);
            // 
            // free_top_upLabel
            // 
            this.free_top_upLabel.AutoSize = true;
            this.free_top_upLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.free_top_upLabel.Location = new System.Drawing.Point(121, 243);
            this.free_top_upLabel.Name = "free_top_upLabel";
            this.free_top_upLabel.Size = new System.Drawing.Size(50, 20);
            this.free_top_upLabel.TabIndex = 4;
            this.free_top_upLabel.Text = "label4";
            this.free_top_upLabel.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(228, 470);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 20);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "label4";
            // 
            // deliveryTextBox
            // 
            this.deliveryTextBox.Enabled = false;
            this.deliveryTextBox.Location = new System.Drawing.Point(293, 113);
            this.deliveryTextBox.Name = "deliveryTextBox";
            this.deliveryTextBox.Size = new System.Drawing.Size(100, 23);
            this.deliveryTextBox.TabIndex = 7;
            this.deliveryTextBox.Text = "_ _ _";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(316, 211);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(38, 15);
            this.testLabel.TabIndex = 8;
            this.testLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 579);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.deliveryTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.free_top_upLabel);
            this.Controls.Add(this.ingredientGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ingredientGroupBox.ResumeLayout(false);
            this.ingredientGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.GroupBox ingredientGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
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
        private System.Windows.Forms.MaskedTextBox deliveryTextBox;
        private System.Windows.Forms.Label testLabel;
    }
}

