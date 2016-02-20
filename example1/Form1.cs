using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace example1
{
    public partial class Form1 : Form
    {
        public double a; 
        public bool set; //esli my zadali a число 
        public string op;
        public Form1()
        {
            InitializeComponent();
        }

        

        
        

        private void numbers_Events_Click(object sender, EventArgs e) //sender eto button 
        {
            Button btc_clicked = (Button)sender;
            if(btc_clicked.Text==".") 
            {
                if (!Result_View.Text.Contains("."))
                {
                    this.Result_View.Text += btc_clicked.Text;
                }
                return;
            }
            if (this.Result_View.Text == "0" || set)
            {

                set = false;
                this.Result_View.Text = btc_clicked.Text;
            }
            else
            {
                this.Result_View.Text += btc_clicked.Text;

            }
        }

        private void operation_click(object sender, EventArgs e)
        {

            if(a!=0) {
                this.calculate_Click(sender, e);
                    
                    }; //esli v a chislo lejit
            a = double.Parse(this.Result_View.Text);
            set = true;
           
            op = ((Button)sender).Text;

        }
        public double save;
        private void calculate_Click(object sender, EventArgs e)
        {
            if(save!=0)
            {
                double scalc = 0;
                if (op == "+")
                {
                    scalc = save + double.Parse(this.Result_View.Text);

                }
                else if (op == "-")
                {
                    scalc =  double.Parse(this.Result_View.Text)-save;


                }

                
                this.Result_View.Text = scalc.ToString();
                set = true; // ctob predyduwii text udalilsya
                a = 0; //ctob is a udalit to chislo
                return; 

            }
            double calc = 0;
            if (op == "+")
            {
               calc = a + double.Parse(this.Result_View.Text);
                
            }
            else if(op=="-") {
                 calc = a - double.Parse(this.Result_View.Text);
                

            }

            save = double.Parse(this.Result_View.Text);
            this.Result_View.Text = calc.ToString();
            set = true; // ctob predyduwii text udalilsya
            a = 0; //ctob is a udalit to chislo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            save = 0;
            set = false;
            op = "";
            this.Result_View.Text = "0";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double curr = double.Parse(this.Result_View.Text);
            curr *= -1;
            this.Result_View.Text = curr.ToString();

        }
    }
}
