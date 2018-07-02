using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //=========================================================
            //Solve all of the prompts below using various LINQ queries
            //=========================================================

            //=========================================================
            //There is only one artist in this collection from Mount 
            //Vernon. What is their name and age?
            //=========================================================

            object person = (from a in Artists where a.Hometown == "Mount Vernon" select a).SingleOrDefault();
            System.Console.WriteLine((person as Artist).RealName+" "+(person as Artist).Age);
            
            //=========================================================
            //Who is the youngest artist in our collection of artists?
            //=========================================================
            
            int minVal = Artists.Select(x => x.Age).Min();
            object personMin = (from a in Artists where a.Age == minVal select a).SingleOrDefault();
            System.Console.WriteLine((personMin as Artist).RealName+" "+(personMin as Artist).Age);         

            //=========================================================
            //Display all artists with 'William' somewhere in their 
            //real name        
            //=========================================================

            List<Artist> wills = Artists.Where(a => a.RealName.Contains("William")).ToList();
            for(int i=0;i<wills.Count;i++){
                System.Console.WriteLine(wills[i].RealName+" "+wills[i].Age);
            }

            //=========================================================
            //Display all groups with names less than 8 characters
            //=========================================================

            List<Group> lessThan = Groups.Where(g => g.GroupName.Length < 8).ToList();
            for(int i=0;i<lessThan.Count;i++){
                System.Console.WriteLine(lessThan[i].GroupName);
            }

            //=========================================================
            //Display the 3 oldest artists from Atlanta
            //=========================================================
            
            List<Artist> oldArt = Artists.OrderBy(a => a.Age).TakeLast(3).ToList();
            for(int i=0;i<oldArt.Count;i++){
                System.Console.WriteLine(oldArt[i].RealName+" "+oldArt[i].Age);
            }
            //=========================================================
            //(Optional) Display the Group Name of all groups that have 
            //at least one member not from New York City
            //=========================================================

            //=========================================================
            //(Optional) Display the artist names of all members of the 
            //group 'Wu-Tang Clan'
            //=========================================================
        }
    }
}
