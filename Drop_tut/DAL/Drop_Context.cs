using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Drop_tut.Models;

namespace Drop_tut.DAL
{
    public class Drop_Context: DbContext
    {
        public Drop_Context():base("DropConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}