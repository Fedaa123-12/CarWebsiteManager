using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;


namespace WindowsFormsApp1
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



        private void button3_Click(object sender, EventArgs e)
        {
           
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows.Count;
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected "+ i + " rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    for (i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        // Get the index of the selected row
                        int selectedIndex = dataGridView1.SelectedRows[i].Index;

                        
                        string nameToDelete = dataGridView1.Rows[selectedIndex].Cells["name"].Value.ToString();
                        MessageBox.Show($"Deleting car with Name: {nameToDelete}");

                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.RemoveAt(selectedIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        

        }


        private void CREATE_Click(object sender, EventArgs e)
        {
            Create creat = new Create();
            creat.Show();
        }

        private void READ_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            Update update = new Update();   
            update.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            Delete delete= new Delete();    
            delete.Show();
        }
    }
}
