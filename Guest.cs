using System;
//class Guest
namespace DinnerParty
{
    public class Guest
    {
        //Properties
        public string name { get; set; }
        public string occupation { get; set; }
        public string bio { get; set; }

        //Constructor
        public Guest(string Name, string Occupation, string Bio)
        {
            name = Name;
            occupation = Occupation;
            bio = Bio;
        }

    }
}