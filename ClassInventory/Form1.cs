using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            string name = c.Text;
            string team = teamInput.Text;
            string position = positionInput.Text;
            int age = Convert.ToInt16(ageInput.Text);

            // TODO - create object with gathered information
            Player p = new Player(name, age, team, position);

            // TODO - add object to global list
            players.Add(p);

            // TODO - display message to indicate addition made
            output.Text = "Successful Addition!";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO - if object is in list remove it
            for(int x = 0; x < players.Count; x++)
            {
                if (removeInput.Text == players[x].name)
                {
                    players.Remove(players[x]);
                }
            }
            // TODO - display message to indicate deletion made
            output.Text = "Removed Successfully!";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            Boolean found = false;
            int location = -1;

            for(int x = 0; x < players.Count; x++)
            {
                if (searchInput.Text == players[x].name)
                {
                    found = true;
                    location = x;
                }
            }
            
            if (found)
            {
                output.Text = players[location].name + " | " + players[location].age + " | +" + players[location].team + " | " + players[location].position;
            } else
            {
                output.Text = "Player Not Found!";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
            output.Text = "";
            for(int x = 0; x < players.Count; x++)
            {
                output.Text = output.Text + players[x].name + " | " + players[x].age + " | " + players[x].team + " | " + players[x].position + "\n";
            }
        }
    }
}
