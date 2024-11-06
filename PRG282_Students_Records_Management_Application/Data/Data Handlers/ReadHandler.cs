using Newtonsoft.Json;
using PRG282_Students_Records_Management_Application.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Students_Records_Management_Application.Data.Data_Handlers
{
    internal class ReadHandler
    {
        public ReadHandler() { }
        

        //students.txt
        public static List<Student> ReadStudentsFile() //if successful returns read initial hardcodedlist of students else returns empty list of students
        {
            
            try
            {
                string path = @"students.txt";

                string json = File.ReadAllText(path);
                // Deserialize JSON to List<Student> and return it.
                return JsonConvert.DeserializeObject<List<Student>>(json);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Student.ListOfStudents;
            }

        }

        //summary.txt

        public static SummaryReport ReadSummaryReportFile() //if successful returns read summary report else returns default summary report of hard coded students
        {
            
            try
            {
                string path = @"summary.txt";
                string json = File.ReadAllText(path);
                // Deserialize JSON to List<Student> and return it.
                return JsonConvert.DeserializeObject<SummaryReport>(json);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SummaryReport summaryReport = new SummaryReport();
                return summaryReport;
            }
        }
    }
}
