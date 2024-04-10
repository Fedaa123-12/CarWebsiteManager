using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        private async void Delete_Load(object sender, EventArgs e)
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
                            int id = (int)item["ID"];
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

                            dataGridView1.Rows.Add(id,name, model, Mileage, MotExp, Reg, KeyNo, CatStat, Colour, Value, FuelType, ExtraFeatures, Image);

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

        private async  void  delBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows.Count;
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected " + i + " rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    for (i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        // Get the index of the selected row
                        int selectedIndex = dataGridView1.SelectedRows[i].Index;


                      
                        int idToDelete = int.Parse(dataGridView1.Rows[selectedIndex].Cells["id"].Value.ToString());

                        

                        await deleteCar(idToDelete, selectedIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private async Task deleteCar(int id, int selectedIndex)
        {
            string url = "https://car-website-2.onrender.com/deleteById?id=";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(url+id);
                MessageBox.Show("loading...This might take a while");

                // Check if the response was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response content: " + responseContent);
                    MessageBox.Show($"Deleting car with ID: {id}");
                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Successfully Delete selected row/s");
                    
                }
                else
                {
                    MessageBox.Show("Server Problem, retry again");
                    Console.WriteLine("Error: " + response.StatusCode);
                }

             
            }
        }


    }
}
