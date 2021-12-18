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
using Newtonsoft.Json;

namespace Class_Grading
{
    public partial class MainForm : Form {

        public List<StudentClass> studentClasses = new List<StudentClass>();
        const string STUDENT_DATA_FILE = "StudentDataFile.json";

        public MainForm() { 
            InitializeComponent();

            saveStudentsData();
            LoadStudentsData();
            studentInfoDataGridView.Columns[4].ReadOnly = true; // the user can not edit Final the Column
        }


        public void saveStudentsData() {

            var sirializeStudent = JsonConvert.SerializeObject(studentClasses);
            File.WriteAllText(STUDENT_DATA_FILE, sirializeStudent);

        }

        public void LoadStudentsData() {

            var studentContain = File.ReadAllText(STUDENT_DATA_FILE);
            studentClasses = JsonConvert.DeserializeObject<List<StudentClass>>(studentContain);

            studentInfoDataGridView.DataSource = new BindingList<StudentClass>(studentClasses);
        }

        private void studentInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {

            // [ (88 x 1) + (90 x 2) + (85 x 3) + (84 x 6) ] / (1 + 2 + 3 + 6) = 85.58
            StudentClass student = new StudentClass();

            student.Final = ( (student.Attendance * (double)attendnceNumericUpDown.Value) + 
                              (student.Homework * (double)homeworkNumericUpDown.Value) + 
                              (student.Midterm * (double)midtermNumericUpDown.Value) )  / (double)(attendnceNumericUpDown.Value + homeworkNumericUpDown.Value 
                             + midtermNumericUpDown.Value);

           
        }

    }
}
