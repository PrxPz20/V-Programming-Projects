
namespace The_Concentration_Game
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.cardsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.match2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.match3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideImageTimer = new System.Windows.Forms.Timer(this.components);
            this.CountDownLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.card1PictureBox = new System.Windows.Forms.PictureBox();
            this.cardFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.card2PictureBox = new System.Windows.Forms.PictureBox();
            this.card3PictureBox = new System.Windows.Forms.PictureBox();
            this.card_4_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_5_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_6_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_7_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_8_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_9_PictureBox = new System.Windows.Forms.PictureBox();
            this.card_10_PictureBox = new System.Windows.Forms.PictureBox();
            this.cardsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card1PictureBox)).BeginInit();
            this.cardFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_4_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_5_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_6_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_7_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_8_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_9_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_10_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardsGroupBox
            // 
            this.cardsGroupBox.Controls.Add(this.cardFlowLayoutPanel);
            this.cardsGroupBox.Location = new System.Drawing.Point(0, 27);
            this.cardsGroupBox.Name = "cardsGroupBox";
            this.cardsGroupBox.Size = new System.Drawing.Size(353, 198);
            this.cardsGroupBox.TabIndex = 0;
            this.cardsGroupBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameStripMenuItem,
            this.sizeStripMenuItem,
            this.ruleStripMenuItem,
            this.aboutStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameStripMenuItem
            // 
            this.gameStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameStripMenuItem.Name = "gameStripMenuItem";
            this.gameStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // sizeStripMenuItem
            // 
            this.sizeStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.sizeStripMenuItem.Name = "sizeStripMenuItem";
            this.sizeStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.sizeStripMenuItem.Text = "Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // ruleStripMenuItem
            // 
            this.ruleStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.match2ToolStripMenuItem,
            this.match3ToolStripMenuItem});
            this.ruleStripMenuItem.Name = "ruleStripMenuItem";
            this.ruleStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ruleStripMenuItem.Text = "Rule";
            // 
            // match2ToolStripMenuItem
            // 
            this.match2ToolStripMenuItem.Name = "match2ToolStripMenuItem";
            this.match2ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.match2ToolStripMenuItem.Text = "Match 2";
            // 
            // match3ToolStripMenuItem
            // 
            this.match3ToolStripMenuItem.Name = "match3ToolStripMenuItem";
            this.match3ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.match3ToolStripMenuItem.Text = "Match 3";
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutStripMenuItem.Text = "About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
            // 
            // CountDownLabel
            // 
            this.CountDownLabel.AutoSize = true;
            this.CountDownLabel.Location = new System.Drawing.Point(724, 43);
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Size = new System.Drawing.Size(35, 13);
            this.CountDownLabel.TabIndex = 2;
            this.CountDownLabel.Text = "label1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(232, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "button1";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // card1PictureBox
            // 
            this.card1PictureBox.Location = new System.Drawing.Point(6, 6);
            this.card1PictureBox.Name = "card1PictureBox";
            this.card1PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1PictureBox.TabIndex = 0;
            this.card1PictureBox.TabStop = false;
            // 
            // cardFlowLayoutPanel
            // 
            this.cardFlowLayoutPanel.Controls.Add(this.card1PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card2PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card3PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_4_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_5_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_6_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_7_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_8_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_9_PictureBox);
            this.cardFlowLayoutPanel.Controls.Add(this.card_10_PictureBox);
            this.cardFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.cardFlowLayoutPanel.Name = "cardFlowLayoutPanel";
            this.cardFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.cardFlowLayoutPanel.Size = new System.Drawing.Size(347, 179);
            this.cardFlowLayoutPanel.TabIndex = 0;
            // 
            // card2PictureBox
            // 
            this.card2PictureBox.Location = new System.Drawing.Point(72, 6);
            this.card2PictureBox.Name = "card2PictureBox";
            this.card2PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card2PictureBox.TabIndex = 1;
            this.card2PictureBox.TabStop = false;
            // 
            // card3PictureBox
            // 
            this.card3PictureBox.Location = new System.Drawing.Point(138, 6);
            this.card3PictureBox.Name = "card3PictureBox";
            this.card3PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card3PictureBox.TabIndex = 2;
            this.card3PictureBox.TabStop = false;
            // 
            // card_4_PictureBox
            // 
            this.card_4_PictureBox.Location = new System.Drawing.Point(204, 6);
            this.card_4_PictureBox.Name = "card_4_PictureBox";
            this.card_4_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_4_PictureBox.TabIndex = 3;
            this.card_4_PictureBox.TabStop = false;
            // 
            // card_5_PictureBox
            // 
            this.card_5_PictureBox.Location = new System.Drawing.Point(270, 6);
            this.card_5_PictureBox.Name = "card_5_PictureBox";
            this.card_5_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_5_PictureBox.TabIndex = 4;
            this.card_5_PictureBox.TabStop = false;
            // 
            // card_6_PictureBox
            // 
            this.card_6_PictureBox.Location = new System.Drawing.Point(6, 72);
            this.card_6_PictureBox.Name = "card_6_PictureBox";
            this.card_6_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_6_PictureBox.TabIndex = 5;
            this.card_6_PictureBox.TabStop = false;
            // 
            // card_7_PictureBox
            // 
            this.card_7_PictureBox.Location = new System.Drawing.Point(72, 72);
            this.card_7_PictureBox.Name = "card_7_PictureBox";
            this.card_7_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_7_PictureBox.TabIndex = 6;
            this.card_7_PictureBox.TabStop = false;
            // 
            // card_8_PictureBox
            // 
            this.card_8_PictureBox.Location = new System.Drawing.Point(138, 72);
            this.card_8_PictureBox.Name = "card_8_PictureBox";
            this.card_8_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_8_PictureBox.TabIndex = 7;
            this.card_8_PictureBox.TabStop = false;
            // 
            // card_9_PictureBox
            // 
            this.card_9_PictureBox.Location = new System.Drawing.Point(204, 72);
            this.card_9_PictureBox.Name = "card_9_PictureBox";
            this.card_9_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_9_PictureBox.TabIndex = 8;
            this.card_9_PictureBox.TabStop = false;
            // 
            // card_10_PictureBox
            // 
            this.card_10_PictureBox.Location = new System.Drawing.Point(270, 72);
            this.card_10_PictureBox.Name = "card_10_PictureBox";
            this.card_10_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.card_10_PictureBox.TabIndex = 9;
            this.card_10_PictureBox.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.CountDownLabel);
            this.Controls.Add(this.cardsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.cardsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card1PictureBox)).EndInit();
            this.cardFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.card2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_4_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_5_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_6_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_7_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_8_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_9_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_10_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cardsGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem match2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem match3ToolStripMenuItem;
        private System.Windows.Forms.Timer hideImageTimer;
        private System.Windows.Forms.Label CountDownLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel cardFlowLayoutPanel;
        private System.Windows.Forms.PictureBox card1PictureBox;
        private System.Windows.Forms.PictureBox card2PictureBox;
        private System.Windows.Forms.PictureBox card3PictureBox;
        private System.Windows.Forms.PictureBox card_4_PictureBox;
        private System.Windows.Forms.PictureBox card_5_PictureBox;
        private System.Windows.Forms.PictureBox card_6_PictureBox;
        private System.Windows.Forms.PictureBox card_7_PictureBox;
        private System.Windows.Forms.PictureBox card_8_PictureBox;
        private System.Windows.Forms.PictureBox card_9_PictureBox;
        private System.Windows.Forms.PictureBox card_10_PictureBox;
    }
}

