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
    public partial class Review_Form : Form
    {
        int textBox = 1;
        int score = 1;
        List<TextBox> textBoxList = new List<TextBox>();
        List<ComboBox> comboBoxList = new List<ComboBox>();

        public Review_Form()
        {
            InitializeComponent();
            loadForm();
        }

        private void loadForm()
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string filePath = projectDirectory + @"\AppDev_CW_dNF\fields.txt"; // Get the full file path

            string line = File.ReadAllText(filePath); // Read all data from file into a single string            
            string[] values = line.Split(','); // Split data

            // Dynamiclly creating textBoxes
            createTextBox("Customer Name"); 
            createTextBox("Customer Number");
            createTextBox("Customer Email");

            string[] items = sorting(values);

            // Dynamiclly creating comboBoxes
            foreach (string value in items)
            {
                createReviewField(value);
            }

        }

        private void createTextBox(string title)
        {
            // Creating Label 
            Label Mylabel = new Label();
            Mylabel.Text = title;
            Mylabel.ForeColor = Color.White;
            Mylabel.Top = textBox * 40;
            Mylabel.Left = 20;
            panelForm.Controls.Add(Mylabel);

            // Creating TextBox
            TextBox Mytextbox = new TextBox();
            Mytextbox.Name = "txt" + textBox;
            Mytextbox.Top = textBox * 40;
            Mytextbox.Left = 120;
            Mytextbox.Width = 180;
            panelForm.Controls.Add(Mytextbox);

            textBox++;
            textBoxList.Add(Mytextbox); // Saving textBox references
        }

        private void createReviewField(string title)
        {
            // Creating Label 
            Label Mylabel = new Label();
            Mylabel.Text = title;
            Mylabel.ForeColor = Color.White;
            Mylabel.Top = textBox * 40;
            Mylabel.Left = 20;
            panelForm.Controls.Add(Mylabel);

            // Creating ComboBox
            ComboBox MyComboBox = new ComboBox();
            MyComboBox.Name = "combo" + score;
            MyComboBox.Top = textBox * 40;
            MyComboBox.Left = 120;
            MyComboBox.Width = 180;
            MyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MyComboBox.Items.Add("1");
            MyComboBox.Items.Add("2");
            MyComboBox.Items.Add("3");
            MyComboBox.Items.Add("4");
            MyComboBox.Items.Add("5");
            panelForm.Controls.Add(MyComboBox);

            textBox++; 
            score++;
            comboBoxList.Add(MyComboBox); // Saving comboBox references
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory; // Get the current WORKING directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; // Get the current PROJECT directory
            string reviewPath = projectDirectory + @"\AppDev_CW_dNF\reviews.csv"; // Get the full file path

            List<string> data = new List<string>();
            bool err = false;

            // Getting data from textBox
            foreach (TextBox textBox in textBoxList)
            {
                data.Add(textBox.Text);
            }

            // Getting data from comboBox
            foreach (ComboBox comboBox in comboBoxList)
            {
                if (comboBox.Text.Equals(""))
                {
                    err = true;
                }
                data.Add(comboBox.Text);
            }

            if (err)
            {
                MessageBox.Show("Please score all criteria", "Error");
            } else
            {
                // Writing to reviews.csv
                using (StreamWriter w = File.AppendText(reviewPath))
                {
                    w.Write("\n");
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (i != data.Count - 1)
                        {
                            w.Write(data[i] + ",");
                        }
                        else
                        {
                            w.Write(data[i]);
                        }
                    }
                }
                MessageBox.Show("Review Added successfully.", "Success");
                clearForm();
            }

        }

        private void clearForm()
        {
            foreach (TextBox textBox in textBoxList)
            {
                textBox.Text = String.Empty;
            }

            foreach (ComboBox comboBox in comboBoxList)
            {
                comboBox.SelectedIndex = -1;
            }
        }

        // Bubble sort 
        private string[] sorting(string[] values)
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
