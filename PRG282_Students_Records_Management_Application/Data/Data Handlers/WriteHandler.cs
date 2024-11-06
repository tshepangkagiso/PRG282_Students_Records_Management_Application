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
    internal class WriteHandler
    {
        public WriteHandler() { }

        //students.txt
        public static void WriteStudentsFile()  // Saves the current state of list of students thats in programs runtime memory
        {
            
            try
            {
                // Serialize the list of students to JSON
                string path = @"students.txt";
                string json = JsonConvert.SerializeObject(Student.ListOfStudents, Formatting.Indented);

                File.WriteAllText(path,json);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //summary.txt
        public static void WriteSummaryReportFile()  // Saves the current state of the object of summary report thats in programs runtime memory
        {

            try
            {
                SummaryReport summaryReport = new SummaryReport();
                summaryReport = SummaryReport.GetSummaryReport();

                if(summaryReport != null)
                {
                    // Serialize the summary report object to JSON
                    string path = @"summary.txt";
                    string json = JsonConvert.SerializeObject(summaryReport, Formatting.Indented);

                    File.WriteAllText(path, json);
                }
                else
                {
                    MessageBox.Show("Summary report object returned a null");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
