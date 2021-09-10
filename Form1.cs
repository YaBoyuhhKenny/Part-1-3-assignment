using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_assignment
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            double height;

            name = txtName.Text;
            age = (int)ageUpDown.Value;
            height = Convert.ToDouble(txtHeight.Text);

            greetingMessage.Text = "Hello " + name + " you are " + (2.72 - height) + "m shorter than the tallest person and " + (82 - age) + " years below the average life expectancy.";
        }

     
    }
}
