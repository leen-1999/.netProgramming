using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        List<Employee> employees = new List<Employee>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(txtId.Text);
            customer.FirstName = textName.Text;
            customer.LastName = textLastName.Text;
            customer.Address = textAddress.Text;

            customers.Add(customer);
            clearTxtBox();

        }
        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(txtId.Text);
            employee.FirstName = textName.Text;
            employee.LastName = textLastName.Text;
            employee.Address = textAddress.Text;
            employees.Add(employee);
            clearTxtBox();
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Employee employee in employees)
                listBox1.Items.Add(employee.FirstName + " " + employee.LastName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in customers)
                listBox1.Items.Add(x.FirstName + " " + x.LastName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
       

            string text = listBox1.GetItemText(listBox1.SelectedItem);



            for (int i = 0; i < customers.Count; i++)

                if (customers[i].FirstName + " " + customers[i].LastName == text)

                    customers.Remove(customers[i]);



            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string text = listBox1.GetItemText(listBox1.SelectedItem);



            for (int i = 0; i < employees.Count; i++)

                if (employees[i].FirstName + " " + employees[i].LastName == text)

                    employees.Remove(employees[i]);



            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (IPerson x in customers)
                comboBox1.Items.Add(x.Id);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            listBox1.Items.Clear();

            int y = Int32.Parse(comboBox1.Text);

            foreach (IPerson x in customers)

                if (x.Id == y)

                {

                    listBox1.Items.Add(x.FirstName + " " + x.LastName);

                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //foreach (Employee employee in employees)
            //    comboBox2.Items.Add(employee.Id); 
                
        }
        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (IPerson x in employees)
                comboBox2.Items.Add(x.Id);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int y = Int32.Parse(comboBox2.Text);

            foreach (IPerson x in employees)

                if (x.Id == y)

                {

                    listBox1.Items.Add(x.FirstName + " " + x.LastName);

                }
        }
    }
}
