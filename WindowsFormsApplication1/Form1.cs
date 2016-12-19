using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

/* Author: Scott Robinson
 * December 2016
 * XML Final Project
 * The purpose of this application is to show the use of XML in an application other than an ASP.Net website. 
 * It is a simple User Interface that lets the user select a team and see relevant info about that team.
 * */

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("TeamData.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string league = node["League"].InnerText;
                string name = node.Attributes[0].Value;
                string manager = node["Manager"].InnerText;
                string captain = node["Captain"].InnerText;
                string position = node["Position"].InnerText;
                int titles = int.Parse(node["Titles"].InnerText);
                listBox1.Items.Add(new Team(name, league, titles, manager, captain, position));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
