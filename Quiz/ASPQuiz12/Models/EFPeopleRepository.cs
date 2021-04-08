using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPQuiz10.Models
{
    public class EFPeopleRepository: IPeopleRepository
    {
        private PeopleDbContext context;
        public EFPeopleRepository(PeopleDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Person> People => context.People;
    }
}
