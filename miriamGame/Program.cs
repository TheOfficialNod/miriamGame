using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miriamGame
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            Random rnd = new Random();
            int randomEvent = rnd.Next(0, 2); //Creates random number between 0 and 9

            var eventList = new List<string> { "You find an abandoned caravan do you look to find something", "You find an abandoned car do you want to search it", "Theres a wanderer in your path do you approach him" };
            var firstItem = eventList.ElementAt(randomEvent);
            //List<string> events = new List<string>();
            //events.Add("You find an abandoned caravan do you look to find something");
            //events.Add("You find an abandoned car do you want to search it");
            //events.Add("Theres a wanderer in your path do you approach him");

            int hunger = 15;
            int thirst = 7;

            if (hunger > 0 && thirst > 0)
            {
                string hungerStr = hunger.ToString();
                string thirstStr = thirst.ToString();
                Form1._Form1.update(firstItem);
                Form1._Form1.update("\nYou have " + hungerStr + " hunger left\n" + "You have " + thirstStr + " thirst left\n");
            }
            else
            {
                Form1._Form1.update("You died");
            }
        }
    }
}
