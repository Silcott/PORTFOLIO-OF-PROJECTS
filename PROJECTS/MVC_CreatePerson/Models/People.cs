using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CreatePerson.Models
{
    public static class People
    {
        public static List<Person> PeopleList = new List<Person>();

        public static void AddDefaultNames()
        {
            PeopleList.Add(new Person { FirstName = "James", LastName = "Silcott", Gender = "Male", Age = 42});
            PeopleList.Add(new Person { FirstName = "Paul", LastName = "Atreides", Gender = "Male", Age = 40 });
            PeopleList.Add(new Person { FirstName = "Sloth", LastName = "Goonie", Gender = "Male", Age = 35 });
            PeopleList.Add(new Person { FirstName = "Princess", LastName = "Leia", Gender = "Female", Age = 22 });
            PeopleList.Add(new Person { FirstName = "Short", LastName = "Round", Gender = "Male", Age = 12 });
        }
    }
}
