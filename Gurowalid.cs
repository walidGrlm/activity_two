using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            //Checkbox1 = Saudi
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }
            //Checkbox2 = korea 
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " "; 
            }
              //Checkbox3 = dubai 
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";

            }
              //Checkbox4 = thailand 
            if (checkBox3.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            } 

            if (str != null) { 
                MessageBox.Show("You Selected : \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void othersbox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersbox.Checked)
            { 
                label3.Visible = true; 
                textBox1.Visible = true; 
            } 
            else { 
                label3.Visible = false;
                textBox1.Visible = false; }

            
           

        }
  }
}
