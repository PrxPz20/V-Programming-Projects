
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
            this.cardTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.cardsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardsGroupBox
            // 
            this.cardsGroupBox.Controls.Add(this.cardTableLayoutPanel);
            this.cardsGroupBox.Location = new System.Drawing.Point(0, 27);
            this.cardsGroupBox.Name = "cardsGroupBox";
            this.cardsGroupBox.Size = new System.Drawing.Size(671, 237);
            this.cardsGroupBox.TabIndex = 0;
            this.cardsGroupBox.TabStop = false;
            // 
            // cardTableLayoutPanel
            // 
            this.cardTableLayoutPanel.ColumnCount = 5;
            this.cardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.cardTableLayoutPanel.Name = "cardTableLayoutPanel";
            this.cardTableLayoutPanel.RowCount = 2;
            this.cardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardTableLayoutPanel.Size = new System.Drawing.Size(665, 218);
            this.cardTableLayoutPanel.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.cardsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.cardsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cardsGroupBox;
        private System.Windows.Forms.TableLayoutPanel cardTableLayoutPanel;
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
    }
}

