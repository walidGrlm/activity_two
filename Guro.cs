using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Wishlist.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Seliction_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wishlist.Sorted = true; 
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Add("Rojo");
            Wishlist.Items.Add("House");
            Wishlist.Items.Add("Full Money ");
            Wishlist.Items.Add("iPhone Pro Max 14 ");
            Wishlist.Items.Add("Car");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Clear();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Wishlist.Items.Count);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
