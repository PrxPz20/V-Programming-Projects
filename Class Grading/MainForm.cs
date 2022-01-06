using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Class_Grading
{
    public partial class MainForm : Form {

        private List<StudentGrade> studentGrades = new List<StudentGrade>();
        private const double MinimumPassGrade = 60;


        
        public MainForm() { 
            InitializeComponent();

            studentGradesDataGridView.DataSource = new BindingList<StudentGrade>();
        }


        private void studentGradesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {

            UpdateGradeInfo();
        }

        private void gradeWeightNumericUpDown_ValueChanged(object sender, EventArgs e) {

            UpdateGradeInfo();
        }        

    
        private void UpdateGradeInfo() {

            var grades = studentGrades.Select(x => x.GetGrade((double)attendnceNumericUpDown.Value,
                                                              (double)homeworkNumericUpDown.Value,
                                                              (double)midtermNumericUpDown.Value,
                                                              (double)finalNumericUpDown.Value))
                                                              .ToList();

            classAverageTextBox.Text = grades.Average().ToString("N2");

            studentsCountTextBox.Text = grades.Count.ToString();

            var passRate = grades.Count(x => x >= MinimumPassGrade) / (double)grades.Count;
            passRateTextBox.Text = passRate.ToString("P2");


        }


    }
}

/*
 * ((student.Attendance * (double)attendnceNumericUpDown.Value) +
 (student.Homework * (double)homeworkNumericUpDown.Value) +
 (student.Midterm * (double)midtermNumericUpDown.Value)) / (double)(attendnceNumericUpDown.Value + homeworkNumericUpDown.Value
+ midtermNumericUpDown.Value)
 * 
 * 
 * */