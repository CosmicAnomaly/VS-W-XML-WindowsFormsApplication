using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Author: Scott Robinson
 * December 2016
 * XML Final Project
 * The purpose of this application is to show the use of XML in an application other than an ASP.Net website. 
 * It is a simple User Interface that lets the user select a team and see relevant info about that team.
 * */
namespace WindowsFormsApplication1
{
    public class Team
    {
        public string Name { get; private set; }
        public string League { get; private set; }
        public int Titles { get; private set; }
        public string Manager { get; private set; }
        public string Captain { get; private set; }
        public string Position { get; private set; }

        public Team(string name, string league, int titles, string manager, string captain, string position)
        {
            Name = name;
            League = league;
            Titles = titles;
            Manager = manager;
            Captain = captain;
            Position = position;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
