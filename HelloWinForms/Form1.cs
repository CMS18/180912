using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        private static readonly Random randomGenerator = new Random();

        private Button myButton;

        private int sum;
        private int count;

        public Form1()
        {
            InitializeComponent();

            myButton = new Button();
            myButton.Text = "Klicka på mig!";
            myButton.Click += MyButton_Click;

            //myButton.Parent = this;
            //this.Controls.Add(myButton);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("HEJ! Du klickade på knappen.");

            myButton.Left = randomGenerator.Next(0, this.Width - myButton.Width);
            myButton.Top = randomGenerator.Next(0, this.Height - myButton.Height);


        }

        private void AddAgeButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(AgeTextBox.Text);

            sum = sum + age;
            count = count + 1;

            double avarage = (double)sum / count;

            AvarageAgeLabel.Text = $"Medelvärde: {avarage:0.00}";

            AgeListBox.Items.Add(age);

            AgeTextBox.Clear();
            AgeTextBox.Focus();


        }
    }
}
