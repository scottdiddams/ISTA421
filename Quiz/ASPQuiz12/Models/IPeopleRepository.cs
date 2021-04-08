using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPQuiz10.Models
{
    public interface IPeopleRepository
    {
        IQueryable<Person> People { get; }
    }
}
