using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize a dictionary with the two tables
            Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>()
            {
                {"Table 1", new List<Guest>()}, {"Table 2", new List<Guest>()}
            };

            //initialize a list of guests
            List<Guest> guests = getGuests();

            //add the guests to the tables, making sure each table doesn't have more than one of the same occupation
            foreach (Guest guest in guests)
            {
                //get all of table1's occupations
                List<string> table1Occupations = tables["Table 1"].Select(g => g.occupation).ToList();
                //add guest to table 2 if their occupation is already at table 1
                if(table1Occupations.Contains(guest.occupation))
                {
                    tables["Table 2"].Add(guest);
                }
                //else, add the guest to table 1
                else
                {
                    tables["Table 1"].Add(guest);
                }
            }

            //Log the guests by table
            foreach(string tableName in tables.Keys)
            {
                //log the current table name
                List<Guest> tableGuests = tables[tableName];
                Console.WriteLine(tableName);

                //log each guest of the current table
                foreach (Guest guest in tableGuests)
                {
                    Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
                }
            }

        }

        //returns a list of guests
        static List<Guest> getGuests()
        {
            return new List<Guest>()
            {
                {new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model")},
                {new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war")},
                {new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner")},
                {new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist")},
                {new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian")},
                {new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world")},
                {new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds")},
                {new Guest("Indira Gandhi","politician","(1917 - 1984) Prime Minister of India 1966 - 1977")}
            };
        }
    }
}
