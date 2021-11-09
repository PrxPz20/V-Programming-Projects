
namespace PizzaApplication
{
    partial class Form1
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
            this.ingredientsGroupBox2 = new System.Windows.Forms.GroupBox();
            this.freeIngredientsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza App";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(107, 375);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(59, 25);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "price";
            // 
            // pizzaSizeGroupBox
            // 
            this.pizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeGroupBox.Location = new System.Drawing.Point(18, 56);
            this.pizzaSizeGroupBox.Name = "pizzaSizeGroupBox";
            this.pizzaSizeGroupBox.Size = new System.Drawing.Size(224, 185);
            this.pizzaSizeGroupBox.TabIndex = 3;
            this.pizzaSizeGroupBox.TabStop = false;
            this.pizzaSizeGroupBox.Text = "Size";
            // 
            // ingredientsGroupBox2
            // 
            this.ingredientsGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsGroupBox2.Location = new System.Drawing.Point(332, 56);
            this.ingredientsGroupBox2.Name = "ingredientsGroupBox2";
            this.ingredientsGroupBox2.Size = new System.Drawing.Size(419, 185);
            this.ingredientsGroupBox2.TabIndex = 4;
            this.ingredientsGroupBox2.TabStop = false;
            this.ingredientsGroupBox2.Text = "Ingredients";
            // 
            // freeIngredientsLabel
            // 
            this.freeIngredientsLabel.AutoSize = true;
            this.freeIngredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeIngredientsLabel.Location = new System.Drawing.Point(328, 244);
            this.freeIngredientsLabel.Name = "freeIngredientsLabel";
            this.freeIngredientsLabel.Size = new System.Drawing.Size(153, 24);
            this.freeIngredientsLabel.TabIndex = 5;
            this.freeIngredientsLabel.Text = "Free Ingredients:";
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(375, 375);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 31);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.freeIngredientsLabel);
            this.Controls.Add(this.ingredientsGroupBox2);
            this.Controls.Add(this.pizzaSizeGroupBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Name = "Form1";
            this.Text = "PizzaApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.GroupBox pizzaSizeGroupBox;
        private System.Windows.Forms.GroupBox ingredientsGroupBox2;
        private System.Windows.Forms.Label freeIngredientsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

