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
            int totalFields = 0;

            // Get data from reviews.csv
            string[] reviews = File.ReadAllLines(reviewPath);

            // X and Y values of chart
            List<string> xValues = new List<string>();
            List<double> yValues = new List<double>();

            // Saving field names for chart
            foreach (string head in field)
            {
                totalFields++; // Calculating total number of fields
                xValues.Add(head);
            }

            int totalReviews = reviews.Length;
            double[] totalScore = new double[totalFields];

            for (int j = 1; j < totalReviews; j++) // Looping through all reviews (rows)
            {
                string[] review = reviews[j].Split(',');
                int count = 0;

                for (int i = 3; i < review.Length; i++) // Looping through all fields (columns)
                {
                    totalScore[count] += Convert.ToDouble(review[i]); // Storing total score in each field
                    count++;
                }
            }
            
            // Calculating average score of each field
            foreach (double avg in totalScore)
            {
                yValues.Add(avg / (totalReviews-1));
            }

            // Plotting in graph
            reviewChart.Series["Average Score"].Points.DataBindXY(xValues, yValues);
        }   
    }
}
