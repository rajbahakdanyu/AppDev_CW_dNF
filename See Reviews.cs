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
        public See_Reviews()
        {
            InitializeComponent();
            loadData();
        }

        // Initializing data into dataGridView
        private void loadData()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string reviewPath = projectDirectory + @"\AppDev_CW_dNF\reviews.csv"; // Get the full file path

            string[] lines = File.ReadAllLines(reviewPath);

            int totalRecord = lines.Length;
            int totalCol = (lines[0].Split(',')).Length;

            bool head = true;

            foreach (string value in lines)
            {
                string[] values = value.Split(',');
                if (head)
                {
                    viewAll.ColumnCount = totalCol;
                    for (int i = 0; i < totalCol; i++)
                    {
                        viewAll.Columns[i].Name = values[i];
                    }
                    head = false;
                } else
                {
                    viewAll.Rows.Add(values);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
