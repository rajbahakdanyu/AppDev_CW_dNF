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
using System.Globalization;

namespace AppDev_CW_dNF
{
    public partial class Edit_Form : Form
    {
        public Edit_Form()
        {
            InitializeComponent();
            loadData();
        }

        // Go back to the landing panel
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Initializing data into dataGridView
        private void  loadData()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string filePath = projectDirectory + @"\AppDev_CW_dNF\fields.txt"; // Get the full file path

            string line = File.ReadAllText(filePath); // Read all data from file into a single string            
            string[] values = line.Split(','); // Split data

            // Displaying each field name in dataGridView
            foreach (var value in values)
            {
                reviewFields.Rows.Add(new object[] { value });
            }
        }

        // Remove selected row from dataGridView
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = reviewFields.CurrentCell.RowIndex; // Get index of selected row
            reviewFields.Rows.RemoveAt(id); // Delete selected row
        }

        // Add new field name into dataGridView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newField = txtAdd.Text; // Get new field name

            if (newField.Length == 0) // Check if field name is empty
            {
                MessageBox.Show("Please enter field name.", "Empty field name");
            } else
            {
                if (!checkExists(newField))
                {
                    reviewFields.Rows.Add(newField);
                } else
                {
                    MessageBox.Show("The field name you have entered already exists.", "Duplicate field name");
                }                
            }
        }

        // Check if field name already exists in dataGridView
        private bool checkExists(string fieldName)
        {
            foreach (DataGridViewRow row in reviewFields.Rows) // loop through all rows of dataGridView
            {
                string current = row.Cells[0].Value.ToString().ToLower(); // Get value of current cell of row

                if (fieldName.ToLower() == current)
                {
                    return true;
                }
            }
            return false;
        }

        // Save changes to file
        private void btnSave_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string filePath = projectDirectory + @"\AppDev_CW_dNF\fields.txt"; // Get the full file path

            string current;
            string field;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture.
            StreamWriter writer = new StreamWriter(filePath);

            int numRows = reviewFields.Rows.Count; // Get total number of rows in dataGridView
            int count = 0;

            foreach (DataGridViewRow row in reviewFields.Rows) // loop through all rows of dataGridView
            {
                current = row.Cells[0].Value.ToString().ToLower(); // Get value of current cell of row
                field = textInfo.ToTitleCase(current);

                if (count < numRows-1) // Check if it is the last field
                {
                    field = field + ",";
                }
                writer.Write(field); // Write to file               
                count += 1;
            }
            writer.Close();
           
            MessageBox.Show("Changes saved successfully.", "Success");
        }
    }
}
