using PRG282_Students_Records_Management_Application.Data.Data_Handlers;
using PRG282_Students_Records_Management_Application.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Students_Records_Management_Application
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //write data from files as soon as app loads.
            WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();

            //Get the data from files as soon as app loads.
            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
        }

    }
}
