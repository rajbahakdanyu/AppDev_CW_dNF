using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_CW_dNF
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
            loadDataChart();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataChart()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string filePath = projectDirectory + @"\AppDev_CW_dNF\"; // Get the full file path

            // Get path of both files
            string reviewPath = filePath + "reviews.csv";
            string fieldPath = filePath + "fields.txt";

            // Get data from fields.txt
            string fields = File.ReadAllText(fieldPath);
            string[] field = fields.Split(',');

            // Get data from reviews.csv
            string[] reviews = File.ReadAllLines(reviewPath);
            string[] review = new string[reviews.Length];

            // X and Y values of chart
            List<string> xValues = new List<string>();
            List<double> yValues = new List<double>();

            

            reviewChart.Series["Average Score"].Points.DataBindXY(xValues, yValues);

            reviewChart.Titles.Add("Review Score Average Chart");
        }   
    }
}
