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

            createTextBox("Customer Name"); 
            createTextBox("Customer Number");
            createTextBox("Customer Email");

            foreach (string value in values)
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
            MyComboBox.Name = "txt" + score;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review saved successfully.", "Success");
        }
    }
}
