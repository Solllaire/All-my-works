using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((textBox1.Text.IndexOf(",") > -1 && b.Text == ",") | (textBox1.Text == "0" && b.Text!=",") | (b.Text == ","&& textBox1.Text==""))
            {
                return;
            }
            else
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch
            {
                return;
            }
        }
        String action, number1;


        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Button b = (Button)sender;
                if (b.Text == "/" | b.Text == "*") return;
                else
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + b.Text;
            }
            else
            {
                Button b = (Button)sender;
                if (textBox1.Text == "+" | textBox1.Text == "-") { return; }
                action = b.Text;
                number1 = textBox1.Text;
                textBox1.Text = "";
            }
            textBox2.Text = number1+" "+action;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (action == "+")
                    textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
                if (action == "-")
                    textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
                if (action == "*")
                    textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
                if (action == "/")
                    textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
                action = "";
                textBox2.Text = "";


            }
            catch { textBox2.Text = ""; return;}
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }



    }
}
