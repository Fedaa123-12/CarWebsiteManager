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



        private async void button1_Click(object sender, EventArgs e)
        {
            
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "https://car-website-2.onrender.com";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //dynamic stuff = JObject.Parse(responseBody);
                        JArray jsonArray = JArray.Parse(responseBody);


                        foreach (JObject item in jsonArray.Cast<JObject>())
                        {
                            // Access values by key
                            string name = (string)item["Name"];
                            string model = (string)item["Model"];


                            dataGridView1.Rows.Add(name, model);

                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("eweew");

            Console.WriteLine("Console window created!"); // Test output
            /*string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=sql8.freesqldatabase.com;database=sql8695053;uid=sql8695053;pwd=\"CiE24Lf8kJ\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create creat = new Create();
            creat.Show();
        }

      
    }
}
