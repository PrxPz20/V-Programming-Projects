
namespace Class_Grading
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.greadWeightsGroupBox = new System.Windows.Forms.GroupBox();
            this.greadWeightsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.attendnceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.homeworkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.midtermNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.finalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridGroupBox = new System.Windows.Forms.GroupBox();
            this.studentGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentsCountTextBox = new System.Windows.Forms.TextBox();
            this.classAverageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passRateLabel = new System.Windows.Forms.Label();
            this.passRateTextBox = new System.Windows.Forms.TextBox();
            this.greadWeightsGroupBox.SuspendLayout();
            this.greadWeightsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendnceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalNumericUpDown)).BeginInit();
            this.dataGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).BeginInit();
            this.statsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // greadWeightsGroupBox
            // 
            this.greadWeightsGroupBox.Controls.Add(this.greadWeightsFlowLayoutPanel);
            this.greadWeightsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greadWeightsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.greadWeightsGroupBox.Name = "greadWeightsGroupBox";
            this.greadWeightsGroupBox.Size = new System.Drawing.Size(721, 95);
            this.greadWeightsGroupBox.TabIndex = 0;
            this.greadWeightsGroupBox.TabStop = false;
            this.greadWeightsGroupBox.Text = "Gread Weights";
            // 
            // greadWeightsFlowLayoutPanel
            // 
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.label1);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.attendnceNumericUpDown);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.label2);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.homeworkNumericUpDown);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.label3);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.midtermNumericUpDown);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.label4);
            this.greadWeightsFlowLayoutPanel.Controls.Add(this.finalNumericUpDown);
            this.greadWeightsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greadWeightsFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.greadWeightsFlowLayoutPanel.Name = "greadWeightsFlowLayoutPanel";
            this.greadWeightsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.greadWeightsFlowLayoutPanel.Size = new System.Drawing.Size(715, 70);
            this.greadWeightsFlowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendnce:";
            // 
            // attendnceNumericUpDown
            // 
            this.attendnceNumericUpDown.Location = new System.Drawing.Point(96, 23);
            this.attendnceNumericUpDown.Name = "attendnceNumericUpDown";
            this.attendnceNumericUpDown.Size = new System.Drawing.Size(79, 26);
            this.attendnceNumericUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Homework:";
            // 
            // homeworkNumericUpDown
            // 
            this.homeworkNumericUpDown.Location = new System.Drawing.Point(276, 23);
            this.homeworkNumericUpDown.Name = "homeworkNumericUpDown";
            this.homeworkNumericUpDown.Size = new System.Drawing.Size(79, 26);
            this.homeworkNumericUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Midterm";
            // 
            // midtermNumericUpDown
            // 
            this.midtermNumericUpDown.Location = new System.Drawing.Point(433, 23);
            this.midtermNumericUpDown.Name = "midtermNumericUpDown";
            this.midtermNumericUpDown.Size = new System.Drawing.Size(79, 26);
            this.midtermNumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Final:";
            // 
            // finalNumericUpDown
            // 
            this.finalNumericUpDown.Location = new System.Drawing.Point(571, 23);
            this.finalNumericUpDown.Name = "finalNumericUpDown";
            this.finalNumericUpDown.Size = new System.Drawing.Size(79, 26);
            this.finalNumericUpDown.TabIndex = 6;
            // 
            // dataGridGroupBox
            // 
            this.dataGridGroupBox.Controls.Add(this.studentGradesDataGridView);
            this.dataGridGroupBox.Location = new System.Drawing.Point(15, 113);
            this.dataGridGroupBox.Name = "dataGridGroupBox";
            this.dataGridGroupBox.Size = new System.Drawing.Size(718, 448);
            this.dataGridGroupBox.TabIndex = 1;
            this.dataGridGroupBox.TabStop = false;
            // 
            // studentGradesDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGradesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentGradesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGradesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.studentGradesDataGridView.Name = "studentGradesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentGradesDataGridView.Size = new System.Drawing.Size(712, 429);
            this.studentGradesDataGridView.TabIndex = 0;
            this.studentGradesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGradesDataGridView_CellValueChanged);
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.passRateLabel);
            this.statsGroupBox.Controls.Add(this.passRateTextBox);
            this.statsGroupBox.Controls.Add(this.label6);
            this.statsGroupBox.Controls.Add(this.studentsCountTextBox);
            this.statsGroupBox.Controls.Add(this.classAverageTextBox);
            this.statsGroupBox.Controls.Add(this.label5);
            this.statsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGroupBox.Location = new System.Drawing.Point(15, 596);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(718, 83);
            this.statsGroupBox.TabIndex = 2;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Students Count";
            // 
            // studentsCountTextBox
            // 
            this.studentsCountTextBox.Location = new System.Drawing.Point(365, 31);
            this.studentsCountTextBox.Name = "studentsCountTextBox";
            this.studentsCountTextBox.Size = new System.Drawing.Size(100, 26);
            this.studentsCountTextBox.TabIndex = 2;
            // 
            // classAverageTextBox
            // 
            this.classAverageTextBox.Location = new System.Drawing.Point(120, 31);
            this.classAverageTextBox.Name = "classAverageTextBox";
            this.classAverageTextBox.Size = new System.Drawing.Size(100, 26);
            this.classAverageTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class Average";
            // 
            // passRateLabel
            // 
            this.passRateLabel.AutoSize = true;
            this.passRateLabel.Location = new System.Drawing.Point(482, 31);
            this.passRateLabel.Name = "passRateLabel";
            this.passRateLabel.Size = new System.Drawing.Size(83, 20);
            this.passRateLabel.TabIndex = 5;
            this.passRateLabel.Text = "Pass Rate";
            // 
            // passRateTextBox
            // 
            this.passRateTextBox.Location = new System.Drawing.Point(571, 31);
            this.passRateTextBox.Name = "passRateTextBox";
            this.passRateTextBox.Size = new System.Drawing.Size(100, 26);
            this.passRateTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 708);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.dataGridGroupBox);
            this.Controls.Add(this.greadWeightsGroupBox);
            this.Name = "MainForm";
            this.Text = " ";
            this.greadWeightsGroupBox.ResumeLayout(false);
            this.greadWeightsFlowLayoutPanel.ResumeLayout(false);
            this.greadWeightsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendnceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalNumericUpDown)).EndInit();
            this.dataGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).EndInit();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox greadWeightsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel greadWeightsFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown attendnceNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown homeworkNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown midtermNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown finalNumericUpDown;
        private System.Windows.Forms.GroupBox dataGridGroupBox;
        private System.Windows.Forms.DataGridView studentGradesDataGridView;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentsCountTextBox;
        private System.Windows.Forms.TextBox classAverageTextBox;
        private System.Windows.Forms.Label passRateLabel;
        private System.Windows.Forms.TextBox passRateTextBox;
    }
}

