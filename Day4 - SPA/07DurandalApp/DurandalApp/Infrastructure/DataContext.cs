using DurandalApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DurandalApp.Infrastructure
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public IDbSet<Movie> Movies { get; set; }
    }
}