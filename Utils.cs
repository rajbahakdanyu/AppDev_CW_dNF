using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_CW_dNF
{
    public class Utils
    {
        // Get full path of reviews.csv
        public string getReviewsPath()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string reviewPath = projectDirectory + @"\AppDev_CW_dNF\reviews.csv"; // Get the full file path

            return reviewPath;
        }

        // Get full path gields.txt
        public string getFieldsPath()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string fieldsPath = projectDirectory + @"\AppDev_CW_dNF\fields.txt"; // Get the full file path

            return fieldsPath;
        }

        // Bubble sort 
        public string[] sorting(string[] values)
        {
            int l = values.Length;
            string temp;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (values[j].CompareTo(values[j + 1]) > 0)
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }

            return values;
        }
    }
}
