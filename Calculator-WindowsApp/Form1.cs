using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       string c;
       public double x,y;
        //all buttons in one event
        private void button12_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
                textBox1.Text = textBox1.Text + B.Text;
            
        }
        //clear button
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        //send number to label
        private void button17_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            c = B.Text;
            x =Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();
        }
        //The four mathematical operations
        private void button13_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            switch (c)
            {
                case "+":
                    { 
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "-":
                    {
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "/":
                    {
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "*":
                    {
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;
            }
        }
    }
}
