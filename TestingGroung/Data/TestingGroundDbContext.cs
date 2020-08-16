using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingGroung.Model;

namespace TestingGroung.Data
{
    public class TestingGroundDbContext : DbContext
    {
        public TestingGroundDbContext(DbContextOptions<TestingGroundDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons  { get; set; }

    }
}
