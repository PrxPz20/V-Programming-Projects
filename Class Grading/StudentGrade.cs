using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Grading {
    public class StudentGrade {

        public StudentGrade() { }

        public string Name { get; set; }
        public double Attendance { get; set; }
        public double Homework { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }

        public double GetGrade(double attendanceWeight, double homeworkWeight, double midtermWeight, double finalWeight) {

            double totalWeight = attendanceWeight + homeworkWeight + midtermWeight + finalWeight;

            double totalGrade = Attendance * attendanceWeight
                                + Homework * homeworkWeight
                                + Midterm * midtermWeight
                                + Final * finalWeight;

            return totalGrade / totalWeight;

        }

    }
}
