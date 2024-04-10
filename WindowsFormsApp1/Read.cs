using Newtonsoft.Json.Linq;
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

namespace WindowsFormsApp1
{
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // or DataGridViewAutoSizeColumnMode.Fill
            }
        }



        private async void Read_Load(object sender, EventArgs e)
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
                            double Mileage = (double)item["Mileage"];
                            string MotExp = (string)item["MotExp"];
                            string Reg = (string)item["Reg"];
                            string KeyNo = (string)item["KeyNo"];
                            string CatStat = (string)item["CatStat"];
                            string Colour = (string)item["Colour"];
                            string Value = (string)item["Value"];
                            string FuelType = (string)item["FuelType"];
                            string ExtraFeatures = (string)item["ExtraFeatures"];
                            string Image = (string)item["Image"];

                            dataGridView1.Rows.Add(name, model, Mileage, MotExp, Reg, KeyNo, CatStat, Colour, Value, FuelType, ExtraFeatures, Image);
                            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
