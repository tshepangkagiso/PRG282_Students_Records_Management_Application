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
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Set to regular text color
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black; // Set to regular text color
            }
        }

        private void SetPlaceholder1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //write data from files as soon as app loads.
            /**WriteHandler.WriteStudentsFile();
            WriteHandler.WriteSummaryReportFile();

            //Get the data from files as soon as app loads.
            Student.ListOfStudents = ReadHandler.ReadStudentsFile();
            SummaryReport summaryReport = ReadHandler.ReadSummaryReportFile();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Student.ListOfStudents;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = summaryReport;

            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;**/

            this.Text= "Student Records Management Application";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

           
            pictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            Panel bottomBorder = new Panel();
           
           
            // Add Panel to the form
            this.Controls.Add(bottomBorder);
            textBox1.Text = "Username"; // Set initial placeholder text
            textBox1.ForeColor = Color.Gray;
            textBox1.Enter += RemovePlaceholder;
            textBox1.Leave += SetPlaceholder;

            textBox2.Text = "Password"; // Set initial placeholder text
            textBox2.ForeColor = Color.Gray;
            textBox2.Enter += RemovePlaceholder1;
            textBox2.Leave += SetPlaceholder1;



        }

    }
}
