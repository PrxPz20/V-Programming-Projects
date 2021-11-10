
namespace PizzaApplication
{
    partial class AddressForm
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
            this.locationadressTextBox = new System.Windows.Forms.TextBox();
            this.setaddressButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // locationadressTextBox
            // 
            this.locationadressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.locationadressTextBox.Location = new System.Drawing.Point(193, 54);
            this.locationadressTextBox.Name = "locationadressTextBox";
            this.locationadressTextBox.Size = new System.Drawing.Size(228, 33);
            this.locationadressTextBox.TabIndex = 1;
            // 
            // setaddressButton
            // 
            this.setaddressButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.setaddressButton.Location = new System.Drawing.Point(147, 114);
            this.setaddressButton.Name = "setaddressButton";
            this.setaddressButton.Size = new System.Drawing.Size(108, 29);
            this.setaddressButton.TabIndex = 2;
            this.setaddressButton.Text = "Set Address";
            this.setaddressButton.UseVisualStyleBackColor = true;
            this.setaddressButton.Click += new System.EventHandler(this.setaddressButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location Address:";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setaddressButton);
            this.Controls.Add(this.locationadressTextBox);
            this.Name = "AddressForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationadressTextBox;
        private System.Windows.Forms.Button setaddressButton;
        private System.Windows.Forms.Label label1;
    }
}