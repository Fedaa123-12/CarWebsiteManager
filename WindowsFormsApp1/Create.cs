using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }






        private async void Submit_Click(object sender, EventArgs e)
        {
            await newCar();
        }



        public class TextBoxChecker
        {
            public static bool checkEmpty(params System.Windows.Forms.TextBox[] textBoxes)
            {
                foreach (System.Windows.Forms.TextBox textBox in textBoxes)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true;
                    }
                }
                return false;
            }
        }




        private async Task newCar()
        {
            if (TextBoxChecker.checkEmpty(CName, Model, Mileage, MotExp, Reg, KeyNo, CatStat, Colour, Value, FuelType, ExtraFeatures, Image))
            {
                MessageBox.Show("One or more text boxes are empty.");
            }
            else if ( !(checkDig(Mileage.Text)) || !(checkDig(Value.Text)) )
            {
                MessageBox.Show("Ensure mileage and value fields are numbers");
            }
            else
            {
                String name = CName.Text;
                String model = Model.Text;
                double mileage = double.Parse(Mileage.Text);
                String motexp = MotExp.Text;
                String reg = Reg.Text;
                String keyNo = KeyNo.Text;
                String colour = Colour.Text;
                String catstat = CatStat.Text;
                double value = double.Parse(Value.Text);
                String fuelType = FuelType.Text;
                //DateTime d = DateTime.Parse("12");
                String extraFeatures = ExtraFeatures.Text;
                String image = Image.Text;


                DialogResult result = MessageBox.Show("Are you sure you want to insert the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string url = "https://car-website-2.onrender.com/newCar";
                    // JSON data representing the car details
                    string jsonData = $@"{{
                        ""Name"": ""{name}"",
                        ""Model"": ""{model}"",
                        ""Mileage"": ""{mileage}"",
                        ""MotExp"": ""{motexp}"",
                        ""Reg"": ""{reg}"",
                        ""KeyNo"": ""{keyNo}"",
                        ""CatStat"": ""{catstat}"",
                        ""Colour"": ""{colour}"",
                        ""Value"": ""{value}"",
                        ""FuelType"": ""{fuelType}"",
                        ""ExtraFeatures"": ""{extraFeatures}"",
                        ""image"": ""{image}""
                    }}";

                    // Create StringContent with JSON data
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Create an instance of HttpClient
                    using (HttpClient client = new HttpClient())
                    {
                        // Send the POST request
                        
                        HttpResponseMessage response = await client.PostAsync(url, content);
                        MessageBox.Show("loading...This might take a while");

                        // Check if the response was successful
                        if (response.IsSuccessStatusCode)
                        {
                            // Read the response content
                            string responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Response content: " + responseContent);
                            MessageBox.Show("Successfully Inserted a new car");
                        }
                        else
                        {
                            Console.WriteLine("Error: " + response.StatusCode);
                        }
                    }
                    clearAllTxtBoxes();
                }
     
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] parts = dateTimePicker1.Value.ToString().Split(' ');
            MessageBox.Show(parts[0]);
        }


        private Boolean checkDig(String no)
        {
            Double noToDo;
            if (double.TryParse(Mileage.Text, out noToDo))
            {
                //noToDo = Double.Parse(no);
                return true;
            }

            return false;
        }

        private void clearAllTxtBoxes()
        {

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.TextBox)
                        (control as System.Windows.Forms.TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);

        }

    }
}
