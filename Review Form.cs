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
        Utils util = new Utils();

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
            string filePath = util.getFieldsPath(); 

            string line = File.ReadAllText(filePath); // Read all data from file into a single string            
            string[] values = line.Split(','); // Split data

            // Dynamiclly creating textBoxes
            createTextBox("Customer Name"); 
            createTextBox("Customer Number");
            createTextBox("Customer Email");

            string[] items = util.sorting(values);

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
            MyComboBox.Items.Add("Horrible");
            MyComboBox.Items.Add("Bad");
            MyComboBox.Items.Add("Alright");
            MyComboBox.Items.Add("Good");
            MyComboBox.Items.Add("Excellent");
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
            string reviewPath = util.getReviewsPath(); 

            List<string> data = new List<string>();
            bool err = false;

            string score = "";
            string point = "";

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
                score = comboBox.Text;
                if (score.Equals("Excellent")) {
                    point = "5";
                } else if (score.Equals("Good"))
                {
                    point = "4";
                } else if (score.Equals("Alright"))
                {
                    point = "3";
                } else if (score.Equals("Bad"))
                {
                    point = "2";
                } else if (score.Equals("Horrible"))
                {
                    point = "1";
                }
                data.Add(point);
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
    }
}
