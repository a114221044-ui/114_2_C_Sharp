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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;

                using (inputFile = File.OpenText("Grades.csv"))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        double average = (double.Parse(fields[1]) + double.Parse(fields[2]) + double.Parse(fields[3])) / 3;
                        averagesListBox.Items.Add(fields[0] + ": " + average.ToString("F2"));
                    }
                }

            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
