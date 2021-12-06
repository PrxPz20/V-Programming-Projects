
namespace Shopping_List
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
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.todoGroupBox = new System.Windows.Forms.GroupBox();
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.markCompleteButton = new System.Windows.Forms.Button();
            this.completedGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.completedListBox = new System.Windows.Forms.ListBox();
            this.itemGroupBox.SuspendLayout();
            this.todoGroupBox.SuspendLayout();
            this.completedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.nameLabel);
            this.itemGroupBox.Controls.Add(this.quantityLabel);
            this.itemGroupBox.Controls.Add(this.quantityTextBox);
            this.itemGroupBox.Controls.Add(this.nameTextBox);
            this.itemGroupBox.Controls.Add(this.addButton);
            this.itemGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemGroupBox.Location = new System.Drawing.Point(12, 30);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(347, 374);
            this.itemGroupBox.TabIndex = 0;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Items";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(6, 187);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 20);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(80, 187);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(211, 26);
            this.quantityTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(121, 332);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // todoGroupBox
            // 
            this.todoGroupBox.Controls.Add(this.todoListBox);
            this.todoGroupBox.Controls.Add(this.deleteButton);
            this.todoGroupBox.Controls.Add(this.markCompleteButton);
            this.todoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoGroupBox.Location = new System.Drawing.Point(365, 30);
            this.todoGroupBox.Name = "todoGroupBox";
            this.todoGroupBox.Size = new System.Drawing.Size(368, 374);
            this.todoGroupBox.TabIndex = 1;
            this.todoGroupBox.TabStop = false;
            this.todoGroupBox.Text = "Todo";
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 20;
            this.todoListBox.Location = new System.Drawing.Point(0, 22);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(368, 304);
            this.todoListBox.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(6, 332);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 36);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // markCompleteButton
            // 
            this.markCompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markCompleteButton.Location = new System.Drawing.Point(133, 332);
            this.markCompleteButton.Name = "markCompleteButton";
            this.markCompleteButton.Size = new System.Drawing.Size(210, 37);
            this.markCompleteButton.TabIndex = 4;
            this.markCompleteButton.Text = "Mark as Complete";
            this.markCompleteButton.UseVisualStyleBackColor = true;
            // 
            // completedGroupBox
            // 
            this.completedGroupBox.Controls.Add(this.clearButton);
            this.completedGroupBox.Controls.Add(this.completedListBox);
            this.completedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedGroupBox.Location = new System.Drawing.Point(739, 30);
            this.completedGroupBox.Name = "completedGroupBox";
            this.completedGroupBox.Size = new System.Drawing.Size(420, 374);
            this.completedGroupBox.TabIndex = 1;
            this.completedGroupBox.TabStop = false;
            this.completedGroupBox.Text = "Completed";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(6, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 31);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // completedListBox
            // 
            this.completedListBox.FormattingEnabled = true;
            this.completedListBox.ItemHeight = 20;
            this.completedListBox.Location = new System.Drawing.Point(0, 22);
            this.completedListBox.Name = "completedListBox";
            this.completedListBox.Size = new System.Drawing.Size(420, 304);
            this.completedListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 458);
            this.Controls.Add(this.todoGroupBox);
            this.Controls.Add(this.completedGroupBox);
            this.Controls.Add(this.itemGroupBox);
            this.Name = "Form1";
            this.Text = "Shopping List";
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.todoGroupBox.ResumeLayout(false);
            this.completedGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox todoGroupBox;
        private System.Windows.Forms.GroupBox completedGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button markCompleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.ListBox completedListBox;
    }
}

