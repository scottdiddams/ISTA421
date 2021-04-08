using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPQuiz10.Models
{
    public static class PeopleRepository
    {
        private static List<Person> newpeople = new List<Person>();
        public static IEnumerable<Person> NewPeople => newpeople;
        public static void AddResponse(Person newperson)
        {
            newpeople.Add(newperson);
        }
    }
}
