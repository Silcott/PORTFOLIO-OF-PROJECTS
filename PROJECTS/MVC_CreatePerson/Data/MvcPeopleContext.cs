using Microsoft.EntityFrameworkCore;
using MVC_CreatePerson.Models;

namespace MVC_CreatePerson.Data
{
    public class MvcPeopleContext : DbContext
    {
        public MvcPeopleContext(DbContextOptions<MvcPeopleContext> options)
            : base(options)
        {
        }
        public DbSet<Person>Persons { get; set; }
    }
}
