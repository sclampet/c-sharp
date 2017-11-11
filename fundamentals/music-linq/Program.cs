using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var mountVernonArtist = from person in Artists
                                    where person.Hometown == "Mount Vernon"
                                    select new {person.ArtistName, person.Age};
            System.Console.WriteLine(mountVernonArtist);

            //Who is the youngest artist in our collection of artists?
            var youngest = from young in Artists
                            orderby young.Age ascending
                            select Artists.First();

            //Display all artists with 'William' somewhere in their real name
            var williams = Artists.Where(n => {
                if(n.RealName.Contains("William"))
                {
                    return true;
                }
                return false;
            });

            //Display the 3 oldest artist from Atlanta
            var oldAtl = from emcees in Artists
                            where emcees.Hometown == "Atlanta"
                            orderby emcees.Age descending
                            select Artists.Take(3);

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
                            

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
