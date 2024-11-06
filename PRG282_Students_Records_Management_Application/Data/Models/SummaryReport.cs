using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Students_Records_Management_Application.Data.Models
{
    internal class SummaryReport
    {
        //public summary Report fields
        public int TotalNumberOfStudents { get; set; }
        public int AverageStudentAge { get; set; }

        //private Constructor with params that have default values
        private SummaryReport(int totalNumberOfStudents = 0, int averageStudentAge = 0)
        {
            TotalNumberOfStudents = totalNumberOfStudents;
            AverageStudentAge = averageStudentAge;
        }

        //Constructor with no params
        public SummaryReport() { }

        //Method to create and summary report, returns summary report if successful else it returns null;
        public static SummaryReport GetSummaryReport()
        {
            try
            {
                if(Student.ListOfStudents.Count <= 0)
                {
                    MessageBox.Show(" 0 students and 0 average age");
                    SummaryReport summaryReport = new SummaryReport();
                    return summaryReport;
                }
                else if ( Student.ListOfStudents.Count >= 1)
                {
                    int totalStudents = Student.ListOfStudents.Count;
                    int age = 0;
                    foreach(var student in Student.ListOfStudents)
                    {
                        age = age + student._StudentAge;
                    }

                    int averageAge = age / totalStudents;
                    SummaryReport summaryReport = new SummaryReport(totalStudents,averageAge);
                    MessageBox.Show($"{summaryReport.TotalNumberOfStudents} total students and {summaryReport.AverageStudentAge} average student age");
                    return summaryReport;
                }
                else
                {
                    MessageBox.Show("List of studentds has count issues");
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
