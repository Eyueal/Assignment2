using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_desktop1
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

        private void button1_Click(object sender, EventArgs e)
        {
            

           if (string.IsNullOrEmpty(txt_productn.Text))
            {
               // error1.SetError(txt_productn, "Name is required");
                //error1.SetError(txt_pid, "ID is required");
                //error1.SetError(txt_price, "Price is required");

                //MessageBox.Show("Name is Required");
            }
            else
            {
                
                error1.Clear();

                Product p = new Product
                {
                    Id = int.Parse(txt_pid.Text),
                    Productname = txt_productn.Text,
                    Price = double.Parse(txt_price.Text),
                    IsAvailable = Isav.Checked
                    
                };
                p.Save();
                MessageBox.Show($"Product '" + p.Productname + "' is added sucessfully");
                
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.GetAllProducts();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_pid.Text = "";

            //textBox3.Text = "";
            textBox4.Text = "";
            txt_price.Text = "";
            txt_productn.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var item2 = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            MessageBox.Show(item.Name);
            MessageBox.Show(item2.Name);

        }
    }
}
//Datatransfer, page to page and close the page. 