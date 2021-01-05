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

namespace AppDev_CW_dNF
{
    public partial class See_Reviews : Form
    {
        Utils util = new Utils();

        public See_Reviews()
        {
            InitializeComponent();
            loadData();
        }

        // Initializing data into dataGridView
        private void loadData()
        {
            string reviewPath = util.getReviewsPath(); // Get the full file path

            string[] lines = File.ReadAllLines(reviewPath); // Getting data from reviews.csv

            int totalCol = (lines[0].Split(',')).Length; // Getting total number of columns

            bool head = true;

            // Writing data into dataGridView
            foreach (string value in lines)
            {
                string[] values = value.Split(',');

                // Checking if row is column header or not
                if (head)
                {
                    viewAll.ColumnCount = totalCol; // Setting total number of columns

                    // Writing column headers
                    for (int i = 0; i < totalCol; i++)
                    {
                        viewAll.Columns[i].Name = values[i];
                    }

                    head = false;
                } else
                {
                    viewAll.Rows.Add(values); // Populating rows
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            // Opening dialog box for file import
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Getting path of documents folder
                openFileDialog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            string reviewPath = util.getReviewsPath(); // Get the full file path

            string[] reviews = File.ReadAllLines(reviewPath);
            string[] reviewField = reviews[0].Split(',');

            string[] lines = fileContent.Split('\n');
            string[] importField = lines[0].Split(',');

            bool match = true;

            // Check if review criterias match
            foreach (string head in importField)
            {
                if (!reviewField.Contains(head))
                {
                    match = false;
                }
            }

            // Check if total number review criterias match
            if (reviewField.Length != importField.Length)
            {
                match = false;
            }

            if (match)
            {
                // Write to reviews.csv
                using (StreamWriter w = File.AppendText(reviewPath))
                {
                    for (int j = 1; j < lines.Length; j++)
                    {
                        string[] line = lines[j].Split(',');

                        w.Write("\n");
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (i != line.Length - 1)
                            {
                                w.Write(line[i] + ",");
                            }
                            else
                            {
                                w.Write(line[i]);
                            }
                        }
                    }                   
                }

                MessageBox.Show("Reviews imported successfully.", "Success");
                viewAll.Rows.Clear(); // Clears dataGridView
                loadData(); // Updates dataGridView
            } else
            {
                MessageBox.Show("Review criterias does not match.", "Error");
            }
        }
    }
}
