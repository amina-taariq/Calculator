using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operation = " ";
        bool clear_value = false;
        bool formed = false;
        double memoryRecall = 0;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void btn_click(object sender, EventArgs e)
        {
            if((textBox2.Text == "0")||(clear_value) ||(formed))
            {
                textBox2.Clear();
                textBox1.Clear();
         
                clear_value= false;
                formed= false;
            } else if ((textBox2.Text == "0") || (clear_value) || (formed))
            {
                textBox2.Clear();
                clear_value = false;
                formed = false;
            }

                Button button= (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            textBox2.Text = textBox2.Text + button.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultValue = double.Parse(textBox2.Text);
             if((textBox2.Text != "0") && (formed))
            {
                textBox1.Text=textBox2.Text+ button.Text;

            }  else if (textBox2.Text !="0")
            {
                textBox1.Text = textBox1.Text + button.Text;

                textBox2.Text = "";
            }
            
             formed= false;
        }

        private void equal_to(object sender, EventArgs e)
        {
            formed = true;
            textBox1.Text = textBox1.Text + "=";
            switch(operation)
            {
                case "+":
                    textBox2.Text = (resultValue + double.Parse(textBox2.Text)).ToString();
                    resultValue =double.Parse(textBox2.Text);
                    memoryRecall=double.Parse(textBox2.Text);   

                    break;
                case "-":
                    textBox2.Text = (resultValue - double.Parse(textBox2.Text)).ToString();
                    resultValue = double.Parse(textBox2.Text);
                    memoryRecall = double.Parse(textBox2.Text);
                    break;
                case "*":
                    textBox2.Text = (resultValue * double.Parse(textBox2.Text)).ToString();
                    resultValue = double.Parse(textBox2.Text);
                    memoryRecall = double.Parse(textBox2.Text);
                    break;
                case "/":
                    textBox2.Text = (resultValue / double.Parse(textBox2.Text)).ToString();
                    resultValue = double.Parse(textBox2.Text);
                    memoryRecall = double.Parse(textBox2.Text);
                    break;
                default:
                    break;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = resultValue.ToString();
            clear_value = true;
        }

        private void MemoryRecall(object sender, EventArgs e)
        {
            textBox2.Text=(memoryRecall).ToString();
            textBox1.Text+=textBox2.Text;
        }

        private void OnOff(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
