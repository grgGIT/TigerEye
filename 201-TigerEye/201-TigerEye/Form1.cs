using RoomGlobals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace HomePage
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

        //gyms
        private void button1_Click(object sender, EventArgs e)
        {
            Gym.Form1 gymForm = new Gym.Form1();
            gymForm.Show();
        }

        //dining
        private void button2_Click(object sender, EventArgs e)
        {
            Dining.Form1 diningForm = new Dining.Form1();
            diningForm.Show();
        }

        //academic planning
        private void button5_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to open the external website?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Replace "https://www.example.com" with the URL of the external website
                string externalUrl = "https://people.rit.edu/grg7576/TigerEye--201%20Project/acadPlan/acadplan.html";

                // Open the default web browser with the external website
                Process.Start(externalUrl);
            }


        }

        //PawPrints
        private void button4_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to open the external website?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Replace "https://www.example.com" with the URL of the external website
                string externalUrl = "https://pawprints.rit.edu/";

                // Open the default web browser with the external website
                Process.Start(externalUrl);
            }
        }

        //Reporter Stories
        private void button7_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to open the external website?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Replace "https://www.example.com" with the URL of the external website
                string externalUrl = "https://reporter.rit.edu/";

                // Open the default web browser with the external website
                Process.Start(externalUrl);
            }
        }

        //study spaces
        private void button3_Click(object sender, EventArgs e)
        {
            Rooms.RoomForm roomForm = new Rooms.RoomForm();
            roomForm.Show();
        }

        //creating a notice to help direct people to the map form
        private void ShowPopupNotice(string message)
        {
            MessageBox.Show(message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        //bus maps
        private void button6_Click(object sender, EventArgs e)
        {
            ShowPopupNotice("Please follow to the RoomForms page and then click the maps button in the top right corner to see that page. Click OK to continue.");

            // trying to display the MapForm()
            Assembly roomsAssembly = Assembly.LoadFrom("C:\\Users\\ggrac\\OneDrive\\Desktop\\Rooms_3\\Rooms\\bin\\Debug\\RoomGlobals.dll");

            Type mapFormType = roomsAssembly.GetType("RoomGlobals.MapForm");

            if (mapFormType != null)
            {
                Form mapForm = (Form)Activator.CreateInstance(mapFormType);
                mapForm.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
